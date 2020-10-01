namespace EventSys
{
    partial class frmDeleteVenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteVenue));
            this.cboVenueNames = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mnuBack = new System.Windows.Forms.Button();
            this.pnlDeleteVenue = new System.Windows.Forms.Panel();
            this.btnDelVenue = new System.Windows.Forms.Button();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.Town = new System.Windows.Forms.Label();
            this.txtVenueName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlDeleteVenue.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboVenueNames
            // 
            this.cboVenueNames.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVenueNames.FormattingEnabled = true;
            this.cboVenueNames.Location = new System.Drawing.Point(352, 123);
            this.cboVenueNames.Name = "cboVenueNames";
            this.cboVenueNames.Size = new System.Drawing.Size(205, 24);
            this.cboVenueNames.TabIndex = 1;
            this.cboVenueNames.SelectedIndexChanged += new System.EventHandler(this.cboVenueNames_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(227, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Venue Name";
            // 
            // mnuBack
            // 
            this.mnuBack.BackColor = System.Drawing.Color.Transparent;
            this.mnuBack.FlatAppearance.BorderSize = 0;
            this.mnuBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuBack.Image = ((System.Drawing.Image)(resources.GetObject("mnuBack.Image")));
            this.mnuBack.Location = new System.Drawing.Point(706, 18);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(54, 66);
            this.mnuBack.TabIndex = 27;
            this.mnuBack.UseVisualStyleBackColor = false;
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click_1);
            // 
            // pnlDeleteVenue
            // 
            this.pnlDeleteVenue.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeleteVenue.Controls.Add(this.btnDelVenue);
            this.pnlDeleteVenue.Controls.Add(this.txtTown);
            this.pnlDeleteVenue.Controls.Add(this.Town);
            this.pnlDeleteVenue.Controls.Add(this.txtVenueName);
            this.pnlDeleteVenue.Controls.Add(this.txtStreet);
            this.pnlDeleteVenue.Controls.Add(this.txtContactNo);
            this.pnlDeleteVenue.Controls.Add(this.txtEmail);
            this.pnlDeleteVenue.Controls.Add(this.txtCapacity);
            this.pnlDeleteVenue.Controls.Add(this.label6);
            this.pnlDeleteVenue.Controls.Add(this.label1);
            this.pnlDeleteVenue.Controls.Add(this.label4);
            this.pnlDeleteVenue.Controls.Add(this.label3);
            this.pnlDeleteVenue.Controls.Add(this.label2);
            this.pnlDeleteVenue.Location = new System.Drawing.Point(227, 173);
            this.pnlDeleteVenue.Name = "pnlDeleteVenue";
            this.pnlDeleteVenue.Size = new System.Drawing.Size(326, 235);
            this.pnlDeleteVenue.TabIndex = 30;
            this.pnlDeleteVenue.Visible = false;
            // 
            // btnDelVenue
            // 
            this.btnDelVenue.BackColor = System.Drawing.Color.White;
            this.btnDelVenue.FlatAppearance.BorderSize = 0;
            this.btnDelVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelVenue.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelVenue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelVenue.Location = new System.Drawing.Point(224, 184);
            this.btnDelVenue.Name = "btnDelVenue";
            this.btnDelVenue.Size = new System.Drawing.Size(82, 33);
            this.btnDelVenue.TabIndex = 8;
            this.btnDelVenue.Text = "Delete";
            this.btnDelVenue.UseVisualStyleBackColor = false;
            this.btnDelVenue.Click += new System.EventHandler(this.btnDelVenue_Click);
            // 
            // txtTown
            // 
            this.txtTown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTown.Enabled = false;
            this.txtTown.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(151, 71);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(142, 15);
            this.txtTown.TabIndex = 4;
            // 
            // Town
            // 
            this.Town.AutoSize = true;
            this.Town.BackColor = System.Drawing.Color.Transparent;
            this.Town.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Town.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Town.Location = new System.Drawing.Point(14, 66);
            this.Town.Name = "Town";
            this.Town.Size = new System.Drawing.Size(57, 23);
            this.Town.TabIndex = 15;
            this.Town.Text = "Town";
            // 
            // txtVenueName
            // 
            this.txtVenueName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVenueName.Enabled = false;
            this.txtVenueName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenueName.Location = new System.Drawing.Point(151, 12);
            this.txtVenueName.MaxLength = 20;
            this.txtVenueName.Name = "txtVenueName";
            this.txtVenueName.Size = new System.Drawing.Size(142, 15);
            this.txtVenueName.TabIndex = 2;
            // 
            // txtStreet
            // 
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.Enabled = false;
            this.txtStreet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(151, 40);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(142, 15);
            this.txtStreet.TabIndex = 3;
            // 
            // txtContactNo
            // 
            this.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactNo.Enabled = false;
            this.txtContactNo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(151, 130);
            this.txtContactNo.MaxLength = 14;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(142, 15);
            this.txtContactNo.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(151, 158);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 15);
            this.txtEmail.TabIndex = 6;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacity.Enabled = false;
            this.txtCapacity.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(212, 100);
            this.txtCapacity.MaxLength = 4;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(81, 15);
            this.txtCapacity.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(14, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Capacity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(14, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Venue Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Street";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.mnuBack);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboVenueNames);
            this.panel2.Location = new System.Drawing.Point(-14, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 160);
            this.panel2.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(295, 20);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(10);
            this.label14.Size = new System.Drawing.Size(193, 51);
            this.label14.TabIndex = 24;
            this.label14.Text = "Delete Venue";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(-6, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 140);
            this.panel3.TabIndex = 71;
            // 
            // frmDeleteVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 469);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDeleteVenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteVenue";
            this.Text = "Bored\'n\'Kerry - [Delete Venue]";
            this.Load += new System.EventHandler(this.frmDeleteVenue_Load);
            this.pnlDeleteVenue.ResumeLayout(false);
            this.pnlDeleteVenue.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboVenueNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mnuBack;
        private System.Windows.Forms.Panel pnlDeleteVenue;
        private System.Windows.Forms.Button btnDelVenue;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label Town;
        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
    }
}