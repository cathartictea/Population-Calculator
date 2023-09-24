using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Local variables
            decimal populationSize;   //The population size
            decimal yearlyIncrease;   //The yearly increase
            int numberOfYears;        //The number of years
            int count = 1;            //Loop counter initialized with 1

            //Verify valid input for POPULATIONSIZE
            if (decimal.TryParse(startPopSizeTextBox.Text, out populationSize))
            {
                //Verify valid input for YEARLYINCREASE
                if (decimal.TryParse(yearlyIncreaseTextBox.Text, out yearlyIncrease))
                {
                    //Verify valid input for NUMBEROFYEARS
                    if (int.TryParse(numberofYearsTextBox.Text, out numberOfYears))
                    {
                        while (count <= numberOfYears)
                        {
                            populationSize = populationSize + ((yearlyIncrease/100) * populationSize);

                            //Display method
                            listBox1.Items.Add(count + "\t" + populationSize);

                            //Increase the count by 1
                            count += 1; // count = count + 1 
                        }
                    }
                    else
                    {
                        //Invalid... NUMBEROFYEARS
                        MessageBox.Show("Invalid value for number of years.");
                    }
                }
                else
                {
                    //Invalid... YEARLYINCREASE
                    MessageBox.Show("Invalid value for yearly increase.");
                }
            }
            else
            {
                //Invalid... POPULATIONSIZE
                MessageBox.Show("Invalid value for population size.");
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
