using MySql.Data.MySqlClient;
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
    public partial class Principal : Form
    {
        DataTable _DATOS = new DataTable();

        public void GuardarLista()
        {
            _DATOS.TableName = "Conexiones";
            _DATOS.WriteXml("Conexiones.xml");
        }

        public void LeerLista()
        {
            _DATOS.TableName = "Conexiones";
            _DATOS.ReadXml("Conexiones.xml");
        }

        private void ContarRegistro()
        {
            lblRegistros.Text = dtgPerfiles.Rows.Count.ToString() + " Registros";
        }

        private void Configurar()
        {
            _DATOS.Columns.Add("cPerfil");
            _DATOS.Columns.Add("cServidor");
            _DATOS.Columns.Add("cBase");
            _DATOS.Columns.Add("cUsuario");
            _DATOS.Columns.Add("cPuerto");
            _DATOS.Columns.Add("cContrasenia");
            dtgPerfiles.AutoGenerateColumns = false;
            dtgPerfiles.DataSource = _DATOS;
        }
        public Principal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Configurar();
            LeerLista();
            ContarRegistro();
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea realizar un respaldo de la base de datos seleccionada? ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GenerarRespaldo r = new GenerarRespaldo(GenerarRespaldo.Accion.ACTUALIZAR);
                    r.txbVservidor.Text = dtgPerfiles.CurrentRow.Cells["Servidor"].Value.ToString();
                    r.txtVbases.Text = dtgPerfiles.CurrentRow.Cells["Base"].Value.ToString();
                    r.txbVusuario.Text = dtgPerfiles.CurrentRow.Cells["Usuario"].Value.ToString();
                    r.txbVpuerto.Text = dtgPerfiles.CurrentRow.Cells["Puerto"].Value.ToString();
                    r.txbVpass.Text = dtgPerfiles.CurrentRow.Cells["Contrasenia"].Value.ToString();
                    r.ShowDialog();
                    if (r.Procesar)
                    {
                        dtgPerfiles.CurrentRow.Cells["Servidor"].Value = r.txbVservidor.Text;
                        dtgPerfiles.CurrentRow.Cells["Base"].Value = r.txtVbases.Text;
                        dtgPerfiles.CurrentRow.Cells["Usuario"].Value = r.txbVusuario.Text;
                        dtgPerfiles.CurrentRow.Cells["Puerto"].Value = r.txbVpuerto.Text;
                        dtgPerfiles.CurrentRow.Cells["Contrasenia"].Value = r.txbVpass.Text;
                    }
                    GuardarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe crear un perfil para respaldar una base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                string Servidor = dtgPerfiles.CurrentRow.Cells["Servidor"].Value.ToString();
                string Puerto = dtgPerfiles.CurrentRow.Cells["Puerto"].Value.ToString();
                string usuario = dtgPerfiles.CurrentRow.Cells["Usuario"].Value.ToString();
                string Pass = dtgPerfiles.CurrentRow.Cells["Contrasenia"].Value.ToString();
                string baseD = dtgPerfiles.CurrentRow.Cells["Base"].Value.ToString();
                string cadenaConexion = "data source=" + Servidor + ";port=" + Puerto + ";Uid=" + usuario + ";Pwd=" + Pass + ";";
                string Path;
                try
                {
                    string file;
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.FileName = "";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        file = ofd.FileName;
                        Path = file;

                        using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    cmd.Connection = connection;
                                    connection.Open();
                                    mb.ImportFromFile(Path);
                                    connection.Clone();
                                    MessageBox.Show("Base de datos restaurada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al restaurar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe crear un perfil para restaurar una base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EdicionConexion f = new EdicionConexion(EdicionConexion.Accion.INSERTAR);
            f.ShowDialog();
            if (f.Procesar)
            {
                DataRow NuevaFila = _DATOS.NewRow();
                NuevaFila["cPerfil"] = f.txbPerfil.Text;
                NuevaFila["cServidor"] = f.txbServidor.Text;
                NuevaFila["cBase"] = f.cmbElegir.Text;
                NuevaFila["cUsuario"] = f.txbUsuario.Text;
                NuevaFila["cPuerto"] = f.txbPuerto.Text;
                NuevaFila["cContrasenia"] = f.txbContraseña.Text;
                _DATOS.Rows.Add(NuevaFila);
                GuardarLista();
                ContarRegistro();
                MessageBox.Show("Registro agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea editar este registro? ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EdicionConexion f = new EdicionConexion(EdicionConexion.Accion.ACTUALIZAR);
                    f.txbPerfil.Text = dtgPerfiles.CurrentRow.Cells["Perfil"].Value.ToString();
                    f.txbServidor.Text = dtgPerfiles.CurrentRow.Cells["Servidor"].Value.ToString();
                    f.cmbElegir.Text = dtgPerfiles.CurrentRow.Cells["Base"].Value.ToString();
                    f.txbUsuario.Text = dtgPerfiles.CurrentRow.Cells["Usuario"].Value.ToString();
                    f.txbPuerto.Text = dtgPerfiles.CurrentRow.Cells["Puerto"].Value.ToString();
                    f.txbContraseña.Text = dtgPerfiles.CurrentRow.Cells["Contrasenia"].Value.ToString();
                    f.ShowDialog();
                    if (f.Procesar)
                    {
                        dtgPerfiles.CurrentRow.Cells["Perfil"].Value = f.txbPerfil.Text;
                        dtgPerfiles.CurrentRow.Cells["Servidor"].Value = f.txbServidor.Text;
                        dtgPerfiles.CurrentRow.Cells["Base"].Value = f.cmbElegir.Text;
                        dtgPerfiles.CurrentRow.Cells["Usuario"].Value = f.txbUsuario.Text;
                        dtgPerfiles.CurrentRow.Cells["Puerto"].Value = f.txbPuerto.Text;
                        dtgPerfiles.CurrentRow.Cells["Contrasenia"].Value = f.txbContraseña.Text;
                        MessageBox.Show("Registro editado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    GuardarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dtgPerfiles.Rows.RemoveAt(dtgPerfiles.CurrentRow.Index);
                    GuardarLista();
                    ContarRegistro();
                    MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
