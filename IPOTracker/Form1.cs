using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPOTracker
{
    public partial class TrackerForm : Form
    {
        public TrackerForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            decimal appliedAmtValue, ballotAmtValue, exitAmtValue;
            if (!decimal.TryParse(appliedAmtTextBox.Text, out appliedAmtValue) ||
                !decimal.TryParse(ballotAmtTextBox.Text, out ballotAmtValue) ||
                !decimal.TryParse(exitAmtTextBox.Text, out exitAmtValue))
            {
                MessageBox.Show("Please enter valid values in all input fields.");
                return;
            }

            // Perform logic
            decimal successRateValue = ballotAmtValue / appliedAmtValue * 100;
            decimal allotMarginValue = (exitAmtValue - ballotAmtValue) / ballotAmtValue * 100;
            decimal rocValue = (exitAmtValue - ballotAmtValue) / appliedAmtValue * 100;

            // Display outputs
            successRateTextBox.Text = successRateValue.ToString("0.00");
            allotMarginTextBox.Text = allotMarginValue.ToString("0.00");
            rocTextBox.Text = rocValue.ToString("0.00");
        }
    }
}
