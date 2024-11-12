namespace MiniProyecto3.vista
{
    partial class frmParticipantesInscritos
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
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.btnParticipantes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Location = new System.Drawing.Point(24, 138);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.RowHeadersWidth = 47;
            this.dgvParticipantes.Size = new System.Drawing.Size(491, 150);
            this.dgvParticipantes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clase";
            // 
            // cmbClase
            // 
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(211, 41);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(121, 21);
            this.cmbClase.TabIndex = 2;
            this.cmbClase.SelectedIndexChanged += new System.EventHandler(this.cmbIdClase_SelectedIndexChanged);
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(359, 44);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(0, 13);
            this.lblClase.TabIndex = 3;
            // 
            // btnParticipantes
            // 
            this.btnParticipantes.Location = new System.Drawing.Point(196, 90);
            this.btnParticipantes.Name = "btnParticipantes";
            this.btnParticipantes.Size = new System.Drawing.Size(151, 23);
            this.btnParticipantes.TabIndex = 4;
            this.btnParticipantes.Text = "Listar participantes inscritos";
            this.btnParticipantes.UseVisualStyleBackColor = true;
            this.btnParticipantes.Click += new System.EventHandler(this.btnParticipantes_Click);
            // 
            // frmParticipantesInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 314);
            this.Controls.Add(this.btnParticipantes);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.cmbClase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvParticipantes);
            this.Name = "frmParticipantesInscritos";
            this.Text = "frnParticipantesInscritos";
            this.Load += new System.EventHandler(this.frnParticipantesInscritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbClase;
        public System.Windows.Forms.Label lblClase;
        public System.Windows.Forms.Button btnParticipantes;
        public System.Windows.Forms.DataGridView dgvParticipantes;
    }
}