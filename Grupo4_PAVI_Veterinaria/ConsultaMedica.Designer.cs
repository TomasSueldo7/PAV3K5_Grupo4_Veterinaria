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
            this.btnBuscarMedicamentos = new System.Windows.Forms.Button();
            this.btnAgregarMedicamentos = new System.Windows.Forms.Button();
            this.grdMedicamentos = new System.Windows.Forms.DataGridView();
            this.Id_Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.txtNroMedicamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarSintomas = new System.Windows.Forms.Button();
            this.gdrSintomas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarSintomas = new System.Windows.Forms.Button();
            this.txtSintoma = new System.Windows.Forms.TextBox();
            this.txtNroSintoma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarHC = new System.Windows.Forms.Button();
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
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNroConsulta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicamentos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSintomas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Historia Clínica";
            // 
            // txtNroHC
            // 
            this.txtNroHC.Location = new System.Drawing.Point(493, 42);
            this.txtNroHC.Name = "txtNroHC";
            this.txtNroHC.Size = new System.Drawing.Size(69, 23);
            this.txtNroHC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarMedicamentos);
            this.groupBox1.Controls.Add(this.btnAgregarMedicamentos);
            this.groupBox1.Controls.Add(this.grdMedicamentos);
            this.groupBox1.Controls.Add(this.txtMedicamento);
            this.groupBox1.Controls.Add(this.txtNroMedicamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 325);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicamentos";
            // 
            // btnBuscarMedicamentos
            // 
            this.btnBuscarMedicamentos.Location = new System.Drawing.Point(83, 106);
            this.btnBuscarMedicamentos.Name = "btnBuscarMedicamentos";
            this.btnBuscarMedicamentos.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMedicamentos.TabIndex = 6;
            this.btnBuscarMedicamentos.Text = "Buscar";
            this.btnBuscarMedicamentos.UseVisualStyleBackColor = true;
            this.btnBuscarMedicamentos.Click += new System.EventHandler(this.btnBuscarMedicamentos_Click);
            // 
            // btnAgregarMedicamentos
            // 
            this.btnAgregarMedicamentos.Location = new System.Drawing.Point(164, 106);
            this.btnAgregarMedicamentos.Name = "btnAgregarMedicamentos";
            this.btnAgregarMedicamentos.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMedicamentos.TabIndex = 5;
            this.btnAgregarMedicamentos.Text = "Agregar";
            this.btnAgregarMedicamentos.UseVisualStyleBackColor = true;
            this.btnAgregarMedicamentos.Click += new System.EventHandler(this.btnAgregarMedicamentos_Click);
            // 
            // grdMedicamentos
            // 
            this.grdMedicamentos.AllowUserToAddRows = false;
            this.grdMedicamentos.AllowUserToDeleteRows = false;
            this.grdMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Medicamento,
            this.Descripcion});
            this.grdMedicamentos.Location = new System.Drawing.Point(6, 135);
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
            // txtMedicamento
            // 
            this.txtMedicamento.Enabled = false;
            this.txtMedicamento.Location = new System.Drawing.Point(164, 56);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(135, 23);
            this.txtMedicamento.TabIndex = 3;
            // 
            // txtNroMedicamento
            // 
            this.txtNroMedicamento.Location = new System.Drawing.Point(164, 26);
            this.txtNroMedicamento.Name = "txtNroMedicamento";
            this.txtNroMedicamento.Size = new System.Drawing.Size(135, 23);
            this.txtNroMedicamento.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "N° Medicamento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarSintomas);
            this.groupBox2.Controls.Add(this.gdrSintomas);
            this.groupBox2.Controls.Add(this.btnAgregarSintomas);
            this.groupBox2.Controls.Add(this.txtSintoma);
            this.groupBox2.Controls.Add(this.txtNroSintoma);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(366, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 325);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sintomas";
            // 
            // btnBuscarSintomas
            // 
            this.btnBuscarSintomas.Location = new System.Drawing.Point(86, 106);
            this.btnBuscarSintomas.Name = "btnBuscarSintomas";
            this.btnBuscarSintomas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarSintomas.TabIndex = 8;
            this.btnBuscarSintomas.Text = "Buscar";
            this.btnBuscarSintomas.UseVisualStyleBackColor = true;
            this.btnBuscarSintomas.Click += new System.EventHandler(this.btnBuscarSintomas_Click);
            // 
            // gdrSintomas
            // 
            this.gdrSintomas.AllowUserToAddRows = false;
            this.gdrSintomas.AllowUserToDeleteRows = false;
            this.gdrSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSintomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gdrSintomas.Location = new System.Drawing.Point(6, 135);
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
            this.btnAgregarSintomas.Location = new System.Drawing.Point(167, 106);
            this.btnAgregarSintomas.Name = "btnAgregarSintomas";
            this.btnAgregarSintomas.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarSintomas.TabIndex = 7;
            this.btnAgregarSintomas.Text = "Agregar";
            this.btnAgregarSintomas.UseVisualStyleBackColor = true;
            this.btnAgregarSintomas.Click += new System.EventHandler(this.btnAgregarSintomas_Click);
            // 
            // txtSintoma
            // 
            this.txtSintoma.Enabled = false;
            this.txtSintoma.Location = new System.Drawing.Point(182, 53);
            this.txtSintoma.Name = "txtSintoma";
            this.txtSintoma.Size = new System.Drawing.Size(135, 23);
            this.txtSintoma.TabIndex = 3;
            // 
            // txtNroSintoma
            // 
            this.txtNroSintoma.Location = new System.Drawing.Point(182, 24);
            this.txtNroSintoma.Name = "txtNroSintoma";
            this.txtNroSintoma.Size = new System.Drawing.Size(135, 23);
            this.txtNroSintoma.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "N° Sintoma";
            // 
            // btnBuscarHC
            // 
            this.btnBuscarHC.Location = new System.Drawing.Point(581, 42);
            this.btnBuscarHC.Name = "btnBuscarHC";
            this.btnBuscarHC.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarHC.TabIndex = 2;
            this.btnBuscarHC.Text = "Buscar";
            this.btnBuscarHC.UseVisualStyleBackColor = true;
            this.btnBuscarHC.Click += new System.EventHandler(this.btnBuscarHC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Peso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Altura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Dueño";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(164, 64);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(154, 23);
            this.txtFechaNacimiento.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(164, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 23);
            this.txtNombre.TabIndex = 14;
            // 
            // txtDueño
            // 
            this.txtDueño.Enabled = false;
            this.txtDueño.Location = new System.Drawing.Point(164, 129);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(154, 23);
            this.txtDueño.TabIndex = 15;
            // 
            // txtPeso
            // 
            this.txtPeso.Enabled = false;
            this.txtPeso.Location = new System.Drawing.Point(164, 97);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(154, 23);
            this.txtPeso.TabIndex = 16;
            // 
            // txtAltura
            // 
            this.txtAltura.Enabled = false;
            this.txtAltura.Location = new System.Drawing.Point(164, 161);
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
            this.groupBox3.Controls.Add(this.txtRaza);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtAltura);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDueño);
            this.groupBox3.Controls.Add(this.txtPeso);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtFechaNacimiento);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 232);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Perro";
            // 
            // txtRaza
            // 
            this.txtRaza.Enabled = false;
            this.txtRaza.Location = new System.Drawing.Point(164, 192);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(154, 23);
            this.txtRaza.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Raza";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(493, 109);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(69, 23);
            this.txtLegajo.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(548, 175);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 52);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(452, 175);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 52);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(383, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "N° Consulta";
            // 
            // txtNroConsulta
            // 
            this.txtNroConsulta.Enabled = false;
            this.txtNroConsulta.Location = new System.Drawing.Point(493, 76);
            this.txtNroConsulta.Name = "txtNroConsulta";
            this.txtNroConsulta.Size = new System.Drawing.Size(69, 23);
            this.txtNroConsulta.TabIndex = 22;
            this.txtNroConsulta.TextChanged += new System.EventHandler(this.txtNroConsulta_TextChanged);
            // 
            // ConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 587);
            this.Controls.Add(this.txtNroConsulta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBuscarHC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNroHC);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaMedica";
            this.Text = "Registrar consulta medica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicamentos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSintomas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNroHC;
        private Label label3;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private DataGridView grdMedicamentos;
        private TextBox txtMedicamento;
        private TextBox txtNroMedicamento;
        private GroupBox groupBox2;
        private DataGridView gdrSintomas;
        private TextBox txtSintoma;
        private TextBox txtNroSintoma;
        private Label label5;
        private Label label6;
        private Button btnAgregarMedicamentos;
        private Button btnBuscarMedicamentos;
        private Button btnBuscarSintomas;
        private Button btnAgregarSintomas;
        private Button btnBuscarHC;
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
        private TextBox txtLegajo;
        private TextBox txtRaza;
        private Button btnGuardar;
        private Button btnLimpiar;
        private DataGridViewTextBoxColumn Id_Medicamento;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label13;
        private TextBox txtNroConsulta;
    }
}