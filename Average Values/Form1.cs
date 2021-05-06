using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average_Values
{
    public partial class Form1 : Form
    {
        //Global varriables
        double sum = 0;
        int entries = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                double number = 0;
                double average = 0;

                number = Convert.ToDouble(numberInput.Text);
                if (number != 0)
                {
                    sum = sum + number;
                    entries++;
                    numberAdded.Text = $"{number} was added to the sum";
                    numberInput.Text = "";
                }
                else
                {
                    average = sum / entries;
                    numberAdded.Text = $"The average of all numbers entered is: \n {average.ToString("0.00")}";
                    numberInput.Visible = false;
                    addButton.Visible = false;
                }
            }
            catch
            {
                numberAdded.Text = $"You must use a number";
            }
        }
    }
}
