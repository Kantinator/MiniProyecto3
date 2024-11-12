using System.Collections.Generic;
using System;

namespace MiniProyecto3.vista
{
    partial class FormListadoClientes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnConsultar;

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
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPlan
            // 
            this.cmbPlan.Location = new System.Drawing.Point(57, 64);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(121, 24);
            this.cmbPlan.TabIndex = 0;
            // 
            // lstClientes
            // 
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(57, 105);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(120, 84);
            this.lstClientes.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(30, 250);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FormListadoClientes
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.cmbPlan);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnConsultar);
            this.Name = "FormListadoClientes";
            this.ResumeLayout(false);

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idPlan = Convert.ToInt32(cmbPlan.SelectedValue);
            List<Cliente> clientes = Cliente.ListarPorPlan(idPlan);
            lstClientes.DataSource = clientes;
            lstClientes.DisplayMember = "Nombre";
        }
    }
}