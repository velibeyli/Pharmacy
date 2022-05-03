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
    public partial class SellMedicine : Form
    {
        private Medicine OrderedMedicine;
        private List<Medicine> orderedMedicines;

        private readonly PharmacyEntities1 _db;
        public SellMedicine()
        {
            InitializeComponent();
            _db = new PharmacyEntities1();
            orderedMedicines = new List<Medicine>();
        }

        private void SellMedicine_Load(object sender, EventArgs e)
        {
            UpdateMedicineDataGrid();
        }
        private void UpdateMedicineDataGrid(string med = "",string barcode = "")
        {
            List<Medicine> byName = _db.Medicines.Where(m => m.Name.Contains(med)).ToList();
            List<Medicine> byBarcode = _db.Medicines.Where(m => m.Barcode.Contains(barcode)).ToList();

            dgwMedicines.DataSource = byName.Intersect(byBarcode).Select(m => new
            {
                m.ID,
                m.Name,
                m.Barcode,
                m.Price,
                m.Count,
                m.Volume,
                Unit = m.Unit.Name
            }).ToList();
            dgwMedicines.Columns[0].Visible = false;
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            string medicine = txtSearchByName.Text.Trim();
            UpdateMedicineDataGrid(med: medicine);
        }

        private void txtSearchByBarcode_TextChanged(object sender, EventArgs e)
        {
            string barcode = txtSearchByBarcode.Text.Trim();
            UpdateMedicineDataGrid(barcode: barcode);
        }

        private void dgwMedicines_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgwMedicines.Rows[e.RowIndex].Cells[0].Value;

            OrderedMedicine = _db.Medicines.Find(id);

            txtMedicineName.Text = OrderedMedicine.Name;
            txtBarcode.Text = OrderedMedicine.Barcode;
            numCount.Maximum =Convert.ToDecimal( OrderedMedicine.Count);
        }

        private void numCount_ValueChanged(object sender, EventArgs e)
        {
            int count = (int)numCount.Value;
            numPrice.Value = (decimal)(count * OrderedMedicine.Price);
        }
    }
}
