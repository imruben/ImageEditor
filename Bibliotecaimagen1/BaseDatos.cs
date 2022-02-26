using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace BibliotecaImagen
{
    public class BaseDatos
    {

        //Clase BaseDatos: Es la clase de la base de datos, desde donde abrimos la base de datos
        //y creamos todos los métodos de la base de datos para poder manejarla desde un forms.



        //Conexión con la base de datos
        private SQLiteConnection cnx;


        //Abre la conexión con la base de datos
        public int Iniciar()
        {
            try
            {
              //El archivo BaseDatos.db esta en el debug, aun asi no he conseguido usarlo sin poner la ruta entera
                string dataSource = "Data Source=C:\\Users\\Ruben\\Documents\\Desktop\\PROYECTO PP FINAL GRUPO 2\\Bibliotecaimagen1\\bin\\Debug\\BaseDatos.db";
                cnx = new SQLiteConnection(dataSource);
                cnx.Open();
            }
            catch (SQLiteException)
            {
                return -1;
            }
            return 0;
        }


        //Cierra la conexión con la base de datos
        public void Cerrar()
        {
            if(cnx != null)
            {
                cnx.Close();
                cnx = null;
            }
        }


        //Devuelve un DataTable con todos los registros de la base de datos
        public DataTable GetImagenes()
        {
            string sql = "SELECT * FROM imagenes";
            DataTable res = new DataTable();
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);                   
            adp.Fill(res);
            return res;

        }


        //Inserta los datos en la base de datos
        public void InsertarDatos(string nombre, int alto, int ancho, string diahora)
        {
            SQLiteDataAdapter adp;
            DataTable dt = new DataTable();
            string sql;
            sql = "SELECT * FROM imagenes WHERE NOMBRE = '" + nombre + "'";
            adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
            { // Inserta la imagen en caso de que no este
                SQLiteCommand command;
                sql = "INSERT INTO imagenes VALUES ('" + nombre + "', " + alto + ", " + ancho
                + ", '" + diahora + "')";
                command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
            }
            else
            { //Actualiza en caso de que si este
                SQLiteCommand command;
                sql = "UPDATE imagenes SET ALTURA = " + alto + ", ANCHO = " + ancho + ",FECHA = '" + diahora + "' WHERE NOMBRE = '" + nombre + "'";
                command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
            }
        }



        //Devuelve un DataTable con las imagenes cuyo nombre empieza por el string recibido
        public DataTable GetPorNombre(string nombre)
        {
            string sql = "SELECT * FROM imagenes WHERE NOMBRE LIKE '" + nombre + "%'";
            DataTable dt = new DataTable();
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx); 
            adp.Fill(dt);
            return dt;
        }

        

        //Devuelve un DataTable con las imagenes cuya fecha de modificación es la recibida
        public DataTable GetPorFecha(string data)
        {
            string sql = "SELECT * FROM imagenes WHERE FECHA = '" + data + "'";
            DataTable dt = new DataTable();
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(dt);
            return dt;
        }



        //Elimina los datos de una imagen del DataTable
        public DataTable EliminarDatos(string nombre)
        {

            string sql = "DELETE FROM imagenes WHERE NOMBRE = '" + nombre + "'";
            DataTable dt = new DataTable();
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, cnx);
            adp.Fill(dt);
            return dt;            

        }
        
    }




}

