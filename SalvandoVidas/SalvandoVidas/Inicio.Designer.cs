namespace SalvandoVidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            tsmInicio = new ToolStripMenuItem();
            tsmAcerca = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(384, 88);
            label1.Name = "label1";
            label1.Size = new Size(408, 18);
            label1.TabIndex = 1;
            label1.Text = "SISTEMA DE REGISTRO DE USUARIO EN CENTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(480, 120);
            label2.Name = "label2";
            label2.Size = new Size(193, 18);
            label2.TabIndex = 2;
            label2.Text = "EPS SALVANDO VIDAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(464, 192);
            label3.Name = "label3";
            label3.Size = new Size(231, 15);
            label3.TabIndex = 3;
            label3.Text = "Digite la Contraseña para Ingresar";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ActiveCaption;
            btnIngresar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(488, 320);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 32);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Desktop;
            btnSalir.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(600, 320);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 32);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(488, 256);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(184, 23);
            txtContraseña.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmInicio, tsmAcerca });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmInicio
            // 
            tsmInicio.Name = "tsmInicio";
            tsmInicio.Size = new Size(88, 20);
            tsmInicio.Text = "Iniciar Sesion";
            // 
            // tsmAcerca
            // 
            tsmAcerca.Name = "tsmAcerca";
            tsmAcerca.Size = new Size(71, 20);
            tsmAcerca.Text = "Acerca de";
            tsmAcerca.Click += this.tsmAcerca_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 393);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnIngresar;
        private Button btnSalir;
        private TextBox txtContraseña;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmInicio;
        private ToolStripMenuItem tsmAcerca;
    }
}
