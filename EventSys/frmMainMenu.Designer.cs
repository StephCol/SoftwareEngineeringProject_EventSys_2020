namespace EventSys
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVenuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegVenue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdVenue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelVenue = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.makeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSignUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTopUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnVenues = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnRev = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVenuesToolStripMenuItem,
            this.manageEventsToolStripMenuItem,
            this.makeToolStripMenuItem,
            this.mnuExit,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVenuesToolStripMenuItem
            // 
            this.manageVenuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegVenue,
            this.mnuUpdVenue,
            this.mnuDelVenue});
            this.manageVenuesToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageVenuesToolStripMenuItem.Name = "manageVenuesToolStripMenuItem";
            this.manageVenuesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.manageVenuesToolStripMenuItem.Text = "Manage Venues";
            this.manageVenuesToolStripMenuItem.Click += new System.EventHandler(this.manageVenuesToolStripMenuItem_Click);
            // 
            // mnuRegVenue
            // 
            this.mnuRegVenue.Name = "mnuRegVenue";
            this.mnuRegVenue.Size = new System.Drawing.Size(184, 22);
            this.mnuRegVenue.Text = "Register Venue";
            this.mnuRegVenue.Click += new System.EventHandler(this.mnuRegVenue_Click);
            // 
            // mnuUpdVenue
            // 
            this.mnuUpdVenue.Name = "mnuUpdVenue";
            this.mnuUpdVenue.Size = new System.Drawing.Size(184, 22);
            this.mnuUpdVenue.Text = "Update Venue";
            this.mnuUpdVenue.Click += new System.EventHandler(this.mnuUpdVenue_Click);
            // 
            // mnuDelVenue
            // 
            this.mnuDelVenue.Name = "mnuDelVenue";
            this.mnuDelVenue.Size = new System.Drawing.Size(184, 22);
            this.mnuDelVenue.Text = "Delete Venue";
            this.mnuDelVenue.Click += new System.EventHandler(this.mnuDelVenue_Click);
            // 
            // manageEventsToolStripMenuItem
            // 
            this.manageEventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddEvent,
            this.mnuUpdEvent,
            this.mnuCancelEvent});
            this.manageEventsToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEventsToolStripMenuItem.Name = "manageEventsToolStripMenuItem";
            this.manageEventsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.manageEventsToolStripMenuItem.Text = "Manage Events";
            this.manageEventsToolStripMenuItem.Click += new System.EventHandler(this.manageEventsToolStripMenuItem_Click);
            // 
            // mnuAddEvent
            // 
            this.mnuAddEvent.Name = "mnuAddEvent";
            this.mnuAddEvent.Size = new System.Drawing.Size(180, 22);
            this.mnuAddEvent.Text = "Add Event";
            this.mnuAddEvent.Click += new System.EventHandler(this.mnuAddEvent_Click);
            // 
            // mnuUpdEvent
            // 
            this.mnuUpdEvent.Name = "mnuUpdEvent";
            this.mnuUpdEvent.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdEvent.Text = "Update Event";
            this.mnuUpdEvent.Click += new System.EventHandler(this.mnuUpdEvent_Click);
            // 
            // mnuCancelEvent
            // 
            this.mnuCancelEvent.Name = "mnuCancelEvent";
            this.mnuCancelEvent.Size = new System.Drawing.Size(180, 22);
            this.mnuCancelEvent.Text = "Cancel Event";
            this.mnuCancelEvent.Click += new System.EventHandler(this.mnuCancelEvent_Click);
            // 
            // makeToolStripMenuItem
            // 
            this.makeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSignUp,
            this.mnuTopUp,
            this.mnuMakeBooking,
            this.mnuCancelBooking});
            this.makeToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeToolStripMenuItem.Name = "makeToolStripMenuItem";
            this.makeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.makeToolStripMenuItem.Text = "Manage Bookings";
            // 
            // mnuSignUp
            // 
            this.mnuSignUp.Name = "mnuSignUp";
            this.mnuSignUp.Size = new System.Drawing.Size(204, 22);
            this.mnuSignUp.Text = "Sign Up Customer";
            this.mnuSignUp.Click += new System.EventHandler(this.mnuSignUp_Click);
            // 
            // mnuTopUp
            // 
            this.mnuTopUp.Name = "mnuTopUp";
            this.mnuTopUp.Size = new System.Drawing.Size(204, 22);
            this.mnuTopUp.Text = "Top Up Account";
            this.mnuTopUp.Click += new System.EventHandler(this.mnuTopUp_Click);
            // 
            // mnuMakeBooking
            // 
            this.mnuMakeBooking.Name = "mnuMakeBooking";
            this.mnuMakeBooking.Size = new System.Drawing.Size(204, 22);
            this.mnuMakeBooking.Text = "Make Booking";
            this.mnuMakeBooking.Click += new System.EventHandler(this.mnuMakeBooking_Click);
            // 
            // mnuCancelBooking
            // 
            this.mnuCancelBooking.Name = "mnuCancelBooking";
            this.mnuCancelBooking.Size = new System.Drawing.Size(204, 22);
            this.mnuCancelBooking.Text = "Cancel Booking";
            this.mnuCancelBooking.Click += new System.EventHandler(this.mnuCancelBooking_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(49, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnVenues,
            this.mnuAnRev});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuAnVenues
            // 
            this.mnuAnVenues.Name = "mnuAnVenues";
            this.mnuAnVenues.Size = new System.Drawing.Size(198, 22);
            this.mnuAnVenues.Text = "Analyse Venues";
            this.mnuAnVenues.Click += new System.EventHandler(this.mnuAnVenues_Click);
            // 
            // mnuAnRev
            // 
            this.mnuAnRev.Name = "mnuAnRev";
            this.mnuAnRev.Size = new System.Drawing.Size(198, 22);
            this.mnuAnRev.Text = "Analyse Revenue";
            this.mnuAnRev.Click += new System.EventHandler(this.mnuAnRev_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(103, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 280);
            this.panel1.TabIndex = 1;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVenuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRegVenue;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdVenue;
        private System.Windows.Forms.ToolStripMenuItem mnuDelVenue;
        private System.Windows.Forms.ToolStripMenuItem manageEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddEvent;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdEvent;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelEvent;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSignUp;
        private System.Windows.Forms.ToolStripMenuItem mnuTopUp;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAnVenues;
        private System.Windows.Forms.ToolStripMenuItem mnuAnRev;
        private System.Windows.Forms.Panel panel1;
    }
}