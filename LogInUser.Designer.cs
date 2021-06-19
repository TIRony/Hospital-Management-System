namespace Assignment
{
    partial class LogInUser
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
            this.AllPanel = new MetroFramework.Controls.MetroPanel();
            this.labelPassword = new MetroFramework.Controls.MetroLabel();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonLogin = new MetroFramework.Controls.MetroButton();
            this.labelUserName = new MetroFramework.Controls.MetroLabel();
            this.txtLoginUserName = new MetroFramework.Controls.MetroTextBox();
            this.buttonExit = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AllPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllPanel
            // 
            this.AllPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllPanel.Controls.Add(this.labelPassword);
            this.AllPanel.Controls.Add(this.buttonSignUp);
            this.AllPanel.Controls.Add(this.buttonLogin);
            this.AllPanel.Controls.Add(this.labelUserName);
            this.AllPanel.Controls.Add(this.txtLoginUserName);
            this.AllPanel.Controls.Add(this.buttonExit);
            this.AllPanel.Controls.Add(this.txtPassword);
            this.AllPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllPanel.HorizontalScrollbarBarColor = true;
            this.AllPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AllPanel.HorizontalScrollbarSize = 10;
            this.AllPanel.Location = new System.Drawing.Point(3, 3);
            this.AllPanel.Name = "AllPanel";
            this.AllPanel.Size = new System.Drawing.Size(1628, 575);
            this.AllPanel.TabIndex = 0;
            this.AllPanel.VerticalScrollbarBarColor = true;
            this.AllPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AllPanel.VerticalScrollbarSize = 10;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(180, 185);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 19);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password :";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSignUp.Location = new System.Drawing.Point(581, 374);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(147, 33);
            this.buttonSignUp.TabIndex = 8;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(295, 299);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(118, 34);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseSelectable = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(160, 111);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(90, 19);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = " User Name : ";
            // 
            // txtLoginUserName
            // 
            // 
            // 
            // 
            this.txtLoginUserName.CustomButton.Image = null;
            this.txtLoginUserName.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txtLoginUserName.CustomButton.Name = "";
            this.txtLoginUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLoginUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginUserName.CustomButton.TabIndex = 1;
            this.txtLoginUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginUserName.CustomButton.UseSelectable = true;
            this.txtLoginUserName.CustomButton.Visible = false;
            this.txtLoginUserName.Lines = new string[0];
            this.txtLoginUserName.Location = new System.Drawing.Point(281, 107);
            this.txtLoginUserName.MaxLength = 32767;
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.PasswordChar = '\0';
            this.txtLoginUserName.PromptText = "User Name";
            this.txtLoginUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginUserName.SelectedText = "";
            this.txtLoginUserName.SelectionLength = 0;
            this.txtLoginUserName.SelectionStart = 0;
            this.txtLoginUserName.ShortcutsEnabled = true;
            this.txtLoginUserName.Size = new System.Drawing.Size(299, 23);
            this.txtLoginUserName.TabIndex = 4;
            this.txtLoginUserName.UseSelectable = true;
            this.txtLoginUserName.WaterMark = "User Name";
            this.txtLoginUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(419, 299);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(109, 34);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseSelectable = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(281, 181);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(299, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.AllPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1634, 581);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LogInUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LogInUser";
            this.Text = "Hospital";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogInUser_Load);
            this.AllPanel.ResumeLayout(false);
            this.AllPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel AllPanel;
        private MetroFramework.Controls.MetroTextBox txtLoginUserName;
        private MetroFramework.Controls.MetroLabel labelPassword;
        private MetroFramework.Controls.MetroLabel labelUserName;
        private MetroFramework.Controls.MetroButton buttonExit;
        private MetroFramework.Controls.MetroButton buttonLogin;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSignUp;
    }
}