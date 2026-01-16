using CafeManagementSystem.Database;

namespace CafeManagementSystem.Forms.Customers;

public partial class CustomerManagementForm : Form
{
    public CustomerManagementForm()
    {
        InitializeComponent();
        LoadCustomers();
    }

    private void LoadCustomers()
    {
        lblInfo!.Text = "Customer management functionality will be implemented here.\nFeatures: View, add, edit customers, manage credit accounts, and track payments.";
    }

    private void btnClose_Click(object? sender, EventArgs e)
    {
        this.Close();
    }
}

partial class CustomerManagementForm
{
    private Label? lblInfo;
    private Button? btnClose;

    private void InitializeComponent()
    {
        this.lblInfo = new Label();
        this.btnClose = new Button();
        this.SuspendLayout();
        
        this.lblInfo.Location = new System.Drawing.Point(50, 50);
        this.lblInfo.Size = new System.Drawing.Size(700, 400);
        this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
        
        this.btnClose.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
        this.btnClose.FlatStyle = FlatStyle.Flat;
        this.btnClose.ForeColor = System.Drawing.Color.White;
        this.btnClose.Location = new System.Drawing.Point(650, 500);
        this.btnClose.Size = new System.Drawing.Size(100, 40);
        this.btnClose.Text = "Close";
        this.btnClose.Click += new EventHandler(this.btnClose_Click);
        
        this.ClientSize = new System.Drawing.Size(800, 600);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.lblInfo);
        this.Name = "CustomerManagementForm";
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Customer Management";
        this.ResumeLayout(false);
    }
}
