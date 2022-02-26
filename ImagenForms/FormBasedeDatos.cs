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
    public partial class FormBasedeDatos : Form
    {
        //Declaramos la base de datos
        BaseDatos imagenes = new BaseDatos();

        public FormBasedeDatos()
        {
            InitializeComponent();
        }


        //Abrimos la base de datos cuando abra el formulario
        private void FormBasedeDatos_Load(object sender, EventArgs e)
        {
            imagenes.Iniciar();
        }


        //Botón para ver la base de datos
        private void btnVerImagenes_Click(object sender, EventArgs e)
        {
            DataTable dt = imagenes.GetImagenes();
            matriz.DataSource = dt;
            matriz.Refresh();
        }


        //Botón para filtrar por nombre
        private void btnNombre_Click(object sender, EventArgs e)
        {
            DataTable dt = imagenes.GetPorNombre(textBoxNombre.Text);
            matriz.DataSource = dt;
            matriz.Refresh();
        }


        //Botón para filtrar por fecha
        private void btnFecha_Click(object sender, EventArgs e)
        {
            DataTable dt = imagenes.GetPorFecha(textBoxFecha.Text);
            matriz.DataSource = dt;
            matriz.Refresh();
        }


        //Botón para eliminar la imagen de la base de datos a la cual hacemos click
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = matriz.SelectedCells[0].Value.ToString();
            DataTable dt = imagenes.EliminarDatos(nombre);
            matriz.DataSource = dt;
            matriz.Refresh();
        }


        //Botón para cerrar el formulario, cierra tambien la base de datos
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            imagenes.Cerrar();
        }

       
    }



}
