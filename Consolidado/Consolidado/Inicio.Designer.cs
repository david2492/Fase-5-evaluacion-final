namespace Consolidado
{
    partial class frmConsolidado
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
            label4 = new Label();
            btnspa = new Button();
            btnMelodias = new Button();
            btnVidas = new Button();
            btnArbol = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 16);
            label1.Name = "label1";
            label1.Size = new Size(423, 37);
            label1.TabIndex = 0;
            label1.Text = "Consolidacion Estructura de Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 272);
            label2.Name = "label2";
            label2.Size = new Size(181, 15);
            label2.TabIndex = 1;
            label2.Text = "Jonathan David Rodriguez Tejada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 288);
            label3.Name = "label3";
            label3.Size = new Size(197, 15);
            label3.TabIndex = 2;
            label3.Text = "Estudiante de Ingenieria de sistemas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 304);
            label4.Name = "label4";
            label4.Size = new Size(216, 15);
            label4.TabIndex = 3;
            label4.Text = "Universidad Abierta y A distancia UNAD";
            // 
            // btnspa
            // 
            btnspa.Location = new Point(16, 176);
            btnspa.Name = "btnspa";
            btnspa.Size = new Size(136, 40);
            btnspa.TabIndex = 4;
            btnspa.Text = "Ingresar SPA ROBLES";
            btnspa.UseVisualStyleBackColor = true;
            btnspa.Click += btnspa_Click;
            // 
            // btnMelodias
            // 
            btnMelodias.Location = new Point(168, 176);
            btnMelodias.Name = "btnMelodias";
            btnMelodias.Size = new Size(136, 40);
            btnMelodias.TabIndex = 5;
            btnMelodias.Text = "Ingresar Medolias Perfectas";
            btnMelodias.UseVisualStyleBackColor = true;
            btnMelodias.Click += btnMelodias_Click;
            // 
            // btnVidas
            // 
            btnVidas.Location = new Point(320, 176);
            btnVidas.Name = "btnVidas";
            btnVidas.Size = new Size(136, 40);
            btnVidas.TabIndex = 6;
            btnVidas.Text = "Ingresar Salvando Vidas";
            btnVidas.UseVisualStyleBackColor = true;
            btnVidas.Click += btnVidas_Click;
            // 
            // btnArbol
            // 
            btnArbol.Location = new Point(472, 176);
            btnArbol.Name = "btnArbol";
            btnArbol.Size = new Size(136, 40);
            btnArbol.TabIndex = 7;
            btnArbol.Text = "Ingresar Arbol Binario";
            btnArbol.UseVisualStyleBackColor = true;
            btnArbol.Click += btnArbol_Click;
            // 
            // frmConsolidado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(626, 332);
            Controls.Add(btnArbol);
            Controls.Add(btnVidas);
            Controls.Add(btnMelodias);
            Controls.Add(btnspa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmConsolidado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consolidacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnspa;
        private Button btnMelodias;
        private Button btnVidas;
        private Button btnArbol;
    }
}
