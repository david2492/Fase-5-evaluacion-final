namespace fase1
{
    partial class frmDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatos));
            this.lblcedula = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblestrato = new System.Windows.Forms.Label();
            this.grpservicio = new System.Windows.Forms.GroupBox();
            this.optumyc = new System.Windows.Forms.RadioButton();
            this.optcyc = new System.Windows.Forms.RadioButton();
            this.optuac = new System.Windows.Forms.RadioButton();
            this.optccyu = new System.Windows.Forms.RadioButton();
            this.cmbestrato = new System.Windows.Forms.ComboBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncargar = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.grpservicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Location = new System.Drawing.Point(56, 49);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(40, 13);
            this.lblcedula.TabIndex = 0;
            this.lblcedula.Text = "Cedula";
            this.lblcedula.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(176, 48);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(56, 104);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(90, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre completo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(176, 96);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // lblestrato
            // 
            this.lblestrato.AutoSize = true;
            this.lblestrato.Location = new System.Drawing.Point(56, 160);
            this.lblestrato.Name = "lblestrato";
            this.lblestrato.Size = new System.Drawing.Size(40, 13);
            this.lblestrato.TabIndex = 5;
            this.lblestrato.Text = "Estrato";
            // 
            // grpservicio
            // 
            this.grpservicio.Controls.Add(this.optumyc);
            this.grpservicio.Controls.Add(this.optcyc);
            this.grpservicio.Controls.Add(this.optuac);
            this.grpservicio.Controls.Add(this.optccyu);
            this.grpservicio.Location = new System.Drawing.Point(64, 216);
            this.grpservicio.Name = "grpservicio";
            this.grpservicio.Size = new System.Drawing.Size(216, 120);
            this.grpservicio.TabIndex = 6;
            this.grpservicio.TabStop = false;
            this.grpservicio.Text = "Servicio";
            // 
            // optumyc
            // 
            this.optumyc.AutoSize = true;
            this.optumyc.Location = new System.Drawing.Point(16, 96);
            this.optumyc.Name = "optumyc";
            this.optumyc.Size = new System.Drawing.Size(191, 17);
            this.optumyc.TabIndex = 10;
            this.optumyc.TabStop = true;
            this.optumyc.Text = "Uñas en acrílico, maquillaje y cejas";
            this.optumyc.UseVisualStyleBackColor = true;
            // 
            // optcyc
            // 
            this.optcyc.AutoSize = true;
            this.optcyc.Location = new System.Drawing.Point(16, 24);
            this.optcyc.Name = "optcyc";
            this.optcyc.Size = new System.Drawing.Size(103, 17);
            this.optcyc.TabIndex = 7;
            this.optcyc.TabStop = true;
            this.optcyc.Text = "Corte y cepillado";
            this.optcyc.UseVisualStyleBackColor = true;
            // 
            // optuac
            // 
            this.optuac.AutoSize = true;
            this.optuac.Location = new System.Drawing.Point(16, 72);
            this.optuac.Name = "optuac";
            this.optuac.Size = new System.Drawing.Size(139, 17);
            this.optuac.TabIndex = 9;
            this.optuac.TabStop = true;
            this.optuac.Text = "Uñas en acrílico y cejas";
            this.optuac.UseVisualStyleBackColor = true;
            // 
            // optccyu
            // 
            this.optccyu.AutoSize = true;
            this.optccyu.Location = new System.Drawing.Point(16, 48);
            this.optccyu.Name = "optccyu";
            this.optccyu.Size = new System.Drawing.Size(132, 17);
            this.optccyu.TabIndex = 8;
            this.optccyu.TabStop = true;
            this.optccyu.Text = "Corte, cepillado y uñas";
            this.optccyu.UseVisualStyleBackColor = true;
            // 
            // cmbestrato
            // 
            this.cmbestrato.FormattingEnabled = true;
            this.cmbestrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbestrato.Location = new System.Drawing.Point(176, 152);
            this.cmbestrato.Name = "cmbestrato";
            this.cmbestrato.Size = new System.Drawing.Size(96, 21);
            this.cmbestrato.TabIndex = 7;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(240, 384);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(80, 56);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncargar
            // 
            this.btncargar.Image = ((System.Drawing.Image)(resources.GetObject("btncargar.Image")));
            this.btncargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncargar.Location = new System.Drawing.Point(80, 384);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(88, 56);
            this.btncargar.TabIndex = 8;
            this.btncargar.Text = "Cargar";
            this.btncargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(304, 8);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(75, 23);
            this.Atras.TabIndex = 10;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.cmbestrato);
            this.Controls.Add(this.grpservicio);
            this.Controls.Add(this.lblestrato);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.lblcedula);
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.grpservicio.ResumeLayout(false);
            this.grpservicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblestrato;
        private System.Windows.Forms.GroupBox grpservicio;
        private System.Windows.Forms.RadioButton optumyc;
        private System.Windows.Forms.RadioButton optcyc;
        private System.Windows.Forms.RadioButton optuac;
        private System.Windows.Forms.RadioButton optccyu;
        private System.Windows.Forms.ComboBox cmbestrato;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button Atras;
    }
}