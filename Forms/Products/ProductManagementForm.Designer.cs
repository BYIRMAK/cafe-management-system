namespace CafeManagementSystem.Forms.Products
{
    partial class ProductManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewProducts;
        private Button btnAdd, btnEdit, btnDelete, btnClose;
        private Label lblTitle;
        private Panel panelTop, panelButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new Panel();
            this.lblTitle = new Label();
            this.panelButtons = new Panel();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnClose = new Button();
            this.dataGridViewProducts = new DataGridView();
            this.panelTop.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(900, 60);
            
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.Text = "Product Management";
            
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Dock = DockStyle.Bottom;
            this.panelButtons.Size = new System.Drawing.Size(900, 60);
            
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 10);
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.Text = "Add Product";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(130, 10);
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
            
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(240, 10);
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(780, 10);
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.Dock = DockStyle.Fill;
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 60);
            this.dataGridViewProducts.Size = new System.Drawing.Size(900, 480);
            
            this.dataGridViewProducts.Columns.Add("Id", "ID");
            this.dataGridViewProducts.Columns.Add("Name", "Product Name");
            this.dataGridViewProducts.Columns.Add("Category", "Category");
            this.dataGridViewProducts.Columns.Add("Price", "Price");
            this.dataGridViewProducts.Columns.Add("Stock", "Stock");
            this.dataGridViewProducts.Columns.Add("Barcode", "Barcode");
            this.dataGridViewProducts.Columns[0].Visible = false;
            
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.Name = "ProductManagementForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Product Management";
            
            this.panelTop.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
