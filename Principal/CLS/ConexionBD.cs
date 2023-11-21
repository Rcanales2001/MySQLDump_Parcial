using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.CLS
{
    class ConexionBD
    {
        String _Servidor;
        String _Puerto;
        String _Usuario;
        String _Password;
        String _baseDato;
        public string Servidor
        {
            get { return _Servidor; }
            set { _Servidor = value; }
        }

        public String Puerto
        {
            get { return _Puerto; }
            set { _Puerto = value; }
        }

        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public string ObtenerCadenaConexion()
        {
            return _Cadena;
        }


        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public String BaseDato
        {
            get { return _baseDato; }
            set { _baseDato = value; }
        }

        protected MySqlConnection _CONEXION;
        String _Cadena = "Server=localhost;Port=3306;Database=mysql;Uid=root;Pwd=roberto1;SslMode=None;";

        public Boolean Conectar()
        {
            Boolean _Conectado = false;

            try
            {
                _CONEXION = new MySqlConnection();
                _CONEXION.ConnectionString = _Cadena;
                
                _CONEXION.Open();
                _Conectado = true;
            }
            catch (Exception ex)
            {
                // Log the exception or display a message for debugging
                Console.WriteLine("Error connecting to the database: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
                _Conectado = false;
            }
            finally
            {

            }
            return _Conectado;
        }

        public void Desconectar()
        {
            try
            {
                if (_CONEXION.State == System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch
            {

            }
        }
    }
}
