namespace NewBRO
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btMenu = new System.Windows.Forms.Button();
            this.gbxPassword = new System.Windows.Forms.GroupBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.lbNew = new System.Windows.Forms.Label();
            this.tbCPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbxPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(15, 20);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(436, 54);
            this.lbTitle.TabIndex = 33;
            this.lbTitle.Text = "Book Recovery System";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(725, 20);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(327, 78);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 32;
            this.pbLogo.TabStop = false;
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(852, 464);
            this.btMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(175, 53);
            this.btMenu.TabIndex = 31;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // gbxPassword
            // 
            this.gbxPassword.Controls.Add(this.btConfirm);
            this.gbxPassword.Controls.Add(this.lbConfirm);
            this.gbxPassword.Controls.Add(this.lbNew);
            this.gbxPassword.Controls.Add(this.tbCPassword);
            this.gbxPassword.Controls.Add(this.tbPassword);
            this.gbxPassword.Location = new System.Drawing.Point(313, 162);
            this.gbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPassword.Name = "gbxPassword";
            this.gbxPassword.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPassword.Size = new System.Drawing.Size(441, 278);
            this.gbxPassword.TabIndex = 30;
            this.gbxPassword.TabStop = false;
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(143, 198);
            this.btConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(132, 46);
            this.btConfirm.TabIndex = 4;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbConfirm
            // 
            this.lbConfirm.AutoSize = true;
            this.lbConfirm.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirm.Location = new System.Drawing.Point(8, 107);
            this.lbConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(225, 33);
            this.lbConfirm.TabIndex = 8;
            this.lbConfirm.Text = "Confirm Password:";
            // 
            // lbNew
            // 
            this.lbNew.AutoSize = true;
            this.lbNew.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNew.Location = new System.Drawing.Point(8, 49);
            this.lbNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNew.Name = "lbNew";
            this.lbNew.Size = new System.Drawing.Size(187, 33);
            this.lbNew.TabIndex = 7;
            this.lbNew.Text = "New Password:";
            // 
            // tbCPassword
            // 
            this.tbCPassword.Location = new System.Drawing.Point(236, 114);
            this.tbCPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbCPassword.Name = "tbCPassword";
            this.tbCPassword.Size = new System.Drawing.Size(192, 22);
            this.tbCPassword.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(236, 57);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(192, 22);
            this.tbPassword.TabIndex = 5;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.gbxPassword);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbxPassword.ResumeLayout(false);
            this.gbxPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.GroupBox gbxPassword;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.Label lbNew;
        private System.Windows.Forms.TextBox tbCPassword;
        private System.Windows.Forms.TextBox tbPassword;
    }
}