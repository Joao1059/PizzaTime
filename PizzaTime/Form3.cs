using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaTime
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form formulario3 = new Form1();
            formulario3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string seleccion;
            if( radioButton1.Checked == true)
            {
                seleccion = "Pizza Vegetariana";
            }
            else
            {
                seleccion =  " Pizza Americana";
            }

           
            
            if (checkBox1.Checked == true)
            {
                cont++;
            }

            if (checkBox2.Checked == true)
            {
                cont++;
            }

            if (checkBox3.Checked == true)
            {
                cont++;
            }
            MessageBox.Show("La pizza elegida es " + seleccion + " y los acompañamientos son:" + cont);

            Form formulario4 = new Form4();
            formulario4.Show();
            this.Hide();
        }

    }
}
