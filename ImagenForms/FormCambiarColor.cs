using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaImagen;

namespace ImagenForms
{
        //Formulario 4: Se abrirá al pulsar el botón "Modificar un color" y dejará al usuario 
        //escoger el color que quiere modificar y la intensidad que quiere restarle o sumarle a ese color.
    public partial class FormCambiarColor : Form
    {

        //Declaramos un objeto de la clase Imagen
        Imagen Laimagen = new Imagen();

        //Variables del formulario
        private string color;
        private int intensidad;
  
        public FormCambiarColor()
        {
            InitializeComponent();
        }

        //Metodos Gets para conseguir la intensidad desde el formularioImagen
        public int GetIntensidad()
        {
            return this.intensidad;
        }

        public string GetColor()
        {
            return this.color;
        }


        //3 botones para que el usuario escoja el color y le asignaremos este valor a un string
        //para usarlos luego en la funcion
        private void btnRojo_Click(object sender, EventArgs e)
        {
            this.color = "Rojo";
            btnAzul.Visible = false;
            btnVerde.Visible = false;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            this.color = "Azul";
            btnVerde.Visible = false;
            btnRojo.Visible = false;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.color = "Verde";
            btnAzul.Visible = false;
            btnRojo.Visible = false;
        }

        //Botón para cerrar el formulario y ver aplicada la modificacion de la imagen en el PictureBox
        //Muestra un error si el usuario introduce letras en lugar de un valor númerico
        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            try
            {
            this.intensidad = Convert.ToInt32(textBoxIntensidad.Text);
            this.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("La intensidad tiene que ser un valor númerico");
            }
            
        }

        //Botón para cerrar el formulario.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}






