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
    public partial class Form5 : Form
    {
        public object Addition { get; private set; }
        public object Soustraction { get; private set; }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nombre1 = int.Parse(textBox1.Text);
            int nombre2 = int.Parse(textBox2.Text);
            int resultat = 0;

            // Vérifiez quelle opération RadioButton est sélectionnée
            if (radioButton1.Checked)
            {
                resultat = nombre1 + nombre2;
            }

            else if (radioButton2.Checked)
            {
                resultat = nombre1 - nombre2;
            }
            else if (radioButton3.Checked)
            {
                resultat = nombre1 * nombre2;
            }
            else if (radioButton4.Checked)
            {
                // Vérifiez si la division par zéro est évitée
                if (nombre2 != 0)
                {
                    resultat = nombre1 / nombre2;
                }
                else
                {
                    MessageBox.Show("Erreur : Division par zéro !");
                }
            }

            // Affichez le résultat dans un TextBox
            textBox3.Text = resultat.ToString();
        }

    }

   

}