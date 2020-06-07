using System;
using System.Windows.Forms;

namespace PizzaTime
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       
        private void txtnombreyapellido_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario4 = new Form3();
            formulario4.Show();
            this.Hide();
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombreyapellido.Text;
            string telefono = txttelefono.Text;
            string direccion = txtdireccion.Text;
            string comentario = textBox4.Text;
            string seleccion;

            if (radioButton1.Checked == true)
            {
                seleccion = "Efectivo";
            }
            else
            {
                seleccion = "Tarjeta";
            }

            MessageBox.Show("los datos del cliente son " + 
                "\n Nombre: "+nombre + 
                "\n Numero de telefono: "+telefono + 
                "\n Direccion: "+direccion + 
                "\n Comentario del cliente: "+comentario +
                "\n metodo de pago: "+seleccion);
            MessageBox.Show("¡la orden esta en proceso!, el pago se realizara en el domicilio del cliente");
            Form formulario5 = new Form1();
            formulario5.Show();
            this.Hide();
                
             
                  

        }
    }
}
