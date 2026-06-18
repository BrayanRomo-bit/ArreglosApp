namespace AplicacionArreglos
{
    partial class FormularioPrincipal
    {
        private System.ComponentModel.IContainer componentes = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (componentes != null))
            {
                componentes.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InicializarComponentes()
        {
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblEntradaMensaje = new System.Windows.Forms.Label();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txtAnalisisFrecuencia = new System.Windows.Forms.TextBox();
            
            this.txtLlave11 = new System.Windows.Forms.TextBox();
            this.txtLlave12 = new System.Windows.Forms.TextBox();
            this.txtLlave13 = new System.Windows.Forms.TextBox();
            this.txtLlave21 = new System.Windows.Forms.TextBox();
            this.txtLlave22 = new System.Windows.Forms.TextBox();
            this.txtLlave23 = new System.Windows.Forms.TextBox();
            this.txtLlave31 = new System.Windows.Forms.TextBox();
            this.txtLlave32 = new System.Windows.Forms.TextBox();
            this.txtLlave33 = new System.Windows.Forms.TextBox();
            
            this.lblEntradaLlave = new System.Windows.Forms.Label();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.lblResultadoDeterminante = new System.Windows.Forms.Label();
            
            this.lblMensajeEncriptado = new System.Windows.Forms.Label();
            this.txtMensajeEncriptado = new System.Windows.Forms.TextBox();
            
            this.SuspendLayout();
            
            // txtMensaje
            this.txtMensaje.Location = new System.Drawing.Point(30, 50);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(200, 23);
            
            // lblEntradaMensaje
            this.lblEntradaMensaje.AutoSize = true;
            this.lblEntradaMensaje.Location = new System.Drawing.Point(30, 20);
            this.lblEntradaMensaje.Name = "lblEntradaMensaje";
            this.lblEntradaMensaje.Text = "Mensaje a encriptar:";
            
            // btnAnalizar
            this.btnAnalizar.Location = new System.Drawing.Point(30, 80);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(150, 30);
            this.btnAnalizar.Text = "Análisis de Frecuencia";
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            
            // txtAnalisisFrecuencia
            this.txtAnalisisFrecuencia.Location = new System.Drawing.Point(30, 120);
            this.txtAnalisisFrecuencia.Name = "txtAnalisisFrecuencia";
            this.txtAnalisisFrecuencia.ReadOnly = true;
            this.txtAnalisisFrecuencia.Size = new System.Drawing.Size(200, 23);
            
            // lblMensajeEncriptado
            this.lblMensajeEncriptado.AutoSize = true;
            this.lblMensajeEncriptado.Location = new System.Drawing.Point(30, 160);
            this.lblMensajeEncriptado.Name = "lblMensajeEncriptado";
            this.lblMensajeEncriptado.Text = "Mensaje Encriptado Final:";
            
            // txtMensajeEncriptado
            this.txtMensajeEncriptado.Location = new System.Drawing.Point(30, 190);
            this.txtMensajeEncriptado.Name = "txtMensajeEncriptado";
            this.txtMensajeEncriptado.ReadOnly = true;
            this.txtMensajeEncriptado.Size = new System.Drawing.Size(200, 23);
            
            // lblEntradaLlave
            this.lblEntradaLlave.AutoSize = true;
            this.lblEntradaLlave.Location = new System.Drawing.Point(300, 20);
            this.lblEntradaLlave.Name = "lblEntradaLlave";
            this.lblEntradaLlave.Text = "Matriz Llave (Ingresa 9 números):";

            // Matrix TextBoxes
            int inicioX = 300, inicioY = 50, espaciado = 40;
            
            this.txtLlave11.Location = new System.Drawing.Point(inicioX, inicioY);
            this.txtLlave11.Size = new System.Drawing.Size(30, 23);
            this.txtLlave12.Location = new System.Drawing.Point(inicioX + espaciado, inicioY);
            this.txtLlave12.Size = new System.Drawing.Size(30, 23);
            this.txtLlave13.Location = new System.Drawing.Point(inicioX + espaciado * 2, inicioY);
            this.txtLlave13.Size = new System.Drawing.Size(30, 23);
            
            this.txtLlave21.Location = new System.Drawing.Point(inicioX, inicioY + espaciado);
            this.txtLlave21.Size = new System.Drawing.Size(30, 23);
            this.txtLlave22.Location = new System.Drawing.Point(inicioX + espaciado, inicioY + espaciado);
            this.txtLlave22.Size = new System.Drawing.Size(30, 23);
            this.txtLlave23.Location = new System.Drawing.Point(inicioX + espaciado * 2, inicioY + espaciado);
            this.txtLlave23.Size = new System.Drawing.Size(30, 23);
            
            this.txtLlave31.Location = new System.Drawing.Point(inicioX, inicioY + espaciado * 2);
            this.txtLlave31.Size = new System.Drawing.Size(30, 23);
            this.txtLlave32.Location = new System.Drawing.Point(inicioX + espaciado, inicioY + espaciado * 2);
            this.txtLlave32.Size = new System.Drawing.Size(30, 23);
            this.txtLlave33.Location = new System.Drawing.Point(inicioX + espaciado * 2, inicioY + espaciado * 2);
            this.txtLlave33.Size = new System.Drawing.Size(30, 23);
            
            // btnEncriptar
            this.btnEncriptar.Location = new System.Drawing.Point(300, 180);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(150, 30);
            this.btnEncriptar.Text = "Validar Llave y Encriptar";
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            
            // lblResultadoDeterminante
            this.lblResultadoDeterminante.AutoSize = true;
            this.lblResultadoDeterminante.Location = new System.Drawing.Point(300, 220);
            this.lblResultadoDeterminante.Name = "lblResultadoDeterminante";
            this.lblResultadoDeterminante.Text = "Determinante: ";

            // FormularioPrincipal
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblEntradaMensaje);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.txtAnalisisFrecuencia);
            this.Controls.Add(this.lblMensajeEncriptado);
            this.Controls.Add(this.txtMensajeEncriptado);
            this.Controls.Add(this.lblEntradaLlave);
            this.Controls.Add(this.txtLlave11);
            this.Controls.Add(this.txtLlave12);
            this.Controls.Add(this.txtLlave13);
            this.Controls.Add(this.txtLlave21);
            this.Controls.Add(this.txtLlave22);
            this.Controls.Add(this.txtLlave23);
            this.Controls.Add(this.txtLlave31);
            this.Controls.Add(this.txtLlave32);
            this.Controls.Add(this.txtLlave33);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.lblResultadoDeterminante);
            this.Name = "FormularioPrincipal";
            this.Text = "Sistema de Encriptación de Datos - Cifrado Hill";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblEntradaMensaje;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox txtAnalisisFrecuencia;
        
        private System.Windows.Forms.TextBox txtLlave11;
        private System.Windows.Forms.TextBox txtLlave12;
        private System.Windows.Forms.TextBox txtLlave13;
        private System.Windows.Forms.TextBox txtLlave21;
        private System.Windows.Forms.TextBox txtLlave22;
        private System.Windows.Forms.TextBox txtLlave23;
        private System.Windows.Forms.TextBox txtLlave31;
        private System.Windows.Forms.TextBox txtLlave32;
        private System.Windows.Forms.TextBox txtLlave33;
        
        private System.Windows.Forms.Label lblEntradaLlave;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Label lblResultadoDeterminante;
        
        private System.Windows.Forms.Label lblMensajeEncriptado;
        private System.Windows.Forms.TextBox txtMensajeEncriptado;
    }
}
