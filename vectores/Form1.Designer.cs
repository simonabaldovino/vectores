namespace vectores
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
            this.grpCarga = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.grpCarga.SuspendLayout();
            this.grpListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCarga
            // 
            this.grpCarga.Controls.Add(this.btnCargar);
            this.grpCarga.Controls.Add(this.txtUsuarios);
            this.grpCarga.Controls.Add(this.lblNombre);
            this.grpCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarga.Location = new System.Drawing.Point(38, 41);
            this.grpCarga.Name = "grpCarga";
            this.grpCarga.Size = new System.Drawing.Size(349, 176);
            this.grpCarga.TabIndex = 0;
            this.grpCarga.TabStop = false;
            this.grpCarga.Text = "Carga de datos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(119, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(156, 48);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(178, 22);
            this.txtUsuarios.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(156, 93);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(178, 31);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.btnWhile);
            this.grpListado.Controls.Add(this.btnFor);
            this.grpListado.Controls.Add(this.lstPersonas);
            this.grpListado.Location = new System.Drawing.Point(38, 249);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(349, 261);
            this.grpListado.TabIndex = 1;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado de datos";
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Location = new System.Drawing.Point(34, 36);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(300, 160);
            this.lstPersonas.TabIndex = 0;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(34, 216);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(112, 23);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "Listar con for ";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(222, 216);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(112, 23);
            this.btnWhile.TabIndex = 2;
            this.btnWhile.Text = "Listar con while";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 538);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.grpCarga);
            this.Name = "Form1";
            this.Text = "Vectores";
            this.grpCarga.ResumeLayout(false);
            this.grpCarga.PerformLayout();
            this.grpListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCarga;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.ListBox lstPersonas;
    }
}

