namespace CafeManagementSystem.Forms.Tables
{
    partial class TableManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewTables;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClose;
        private Label lblTitle;
        private Panel panelTop;
        private Panel panelButtons;

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
            this.panelButtons = new Panel();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnClose = new Button();
            this.dataGridViewTables = new DataGridView();
            
            this.panelTop.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            this.SuspendLayout();
            
            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 60);
            this.panelTop.TabIndex = 0;
            
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Table Management";
            
            // panelButtons
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Dock = DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 540);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(900, 60);
            this.panelButtons.TabIndex = 2;
            
            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Table";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            
            // btnEdit
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(130, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Table";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
            
            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(240, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            
            // btnClose
            this.btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(780, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            
            // dataGridViewTables
            this.dataGridViewTables.AllowUserToAddRows = false;
            this.dataGridViewTables.AllowUserToDeleteRows = false;
            this.dataGridViewTables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTables.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Dock = DockStyle.Fill;
            this.dataGridViewTables.Location = new System.Drawing.Point(0, 60);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.ReadOnly = true;
            this.dataGridViewTables.RowHeadersWidth = 51;
            this.dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTables.Size = new System.Drawing.Size(900, 480);
            this.dataGridViewTables.TabIndex = 1;
            
            // Add columns
            this.dataGridViewTables.Columns.Add("Id", "ID");
            this.dataGridViewTables.Columns.Add("TableNumber", "Table Number");
            this.dataGridViewTables.Columns.Add("Capacity", "Capacity");
            this.dataGridViewTables.Columns.Add("Region", "Region");
            this.dataGridViewTables.Columns.Add("Status", "Status");
            
            this.dataGridViewTables.Columns[0].Visible = false; // Hide ID column
            
            // TableManagementForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dataGridViewTables);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "TableManagementForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Table Management";
            
            this.panelTop.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
