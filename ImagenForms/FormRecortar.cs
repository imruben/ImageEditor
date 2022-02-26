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
    public partial class FormRecortar : Form
    {
        //FormRecortar: Recorta la imagen desde los dos puntos que elige el usuario, dandole
        //un valor a las coordenadas x e y de estos dos puntos

        Imagen imagen1 = new Imagen();
        private int anchorecortado, altorecortado;
        private Pixel[,] matrizcortada;


        //Gets para devolver los datos al FormImagen
        public Pixel[,] GetMatriz()
        {
            return matrizcortada;
        }
        public int GetAncho()
        {
            return anchorecortado;
        }
        public int GetAltura()
        {
            return altorecortado;
        }

        //Creamos un método para pasarle la matriz al formImagen y crear desde ahi el bitmap nuevo
        public FormRecortar(int ancho, int alto, Pixel[,] matriz)
        {
            InitializeComponent();
            imagen1.SetMatriz(matriz, alto, ancho);
        }


        //Botón para recortar la imagen y volver al FormImagen
        //Muestra un error si el usuario introduce letras en lugar de un valor númerico
        //Muestra otro error si el usuario introduce dos puntos iguales o que no forman un rectangulo para poder recortarlo
        //Muestra otro error si los puntos estan fuera del limite de la imagen
        private void btnRecortar_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = Convert.ToInt32(textBoxP1x.Text);
                int y1 = Convert.ToInt32(textBoxP1y.Text);
                int x2 = Convert.ToInt32(textBoxP2x.Text);
                int y2 = Convert.ToInt32(textBoxP2y.Text);

                if (x1 < 0)
                {
                    x1 = 0;
                    textBoxP1x.Text = Convert.ToString(x1);
                }
                if (x2 < 0)
                {
                    x2 = 0;
                    textBoxP1x.Text = Convert.ToString(x2);
                }
                if (y1 < 0)
                {
                    y1 = 0;
                    textBoxP1y.Text = Convert.ToString(y1);
                }
                if (y2 < 0)
                {
                    y2 = 0;
                    textBoxP2y.Text = Convert.ToString(y2);
                }
                if (x1 >= imagen1.GetAncho())
                {
                    x1 = imagen1.GetAncho() - 1;
                    textBoxP1x.Text = Convert.ToString(x1);
                }
                if (x2 >= imagen1.GetAncho())
                {
                    x2 = imagen1.GetAncho() - 1;
                    textBoxP2x.Text = Convert.ToString(x2);
                }
                if (y1 >= imagen1.GetAlto())
                {
                    y1 = imagen1.GetAlto() - 1;
                    textBoxP1y.Text = Convert.ToString(y1);
                }
                if (y2 >= imagen1.GetAlto())
                {
                    y2 = imagen1.GetAlto() - 1;
                    textBoxP2y.Text = Convert.ToString(y2);
                }

                int opcion = imagen1.RecortarImagen(x1, y1, x2, y2);
                if (opcion == -1)
                {
                    MessageBox.Show("No puedes recortar con estos dos puntos.\n Recuerda que los dos puntos tienen que formar un rectangulo");
                    textBoxP1x.Text = "0";
                    textBoxP1y.Text = "0";
                    textBoxP2x.Text = Convert.ToString(imagen1.GetAncho() - 1);
                    textBoxP2y.Text = Convert.ToString(imagen1.GetAlto() - 1);
                   
                }
                if (opcion == -2)
                {
                    MessageBox.Show("No puedes recortar fuera del limite");
                   
                }                
                 else
                {
                    anchorecortado = imagen1.GetAncho2();
                    altorecortado = imagen1.GetAltura2();
                    matrizcortada = imagen1.GetMatriz2();
                    this.Close();
                }
            }
            catch (FormatException)
            {
                textBoxP1x.Text = "0";
                textBoxP1y.Text = "0";
                textBoxP2x.Text = Convert.ToString(imagen1.GetAncho() - 1);
                textBoxP2y.Text = Convert.ToString(imagen1.GetAlto() - 1);
                MessageBox.Show("Introduce sólo numeros");
                
            }
           
        }


        //En el Load cargamos las dimensiones para que el usuario sepa el limite
        private void FormRecortar_Load(object sender, EventArgs e)
        {
            labeldimension.Text = Convert.ToString(imagen1.GetAncho() + "x" + Convert.ToString(imagen1.GetAncho()));

        }


        //Botón para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
