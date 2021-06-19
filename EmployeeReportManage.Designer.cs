namespace Assignment
{
    partial class EmployeeReportManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.dgvDetails = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.refreshButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.newButton = new MetroFramework.Controls.MetroButton();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgReportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDrugs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLabResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1164, 731);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.metroPanel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.metroPanel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(867, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(294, 725);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.txtPatientName);
            this.metroPanel3.Controls.Add(this.labelPatientName);
            this.metroPanel3.Controls.Add(this.txtReportDate);
            this.metroPanel3.Controls.Add(this.txtLabResult);
            this.metroPanel3.Controls.Add(this.txtDrug);
            this.metroPanel3.Controls.Add(this.txtPatientID);
            this.metroPanel3.Controls.Add(this.txtID);
            this.metroPanel3.Controls.Add(this.labelLabResult);
            this.metroPanel3.Controls.Add(this.labelDrug);
            this.metroPanel3.Controls.Add(this.labelPatientID);
            this.metroPanel3.Controls.Add(this.labelReportDate);
            this.metroPanel3.Controls.Add(this.labelID);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 62);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(288, 660);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
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
            this.txtPatientName.Location = new System.Drawing.Point(90, 82);
            this.txtPatientName.MaxLength = 32767;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PasswordChar = '\0';
            this.txtPatientName.PromptText = "Patient Name";
            this.txtPatientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.SelectionLength = 0;
            this.txtPatientName.SelectionStart = 0;
            this.txtPatientName.ShortcutsEnabled = true;
            this.txtPatientName.Size = new System.Drawing.Size(191, 23);
            this.txtPatientName.TabIndex = 16;
            this.txtPatientName.UseSelectable = true;
            this.txtPatientName.WaterMark = "Patient Name";
            this.txtPatientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPatientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Location = new System.Drawing.Point(-4, 82);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(95, 19);
            this.labelPatientName.TabIndex = 15;
            this.labelPatientName.Text = "Patient Name :";
            // 
            // txtReportDate
            // 
            this.txtReportDate.Location = new System.Drawing.Point(93, 143);
            this.txtReportDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtReportDate.Name = "txtReportDate";
            this.txtReportDate.Size = new System.Drawing.Size(189, 29);
            this.txtReportDate.TabIndex = 14;
            // 
            // txtLabResult
            // 
            this.txtLabResult.Location = new System.Drawing.Point(83, 375);
            this.txtLabResult.Name = "txtLabResult";
            this.txtLabResult.Size = new System.Drawing.Size(191, 51);
            this.txtLabResult.TabIndex = 13;
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
            this.txtDrug.Location = new System.Drawing.Point(93, 261);
            this.txtDrug.MaxLength = 32767;
            this.txtDrug.Name = "txtDrug";
            this.txtDrug.PasswordChar = '\0';
            this.txtDrug.PromptText = "Drug";
            this.txtDrug.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDrug.SelectedText = "";
            this.txtDrug.SelectionLength = 0;
            this.txtDrug.SelectionStart = 0;
            this.txtDrug.ShortcutsEnabled = true;
            this.txtDrug.Size = new System.Drawing.Size(191, 23);
            this.txtDrug.TabIndex = 11;
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
            this.txtPatientID.Location = new System.Drawing.Point(93, 203);
            this.txtPatientID.MaxLength = 32767;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PasswordChar = '\0';
            this.txtPatientID.PromptText = "Patient ID";
            this.txtPatientID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPatientID.SelectedText = "";
            this.txtPatientID.SelectionLength = 0;
            this.txtPatientID.SelectionStart = 0;
            this.txtPatientID.ShortcutsEnabled = true;
            this.txtPatientID.Size = new System.Drawing.Size(191, 23);
            this.txtPatientID.TabIndex = 10;
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
            this.txtID.Location = new System.Drawing.Point(92, 28);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PromptText = "Auto Generate";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(191, 23);
            this.txtID.TabIndex = 8;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMark = "Auto Generate";
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelLabResult
            // 
            this.labelLabResult.AutoSize = true;
            this.labelLabResult.Location = new System.Drawing.Point(3, 387);
            this.labelLabResult.Name = "labelLabResult";
            this.labelLabResult.Size = new System.Drawing.Size(75, 19);
            this.labelLabResult.TabIndex = 7;
            this.labelLabResult.Text = "Lab Result :";
            // 
            // labelDrug
            // 
            this.labelDrug.AutoSize = true;
            this.labelDrug.Location = new System.Drawing.Point(42, 261);
            this.labelDrug.Name = "labelDrug";
            this.labelDrug.Size = new System.Drawing.Size(45, 19);
            this.labelDrug.TabIndex = 5;
            this.labelDrug.Text = "Drug :";
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Location = new System.Drawing.Point(15, 203);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(71, 19);
            this.labelPatientID.TabIndex = 4;
            this.labelPatientID.Text = "Patient ID :";
            // 
            // labelReportDate
            // 
            this.labelReportDate.AutoSize = true;
            this.labelReportDate.Location = new System.Drawing.Point(-1, 145);
            this.labelReportDate.Name = "labelReportDate";
            this.labelReportDate.Size = new System.Drawing.Size(88, 19);
            this.labelReportDate.TabIndex = 3;
            this.labelReportDate.Text = "Report Date :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(69, 28);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 19);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID :";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.updateButton);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(288, 53);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(129, 16);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.metroPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(858, 725);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.dgvDetails);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(3, 62);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(852, 660);
            this.metroPanel4.TabIndex = 1;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AllowUserToResizeRows = false;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvPatientID,
            this.dgvPatientName,
            this.dgReportDate,
            this.dgvDrugs,
            this.dgvLabResult});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.EnableHeadersVisualStyles = false;
            this.dgvDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(850, 658);
            this.dgvDetails.TabIndex = 2;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtSearch);
            this.metroPanel1.Controls.Add(this.searchButton);
            this.metroPanel1.Controls.Add(this.refreshButton);
            this.metroPanel1.Controls.Add(this.deleteButton);
            this.metroPanel1.Controls.Add(this.newButton);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(852, 53);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(368, 16);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(183, 23);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(557, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseSelectable = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(174, 16);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseSelectable = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(93, 16);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 16);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "New";
            this.newButton.UseSelectable = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvID.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 80;
            // 
            // dgvPatientID
            // 
            this.dgvPatientID.DataPropertyName = "PatientID";
            this.dgvPatientID.HeaderText = "PatientID";
            this.dgvPatientID.Name = "dgvPatientID";
            this.dgvPatientID.ReadOnly = true;
            // 
            // dgvPatientName
            // 
            this.dgvPatientName.DataPropertyName = "PatientName";
            this.dgvPatientName.HeaderText = "Patient Name";
            this.dgvPatientName.Name = "dgvPatientName";
            this.dgvPatientName.ReadOnly = true;
            // 
            // dgReportDate
            // 
            this.dgReportDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgReportDate.DataPropertyName = "ReportDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgReportDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgReportDate.HeaderText = "Report Date";
            this.dgReportDate.Name = "dgReportDate";
            this.dgReportDate.ReadOnly = true;
            // 
            // dgvDrugs
            // 
            this.dgvDrugs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDrugs.DataPropertyName = "Drugs";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDrugs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDrugs.HeaderText = "Drugs";
            this.dgvDrugs.Name = "dgvDrugs";
            this.dgvDrugs.ReadOnly = true;
            // 
            // dgvLabResult
            // 
            this.dgvLabResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvLabResult.DataPropertyName = "LabResult";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvLabResult.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLabResult.HeaderText = "Lab Result";
            this.dgvLabResult.Name = "dgvLabResult";
            this.dgvLabResult.ReadOnly = true;
            // 
            // EmployeeReportManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 731);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeReportManage";
            this.Text = "Patirnt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeReportManage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroButton refreshButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton newButton;
        private MetroFramework.Controls.MetroGrid dgvDetails;
        private MetroFramework.Controls.MetroButton updateButton;
        private System.Windows.Forms.RichTextBox txtLabResult;
        private MetroFramework.Controls.MetroTextBox txtDrug;
        private MetroFramework.Controls.MetroTextBox txtPatientID;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel labelLabResult;
        private MetroFramework.Controls.MetroLabel labelDrug;
        private MetroFramework.Controls.MetroLabel labelPatientID;
        private MetroFramework.Controls.MetroLabel labelReportDate;
        private MetroFramework.Controls.MetroLabel labelID;
        private MetroFramework.Controls.MetroDateTime txtReportDate;
        private MetroFramework.Controls.MetroTextBox txtPatientName;
        private MetroFramework.Controls.MetroLabel labelPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgReportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDrugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLabResult;
    }
}