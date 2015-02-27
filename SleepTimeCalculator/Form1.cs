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

            RichFormat(times);
	
        }

        private void CalculateSleepTime()
        {
            TimeSpan end = BoxValue;

            TimeSpan[] times = new TimeSpan[6];

            for (int i = times.Length; i < 0; i--)
            {
                times[i] = i == times.Length ? end - _cycle : times[i + 1] - _cycle;
            }

            RichFormat(times, false);
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
            return t.ToString("hh\\:mm");
        }

        private void RichFormat(TimeSpan[] times, bool forward = true)
        {
            var box = rtbOutput;
            if (forward)
            {
                for (int i = 0; i < times.Length; i++)
                {
                    FormatTime(times, box, i);
                }
            }
            else
            {
                for (int i = times.Length; i > 0; i--)
                {
                    FormatTime(times, box, i);
                }
            }
        }

        private static void FormatTime(TimeSpan[] times, RichTextBox box, int i)
        {
            string time = Format(times[i]) + Environment.NewLine;
            Action<Color> color = c => box.AddColor(time, c);
            switch (i)
            {
                case 0:
                    box.AddRed(time);
                    break;
                case 1:
                    box.AddColor(time, Color.OrangeRed);
                    break;
                case 2:
                    color(Color.Orange);
                    break;
                case 3:
                    color(Color.PaleGreen);
                    break;
                case 4:
                    color(Color.LightGreen);
                    break;
                case 5:
                    color(Color.Green);
                    break;
                default:
                    box.AddBlack(time);
                    break;

            }
        }
        
    }
}
