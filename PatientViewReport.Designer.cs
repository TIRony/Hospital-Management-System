namespace Assignment
{
    partial class PatientViewReport
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.buttonRefresh = new MetroFramework.Controls.MetroButton();
            this.txtPatientName = new MetroFramework.Controls.MetroTextBox();
            this.labelPatientName = new MetroFramework.Controls.MetroLabel();
            this.txtReportDate = new MetroFramework.Controls.MetroDateTime();
            this.txtLabResult = new System.Windows.Forms.RichTextBox();
            this.txtDrug = new MetroFramework.Controls.MetroTextBox();
            this.txtPatientID = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.labelLabResult = new MetroFramework.Controls.MetroLabel();
            this.labelDrug = new MetroFramework.Controls.MetroLabel();
            this.labelPatientID = new MetroFramework.Controls.MetroLabel();
            this.labelReportDate = new MetroFramework.Controls.MetroLabel();
            this.labelID = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1000F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1365, 646);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.buttonRefresh);
            this.metroPanel1.Controls.Add(this.txtPatientName);
            this.metroPanel1.Controls.Add(this.labelPatientName);
            this.metroPanel1.Controls.Add(this.txtReportDate);
            this.metroPanel1.Controls.Add(this.txtLabResult);
            this.metroPanel1.Controls.Add(this.txtDrug);
            this.metroPanel1.Controls.Add(this.txtPatientID);
            this.metroPanel1.Controls.Add(this.txtID);
            this.metroPanel1.Controls.Add(this.labelLabResult);
            this.metroPanel1.Controls.Add(this.labelDrug);
            this.metroPanel1.Controls.Add(this.labelPatientID);
            this.metroPanel1.Controls.Add(this.labelReportDate);
            this.metroPanel1.Controls.Add(this.labelID);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(185, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(994, 640);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonRefresh.Location = new System.Drawing.Point(475, 532);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 29;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseSelectable = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // txtPatientName
            // 
            // 
            // 
            // 
            this.txtPatientName.CustomButton.Image = null;
            this.txtPatientName.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtPatientName.CustomButton.Name = "";
            this.txtPatientName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatientName.CustomButton.TabIndex = 1;
            this.txtPatientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatientName.CustomButton.UseSelectable = true;
            this.txtPatientName.CustomButton.Visible = false;
            this.txtPatientName.Lines = new string[0];
            this.txtPatientName.Location = new System.Drawing.Point(447, 203);
            this.txtPatientName.MaxLength = 32767;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PasswordChar = '\0';
            this.txtPatientName.PromptText = "Patient Name";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.SelectionLength = 0;
            this.txtPatientName.SelectionStart = 0;
            this.txtPatientName.ShortcutsEnabled = true;
            this.txtPatientName.Size = new System.Drawing.Size(191, 23);
            this.txtPatientName.TabIndex = 28;
            this.txtPatientName.UseSelectable = true;
            this.txtPatientName.WaterMark = "Patient Name";
            this.txtPatientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Location = new System.Drawing.Point(353, 203);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(95, 19);
            this.labelPatientName.TabIndex = 27;
            this.labelPatientName.Text = "Patient Name :";
            // 
            // txtReportDate
            // 
            this.txtReportDate.Location = new System.Drawing.Point(450, 264);
            this.txtReportDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtReportDate.Name = "txtReportDate";
            this.txtReportDate.Size = new System.Drawing.Size(189, 29);
            this.txtReportDate.TabIndex = 26;
            // 
            // txtLabResult
            // 
            this.txtLabResult.Location = new System.Drawing.Point(449, 440);
            this.txtLabResult.Name = "txtLabResult";
            this.txtLabResult.ReadOnly = true;
            this.txtLabResult.Size = new System.Drawing.Size(191, 51);
            this.txtLabResult.TabIndex = 25;
            this.txtLabResult.Text = "";
            // 
            // txtDrug
            // 
            // 
            // 
            // 
            this.txtDrug.CustomButton.Image = null;
            this.txtDrug.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtDrug.CustomButton.Name = "";
            this.txtDrug.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDrug.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDrug.CustomButton.TabIndex = 1;
            this.txtDrug.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDrug.CustomButton.UseSelectable = true;
            this.txtDrug.CustomButton.Visible = false;
            this.txtDrug.Lines = new string[0];
            this.txtDrug.Location = new System.Drawing.Point(450, 382);
            this.txtDrug.MaxLength = 32767;
            this.txtDrug.Name = "txtDrug";
            this.txtDrug.PasswordChar = '\0';
            this.txtDrug.PromptText = "Drug";
            this.txtDrug.ReadOnly = true;
            this.txtDrug.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDrug.SelectedText = "";
            this.txtDrug.SelectionLength = 0;
            this.txtDrug.SelectionStart = 0;
            this.txtDrug.ShortcutsEnabled = true;
            this.txtDrug.Size = new System.Drawing.Size(191, 23);
            this.txtDrug.TabIndex = 24;
            this.txtDrug.UseSelectable = true;
            this.txtDrug.WaterMark = "Drug";
            this.txtDrug.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDrug.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPatientID
            // 
            // 
            // 
            // 
            this.txtPatientID.CustomButton.Image = null;
            this.txtPatientID.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtPatientID.CustomButton.Name = "";
            this.txtPatientID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPatientID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPatientID.CustomButton.TabIndex = 1;
            this.txtPatientID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPatientID.CustomButton.UseSelectable = true;
            this.txtPatientID.CustomButton.Visible = false;
            this.txtPatientID.Lines = new string[0];
            this.txtPatientID.Location = new System.Drawing.Point(450, 324);
            this.txtPatientID.MaxLength = 32767;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PasswordChar = '\0';
            this.txtPatientID.PromptText = "Patient ID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientID.SelectedText = "";
            this.txtPatientID.SelectionLength = 0;
            this.txtPatientID.SelectionStart = 0;
            this.txtPatientID.ShortcutsEnabled = true;
            this.txtPatientID.Size = new System.Drawing.Size(191, 23);
            this.txtPatientID.TabIndex = 23;
            this.txtPatientID.UseSelectable = true;
            this.txtPatientID.WaterMark = "Patient ID";
            this.txtPatientID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatientID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(449, 149);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PromptText = "Auto Generate";
            this.txtID.ReadOnly = true;
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(191, 23);
            this.txtID.TabIndex = 22;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMark = "Auto Generate";
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelLabResult
            // 
            this.labelLabResult.AutoSize = true;
            this.labelLabResult.Location = new System.Drawing.Point(369, 452);
            this.labelLabResult.Name = "labelLabResult";
            this.labelLabResult.Size = new System.Drawing.Size(75, 19);
            this.labelLabResult.TabIndex = 21;
            this.labelLabResult.Text = "Lab Result :";
            // 
            // labelDrug
            // 
            this.labelDrug.AutoSize = true;
            this.labelDrug.Location = new System.Drawing.Point(399, 382);
            this.labelDrug.Name = "labelDrug";
            this.labelDrug.Size = new System.Drawing.Size(45, 19);
            this.labelDrug.TabIndex = 20;
            this.labelDrug.Text = "Drug :";
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Location = new System.Drawing.Point(372, 324);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(71, 19);
            this.labelPatientID.TabIndex = 19;
            this.labelPatientID.Text = "Patient ID :";
            // 
            // labelReportDate
            // 
            this.labelReportDate.AutoSize = true;
            this.labelReportDate.Location = new System.Drawing.Point(356, 266);
            this.labelReportDate.Name = "labelReportDate";
            this.labelReportDate.Size = new System.Drawing.Size(88, 19);
            this.labelReportDate.TabIndex = 18;
            this.labelReportDate.Text = "Report Date :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(426, 149);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 19);
            this.labelID.TabIndex = 17;
            this.labelID.Text = "ID :";
            // 
            // PatientViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 646);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PatientViewReport";
            this.Text = "PatientViewReport";
            this.Load += new System.EventHandler(this.PatientViewReport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtPatientName;
        private MetroFramework.Controls.MetroLabel labelPatientName;
        private MetroFramework.Controls.MetroDateTime txtReportDate;
        private System.Windows.Forms.RichTextBox txtLabResult;
        private MetroFramework.Controls.MetroTextBox txtDrug;
        private MetroFramework.Controls.MetroTextBox txtPatientID;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel labelLabResult;
        private MetroFramework.Controls.MetroLabel labelDrug;
        private MetroFramework.Controls.MetroLabel labelPatientID;
        private MetroFramework.Controls.MetroLabel labelReportDate;
        private MetroFramework.Controls.MetroLabel labelID;
        private MetroFramework.Controls.MetroButton buttonRefresh;
    }
}