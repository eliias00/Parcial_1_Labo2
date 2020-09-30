namespace Troncoso.Elias.Parcial
{
    partial class frm_Listados
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
            this.dGView_Listados = new System.Windows.Forms.DataGridView();
            this.dGView_Stock_10U = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Listados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Stock_10U)).BeginInit();
            this.SuspendLayout();
            // 
            // dGView_Listados
            // 
            this.dGView_Listados.AllowUserToAddRows = false;
            this.dGView_Listados.AllowUserToDeleteRows = false;
            this.dGView_Listados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView_Listados.Location = new System.Drawing.Point(12, 12);
            this.dGView_Listados.Name = "dGView_Listados";
            this.dGView_Listados.ReadOnly = true;
            this.dGView_Listados.Size = new System.Drawing.Size(417, 198);
            this.dGView_Listados.TabIndex = 0;
            // 
            // dGView_Stock_10U
            // 
            this.dGView_Stock_10U.AllowUserToAddRows = false;
            this.dGView_Stock_10U.AllowUserToDeleteRows = false;
            this.dGView_Stock_10U.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView_Stock_10U.Location = new System.Drawing.Point(12, 240);
            this.dGView_Stock_10U.Name = "dGView_Stock_10U";
            this.dGView_Stock_10U.ReadOnly = true;
            this.dGView_Stock_10U.Size = new System.Drawing.Size(417, 198);
            this.dGView_Stock_10U.TabIndex = 1;
            // 
            // frm_Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.dGView_Stock_10U);
            this.Controls.Add(this.dGView_Listados);
            this.Name = "frm_Listados";
            this.Text = "frm_Listados";
            this.Load += new System.EventHandler(this.Frm_Listados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Listados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Stock_10U)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGView_Listados;
        private System.Windows.Forms.DataGridView dGView_Stock_10U;
    }
}