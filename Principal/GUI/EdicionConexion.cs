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

            // Suscribe el evento Load al método correspondiente
            this.Load += EdicionConexion_Load;
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

           
        }
        private void CargarBasesDeDatos()
        {
            string cadenaConexion = "Server=localhost;Port=3306;Database=mysql;Uid=root;Pwd=roberto1;SslMode=None;";
            List<string> basesDeDatos = new List<string>();

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conexion))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    basesDeDatos.Add(dr[0].ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay bases de datos disponibles.");
                            }
                        }
                    }
                }

                // Asigna la lista de bases de datos al ComboBox
                cmbElegir.DataSource = basesDeDatos;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error MySQL al cargar bases de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar bases de datos.", ex);
            }
        }
        private void EdicionConexion_Load(object sender, EventArgs e)
        {
            try
            {
                // Llama al método para cargar las bases de datos en el ComboBox
                CargarBasesDeDatos();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error MySQL: " + ex.Message);
                Console.WriteLine("Número de error: " + ex.Number);
                // Otros detalles del error
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                // Otros detalles del error
            }
        }
    }
 }

