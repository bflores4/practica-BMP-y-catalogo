namespace practica_2_archivos_de_texto_y_binarios
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSizeBytes = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.lblLargo = new System.Windows.Forms.Label();
            this.txtBitsByPixel = new System.Windows.Forms.TextBox();
            this.lblBits = new System.Windows.Forms.Label();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.lblLugarNacimiento = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtprimerNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSelectFile.Location = new System.Drawing.Point(91, 14);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(142, 51);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Seleccionar archivo BMP";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 85);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(160, 20);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Tamaño del archivo:";
            // 
            // txtSizeBytes
            // 
            this.txtSizeBytes.Location = new System.Drawing.Point(193, 82);
            this.txtSizeBytes.Name = "txtSizeBytes";
            this.txtSizeBytes.Size = new System.Drawing.Size(100, 26);
            this.txtSizeBytes.TabIndex = 2;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(193, 117);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 26);
            this.txtAncho.TabIndex = 4;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(12, 120);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(61, 20);
            this.lblAncho.TabIndex = 3;
            this.lblAncho.Text = "Ancho:";
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(193, 152);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 26);
            this.txtLargo.TabIndex = 6;
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(12, 155);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(57, 20);
            this.lblLargo.TabIndex = 5;
            this.lblLargo.Text = "Largo:";
            // 
            // txtBitsByPixel
            // 
            this.txtBitsByPixel.Location = new System.Drawing.Point(193, 189);
            this.txtBitsByPixel.Name = "txtBitsByPixel";
            this.txtBitsByPixel.Size = new System.Drawing.Size(100, 26);
            this.txtBitsByPixel.TabIndex = 8;
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(12, 192);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(112, 20);
            this.lblBits.TabIndex = 7;
            this.lblBits.Text = "Bits por pixel:";
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Location = new System.Drawing.Point(444, 14);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(75, 20);
            this.lblCatalogo.TabIndex = 9;
            this.lblCatalogo.Text = "Catalogo";
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Location = new System.Drawing.Point(515, 149);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(137, 26);
            this.txtLugarNacimiento.TabIndex = 17;
            // 
            // lblLugarNacimiento
            // 
            this.lblLugarNacimiento.AutoSize = true;
            this.lblLugarNacimiento.Location = new System.Drawing.Point(348, 152);
            this.lblLugarNacimiento.Name = "lblLugarNacimiento";
            this.lblLugarNacimiento.Size = new System.Drawing.Size(166, 20);
            this.lblLugarNacimiento.TabIndex = 16;
            this.lblLugarNacimiento.Text = "Lugar de nacimineto:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(515, 112);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(137, 26);
            this.txtEdad.TabIndex = 15;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(348, 115);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(52, 20);
            this.lblEdad.TabIndex = 14;
            this.lblEdad.Text = "Edad:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(515, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(137, 26);
            this.txtApellido.TabIndex = 13;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(348, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 20);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtprimerNombre
            // 
            this.txtprimerNombre.Location = new System.Drawing.Point(515, 42);
            this.txtprimerNombre.Name = "txtprimerNombre";
            this.txtprimerNombre.Size = new System.Drawing.Size(137, 26);
            this.txtprimerNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(348, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 20);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Primer nombre:";
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Location = new System.Drawing.Point(515, 186);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(137, 26);
            this.txtEstadoCivil.TabIndex = 19;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(348, 189);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(100, 20);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado civil:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnGuardar.Location = new System.Drawing.Point(433, 220);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 51);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar en catalogo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 287);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEstadoCivil);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtLugarNacimiento);
            this.Controls.Add(this.lblLugarNacimiento);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtprimerNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.txtBitsByPixel);
            this.Controls.Add(this.lblBits);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.txtSizeBytes);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnSelectFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSizeBytes;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.TextBox txtBitsByPixel;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.TextBox txtLugarNacimiento;
        private System.Windows.Forms.Label lblLugarNacimiento;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtprimerNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnGuardar;
    }
}

