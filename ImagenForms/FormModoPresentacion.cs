using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BibliotecaImagen;
using System.Media;

namespace ImagenForms

    // FormModoPresentacion: Responde al bóton "Modo Presentación" y da a elegir a el usuario una carpeta de imagenes
    //Tambien puede configurar el tiempo entre imagenes consecutivas
    //y detener, continuar o reiniciar la presentación


{
    public partial class FormModoPresentacion : Form
    {

        //Atributos del form
        private int counter = 1;
        private FolderBrowserDialog fbd = new FolderBrowserDialog();
        private bool playing = false;
        private bool carpetacargada = false;
        Imagen laimagen = new Imagen();



        public FormModoPresentacion()
        {
            InitializeComponent();
        }

        //Botón para escoger la carpeta con la que hacer la presentación
        //Cambiamos el bool para que el programa sepa que hemos clickado el boton y podemos iniciar la presentación
        private void EscogerCarpeta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = fbd.ShowDialog();
            carpetacargada = true;
        }

        //Botón con el que iniciaremos y pararemos la presentación
        //Muestra un error si el intervalo esta vacio
        private void btnEmpezarPresentacion_Click(object sender, EventArgs e)
        {
            //Mostramos un error si el usuario no introduce un intervalo
            if (string.IsNullOrEmpty(textBoxInterval.Text))
            {
                MessageBox.Show("Introduce un intervalo entre imagenes");
            }
             
            { 
            //Comprobamos si la presentacion esta activa para que pare el timer y si no esta active que empieze el timer
            if (!playing)
            {
                
                btnEmpezarPresentación.Text = "Parar Presentación";
                timer1.Start();
                playing = true;
            }
            else
            {
                btnEmpezarPresentación.Text = "Iniciar Presentación";
                playing = false;
                timer1.Stop();
            }
            }

        }


        //Botón para reiniciar la presentación
        private void btnReiniciarPresentacion_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();

        }

        //Configuramos el timer para poder cambiar el tiempo entre imagen e imagen
        //Muestra un error si el usuario introduce letras en lugar de un valor númerico para el intervalo
        //Muestra otro error si no hay una carpeta de imagenes seleccionada al iniciar la presentación
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Mostramos un error si el usuario intenta empezar la presentación sin haber cargado la carpeta de imagenes
            if (carpetacargada == false)
            {
                MessageBox.Show("Escoge una carpeta de imagenes primero");
            }
            else
            {
                try
                {
                    //Pasamos el intervalo del textbox a las propiedades del timer
                    int interval = Convert.ToInt32(textBoxInterval.Text);
                    timer1.Interval = interval * 1000;


                    //cada tick del timer subimos el valor del contador
                    counter++;

                    //Recogemos la lista de imagenes de la carpeta seleccionada
                    string[] imagenes = Directory.GetFiles(fbd.SelectedPath, "*.*");
                    //Hacemos que el contador se ponga a 0 cuando se acaban las imagenes                  
                    if (counter > imagenes.Length - 1)
                    {
                        counter = 0;
                    }

                    string extension = System.IO.Path.GetExtension(imagenes[counter]);

                    //Si la imagen es ppm, usaremos nuestro método para cargar imagenes ppm,
                    //porque si no el programa no es compatible con este formato
                    if (extension == ".ppm")
                    {
                        if (counter > imagenes.Length - 1)
                        {
                            counter = 0;
                        }

                        laimagen.CargarImagen(imagenes[counter]);
                        Bitmap bitmap = laimagen.CrearBitmap();
                        imagen.Image = bitmap;
                    }
                    else
                    {   //Para cualquier otro tipo de archivo lo asignaremos con este método al picturebox                                     
                        //Esto cargara las imagenes al picturebox "imagen"
                        imagen.Image = Image.FromFile(imagenes[counter]);
                        //Esto cargara el nombre de las imagenes a la etiqueta "nombreimagen"
                        nombreimagen.Text = System.IO.Path.GetFileName(imagenes[counter]);
                    }
                }



                catch (FormatException)
                {
                    MessageBox.Show("El valor del intervalo tiene que ser numerico");

                }                   
               
            }
        }


        //Botón para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModoPresentacion_Load(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.musica);
            splayer.Play();
        }
    }
}
