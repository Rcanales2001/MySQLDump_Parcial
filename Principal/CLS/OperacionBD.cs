using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.CLS
{
    class OperacionBD
    {
        private ConexionBD conexion;

        public OperacionBD(ConexionBD conexion)
        {
            this.conexion = conexion;
        }
        public class DBOperaciones : ConexionBD
        {
            public Int32 Insertar(String pSentencia)
            {
                return EjecutarSentencia(pSentencia);
            }
            public Int32 Actualizar(String pSentencia)
            {
                return EjecutarSentencia(pSentencia);
            }
            public Int32 Eliminar(String pSentencia)
            {
                return EjecutarSentencia(pSentencia);
            }
            public Boolean Guardar()
            {
                Boolean Guardado = false;
                string sentencia;
                try
                {
                    sentencia = "show databases";

                }
                catch
                {

                }
                return Guardado;
            }

            private Int32 EjecutarSentencia(String pSentencia)
            {
                Int32 FilasAfectadas = 0;
                MySqlCommand Comando = new MySqlCommand();
                try
                {
                    if (!base.Conectar())
                    {
                        // Intentar reconectar
                        base.Conectar();
                    }

                    if (base._CONEXION.State == ConnectionState.Open)
                    {
                        Comando.Connection = base._CONEXION;
                        Comando.CommandText = pSentencia;
                        FilasAfectadas = Comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    FilasAfectadas = -1;
                    Console.WriteLine("Error executing SQL command: " + ex.Message);
                }
                finally
                {
                    base.Desconectar();
                }
                return FilasAfectadas;
            }

            public DataTable Consultar(String pConsulta)
            {
                DataTable Resultado = new DataTable();
                MySqlCommand Comando = new MySqlCommand();
                MySqlDataAdapter Adaptador = new MySqlDataAdapter();
                try
                {
                    if (base.Conectar())
                    {
                        Comando.Connection = base._CONEXION;
                        Comando.CommandText = pConsulta;
                        Adaptador.SelectCommand = Comando;
                        Adaptador.Fill(Resultado);
                    }
                }
                catch
                {
                    Resultado = new DataTable();
                }
                finally
                {
                    base.Desconectar();
                }
                return Resultado;
            }
        }

        internal DataTable Consultar(MySqlCommand cm)
        {
            throw new NotImplementedException();
        }
    }
}
