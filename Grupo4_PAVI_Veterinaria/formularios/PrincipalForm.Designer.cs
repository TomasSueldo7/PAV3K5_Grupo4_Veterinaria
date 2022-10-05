namespace Grupo4_PAVI_Veterinaria.formularios
{
    partial class PrincipalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.perrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // perrosToolStripMenuItem
            // 
            this.perrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.empleadosToolStripMenuItem1});
            this.perrosToolStripMenuItem.Name = "perrosToolStripMenuItem";
            this.perrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.perrosToolStripMenuItem.Text = "Registros";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nuevoToolStripMenuItem.Text = "Perros";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarConsultaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // registrarConsultaToolStripMenuItem
            // 
            this.registrarConsultaToolStripMenuItem.Name = "registrarConsultaToolStripMenuItem";
            this.registrarConsultaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.registrarConsultaToolStripMenuItem.Text = "Registrar consulta";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(12, 411);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(111, 30);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.Text = "PrincipalForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem perrosToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem1;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem registrarConsultaToolStripMenuItem;
        private Label lblBienvenido;
    }
}