namespace Troncoso.Elias.Parcial
{
    partial class frm_Stock
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
            this.lbl_Stock_Titulo = new System.Windows.Forms.Label();
            this.iBtn_Stock = new FontAwesome.Sharp.IconButton();
            this.lbl_Agregar_Prod = new System.Windows.Forms.Label();
            this.dGViewStock = new System.Windows.Forms.DataGridView();
            this.iBtn_Remove = new FontAwesome.Sharp.IconButton();
            this.lbl_Eliminar_Prod = new System.Windows.Forms.Label();
            this.iBtn_Modif_Prod = new FontAwesome.Sharp.IconButton();
            this.lbl_Modif_Prod = new System.Windows.Forms.Label();
            this.iBtn_Cliente_Agregar = new FontAwesome.Sharp.IconButton();
            this.lbl_Agregar_Empleado = new System.Windows.Forms.Label();
            this.iBtn_Refrescar = new FontAwesome.Sharp.IconButton();
            this.lbl_Refrescar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Stock_Titulo
            // 
            this.lbl_Stock_Titulo.AutoSize = true;
            this.lbl_Stock_Titulo.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Titulo.Location = new System.Drawing.Point(219, 30);
            this.lbl_Stock_Titulo.Name = "lbl_Stock_Titulo";
            this.lbl_Stock_Titulo.Size = new System.Drawing.Size(142, 60);
            this.lbl_Stock_Titulo.TabIndex = 1;
            this.lbl_Stock_Titulo.Text = "Stock";
            // 
            // iBtn_Stock
            // 
            this.iBtn_Stock.FlatAppearance.BorderSize = 0;
            this.iBtn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_Stock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtn_Stock.ForeColor = System.Drawing.Color.Black;
            this.iBtn_Stock.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iBtn_Stock.IconColor = System.Drawing.Color.Black;
            this.iBtn_Stock.IconSize = 52;
            this.iBtn_Stock.Location = new System.Drawing.Point(15, 347);
            this.iBtn_Stock.Name = "iBtn_Stock";
            this.iBtn_Stock.Rotation = 0D;
            this.iBtn_Stock.Size = new System.Drawing.Size(81, 64);
            this.iBtn_Stock.TabIndex = 3;
            this.iBtn_Stock.UseVisualStyleBackColor = true;
            this.iBtn_Stock.Click += new System.EventHandler(this.IBtn_Stock_Click);
            // 
            // lbl_Agregar_Prod
            // 
            this.lbl_Agregar_Prod.AutoSize = true;
            this.lbl_Agregar_Prod.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Agregar_Prod.Location = new System.Drawing.Point(12, 401);
            this.lbl_Agregar_Prod.Name = "lbl_Agregar_Prod";
            this.lbl_Agregar_Prod.Size = new System.Drawing.Size(101, 32);
            this.lbl_Agregar_Prod.TabIndex = 4;
            this.lbl_Agregar_Prod.Text = "Agregar nuevo\r\n    producto";
            // 
            // dGViewStock
            // 
            this.dGViewStock.AllowUserToAddRows = false;
            this.dGViewStock.AllowUserToDeleteRows = false;
            this.dGViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGViewStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGViewStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dGViewStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGViewStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGViewStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGViewStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGViewStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGViewStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dGViewStock.EnableHeadersVisualStyles = false;
            this.dGViewStock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dGViewStock.Location = new System.Drawing.Point(12, 110);
            this.dGViewStock.Name = "dGViewStock";
            this.dGViewStock.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGViewStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGViewStock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGViewStock.Size = new System.Drawing.Size(506, 231);
            this.dGViewStock.TabIndex = 5;
            // 
            // iBtn_Remove
            // 
            this.iBtn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_Remove.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtn_Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iBtn_Remove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iBtn_Remove.IconColor = System.Drawing.Color.Black;
            this.iBtn_Remove.IconSize = 52;
            this.iBtn_Remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_Remove.Location = new System.Drawing.Point(304, 347);
            this.iBtn_Remove.Name = "iBtn_Remove";
            this.iBtn_Remove.Rotation = 0D;
            this.iBtn_Remove.Size = new System.Drawing.Size(75, 63);
            this.iBtn_Remove.TabIndex = 6;
            this.iBtn_Remove.UseVisualStyleBackColor = true;
            this.iBtn_Remove.Click += new System.EventHandler(this.IBtn_Remove_Click);
            // 
            // lbl_Eliminar_Prod
            // 
            this.lbl_Eliminar_Prod.AutoSize = true;
            this.lbl_Eliminar_Prod.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eliminar_Prod.Location = new System.Drawing.Point(316, 401);
            this.lbl_Eliminar_Prod.Name = "lbl_Eliminar_Prod";
            this.lbl_Eliminar_Prod.Size = new System.Drawing.Size(63, 32);
            this.lbl_Eliminar_Prod.TabIndex = 7;
            this.lbl_Eliminar_Prod.Text = "Eliminar\r\nProducto";
            // 
            // iBtn_Modif_Prod
            // 
            this.iBtn_Modif_Prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_Modif_Prod.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtn_Modif_Prod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iBtn_Modif_Prod.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iBtn_Modif_Prod.IconColor = System.Drawing.Color.Black;
            this.iBtn_Modif_Prod.IconSize = 52;
            this.iBtn_Modif_Prod.Location = new System.Drawing.Point(165, 347);
            this.iBtn_Modif_Prod.Name = "iBtn_Modif_Prod";
            this.iBtn_Modif_Prod.Rotation = 0D;
            this.iBtn_Modif_Prod.Size = new System.Drawing.Size(75, 71);
            this.iBtn_Modif_Prod.TabIndex = 8;
            this.iBtn_Modif_Prod.UseVisualStyleBackColor = true;
            this.iBtn_Modif_Prod.Click += new System.EventHandler(this.IBtn_Modif_Prod_Click);
            // 
            // lbl_Modif_Prod
            // 
            this.lbl_Modif_Prod.AutoSize = true;
            this.lbl_Modif_Prod.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modif_Prod.Location = new System.Drawing.Point(172, 401);
            this.lbl_Modif_Prod.Name = "lbl_Modif_Prod";
            this.lbl_Modif_Prod.Size = new System.Drawing.Size(68, 32);
            this.lbl_Modif_Prod.TabIndex = 9;
            this.lbl_Modif_Prod.Text = "Modificar\r\nProducto";
            // 
            // iBtn_Cliente_Agregar
            // 
            this.iBtn_Cliente_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_Cliente_Agregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtn_Cliente_Agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iBtn_Cliente_Agregar.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iBtn_Cliente_Agregar.IconColor = System.Drawing.Color.Black;
            this.iBtn_Cliente_Agregar.IconSize = 52;
            this.iBtn_Cliente_Agregar.Location = new System.Drawing.Point(433, 342);
            this.iBtn_Cliente_Agregar.Name = "iBtn_Cliente_Agregar";
            this.iBtn_Cliente_Agregar.Rotation = 0D;
            this.iBtn_Cliente_Agregar.Size = new System.Drawing.Size(85, 74);
            this.iBtn_Cliente_Agregar.TabIndex = 10;
            this.iBtn_Cliente_Agregar.UseVisualStyleBackColor = true;
            this.iBtn_Cliente_Agregar.Click += new System.EventHandler(this.IBtn_Cliente_Agregar_Click);
            // 
            // lbl_Agregar_Empleado
            // 
            this.lbl_Agregar_Empleado.AutoSize = true;
            this.lbl_Agregar_Empleado.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Agregar_Empleado.Location = new System.Drawing.Point(449, 401);
            this.lbl_Agregar_Empleado.Name = "lbl_Agregar_Empleado";
            this.lbl_Agregar_Empleado.Size = new System.Drawing.Size(69, 32);
            this.lbl_Agregar_Empleado.TabIndex = 11;
            this.lbl_Agregar_Empleado.Text = "Agregar\r\nEmpleado";
            // 
            // iBtn_Refrescar
            // 
            this.iBtn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_Refrescar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtn_Refrescar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iBtn_Refrescar.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.iBtn_Refrescar.IconColor = System.Drawing.Color.Black;
            this.iBtn_Refrescar.IconSize = 52;
            this.iBtn_Refrescar.Location = new System.Drawing.Point(524, 97);
            this.iBtn_Refrescar.Name = "iBtn_Refrescar";
            this.iBtn_Refrescar.Rotation = 0D;
            this.iBtn_Refrescar.Size = new System.Drawing.Size(61, 66);
            this.iBtn_Refrescar.TabIndex = 12;
            this.iBtn_Refrescar.UseVisualStyleBackColor = true;
            this.iBtn_Refrescar.Click += new System.EventHandler(this.IBtn_Refrescar_Click);
            // 
            // lbl_Refrescar
            // 
            this.lbl_Refrescar.AutoSize = true;
            this.lbl_Refrescar.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Refrescar.Location = new System.Drawing.Point(524, 157);
            this.lbl_Refrescar.Name = "lbl_Refrescar";
            this.lbl_Refrescar.Size = new System.Drawing.Size(70, 16);
            this.lbl_Refrescar.TabIndex = 13;
            this.lbl_Refrescar.Text = "Refrescar";
            // 
            // frm_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(599, 442);
            this.Controls.Add(this.lbl_Refrescar);
            this.Controls.Add(this.iBtn_Refrescar);
            this.Controls.Add(this.lbl_Agregar_Empleado);
            this.Controls.Add(this.iBtn_Cliente_Agregar);
            this.Controls.Add(this.lbl_Modif_Prod);
            this.Controls.Add(this.iBtn_Modif_Prod);
            this.Controls.Add(this.lbl_Eliminar_Prod);
            this.Controls.Add(this.iBtn_Remove);
            this.Controls.Add(this.dGViewStock);
            this.Controls.Add(this.lbl_Agregar_Prod);
            this.Controls.Add(this.iBtn_Stock);
            this.Controls.Add(this.lbl_Stock_Titulo);
            this.Name = "frm_Stock";
            this.Text = "Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Stock_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Stock_Titulo;
        private FontAwesome.Sharp.IconButton iBtn_Stock;
        private System.Windows.Forms.Label lbl_Agregar_Prod;
        private System.Windows.Forms.DataGridView dGViewStock;
        private FontAwesome.Sharp.IconButton iBtn_Remove;
        private System.Windows.Forms.Label lbl_Eliminar_Prod;
        private FontAwesome.Sharp.IconButton iBtn_Modif_Prod;
        private System.Windows.Forms.Label lbl_Modif_Prod;
        private FontAwesome.Sharp.IconButton iBtn_Cliente_Agregar;
        private System.Windows.Forms.Label lbl_Agregar_Empleado;
        private FontAwesome.Sharp.IconButton iBtn_Refrescar;
        private System.Windows.Forms.Label lbl_Refrescar;
    }
}