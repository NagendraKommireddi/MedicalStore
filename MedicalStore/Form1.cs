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
        Database db = new Database();
        //List<MedicineList> medList;
        DataSet ds = new DataSet();
        
        public MainForm()
        {
            InitializeComponent();
            Database.SqlCon();
            MedicineListDetails();
        }

        public void MedicineListDetails()
        {
            //medList = new List<MedicineList>();
            //medList.Add(new MedicineList { sno = 1, medName = "Acetaminophen", medUnits = 23, medId = 3456, unitPrice = 450, medStatus = "Available" });
            //medList.Add(new MedicineList { sno = 2, medName = "Adderall", medUnits = 10, medId = 3457, unitPrice = 700, medStatus = "Available" });
            //medList.Add(new MedicineList { sno = 3, medName = "Alprazolam", medUnits = 4, medId = 3457, unitPrice = 780, medStatus = "Available" });
            //medList.Add(new MedicineList { sno = 4, medName = "Citalopram", medUnits = 230, medId = 3458, unitPrice = 9000, medStatus = "Available" });
            //medList.Add(new MedicineList { sno = 5, medName = "Doxycycline", medUnits = 0, medId = 3459, unitPrice = 100, medStatus = "Not Available" });
            //medList.Add(new MedicineList { sno = 6, medName = "Gabapentin", medUnits = 30, medId = 3410, unitPrice = 200, medStatus = "Available" });
            //medList.Add(new MedicineList { sno = 7, medName = "Metformin", medUnits = 50, medId = 3411, unitPrice = 500, medStatus = "Available" });
            //medList.Add(new MedicineList { sno = 8, medName = "Metoprolol", medUnits = 0, medId = 3427, unitPrice = 800, medStatus = "Not Available" });
            //medList.Add(new MedicineList { sno = 9, medName = "Naproxen", medUnits = 0, medId = 3497, unitPrice = 790, medStatus = "Not Available" });
            //medList.Add(new MedicineList { sno = 10, medName = "Omeprazole", medUnits = 560, medId = 3407, unitPrice = 800, medStatus = "Available" });
            //medList.Add(new MedicineList { sno = 11, medName = "Oxycodone", medUnits = 1, medId = 3477, unitPrice = 790, medStatus = "Available" });
            //dataGridView1.DataSource = medList;
            
            string Sql1 = "SELECT * FROM medicines";
            //Database.command = new SqlCommand(Sql1, Database._con);
            //Database.dataReader = Database.command.ExecuteReader();
            Database.dataadapter = new SqlDataAdapter(Sql1, Database._con);
            Database._con.Open();
            Database.dataadapter.Fill(ds, "Medicines");
            Database._con.Close();
            dataGridView1.DataSource = ds.Tables[0];
            //MessageBox.Show(ds.Tables[0].Columns.Count.ToString());
            //foreach (DataColumn column in ds.Tables[0].Columns)
            //{
            //    MessageBox.Show(column.ColumnName);
            //}


                //while (Database.dataReader.Read())
                //{
                //    object[] row = new object[] {
                //        Database.dataReader.GetValue(0),
                //        Database.dataReader.GetValue(1),
                //        Database.dataReader.GetValue(2),
                //        Database.dataReader.GetValue(3),
                //        Database.dataReader.GetValue(4),
                //        Database.dataReader.GetValue(5)
                //    };
                //    dataGridView1.Rows.Add(row);
                //}


                //foreach (var med in medList)
                //{
                //    textBox1.AutoCompleteCustomSource.Add(med.medName);
                //}            
            }

            private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataView dv = new DataView(ds.Tables[0], "medName = 'Adderall'", "medName Desc", DataViewRowState.CurrentRows);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var strExpr = "medName" = textBox1.Text;
            //string inputMed = textBox1.Text + "*";
            ds.Tables[0].DefaultView.RowFilter = "medName LIKE '" + textBox1.Text + "*'";
        }
    }

    public class MedicineList
    {
        public int sno { get; set; }
        public int medId { get; set; }
        public string medName { get; set; }
        public int medUnits { get; set; }
        public int unitPrice { get; set; }
        public string medStatus { get; set; }

    }
}
