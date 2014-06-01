using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace axisScaling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.Minimum = -240;
        }

        private void textBoxXaxisMax_TextChanged(object sender, EventArgs e)
        {
            double x;
            //checks if the Entering is a double number and if it is greater than the min value
            if (Double.TryParse(this.textBoxXaxisMax.Text, out x) && x > chart1.ChartAreas[0].AxisX.Minimum)
            {
                this.textBoxXaxisMax.BackColor = Color.White;
                chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(this.textBoxXaxisMax.Text);

                //method to 

            }
            else
                //if not the textbox is highlighted 
                this.textBoxXaxisMax.BackColor = Color.Orange;


            //calls the Min Function to update the chart if the Min-value is now valid
            double y;
            //checks if the Entering is a double number and if it is smaler than the max value
            if (Double.TryParse(this.textBoxXaxisMax.Text, out y) && y < chart1.ChartAreas[0].AxisX.Maximum)
            {
                this.textBoxXaxisMin.BackColor = Color.White;
                chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(this.textBoxXaxisMin.Text);
            }
            else
                //if not the textbox is highlighted 
                this.textBoxXaxisMin.BackColor = Color.Orange;
        }

        private void textBoxXaxisMin_TextChanged(object sender, EventArgs e)
        {
            double x;
            //checks if the Entering is a double number and if it is smaler than the max value
            //if (Double.TryParse(this.textBoxXaxisMin.Text, out x) && x < chart1.ChartAreas[0].AxisX.Maximum)    
            if (Double.TryParse(this.textBoxXaxisMin.Text, out x))
            {
                this.textBoxXaxisMin.BackColor = Color.White;
                chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(this.textBoxXaxisMin.Text);
                //changeYScalaMin(chartCharacteristicCurvesThermoelemts, Convert.ToDouble(this.textBoxCharacteristicCurvesThermoelementXmin.Text), Convert.ToDouble(this.textBoxCharacteristicCurvesThermoelementXmax.Text));     
            }
            else
                //if not the textbox is highlighted 
                this.textBoxXaxisMin.BackColor = Color.Orange;
            //calls the Max Function to update the chart if the Max-value is now valid

            double y;
            //checks if the Entering is a double number and if it is greater than the min value
            if (Double.TryParse(this.textBoxXaxisMax.Text, out y) && y > chart1.ChartAreas[0].AxisX.Minimum)
            {
                this.textBoxXaxisMax.BackColor = Color.White;
                chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(this.textBoxXaxisMax.Text);
            }
            else
                //if not the textbox is highlighted 
                this.textBoxXaxisMax.BackColor = Color.Orange;
        }
    }
}
