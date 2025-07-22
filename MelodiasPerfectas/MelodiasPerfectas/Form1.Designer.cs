namespace fase1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.titulo1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Titulo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña";
            // 
            // btnvalidar
            // 
            this.btnvalidar.Location = new System.Drawing.Point(120, 136);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(75, 23);
            this.btnvalidar.TabIndex = 1;
            this.btnvalidar.Text = "validar";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(128, 96);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(100, 20);
            this.txtclave.TabIndex = 2;
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.titulo1.Location = new System.Drawing.Point(16, 16);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(268, 26);
            this.titulo1.TabIndex = 3;
            this.titulo1.Text = "Curso Estructura de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(72, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Acceso Al Sistema";
            // 
            // Titulo2
            // 
            this.Titulo2.AutoSize = true;
            this.Titulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.Titulo2.Location = new System.Drawing.Point(40, 40);
            this.Titulo2.Name = "Titulo2";
            this.Titulo2.Size = new System.Drawing.Size(221, 22);
            this.Titulo2.TabIndex = 5;
            this.Titulo2.Text = "Jonathan David Rodriguez";
            this.Titulo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 179);
            this.Controls.Add(this.Titulo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titulo1);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso al sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titulo2;
    }
}

