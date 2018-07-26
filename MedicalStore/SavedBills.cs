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
    public partial class SavedBills : Form
    {
        DataSet ds = new DataSet();
        public string fromDate = "", toDate = "";

        public SavedBills()
        {
            InitializeComponent();
            Database.SqlCon();
            SavedBillDetails();
        }
        //From Date picker
        private void fromDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fromDate = fromDateTimePicker1.Value.ToString("dd-MM-yyyy");
        }
        //To Date picker
        private void ToDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            toDate = ToDateTimePicker2.Value.ToString("dd-MM-yyyy");
            ds.Tables[0].DefaultView.RowFilter = "billDate >= '" + fromDate + "' AND billDate <= '" + toDate + "'";
        }
        //To fetch saved bill details from database
        public void SavedBillDetails()
        {
            string Sql1 = "SELECT * FROM savedBills";
            Database.dataadapter = new SqlDataAdapter(Sql1, Database._con);
            Database._con.Open();
            Database.dataadapter.Fill(ds, "SavedBills");
            Database._con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
