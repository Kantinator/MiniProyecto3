namespace MiniProyecto3.vista
{
    partial class FormInscripcionClase
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbIdGrupo;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnInscribirClase;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbIdGrupo = new System.Windows.Forms.ComboBox();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnInscribirClase = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ComboBox para IdGrupo
            this.cmbIdGrupo.FormattingEnabled = true;
            this.cmbIdGrupo.Location = new System.Drawing.Point(30, 30);
            this.cmbIdGrupo.Name = "cmbIdGrupo";
            this.cmbIdGrupo.Size = new System.Drawing.Size(200, 24);
            this.cmbIdGrupo.TabIndex = 0;

            // ComboBox para IdCliente
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(30, 70);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(200, 24);
            this.cmbIdCliente.TabIndex = 1;

            // DateTimePicker para FechaInicio
            this.dtpFechaInicio.Location = new System.Drawing.Point(30, 110);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaInicio.TabIndex = 2;

            // DateTimePicker para FechaFin
            this.dtpFechaFin.Location = new System.Drawing.Point(30, 150);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaFin.TabIndex = 3;

            // Botón para registrar inscripción en clase
            this.btnInscribirClase.Location = new System.Drawing.Point(30, 190);
            this.btnInscribirClase.Name = "btnInscribirClase";
            this.btnInscribirClase.Size = new System.Drawing.Size(200, 30);
            this.btnInscribirClase.TabIndex = 4;
            this.btnInscribirClase.Text = "Inscribir en Clase";
            this.btnInscribirClase.UseVisualStyleBackColor = true;
            this.btnInscribirClase.Click += new System.EventHandler(this.btnInscribirClase_Click);

            // Configuración del formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.cmbIdGrupo);
            this.Controls.Add(this.cmbIdCliente);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.btnInscribirClase);
            this.Name = "FormInscripcionClase";
            this.Text = "Inscripción en Clase Dirigida";
            this.ResumeLayout(false);
        }
    }
}
