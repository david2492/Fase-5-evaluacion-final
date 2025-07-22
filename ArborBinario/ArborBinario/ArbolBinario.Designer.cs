namespace ArborBinario
{
    partial class frmArbolBinario
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
            label1 = new Label();
            txtEntero = new TextBox();
            btnAgregar = new Button();
            label2 = new Label();
            pnlArbol = new Panel();
            label3 = new Label();
            pnlPreorden = new Panel();
            label4 = new Label();
            PnlInorden = new Panel();
            label5 = new Label();
            pnlPosorden = new Panel();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 16);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor Entero";
            // 
            // txtEntero
            // 
            txtEntero.Location = new Point(40, 40);
            txtEntero.Name = "txtEntero";
            txtEntero.Size = new Size(100, 23);
            txtEntero.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(224, 40);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Nodo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 72);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Arbol";
            // 
            // pnlArbol
            // 
            pnlArbol.BackColor = SystemColors.ButtonHighlight;
            pnlArbol.Location = new Point(40, 88);
            pnlArbol.Name = "pnlArbol";
            pnlArbol.Size = new Size(672, 192);
            pnlArbol.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 296);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 5;
            label3.Text = "Recorrido Preorden";
            // 
            // pnlPreorden
            // 
            pnlPreorden.BackColor = SystemColors.ButtonHighlight;
            pnlPreorden.Location = new Point(40, 320);
            pnlPreorden.Name = "pnlPreorden";
            pnlPreorden.Size = new Size(672, 32);
            pnlPreorden.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 360);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 7;
            label4.Text = "Recorrido Inorden";
            // 
            // PnlInorden
            // 
            PnlInorden.BackColor = SystemColors.ButtonHighlight;
            PnlInorden.Location = new Point(40, 384);
            PnlInorden.Name = "PnlInorden";
            PnlInorden.Size = new Size(672, 32);
            PnlInorden.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 424);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 9;
            label5.Text = "Recorrido Posorden";
            // 
            // pnlPosorden
            // 
            pnlPosorden.BackColor = SystemColors.ButtonHighlight;
            pnlPosorden.Location = new Point(40, 448);
            pnlPosorden.Name = "pnlPosorden";
            pnlPosorden.Size = new Size(672, 32);
            pnlPosorden.TabIndex = 10;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(344, 496);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 11;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // frmArbolBinario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(750, 539);
            Controls.Add(btnAtras);
            Controls.Add(pnlPosorden);
            Controls.Add(label5);
            Controls.Add(PnlInorden);
            Controls.Add(label4);
            Controls.Add(pnlPreorden);
            Controls.Add(label3);
            Controls.Add(pnlArbol);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(txtEntero);
            Controls.Add(label1);
            Name = "frmArbolBinario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arbol Binario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEntero;
        private Button btnAgregar;
        private Label label2;
        private Panel pnlArbol;
        private Label label3;
        private Panel pnlPreorden;
        private Label label4;
        private Panel PnlInorden;
        private Label label5;
        private Panel pnlPosorden;
        private Button btnAtras;
    }
}