namespace Pharmacy2
{
    partial class AddMedicine
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkReceipt = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numVolume = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.dgwMedicines = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.Location = new System.Drawing.Point(12, 46);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(196, 31);
            this.txtMedicineName.TabIndex = 1;
            this.txtMedicineName.Leave += new System.EventHandler(this.txtMedicineName_Leave);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(244, 46);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(196, 31);
            this.txtBarcode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Location = new System.Drawing.Point(14, 108);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(195, 31);
            this.numPrice.TabIndex = 6;
            // 
            // numCount
            // 
            this.numCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCount.Location = new System.Drawing.Point(245, 108);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(195, 31);
            this.numCount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count";
            // 
            // chkReceipt
            // 
            this.chkReceipt.AutoSize = true;
            this.chkReceipt.Location = new System.Drawing.Point(13, 149);
            this.chkReceipt.Name = "chkReceipt";
            this.chkReceipt.Size = new System.Drawing.Size(105, 17);
            this.chkReceipt.TabIndex = 9;
            this.chkReceipt.Text = "Sell with Receipt";
            this.chkReceipt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Volume:";
            // 
            // numVolume
            // 
            this.numVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numVolume.Location = new System.Drawing.Point(13, 202);
            this.numVolume.Name = "numVolume";
            this.numVolume.Size = new System.Drawing.Size(195, 31);
            this.numVolume.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unit:";
            // 
            // cmbUnit
            // 
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(244, 201);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(196, 33);
            this.cmbUnit.TabIndex = 14;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.Maroon;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMedicine.Location = new System.Drawing.Point(503, 160);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(233, 74);
            this.btnAddMedicine.TabIndex = 15;
            this.btnAddMedicine.Text = "Add";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // dgwMedicines
            // 
            this.dgwMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMedicines.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedicines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwMedicines.Location = new System.Drawing.Point(0, 261);
            this.dgwMedicines.Name = "dgwMedicines";
            this.dgwMedicines.Size = new System.Drawing.Size(800, 270);
            this.dgwMedicines.TabIndex = 16;
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.dgwMedicines);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numVolume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkReceipt);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label1);
            this.Name = "AddMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMedicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkReceipt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.DataGridView dgwMedicines;
    }
}