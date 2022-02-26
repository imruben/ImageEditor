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
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Media;

namespace ImagenForms
{
    //FormImagen: Form principal donde el 'PictureBox' nos muestra la imagen y los diferentes
    //botones nos realizaran las distintas modificaciones
    public partial class FormImagen : Form
    {

        //Declaramos una variable de la clase imagen para trabajar sobre ella
        Imagen Laimagen = new Imagen();

        public FormImagen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        //FUNCIONES DEL EDITOR: Aqui estan programados todos los botones del editor, los cuales hacen 
        //o bien una modificacion directa, o nos abren otro forms donde pediremos al usuario los datos 
        //necesarios para hacer la modificacion


        //OPCIÓN 1: Carga una imagen cualquiera y la muestra en el 'PictureBox'
        //Muestra un mensaje si la imagen se ha cargado correctamente
        //Muestra un error si la imagen no se ha encontrado
        //Muestra otro error si el formato no es compatible con el editor
        private void button1_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            //El 'OpenFileDialog' nos pregunta la imagen a editar
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //Filtros del 'OpenFileDialog'
                openFileDialog.InitialDirectory = "C:\\Users\\Ruben\\Documents\\Desktop\\PROYECTO PP FINAL GRUPO 2\\Bibliotecaimagen1\\bin\\Debug\\Imagenes de prueba";
                openFileDialog.Filter = "PPM Files (*.ppm)|*.ppm|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.CheckFileExists = true;
                DialogResult dr = openFileDialog1.ShowDialog();
                
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    string filepath = openFileDialog1.FileName;
                    string extension = System.IO.Path.GetExtension(filepath);

                    //Usaremos el método 'CargarImagen' si ésta es '.ppm'
                    if (extension == ".ppm")
                    {
                        int err = Laimagen.CargarImagen(filepath);
                        if (err == 0)
                        {
                            Laimagen.AñadirImagen();
                            MessageBox.Show("Imagen cargada correctamente");
                            Bitmap bitmap = Laimagen.CrearBitmap();
                            pictureBox1.Image = bitmap;
                        }
                        if (err == -1)
                        {

                            MessageBox.Show("No se ha encontrado ninguna imagen en esa ruta");
                        }
                        if (err == -2)
                        {                            
                            MessageBox.Show("El formato es incompatible con el editor. \nPrueba con una imagen");
                        }
                    }
                    //O usaremos el método 'CargarImagen2' si ésta no es '.ppm'
                    else
                    {
                        int err = Laimagen.CargarImagen2(filepath);
                        if (err == 0)
                        {
                            Laimagen.AñadirImagen();
                            MessageBox.Show("Imagen cargada correctamente");
                            Bitmap bitmap = Laimagen.CrearBitmap();
                            pictureBox1.Image = bitmap;
                        }

                        if (err == -1)
                        {
                            MessageBox.Show("No se ha encontrado ninguna imagen en esa ruta");
                        }
                        if (err == -2)
                        {
                            MessageBox.Show("El formato es incompatible con el editor. \nPrueba con una imagen");
                        }

                    }
                }
            }
        }

        
        //OPCIÓN 2: Guarda la imagen
        //Muestra un error si no hay ninguna imagen cargada en el pictureBox
        private void button2_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            if (pictureBox1.Image != null)
            {
                Laimagen.GuardarGeneral();
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen cargada");
            }
        }

        //OPCIÓN 2.2: Guarda la imagen donde el usuario escoja
        //Muestra un error si no hay ninguna imagen cargada en el pictureBox
        private void btnGuardarimagencomo_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            if (pictureBox1.Image != null)
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
                    Laimagen.GuardarImagenGeneral(nombre);
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen cargada");
            }
        }


        //OPCIÓN 3: Voltea la imagen vertical o horizontalmente (escoge el usuario)
        //Muestra un error si no hay ninguna imagen cargada en el pictureBox
        private void btnVoltear_Click_1(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            if (pictureBox1.Image != null)
            {
                FormVoltear fVoltear = new FormVoltear();

                fVoltear.ShowDialog();

                if (fVoltear.GetEje() == "Vertical")
                {
                    Laimagen.AñadirImagen();
                    Laimagen.VoltearImagenVertical();
                }

                if (fVoltear.GetEje() == "Horizontal")
                {
                    Laimagen.AñadirImagen();
                    Laimagen.VoltearImagenHorizontal();
                }

                Bitmap bitmap2 = Laimagen.CrearBitmap();
                pictureBox1.Image = bitmap2;

            }
            else
            {
                MessageBox.Show("No hay ninguna imagen cargada");
            }
        }


        //OPCIÓN 4: Modifica la intensidad de un color escogido por el usuario
        //Muestra un error si no hay ninguna imagen cargada en el pictureBox
        private void btnModificarColor_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            if (pictureBox1.Image != null)
            {
                FormCambiarColor fColor = new FormCambiarColor();

                fColor.ShowDialog();

                int intensidad1 = fColor.GetIntensidad();
                string color = fColor.GetColor();

                if (color == "Rojo")
                {
                    Laimagen.ModificarColor(intensidad1, 0, 0);
                }
                if (color == "Azul")
                {
                    Laimagen.ModificarColor(0, intensidad1, 0);
                }
                if (color == "Verde")
                {
                    Laimagen.ModificarColor(0, 0, intensidad1);
                }
                Laimagen.AñadirImagen();
                Bitmap bitmap4 = Laimagen.CrearBitmap();
                pictureBox1.Image = bitmap4;
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen cargada");
            }
        }


        //OPCIÓN 5: Transforma los colores de la imagen en una escala de grises
        //Muestra un error si no hay ninguna imagen cargada en el pictureBox
        private void btnEscaladegrises_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            if (pictureBox1.Image != null)
            {
                Laimagen.AñadirImagen();
                Laimagen.Escaladegrises();
                Bitmap bitmap3 = Laimagen.CrearBitmap();
                pictureBox1.Image = bitmap3;
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen cargada");
            }
        }


        //OPCIÓN 6: Abre un formulario que muestra los siguientes datos acerca de la imagen: 
        // archivo (ruta y nombre del archivo) y dimensión (alto y ancho en píxeles)
        //Muestra un error si no hay ninguna imagen cargada en el pictureBox
        private void btnMostrardatos_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            if (pictureBox1.Image != null)
            {
                FormDatos fdatos = new FormDatos();

                int ancho = Laimagen.GetAlto();
                int alto = Laimagen.GetAncho();
                string archivo = Laimagen.GetArchivo();

                fdatos.SetAncho1(ancho);
                fdatos.SetAlto1(alto);
                fdatos.SetArchivo1(archivo);

                fdatos.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen cargada");
            }
        }


        //OPCIÓN 7: Añade un marco con los parámetros que elige el usuario en otro
        //forms que se abre en el mismo momento.
        //Muestra un error si no hay ninguna imagen cargada en el pictureBox
        private void btnAñadirmarco_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            if (pictureBox1.Image != null)
            {
                if (this.Laimagen.GetAncho() != 0 && this.Laimagen.GetAlto() != 0)
                {
                    FormMarco fmarco = new FormMarco(Laimagen.GetAncho(), Laimagen.GetAlto(), Laimagen.GetMatriz());
                    fmarco.ShowDialog();

                    if ((fmarco.GetAncho() != 0) && (fmarco.GetAltura() != 0) && (fmarco.GetMatriz() != null))
                    {
                        Laimagen.AñadirImagen();
                        Laimagen.SetMatriz(fmarco.GetMatriz(), fmarco.GetAltura(), fmarco.GetAncho());
                        Bitmap bitmap7 = Laimagen.CrearBitmap();
                        pictureBox1.Image = bitmap7;
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen cargada");
            }
        }


        //OPCIÓN 8: Recorta la imagen, dando a escoger al usuario la esquina
        //superior-izquierda y la esquina inferior-derecha de la imagen.
        //Muestra un error si no hay ninguna imagen cargada en el pictureBox
        private void btnRecortar_Click_1(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            if (pictureBox1.Image != null)
            {
                if (this.Laimagen.GetAncho() != 0 && this.Laimagen.GetAlto() != 0)
                {
                    FormRecortar recortar1 = new FormRecortar(Laimagen.GetAncho(), Laimagen.GetAlto(), Laimagen.GetMatriz());
                    recortar1.ShowDialog();
                    if ((recortar1.GetAltura() != 0) || (recortar1.GetAncho() != 0) || (recortar1.GetMatriz() != null))
                    {
                        Laimagen.AñadirImagen();
                        Laimagen.SetMatriz(recortar1.GetMatriz(), recortar1.GetAltura(), recortar1.GetAncho());
                        Bitmap bitmap5 = Laimagen.CrearBitmap();
                        pictureBox1.Image = bitmap5;

                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen cargada");
            }

        }


        // OPCIÓN 9: Abre otro formulario donde muestra información sbre los autores y las
        //funcionalidades adicionales de la aplicación
        private void button3_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            FormAcercade fAcercade = new FormAcercade();
            fAcercade.ShowDialog();
        }


        // OPCIÓN 10: Deshace la ultima modificación realizada a la imagen
        //Muestra un error si no hay ninguna imagen cargada en el pictureBox
        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            if (pictureBox1.Image != null)
            {
                Laimagen.Deshacer();
                Bitmap bitmap6 = Laimagen.CrearBitmap();
                pictureBox1.Image = bitmap6;
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen cargada");
            }
        }


        //OPCIÓN 11: Abre un forms donde el usuario puede hacer una presentación de una carpeta
        //de imagenes que el escoja. Tambien puede configurar el tiempo entre imagenes consecutivas
        //y detener, continuar o reiniciar la presentación
        private void btnModoPresentacion_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            FormModoPresentacion fPresentacion = new FormModoPresentacion();
            fPresentacion.ShowDialog();
        }



        //OPCIÓN 12: Abre la base de datos
        private void btnBasedeDatos_Click(object sender, EventArgs e)
        {
            //Sonido guardado como recurso que suena al pulsar el botón
            SoundPlayer splayer = new SoundPlayer(ImagenForms.Properties.Resources.sonido);
            splayer.Play();

            FormBasedeDatos fBaseDeDatos = new FormBasedeDatos();
            fBaseDeDatos.ShowDialog();
        }







        //Codigo de los 4 botones de la barra de arriba (salir, maximizar, restaurar y minimizar)


        //Botón "Salir": Antes de cerrar el programa, abre el "FormSalir" para preguntar al usuario (SOLO SI HAY UNA IMAGEN CARGADA)
        //si quiere salvar la imagen
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                FormSalir fsalir = new FormSalir();
                fsalir.ShowDialog();
            }
            else
            {
                Application.Exit();
            }

        }

        //Botón "Maximizar": Maximiza la ventana
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        //Botón "Restaurar": Vuelve atrás despues de maximizar
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        //Botón "Minimizar": Minimiza la ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }








        //Codigo para poder mover la ventana del formulario arrastrando desde la parte de arriba (como cualquier ventana de Windows)

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}













