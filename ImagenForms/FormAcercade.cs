using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ImagenForms
{
    public partial class FormAcercade : Form
    {

        //FormAcercade: Responde al botón "Acerca De" del FormImagen y muestra información sobre los autores y las
        //funcionalidades adicionales de la aplicación


        public FormAcercade()
        {
            InitializeComponent();
        }

        //Botón para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAcercade_Load(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.musica);
            splayer.Play();
        }


    }
}
