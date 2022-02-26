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

    //FormVoltear: Formulario que se abre cuando seleccionamos la opción "Voltear Imagen" en el formImagen:
    //Da 2 opciones al usuario: volteo vertical o volteo horizontal


    public partial class FormVoltear : Form
    {
        public FormVoltear()
        {
            InitializeComponent();
        }

        //Variable eje para pasarla al FormImagen
        string eje;

        public string GetEje()
        {
            return this.eje;
        }


        //Botón para hacer el giro vertical
        private void btnVertical_Click(object sender, EventArgs e)
        {
            eje = "Vertical";
            this.Close();
        }

        //Botón para hacer el giro horizontal
        private void btnHorizontal_Click(object sender, EventArgs e)
        {
            eje = "Horizontal";
            this.Close();
        }

        //Botón para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
