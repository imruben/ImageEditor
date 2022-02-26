using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagenForms
{

    //Formulario 3: Responde al botón "Mostrar Datos" del 'Form1' y 
    //muestra los siguientes datos acerca de la imagen: 
    //archivo (ruta y nombre del archivo) y dimensión (alto y ancho en píxeles)

    public partial class FormDatos : Form
    {

        public FormDatos()
        {
            InitializeComponent();
        }

        //Variables que se mostraran en pantalla
        private string archivo1;
        private int ancho1;
        private int alto1;

        //Métodos Sets necesarios para pasar los valores 'archivo', 'ancho' y 'alto' del FormImagen a este form
        public void SetAncho1(int ancho)
        {
            this.ancho1 = ancho;
        }
        public void SetAlto1(int alto)
        {
            this.alto1 = alto;
        }
        public void SetArchivo1(string archivo)
        {
            this.archivo1 = archivo;
        }
         
    //Solo cargar el formulario, se le asigna un dato a cada label del 'form3'
    //El primero muestra la ruta del archivo, el segundo consigue el nombre del archivo
    //de la ruta, y el tercero muestra el ancho y alto en pixeles del archivo.
    private void Form3_Load_1(object sender, EventArgs e)
        {
            labelruta2.Text = " " + archivo1;
            labelnombre.Text = " " + System.IO.Path.GetFileName(archivo1);             
            labeldimensiones.Text = +alto1 + " x " + ancho1;
        }


        //Botón para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
