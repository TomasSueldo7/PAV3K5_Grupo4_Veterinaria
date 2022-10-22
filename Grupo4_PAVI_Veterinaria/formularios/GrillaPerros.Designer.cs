namespace Grupo4_PAVI_Veterinaria.formularios
{
    partial class GrillaPerros
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
            this.gdr_perros = new System.Windows.Forms.DataGridView();
            this.Nro_HC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_perros)).BeginInit();
            this.SuspendLayout();
            // 
            // gdr_perros
            // 
            this.gdr_perros.AllowUserToAddRows = false;
            this.gdr_perros.AllowUserToDeleteRows = false;
            this.gdr_perros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_perros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_HC,
            this.Nombre,
            this.Fecha_nacimiento,
            this.Id_Raza,
            this.Peso,
            this.Altura,
            this.Id_owner});
            this.gdr_perros.Location = new System.Drawing.Point(12, 55);
            this.gdr_perros.MultiSelect = false;
            this.gdr_perros.Name = "gdr_perros";
            this.gdr_perros.ReadOnly = true;
            this.gdr_perros.RowTemplate.Height = 25;
            this.gdr_perros.Size = new System.Drawing.Size(744, 358);
            this.gdr_perros.TabIndex = 18;
            this.gdr_perros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_perros_CellClick);
            // 
            // Nro_HC
            // 
            this.Nro_HC.DataPropertyName = "Nro_HC";
            this.Nro_HC.HeaderText = "N° H.Clinica";
            this.Nro_HC.Name = "Nro_HC";
            this.Nro_HC.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.DataPropertyName = "Fecha_nacimiento";
            this.Fecha_nacimiento.HeaderText = "Fecha Nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            // 
            // Id_Raza
            // 
            this.Id_Raza.DataPropertyName = "Denominacion";
            this.Id_Raza.HeaderText = "Raza";
            this.Id_Raza.Name = "Id_Raza";
            this.Id_Raza.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Altura
            // 
            this.Altura.DataPropertyName = "Altura";
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            // 
            // Id_owner
            // 
            this.Id_owner.DataPropertyName = "Dueño";
            this.Id_owner.HeaderText = "Dueño";
            this.Id_owner.Name = "Id_owner";
            this.Id_owner.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(620, 440);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 55);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(479, 440);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 55);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 457);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 23);
            this.txtNombre.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre Perro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(138, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Seleccione el perro para el registro de la consulta médica";
            // 
            // GrillaPerros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gdr_perros);
            this.Name = "GrillaPerros";
            this.Text = "GrillaPerros";
            ((System.ComponentModel.ISupportInitialize)(this.gdr_perros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gdr_perros;
        private DataGridViewTextBoxColumn Nro_HC;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Fecha_nacimiento;
        private DataGridViewTextBoxColumn Id_Raza;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn Altura;
        private DataGridViewTextBoxColumn Id_owner;
        private Button btnBuscar;
        private Button btnLimpiar;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
    }
}