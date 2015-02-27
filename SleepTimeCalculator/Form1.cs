using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepTimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            dtpInput.Value = DateTime.Now;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (rbWake.Checked)
            {
                CalculateSleepTime();
            }
            else if (rbSleep.Checked)
            {
                CalculateWakeTime();
            }
        }

        private void CalculateWakeTime()
        {
            throw new NotImplementedException();
        }

        private void CalculateSleepTime()
        {
            throw new NotImplementedException();
        }
    }
}
