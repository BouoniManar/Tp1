using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Nombre1;
            int Nombre2;
            int Resultat;
            Nombre1 = int.Parse(textBox1.Text);
            Nombre2=int.Parse(textBox2.Text);
            Resultat = Nombre1 + Nombre2;

            textBox3.Text = Resultat.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
