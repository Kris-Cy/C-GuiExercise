using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace CH13Num9GUI
{
    public partial class PayCalc : Form
    {
        public PayCalc()
        {
            InitializeComponent();
        }

        private void NumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void HourBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Double hours, rate, overtime, pay;
            hours = Convert.ToDouble(HourBox.Text);
            rate = Convert.ToDouble(RateBox.Text);
            overtime = rate * 1.5;
            if (hours <= 40)
                pay = hours * rate;
            else
                pay = (hours * rate) + ((hours - 40) * overtime);
            CalcLbl.Text = ("$" + pay.ToString("0.00"));
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("SavedValues.txt"))
            {
                writer.WriteLine(HourBox.Text);
                writer.WriteLine(RateBox.Text);
                writer.WriteLine(CalcLbl.Text);
            }
            MessageBox.Show("Values have been saved.");
        }

/* This assignment was done for a class assignment, on a school computer. As it stands, the code for the retrieve button will run on that computer, but not another one. 
 * I'll come back to change that.*/ 

/*

        private void RetrieveBtn_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader values = new StreamReader(@"C:\Users\kc-ro\source\repos\CH13Num9GUI\CH13Num9GUI\bin\Debug\SavedValues.txt");
            string FilePath = @"C:\Users\kc-ro\source\repos\CH13Num9GUI\CH13Num9GUI\bin\Debug\SavedValues.txt";
            string[] ReadText = File.ReadAllLines(@"C:\Users\kc-ro\source\repos\CH13Num9GUI\CH13Num9GUI\bin\Debug\SavedValues.txt");
            HourBox.Text = ReadText[0];
            RateBox.Text = ReadText[1];
            if (CalcLbl.Text == " ")
                CalcLbl.Text = " ";
            else
                CalcLbl.Text = ReadText[2];
            MessageBox.Show("Values have been retrieved.");
        }
*/

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NameBox.Text = " ";
            NumBox.Text = " ";
            HourBox.Text = " ";
            RateBox.Text = " ";
            CalcLbl.Text = " ";
        }
    }
}
