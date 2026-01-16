namespace CafeManagementSystem.Forms.Main
{
    partial class MainDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelTop;
        private Panel panelSide;
        private Panel panelMain;
        private Label lblTitle;
        private Label lblWelcome;
        private Button btnLogout;
        private Button btnTableManagement;
        private Button btnProductManagement;
        private Button btnQuickSale;
        private Button btnReservations;
        private Button btnCustomers;
        private Button btnSettings;
        private Button btnRefresh;
        private Panel panelStats;
        private Label lblTodaySales;
        private Label lblOccupancy;
        private Label lblActiveOrders;
        private Label lblReservations;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new Panel();
            this.lblTitle = new Label();
            this.lblWelcome = new Label();
            this.btnLogout = new Button();
            this.btnRefresh = new Button();
            this.panelSide = new Panel();
            this.btnTableManagement = new Button();
            this.btnProductManagement = new Button();
            this.btnQuickSale = new Button();
            this.btnReservations = new Button();
            this.btnCustomers = new Button();
            this.btnSettings = new Button();
            this.panelMain = new Panel();
            this.panelStats = new Panel();
            this.lblTodaySales = new Label();
            this.lblOccupancy = new Label();
            this.lblActiveOrders = new Label();
            this.lblReservations = new Label();
            
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            
            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 80);
            this.panelTop.TabIndex = 0;
            
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cafe Management System";
            
            // lblWelcome
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, User";
            
            // btnRefresh
            this.btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1000, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 40);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            
            // btnLogout
            this.btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1100, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            
            // panelSide
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelSide.Controls.Add(this.btnTableManagement);
            this.panelSide.Controls.Add(this.btnProductManagement);
            this.panelSide.Controls.Add(this.btnQuickSale);
            this.panelSide.Controls.Add(this.btnReservations);
            this.panelSide.Controls.Add(this.btnCustomers);
            this.panelSide.Controls.Add(this.btnSettings);
            this.panelSide.Dock = DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 80);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 620);
            this.panelSide.TabIndex = 1;
            
            // Create side menu buttons
            int buttonY = 20;
            int buttonHeight = 50;
            int buttonSpacing = 10;
            
            // btnTableManagement
            this.btnTableManagement.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnTableManagement.FlatStyle = FlatStyle.Flat;
            this.btnTableManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTableManagement.ForeColor = System.Drawing.Color.White;
            this.btnTableManagement.Location = new System.Drawing.Point(10, buttonY);
            this.btnTableManagement.Name = "btnTableManagement";
            this.btnTableManagement.Size = new System.Drawing.Size(180, buttonHeight);
            this.btnTableManagement.TabIndex = 0;
            this.btnTableManagement.Text = "Table Management";
            this.btnTableManagement.UseVisualStyleBackColor = false;
            this.btnTableManagement.Click += new EventHandler(this.btnTableManagement_Click);
            buttonY += buttonHeight + buttonSpacing;
            
            // btnProductManagement
            this.btnProductManagement.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnProductManagement.FlatStyle = FlatStyle.Flat;
            this.btnProductManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProductManagement.ForeColor = System.Drawing.Color.White;
            this.btnProductManagement.Location = new System.Drawing.Point(10, buttonY);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(180, buttonHeight);
            this.btnProductManagement.TabIndex = 1;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = false;
            this.btnProductManagement.Click += new EventHandler(this.btnProductManagement_Click);
            buttonY += buttonHeight + buttonSpacing;
            
            // btnQuickSale
            this.btnQuickSale.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnQuickSale.FlatStyle = FlatStyle.Flat;
            this.btnQuickSale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuickSale.ForeColor = System.Drawing.Color.White;
            this.btnQuickSale.Location = new System.Drawing.Point(10, buttonY);
            this.btnQuickSale.Name = "btnQuickSale";
            this.btnQuickSale.Size = new System.Drawing.Size(180, buttonHeight);
            this.btnQuickSale.TabIndex = 2;
            this.btnQuickSale.Text = "Quick Sale";
            this.btnQuickSale.UseVisualStyleBackColor = false;
            this.btnQuickSale.Click += new EventHandler(this.btnQuickSale_Click);
            buttonY += buttonHeight + buttonSpacing;
            
            // btnReservations
            this.btnReservations.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnReservations.FlatStyle = FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.Location = new System.Drawing.Point(10, buttonY);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(180, buttonHeight);
            this.btnReservations.TabIndex = 3;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new EventHandler(this.btnReservations_Click);
            buttonY += buttonHeight + buttonSpacing;
            
            // btnCustomers
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnCustomers.FlatStyle = FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(10, buttonY);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(180, buttonHeight);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new EventHandler(this.btnCustomers_Click);
            buttonY += buttonHeight + buttonSpacing;
            
            // btnSettings
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnSettings.FlatStyle = FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(10, buttonY);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(180, buttonHeight);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new EventHandler(this.btnSettings_Click);
            
            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.panelMain.Controls.Add(this.panelStats);
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1000, 620);
            this.panelMain.TabIndex = 2;
            
            // panelStats
            this.panelStats.BackColor = System.Drawing.Color.White;
            this.panelStats.BorderStyle = BorderStyle.FixedSingle;
            this.panelStats.Controls.Add(this.lblTodaySales);
            this.panelStats.Controls.Add(this.lblOccupancy);
            this.panelStats.Controls.Add(this.lblActiveOrders);
            this.panelStats.Controls.Add(this.lblReservations);
            this.panelStats.Location = new System.Drawing.Point(40, 40);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(920, 200);
            this.panelStats.TabIndex = 0;
            
            // Statistics labels
            int labelX = 30;
            int labelY = 30;
            int labelWidth = 400;
            int labelHeight = 30;
            int labelSpacing = 40;
            
            // lblTodaySales
            this.lblTodaySales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTodaySales.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblTodaySales.Location = new System.Drawing.Point(labelX, labelY);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.lblTodaySales.TabIndex = 0;
            this.lblTodaySales.Text = "Today's Sales: $0.00";
            labelY += labelSpacing;
            
            // lblOccupancy
            this.lblOccupancy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOccupancy.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblOccupancy.Location = new System.Drawing.Point(labelX, labelY);
            this.lblOccupancy.Name = "lblOccupancy";
            this.lblOccupancy.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.lblOccupancy.TabIndex = 1;
            this.lblOccupancy.Text = "Table Occupancy: 0/0";
            labelY += labelSpacing;
            
            // lblActiveOrders
            this.lblActiveOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActiveOrders.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblActiveOrders.Location = new System.Drawing.Point(labelX, labelY);
            this.lblActiveOrders.Name = "lblActiveOrders";
            this.lblActiveOrders.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.lblActiveOrders.TabIndex = 2;
            this.lblActiveOrders.Text = "Active Orders: 0";
            
            labelX = 500;
            labelY = 30;
            
            // lblReservations
            this.lblReservations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReservations.ForeColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.lblReservations.Location = new System.Drawing.Point(labelX, labelY);
            this.lblReservations.Name = "lblReservations";
            this.lblReservations.Size = new System.Drawing.Size(labelWidth, labelHeight);
            this.lblReservations.TabIndex = 3;
            this.lblReservations.Text = "Today's Reservations: 0";
            
            // MainDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainDashboardForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Cafe Management System - Dashboard";
            this.WindowState = FormWindowState.Maximized;
            
            this.panelTop.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
