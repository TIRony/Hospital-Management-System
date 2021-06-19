namespace Assignment
{
    partial class PatientMenu
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
            this.PatientMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.buttonImageSave = new MetroFramework.Controls.MetroButton();
            this.txtbackImage = new MetroFramework.Controls.MetroTextBox();
            this.BackImage = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySelfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.serialQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientMenuPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientMenuPanel
            // 
            this.PatientMenuPanel.ColumnCount = 1;
            this.PatientMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PatientMenuPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.PatientMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientMenuPanel.Location = new System.Drawing.Point(0, 24);
            this.PatientMenuPanel.Name = "PatientMenuPanel";
            this.PatientMenuPanel.RowCount = 2;
            this.PatientMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PatientMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PatientMenuPanel.Size = new System.Drawing.Size(711, 505);
            this.PatientMenuPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 458);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 44);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(399, 38);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // buttonImageSave
            // 
            this.buttonImageSave.BackColor = System.Drawing.Color.Yellow;
            this.buttonImageSave.Location = new System.Drawing.Point(317, 9);
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
            this.txtbackImage.Location = new System.Drawing.Point(128, 9);
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
            // metroPanel2
            // 
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(408, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(294, 38);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.mySelfToolStripMenuItem,
            this.serialQueueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.manageToolStripMenuItem.Text = "My Report";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // mySelfToolStripMenuItem
            // 
            this.mySelfToolStripMenuItem.Name = "mySelfToolStripMenuItem";
            this.mySelfToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.mySelfToolStripMenuItem.Text = "My self";
            this.mySelfToolStripMenuItem.Click += new System.EventHandler(this.mySelfToolStripMenuItem_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLogout.Location = new System.Drawing.Point(583, -4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(128, 28);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelWelcome.Location = new System.Drawing.Point(349, 6);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(59, 13);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome";
            // 
            // serialQueueToolStripMenuItem
            // 
            this.serialQueueToolStripMenuItem.Name = "serialQueueToolStripMenuItem";
            this.serialQueueToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.serialQueueToolStripMenuItem.Text = "Serial Queue";
            this.serialQueueToolStripMenuItem.Click += new System.EventHandler(this.serialQueueToolStripMenuItem_Click);
            // 
            // PatientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 529);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.PatientMenuPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PatientMenu";
            this.Text = "PatientMenu";
            this.Load += new System.EventHandler(this.PatientMenu_Load);
            this.PatientMenuPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PatientMenuPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton buttonImageSave;
        private MetroFramework.Controls.MetroTextBox txtbackImage;
        private MetroFramework.Controls.MetroButton BackImage;
        private System.Windows.Forms.ToolStripMenuItem mySelfToolStripMenuItem;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.ToolStripMenuItem serialQueueToolStripMenuItem;
    }
}