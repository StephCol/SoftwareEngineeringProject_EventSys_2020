namespace EventSys
{
    partial class frmAnalyseRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyseRevenue));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuBack = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chtRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtFees = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblYear = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.txtSysRev = new System.Windows.Forms.TextBox();
            this.txtTicketRev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtFees)).BeginInit();
            this.pnlRevenue.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBack
            // 
            this.mnuBack.BackColor = System.Drawing.Color.Transparent;
            this.mnuBack.FlatAppearance.BorderSize = 0;
            this.mnuBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuBack.Image = ((System.Drawing.Image)(resources.GetObject("mnuBack.Image")));
            this.mnuBack.Location = new System.Drawing.Point(692, 22);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(54, 66);
            this.mnuBack.TabIndex = 26;
            this.mnuBack.UseVisualStyleBackColor = false;
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(418, 134);
            this.cboYear.MaxLength = 3;
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(74, 24);
            this.cboYear.TabIndex = 39;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(297, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Select Year";
            // 
            // chtRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chtRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtRevenue.Legends.Add(legend1);
            this.chtRevenue.Location = new System.Drawing.Point(13, 54);
            this.chtRevenue.Name = "chtRevenue";
            this.chtRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtRevenue.Series.Add(series1);
            this.chtRevenue.Size = new System.Drawing.Size(320, 235);
            this.chtRevenue.TabIndex = 93;
            this.chtRevenue.Text = "chart1";
            // 
            // chtFees
            // 
            this.chtFees.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chtFees.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtFees.Legends.Add(legend2);
            this.chtFees.Location = new System.Drawing.Point(375, 54);
            this.chtFees.Name = "chtFees";
            this.chtFees.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtFees.Series.Add(series2);
            this.chtFees.Size = new System.Drawing.Size(324, 235);
            this.chtFees.TabIndex = 94;
            this.chtFees.Text = "chart1";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblYear.Location = new System.Drawing.Point(287, 5);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(149, 25);
            this.lblYear.TabIndex = 96;
            this.lblYear.Text = "Year in Review";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.Transparent;
            this.pnlRevenue.Controls.Add(this.txtSysRev);
            this.pnlRevenue.Controls.Add(this.txtTicketRev);
            this.pnlRevenue.Controls.Add(this.label3);
            this.pnlRevenue.Controls.Add(this.label2);
            this.pnlRevenue.Controls.Add(this.chtFees);
            this.pnlRevenue.Controls.Add(this.lblYear);
            this.pnlRevenue.Controls.Add(this.chtRevenue);
            this.pnlRevenue.Location = new System.Drawing.Point(8, 166);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(714, 349);
            this.pnlRevenue.TabIndex = 98;
            this.pnlRevenue.Visible = false;
            // 
            // txtSysRev
            // 
            this.txtSysRev.BackColor = System.Drawing.Color.White;
            this.txtSysRev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSysRev.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSysRev.Location = new System.Drawing.Point(551, 316);
            this.txtSysRev.Name = "txtSysRev";
            this.txtSysRev.ReadOnly = true;
            this.txtSysRev.Size = new System.Drawing.Size(93, 18);
            this.txtSysRev.TabIndex = 109;
            this.txtSysRev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTicketRev
            // 
            this.txtTicketRev.BackColor = System.Drawing.Color.White;
            this.txtTicketRev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTicketRev.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketRev.Location = new System.Drawing.Point(205, 318);
            this.txtTicketRev.Name = "txtTicketRev";
            this.txtTicketRev.ReadOnly = true;
            this.txtTicketRev.Size = new System.Drawing.Size(93, 18);
            this.txtTicketRev.TabIndex = 108;
            this.txtTicketRev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(39, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 107;
            this.label3.Text = "Total Ticket Rev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(378, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 106;
            this.label2.Text = "Total System Rev";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.mnuBack);
            this.panel2.Controls.Add(this.cboYear);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(-27, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 180);
            this.panel2.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 23);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(238, 51);
            this.label1.TabIndex = 24;
            this.label1.Text = "Analyse Revenue";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(-14, 521);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 140);
            this.panel3.TabIndex = 100;
            // 
            // frmAnalyseRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnalyseRevenue";
            this.Text = "frmAnalyseRevenue";
            this.Load += new System.EventHandler(this.frmAnalyseRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtFees)).EndInit();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mnuBack;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtFees;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSysRev;
        private System.Windows.Forms.TextBox txtTicketRev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}