using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStore
{
    public partial class NewBill : Form
    {

        List<MedicineList> medicineLists;
        string med1Name = "";
        int med1Units;
        int med1Price;
        string billDatePick = "";

        public NewBill()
        {
            InitializeComponent();
        }
        //Bill Date Picker Value
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            billDatePick = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }
        //New Bill Adding Method
        public void newBillAdding()
        {
            int billId = 2345;
            string billDate = billDatePick;
            string custName = textBox1.Text;
            string custContact = textBox2.Text;
            int totalPrice = Convert.ToInt32(label11.Text);
            int totalUnits = Convert.ToInt32(label14.Text);

            MessageBox.Show(billId + "\n" + billDate + "\n" + custName + "\n" + custContact + "\n" + totalPrice + "\n" + totalUnits);
        }
        //Adding Medicine List
        private void button2_Click(object sender, EventArgs e)
        {
            med1Name = textBox3.Text;
            med1Units = Convert.ToInt32(textBox4.Text);
            med1Price = Convert.ToInt32(label10.Text);

            medicineLists = new List<MedicineList>();
            medicineLists.Add(new MedicineList() { medName = med1Name, medUnits = med1Units, medPrice = med1Price });
            foreach (var med in medicineLists)
            {
                medicinesListView1.Items.Add(med.medName);
                medicinesListView1.Items.Add(med.medUnits.ToString());
                medicinesListView1.Items.Add(med.medPrice.ToString());
            }
        }
        //Units update in Total
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string numUnits = "";
            numUnits = (Convert.ToInt32(textBox4.Text) * 8).ToString();
            label10.Text = Convert.ToString(numUnits);
        }
        //Submit Button
        public void button4_Click(object sender, EventArgs e)
        {
            newBillAdding();
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
    }
    public class MedicineList
    {
        public string medName;
        public int medUnits;
        public int medPrice;
    }
}
