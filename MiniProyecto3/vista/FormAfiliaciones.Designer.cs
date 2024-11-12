namespace MiniProyecto3.vista
{
    partial class FormAfiliaciones
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbIdPlan;
        private System.Windows.Forms.ComboBox cmbIdInstructor;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnCrearAfiliacion;

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
            this.cmbIdPlan = new System.Windows.Forms.ComboBox();
            this.cmbIdInstructor = new System.Windows.Forms.ComboBox();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnCrearAfiliacion = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ComboBox para IdPlan
            this.cmbIdPlan.FormattingEnabled = true;
            this.cmbIdPlan.Location = new System.Drawing.Point(30, 30);
            this.cmbIdPlan.Name = "cmbIdPlan";
            this.cmbIdPlan.Size = new System.Drawing.Size(200, 24);
            this.cmbIdPlan.TabIndex = 0;

            // ComboBox para IdInstructor
            this.cmbIdInstructor.FormattingEnabled = true;
            this.cmbIdInstructor.Location = new System.Drawing.Point(30, 70);
            this.cmbIdInstructor.Name = "cmbIdInstructor";
            this.cmbIdInstructor.Size = new System.Drawing.Size(200, 24);
            this.cmbIdInstructor.TabIndex = 1;

            // ComboBox para IdCliente
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(30, 110);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(200, 24);
            this.cmbIdCliente.TabIndex = 2;

            // DateTimePicker para FechaInicio
            this.dtpFechaInicio.Location = new System.Drawing.Point(30, 150);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaInicio.TabIndex = 3;

            // DateTimePicker para FechaFin
            this.dtpFechaFin.Location = new System.Drawing.Point(30, 190);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaFin.TabIndex = 4;

            // Botón para crear afiliación
            this.btnCrearAfiliacion.Location = new System.Drawing.Point(30, 230);
            this.btnCrearAfiliacion.Name = "btnCrearAfiliacion";
            this.btnCrearAfiliacion.Size = new System.Drawing.Size(200, 30);
            this.btnCrearAfiliacion.TabIndex = 5;
            this.btnCrearAfiliacion.Text = "Crear Afiliación";
            this.btnCrearAfiliacion.UseVisualStyleBackColor = true;
            this.btnCrearAfiliacion.Click += new System.EventHandler(this.btnCrearAfiliacion_Click);

            // Configuración del formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.cmbIdPlan);
            this.Controls.Add(this.cmbIdInstructor);
            this.Controls.Add(this.cmbIdCliente);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.btnCrearAfiliacion);
            this.Name = "FormAfiliaciones";
            this.Text = "Registrar Afiliación";
            this.ResumeLayout(false);
        }
    }
}
