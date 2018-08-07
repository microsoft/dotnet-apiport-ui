using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PortabilityAnalyzer
{
    public partial class MainForm : Form
    {
        string reportPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var d = new FolderBrowserDialog())
            {
                d.SelectedPath = PathTextBox.Text;

                if (d.ShowDialog() == DialogResult.OK)
                {
                    PathTextBox.Text = d.SelectedPath;
                    AnalyzeButton.Enabled = true;
                }
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            AnalyzeButton.Enabled = false;
            OutputTextBox.Text = string.Empty;

            reportPath = GenerateReportPath();

            var ourPath = Environment.GetCommandLineArgs()[0];
            var ourDirectory = Path.GetDirectoryName(ourPath);
            var apiPortPath = Path.Combine(ourDirectory, "ApiPort", "net461", "win7-x64", "apiport.exe");

            var p = new Process();
            p.StartInfo.FileName = apiPortPath;
            p.StartInfo.Arguments = $"analyze -f \"{PathTextBox.Text}\" -o \"{reportPath}\" -t \".NET Core, Version=3.0\"";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.EnableRaisingEvents = true;

            List<string> msg = new List<string>();

            p.OutputDataReceived += (s, o) =>
            {
                if (o.Data != null)
                {
                    BeginInvoke(new Action(() =>
                    {
                        msg.Add(o.Data);
                    }));
                }
            };

            p.Exited += delegate
            {
                BeginInvoke(new Action(() =>
                {
                    AnalyzeButton.Enabled = true;
                    string text;

                    if (msg.Count != 17) // Was not successful
                    {
                        OpenReportButton.Visible = false;

                        if (msg.Count < 10) // Exception was thrown in the API console tool
                        {
                            text = $"Unable to analyze. The access to the specified path might be denied.";
                        }
                        else
                        {
                            text = msg.FindLast(o => !String.IsNullOrEmpty(o));
                            text = text.Trim(new char[] { '*', ' ' });
                            if (!text.Equals("No files were found to analyze.", StringComparison.InvariantCultureIgnoreCase))
                            {
                                msg.RemoveRange(0, 10);
                                var details = String.Join(Environment.NewLine, msg.ToArray());
                                text = $"Unable to analyze.{Environment.NewLine}Details:{Environment.NewLine}{details}";
                            }
                        }
                    }
                    else // Was successful
                    {
                        text = $"Report saved in: {Environment.NewLine}{reportPath}";
                        OpenReportButton.Visible = true;
                    }

                    OutputTextBox.Text = text;
                    UIline1.Visible = true;
                }));
            };

            p.Start();

            UIline1.Visible = true;
            OutputTextBox.Text = "Analyzing...";

            p.BeginOutputReadLine();
        }

        private static string GenerateReportPath()
        {
            var outputDirectory = Path.GetTempPath();
            var outputName = "PortabilityReport";
            var outputExtension = ".xlsx";
            var counter = 1;
            var outputPath = Path.Combine(outputDirectory, outputName + outputExtension);

            while (File.Exists(outputPath))
            {
                outputPath = Path.Combine(outputDirectory, $"{outputName}({counter}){outputExtension}");
                counter++;
            }

            return outputPath;
        }

        private void BlogLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink(BlogLinkLabel, "https://docs.microsoft.com/en-us/dotnet/standard/analyzers/portability-analyzer");
        }

        private void VisitLink(LinkLabel linkLabel, string url)
        {
            try
            {
                Process.Start(url);
                linkLabel.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open link that was clicked. {ex.Message}");
            }
        }

        private void OpenReportButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(reportPath))
                Process.Start(reportPath);
        }

        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            AnalyzeButton.Enabled = !String.IsNullOrWhiteSpace(PathTextBox.Text);
            UIline1.Visible = false;
            OpenReportButton.Visible = false;
            OutputTextBox.Text = string.Empty;
        }

        private void PrivacyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink(PrivacyLinkLabel, "https://privacy.microsoft.com/en-us/privacystatement");
        }
    }
}
