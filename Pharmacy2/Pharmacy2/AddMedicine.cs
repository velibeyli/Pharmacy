using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Pharmacy2.Model;

namespace Pharmacy2
{
    public partial class AddMedicine : Form
    {
        private readonly PharmacyEntities1 _db;
        public AddMedicine()
        {
            InitializeComponent();
            _db = new PharmacyEntities1();
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            UpdateMedicineDataGrid();

            cmbUnit.DataSource = _db.Units.Select(u => new ComboItem
            {
                Text = u.Name,
                Value = u.ID
            }).ToList();

            //cmbUnit.DataSource = _db.Units.Select(m => m.Name).ToList();
        }

        private void UpdateMedicineDataGrid()
        {
            dgwMedicines.DataSource = _db.Medicines.Select(m => new {
                m.Name,
                m.Barcode,
                m.Price,
                m.Count,
                m.Volume,
                Unit = m.Unit.Name
            }).ToList();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string medicineName = txtMedicineName.Text.Trim();
            string barcode = txtBarcode.Text.Trim();
            decimal price = numPrice.Value;
            int count = (int)numCount.Value;
            bool hasReceipt = chkReceipt.Checked;
            int volume = (int)numVolume.Value;
            ComboItem unit = cmbUnit.SelectedItem as ComboItem;

            Medicine med = new Medicine()
            {
                Name = medicineName,
                Barcode = barcode,
                Price = price,
                Count = count,
                Volume = volume,
                HasReceipt = hasReceipt,
                UnitID = unit.Value
            };

            if (!CheckMedInput(med))
            {
                MessageBox.Show("Inputs are not valid");
                return;
            }

            if(txtBarcode.Enabled && CheckMedBarcode(txtBarcode.Text))
            {
                MessageBox.Show("This barcode was used by another medicine");
                return;
            }

            if (txtBarcode.Enabled)
            {
                //add new medicine
                _db.Medicines.Add(med);
                _db.SaveChanges();

                MessageBox.Show("New Medicine was successfully added");
            }
            else
            {
                //update count of existing medicine
                _db.Medicines.First(m => m.Barcode == txtBarcode.Text).Count += count;
                _db.SaveChanges();

                MessageBox.Show("Product was successfully updated");
            }

            UpdateMedicineDataGrid();
            ClearAddFormInputs();
        }

        private bool CheckMedInput(Medicine med)
        {
            if(string.IsNullOrEmpty(med.Name) ||
                string.IsNullOrEmpty(med.Barcode) ||
                med.Price <= 0 ||
                med.Count <= 0 ||
                med.Volume <= 0)
            {
                return false;
            }

            return true;
        }

        private void txtMedicineName_Leave(object sender, EventArgs e)
        {
            string medicineName = txtMedicineName.Text.Trim();

            if (!string.IsNullOrEmpty(medicineName))
            {
                Medicine medicine = _db.Medicines.FirstOrDefault(m => m.Name.ToLower() == medicineName.ToLower());

                if(medicine != null)
                {
                    txtBarcode.Text = medicine.Barcode;
                    txtBarcode.Enabled = false;
                }
                else
                {
                    txtBarcode.Text = "";
                    txtBarcode.Enabled = true;
                }
            }
        }

        private bool CheckMedBarcode(string barcode)
        {
            return _db.Medicines.FirstOrDefault(m => m.Barcode == barcode) != null;
        }

        private void ClearAddFormInputs()
        {
            foreach (var control in this.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                else if(control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
                else if(control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }
    }
}
