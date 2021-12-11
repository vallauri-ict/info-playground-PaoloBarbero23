using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace FormConControlloRegex
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void errore(TextBox txt)
        {
            

            txt.BorderStyle = BorderStyle.None;
            Pen p = new Pen(Color.Red);
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            
            
            int variance = 3;
            g.DrawRectangle(p, new Rectangle(txt.Location.X - variance, txt.Location.Y - variance, txt.Width + variance, txt.Height + variance));
        }
    }

}
