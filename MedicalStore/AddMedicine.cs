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
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
        }
        //Adding Medicine Details
        public void AddMedicineDetails()
        {
            string medId = medIdTextBox1.Text;
            string medName = medNameTextBox2.Text;
            int medUnits = Convert.ToInt32(medUnitsTextBox3.Text);
            int unitPrice = Convert.ToInt32(medPriceTextBox4.Text);

            try
            {
                Database._con.Open();
                SqlCommand command = new SqlCommand(@"IF NOT EXISTS (SELECT * FROM medicines WHERE medName = @medName) BEGIN INSERT INTO medicines (medId, medName, medUnits, unitPrice) VALUES (@medId, @medName, @medUnits, @unitPrice); END", Database._con);
                command.Parameters.AddWithValue("@medId", medId);
                command.Parameters.AddWithValue("@medName", medName);
                command.Parameters.AddWithValue("@medUnits", medUnits);
                command.Parameters.AddWithValue("@unitPrice", unitPrice);
                int queryResult = command.ExecuteNonQuery();
                Database.dataadapter.Fill(Database.ds, "Medicines");
                Database._con.Close();
                if (queryResult > 0)
                {
                    alertLabel6.Text = "New Medicine Added Successfully";
                    alertLabel6.ForeColor = SystemColors.HotTrack;
                    foreach(Control @controls in Controls)
                    {
                        if(@controls is TextBox)
                        {
                            @controls.Text = String.Empty;
                        }
                    }
                    //medIdTextBox1.Text = "";
                    //medNameTextBox2.Text = "";
                    //medUnitsTextBox3.Text = "";
                }
                else
                {
                    alertLabel6.Text = "New Medicine Not Added, Try again..!!!";
                    alertLabel6.ForeColor = SystemColors.GrayText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                alertLabel6.Text = "Something went wrong...!!!";
                alertLabel6.ForeColor = SystemColors.GrayText;
            }
        }
        //Add Medicine Details Button
        private void button4_Click(object sender, EventArgs e)
        {
            AddMedicineDetails();
        }
        //Close Window
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void medNameTextBox2_TextChanged(object sender, EventArgs e)
        {
            //MainForm.ds.Tables[0].DefaultView.RowFilter = "medName LIKE '" + medNameTextBox2.Text + "*'";
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            for (int i = 0; i < Database.ds.Tables[0].Rows.Count; i++)
            {
                DataRow dataRow = Database.ds.Tables[0].Rows[i];
                //dataRow.Field<string>(2);
                autoCompleteString.Add(dataRow.Field<string>(2));
            }
            medNameTextBox2.AutoCompleteCustomSource = autoCompleteString;
        }
    }
}
