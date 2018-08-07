namespace PortabilityAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.UIline1 = new System.Windows.Forms.Label();
            this.BlogLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OpenReportButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.UIline2 = new System.Windows.Forms.Label();
            this.PrivacyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PathTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.PathTextBox.Location = new System.Drawing.Point(12, 30);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(425, 20);
            this.PathTextBox.TabIndex = 1;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(441, 29);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(79, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "&Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Path to application folder:";
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnalyzeButton.Enabled = false;
            this.AnalyzeButton.Location = new System.Drawing.Point(441, 60);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(79, 23);
            this.AnalyzeButton.TabIndex = 3;
            this.AnalyzeButton.Text = "&Analyze";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            this.AnalyzeButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // UIline1
            // 
            this.UIline1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UIline1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UIline1.Location = new System.Drawing.Point(12, 90);
            this.UIline1.Name = "UIline1";
            this.UIline1.Size = new System.Drawing.Size(510, 2);
            this.UIline1.TabIndex = 5;
            this.UIline1.Visible = false;
            // 
            // BlogLinkLabel
            // 
            this.BlogLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlogLinkLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BlogLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 15);
            this.BlogLinkLabel.Location = new System.Drawing.Point(444, 156);
            this.BlogLinkLabel.Name = "BlogLinkLabel";
            this.BlogLinkLabel.Size = new System.Drawing.Size(78, 18);
            this.BlogLinkLabel.TabIndex = 8;
            this.BlogLinkLabel.TabStop = true;
            this.BlogLinkLabel.Text = "About this tool";
            this.BlogLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BlogLinkLabel_LinkClicked);
            // 
            // OpenReportButton
            // 
            this.OpenReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenReportButton.Location = new System.Drawing.Point(441, 100);
            this.OpenReportButton.Name = "OpenReportButton";
            this.OpenReportButton.Size = new System.Drawing.Size(79, 23);
            this.OpenReportButton.TabIndex = 9;
            this.OpenReportButton.Text = "&Open Report";
            this.OpenReportButton.UseVisualStyleBackColor = true;
            this.OpenReportButton.Visible = false;
            this.OpenReportButton.Click += new System.EventHandler(this.OpenReportButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTextBox.Location = new System.Drawing.Point(12, 96);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(423, 74);
            this.OutputTextBox.TabIndex = 10;
            this.OutputTextBox.Text = "";
            // 
            // UIline2
            // 
            this.UIline2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UIline2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UIline2.Location = new System.Drawing.Point(12, 182);
            this.UIline2.Name = "UIline2";
            this.UIline2.Size = new System.Drawing.Size(510, 2);
            this.UIline2.TabIndex = 5;
            // 
            // PrivacyLinkLabel
            // 
            this.PrivacyLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrivacyLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(295, 52);
            this.PrivacyLinkLabel.Location = new System.Drawing.Point(12, 200);
            this.PrivacyLinkLabel.Name = "PrivacyLinkLabel";
            this.PrivacyLinkLabel.Size = new System.Drawing.Size(516, 77);
            this.PrivacyLinkLabel.TabIndex = 12;
            this.PrivacyLinkLabel.TabStop = true;
            this.PrivacyLinkLabel.Text = resources.GetString("PrivacyLinkLabel.Text");
            this.PrivacyLinkLabel.UseCompatibleTextRendering = true;
            this.PrivacyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PrivacyLinkLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Privacy";
            // 
            // MainForm
            // 
            this.AcceptButton = this.AnalyzeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrivacyLinkLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.OpenReportButton);
            this.Controls.Add(this.BlogLinkLabel);
            this.Controls.Add(this.UIline2);
            this.Controls.Add(this.UIline1);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.PathTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(545, 321);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NET Core 3.0 Desktop API Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.Label UIline1;
        private System.Windows.Forms.LinkLabel BlogLinkLabel;
        private System.Windows.Forms.Button OpenReportButton;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Label UIline2;
        private System.Windows.Forms.LinkLabel PrivacyLinkLabel;
        private System.Windows.Forms.Label label4;
    }
}

