namespace NewBRO
{
    partial class Borrowers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrowers));
            this.btMenu = new System.Windows.Forms.Button();
            this.lbBorrowers = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btExisting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(639, 377);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(131, 43);
            this.btMenu.TabIndex = 17;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // lbBorrowers
            // 
            this.lbBorrowers.AutoSize = true;
            this.lbBorrowers.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowers.Location = new System.Drawing.Point(336, 126);
            this.lbBorrowers.Name = "lbBorrowers";
            this.lbBorrowers.Size = new System.Drawing.Size(135, 33);
            this.lbBorrowers.TabIndex = 13;
            this.lbBorrowers.Text = "Borrowers";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(232, 82);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(350, 42);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Book Recovery System";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(543, 1);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(245, 63);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // btNew
            // 
            this.btNew.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Location = new System.Drawing.Point(293, 174);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(206, 43);
            this.btNew.TabIndex = 18;
            this.btNew.Text = "Add New Borrower";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btExisting
            // 
            this.btExisting.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExisting.Location = new System.Drawing.Point(293, 275);
            this.btExisting.Name = "btExisting";
            this.btExisting.Size = new System.Drawing.Size(206, 43);
            this.btExisting.TabIndex = 19;
            this.btExisting.Text = "Existing Borrowers";
            this.btExisting.UseVisualStyleBackColor = true;
            this.btExisting.Click += new System.EventHandler(this.btExisting_Click);
            // 
            // Borrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(796, 456);
            this.Controls.Add(this.btExisting);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.lbBorrowers);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Borrowers";
            this.Text = "Borrowers";
            this.Load += new System.EventHandler(this.Borrowers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Label lbBorrowers;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btExisting;
    }
}