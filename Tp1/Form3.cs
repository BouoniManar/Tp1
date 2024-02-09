using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Nombre;
            Nombre = int.Parse(textBox1.Text);

            if (Nombre % 2 == 0)
            {
                label2.Text = "Le nombre est pair.";
            }
            else if (Nombre % 2 != 0)
            {
                label2.Text = "Le nombre est impair.";
            }
            else
            {
                label2.Text = "Veuillez entrer un nombre valide.";
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}