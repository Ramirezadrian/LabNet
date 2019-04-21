using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1
{
    public partial class Form1 : Form
    {
        public Form1()
        { //Nunca poner codigo aca arriba
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            p1.Nombre = txtNombre.Text;
            p1.Apellido = txtApellido.Text;
            p1.Edad = int.Parse(txtEdad.Text);

            if (p1.Edad <= 17){
                lblResultado.Text="Usuario menor de edad";
            }
            else
            {
                lblResultado.Text = "Usuario mayor de edad";
            }


            
            



        }
    }
}
