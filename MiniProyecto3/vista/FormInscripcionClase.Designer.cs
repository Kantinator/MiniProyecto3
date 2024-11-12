namespace MiniProyecto3.vista
{
    partial class FormInscripcionClase
    {
        private System.ComponentModel.IContainer components = null;
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbIdGrupo
            // 
            this.cmbIdGrupo.FormattingEnabled = true;
            this.cmbIdGrupo.Location = new System.Drawing.Point(143, 29);
            this.cmbIdGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIdGrupo.Name = "cmbIdGrupo";
            this.cmbIdGrupo.Size = new System.Drawing.Size(151, 21);
            this.cmbIdGrupo.TabIndex = 0;
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(143, 62);
            this.cmbIdCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(151, 21);
            this.cmbIdCliente.TabIndex = 1;
            this.cmbIdCliente.SelectedIndexChanged += new System.EventHandler(this.cmbIdCliente_SelectedIndexChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(143, 94);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaInicio.TabIndex = 2;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(143, 127);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaFin.TabIndex = 3;
            // 
            // btnInscribirClase
            // 
            this.btnInscribirClase.Location = new System.Drawing.Point(143, 159);
            this.btnInscribirClase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInscribirClase.Name = "btnInscribirClase";
            this.btnInscribirClase.Size = new System.Drawing.Size(150, 24);
            this.btnInscribirClase.TabIndex = 4;
            this.btnInscribirClase.Text = "Inscribir en Clase";
            this.btnInscribirClase.UseVisualStyleBackColor = true;
            this.btnInscribirClase.Click += new System.EventHandler(this.btnInscribirClase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de finalizacion:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(310, 65);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 13);
            this.lblCliente.TabIndex = 9;
            // 
            // FormInscripcionClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 231);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdGrupo);
            this.Controls.Add(this.cmbIdCliente);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.btnInscribirClase);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormInscripcionClase";
            this.Text = "Inscripción en Clase Dirigida";
            this.Load += new System.EventHandler(this.FormInscripcionClase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.ComboBox cmbIdGrupo;
        public System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblCliente;
    }
}
