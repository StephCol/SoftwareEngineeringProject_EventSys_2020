namespace EventSys
{
    partial class frmUpdateVenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateVenue));
            this.label1 = new System.Windows.Forms.Label();
            this.cboVenueNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtVenueName = new System.Windows.Forms.TextBox();
            this.Town = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.btnUpdateVenue = new System.Windows.Forms.Button();
            this.mnuBack = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlUpdateVenue = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlUpdateVenue.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(352, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Venue";
            // 
            // cboVenueNames
            // 
            this.cboVenueNames.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVenueNames.FormattingEnabled = true;
            this.cboVenueNames.Location = new System.Drawing.Point(313, 131);
            this.cboVenueNames.MaxLength = 25;
            this.cboVenueNames.Name = "cboVenueNames";
            this.cboVenueNames.Size = new System.Drawing.Size(192, 24);
            this.cboVenueNames.TabIndex = 1;
            this.cboVenueNames.SelectedIndexChanged += new System.EventHandler(this.cboVenueNames_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Street";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(14, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(14, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contact No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Capacity";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(218, 117);
            this.txtCapacity.MaxLength = 4;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(81, 20);
            this.txtCapacity.TabIndex = 5;
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 190);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(125, 149);
            this.txtContactNo.MaxLength = 14;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(170, 20);
            this.txtContactNo.TabIndex = 5;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(125, 40);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(170, 20);
            this.txtStreet.TabIndex = 3;
            this.txtStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTown_KeyPress);
            // 
            // txtVenueName
            // 
            this.txtVenueName.Location = new System.Drawing.Point(125, 12);
            this.txtVenueName.MaxLength = 20;
            this.txtVenueName.Name = "txtVenueName";
            this.txtVenueName.Size = new System.Drawing.Size(170, 20);
            this.txtVenueName.TabIndex = 2;
            // 
            // Town
            // 
            this.Town.AutoSize = true;
            this.Town.BackColor = System.Drawing.Color.Transparent;
            this.Town.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Town.ForeColor = System.Drawing.Color.Gray;
            this.Town.Location = new System.Drawing.Point(14, 71);
            this.Town.Name = "Town";
            this.Town.Size = new System.Drawing.Size(57, 23);
            this.Town.TabIndex = 15;
            this.Town.Text = "Town";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(125, 76);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(170, 20);
            this.txtTown.TabIndex = 4;
            this.txtTown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTown_KeyPress);
            // 
            // btnUpdateVenue
            // 
            this.btnUpdateVenue.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateVenue.FlatAppearance.BorderSize = 0;
            this.btnUpdateVenue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateVenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateVenue.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVenue.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateVenue.Location = new System.Drawing.Point(229, 251);
            this.btnUpdateVenue.Name = "btnUpdateVenue";
            this.btnUpdateVenue.Size = new System.Drawing.Size(81, 36);
            this.btnUpdateVenue.TabIndex = 8;
            this.btnUpdateVenue.Text = "Update";
            this.btnUpdateVenue.UseVisualStyleBackColor = false;
            this.btnUpdateVenue.Click += new System.EventHandler(this.btnUpdateVenue_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.BackColor = System.Drawing.Color.Transparent;
            this.mnuBack.FlatAppearance.BorderSize = 0;
            this.mnuBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuBack.Image = ((System.Drawing.Image)(resources.GetObject("mnuBack.Image")));
            this.mnuBack.Location = new System.Drawing.Point(711, 19);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(54, 66);
            this.mnuBack.TabIndex = 27;
            this.mnuBack.UseVisualStyleBackColor = false;
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(129, 226);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(170, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(14, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Password";
            // 
            // pnlUpdateVenue
            // 
            this.pnlUpdateVenue.BackColor = System.Drawing.Color.Transparent;
            this.pnlUpdateVenue.Controls.Add(this.txtPassword);
            this.pnlUpdateVenue.Controls.Add(this.label7);
            this.pnlUpdateVenue.Controls.Add(this.btnUpdateVenue);
            this.pnlUpdateVenue.Controls.Add(this.txtTown);
            this.pnlUpdateVenue.Controls.Add(this.Town);
            this.pnlUpdateVenue.Controls.Add(this.txtVenueName);
            this.pnlUpdateVenue.Controls.Add(this.txtStreet);
            this.pnlUpdateVenue.Controls.Add(this.txtContactNo);
            this.pnlUpdateVenue.Controls.Add(this.txtEmail);
            this.pnlUpdateVenue.Controls.Add(this.txtCapacity);
            this.pnlUpdateVenue.Controls.Add(this.label6);
            this.pnlUpdateVenue.Controls.Add(this.label5);
            this.pnlUpdateVenue.Controls.Add(this.label4);
            this.pnlUpdateVenue.Controls.Add(this.label3);
            this.pnlUpdateVenue.Controls.Add(this.label2);
            this.pnlUpdateVenue.Location = new System.Drawing.Point(245, 167);
            this.pnlUpdateVenue.Name = "pnlUpdateVenue";
            this.pnlUpdateVenue.Size = new System.Drawing.Size(314, 299);
            this.pnlUpdateVenue.TabIndex = 29;
            this.pnlUpdateVenue.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.mnuBack);
            this.panel2.Controls.Add(this.cboVenueNames);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, -11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 172);
            this.panel2.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(307, 24);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(10);
            this.label15.Size = new System.Drawing.Size(204, 51);
            this.label15.TabIndex = 24;
            this.label15.Text = "Update Venue";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(-1, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 140);
            this.panel3.TabIndex = 34;
            // 
            // frmUpdateVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlUpdateVenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateVenue";
            this.Text = "Bored\'n\'Kerry - [Update Venue]";
            this.Load += new System.EventHandler(this.frmUpdateVenue_Load);
            this.pnlUpdateVenue.ResumeLayout(false);
            this.pnlUpdateVenue.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboVenueNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.Label Town;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Button btnUpdateVenue;
        private System.Windows.Forms.Button mnuBack;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlUpdateVenue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
    }
}