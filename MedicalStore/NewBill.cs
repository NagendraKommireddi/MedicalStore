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

            string med1Name = textBox3.Text;
            int med1Units = Convert.ToInt32(textBox4.Text);
            int med1Price = Convert.ToInt32(label10.Text);

            List<MedicineList> medicineLists = new List<MedicineList>();
            medicineLists.Add(new MedicineList() { medName = med1Name, medUnits = med1Units, medPrice = med1Price });

            MessageBox.Show(billId + "\n" + billDate + "\n" + custName + "\n" + custContact + "\n" + totalPrice + "\n" + totalUnits);
        }
        //Units update in Total
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int numUnits = 0;
            numUnits = Convert.ToInt32(textBox4.Text) * 8;
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
    public class AddMedicineList : Form
    {
        public static int xText = 347, xNum = 502, xLbl9 = 571, xLbl10 = 604;
        public static int y = 177;

        TextBox medTextBox1 = new TextBox();
        NumericUpDown unitsNumUpDown1 = new NumericUpDown();
        Label rsLabel = new Label();
        Label costLabel = new Label();

        Point p1 = new Point(xText, y);
        Point p2 = new Point(xNum, y);
        Point p3 = new Point(xLbl9, y);
        Point p4 = new Point(xLbl10, y);

    }
}
