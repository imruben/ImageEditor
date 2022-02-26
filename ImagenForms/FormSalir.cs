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


    //Formulario 2: Responde al boton "salir" del FormImagen, y proporciona 3 opciones al usuario:
    //Salir sin guardar, guardar y salir y volver atrás

    public partial class FormSalir : Form
    {
        Imagen laimagen = new Imagen();

        public FormSalir()
        {
            InitializeComponent();
        }

        //Botón para salir de la aplicación sin guardar
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Botón para volver otra vez al FormImagen sin salir de la aplicación
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //Botón para guardar la imagen donde el usuario escoja y después salir de la aplicación
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Buscar Archivo";
            saveFileDialog1.InitialDirectory = "C:\\Users\\Ruben\\Documents\\Desktop\\PROYECTO PP FINAL  GRUPO 2\\magenes de prueba";
            saveFileDialog1.Filter = " documentos ppm (*.ppm)|*.ppm| documentos jpg (*.jpg)|*.jpg| documentos png (*.png)|*.png| todos los documentos (*.*)|*.*";
            saveFileDialog1.FilterIndex = 4;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombre = saveFileDialog1.FileName;
                laimagen.GuardarImagenGeneral(nombre);
            }


        }


        //Botón para cerrar el formulario (misma funcion que botón "Volver Atras"
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
