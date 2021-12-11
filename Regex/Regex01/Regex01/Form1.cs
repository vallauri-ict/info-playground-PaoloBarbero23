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

namespace Regex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$";
            Regex rgx = new Regex(pattern);//
            string str = txtStr.Text;

            MessageBox.Show(str + " " + rgx.IsMatch(str));

            MessageBox.Show(str + " " + Regex.IsMatch(str, pattern));
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            string str = "One car red car blue car";
            string pattern = @"(\w+)\s+(car)";
            Regex reg = new Regex(pattern);
            Match m = reg.Match(str);
            int count = 0;
            while (m.Success)
            {

                MessageBox.Show("Trovato: gruppo: " + (++count) + " Valore: " + m.Value + " Alla posizione " + m.Index);
                m = m.NextMatch();
            }

        }

        private void BTNsPLIT_Click(object sender, EventArgs e)
        {
            string pattern = @"\d+";
            Regex rgx = new Regex(pattern);
            string input = "123ABCDE456FGHIJKL789MNOPQ012";
            string[] result = rgx.Split(input);
            for (int i = 0; i < result.Length; i++)
            {
                MessageBox.Show("Stringa " + (i + 1) + ": \"" + result[i] + "\" \n");

            }
            Console.WriteLine();
        }

        private void btnSplit2_Click(object sender, EventArgs e)
        {
            string input = "This is     text with      far too       much " +
            "     whitespace.";
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            MessageBox.Show("Original String: " + input);
            MessageBox.Show("Replacement String: " + result);
        }
    }
}
