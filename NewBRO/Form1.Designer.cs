namespace NewBRO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbxLogInDetails = new System.Windows.Forms.GroupBox();
            this.btLogIn = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbLogIn = new System.Windows.Forms.Label();
            this.btBorrowers = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btLoans = new System.Windows.Forms.Button();
            this.btReports = new System.Windows.Forms.Button();
            this.btUsers = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbxLogInDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(543, 1);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(245, 63);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(232, 82);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(350, 42);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Book Recovery System";
            // 
            // gbxLogInDetails
            // 
            this.gbxLogInDetails.Controls.Add(this.btLogIn);
            this.gbxLogInDetails.Controls.Add(this.lbPassword);
            this.gbxLogInDetails.Controls.Add(this.lbUsername);
            this.gbxLogInDetails.Controls.Add(this.tbPassword);
            this.gbxLogInDetails.Controls.Add(this.tbUsername);
            this.gbxLogInDetails.Controls.Add(this.lbLogIn);
            this.gbxLogInDetails.Location = new System.Drawing.Point(246, 129);
            this.gbxLogInDetails.Name = "gbxLogInDetails";
            this.gbxLogInDetails.Size = new System.Drawing.Size(300, 291);
            this.gbxLogInDetails.TabIndex = 2;
            this.gbxLogInDetails.TabStop = false;
            this.gbxLogInDetails.Enter += new System.EventHandler(this.gbxLogInDetails_Enter);
            // 
            // btLogIn
            // 
            this.btLogIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogIn.Location = new System.Drawing.Point(94, 174);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(99, 37);
            this.btLogIn.TabIndex = 4;
            this.btLogIn.Text = "Log-In";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(6, 107);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(100, 26);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Password:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(6, 60);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(107, 26);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Username:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(119, 113);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(145, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(119, 66);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(145, 20);
            this.tbUsername.TabIndex = 5;
            // 
            // lbLogIn
            // 
            this.lbLogIn.AutoSize = true;
            this.lbLogIn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogIn.Location = new System.Drawing.Point(63, 16);
            this.lbLogIn.Name = "lbLogIn";
            this.lbLogIn.Size = new System.Drawing.Size(167, 33);
            this.lbLogIn.TabIndex = 4;
            this.lbLogIn.Text = "Log-In Details";
            // 
            // btBorrowers
            // 
            this.btBorrowers.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrowers.Location = new System.Drawing.Point(329, 175);
            this.btBorrowers.Name = "btBorrowers";
            this.btBorrowers.Size = new System.Drawing.Size(131, 43);
            this.btBorrowers.TabIndex = 3;
            this.btBorrowers.Text = "Borrowers";
            this.btBorrowers.UseVisualStyleBackColor = true;
            this.btBorrowers.Click += new System.EventHandler(this.btBorrowers_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.Location = new System.Drawing.Point(353, 124);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(81, 33);
            this.lbMenu.TabIndex = 4;
            this.lbMenu.Text = "Menu";
            // 
            // btLoans
            // 
            this.btLoans.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoans.Location = new System.Drawing.Point(329, 242);
            this.btLoans.Name = "btLoans";
            this.btLoans.Size = new System.Drawing.Size(131, 43);
            this.btLoans.TabIndex = 5;
            this.btLoans.Text = "Loans";
            this.btLoans.UseVisualStyleBackColor = true;
            this.btLoans.Click += new System.EventHandler(this.btLoans_Click);
            // 
            // btReports
            // 
            this.btReports.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReports.Location = new System.Drawing.Point(329, 310);
            this.btReports.Name = "btReports";
            this.btReports.Size = new System.Drawing.Size(131, 43);
            this.btReports.TabIndex = 6;
            this.btReports.Text = "Reports";
            this.btReports.UseVisualStyleBackColor = true;
            this.btReports.Click += new System.EventHandler(this.btReports_Click);
            // 
            // btUsers
            // 
            this.btUsers.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsers.Location = new System.Drawing.Point(329, 377);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(131, 43);
            this.btUsers.TabIndex = 7;
            this.btUsers.Text = "Users";
            this.btUsers.UseVisualStyleBackColor = true;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(639, 377);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(131, 43);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(796, 456);
            this.Controls.Add(this.gbxLogInDetails);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btUsers);
            this.Controls.Add(this.btReports);
            this.Controls.Add(this.btLoans);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.btBorrowers);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbxLogInDetails.ResumeLayout(false);
            this.gbxLogInDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbxLogInDetails;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbLogIn;
        private System.Windows.Forms.Button btBorrowers;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btLoans;
        private System.Windows.Forms.Button btReports;
        private System.Windows.Forms.Button btUsers;
        private System.Windows.Forms.Button btExit;
    }
}

