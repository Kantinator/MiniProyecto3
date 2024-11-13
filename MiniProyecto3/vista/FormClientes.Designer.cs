namespace MiniProyecto3 
{
    partial class FormClientes
    {
        private System.ComponentModel.IContainer components = null;

        // Controles del formulario
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCelular;

        // Método que se invoca cuando se inicializa el formulario
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();

            // Configuración de los controles
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Text = "Nombre:";

            this.txtNombre.Location = new System.Drawing.Point(100, 20);

            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(20, 60);
            this.lblCorreo.Text = "Correo:";

            this.txtCorreo.Location = new System.Drawing.Point(100, 60);

            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(20, 100);
            this.lblCelular.Text = "Celular:";

            this.txtCelular.Location = new System.Drawing.Point(100, 100);

            this.btnCrearCliente.Location = new System.Drawing.Point(100, 140);
            this.btnCrearCliente.Text = "Crear Cliente";
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);

            // Configuración del formulario
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.btnCrearCliente);
            this.Text = "Agregar Cliente";
        }

        // Método para limpiar los recursos cuando el formulario se cierre
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
