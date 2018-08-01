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
    public partial class NewBill : Form
    {
        
        public static List<MedicineList> medicineLists=new List<MedicineList>();

        string med1Name = "";
        int med1Units;
        int med1Price;
        int totalPrice = 0;
        string billDatePick = "";

        public NewBill()
        {
            InitializeComponent();
        }
        //New Bill Adding Method
        public void newBillAdding()
        {
            //int billId = 2345;
            string billDate = billDatePick;
            if(billDate == "") { billDate = DateTime.Now.ToString("dd-MM-yyyy"); }

            if (textBox1.Text == null && textBox2.Text == null && label11.Text == null)
            {
                newBillAlertLbl.Text = "Please fill all fields";
                newBillAlertLbl.ForeColor = SystemColors.GrayText;
            }
            else
            {


                string custName = textBox1.Text;
                string custContact = textBox2.Text;
                int totalPrice = Convert.ToInt32(label11.Text);

                //MessageBox.Show(billDate + "\n" + custName + "\n" + custContact + "\n" + totalPrice);

                try
                {
                    BinaryFormatter binFormat = new BinaryFormatter();
                    MemoryStream memStream = new MemoryStream();
                    binFormat.Serialize(memStream, medicineLists);

                    byte[] medListBytes = memStream.ToArray();
                    memStream.Write(medListBytes, 0, medListBytes.Length);

                    Database._con.Open();
                    SqlCommand command = new SqlCommand(@"INSERT INTO savedBills (billDate, customerName, customerContact, medicineList, totalPrice) VALUES 
                                                                                (@billDate, @custName, @custContact, @medListBytes, @totalPrice)", Database._con);
                    command.Parameters.AddWithValue("@billDate", billDate);
                    command.Parameters.AddWithValue("@custName", custName);
                    command.Parameters.AddWithValue("@custContact", custContact);
                    command.Parameters.AddWithValue("@medListBytes", medListBytes);
                    command.Parameters.AddWithValue("@totalPrice", totalPrice);
                    int queryResult = command.ExecuteNonQuery();
                    
                    if (queryResult > 0)
                    {
                        newBillAlertLbl.Text = "Bill Created";
                        newBillAlertLbl.ForeColor = SystemColors.HotTrack;
                        medicineLists.Clear();


                    }
                    else
                    {
                        newBillAlertLbl.Text = "Bill Not Added, Try again..!!!";
                        newBillAlertLbl.ForeColor = SystemColors.GrayText;
                    }
                    Database._con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    newBillAlertLbl.Text = "Something went wrong...!!!";
                    newBillAlertLbl.ForeColor = SystemColors.GrayText;
                }
            }
        }
        //Adding Medicine List

        private void button2_Click(object sender, EventArgs e)
        {
            med1Name = textBox3.Text;
            med1Units = Convert.ToInt32(textBox4.Text);
            med1Price = Convert.ToInt32(label10.Text);

            //medicineLists = new List<MedicineList>();
            medicineLists.Add(new MedicineList() { medName = med1Name, medUnits = med1Units, medPrice = med1Price });
            medicinesListView1.Clear();
            foreach (var med in medicineLists)
            {
                medicinesListView1.Items.Add(med.medName + " - " + med.medUnits.ToString() + " - " + med.medPrice.ToString() + "\n");
                
            }
        }
        //Units update in Total
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int unitCost = 0;
                int unitSetCost = 0;
                string numUnits = textBox4.Text;
                if (numUnits == "") { numUnits = "0"; }

                int units = Convert.ToInt32(numUnits);
                var price = Database.ds.Tables[0]
                        .AsEnumerable()
                        .Where(x => x.Field<string>("medName") == textBox3.Text)
                        .Select(y => y.Field<int>("unitPrice"));
                foreach(var p in price)
                {
                    unitCost = Convert.ToInt32(p);
                }
                unitSetCost = units * unitCost;
                totalPrice = totalPrice + unitSetCost;
                label11.Text = totalPrice.ToString();
                label10.Text = Convert.ToString(unitSetCost);
                newBillAlertLbl.Text = "";
            }
            catch(Exception ex)
            {
                newBillAlertLbl.Text = "Enter Numbers only...!!";
                Console.WriteLine("Exception : {0}", ex.Message);
            }
        }
        //Bill Date Picker Value
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            billDatePick = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }
        //Submit Button
        public void button4_Click(object sender, EventArgs e)
        {
            newBillAdding();
            medicineLists.Clear();
            foreach (Control @controls in Controls)
            {
                if (@controls is TextBox)
                {
                    @controls.Text = String.Empty;
                }
            }
        }
        //Cancel Button
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You wanna close me?", "Conformation pending :", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string[] autocomplete = Database.ds.Tables[0]
                          .AsEnumerable()
                          .Select<System.Data.DataRow, String>(x => x.Field<String>("medName"))
                          .ToArray();


            var source = new AutoCompleteStringCollection();
            source.AddRange(autocomplete);
            textBox3.AutoCompleteCustomSource = source;
            //textBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            //for (int i = 0; i < Database.ds.Tables[0].Rows.Count; i++)
            //{
            //    DataRow dataRow = Database.ds.Tables[0].Rows[i];
            //    //dataRow.Field<string>(2);
            //    autoCompleteString.Add(dataRow.Field<string>(2));
            //}
            //textBox3.AutoCompleteCustomSource = autoCompleteString;
        }
    }
    [Serializable]
    public class MedicineList
    {
        public string medName;
        public int medUnits;
        public int medPrice;
    }
}
