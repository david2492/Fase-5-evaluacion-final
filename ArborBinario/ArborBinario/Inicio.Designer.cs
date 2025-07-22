namespace ArborBinario
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            pnlFecha = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 32);
            label1.Name = "label1";
            label1.Size = new Size(434, 47);
            label1.TabIndex = 0;
            label1.Text = "Arbol Binario de Busqueda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 96);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese la Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 156);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(265, 152);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(160, 23);
            txtContraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(249, 200);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(128, 40);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pnlFecha
            // 
            pnlFecha.Location = new Point(392, 264);
            pnlFecha.Name = "pnlFecha";
            pnlFecha.Size = new Size(192, 32);
            pnlFecha.TabIndex = 5;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(605, 308);
            Controls.Add(pnlFecha);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de Acceso a la Interfaz Grafica del Arbol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Panel pnlFecha;
    }
}
