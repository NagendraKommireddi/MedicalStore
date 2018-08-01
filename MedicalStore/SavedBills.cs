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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MedicalStore
{
    public partial class SavedBills : Form
    {
        //DataSet ds = new DataSet();
        DataTable dtSavedBills = new DataTable();
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
            dtSavedBills.DefaultView.RowFilter = "billDate >= '" + fromDate + "' AND billDate <= '" + toDate + "'";
        }
        //To fetch saved bill details from database
        public void SavedBillDetails()
        {
            string Sql1 = "SELECT * FROM savedBills";
            //Database.dataadapter = new SqlDataAdapter(Sql1, Database._con);
            //Database._con.Open();
            //Database.dataadapter.Fill(ds, "SavedBills");
            //Database._con.Close();
            //dataGridView1SavedBills.DataSource = ds.Tables[0];
            Database._con.Open();
            SqlCommand command = new SqlCommand(Sql1, Database._con);
            SqlDataReader sqlData = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();

            DataColumn dcbillId = new DataColumn("billId");
            dtSavedBills.Columns.Add(dcbillId);
            DataColumn billDate = new DataColumn("billDate");
            dtSavedBills.Columns.Add(billDate);
            DataColumn customerName = new DataColumn("customerName");
            dtSavedBills.Columns.Add(customerName);
            DataColumn customerContact = new DataColumn("customerContact");
            dtSavedBills.Columns.Add(customerContact);
            DataColumn medicineList = new DataColumn("medicineList");
            dtSavedBills.Columns.Add(medicineList);
            DataColumn totalPrice = new DataColumn("totalPrice");
            dtSavedBills.Columns.Add(totalPrice);

            while (sqlData.Read())
            {
                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream ms = new MemoryStream((byte[])sqlData["medicineList"]);
                //ms.Position = 0;
                List<MedicineList> temp = (List<MedicineList>)bf.Deserialize(ms);
                foreach (var item in temp)
                {
                    sb.Append(item.medName + "-" + item.medUnits + "-" + item.medPrice + ", ");
                }

                DataRow row = dtSavedBills.NewRow();
                row["billId"] = sqlData.GetValue(0);
                row["billDate"] = sqlData.GetValue(1);
                row["customerName"] = sqlData.GetValue(2);
                row["customerContact"] = sqlData.GetValue(3);
                row["medicineList"] = sb;
                
                row["totalPrice"] = sqlData.GetValue(5);
                dtSavedBills.Rows.Add(row);
                sb.Clear();
            }
            Database._con.Close();
            dataGridView1SavedBills.DataSource = dtSavedBills;
            dataGridView1SavedBills.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
