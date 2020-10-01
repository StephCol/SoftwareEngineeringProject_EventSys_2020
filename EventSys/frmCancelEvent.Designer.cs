namespace EventSys
{
    partial class frmCancelEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelEvent));
            this.btnCancelEvent = new System.Windows.Forms.Button();
            this.mnuBack = new System.Windows.Forms.Button();
            this.cboAmPm = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.cboTypes = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEventTitles = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCancellation = new System.Windows.Forms.ComboBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelEvent
            // 
            this.btnCancelEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelEvent.FlatAppearance.BorderSize = 0;
            this.btnCancelEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEvent.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEvent.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelEvent.Location = new System.Drawing.Point(174, 271);
            this.btnCancelEvent.Name = "btnCancelEvent";
            this.btnCancelEvent.Size = new System.Drawing.Size(85, 30);
            this.btnCancelEvent.TabIndex = 25;
            this.btnCancelEvent.Text = "Cancel";
            this.btnCancelEvent.UseVisualStyleBackColor = false;
            this.btnCancelEvent.Click += new System.EventHandler(this.btnCancelEvent_Click_1);
            // 
            // mnuBack
            // 
            this.mnuBack.BackColor = System.Drawing.Color.Transparent;
            this.mnuBack.FlatAppearance.BorderSize = 0;
            this.mnuBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuBack.Image = ((System.Drawing.Image)(resources.GetObject("mnuBack.Image")));
            this.mnuBack.Location = new System.Drawing.Point(707, 17);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(54, 66);
            this.mnuBack.TabIndex = 27;
            this.mnuBack.UseVisualStyleBackColor = false;
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click_1);
            // 
            // cboAmPm
            // 
            this.cboAmPm.Enabled = false;
            this.cboAmPm.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAmPm.FormattingEnabled = true;
            this.cboAmPm.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.cboAmPm.Location = new System.Drawing.Point(180, 191);
            this.cboAmPm.MaxLength = 3;
            this.cboAmPm.Name = "cboAmPm";
            this.cboAmPm.Size = new System.Drawing.Size(66, 24);
            this.cboAmPm.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label11.Location = new System.Drawing.Point(116, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 23);
            this.label11.TabIndex = 64;
            this.label11.Text = ":";
            // 
            // txtMin
            // 
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMin.Enabled = false;
            this.txtMin.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(137, 196);
            this.txtMin.MaxLength = 2;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(37, 15);
            this.txtMin.TabIndex = 62;
            // 
            // txtHour
            // 
            this.txtHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHour.Enabled = false;
            this.txtHour.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(76, 196);
            this.txtHour.MaxLength = 2;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(37, 15);
            this.txtHour.TabIndex = 61;
            // 
            // cboTypes
            // 
            this.cboTypes.Enabled = false;
            this.cboTypes.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypes.FormattingEnabled = true;
            this.cboTypes.Location = new System.Drawing.Point(77, 129);
            this.cboTypes.Name = "cboTypes";
            this.cboTypes.Size = new System.Drawing.Size(169, 24);
            this.cboTypes.TabIndex = 60;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(135, 221);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(110, 15);
            this.txtPrice.TabIndex = 52;
            this.txtPrice.Text = "00.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTickets
            // 
            this.txtTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTickets.Enabled = false;
            this.txtTickets.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickets.Location = new System.Drawing.Point(135, 250);
            this.txtTickets.MaxLength = 4;
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(110, 15);
            this.txtTickets.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(11, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "Time";
            // 
            // txtDate
            // 
            this.txtDate.CustomFormat = "dd-MMM-yy";
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(77, 161);
            this.txtDate.MinDate = new System.DateTime(2020, 3, 10, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(169, 22);
            this.txtDate.TabIndex = 50;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(15, 69);
            this.txtDescription.MaxLength = 140;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(230, 53);
            this.txtDescription.TabIndex = 49;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Enabled = false;
            this.txtTitle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(76, 15);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(169, 15);
            this.txtTitle.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(12, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(11, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(11, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Title";
            // 
            // cboEventTitles
            // 
            this.cboEventTitles.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEventTitles.FormattingEnabled = true;
            this.cboEventTitles.Location = new System.Drawing.Point(376, 134);
            this.cboEventTitles.Name = "cboEventTitles";
            this.cboEventTitles.Size = new System.Drawing.Size(173, 24);
            this.cboEventTitles.TabIndex = 46;
            this.cboEventTitles.SelectedIndexChanged += new System.EventHandler(this.cboEventTitles_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(260, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 23);
            this.label12.TabIndex = 45;
            this.label12.Text = "Event Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(107, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 25);
            this.label9.TabIndex = 65;
            this.label9.Text = "€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(179, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Cancellation Reason";
            // 
            // cboCancellation
            // 
            this.cboCancellation.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCancellation.FormattingEnabled = true;
            this.cboCancellation.Location = new System.Drawing.Point(376, 164);
            this.cboCancellation.Name = "cboCancellation";
            this.cboCancellation.Size = new System.Drawing.Size(199, 24);
            this.cboCancellation.TabIndex = 67;
            this.cboCancellation.SelectedIndexChanged += new System.EventHandler(this.cboCancellation_SelectedIndexChanged);
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpDetails.Controls.Add(this.label10);
            this.grpDetails.Controls.Add(this.label9);
            this.grpDetails.Controls.Add(this.cboAmPm);
            this.grpDetails.Controls.Add(this.label11);
            this.grpDetails.Controls.Add(this.txtMin);
            this.grpDetails.Controls.Add(this.txtHour);
            this.grpDetails.Controls.Add(this.cboTypes);
            this.grpDetails.Controls.Add(this.txtPrice);
            this.grpDetails.Controls.Add(this.btnCancelEvent);
            this.grpDetails.Controls.Add(this.txtTickets);
            this.grpDetails.Controls.Add(this.label8);
            this.grpDetails.Controls.Add(this.txtDate);
            this.grpDetails.Controls.Add(this.txtDescription);
            this.grpDetails.Controls.Add(this.txtTitle);
            this.grpDetails.Controls.Add(this.label7);
            this.grpDetails.Controls.Add(this.label6);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Location = new System.Drawing.Point(256, 213);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(270, 332);
            this.grpDetails.TabIndex = 68;
            this.grpDetails.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.mnuBack);
            this.panel2.Controls.Add(this.cboCancellation);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboEventTitles);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 206);
            this.panel2.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(289, 27);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(10);
            this.label14.Size = new System.Drawing.Size(190, 51);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cancel Event";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(171, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 66;
            this.label10.Text = "(optional)";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(-4, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 140);
            this.panel3.TabIndex = 70;
            // 
            // frmCancelEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 570);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grpDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCancelEvent";
            this.Text = "Bored\'n\'Kerry - [Cancel Event]";
            this.Load += new System.EventHandler(this.frmCancelEvent_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelEvent;
        private System.Windows.Forms.Button mnuBack;
        private System.Windows.Forms.ComboBox cboAmPm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.ComboBox cboTypes;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEventTitles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCancellation;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
    }
}