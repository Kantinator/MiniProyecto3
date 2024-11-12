using System;

namespace MiniProyecto3.vista
{
    partial class FormBeneficio
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDescripcionBeneficio;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.Button btnAsignarBeneficio;

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
            this.txtDescripcionBeneficio = new System.Windows.Forms.TextBox();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.btnAsignarBeneficio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescripcionBeneficio
            // 
            this.txtDescripcionBeneficio.Location = new System.Drawing.Point(125, 130);
            this.txtDescripcionBeneficio.Name = "txtDescripcionBeneficio";
            this.txtDescripcionBeneficio.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcionBeneficio.TabIndex = 0;
            this.txtDescripcionBeneficio.Text = "Beneficio";
            this.txtDescripcionBeneficio.TextChanged += new System.EventHandler(this.txtDescripcionBeneficio_TextChanged);
            // 
            // cmbPlan
            // 
            this.cmbPlan.Location = new System.Drawing.Point(125, 167);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(121, 24);
            this.cmbPlan.TabIndex = 1;
            // 
            // btnAsignarBeneficio
            // 
            this.btnAsignarBeneficio.Location = new System.Drawing.Point(147, 207);
            this.btnAsignarBeneficio.Name = "btnAsignarBeneficio";
            this.btnAsignarBeneficio.Size = new System.Drawing.Size(75, 23);
            this.btnAsignarBeneficio.TabIndex = 2;
            this.btnAsignarBeneficio.Text = "Asignar Beneficio";
            this.btnAsignarBeneficio.Click += new System.EventHandler(this.btnAsignarBeneficio_Click);
            // 
            // FormBeneficio
            // 
            this.ClientSize = new System.Drawing.Size(411, 307);
            this.Controls.Add(this.txtDescripcionBeneficio);
            this.Controls.Add(this.cmbPlan);
            this.Controls.Add(this.btnAsignarBeneficio);
            this.Name = "FormBeneficio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAsignarBeneficio_Click(object sender, EventArgs e)
        {
            int idPlan = Convert.ToInt32(cmbPlan.SelectedValue);
            Beneficio nuevoBeneficio = new Beneficio(txtDescripcionBeneficio.Text, idPlan);
            nuevoBeneficio.CrearBeneficio();
        }
    }
}