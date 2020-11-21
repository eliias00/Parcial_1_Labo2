namespace Parcial_2_Troncoso_Elias_2D
{
    partial class frmPedidos
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
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.lViewPedidosLevantados = new System.Windows.Forms.ListView();
            this.lViewPedidosHechos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(196, 350);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(116, 30);
            this.btnAgregarPedido.TabIndex = 0;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.BtnAgregarPedido_Click);
            // 
            // lViewPedidosLevantados
            // 
            this.lViewPedidosLevantados.HideSelection = false;
            this.lViewPedidosLevantados.Location = new System.Drawing.Point(12, 12);
            this.lViewPedidosLevantados.Name = "lViewPedidosLevantados";
            this.lViewPedidosLevantados.Size = new System.Drawing.Size(516, 153);
            this.lViewPedidosLevantados.TabIndex = 3;
            this.lViewPedidosLevantados.UseCompatibleStateImageBehavior = false;
            // 
            // lViewPedidosHechos
            // 
            this.lViewPedidosHechos.HideSelection = false;
            this.lViewPedidosHechos.Location = new System.Drawing.Point(12, 181);
            this.lViewPedidosHechos.Name = "lViewPedidosHechos";
            this.lViewPedidosHechos.Size = new System.Drawing.Size(516, 153);
            this.lViewPedidosHechos.TabIndex = 4;
            this.lViewPedidosHechos.UseCompatibleStateImageBehavior = false;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(542, 392);
            this.Controls.Add(this.lViewPedidosHechos);
            this.Controls.Add(this.lViewPedidosLevantados);
            this.Controls.Add(this.btnAgregarPedido);
            this.Name = "frmPedidos";
            this.Text = "Pedidos Van";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPedidos_FormClosing);
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.ListView lViewPedidosLevantados;
        private System.Windows.Forms.ListView lViewPedidosHechos;
    }
}

