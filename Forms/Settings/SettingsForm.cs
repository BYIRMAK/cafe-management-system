using CafeManagementSystem.Database;

namespace CafeManagementSystem.Forms.Settings;

public partial class SettingsForm : Form
{
    public SettingsForm()
    {
        InitializeComponent();
        LoadSettings();
    }

    private void LoadSettings()
    {
        lblInfo!.Text = "Settings and configuration management will be implemented here.\nFeatures:\n" +
                      "- Printer configuration\n" +
                      "- Personnel management\n" +
                      "- Reports and cash register\n" +
                      "- Supplier settings\n" +
                      "- Subscription/License information\n" +
                      "- General business settings";
    }

    private void btnClose_Click(object? sender, EventArgs e)
    {
        this.Close();
    }
}

partial class SettingsForm
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
        this.Name = "SettingsForm";
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Settings";
        this.ResumeLayout(false);
    }
}
