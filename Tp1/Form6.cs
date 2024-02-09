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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            textBox2.UseSystemPasswordChar = true;

            if (login== "admin" && password =="admin") 
            {
                MessageBox.Show("Connexion reussi !");

            }
            else
            {

                MessageBox.Show("Identifiants incorrects. Veuillez réessayer.");
            }
        }
    }
}
