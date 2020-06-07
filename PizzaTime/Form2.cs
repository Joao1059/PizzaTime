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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
            string seleccion2;
            int palitos = 3100;
            int alitas = 4300;
            int bebidas = 2600;
            int saldo = 0;
            if (radioButton1.Checked == true)
            {
                seleccion = "pizza Vegetariana";
            }
            else
            {
                seleccion = " pizza Americana";
            }

            saldo = saldo + 10300;

            if (checkBox1.Checked == true)
            {
                cont++;
                saldo = saldo + palitos;
            }

            if (checkBox2.Checked == true)
            {
                cont++;
                saldo = saldo + alitas;
            }

            if (checkBox3.Checked == true)
            {
                cont++;
                saldo = saldo + bebidas;
            }

            if(radioButton3.Checked == true)
            {
                seleccion2 = "para servir";
            }
            else
            {
                seleccion2 = "para llevar";
            }
            MessageBox.Show("La pizza elegida es " + seleccion + " , el(los) acompañamiento(s) son: " + cont + " y es "+ seleccion2);
            MessageBox.Show("El total es: " + saldo);

        }
    }
}
