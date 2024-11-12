using System;

namespace MiniProyecto3.vista
{
    partial class FormPlan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown nudHorasSemanales;
        private System.Windows.Forms.NumericUpDown nudCostoMensual;
        private System.Windows.Forms.Button btnCrearPlan;

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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.nudHorasSemanales = new System.Windows.Forms.NumericUpDown();
            this.nudCostoMensual = new System.Windows.Forms.NumericUpDown();
            this.btnCrearPlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasSemanales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoMensual)).BeginInit();
            this.SuspendLayout();
            
            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(30, 30);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcion.TabIndex = 0;
            
            // nudHorasSemanales
            this.nudHorasSemanales.Location = new System.Drawing.Point(30, 70);
            this.nudHorasSemanales.Name = "nudHorasSemanales";
            this.nudHorasSemanales.Size = new System.Drawing.Size(120, 22);
            this.nudHorasSemanales.TabIndex = 1;

            // nudCostoMensual
            this.nudCostoMensual.Location = new System.Drawing.Point(30, 113);
            this.nudCostoMensual.Name = "nudCostoMensual";
            this.nudCostoMensual.Size = new System.Drawing.Size(120, 22);
            this.nudCostoMensual.TabIndex = 2;

            // btnCrearPlan 
            this.btnCrearPlan.Location = new System.Drawing.Point(30, 150);
            this.btnCrearPlan.Name = "btnCrearPlan";
            this.btnCrearPlan.Size = new System.Drawing.Size(75, 23);
            this.btnCrearPlan.TabIndex = 3;
            this.btnCrearPlan.Text = "Crear Plan";
            this.btnCrearPlan.Click += new System.EventHandler(this.btnCrearPlan_Click);

            // FormPlan
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.nudHorasSemanales);
            this.Controls.Add(this.nudCostoMensual);
            this.Controls.Add(this.btnCrearPlan);
            this.Name = "FormPlan";
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasSemanales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoMensual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCrearPlan_Click(object sender, EventArgs e)
        {
            PlanesInscripcion nuevoPlan = new PlanesInscripcion(txtDescripcion.Text, (int)nudHorasSemanales.Value, nudCostoMensual.Value);
            nuevoPlan.CrearPlan();
        }
    }
}