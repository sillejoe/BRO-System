namespace NewBRO
{
    partial class LoansMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoansMenu));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbLoans = new System.Windows.Forms.Label();
            this.btNewLoan = new System.Windows.Forms.Button();
            this.btCurrent = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(724, 1);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(327, 78);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(309, 101);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(436, 54);
            this.lbTitle.TabIndex = 11;
            this.lbTitle.Text = "Book Recovery System";
            // 
            // lbLoans
            // 
            this.lbLoans.AutoSize = true;
            this.lbLoans.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoans.Location = new System.Drawing.Point(481, 155);
            this.lbLoans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoans.Name = "lbLoans";
            this.lbLoans.Size = new System.Drawing.Size(99, 41);
            this.lbLoans.TabIndex = 14;
            this.lbLoans.Text = "Loans";
            // 
            // btNewLoan
            // 
            this.btNewLoan.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewLoan.Location = new System.Drawing.Point(391, 214);
            this.btNewLoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNewLoan.Name = "btNewLoan";
            this.btNewLoan.Size = new System.Drawing.Size(275, 53);
            this.btNewLoan.TabIndex = 19;
            this.btNewLoan.Text = "Add New Loan";
            this.btNewLoan.UseVisualStyleBackColor = true;
            this.btNewLoan.Click += new System.EventHandler(this.btNewLoan_Click);
            // 
            // btCurrent
            // 
            this.btCurrent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCurrent.Location = new System.Drawing.Point(391, 338);
            this.btCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCurrent.Name = "btCurrent";
            this.btCurrent.Size = new System.Drawing.Size(275, 53);
            this.btCurrent.TabIndex = 20;
            this.btCurrent.Text = "Current Loans";
            this.btCurrent.UseVisualStyleBackColor = true;
            this.btCurrent.Click += new System.EventHandler(this.btCurrent_Click);
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(852, 464);
            this.btMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(175, 53);
            this.btMenu.TabIndex = 21;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // LoansMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1061, 561);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.btCurrent);
            this.Controls.Add(this.btNewLoan);
            this.Controls.Add(this.lbLoans);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoansMenu";
            this.Text = "LoansMenu";
            this.Load += new System.EventHandler(this.LoansMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbLoans;
        private System.Windows.Forms.Button btNewLoan;
        private System.Windows.Forms.Button btCurrent;
        private System.Windows.Forms.Button btMenu;
    }
}