using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;




namespace BibliotecaImagen
{
    //CLASE Imagen: Es la clase principal y donde programamos todos los 
    // constructores y métodos que usamos luego en el 'FormImagen'.
    public class Imagen
    {
        //Atributos de la clase Imagen
        private string archivo;
        private string identificador;
        private int ancho;
        private int alto;
        private int ancho2;
        private int alto2;       
        private byte niveles;
        private Pixel[,] pixeles;
        private Pixel[,] pixel1;
        private Stack<Imagen> pilaimagenes = new Stack<Imagen>();
        BaseDatos imagenes = new BaseDatos();



        //Metodos "Gets" y "Sets" que devuelven las variables de la imagen para usar 
        //estos valores en otros forms
        public string GetArchivo()
        {
            return this.archivo;
        }
        public int GetAlto()
        {
            return this.alto;

        }
        public int GetAncho()
        {
            return this.ancho;

        }
        public Pixel[,] GetMatriz() 
        {
            return this.pixeles;
        }
        public int GetAncho2() 
        {
            return this.ancho2;
        }

        public int GetAltura2() 
        {
            return this.alto2;
        }
        public Pixel[,] GetMatriz2() 
        {
            return this.pixel1;
        }
        public void SetMatriz(Pixel[,] matriz, int alto, int ancho)
        {
            this.pixeles = matriz;
            this.alto = alto;
            this.ancho = ancho;
        }
        public string GetNombrefichero() 
        {
            return this.archivo;
        }


        // MÉTODO 1: Lee y carga una imagen PPM
        //Devuelve 0 si la imagen se ha cargado correctamente
        //Devuelve -1 si no encuentra la imagen
        //Devuelve -2 si el método no permite el tipo de archivo
        public int CargarImagen(string picture)
        {
            StreamReader fichero = null;
            try
            {
                string linea;
                string[] datos;
                fichero = new StreamReader(picture);
              
                this.archivo = picture;
                linea = fichero.ReadLine();
                if (linea != "P3")
                {
                    fichero.Close();
                    return -2;
                }
                this.identificador = linea;

                linea = fichero.ReadLine();
                datos = linea.Split(' ');
                if (datos.Length != 2)
                {
                    fichero.Close();
                    return -2;
                }
                this.ancho = Convert.ToInt32(datos[0]);
                this.alto = Convert.ToInt32(datos[1]);

                linea = fichero.ReadLine();
                this.niveles = Convert.ToByte(linea);

                this.pixeles = new Pixel[this.alto, this.ancho];

                for (int fila = 0; fila < this.alto; fila++)
                {
                    linea = fichero.ReadLine();
                    if (linea == null)
                    {
                        fichero.Close();
                        return -2;
                    }

                    datos = linea.Split(' ');
                    if (datos.Length != this.ancho * 3)
                    {
                        fichero.Close();
                        return -2;
                    }

                    for (int columna = 0; columna < this.ancho; columna++)
                    {
                        byte r = Convert.ToByte(datos[3 * columna]);
                        byte g = Convert.ToByte(datos[3 * columna + 1]);
                        byte b = Convert.ToByte(datos[3 * columna + 2]);
                        this.pixeles[fila, columna] = new Pixel(r, g, b);
                    }
                }
            }

            catch (FileNotFoundException)
            {
                return -1;
            }
            catch (ArgumentException)
            {
                fichero.Close();
                return -2;
            }

            fichero.Close();

            return 0;
        }


        //MÉTODO 2: Carga una imagen que no sea PPM (.jpeg, .png, .jfif,...)
        //Devuelve 0 si la imagen se ha cargado correctamente
        //Devuelve -1 si no encuentra la imagen
        //Devuelve -2 si el método no permite el tipo de archivo
        public int CargarImagen2(string filename)
        {
            try
            {
                Bitmap bmp = new Bitmap(filename);
                this.archivo = filename;
                this.ancho = bmp.Width;
                this.alto = bmp.Height;
                this.identificador = "P3";
                this.niveles = 255;
                this.pixeles = new Pixel[alto, ancho];

                for (int fila = 0; fila < this.alto; fila++)
                {
                    for (int columna = 0; columna < this.ancho; columna++)
                    {
                        Color c = bmp.GetPixel(columna, fila);

                        pixeles[fila, columna] = new Pixel(c.R, c.G, c.B);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                return -1;
            }
            catch (ArgumentException)
            {   

                return -2;
            }
            return 0;
        }


        //MÉTODO 0: Guarda una imagen PPM o JPG o PNG donde el usuario quiera
        //Devuelve 0 si la imagen que quiere guardar el usuario es ppm
        //Devuelve 1 si la imagen que quiere guardar el usuario es jpg, png o jfif
        //Devuelve -1 si la imagen no se puede guardar
        public int GuardarImagenGeneral(string nombre)
        {
            if (Path.GetExtension(nombre) == ".ppm" || Path.GetExtension(nombre) == ".PPM")
            {
                GuardarImagenComoPPM(nombre);
                imagenes.Iniciar();
                imagenes.InsertarDatos(Path.GetFileName(nombre), this.alto, this.ancho, DateTime.Now.ToString("dd/MM/yyyy"));
                imagenes.Cerrar();
                return 0;
            }
            else if (Path.GetExtension(nombre) == ".jpg" || Path.GetExtension(nombre) == ".JPG" || Path.GetExtension(nombre) == ".png" || Path.GetExtension(nombre) == ".PNG" || Path.GetExtension(nombre) == ".jfif" || Path.GetExtension(nombre) == ".JFIF")
            {
                GuardarImagenComoNoPPM(nombre);
                imagenes.Iniciar();
                imagenes.InsertarDatos(Path.GetFileName(nombre), this.alto, this.ancho, DateTime.Now.ToString("dd/MM/yyyy"));
                imagenes.Cerrar();
                return 1;
            }
            else
            {
                return -1;
            }
        }

        //Método 0.1: Para guardar un archivo teniendo el nombre
        public int GuardarGeneral() 
        {
            return (GuardarImagenGeneral(this.archivo));
        }



        //MÉTODO 0.2: Guarda una imagen PPM sobreescribiendo la anterior.
        //Devuelve 0 si ha cargado la imagen correctamente
        //Devuelve -1 si la imagen no tiene alto ni ancho
        //Devuelve -2 si da una excepcion IO (Como que el directorio no existe o el path es demasiado largo)
        public int GuardarImagenComoPPM (string nombre)
        {
            if (this.ancho == 0 || this.alto == 0)
                return -1;

            try
            {
                StreamWriter Esc = new StreamWriter(nombre);
                Esc.WriteLine(this.identificador);
                Esc.WriteLine("{0} {1}", this.ancho, this.alto);
                Esc.WriteLine(this.niveles);

                for (int i = 0; i < this.alto; i++)
                {
                    Esc.Write("{0} {1} {2}", this.pixeles[i, 0].GetR(), this.pixeles[i, 0].GetG(), this.pixeles[i, 0].GetB());

                    for (int j = 1; j < this.ancho; j++)
                    {
                        Esc.Write(" ");
                        Esc.Write("{0} {1} {2}", this.pixeles[i, j].GetR(), this.pixeles[i, j].GetG(), this.pixeles[i, j].GetB());
                    }

                    Esc.WriteLine();
                }

                Esc.Close();
                return 0;
            }

            catch (IOException)
            {
                return -2;
            }

        }


        //MÉTODO 0.3: Guarda una imagen que no sea PPM donde el usuario quiera
        public int GuardarImagenComoNoPPM(string picture)
        {
            Bitmap btmp = CrearBitmap();
            btmp.Save(picture);
            return 0;

        }

        //MÉTODO 3: Muestra la imagen en consola (NO SIRVE PARA FORMS)
        public void MostrarImagen()
        {
            for (int fila = 3; fila < this.alto; fila++)
            {
                for (int columna = 0; columna < this.ancho; columna++)
                {
                    Console.Write(this.pixeles[fila, columna]);
                }
                Console.WriteLine();
            }
        }


        //MÉTODO 4: Muestra la cabecera en consola (NO SIRVE PARA FORMS)
        public void MostrarCabecera()
        {
            Console.WriteLine(this.identificador);
        }


        //MÉTODO 5: Muestra el directorio en consola (NO SIRVE PARA FORMS)
        public void MostrarDirectorio()
        {
            Console.WriteLine(this.archivo);
        }


        //MÉTODO 6: Muestra el tamaño en consola (NO SIRVE PARA FORMS)
        public void Tamaño()
        {
            Console.WriteLine("filas x columnas");
            Console.Write(this.alto);
            Console.Write(" x ");
            Console.Write(this.ancho);
        }


        //MÉTODO 7: Voltea el mapa de pixeles de forma vertical
        public void VoltearImagenVertical()
        {
            Pixel[,] volteado = new Pixel[alto, ancho];

            for (int line = 0; line < alto; line++)
            {
                for (int col = 0; col < ancho; col++)
                {
                    volteado[line, col] = pixeles[line, ancho - 1 - col];
                }
            }

            pixeles = volteado;
        }

        //MÉTODO 7.2: Voltea el mapa de pixeles de forma horizontal
        public void VoltearImagenHorizontal()
        {
            Pixel[,] volteado = new Pixel[alto, ancho];

            for (int line = 0; line < alto; line++)
            {
                for (int col = 0; col < ancho; col++)
                {
                    volteado[line, col] = pixeles[alto - 1 - line, col];
                } 
            }

            pixeles = volteado;
        }


        //MÉTODO 8: Crea un bitmap a partir del mapa de pixeles asignandole 
        //las columnas, las filas y el color rgb.
        public Bitmap CrearBitmap()
        {
            Bitmap bmp = new Bitmap(this.ancho, this.alto);

            for (int y = 0; y < alto; y++)
            {
                for (int x = 0; x < ancho; x++)
                {
                    byte r = pixeles[y, x].GetR();
                    byte g = pixeles[y, x].GetG();
                    byte b = pixeles[y, x].GetB();

                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return bmp;
        }



        //METODO 9: Transforma los colores de la imagen en una escala de grises.
        public void Escaladegrises()
        {

            for (int i = 0; i < this.alto; i++)
            {
                for (int y = 0; y < this.ancho; y++)
                {
                    byte r = pixeles[i, y].GetR();
                    byte g = pixeles[i, y].GetG();
                    byte b = pixeles[i, y].GetB();

                    byte grayscale = (byte)((r * 0.3) + (g * 0.59) + (b * 0.11));

                    pixeles[i, y] = new Pixel(grayscale, grayscale, grayscale);
                }
            }
        }


        //MÉTODO 10: Añade un marco a la imagen
        //Devuelve un 0 si el marco se añade correctamente
        public int AñadirMarco(int grosor, byte r, byte g, byte b) 
        {                    
                this.alto2 = this.alto;
                this.ancho2 = this.ancho;
                this.pixel1 = new Pixel[this.alto2, this.ancho2];

                if (((2 * grosor) > this.alto2) || ((2 * grosor) > this.ancho2))
                    return -1;
                for (int i = 0; i < this.alto2; i++)
                {
                    for (int j = 0; j < this.ancho2; j++)
                    {
                        if ((i < grosor) || (j < grosor) || (i >= (this.alto2 - grosor)) || (j >= (this.ancho2 - grosor)))
                        {
                            this.pixel1[i, j] = new Pixel(r, g, b);
                        }
                        else
                            this.pixel1[i, j] = this.pixeles[i, j];
                    }
                }

                     
            return 0;
        }


            //METODO 10: Suma un valor escogido a los colores r,g y b para asi sumar o restar 
            //intensidad a cada color.
            public void ModificarColor(int r, int g, int b)
        {
            Pixel[,] matrizcolores = new Pixel[this.alto, this.ancho];
            byte r1, g1, b1;

            for (int i = 0; i < this.alto; i++)
            {
                for (int y = 0; y < this.ancho; y++)
                {
                    //Si la suma da un valor mayor a 255, lo dejaremos en 255. Y lo mismo para -255.
                    if ((r + Convert.ToInt32(this.pixeles[i, y].GetR())) > 255)
                    {
                        r1 = 255;
                    }
                    else if ((r + Convert.ToInt32(this.pixeles[i, y].GetR())) < 0)
                    {
                        r1 = 0;
                    }
                    else
                    {
                        r1 = Convert.ToByte(r + Convert.ToInt32(this.pixeles[i, y].GetR()));
                    }

                    if ((g + Convert.ToInt32(this.pixeles[i, y].GetG()) > 255))
                    {
                        g1 = 255;
                    }
                    else if ((g + Convert.ToInt32(this.pixeles[i, y].GetG())) < 0)
                    {
                        g1 = 0;
                    }
                    else
                    {
                        g1 = Convert.ToByte(g + Convert.ToInt32(this.pixeles[i, y].GetG()));
                    }

                    if ((b + Convert.ToInt32(this.pixeles[i, y].GetB())) > 255)
                    {
                        b1 = 255;
                    }
                    else if ((b + Convert.ToInt32(this.pixeles[i, y].GetB())) < 0)
                    {
                        b1 = 0;
                    }
                    else
                    {
                        b1 = Convert.ToByte(b + Convert.ToInt32(this.pixeles[i, y].GetB()));
                    }
                    matrizcolores[i, y] = new Pixel(r1, g1, b1);
                }
            }
            for (int i = 0; i < this.alto; i++)
            {
                for (int y = 0; y < this.ancho; y++)
                {
                    this.pixeles[i, y] = matrizcolores[i, y];

                }

            }
        }


        //MÉTODO 11: Recorta una imagen sabiendo las coordenadas x e y de dos puntos 
        //Devuelve un 0 si se ha recortado correctamente
        public int RecortarImagen(int x1, int y1, int x2, int y2) 
        {
            if ((x1 == x2) || (y1 == y2))
                return -1;
            if ((x1 < 0) || (x2 < 0) || (y1 < 0) || (y2 < 0) || (x1 >= this.ancho) || (x2 >= this.ancho) || (y1 >= this.alto) || (y2 >= this.alto))
                return -2;

            this.alto2 = Math.Abs(y1 - y2);
            this.ancho2 = Math.Abs(x1 - x2);

            if (x2 < x1)
            {
                int x = x1;
                x1 = x2;
                x2 = x;
            }
            if (y2 < y1)
            {
                int y = y1;
                y1 = y2;
                y2 = y;
            }

            this.pixel1 = new Pixel[this.alto2, this.ancho2];
            for (int i = 0; i < this.alto2; i++)
            {
                for (int j = 0; j < this.ancho2; j++)
                {
                    this.pixel1[i, j] = this.pixeles[x1 + i, y1 + j];
                }
            }

            return 0;

        }

        //MÉTODO 12: Añade la modificación al stack
        //Devuelve un 0 si se ha añadido correctamente
        public int AñadirImagen() //Función para añadir la imagen al stack.
        {

            this.pilaimagenes.Push(this.Copiar());

            return 0;
        }


        //MÉTODO 12.2: Copia la ultima modificación de la imagen
        //Devuelve la copia de la imagen con todos sus valores asignados
        public Imagen Copiar() //Función para copiar la última modificación de la imagen
        {

            Imagen copia = new Imagen();
            copia.identificador = this.identificador;
            copia.archivo = this.archivo;
            copia.identificador = "P3";
            copia.ancho = this.ancho;
            copia.alto = this.alto;
            copia.pixeles = new Pixel[this.alto, this.ancho];
            copia.niveles = this.niveles;
            for (int i = 0; i < this.alto; i++)
            {
                for (int j = 0; j < this.ancho; j++)
                {
                    copia.pixeles[i, j] = new Pixel();
                    copia.pixeles[i, j].SetR(this.pixeles[i, j].GetR());
                    copia.pixeles[i, j].SetG(this.pixeles[i, j].GetG());
                    copia.pixeles[i, j].SetB(this.pixeles[i, j].GetB());
                }
            }


            return copia;
        }


        //MÉTODO 12.3: Deshace la ultima modificación hecha
        public void Deshacer() 
        {
            if (this.pilaimagenes.Count > 0)
            {
                Imagen im = this.pilaimagenes.Pop();
                this.identificador = im.identificador;
                this.archivo = im.archivo;
                this.ancho = im.ancho;
                this.alto = im.alto;
                this.pixeles = im.pixeles;
                this.niveles = im.niveles;
            }
        }
    }
}
    




        

    






            



        

    



    
        
