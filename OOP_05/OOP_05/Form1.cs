using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public struct Libro
        {
            public string titolo;
            public string autore;
        }

        int pos;

        Dictionary<int, Libro> dicLibri = new Dictionary<int, Libro>();
        Queue<Libro> codaLibri = new Queue<Libro>();
        Stack<Libro> pilaLibri = new Stack<Libro>();

        private void btnAddLibro_Click(object sender, EventArgs e)
        {
            Libro l;
            l.autore = txtAutore.Text;
            l.titolo = txtTitolo.Text;

            dicLibri.Add(++pos, l);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pos = 0;
        }

        private void btnVisualizzaLibri_Click(object sender, EventArgs e)
        {
            foreach (int key in dicLibri.Keys)
            {
                MessageBox.Show("Chiave: " + key);
            }


            foreach(Libro l in dicLibri.Values)
            {
                MessageBox.Show("(Valore) Titolo del libro: " + l.titolo);
            }
        }

        private void btnIndiceLibro_Click(object sender, EventArgs e)
        {
            try
            {
                Libro l = dicLibri[Convert.ToInt32(nupLibro.Value)];
                MessageBox.Show("Libro: " + l.titolo);
            }
            catch (Exception)
            {
                MessageBox.Show("Chiave non presente");
            }
        }

        private void btnAggiungiCoda_Click(object sender, EventArgs e)
        {
            Libro l;
            l.autore = txtAutore.Text;
            l.titolo = txtTitolo.Text;
            codaLibri.Enqueue(l);

        }

        private void btnAggiungiPila_Click(object sender, EventArgs e)
        {
            Libro l;
            l.autore = txtAutore.Text;
            l.titolo = txtTitolo.Text;
            pilaLibri.Push(l);

        }

        private void btnRimuoviCoda_Click(object sender, EventArgs e)
        {
            Libro l = codaLibri.Dequeue();
            MessageBox.Show("Libro: " + l.titolo + "\tAutore:" + l.autore);
            
        }

        private void btnRimuoviPila_Click(object sender, EventArgs e)
        {
            Libro l = pilaLibri.Pop();
            MessageBox.Show("Libro: " + l.titolo + "\tAutore:" + l.autore);

        }
    }
}
