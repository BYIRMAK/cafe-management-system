namespace CafeManagementSystem.Forms.Products
{
    partial class AddEditProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelTop;
        private Label lblTitle, lblName, lblCategory, lblPrice, lblStock, lblBarcode;
        private TextBox txtName, txtCategory, txtBarcode;
        private NumericUpDown numPrice, numStock;
        private Button btnSave, btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new Panel();
            this.lblTitle = new Label();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblCategory = new Label();
            this.txtCategory = new TextBox();
            this.lblPrice = new Label();
            this.numPrice = new NumericUpDown();
            this.lblStock = new Label();
            this.numStock = new NumericUpDown();
            this.lblBarcode = new Label();
            this.txtBarcode = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.SuspendLayout();
            
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(450, 60);
            
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.Text = "Add Product";
            
            int y = 90;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, y);
            this.lblName.Text = "Product Name:";
            
            this.txtName.Location = new System.Drawing.Point(30, y+20);
            this.txtName.Size = new System.Drawing.Size(390, 25);
            
            y += 70;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, y);
            this.lblCategory.Text = "Category:";
            
            this.txtCategory.Location = new System.Drawing.Point(30, y+20);
            this.txtCategory.Size = new System.Drawing.Size(390, 25);
            
            y += 70;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, y);
            this.lblPrice.Text = "Price:";
            
            this.numPrice.Location = new System.Drawing.Point(30, y+20);
            this.numPrice.Size = new System.Drawing.Size(390, 25);
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Maximum = 10000;
            
            y += 70;
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(30, y);
            this.lblStock.Text = "Stock Quantity:";
            
            this.numStock.Location = new System.Drawing.Point(30, y+20);
            this.numStock.Size = new System.Drawing.Size(390, 25);
            this.numStock.Maximum = 10000;
            
            y += 70;
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(30, y);
            this.lblBarcode.Text = "Barcode (optional):";
            
            this.txtBarcode.Location = new System.Drawing.Point(30, y+20);
            this.txtBarcode.Size = new System.Drawing.Size(390, 25);
            
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 480);
            this.btnSave.Size = new System.Drawing.Size(180, 40);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new EventHandler(this.btnSave_Click);
            
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(240, 480);
            this.btnCancel.Size = new System.Drawing.Size(180, 40);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 550);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddEditProductForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Add Product";
            
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
