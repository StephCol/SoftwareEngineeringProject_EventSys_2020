namespace EventSys
{
    partial class frmAnalyseVenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyseVenue));
            this.mnuBack = new System.Windows.Forms.Button();
            this.btnAnalyseVenue = new System.Windows.Forms.Button();
            this.cboVenueNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.txtCancelledEvents = new System.Windows.Forms.TextBox();
            this.txtTicketsSold = new System.Windows.Forms.TextBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSysFee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRevFee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEmailAnalysis = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.pnlAnalysis = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlYear = new System.Windows.Forms.Panel();
            this.pnlMonth = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlAnalysis.SuspendLayout();
            this.pnlYear.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBack
            // 
            this.mnuBack.BackColor = System.Drawing.Color.Transparent;
            this.mnuBack.FlatAppearance.BorderSize = 0;
            this.mnuBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuBack.Image = ((System.Drawing.Image)(resources.GetObject("mnuBack.Image")));
            this.mnuBack.Location = new System.Drawing.Point(707, 20);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(54, 66);
            this.mnuBack.TabIndex = 26;
            this.mnuBack.UseVisualStyleBackColor = false;
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // btnAnalyseVenue
            // 
            this.btnAnalyseVenue.BackColor = System.Drawing.Color.White;
            this.btnAnalyseVenue.FlatAppearance.BorderSize = 0;
            this.btnAnalyseVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyseVenue.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyseVenue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnalyseVenue.Location = new System.Drawing.Point(297, 195);
            this.btnAnalyseVenue.Name = "btnAnalyseVenue";
            this.btnAnalyseVenue.Size = new System.Drawing.Size(85, 33);
            this.btnAnalyseVenue.TabIndex = 29;
            this.btnAnalyseVenue.Text = "Analyse";
            this.btnAnalyseVenue.UseVisualStyleBackColor = false;
            this.btnAnalyseVenue.Visible = false;
            this.btnAnalyseVenue.Click += new System.EventHandler(this.btnAnalyseVenue_Click);
            // 
            // cboVenueNames
            // 
            this.cboVenueNames.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVenueNames.FormattingEnabled = true;
            this.cboVenueNames.Location = new System.Drawing.Point(377, 136);
            this.cboVenueNames.MaxLength = 25;
            this.cboVenueNames.Name = "cboVenueNames";
            this.cboVenueNames.Size = new System.Drawing.Size(177, 24);
            this.cboVenueNames.TabIndex = 28;
            this.cboVenueNames.SelectedIndexChanged += new System.EventHandler(this.cboVenueNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(242, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Select Venue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(43, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Total Revenue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(43, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "No. Cancelled Events";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(43, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "No. Events";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(43, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "No. Tickets Sold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(71, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 33);
            this.label6.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(1, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Year";
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(62, 6);
            this.cboYear.MaxLength = 3;
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(84, 24);
            this.cboYear.TabIndex = 36;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // txtEvents
            // 
            this.txtEvents.Enabled = false;
            this.txtEvents.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvents.Location = new System.Drawing.Point(258, 41);
            this.txtEvents.MaxLength = 8;
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.Size = new System.Drawing.Size(100, 22);
            this.txtEvents.TabIndex = 37;
            // 
            // txtCancelledEvents
            // 
            this.txtCancelledEvents.Enabled = false;
            this.txtCancelledEvents.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelledEvents.Location = new System.Drawing.Point(258, 72);
            this.txtCancelledEvents.MaxLength = 8;
            this.txtCancelledEvents.Name = "txtCancelledEvents";
            this.txtCancelledEvents.Size = new System.Drawing.Size(100, 22);
            this.txtCancelledEvents.TabIndex = 38;
            // 
            // txtTicketsSold
            // 
            this.txtTicketsSold.Enabled = false;
            this.txtTicketsSold.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketsSold.Location = new System.Drawing.Point(258, 101);
            this.txtTicketsSold.MaxLength = 8;
            this.txtTicketsSold.Name = "txtTicketsSold";
            this.txtTicketsSold.Size = new System.Drawing.Size(100, 22);
            this.txtTicketsSold.TabIndex = 39;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Enabled = false;
            this.txtRevenue.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevenue.Location = new System.Drawing.Point(258, 130);
            this.txtRevenue.MaxLength = 15;
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(100, 22);
            this.txtRevenue.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(223, 125);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 33);
            this.label14.TabIndex = 80;
            this.label14.Text = "€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(43, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 81;
            this.label8.Text = "System Fee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(223, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 33);
            this.label9.TabIndex = 83;
            this.label9.Text = "€";
            // 
            // txtSysFee
            // 
            this.txtSysFee.Enabled = false;
            this.txtSysFee.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSysFee.Location = new System.Drawing.Point(258, 156);
            this.txtSysFee.MaxLength = 12;
            this.txtSysFee.Name = "txtSysFee";
            this.txtSysFee.Size = new System.Drawing.Size(100, 22);
            this.txtSysFee.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(223, 176);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 33);
            this.label11.TabIndex = 87;
            this.label11.Text = "€";
            // 
            // txtRevFee
            // 
            this.txtRevFee.Enabled = false;
            this.txtRevFee.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevFee.Location = new System.Drawing.Point(258, 182);
            this.txtRevFee.MaxLength = 12;
            this.txtRevFee.Name = "txtRevFee";
            this.txtRevFee.Size = new System.Drawing.Size(100, 22);
            this.txtRevFee.TabIndex = 86;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(44, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 23);
            this.label12.TabIndex = 85;
            this.label12.Text = "Revenue After Fee";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(486, 424);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 33);
            this.label13.TabIndex = 84;
            // 
            // btnEmailAnalysis
            // 
            this.btnEmailAnalysis.BackColor = System.Drawing.Color.White;
            this.btnEmailAnalysis.FlatAppearance.BorderSize = 0;
            this.btnEmailAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmailAnalysis.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailAnalysis.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnEmailAnalysis.Location = new System.Drawing.Point(220, 204);
            this.btnEmailAnalysis.Name = "btnEmailAnalysis";
            this.btnEmailAnalysis.Size = new System.Drawing.Size(149, 35);
            this.btnEmailAnalysis.TabIndex = 88;
            this.btnEmailAnalysis.Text = "Email Analysis";
            this.btnEmailAnalysis.UseVisualStyleBackColor = false;
            this.btnEmailAnalysis.Click += new System.EventHandler(this.btnEmailAnalysis_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(5, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 25);
            this.label15.TabIndex = 91;
            this.label15.Text = "Month";
            // 
            // cboMonth
            // 
            this.cboMonth.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "All",
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cboMonth.Location = new System.Drawing.Point(81, 6);
            this.cboMonth.MaxLength = 3;
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(70, 24);
            this.cboMonth.TabIndex = 92;
            // 
            // pnlAnalysis
            // 
            this.pnlAnalysis.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlAnalysis.Controls.Add(this.lblDate);
            this.pnlAnalysis.Controls.Add(this.label6);
            this.pnlAnalysis.Controls.Add(this.btnEmailAnalysis);
            this.pnlAnalysis.Controls.Add(this.txtRevFee);
            this.pnlAnalysis.Controls.Add(this.label2);
            this.pnlAnalysis.Controls.Add(this.label3);
            this.pnlAnalysis.Controls.Add(this.label11);
            this.pnlAnalysis.Controls.Add(this.label4);
            this.pnlAnalysis.Controls.Add(this.label5);
            this.pnlAnalysis.Controls.Add(this.label12);
            this.pnlAnalysis.Controls.Add(this.txtEvents);
            this.pnlAnalysis.Controls.Add(this.txtCancelledEvents);
            this.pnlAnalysis.Controls.Add(this.label9);
            this.pnlAnalysis.Controls.Add(this.txtTicketsSold);
            this.pnlAnalysis.Controls.Add(this.txtSysFee);
            this.pnlAnalysis.Controls.Add(this.txtRevenue);
            this.pnlAnalysis.Controls.Add(this.label8);
            this.pnlAnalysis.Controls.Add(this.label14);
            this.pnlAnalysis.Location = new System.Drawing.Point(178, 246);
            this.pnlAnalysis.Name = "pnlAnalysis";
            this.pnlAnalysis.Size = new System.Drawing.Size(419, 244);
            this.pnlAnalysis.TabIndex = 93;
            this.pnlAnalysis.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDate.Location = new System.Drawing.Point(95, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(244, 25);
            this.lblDate.TabIndex = 88;
            this.lblDate.Text = "Analysis for Jan 2018";
            // 
            // pnlYear
            // 
            this.pnlYear.BackColor = System.Drawing.Color.Transparent;
            this.pnlYear.Controls.Add(this.cboYear);
            this.pnlYear.Controls.Add(this.label7);
            this.pnlYear.Location = new System.Drawing.Point(243, 163);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Size = new System.Drawing.Size(154, 34);
            this.pnlYear.TabIndex = 94;
            this.pnlYear.Visible = false;
            // 
            // pnlMonth
            // 
            this.pnlMonth.BackColor = System.Drawing.Color.Transparent;
            this.pnlMonth.Controls.Add(this.label15);
            this.pnlMonth.Controls.Add(this.cboMonth);
            this.pnlMonth.Location = new System.Drawing.Point(403, 163);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(155, 34);
            this.pnlMonth.TabIndex = 95;
            this.pnlMonth.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnReset.Location = new System.Drawing.Point(391, 193);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 38);
            this.btnReset.TabIndex = 96;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.pnlMonth);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.mnuBack);
            this.panel2.Controls.Add(this.cboVenueNames);
            this.panel2.Controls.Add(this.pnlYear);
            this.panel2.Location = new System.Drawing.Point(-16, -14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 206);
            this.panel2.TabIndex = 97;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(283, 27);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(10);
            this.label17.Size = new System.Drawing.Size(223, 51);
            this.label17.TabIndex = 24;
            this.label17.Text = "Analyse Venues";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(-8, 506);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 140);
            this.panel3.TabIndex = 98;
            // 
            // frmAnalyseVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pnlAnalysis);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAnalyseVenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnalyseVenue";
            this.Text = "frmAnalyseVenue";
            this.Load += new System.EventHandler(this.frmAnalyseVenue_Load);
            this.pnlAnalysis.ResumeLayout(false);
            this.pnlAnalysis.PerformLayout();
            this.pnlYear.ResumeLayout(false);
            this.pnlYear.PerformLayout();
            this.pnlMonth.ResumeLayout(false);
            this.pnlMonth.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mnuBack;
        private System.Windows.Forms.Button btnAnalyseVenue;
        private System.Windows.Forms.ComboBox cboVenueNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.TextBox txtCancelledEvents;
        private System.Windows.Forms.TextBox txtTicketsSold;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSysFee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRevFee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEmailAnalysis;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Panel pnlAnalysis;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlYear;
        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
    }
}