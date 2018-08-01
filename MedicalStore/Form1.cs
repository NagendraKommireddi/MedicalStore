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

namespace MedicalStore
{
    public partial class MainForm : Form
    {
        //Main Calling Method
        public MainForm()
        {
            InitializeComponent();
            Database.SqlCon();
            MedicineListDetails();
        }
        //Medicine Details DataGridView
        public void MedicineListDetails()
        {
            //Database.ds.Tables[0].Columns.Add(new DataColumn("medStatus", typeof(string)));
            //foreach (DataRow row in Database.ds.Tables[0].Rows)
            //{
            //    if (Convert.ToInt32(row["medUnits"]) == 0)
            //    {
            //        row["medStatus"] = "Not Available";
            //    }
            //    else { row["medStatus"] = "Available"; }
            //}

            dataGridView1.DataSource = Database.ds.Tables[0];            
        }
        //Search Medicine Input Method
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Database.ds.Tables[0].DefaultView.RowFilter = "medName LIKE '" + textBox1.Text + "*'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new AddMedicine();
            addMedicine.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewBill newBill = new NewBill();
            newBill.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SavedBills savedBills = new SavedBills();
            savedBills.ShowDialog();
        }
    }
}
