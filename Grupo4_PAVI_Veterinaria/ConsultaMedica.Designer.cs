namespace Grupo4_PAVI_Veterinaria
{
    partial class ConsultaMedica
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroHC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMedicamentos = new System.Windows.Forms.ComboBox();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.grdMedicamentos = new System.Windows.Forms.DataGridView();
            this.Id_Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarMedicamentos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarSintomas = new System.Windows.Forms.Button();
            this.cmbSintomas = new System.Windows.Forms.ComboBox();
            this.gdrSintomas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarSintomas = new System.Windows.Forms.Button();
            this.txtSintoma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNroConsulta = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicamentos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSintomas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Historia Clínica";
            // 
            // txtNroHC
            // 
            this.txtNroHC.Enabled = false;
            this.txtNroHC.Location = new System.Drawing.Point(164, 72);
            this.txtNroHC.Name = "txtNroHC";
            this.txtNroHC.Size = new System.Drawing.Size(154, 23);
            this.txtNroHC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMedicamentos);
            this.groupBox1.Controls.Add(this.btnAgregarM);
            this.groupBox1.Controls.Add(this.txtMedicamento);
            this.groupBox1.Controls.Add(this.grdMedicamentos);
            this.groupBox1.Controls.Add(this.btnBuscarMedicamentos);
            this.groupBox1.Location = new System.Drawing.Point(23, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 295);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicamentos";
            // 
            // cmbMedicamentos
            // 
            this.cmbMedicamentos.FormattingEnabled = true;
            this.cmbMedicamentos.Location = new System.Drawing.Point(46, 71);
            this.cmbMedicamentos.Name = "cmbMedicamentos";
            this.cmbMedicamentos.Size = new System.Drawing.Size(154, 23);
            this.cmbMedicamentos.TabIndex = 25;
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.Location = new System.Drawing.Point(223, 71);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(72, 28);
            this.btnAgregarM.TabIndex = 24;
            this.btnAgregarM.Text = "Agregar";
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(46, 34);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(154, 23);
            this.txtMedicamento.TabIndex = 23;
            // 
            // grdMedicamentos
            // 
            this.grdMedicamentos.AllowUserToAddRows = false;
            this.grdMedicamentos.AllowUserToDeleteRows = false;
            this.grdMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Medicamento,
            this.Descripcion});
            this.grdMedicamentos.Location = new System.Drawing.Point(12, 105);
            this.grdMedicamentos.Name = "grdMedicamentos";
            this.grdMedicamentos.ReadOnly = true;
            this.grdMedicamentos.RowTemplate.Height = 25;
            this.grdMedicamentos.Size = new System.Drawing.Size(306, 184);
            this.grdMedicamentos.TabIndex = 4;
            // 
            // Id_Medicamento
            // 
            this.Id_Medicamento.DataPropertyName = "Descripcion";
            this.Id_Medicamento.HeaderText = "ID";
            this.Id_Medicamento.Name = "Id_Medicamento";
            this.Id_Medicamento.ReadOnly = true;
            this.Id_Medicamento.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 210;
            // 
            // btnBuscarMedicamentos
            // 
            this.btnBuscarMedicamentos.Location = new System.Drawing.Point(223, 30);
            this.btnBuscarMedicamentos.Name = "btnBuscarMedicamentos";
            this.btnBuscarMedicamentos.Size = new System.Drawing.Size(72, 28);
            this.btnBuscarMedicamentos.TabIndex = 6;
            this.btnBuscarMedicamentos.Text = "Buscar";
            this.btnBuscarMedicamentos.UseVisualStyleBackColor = true;
            this.btnBuscarMedicamentos.Click += new System.EventHandler(this.btnBuscarMedicamentos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarSintomas);
            this.groupBox2.Controls.Add(this.cmbSintomas);
            this.groupBox2.Controls.Add(this.gdrSintomas);
            this.groupBox2.Controls.Add(this.btnAgregarSintomas);
            this.groupBox2.Controls.Add(this.txtSintoma);
            this.groupBox2.Location = new System.Drawing.Point(361, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 295);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sintomas";
            // 
            // btnBuscarSintomas
            // 
            this.btnBuscarSintomas.Location = new System.Drawing.Point(212, 30);
            this.btnBuscarSintomas.Name = "btnBuscarSintomas";
            this.btnBuscarSintomas.Size = new System.Drawing.Size(72, 28);
            this.btnBuscarSintomas.TabIndex = 8;
            this.btnBuscarSintomas.Text = "Buscar";
            this.btnBuscarSintomas.UseVisualStyleBackColor = true;
            this.btnBuscarSintomas.Click += new System.EventHandler(this.btnBuscarSintomas_Click);
            // 
            // cmbSintomas
            // 
            this.cmbSintomas.FormattingEnabled = true;
            this.cmbSintomas.Location = new System.Drawing.Point(35, 70);
            this.cmbSintomas.Name = "cmbSintomas";
            this.cmbSintomas.Size = new System.Drawing.Size(154, 23);
            this.cmbSintomas.TabIndex = 29;
            // 
            // gdrSintomas
            // 
            this.gdrSintomas.AllowUserToAddRows = false;
            this.gdrSintomas.AllowUserToDeleteRows = false;
            this.gdrSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSintomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gdrSintomas.Location = new System.Drawing.Point(6, 105);
            this.gdrSintomas.Name = "gdrSintomas";
            this.gdrSintomas.ReadOnly = true;
            this.gdrSintomas.RowTemplate.Height = 25;
            this.gdrSintomas.Size = new System.Drawing.Size(311, 184);
            this.gdrSintomas.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 210;
            // 
            // btnAgregarSintomas
            // 
            this.btnAgregarSintomas.Location = new System.Drawing.Point(212, 70);
            this.btnAgregarSintomas.Name = "btnAgregarSintomas";
            this.btnAgregarSintomas.Size = new System.Drawing.Size(72, 28);
            this.btnAgregarSintomas.TabIndex = 28;
            this.btnAgregarSintomas.Text = "Agregar";
            this.btnAgregarSintomas.UseVisualStyleBackColor = true;
            this.btnAgregarSintomas.Click += new System.EventHandler(this.btnAgregarSintomas_Click);
            // 
            // txtSintoma
            // 
            this.txtSintoma.Location = new System.Drawing.Point(35, 33);
            this.txtSintoma.Name = "txtSintoma";
            this.txtSintoma.Size = new System.Drawing.Size(154, 23);
            this.txtSintoma.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Peso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Altura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Dueño";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(164, 144);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(154, 23);
            this.txtFechaNacimiento.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(164, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 23);
            this.txtNombre.TabIndex = 14;
            // 
            // txtDueño
            // 
            this.txtDueño.Enabled = false;
            this.txtDueño.Location = new System.Drawing.Point(480, 72);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(154, 23);
            this.txtDueño.TabIndex = 15;
            // 
            // txtPeso
            // 
            this.txtPeso.Enabled = false;
            this.txtPeso.Location = new System.Drawing.Point(480, 34);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(154, 23);
            this.txtPeso.TabIndex = 16;
            // 
            // txtAltura
            // 
            this.txtAltura.Enabled = false;
            this.txtAltura.Location = new System.Drawing.Point(480, 106);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(154, 23);
            this.txtAltura.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(383, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Legajo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNroConsulta);
            this.groupBox3.Controls.Add(this.txtRaza);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtAltura);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNroHC);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDueño);
            this.groupBox3.Controls.Add(this.txtPeso);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtFechaNacimiento);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(29, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 191);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Perro";
            // 
            // txtNroConsulta
            // 
            this.txtNroConsulta.Enabled = false;
            this.txtNroConsulta.Location = new System.Drawing.Point(164, 109);
            this.txtNroConsulta.Name = "txtNroConsulta";
            this.txtNroConsulta.Size = new System.Drawing.Size(154, 23);
            this.txtNroConsulta.TabIndex = 0;
            // 
            // txtRaza
            // 
            this.txtRaza.Enabled = false;
            this.txtRaza.Location = new System.Drawing.Point(480, 144);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(154, 23);
            this.txtRaza.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "N° Consulta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Raza";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(422, 670);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 52);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(316, 670);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 52);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(148, 21);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(154, 23);
            this.txtLegajo.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtLegajo);
            this.groupBox4.Location = new System.Drawing.Point(361, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 50);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Legajo";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(218, 670);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 52);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 749);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaMedica";
            this.Text = "Registrar consulta medica";
            this.Load += new System.EventHandler(this.ConsultaMedica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicamentos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSintomas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNroHC;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView grdMedicamentos;
        private GroupBox groupBox2;
        private DataGridView gdrSintomas;
        private Button btnBuscarMedicamentos;
        private Button btnBuscarSintomas;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtFechaNacimiento;
        private TextBox txtNombre;
        private TextBox txtDueño;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label label12;
        private GroupBox groupBox3;
        private Label label8;
        private TextBox txtRaza;
        private Button btnGuardar;
        private Button btnLimpiar;
        private DataGridViewTextBoxColumn Id_Medicamento;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label13;
        private TextBox txtNroConsulta;
        private ComboBox cmbMedicamentos;
        private Button btnAgregarM;
        private TextBox txtMedicamento;
        private ComboBox cmbSintomas;
        private Button btnAgregarSintomas;
        private TextBox txtSintoma;
        private TextBox txtLegajo;
        private GroupBox groupBox4;
        private Label label2;
        private Button btnVolver;
    }
}