namespace Proyecto_Ahora_sisi
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerPedido = new System.Windows.Forms.Button();
            this.btnCrearCarta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerPedido
            // 
            this.btnVerPedido.Location = new System.Drawing.Point(12, 12);
            this.btnVerPedido.Name = "btnVerPedido";
            this.btnVerPedido.Size = new System.Drawing.Size(148, 95);
            this.btnVerPedido.TabIndex = 1;
            this.btnVerPedido.Text = "Pedidos";
            this.btnVerPedido.UseVisualStyleBackColor = true;
            this.btnVerPedido.Click += new System.EventHandler(this.btnVerPedido_Click);
            // 
            // btnCrearCarta
            // 
            this.btnCrearCarta.Location = new System.Drawing.Point(166, 12);
            this.btnCrearCarta.Name = "btnCrearCarta";
            this.btnCrearCarta.Size = new System.Drawing.Size(148, 95);
            this.btnCrearCarta.TabIndex = 2;
            this.btnCrearCarta.Text = "Crear Carta";
            this.btnCrearCarta.UseVisualStyleBackColor = true;
            this.btnCrearCarta.Click += new System.EventHandler(this.btnCrearCarta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 113);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(302, 95);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 226);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearCarta);
            this.Controls.Add(this.btnVerPedido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVerPedido;
        private System.Windows.Forms.Button btnCrearCarta;
        private System.Windows.Forms.Button btnSalir;
    }
}

