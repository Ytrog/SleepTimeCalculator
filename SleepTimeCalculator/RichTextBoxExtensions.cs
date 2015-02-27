using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepTimeCalculator
{
    public static class RichTextBoxExtensions
    {
        public static void AddRed(this RichTextBox box, string s)
        {
            box.AddColor(s, Color.Red);
        }

        public static void AddLightRed(this RichTextBox box, string s)
        {
            box.AddColor(s, Color.Magenta);
        }

        public static void AddGreen(this RichTextBox box, string s)
        {
            box.AddColor(s, Color.Green);
        }

        public static void AddGreenYellow(this RichTextBox box, string s)
        {
            box.AddColor(s, Color.GreenYellow);
        }

        public static void AddBlack(this RichTextBox box, string s)
        {
            box.AddColor(s, Color.Black);
        }

        public static void AddColor(this RichTextBox box, string s, Color color)
        {
            var length = box.TextLength;
            box.AppendText(s);
            box.Select(length, s.Length);
            box.SelectionColor = color;
        }
    }
}
