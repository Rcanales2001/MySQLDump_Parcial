using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.GUI
{
    public partial class GenerarRespaldo : Form
    {
        StreamWriter writer;
        StreamReader ReaderC;
        Accion _AccionElegida = Accion.INSERTAR;
        Boolean _PROCESAR = false;
        public Boolean Procesar
        {
            get { return _PROCESAR; }

        }

        public enum Accion { INSERTAR, ACTUALIZAR };

        public GenerarRespaldo(Accion pAccion)
        {
            InitializeComponent();
            _AccionElegida = pAccion;
        }

        private void btnVCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVConectar_Click(object sender, EventArgs e)
        {
            string servidor = txbVservidor.Text;
            string puerto = txbVpuerto.Text;
            string usuario = txbVusuario.Text;
            string password = txbVpass.Text;
            string baseD = txtVbases.Text;
            try
            {
                string file;
                SaveFileDialog re = new SaveFileDialog();
                re.Filter = "SQL Dump File (*:sql)|*.sql|All Files(*.*)|*.*";
                re.FileName = string.Format("{0}_[{1}].sql", baseD, DateTime.Now.ToString("yyyy-MM-dd HH mm").Replace(" ", "_"));
                if (re.ShowDialog() == DialogResult.OK)
                {
                    file = re.FileName;
                    Process prss = new Process();
                    prss.StartInfo.FileName = "cmd.exe";
                    prss.StartInfo.UseShellExecute = false;
                    prss.StartInfo.WorkingDirectory = @"C:\Program Files\MySQL\MySQL Server 8.0\bin";
                    //LA LINEA (58) LA DEBE CAMBIAR POR LA RUTA DE SU MySQL ASI COMO ESTA EN LA RUTA
                    prss.StartInfo.RedirectStandardInput = true;
                    prss.StartInfo.RedirectStandardOutput = true;
                    prss.Start();

                    writer = prss.StandardInput;
                    ReaderC = prss.StandardOutput;

                    writer.WriteLine(string.Format("mysqldump --user={0} --password={1} --result-file={2} --databases {3}", usuario, password, file, baseD));
                    writer.Close();
                    prss.WaitForExit();
                    prss.Close();
                    MessageBox.Show("Respaldo realizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizo el respaldo correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GenerarRespaldo_Load(object sender, EventArgs e)
        {

        }
    }
}
