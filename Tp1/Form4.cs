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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nombre = int.Parse(textBox1.Text);
            long factoriel = 1;

            dataGridView1.Columns[0].HeaderText = "Nombre";
            dataGridView1.Columns[1].HeaderText = "Factorielle";

            for (int i=1; i<= nombre; i++)
            {
                factoriel *= i;
            }

            this.dataGridView1.Rows.Add(nombre,factoriel);
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
