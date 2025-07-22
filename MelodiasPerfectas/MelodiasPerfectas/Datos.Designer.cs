namespace MelodiasPerfectas
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInstrumento = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.ckbFemenino = new System.Windows.Forms.CheckBox();
            this.ckbMasculino = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbClase = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbNClase = new System.Windows.Forms.TextBox();
            this.cmbInstrumento = new System.Windows.Forms.ComboBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.grbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(24, 72);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.Location = new System.Drawing.Point(24, 136);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(62, 13);
            this.lblInstrumento.TabIndex = 2;
            this.lblInstrumento.Text = "Instrumento";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(24, 168);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(78, 13);
            this.lblCosto.TabIndex = 3;
            this.lblCosto.Text = "Costo de Clase";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(24, 200);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(93, 13);
            this.lblClase.TabIndex = 4;
            this.lblClase.Text = "Numero de Clases";
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.ckbFemenino);
            this.grbGenero.Controls.Add(this.ckbMasculino);
            this.grbGenero.Location = new System.Drawing.Point(272, 96);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(144, 104);
            this.grbGenero.TabIndex = 5;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Genero";
            // 
            // ckbFemenino
            // 
            this.ckbFemenino.AutoSize = true;
            this.ckbFemenino.Location = new System.Drawing.Point(32, 64);
            this.ckbFemenino.Name = "ckbFemenino";
            this.ckbFemenino.Size = new System.Drawing.Size(72, 17);
            this.ckbFemenino.TabIndex = 1;
            this.ckbFemenino.Text = "Femenino";
            this.ckbFemenino.UseVisualStyleBackColor = true;
            this.ckbFemenino.CheckedChanged += new System.EventHandler(this.ckbFemenino_CheckedChanged);
            // 
            // ckbMasculino
            // 
            this.ckbMasculino.AutoSize = true;
            this.ckbMasculino.Location = new System.Drawing.Point(32, 40);
            this.ckbMasculino.Name = "ckbMasculino";
            this.ckbMasculino.Size = new System.Drawing.Size(74, 17);
            this.ckbMasculino.TabIndex = 0;
            this.ckbMasculino.Text = "Masculino";
            this.ckbMasculino.UseVisualStyleBackColor = true;
            this.ckbMasculino.CheckedChanged += new System.EventHandler(this.ckbMasculino_CheckedChanged_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(48, 248);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(144, 248);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(352, 248);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(128, 64);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 20);
            this.txbId.TabIndex = 9;
            // 
            // txbClase
            // 
            this.txbClase.Enabled = false;
            this.txbClase.Location = new System.Drawing.Point(128, 160);
            this.txbClase.Name = "txbClase";
            this.txbClase.Size = new System.Drawing.Size(100, 20);
            this.txbClase.TabIndex = 10;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(128, 96);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 11;
            // 
            // txbNClase
            // 
            this.txbNClase.Location = new System.Drawing.Point(128, 192);
            this.txbNClase.Name = "txbNClase";
            this.txbNClase.Size = new System.Drawing.Size(100, 20);
            this.txbNClase.TabIndex = 12;
            // 
            // cmbInstrumento
            // 
            this.cmbInstrumento.FormattingEnabled = true;
            this.cmbInstrumento.Items.AddRange(new object[] {
            "Piano",
            "Guitarra",
            "Violín",
            "Batería",
            "Canto"});
            this.cmbInstrumento.Location = new System.Drawing.Point(128, 128);
            this.cmbInstrumento.Name = "cmbInstrumento";
            this.cmbInstrumento.Size = new System.Drawing.Size(96, 21);
            this.cmbInstrumento.TabIndex = 13;
            this.cmbInstrumento.SelectedIndexChanged += new System.EventHandler(this.cmbInstrumento_SelectedIndexChanged);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(248, 248);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 291);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmbInstrumento);
            this.Controls.Add(this.txbNClase);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbClase);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblInstrumento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos";
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInstrumento;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.CheckBox ckbFemenino;
        private System.Windows.Forms.CheckBox ckbMasculino;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbClase;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbNClase;
        private System.Windows.Forms.ComboBox cmbInstrumento;
        private System.Windows.Forms.Button btnAtras;
    }
}