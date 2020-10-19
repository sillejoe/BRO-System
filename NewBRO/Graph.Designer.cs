namespace NewBRO
{
    partial class Graph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvForGraph = new System.Windows.Forms.DataGridView();
            this.January = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.February = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.March = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.April = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.June = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.July = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.August = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.September = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.October = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.November = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.December = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(15, 20);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(436, 54);
            this.lbTitle.TabIndex = 34;
            this.lbTitle.Text = "Book Recovery System";
            // 
            // dgvForGraph
            // 
            this.dgvForGraph.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvForGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForGraph.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.January,
            this.February,
            this.March,
            this.April,
            this.May,
            this.June,
            this.July,
            this.August,
            this.September,
            this.October,
            this.November,
            this.December});
            this.dgvForGraph.Location = new System.Drawing.Point(78, 85);
            this.dgvForGraph.Margin = new System.Windows.Forms.Padding(4);
            this.dgvForGraph.Name = "dgvForGraph";
            this.dgvForGraph.RowHeadersWidth = 51;
            this.dgvForGraph.Size = new System.Drawing.Size(766, 75);
            this.dgvForGraph.TabIndex = 35;
            // 
            // January
            // 
            this.January.HeaderText = "January";
            this.January.MinimumWidth = 6;
            this.January.Name = "January";
            this.January.Width = 125;
            // 
            // February
            // 
            this.February.HeaderText = "February";
            this.February.MinimumWidth = 6;
            this.February.Name = "February";
            this.February.Width = 125;
            // 
            // March
            // 
            this.March.HeaderText = "March";
            this.March.MinimumWidth = 6;
            this.March.Name = "March";
            this.March.Width = 125;
            // 
            // April
            // 
            this.April.HeaderText = "April";
            this.April.MinimumWidth = 6;
            this.April.Name = "April";
            this.April.Width = 125;
            // 
            // May
            // 
            this.May.HeaderText = "May";
            this.May.MinimumWidth = 6;
            this.May.Name = "May";
            this.May.Width = 125;
            // 
            // June
            // 
            this.June.HeaderText = "June";
            this.June.MinimumWidth = 6;
            this.June.Name = "June";
            this.June.Width = 125;
            // 
            // July
            // 
            this.July.HeaderText = "July";
            this.July.MinimumWidth = 6;
            this.July.Name = "July";
            this.July.Width = 125;
            // 
            // August
            // 
            this.August.HeaderText = "August";
            this.August.MinimumWidth = 6;
            this.August.Name = "August";
            this.August.Width = 125;
            // 
            // September
            // 
            this.September.HeaderText = "September";
            this.September.MinimumWidth = 6;
            this.September.Name = "September";
            this.September.Width = 125;
            // 
            // October
            // 
            this.October.HeaderText = "October";
            this.October.MinimumWidth = 6;
            this.October.Name = "October";
            this.October.Width = 125;
            // 
            // November
            // 
            this.November.HeaderText = "November";
            this.November.MinimumWidth = 6;
            this.November.Name = "November";
            this.November.Width = 125;
            // 
            // December
            // 
            this.December.HeaderText = "December";
            this.December.MinimumWidth = 6;
            this.December.Name = "December";
            this.December.Width = 125;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(78, 167);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Overdue Loans";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(766, 350);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // btMenu
            // 
            this.btMenu.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Location = new System.Drawing.Point(852, 464);
            this.btMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(175, 53);
            this.btMenu.TabIndex = 37;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvForGraph);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Graph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvForGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn January;
        private System.Windows.Forms.DataGridViewTextBoxColumn February;
        private System.Windows.Forms.DataGridViewTextBoxColumn March;
        private System.Windows.Forms.DataGridViewTextBoxColumn April;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn June;
        private System.Windows.Forms.DataGridViewTextBoxColumn July;
        private System.Windows.Forms.DataGridViewTextBoxColumn August;
        private System.Windows.Forms.DataGridViewTextBoxColumn September;
        private System.Windows.Forms.DataGridViewTextBoxColumn October;
        private System.Windows.Forms.DataGridViewTextBoxColumn November;
        private System.Windows.Forms.DataGridViewTextBoxColumn December;
    }
}