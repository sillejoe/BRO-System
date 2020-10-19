namespace NewBRO
{
    partial class BorrowersExisting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowersExisting));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.gbxBorrowerID = new System.Windows.Forms.GroupBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.tbBorrowerID = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbFName = new System.Windows.Forms.Label();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbDOB = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbBranch = new System.Windows.Forms.Label();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.gbxBorrowerData = new System.Windows.Forms.GroupBox();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbxBorrowerID.SuspendLayout();
            this.gbxBorrowerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(543, 1);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(245, 63);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(10, 1);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(350, 42);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Book Recovery System";
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(322, 377);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(131, 43);
            this.btUpdate.TabIndex = 35;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(639, 377);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(131, 43);
            this.btMenu.TabIndex = 34;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // gbxBorrowerID
            // 
            this.gbxBorrowerID.Controls.Add(this.btEnter);
            this.gbxBorrowerID.Controls.Add(this.tbBorrowerID);
            this.gbxBorrowerID.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBorrowerID.Location = new System.Drawing.Point(12, 55);
            this.gbxBorrowerID.Name = "gbxBorrowerID";
            this.gbxBorrowerID.Size = new System.Drawing.Size(243, 51);
            this.gbxBorrowerID.TabIndex = 36;
            this.gbxBorrowerID.TabStop = false;
            this.gbxBorrowerID.Text = "Enter BorrowerID";
            this.gbxBorrowerID.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btEnter
            // 
            this.btEnter.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnter.Location = new System.Drawing.Point(141, 19);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(75, 20);
            this.btEnter.TabIndex = 37;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // tbBorrowerID
            // 
            this.tbBorrowerID.Location = new System.Drawing.Point(6, 19);
            this.tbBorrowerID.Name = "tbBorrowerID";
            this.tbBorrowerID.Size = new System.Drawing.Size(116, 21);
            this.tbBorrowerID.TabIndex = 37;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(24, 147);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(78, 23);
            this.lbAddress.TabIndex = 32;
            this.lbAddress.Text = "Address:";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(24, 113);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(41, 23);
            this.lbSex.TabIndex = 33;
            this.lbSex.Text = "Sex:";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOB.Location = new System.Drawing.Point(24, 79);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(115, 23);
            this.lbDOB.TabIndex = 34;
            this.lbDOB.Text = "Date Of Birth:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.Location = new System.Drawing.Point(24, 45);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(84, 23);
            this.lbSurname.TabIndex = 35;
            this.lbSurname.Text = "Surname:";
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFName.Location = new System.Drawing.Point(24, 8);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(98, 23);
            this.lbFName.TabIndex = 36;
            this.lbFName.Text = "First Name:";
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(181, 11);
            this.tbFName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(160, 20);
            this.tbFName.TabIndex = 37;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(181, 45);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(160, 20);
            this.tbSurname.TabIndex = 38;
            // 
            // tbDOB
            // 
            this.tbDOB.Location = new System.Drawing.Point(181, 79);
            this.tbDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDOB.Name = "tbDOB";
            this.tbDOB.Size = new System.Drawing.Size(160, 20);
            this.tbDOB.TabIndex = 39;
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(181, 113);
            this.tbSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(160, 20);
            this.tbSex.TabIndex = 40;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(181, 147);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(160, 20);
            this.tbAddress.TabIndex = 41;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(24, 181);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(123, 23);
            this.lbEmail.TabIndex = 42;
            this.lbEmail.Text = "Email Address:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(181, 181);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(160, 20);
            this.tbEmail.TabIndex = 43;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(24, 215);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(141, 23);
            this.lbNumber.TabIndex = 44;
            this.lbNumber.Text = "Contact Number:";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(181, 215);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(160, 20);
            this.tbNumber.TabIndex = 45;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(411, 45);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(162, 23);
            this.lbCategory.TabIndex = 46;
            this.lbCategory.Text = "Borrower Category:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Adult",
            "Child",
            "Concession",
            "Home Library Service"});
            this.cbCategory.Location = new System.Drawing.Point(592, 45);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(160, 21);
            this.cbCategory.TabIndex = 47;
            // 
            // lbBranch
            // 
            this.lbBranch.AutoSize = true;
            this.lbBranch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBranch.Location = new System.Drawing.Point(411, 113);
            this.lbBranch.Name = "lbBranch";
            this.lbBranch.Size = new System.Drawing.Size(69, 23);
            this.lbBranch.TabIndex = 48;
            this.lbBranch.Text = "Branch:";
            // 
            // cbBranch
            // 
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Items.AddRange(new object[] {
            "Brinnington",
            "Heatons",
            "Marple",
            "Reddish"});
            this.cbBranch.Location = new System.Drawing.Point(592, 113);
            this.cbBranch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(160, 21);
            this.cbBranch.TabIndex = 49;
            // 
            // gbxBorrowerData
            // 
            this.gbxBorrowerData.Controls.Add(this.cbBranch);
            this.gbxBorrowerData.Controls.Add(this.lbBranch);
            this.gbxBorrowerData.Controls.Add(this.cbCategory);
            this.gbxBorrowerData.Controls.Add(this.lbCategory);
            this.gbxBorrowerData.Controls.Add(this.tbNumber);
            this.gbxBorrowerData.Controls.Add(this.lbNumber);
            this.gbxBorrowerData.Controls.Add(this.tbEmail);
            this.gbxBorrowerData.Controls.Add(this.lbEmail);
            this.gbxBorrowerData.Controls.Add(this.tbAddress);
            this.gbxBorrowerData.Controls.Add(this.tbSex);
            this.gbxBorrowerData.Controls.Add(this.tbDOB);
            this.gbxBorrowerData.Controls.Add(this.tbSurname);
            this.gbxBorrowerData.Controls.Add(this.tbFName);
            this.gbxBorrowerData.Controls.Add(this.lbFName);
            this.gbxBorrowerData.Controls.Add(this.lbSurname);
            this.gbxBorrowerData.Controls.Add(this.lbDOB);
            this.gbxBorrowerData.Controls.Add(this.lbSex);
            this.gbxBorrowerData.Controls.Add(this.lbAddress);
            this.gbxBorrowerData.Location = new System.Drawing.Point(12, 125);
            this.gbxBorrowerData.Name = "gbxBorrowerData";
            this.gbxBorrowerData.Size = new System.Drawing.Size(776, 246);
            this.gbxBorrowerData.TabIndex = 37;
            this.gbxBorrowerData.TabStop = false;
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(484, 378);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(131, 43);
            this.btDelete.TabIndex = 38;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // BorrowersExisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(796, 456);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.gbxBorrowerData);
            this.Controls.Add(this.gbxBorrowerID);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbLogo);
            this.Name = "BorrowersExisting";
            this.Text = "BorrowersExisting";
            this.Load += new System.EventHandler(this.BorrowersExisting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbxBorrowerID.ResumeLayout(false);
            this.gbxBorrowerID.PerformLayout();
            this.gbxBorrowerData.ResumeLayout(false);
            this.gbxBorrowerData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.GroupBox gbxBorrowerID;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox tbBorrowerID;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbDOB;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbBranch;
        private System.Windows.Forms.ComboBox cbBranch;
        private System.Windows.Forms.GroupBox gbxBorrowerData;
        private System.Windows.Forms.Button btDelete;
    }
}