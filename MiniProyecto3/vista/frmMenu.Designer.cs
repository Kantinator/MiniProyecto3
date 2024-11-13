namespace MiniProyecto3.vista
{
    partial class frmMenu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planDeInscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beneficioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiliacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionAClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesInscritosEnUnaClaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesPorPlanDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesQueTrabajonConUnInstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesConSuscripcionActivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 27);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructorToolStripMenuItem,
            this.planDeInscripcionToolStripMenuItem,
            this.beneficioToolStripMenuItem,
            this.clasesToolStripMenuItem,
            this.hToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.afiliacionToolStripMenuItem,
            this.inscripcionAClasesToolStripMenuItem});
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantesInscritosEnUnaClaseToolStripMenuItem,
            this.clientesPorPlanDeToolStripMenuItem,
            this.clientesQueTrabajonConUnInstructorToolStripMenuItem,
            this.detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem,
            this.clientesConSuscripcionActivaToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // instructorToolStripMenuItem
            // 
            this.instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            this.instructorToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.instructorToolStripMenuItem.Text = "Instructores";
            this.instructorToolStripMenuItem.Click += new System.EventHandler(this.instructorToolStripMenuItem_Click);
            // 
            // planDeInscripcionToolStripMenuItem
            // 
            this.planDeInscripcionToolStripMenuItem.Name = "planDeInscripcionToolStripMenuItem";
            this.planDeInscripcionToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.planDeInscripcionToolStripMenuItem.Text = "Planes de inscripcion";
            this.planDeInscripcionToolStripMenuItem.Click += new System.EventHandler(this.planDeInscripcionToolStripMenuItem_Click);
            // 
            // beneficioToolStripMenuItem
            // 
            this.beneficioToolStripMenuItem.Name = "beneficioToolStripMenuItem";
            this.beneficioToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.beneficioToolStripMenuItem.Text = "Beneficios";
            this.beneficioToolStripMenuItem.Click += new System.EventHandler(this.beneficioToolStripMenuItem_Click);
            // 
            // clasesToolStripMenuItem
            // 
            this.clasesToolStripMenuItem.Name = "clasesToolStripMenuItem";
            this.clasesToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.clasesToolStripMenuItem.Text = "Clases";
            this.clasesToolStripMenuItem.Click += new System.EventHandler(this.clasesToolStripMenuItem_Click);
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.hToolStripMenuItem.Text = "Horario de clases";
            this.hToolStripMenuItem.Click += new System.EventHandler(this.hToolStripMenuItem_Click);
            // 
            // afiliacionToolStripMenuItem
            // 
            this.afiliacionToolStripMenuItem.Name = "afiliacionToolStripMenuItem";
            this.afiliacionToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.afiliacionToolStripMenuItem.Text = "Afiliacion";
            this.afiliacionToolStripMenuItem.Click += new System.EventHandler(this.afiliacionToolStripMenuItem_Click);
            // 
            // inscripcionAClasesToolStripMenuItem
            // 
            this.inscripcionAClasesToolStripMenuItem.Name = "inscripcionAClasesToolStripMenuItem";
            this.inscripcionAClasesToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.inscripcionAClasesToolStripMenuItem.Text = "Inscripcion a clases";
            this.inscripcionAClasesToolStripMenuItem.Click += new System.EventHandler(this.inscripcionAClasesToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // participantesInscritosEnUnaClaseToolStripMenuItem
            // 
            this.participantesInscritosEnUnaClaseToolStripMenuItem.Name = "participantesInscritosEnUnaClaseToolStripMenuItem";
            this.participantesInscritosEnUnaClaseToolStripMenuItem.Size = new System.Drawing.Size(324, 24);
            this.participantesInscritosEnUnaClaseToolStripMenuItem.Text = "Participantes inscritos en una clase";
            this.participantesInscritosEnUnaClaseToolStripMenuItem.Click += new System.EventHandler(this.participantesInscritosEnUnaClaseToolStripMenuItem_Click);
            // 
            // clientesPorPlanDeToolStripMenuItem
            // 
            this.clientesPorPlanDeToolStripMenuItem.Name = "clientesPorPlanDeToolStripMenuItem";
            this.clientesPorPlanDeToolStripMenuItem.Size = new System.Drawing.Size(324, 24);
            this.clientesPorPlanDeToolStripMenuItem.Text = "Clientes por plan de afiliacion";
            this.clientesPorPlanDeToolStripMenuItem.Click += new System.EventHandler(this.clientesPorPlanDeToolStripMenuItem_Click);
            // 
            // clientesQueTrabajonConUnInstructorToolStripMenuItem
            // 
            this.clientesQueTrabajonConUnInstructorToolStripMenuItem.Name = "clientesQueTrabajonConUnInstructorToolStripMenuItem";
            this.clientesQueTrabajonConUnInstructorToolStripMenuItem.Size = new System.Drawing.Size(324, 24);
            this.clientesQueTrabajonConUnInstructorToolStripMenuItem.Text = "Clientes que trabajan con un instructor";
            this.clientesQueTrabajonConUnInstructorToolStripMenuItem.Click += new System.EventHandler(this.clientesQueTrabajonConUnInstructorToolStripMenuItem_Click);
            // 
            // detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem
            // 
            this.detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem.Name = "detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem";
            this.detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem.Size = new System.Drawing.Size(324, 24);
            this.detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem.Text = "Detalles de afiliaciones por tipo de plan";
            this.detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem.Click += new System.EventHandler(this.detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem_Click);
            // 
            // clientesConSuscripcionActivaToolStripMenuItem
            // 
            this.clientesConSuscripcionActivaToolStripMenuItem.Name = "clientesConSuscripcionActivaToolStripMenuItem";
            this.clientesConSuscripcionActivaToolStripMenuItem.Size = new System.Drawing.Size(324, 24);
            this.clientesConSuscripcionActivaToolStripMenuItem.Text = "Clientes con suscripcion activa";
            this.clientesConSuscripcionActivaToolStripMenuItem.Click += new System.EventHandler(this.clientesConSuscripcionActivaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 267);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido al Sistema de Gestion de Gimnasio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planDeInscripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beneficioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiliacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionAClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesInscritosEnUnaClaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesPorPlanDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesQueTrabajonConUnInstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesDeAfiliacionesPorTipoDePlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesConSuscripcionActivaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}