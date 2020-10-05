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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Compras));
            this.lbl_Compra_Empleado = new System.Windows.Forms.Label();
            this.lbl_Nombre_Empleado = new System.Windows.Forms.Label();
            this.dGV_Stock_Prod_Comp = new System.Windows.Forms.DataGridView();
            this.productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Prod_Comp = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.pBox_Compras = new System.Windows.Forms.PictureBox();
            this.iBtn_Descarga_Arch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Stock_Prod_Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Prod_Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Compra_Empleado
            // 
            this.lbl_Compra_Empleado.AutoSize = true;
            this.lbl_Compra_Empleado.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compra_Empleado.Location = new System.Drawing.Point(645, 23);
            this.lbl_Compra_Empleado.Name = "lbl_Compra_Empleado";
            this.lbl_Compra_Empleado.Size = new System.Drawing.Size(108, 26);
            this.lbl_Compra_Empleado.TabIndex = 0;
            this.lbl_Compra_Empleado.Text = "Empleado:";
            // 
            // lbl_Nombre_Empleado
            // 
            this.lbl_Nombre_Empleado.AutoSize = true;
            this.lbl_Nombre_Empleado.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_Empleado.Location = new System.Drawing.Point(645, 49);
            this.lbl_Nombre_Empleado.Name = "lbl_Nombre_Empleado";
            this.lbl_Nombre_Empleado.Size = new System.Drawing.Size(0, 26);
            this.lbl_Nombre_Empleado.TabIndex = 1;
            // 
            // dGV_Stock_Prod_Comp
            // 
            this.dGV_Stock_Prod_Comp.AllowUserToAddRows = false;
            this.dGV_Stock_Prod_Comp.AllowUserToDeleteRows = false;
            this.dGV_Stock_Prod_Comp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Stock_Prod_Comp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Stock_Prod_Comp.BackgroundColor = System.Drawing.Color.White;
            this.dGV_Stock_Prod_Comp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_Stock_Prod_Comp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGV_Stock_Prod_Comp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Stock_Prod_Comp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Stock_Prod_Comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Stock_Prod_Comp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productos,
            this.idProducto,
            this.Precio,
            this.Stock});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Stock_Prod_Comp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Stock_Prod_Comp.GridColor = System.Drawing.Color.White;
            this.dGV_Stock_Prod_Comp.Location = new System.Drawing.Point(12, 320);
            this.dGV_Stock_Prod_Comp.Name = "dGV_Stock_Prod_Comp";
            this.dGV_Stock_Prod_Comp.ReadOnly = true;
            this.dGV_Stock_Prod_Comp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGV_Stock_Prod_Comp.RowHeadersVisible = false;
            this.dGV_Stock_Prod_Comp.Size = new System.Drawing.Size(385, 150);
            this.dGV_Stock_Prod_Comp.TabIndex = 2;
            this.dGV_Stock_Prod_Comp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DGV_Stock_Prod_Comp_MouseDown);
            // 
            // productos
            // 
            this.productos.HeaderText = "Productos";
            this.productos.Name = "productos";
            this.productos.ReadOnly = true;
            this.productos.Width = 95;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 99;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 71;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 68;
            // 
            // dGV_Prod_Comp
            // 
            this.dGV_Prod_Comp.AllowUserToAddRows = false;
            this.dGV_Prod_Comp.AllowUserToDeleteRows = false;
            this.dGV_Prod_Comp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Prod_Comp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Prod_Comp.BackgroundColor = System.Drawing.Color.White;
            this.dGV_Prod_Comp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Prod_Comp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Prod_Comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Prod_Comp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.StockUni});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Prod_Comp.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_Prod_Comp.GridColor = System.Drawing.Color.White;
            this.dGV_Prod_Comp.Location = new System.Drawing.Point(421, 320);
            this.dGV_Prod_Comp.Name = "dGV_Prod_Comp";
            this.dGV_Prod_Comp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGV_Prod_Comp.RowHeadersVisible = false;
            this.dGV_Prod_Comp.Size = new System.Drawing.Size(218, 150);
            this.dGV_Prod_Comp.TabIndex = 3;
            this.dGV_Prod_Comp.DragDrop += new System.Windows.Forms.DragEventHandler(this.DGV_Prod_Comp_DragDrop);
            this.dGV_Prod_Comp.DragOver += new System.Windows.Forms.DragEventHandler(this.DGV_Prod_Comp_DragOver);
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.Width = 88;
            // 
            // StockUni
            // 
            this.StockUni.HeaderText = "Unidades a comprar";
            this.StockUni.Name = "StockUni";
            this.StockUni.Width = 98;
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Comprar.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comprar.ForeColor = System.Drawing.Color.Black;
            this.btn_Comprar.Location = new System.Drawing.Point(717, 397);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(126, 43);
            this.btn_Comprar.TabIndex = 4;
            this.btn_Comprar.Text = "Comprar";
            this.btn_Comprar.UseVisualStyleBackColor = false;
            this.btn_Comprar.Click += new System.EventHandler(this.Btn_Comprar_Click_1);
            // 
            // pBox_Compras
            // 
            this.pBox_Compras.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Compras.Image")));
            this.pBox_Compras.Location = new System.Drawing.Point(-2, -2);
            this.pBox_Compras.Name = "pBox_Compras";
            this.pBox_Compras.Size = new System.Drawing.Size(641, 482);
            this.pBox_Compras.TabIndex = 5;
            this.pBox_Compras.TabStop = false;
            // 
            // iBtn_Descarga_Arch
            // 
            this.iBtn_Descarga_Arch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_Descarga_Arch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtn_Descarga_Arch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iBtn_Descarga_Arch.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iBtn_Descarga_Arch.IconColor = System.Drawing.Color.Black;
            this.iBtn_Descarga_Arch.IconSize = 52;
            this.iBtn_Descarga_Arch.Location = new System.Drawing.Point(826, 267);
            this.iBtn_Descarga_Arch.Name = "iBtn_Descarga_Arch";
            this.iBtn_Descarga_Arch.Rotation = 0D;
            this.iBtn_Descarga_Arch.Size = new System.Drawing.Size(75, 86);
            this.iBtn_Descarga_Arch.TabIndex = 6;
            this.iBtn_Descarga_Arch.UseVisualStyleBackColor = true;
            this.iBtn_Descarga_Arch.Click += new System.EventHandler(this.IBtn_Descarga_Arch_Click);
            // 
            // frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(913, 482);
            this.Controls.Add(this.iBtn_Descarga_Arch);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.dGV_Prod_Comp);
            this.Controls.Add(this.dGV_Stock_Prod_Comp);
            this.Controls.Add(this.lbl_Nombre_Empleado);
            this.Controls.Add(this.lbl_Compra_Empleado);
            this.Controls.Add(this.pBox_Compras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Compras_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Stock_Prod_Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Prod_Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Compras)).EndInit();
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
        private System.Windows.Forms.PictureBox pBox_Compras;
        private FontAwesome.Sharp.IconButton iBtn_Descarga_Arch;
    }
}