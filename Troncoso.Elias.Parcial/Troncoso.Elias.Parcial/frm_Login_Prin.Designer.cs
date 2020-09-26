namespace Troncoso.Elias.Parcial
{
    partial class frm_Login_Prin
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
            this.pBox_Login = new System.Windows.Forms.PictureBox();
            this.txtBox_Usuario = new System.Windows.Forms.TextBox();
            this.txtBox_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Login_Ingre = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_Login
            // 
            this.pBox_Login.Image = global::Troncoso.Elias.Parcial.Properties.Resources.Kwik_E_Mart1;
            this.pBox_Login.Location = new System.Drawing.Point(-2, 1);
            this.pBox_Login.Name = "pBox_Login";
            this.pBox_Login.Size = new System.Drawing.Size(804, 452);
            this.pBox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_Login.TabIndex = 0;
            this.pBox_Login.TabStop = false;
            this.pBox_Login.Click += new System.EventHandler(this.PBox_Login_Click);
            // 
            // txtBox_Usuario
            // 
            this.txtBox_Usuario.Location = new System.Drawing.Point(556, 137);
            this.txtBox_Usuario.Multiline = true;
            this.txtBox_Usuario.Name = "txtBox_Usuario";
            this.txtBox_Usuario.Size = new System.Drawing.Size(160, 25);
            this.txtBox_Usuario.TabIndex = 1;
            // 
            // txtBox_Contraseña
            // 
            this.txtBox_Contraseña.Location = new System.Drawing.Point(556, 199);
            this.txtBox_Contraseña.Multiline = true;
            this.txtBox_Contraseña.Name = "txtBox_Contraseña";
            this.txtBox_Contraseña.Size = new System.Drawing.Size(160, 25);
            this.txtBox_Contraseña.TabIndex = 2;
            // 
            // btn_Login_Ingre
            // 
            this.btn_Login_Ingre.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login_Ingre.Location = new System.Drawing.Point(585, 242);
            this.btn_Login_Ingre.Name = "btn_Login_Ingre";
            this.btn_Login_Ingre.Size = new System.Drawing.Size(105, 30);
            this.btn_Login_Ingre.TabIndex = 3;
            this.btn_Login_Ingre.Text = "Ingresar";
            this.btn_Login_Ingre.UseVisualStyleBackColor = true;
            this.btn_Login_Ingre.Click += new System.EventHandler(this.Btn_Login_Ingre_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_login.Location = new System.Drawing.Point(520, 304);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(272, 19);
            this.lbl_login.TabIndex = 4;
            this.lbl_login.Text = "¿Todavía no estas registrado?  Clic aquí";
            this.lbl_login.Click += new System.EventHandler(this.Lbl_login_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher1_Changed);
            // 
            // frm_Login_Prin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_Login_Ingre);
            this.Controls.Add(this.txtBox_Contraseña);
            this.Controls.Add(this.txtBox_Usuario);
            this.Controls.Add(this.pBox_Login);
            this.Name = "frm_Login_Prin";
            this.Text = "kwik-E-Mart";
            this.Load += new System.EventHandler(this.Frm_Login_Prin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_Login;
        private System.Windows.Forms.TextBox txtBox_Usuario;
        private System.Windows.Forms.TextBox txtBox_Contraseña;
        private System.Windows.Forms.Button btn_Login_Ingre;
        private System.Windows.Forms.Label lbl_login;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

