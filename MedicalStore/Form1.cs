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
        DataSet ds = new DataSet();
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
            string Sql1 = "SELECT * FROM medicines";
            Database.dataadapter = new SqlDataAdapter(Sql1, Database._con);
            Database._con.Open();
            Database.dataadapter.Fill(ds, "Medicines");
            Database._con.Close();
            dataGridView1.DataSource = ds.Tables[0];            
        }
        //Search Medicine Input Method
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ds.Tables[0].DefaultView.RowFilter = "medName LIKE '" + textBox1.Text + "*'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewBill newBill = new NewBill();
            newBill.ShowDialog();
        }
    }
}
