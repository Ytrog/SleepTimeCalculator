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

        private static TimeSpan _cycle = new TimeSpan(0, 90, 0);

        private TimeSpan BoxValue
        {
            get
            {
                var date = dtpInput.Value;
                return date.TimeOfDay;
            }
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
            TimeSpan begin = BoxValue;

            TimeSpan[] times = new TimeSpan[6];

            for (int i = 0; i < 6; i++)
            {
                times[i] = i == 0 ? begin + _cycle : times[i - 1] + _cycle;
            }

            rtbOutput.Text = Format(times);
	
        }

        private void CalculateSleepTime()
        {
            throw new NotImplementedException();
        }

        private static string Format(TimeSpan[] times)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var t in times)
            {
                sb.AppendLine(Format(t));
            }

            return sb.ToString();
        }

        private static string Format(TimeSpan t)
        {
            return t.ToString("hhmm");
        }
        
    }
}
