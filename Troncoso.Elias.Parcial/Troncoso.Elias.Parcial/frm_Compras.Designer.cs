namespace Troncoso.Elias.Parcial
{
    partial class frm_Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Compra_Empleado = new System.Windows.Forms.Label();
            this.lbl_Nombre_Empleado = new System.Windows.Forms.Label();
            this.dGV_Stock_Prod_Comp = new System.Windows.Forms.DataGridView();
            this.dGV_Prod_Comp = new System.Windows.Forms.DataGridView();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Stock_Prod_Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Prod_Comp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Compra_Empleado
            // 
            this.lbl_Compra_Empleado.AutoSize = true;
            this.lbl_Compra_Empleado.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compra_Empleado.Location = new System.Drawing.Point(21, 19);
            this.lbl_Compra_Empleado.Name = "lbl_Compra_Empleado";
            this.lbl_Compra_Empleado.Size = new System.Drawing.Size(73, 16);
            this.lbl_Compra_Empleado.TabIndex = 0;
            this.lbl_Compra_Empleado.Text = "Empleado:";
            // 
            // lbl_Nombre_Empleado
            // 
            this.lbl_Nombre_Empleado.AutoSize = true;
            this.lbl_Nombre_Empleado.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_Empleado.Location = new System.Drawing.Point(112, 19);
            this.lbl_Nombre_Empleado.Name = "lbl_Nombre_Empleado";
            this.lbl_Nombre_Empleado.Size = new System.Drawing.Size(0, 16);
            this.lbl_Nombre_Empleado.TabIndex = 1;
            // 
            // dGV_Stock_Prod_Comp
            // 
            this.dGV_Stock_Prod_Comp.AllowUserToAddRows = false;
            this.dGV_Stock_Prod_Comp.AllowUserToDeleteRows = false;
            this.dGV_Stock_Prod_Comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Stock_Prod_Comp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productos,
            this.idProducto,
            this.Precio,
            this.Stock});
            this.dGV_Stock_Prod_Comp.Location = new System.Drawing.Point(12, 65);
            this.dGV_Stock_Prod_Comp.Name = "dGV_Stock_Prod_Comp";
            this.dGV_Stock_Prod_Comp.ReadOnly = true;
            this.dGV_Stock_Prod_Comp.Size = new System.Drawing.Size(430, 150);
            this.dGV_Stock_Prod_Comp.TabIndex = 2;
            this.dGV_Stock_Prod_Comp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Stock_Prod_Comp_CellContentClick);
            this.dGV_Stock_Prod_Comp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DGV_Stock_Prod_Comp_MouseDown);
            // 
            // dGV_Prod_Comp
            // 
            this.dGV_Prod_Comp.AllowUserToAddRows = false;
            this.dGV_Prod_Comp.AllowUserToDeleteRows = false;
            this.dGV_Prod_Comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Prod_Comp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.StockUni});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Prod_Comp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Prod_Comp.Location = new System.Drawing.Point(12, 231);
            this.dGV_Prod_Comp.Name = "dGV_Prod_Comp";
            this.dGV_Prod_Comp.Size = new System.Drawing.Size(244, 150);
            this.dGV_Prod_Comp.TabIndex = 3;
            this.dGV_Prod_Comp.DragDrop += new System.Windows.Forms.DragEventHandler(this.DGV_Prod_Comp_DragDrop);
            this.dGV_Prod_Comp.DragOver += new System.Windows.Forms.DragEventHandler(this.DGV_Prod_Comp_DragOver);
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Comprar.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comprar.ForeColor = System.Drawing.Color.Black;
            this.btn_Comprar.Location = new System.Drawing.Point(316, 321);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(126, 43);
            this.btn_Comprar.TabIndex = 4;
            this.btn_Comprar.Text = "Comprar";
            this.btn_Comprar.UseVisualStyleBackColor = false;
            this.btn_Comprar.Click += new System.EventHandler(this.Btn_Comprar_Click_1);
            // 
            // productos
            // 
            this.productos.HeaderText = "Productos";
            this.productos.Name = "productos";
            this.productos.ReadOnly = true;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // StockUni
            // 
            this.StockUni.HeaderText = "Unidades a comprar";
            this.StockUni.Name = "StockUni";
            // 
            // frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 401);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.dGV_Prod_Comp);
            this.Controls.Add(this.dGV_Stock_Prod_Comp);
            this.Controls.Add(this.lbl_Nombre_Empleado);
            this.Controls.Add(this.lbl_Compra_Empleado);
            this.Name = "frm_Compras";
            this.Text = "frm_Compras";
            this.Load += new System.EventHandler(this.Frm_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Stock_Prod_Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Prod_Comp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Compra_Empleado;
        private System.Windows.Forms.Label lbl_Nombre_Empleado;
        private System.Windows.Forms.DataGridView dGV_Stock_Prod_Comp;
        private System.Windows.Forms.DataGridView dGV_Prod_Comp;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockUni;
    }
}