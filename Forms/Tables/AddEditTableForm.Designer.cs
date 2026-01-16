namespace CafeManagementSystem.Forms.Tables
{
    partial class AddEditTableForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelTop;
        private Label lblTitle;
        private Label lblTableNumber;
        private TextBox txtTableNumber;
        private Label lblCapacity;
        private NumericUpDown numCapacity;
        private Label lblRegion;
        private TextBox txtRegion;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Button btnSave;
        private Button btnCancel;

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
            this.lblTableNumber = new Label();
            this.txtTableNumber = new TextBox();
            this.lblCapacity = new Label();
            this.numCapacity = new NumericUpDown();
            this.lblRegion = new Label();
            this.txtRegion = new TextBox();
            this.lblStatus = new Label();
            this.cboStatus = new ComboBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.SuspendLayout();
            
            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(450, 60);
            this.panelTop.TabIndex = 0;
            
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Table";
            
            // lblTableNumber
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTableNumber.Location = new System.Drawing.Point(30, 90);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(100, 19);
            this.lblTableNumber.TabIndex = 1;
            this.lblTableNumber.Text = "Table Number:";
            
            // txtTableNumber
            this.txtTableNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTableNumber.Location = new System.Drawing.Point(30, 115);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(390, 25);
            this.txtTableNumber.TabIndex = 2;
            
            // lblCapacity
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCapacity.Location = new System.Drawing.Point(30, 160);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(65, 19);
            this.lblCapacity.TabIndex = 3;
            this.lblCapacity.Text = "Capacity:";
            
            // numCapacity
            this.numCapacity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCapacity.Location = new System.Drawing.Point(30, 185);
            this.numCapacity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(390, 25);
            this.numCapacity.TabIndex = 4;
            this.numCapacity.Value = new decimal(new int[] { 4, 0, 0, 0 });
            
            // lblRegion
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRegion.Location = new System.Drawing.Point(30, 230);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(55, 19);
            this.lblRegion.TabIndex = 5;
            this.lblRegion.Text = "Region:";
            
            // txtRegion
            this.txtRegion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegion.Location = new System.Drawing.Point(30, 255);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(390, 25);
            this.txtRegion.TabIndex = 6;
            
            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(30, 300);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 19);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            
            // cboStatus
            this.cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] { 
                CafeManagementSystem.Models.TableStatus.Available, 
                CafeManagementSystem.Models.TableStatus.Occupied, 
                CafeManagementSystem.Models.TableStatus.Reserved 
            });
            this.cboStatus.Location = new System.Drawing.Point(30, 325);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(390, 25);
            this.cboStatus.TabIndex = 8;
            this.cboStatus.SelectedIndex = 0;
            
            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);
            
            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(240, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            
            // AddEditTableForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtTableNumber);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditTableForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Add Table";
            
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
