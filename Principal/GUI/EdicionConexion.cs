using MySql.Data.MySqlClient;
using Principal.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.GUI
{
    public partial class EdicionConexion : Form
    {
        Accion _AccionElegida = Accion.INSERTAR;
        Boolean _PROCESAR = false;
        public Boolean Procesar
        {
            get { return _PROCESAR; }

        }
        public enum Accion { INSERTAR, ACTUALIZAR };
        public EdicionConexion(Accion pAccion)
        {
            InitializeComponent();
            _AccionElegida = pAccion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_AccionElegida == Accion.INSERTAR)
            {
                _PROCESAR = true;
                Close();
            }
            else
            {
                _PROCESAR = true;
                Close();
            }
        }
       

        private void cmbElegir_Click(object sender, EventArgs e)
        {
            
        }

        


        private void cmbElegir_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaConexion = "Server=localhost;Port=3306;Database=mysql;Uid=root;Pwd=roberto1;";
            List<string> basesDeDatos = new List<string>();

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SELECT schema_name FROM information_schema.schemata", conexion))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                basesDeDatos.Add(dr["schema_name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener bases de datos: " + ex.Message);
            }
        }

        private void EdicionConexion_Load(object sender, EventArgs e)
        {

        }
    }
 }

