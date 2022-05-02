﻿namespace Pharmacy2
{
    partial class SellMedicine
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
            this.dgwMedicines = new System.Windows.Forms.DataGridView();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSellMedicine = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchByBarcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMedicines
            // 
            this.dgwMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMedicines.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedicines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwMedicines.Location = new System.Drawing.Point(0, 267);
            this.dgwMedicines.Name = "dgwMedicines";
            this.dgwMedicines.Size = new System.Drawing.Size(922, 270);
            this.dgwMedicines.TabIndex = 17;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(255, 46);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(196, 31);
            this.txtBarcode.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Barcode:";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.Location = new System.Drawing.Point(23, 46);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(196, 31);
            this.txtMedicineName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name:";
            // 
            // numCount
            // 
            this.numCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCount.Location = new System.Drawing.Point(475, 47);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(195, 31);
            this.numCount.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Count";
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.BackColor = System.Drawing.Color.Maroon;
            this.btnSellMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedicine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSellMedicine.Location = new System.Drawing.Point(689, 39);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.Size = new System.Drawing.Size(195, 50);
            this.btnSellMedicine.TabIndex = 24;
            this.btnSellMedicine.Text = "Sell";
            this.btnSellMedicine.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchByBarcode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSearchByName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 69);
            this.panel1.TabIndex = 25;
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(12, 34);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(178, 31);
            this.txtSearchByName.TabIndex = 27;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Search by name";
            // 
            // txtSearchByBarcode
            // 
            this.txtSearchByBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByBarcode.Location = new System.Drawing.Point(255, 34);
            this.txtSearchByBarcode.Name = "txtSearchByBarcode";
            this.txtSearchByBarcode.Size = new System.Drawing.Size(178, 31);
            this.txtSearchByBarcode.TabIndex = 29;
            this.txtSearchByBarcode.TextChanged += new System.EventHandler(this.txtSearchByBarcode_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Search by barcode";
            // 
            // SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(922, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSellMedicine);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwMedicines);
            this.Name = "SellMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellMedicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SellMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMedicines;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSellMedicine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchByBarcode;
        private System.Windows.Forms.Label label5;
    }
}