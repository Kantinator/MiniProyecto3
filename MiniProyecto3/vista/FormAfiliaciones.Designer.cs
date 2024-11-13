namespace MiniProyecto3.vista
{
    partial class FormAfiliaciones
    {
        private System.ComponentModel.IContainer components = null;
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
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbIdPlan
            // 
            this.cmbIdPlan.FormattingEnabled = true;
            this.cmbIdPlan.Location = new System.Drawing.Point(136, 21);
            this.cmbIdPlan.Name = "cmbIdPlan";
            this.cmbIdPlan.Size = new System.Drawing.Size(151, 21);
            this.cmbIdPlan.TabIndex = 0;
            this.cmbIdPlan.SelectedIndexChanged += new System.EventHandler(this.cmbIdPlan_SelectedIndexChanged);
            // 
            // cmbIdInstructor
            // 
            this.cmbIdInstructor.FormattingEnabled = true;
            this.cmbIdInstructor.Location = new System.Drawing.Point(136, 54);
            this.cmbIdInstructor.Name = "cmbIdInstructor";
            this.cmbIdInstructor.Size = new System.Drawing.Size(151, 21);
            this.cmbIdInstructor.TabIndex = 1;
            this.cmbIdInstructor.SelectedIndexChanged += new System.EventHandler(this.cmbIdInstructor_SelectedIndexChanged);
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(136, 86);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(151, 21);
            this.cmbIdCliente.TabIndex = 2;
            this.cmbIdCliente.SelectedIndexChanged += new System.EventHandler(this.cmbIdCliente_SelectedIndexChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(136, 119);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(136, 151);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaFin.TabIndex = 4;
            // 
            // btnCrearAfiliacion
            // 
            this.btnCrearAfiliacion.Location = new System.Drawing.Point(136, 184);
            this.btnCrearAfiliacion.Name = "btnCrearAfiliacion";
            this.btnCrearAfiliacion.Size = new System.Drawing.Size(150, 24);
            this.btnCrearAfiliacion.TabIndex = 5;
            this.btnCrearAfiliacion.Text = "Crear Afiliación";
            this.btnCrearAfiliacion.UseVisualStyleBackColor = true;
            this.btnCrearAfiliacion.Click += new System.EventHandler(this.btnCrearAfiliacion_Click);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(313, 28);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(0, 13);
            this.lblPlan.TabIndex = 6;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(313, 62);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(0, 13);
            this.lblInstructor.TabIndex = 7;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(313, 89);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 13);
            this.lblCliente.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Instructor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha de inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de finalizacion:";
            // 
            // FormAfiliaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 231);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.cmbIdPlan);
            this.Controls.Add(this.cmbIdInstructor);
            this.Controls.Add(this.cmbIdCliente);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.btnCrearAfiliacion);
            this.Name = "FormAfiliaciones";
            this.Text = "Registrar Afiliación";
            this.Load += new System.EventHandler(this.FormAfiliaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public System.Windows.Forms.ComboBox cmbIdPlan;
        public System.Windows.Forms.ComboBox cmbIdInstructor;
        public System.Windows.Forms.ComboBox cmbIdCliente;
        public System.Windows.Forms.DateTimePicker dtpFechaInicio;
        public System.Windows.Forms.DateTimePicker dtpFechaFin;
        public System.Windows.Forms.Label lblPlan;
        public System.Windows.Forms.Label lblInstructor;
        public System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
