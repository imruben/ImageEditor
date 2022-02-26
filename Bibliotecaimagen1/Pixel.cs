using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaImagen
{
    //CLASE Pixel: La usamos para leer los tres colores de tipo byte en las funciones y crear
    //nuevos pixeles usando los metodos Gets y Sets.

    public class Pixel
    {
        byte r;
        byte g;
        byte b;

        public Pixel(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public Pixel()
        {
            this.r = 0;
            this.g = 0;
            this.b = 0;
        }

        public byte GetR()
        {
            return this.r;
        }

        public byte GetG()
        {
            return g;
        }

        public byte GetB()
        {
            return b;
        }
        public void SetR(byte r)
        {
            this.r = r;
        }
        public void SetG(byte g)
        {
            this.g = g;
        }
        public void SetB(byte b)
        {
            this.b = b;
        }      
    }
}

