namespace MiniProyecto3.vista
{
    partial class frmRegistroHorario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numParticipantes = new System.Windows.Forms.NumericUpDown();
            this.numIdGrupo = new System.Windows.Forms.NumericUpDown();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.btnRegistrarHorario = new System.Windows.Forms.Button();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id clase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia de semana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id instructor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Maxima cantidad de participantes:";
            // 
            // numParticipantes
            // 
            this.numParticipantes.Location = new System.Drawing.Point(252, 269);
            this.numParticipantes.Name = "numParticipantes";
            this.numParticipantes.Size = new System.Drawing.Size(120, 20);
            this.numParticipantes.TabIndex = 7;
            // 
            // numIdGrupo
            // 
            this.numIdGrupo.Location = new System.Drawing.Point(252, 101);
            this.numIdGrupo.Name = "numIdGrupo";
            this.numIdGrupo.Size = new System.Drawing.Size(120, 20);
            this.numIdGrupo.TabIndex = 8;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(252, 144);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 9;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(252, 188);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(200, 20);
            this.dtpHora.TabIndex = 10;
            // 
            // cmbClase
            // 
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(251, 61);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(121, 21);
            this.cmbClase.TabIndex = 11;
            this.cmbClase.SelectedIndexChanged += new System.EventHandler(this.cmbClase_SelectedIndexChanged);
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(251, 228);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(121, 21);
            this.cmbInstructor.TabIndex = 12;
            this.cmbInstructor.SelectedIndexChanged += new System.EventHandler(this.cmbInstructor_SelectedIndexChanged);
            // 
            // btnRegistrarHorario
            // 
            this.btnRegistrarHorario.Location = new System.Drawing.Point(216, 328);
            this.btnRegistrarHorario.Name = "btnRegistrarHorario";
            this.btnRegistrarHorario.Size = new System.Drawing.Size(101, 23);
            this.btnRegistrarHorario.TabIndex = 13;
            this.btnRegistrarHorario.Text = "Agregar horario";
            this.btnRegistrarHorario.UseVisualStyleBackColor = true;
            this.btnRegistrarHorario.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(397, 64);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(0, 13);
            this.lblClase.TabIndex = 14;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(397, 231);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(0, 13);
            this.lblInstructor.TabIndex = 15;
            // 
            // frmRegistroHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 382);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.btnRegistrarHorario);
            this.Controls.Add(this.cmbInstructor);
            this.Controls.Add(this.cmbClase);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.numIdGrupo);
            this.Controls.Add(this.numParticipantes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistroHorario";
            this.Text = "frmRegistroHorario";
            this.Load += new System.EventHandler(this.frmRegistroHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown numParticipantes;
        public System.Windows.Forms.NumericUpDown numIdGrupo;
        public System.Windows.Forms.TextBox txtDia;
        public System.Windows.Forms.DateTimePicker dtpHora;
        public System.Windows.Forms.ComboBox cmbClase;
        public System.Windows.Forms.ComboBox cmbInstructor;
        private System.Windows.Forms.Button btnRegistrarHorario;
        public System.Windows.Forms.Label lblClase;
        public System.Windows.Forms.Label lblInstructor;
    }
}