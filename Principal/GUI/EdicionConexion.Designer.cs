
namespace Principal.GUI
{
    partial class EdicionConexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionConexion));
            this.cmbElegir = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txbPerfil = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.txbPuerto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbElegir
            // 
            this.cmbElegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbElegir.FormattingEnabled = true;
            this.cmbElegir.Location = new System.Drawing.Point(311, 209);
            this.cmbElegir.Margin = new System.Windows.Forms.Padding(2);
            this.cmbElegir.Name = "cmbElegir";
            this.cmbElegir.Size = new System.Drawing.Size(206, 24);
            this.cmbElegir.TabIndex = 19;
            this.cmbElegir.SelectedIndexChanged += new System.EventHandler(this.cmbElegir_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(427, 272);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(323, 272);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Conexión";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(308, 190);
            this.lblBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(105, 17);
            this.lblBase.TabIndex = 27;
            this.lblBase.Text = "Base de Datos:";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(55, 190);
            this.lblpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(85, 17);
            this.lblpass.TabIndex = 29;
            this.lblpass.Text = "Contraseña:";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña.Location = new System.Drawing.Point(58, 209);
            this.txbContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txbContraseña.Multiline = true;
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(206, 24);
            this.txbContraseña.TabIndex = 21;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(308, 130);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 28;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(311, 149);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txbUsuario.Multiline = true;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(206, 24);
            this.txbUsuario.TabIndex = 20;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.Location = new System.Drawing.Point(308, 69);
            this.lblServidor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(65, 17);
            this.lblServidor.TabIndex = 25;
            this.lblServidor.Text = "Servidor:";
            // 
            // txbServidor
            // 
            this.txbServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbServidor.Location = new System.Drawing.Point(311, 89);
            this.txbServidor.Margin = new System.Windows.Forms.Padding(2);
            this.txbServidor.Multiline = true;
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(206, 24);
            this.txbServidor.TabIndex = 17;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(55, 69);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 17);
            this.lblPerfil.TabIndex = 24;
            this.lblPerfil.Text = "Perfil:";
            // 
            // txbPerfil
            // 
            this.txbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPerfil.Location = new System.Drawing.Point(58, 89);
            this.txbPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.txbPerfil.Multiline = true;
            this.txbPerfil.Name = "txbPerfil";
            this.txbPerfil.Size = new System.Drawing.Size(206, 24);
            this.txbPerfil.TabIndex = 16;
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuerto.Location = new System.Drawing.Point(55, 130);
            this.lblPuerto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(54, 17);
            this.lblPuerto.TabIndex = 26;
            this.lblPuerto.Text = "Puerto:";
            // 
            // txbPuerto
            // 
            this.txbPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPuerto.Location = new System.Drawing.Point(58, 149);
            this.txbPuerto.Margin = new System.Windows.Forms.Padding(2);
            this.txbPuerto.Multiline = true;
            this.txbPuerto.Name = "txbPuerto";
            this.txbPuerto.Size = new System.Drawing.Size(206, 24);
            this.txbPuerto.TabIndex = 18;
            // 
            // EdicionConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 320);
            this.Controls.Add(this.cmbElegir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.txbServidor);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.txbPerfil);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.txbPuerto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdicionConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EdicionConexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbElegir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblpass;
        public System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblServidor;
        public System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Label lblPerfil;
        public System.Windows.Forms.TextBox txbPerfil;
        private System.Windows.Forms.Label lblPuerto;
        public System.Windows.Forms.TextBox txbPuerto;
    }
}