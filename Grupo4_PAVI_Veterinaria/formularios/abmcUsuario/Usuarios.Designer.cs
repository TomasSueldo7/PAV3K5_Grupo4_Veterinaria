namespace Grupo4_PAVI_Veterinaria.formularios.abmcUsuario
{
    partial class Usuarios
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.contenedorDatosUsuario = new System.Windows.Forms.GroupBox();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtRepetirPassword = new System.Windows.Forms.TextBox();
            this.lblRepetirPassword = new System.Windows.Forms.Label();
            this.txtPasswordUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblPasswordUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.contenedorGrillaUsuarios = new System.Windows.Forms.GroupBox();
            this.grillaUsuarios = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorDatosUsuario.SuspendLayout();
            this.contenedorGrillaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(30, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar Usuario";
            // 
            // contenedorDatosUsuario
            // 
            this.contenedorDatosUsuario.Controls.Add(this.btnBajaUsuario);
            this.contenedorDatosUsuario.Controls.Add(this.btnActualizarUsuario);
            this.contenedorDatosUsuario.Controls.Add(this.txtRol);
            this.contenedorDatosUsuario.Controls.Add(this.btnAltaUsuario);
            this.contenedorDatosUsuario.Controls.Add(this.btnLimpiarCampos);
            this.contenedorDatosUsuario.Controls.Add(this.lblRol);
            this.contenedorDatosUsuario.Controls.Add(this.txtRepetirPassword);
            this.contenedorDatosUsuario.Controls.Add(this.lblRepetirPassword);
            this.contenedorDatosUsuario.Controls.Add(this.txtPasswordUsuario);
            this.contenedorDatosUsuario.Controls.Add(this.txtNombreUsuario);
            this.contenedorDatosUsuario.Controls.Add(this.lblPasswordUsuario);
            this.contenedorDatosUsuario.Controls.Add(this.lblNombreUsuario);
            this.contenedorDatosUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contenedorDatosUsuario.Location = new System.Drawing.Point(30, 40);
            this.contenedorDatosUsuario.Name = "contenedorDatosUsuario";
            this.contenedorDatosUsuario.Size = new System.Drawing.Size(621, 252);
            this.contenedorDatosUsuario.TabIndex = 10;
            this.contenedorDatosUsuario.TabStop = false;
            this.contenedorDatosUsuario.Text = "Datos usuario";
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBajaUsuario.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Eliminar;
            this.btnBajaUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBajaUsuario.Location = new System.Drawing.Point(451, 137);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(93, 75);
            this.btnBajaUsuario.TabIndex = 21;
            this.btnBajaUsuario.Text = "Eliminar";
            this.btnBajaUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBajaUsuario.UseVisualStyleBackColor = true;
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnBajaUsuario_Click);
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarUsuario.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Actualizar;
            this.btnActualizarUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(336, 139);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(91, 74);
            this.btnActualizarUsuario.TabIndex = 20;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(179, 179);
            this.txtRol.MaxLength = 30;
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(100, 27);
            this.txtRol.TabIndex = 19;
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaUsuario.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Registrar;
            this.btnAltaUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAltaUsuario.Location = new System.Drawing.Point(451, 48);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(93, 74);
            this.btnAltaUsuario.TabIndex = 18;
            this.btnAltaUsuario.Text = "Registrar";
            this.btnAltaUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAltaUsuario.UseVisualStyleBackColor = true;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarCampos.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Limpiar;
            this.btnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(335, 47);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(92, 74);
            this.btnLimpiarCampos.TabIndex = 17;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRol.Location = new System.Drawing.Point(29, 179);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(39, 21);
            this.lblRol.TabIndex = 16;
            this.lblRol.Text = "Rol:";
            // 
            // txtRepetirPassword
            // 
            this.txtRepetirPassword.Location = new System.Drawing.Point(179, 137);
            this.txtRepetirPassword.MaxLength = 30;
            this.txtRepetirPassword.Name = "txtRepetirPassword";
            this.txtRepetirPassword.PasswordChar = '*';
            this.txtRepetirPassword.Size = new System.Drawing.Size(100, 27);
            this.txtRepetirPassword.TabIndex = 14;
            // 
            // lblRepetirPassword
            // 
            this.lblRepetirPassword.AutoSize = true;
            this.lblRepetirPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRepetirPassword.Location = new System.Drawing.Point(28, 135);
            this.lblRepetirPassword.Name = "lblRepetirPassword";
            this.lblRepetirPassword.Size = new System.Drawing.Size(145, 21);
            this.lblRepetirPassword.TabIndex = 13;
            this.lblRepetirPassword.Text = "Repetir password:";
            // 
            // txtPasswordUsuario
            // 
            this.txtPasswordUsuario.Location = new System.Drawing.Point(179, 92);
            this.txtPasswordUsuario.MaxLength = 30;
            this.txtPasswordUsuario.Name = "txtPasswordUsuario";
            this.txtPasswordUsuario.PasswordChar = '*';
            this.txtPasswordUsuario.Size = new System.Drawing.Size(100, 27);
            this.txtPasswordUsuario.TabIndex = 12;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(179, 48);
            this.txtNombreUsuario.MaxLength = 30;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 27);
            this.txtNombreUsuario.TabIndex = 11;
            // 
            // lblPasswordUsuario
            // 
            this.lblPasswordUsuario.AutoSize = true;
            this.lblPasswordUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordUsuario.Location = new System.Drawing.Point(28, 94);
            this.lblPasswordUsuario.Name = "lblPasswordUsuario";
            this.lblPasswordUsuario.Size = new System.Drawing.Size(86, 21);
            this.lblPasswordUsuario.TabIndex = 10;
            this.lblPasswordUsuario.Text = "Password:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.Location = new System.Drawing.Point(28, 47);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(142, 21);
            this.lblNombreUsuario.TabIndex = 9;
            this.lblNombreUsuario.Text = "Nombre usuario: ";
            // 
            // contenedorGrillaUsuarios
            // 
            this.contenedorGrillaUsuarios.Controls.Add(this.grillaUsuarios);
            this.contenedorGrillaUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contenedorGrillaUsuarios.Location = new System.Drawing.Point(30, 298);
            this.contenedorGrillaUsuarios.Name = "contenedorGrillaUsuarios";
            this.contenedorGrillaUsuarios.Size = new System.Drawing.Size(621, 225);
            this.contenedorGrillaUsuarios.TabIndex = 11;
            this.contenedorGrillaUsuarios.TabStop = false;
            this.contenedorGrillaUsuarios.Text = "Listado usuarios";
            // 
            // grillaUsuarios
            // 
            this.grillaUsuarios.AllowUserToAddRows = false;
            this.grillaUsuarios.AllowUserToDeleteRows = false;
            this.grillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.passwordUsuario,
            this.rolUsuario});
            this.grillaUsuarios.Location = new System.Drawing.Point(0, 26);
            this.grillaUsuarios.Name = "grillaUsuarios";
            this.grillaUsuarios.ReadOnly = true;
            this.grillaUsuarios.RowTemplate.Height = 25;
            this.grillaUsuarios.Size = new System.Drawing.Size(544, 199);
            this.grillaUsuarios.TabIndex = 10;
            this.grillaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaUsuarios_CellClick_1);
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 200;
            // 
            // passwordUsuario
            // 
            this.passwordUsuario.DataPropertyName = "Contra";
            this.passwordUsuario.HeaderText = "Password";
            this.passwordUsuario.Name = "passwordUsuario";
            this.passwordUsuario.ReadOnly = true;
            this.passwordUsuario.Width = 200;
            // 
            // rolUsuario
            // 
            this.rolUsuario.DataPropertyName = "Rol";
            this.rolUsuario.HeaderText = "Rol";
            this.rolUsuario.Name = "rolUsuario";
            this.rolUsuario.ReadOnly = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 535);
            this.Controls.Add(this.contenedorGrillaUsuarios);
            this.Controls.Add(this.contenedorDatosUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.contenedorDatosUsuario.ResumeLayout(false);
            this.contenedorDatosUsuario.PerformLayout();
            this.contenedorGrillaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private GroupBox contenedorDatosUsuario;
        private Button btnAltaUsuario;
        private Button btnLimpiarCampos;
        private Label lblRol;
        private TextBox txtRepetirPassword;
        private Label lblRepetirPassword;
        private TextBox txtPasswordUsuario;
        private TextBox txtNombreUsuario;
        private Label lblPasswordUsuario;
        private Label lblNombreUsuario;
        private GroupBox contenedorGrillaUsuarios;
        private DataGridView grillaUsuarios;
        private TextBox txtRol;
        private Button btnBajaUsuario;
        private Button btnActualizarUsuario;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn passwordUsuario;
        private DataGridViewTextBoxColumn rolUsuario;
    }
}