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


    //FormMarco: Responde al botón "Añadir Marco" del FormImagen y da al usuario a escoger
    //entre tres colores y el grosor del marco. 


{
    public partial class FormMarco : Form
    {

        //Declaramos el objeto Imagen y las variables necesarias
        Imagen laimagen = new Imagen();
        private int AnchoMarco;
        private int AlturaMarco;
        private Pixel[,] MatrizMarco;
        private string color;
        private int grosor;
        private byte rojo = 0;
        private byte verde = 0;
        private byte azul = 0;


        //Usamos el método "SetMatriz" para crear una matriz con los valores de la imagen
        public FormMarco(int ancho, int alto, Pixel[,] matriz)
        {
            InitializeComponent();
            laimagen.SetMatriz(matriz , alto, ancho);
        }

        

        //Inicializamos el Form con el valor del TextBoxGrosor a 0
        private void FormMarco_Load(object sender, EventArgs e)
        {
            textBoxGrosorMarco.Text = "0";

        }


        //Cremos los "Gets" necesarios para obtener los datos de la imagen original
        public int GetAncho()
        {
            return AnchoMarco;
        }
        public int GetAltura()
        {
            return AlturaMarco;
        }
        public Pixel[,] GetMatriz()
        {
            return MatrizMarco;
        }


        //Botón para escoger el color rojo
        private void btnRojo_Click(object sender, EventArgs e)
        {
            color = "Red";
            btnAzul.Visible = false;
            btnVerde.Visible = false;
        }

        //Botón para escoger el color azul
        private void btnAzul_Click(object sender, EventArgs e)
        {
            color = "Blue";
            btnVerde.Visible = false;
            btnRojo.Visible = false;
        }

        //Botón para escoger el color verde
        private void btnVerde_Click(object sender, EventArgs e)
        {
            color = "Green";
            btnAzul.Visible = false;
            btnRojo.Visible = false;
        }


        //Botón para añadir el marco y cerrar el formulario
        //Muestra un error si el usuario introduce letras en lugar de un valor númerico
        //Muestra otro error si el usuario introduce un valor demasiado grande para el grosor del marco
        private void buttonAñadirMarco_Click(object sender, EventArgs e)
        {
           
            try
            {               
                grosor = Convert.ToInt32(textBoxGrosorMarco.Text);

                //Si el usuario escoje rojo, asignamos al byte rojo el valor 255 mientras que los otros 2 se mantienen a 0
                if (color == "Red")
                {
                    rojo = 255;

                }

                //Si el usuario escoje verde, asignamos al byte verde el valor 255 mientras que los otros 2 se mantienen a 0
                if (color == "Green")
                {
                    verde = 255;
                }

                //Si el usuario escoje azul, asignamos al byte azul el valor 255 mientras que los otros 2 se mantienen a 0
                if (color == "Blue")
                {
                    azul = 255;
                }

                int res = laimagen.AñadirMarco(grosor, rojo, verde, azul);
                if (res == -1)
                {
                    MessageBox.Show("El grosor del marco es demasiado grande. Introduce un valor menor");
                }
                else
                {
                    //laimagen.AñadirMarco(grosor, rojo, verde, azul);
                    AnchoMarco = laimagen.GetAncho2();
                    AlturaMarco = laimagen.GetAltura2();
                    MatrizMarco = laimagen.GetMatriz2();

                    this.Close();
                }
                
            }
            catch(FormatException)
            {
                MessageBox.Show("El grosor del marco tiene que ser un valor númerico");
                textBoxGrosorMarco.Text = "0";
            }
        }

        //Botón para cerrar el formulario
        private void btnCerrarMarco_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
