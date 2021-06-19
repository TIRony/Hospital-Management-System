namespace Assignment
{
    partial class DoctorMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.treatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySelfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoctorMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.buttonImageSave = new MetroFramework.Controls.MetroButton();
            this.txtbackImage = new MetroFramework.Controls.MetroTextBox();
            this.BackImage = new MetroFramework.Controls.MetroButton();
            this.buttonLogout = new MetroFramework.Controls.MetroButton();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.DoctorMenuPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.mySelfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treatToolStripMenuItem
            // 
            this.treatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.treatToolStripMenuItem.Name = "treatToolStripMenuItem";
            this.treatToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.treatToolStripMenuItem.Text = "Treat";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // mySelfToolStripMenuItem
            // 
            this.mySelfToolStripMenuItem.Name = "mySelfToolStripMenuItem";
            this.mySelfToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.mySelfToolStripMenuItem.Text = "My Self";
            this.mySelfToolStripMenuItem.Click += new System.EventHandler(this.mySelfToolStripMenuItem_Click);
            // 
            // DoctorMenuPanel
            // 
            this.DoctorMenuPanel.ColumnCount = 1;
            this.DoctorMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DoctorMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoctorMenuPanel.Controls.Add(this.metroPanel1, 0, 1);
            this.DoctorMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorMenuPanel.Location = new System.Drawing.Point(0, 24);
            this.DoctorMenuPanel.Name = "DoctorMenuPanel";
            this.DoctorMenuPanel.RowCount = 2;
            this.DoctorMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DoctorMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.DoctorMenuPanel.Size = new System.Drawing.Size(774, 532);
            this.DoctorMenuPanel.TabIndex = 1;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.buttonImageSave);
            this.metroPanel1.Controls.Add(this.txtbackImage);
            this.metroPanel1.Controls.Add(this.BackImage);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 485);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(768, 44);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // buttonImageSave
            // 
            this.buttonImageSave.BackColor = System.Drawing.Color.Yellow;
            this.buttonImageSave.Location = new System.Drawing.Point(330, 18);
            this.buttonImageSave.Name = "buttonImageSave";
            this.buttonImageSave.Size = new System.Drawing.Size(75, 23);
            this.buttonImageSave.TabIndex = 4;
            this.buttonImageSave.Text = "Save";
            this.buttonImageSave.UseSelectable = true;
            this.buttonImageSave.Click += new System.EventHandler(this.buttonImageSave_Click);
            // 
            // txtbackImage
            // 
            // 
            // 
            // 
            this.txtbackImage.CustomButton.Image = null;
            this.txtbackImage.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtbackImage.CustomButton.Name = "";
            this.txtbackImage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbackImage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbackImage.CustomButton.TabIndex = 1;
            this.txtbackImage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbackImage.CustomButton.UseSelectable = true;
            this.txtbackImage.CustomButton.Visible = false;
            this.txtbackImage.Lines = new string[0];
            this.txtbackImage.Location = new System.Drawing.Point(128, 18);
            this.txtbackImage.MaxLength = 32767;
            this.txtbackImage.Name = "txtbackImage";
            this.txtbackImage.PasswordChar = '\0';
            this.txtbackImage.PromptText = "Image Path";
            this.txtbackImage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbackImage.SelectedText = "";
            this.txtbackImage.SelectionLength = 0;
            this.txtbackImage.SelectionStart = 0;
            this.txtbackImage.ShortcutsEnabled = true;
            this.txtbackImage.Size = new System.Drawing.Size(183, 23);
            this.txtbackImage.TabIndex = 3;
            this.txtbackImage.UseSelectable = true;
            this.txtbackImage.WaterMark = "Image Path";
            this.txtbackImage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbackImage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BackImage
            // 
            this.BackImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackImage.Location = new System.Drawing.Point(3, 6);
            this.BackImage.Name = "BackImage";
            this.BackImage.Size = new System.Drawing.Size(119, 35);
            this.BackImage.TabIndex = 2;
            this.BackImage.Text = "Set wallpaper";
            this.BackImage.UseSelectable = true;
            this.BackImage.Click += new System.EventHandler(this.BackImage_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(638, 0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseSelectable = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelWelcome.Location = new System.Drawing.Point(349, 8);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(59, 13);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome";
            // 
            // DoctorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 556);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.DoctorMenuPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoctorMenu";
            this.Text = "DoctorMenu";
            this.Load += new System.EventHandler(this.DoctorMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DoctorMenuPanel.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel DoctorMenuPanel;
        private System.Windows.Forms.ToolStripMenuItem treatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySelfToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton buttonImageSave;
        private MetroFramework.Controls.MetroTextBox txtbackImage;
        private MetroFramework.Controls.MetroButton BackImage;
        private MetroFramework.Controls.MetroButton buttonLogout;
        private System.Windows.Forms.Label labelWelcome;
    }
}