namespace NewBRO
{
    partial class CurrentLoans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentLoans));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbxSelect = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbOverdue = new System.Windows.Forms.RadioButton();
            this.rbBorrower = new System.Windows.Forms.RadioButton();
            this.gbxBorrowerID = new System.Windows.Forms.GroupBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.tbBorrowerID = new System.Windows.Forms.TextBox();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.btMenu = new System.Windows.Forms.Button();
            this.cbComplete = new System.Windows.Forms.ComboBox();
            this.lbComplete = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbxSelect.SuspendLayout();
            this.gbxBorrowerID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
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
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(10, 1);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(350, 42);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Book Recovery System";
            // 
            // gbxSelect
            // 
            this.gbxSelect.Controls.Add(this.rbAll);
            this.gbxSelect.Controls.Add(this.rbOverdue);
            this.gbxSelect.Controls.Add(this.rbBorrower);
            this.gbxSelect.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSelect.Location = new System.Drawing.Point(17, 78);
            this.gbxSelect.Name = "gbxSelect";
            this.gbxSelect.Size = new System.Drawing.Size(163, 86);
            this.gbxSelect.TabIndex = 14;
            this.gbxSelect.TabStop = false;
            this.gbxSelect.Text = "Select Loans";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(6, 14);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(40, 18);
            this.rbAll.TabIndex = 17;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.Click += new System.EventHandler(this.rbAll_Click);
            // 
            // rbOverdue
            // 
            this.rbOverdue.AutoSize = true;
            this.rbOverdue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOverdue.Location = new System.Drawing.Point(6, 62);
            this.rbOverdue.Name = "rbOverdue";
            this.rbOverdue.Size = new System.Drawing.Size(70, 18);
            this.rbOverdue.TabIndex = 16;
            this.rbOverdue.TabStop = true;
            this.rbOverdue.Text = "Overdue";
            this.rbOverdue.UseVisualStyleBackColor = true;
            this.rbOverdue.Click += new System.EventHandler(this.rbOverdue_Click);
            // 
            // rbBorrower
            // 
            this.rbBorrower.AutoSize = true;
            this.rbBorrower.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBorrower.Location = new System.Drawing.Point(6, 38);
            this.rbBorrower.Name = "rbBorrower";
            this.rbBorrower.Size = new System.Drawing.Size(74, 18);
            this.rbBorrower.TabIndex = 15;
            this.rbBorrower.TabStop = true;
            this.rbBorrower.Text = "Borrower";
            this.rbBorrower.UseVisualStyleBackColor = true;
            this.rbBorrower.Click += new System.EventHandler(this.rbBorrower_Click);
            // 
            // gbxBorrowerID
            // 
            this.gbxBorrowerID.Controls.Add(this.btEnter);
            this.gbxBorrowerID.Controls.Add(this.tbBorrowerID);
            this.gbxBorrowerID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBorrowerID.Location = new System.Drawing.Point(236, 87);
            this.gbxBorrowerID.Name = "gbxBorrowerID";
            this.gbxBorrowerID.Size = new System.Drawing.Size(243, 51);
            this.gbxBorrowerID.TabIndex = 37;
            this.gbxBorrowerID.TabStop = false;
            this.gbxBorrowerID.Text = "Enter BorrowerID";
            // 
            // btEnter
            // 
            this.btEnter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbBorrowerID.Size = new System.Drawing.Size(116, 23);
            this.tbBorrowerID.TabIndex = 37;
            // 
            // dgvLoans
            // 
            this.dgvLoans.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(17, 183);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.Size = new System.Drawing.Size(479, 187);
            this.dgvLoans.TabIndex = 38;
            this.dgvLoans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoans_CellClick);
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(639, 377);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(131, 43);
            this.btMenu.TabIndex = 39;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // cbComplete
            // 
            this.cbComplete.FormattingEnabled = true;
            this.cbComplete.Items.AddRange(new object[] {
            "No - On Loan",
            "Returned",
            "BRO"});
            this.cbComplete.Location = new System.Drawing.Point(543, 212);
            this.cbComplete.Name = "cbComplete";
            this.cbComplete.Size = new System.Drawing.Size(180, 21);
            this.cbComplete.TabIndex = 40;
            // 
            // lbComplete
            // 
            this.lbComplete.AutoSize = true;
            this.lbComplete.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplete.Location = new System.Drawing.Point(539, 183);
            this.lbComplete.Name = "lbComplete";
            this.lbComplete.Size = new System.Drawing.Size(88, 23);
            this.lbComplete.TabIndex = 49;
            this.lbComplete.Text = "Complete:";
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(496, 376);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(131, 43);
            this.btUpdate.TabIndex = 50;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // CurrentLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.lbComplete);
            this.Controls.Add(this.cbComplete);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.gbxBorrowerID);
            this.Controls.Add(this.gbxSelect);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbLogo);
            this.Name = "CurrentLoans";
            this.Text = "CurrentLoans";
            this.Load += new System.EventHandler(this.CurrentLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbxSelect.ResumeLayout(false);
            this.gbxSelect.PerformLayout();
            this.gbxBorrowerID.ResumeLayout(false);
            this.gbxBorrowerID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbxSelect;
        private System.Windows.Forms.RadioButton rbOverdue;
        private System.Windows.Forms.RadioButton rbBorrower;
        private System.Windows.Forms.GroupBox gbxBorrowerID;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox tbBorrowerID;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.ComboBox cbComplete;
        private System.Windows.Forms.Label lbComplete;
        private System.Windows.Forms.Button btUpdate;
    }
}