namespace SalvandoVidas
{
    partial class frmEstructuraDatos
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
            label2 = new Label();
            grpDatos = new GroupBox();
            txtCopago = new TextBox();
            label10 = new Label();
            txtReporteDatos = new TextBox();
            dtFechaRegistro = new DateTimePicker();
            label12 = new Label();
            cbTipoEstructura = new ComboBox();
            label11 = new Label();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            label8 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            rdExamenes = new RadioButton();
            rdMedicina = new RadioButton();
            cbEstrato = new ComboBox();
            label7 = new Label();
            txtEdad = new TextBox();
            label6 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            cbITipoIdentificacion = new ComboBox();
            txtIdentificacion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabDatos = new TabControl();
            tabPage1 = new TabPage();
            btnEliminarPila = new Button();
            btnReportePila = new Button();
            dgPila = new DataGridView();
            tabPage2 = new TabPage();
            btnEliminarCola = new Button();
            btnReporteCola = new Button();
            dgCola = new DataGridView();
            tabPage3 = new TabPage();
            btnEliminarLista = new Button();
            btnReporteLista = new Button();
            dgLista = new DataGridView();
            grpDatos.SuspendLayout();
            groupBox2.SuspendLayout();
            tabDatos.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPila).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCola).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 24);
            label1.Name = "label1";
            label1.Size = new Size(487, 22);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE REGISTRO DE USUARIO EN CENTRO ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(312, 64);
            label2.Name = "label2";
            label2.Size = new Size(178, 17);
            label2.TabIndex = 1;
            label2.Text = "EPS SALVANDO VIDAS";
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtCopago);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(txtReporteDatos);
            grpDatos.Controls.Add(dtFechaRegistro);
            grpDatos.Controls.Add(label12);
            grpDatos.Controls.Add(cbTipoEstructura);
            grpDatos.Controls.Add(label11);
            grpDatos.Controls.Add(btnSalir);
            grpDatos.Controls.Add(btnLimpiar);
            grpDatos.Controls.Add(btnRegistrar);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(groupBox2);
            grpDatos.Controls.Add(cbEstrato);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(txtEdad);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(cbITipoIdentificacion);
            grpDatos.Controls.Add(txtIdentificacion);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label3);
            grpDatos.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpDatos.Location = new Point(48, 88);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(712, 336);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Usuario";
            // 
            // txtCopago
            // 
            txtCopago.Enabled = false;
            txtCopago.Location = new Point(176, 192);
            txtCopago.Name = "txtCopago";
            txtCopago.Size = new Size(128, 23);
            txtCopago.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(432, 312);
            label10.Name = "label10";
            label10.Size = new Size(250, 13);
            label10.TabIndex = 32;
            label10.Text = "Los campos marcados con (*) son obligatorios.";
            // 
            // txtReporteDatos
            // 
            txtReporteDatos.Enabled = false;
            txtReporteDatos.Location = new Point(178, 292);
            txtReporteDatos.Name = "txtReporteDatos";
            txtReporteDatos.Size = new Size(127, 23);
            txtReporteDatos.TabIndex = 49;
            // 
            // dtFechaRegistro
            // 
            dtFechaRegistro.CalendarFont = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtFechaRegistro.Format = DateTimePickerFormat.Short;
            dtFechaRegistro.Location = new Point(554, 197);
            dtFechaRegistro.Name = "dtFechaRegistro";
            dtFechaRegistro.Size = new Size(127, 23);
            dtFechaRegistro.TabIndex = 47;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(394, 200);
            label12.Name = "label12";
            label12.Size = new Size(121, 14);
            label12.TabIndex = 46;
            label12.Text = "* Fecha de registro:";
            // 
            // cbTipoEstructura
            // 
            cbTipoEstructura.FormattingEnabled = true;
            cbTipoEstructura.Location = new Point(178, 246);
            cbTipoEstructura.Name = "cbTipoEstructura";
            cbTipoEstructura.Size = new Size(127, 23);
            cbTipoEstructura.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(18, 249);
            label11.Name = "label11";
            label11.Size = new Size(126, 14);
            label11.TabIndex = 44;
            label11.Text = "* Tipo de estructura:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(611, 264);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 43;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(505, 264);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 42;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(395, 264);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 41;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 200);
            label8.Name = "label8";
            label8.Size = new Size(109, 14);
            label8.TabIndex = 39;
            label8.Text = "Valor del copago:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 295);
            label9.Name = "label9";
            label9.Size = new Size(106, 15);
            label9.TabIndex = 48;
            label9.Text = "Reporte de datos:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdExamenes);
            groupBox2.Controls.Add(rdMedicina);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(394, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 66);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "* Tipo de atencion";
            // 
            // rdExamenes
            // 
            rdExamenes.AutoSize = true;
            rdExamenes.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdExamenes.Location = new Point(136, 31);
            rdExamenes.Name = "rdExamenes";
            rdExamenes.Size = new Size(149, 19);
            rdExamenes.TabIndex = 13;
            rdExamenes.TabStop = true;
            rdExamenes.Text = "Examen de laboratorio";
            rdExamenes.UseVisualStyleBackColor = true;
            // 
            // rdMedicina
            // 
            rdMedicina.AutoSize = true;
            rdMedicina.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdMedicina.Location = new Point(13, 30);
            rdMedicina.Name = "rdMedicina";
            rdMedicina.Size = new Size(119, 19);
            rdMedicina.TabIndex = 12;
            rdMedicina.TabStop = true;
            rdMedicina.Text = "Medicina general";
            rdMedicina.UseVisualStyleBackColor = true;
            // 
            // cbEstrato
            // 
            cbEstrato.FormattingEnabled = true;
            cbEstrato.Location = new Point(178, 131);
            cbEstrato.Name = "cbEstrato";
            cbEstrato.Size = new Size(127, 23);
            cbEstrato.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 134);
            label7.Name = "label7";
            label7.Size = new Size(158, 14);
            label7.TabIndex = 36;
            label7.Text = "* Estrato socioeconómico:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(558, 66);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(127, 23);
            txtEdad.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(394, 69);
            label6.Name = "label6";
            label6.Size = new Size(50, 14);
            label6.TabIndex = 34;
            label6.Text = "* Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 23);
            txtNombre.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 69);
            label5.Name = "label5";
            label5.Size = new Size(123, 14);
            label5.TabIndex = 32;
            label5.Text = "* Nombre completo:";
            // 
            // cbITipoIdentificacion
            // 
            cbITipoIdentificacion.FormattingEnabled = true;
            cbITipoIdentificacion.Location = new Point(178, 21);
            cbITipoIdentificacion.Name = "cbITipoIdentificacion";
            cbITipoIdentificacion.Size = new Size(127, 23);
            cbITipoIdentificacion.TabIndex = 31;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(558, 21);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(127, 23);
            txtIdentificacion.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(394, 24);
            label4.Name = "label4";
            label4.Size = new Size(142, 14);
            label4.TabIndex = 29;
            label4.Text = "* Nro. de identificacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 24);
            label3.Name = "label3";
            label3.Size = new Size(143, 14);
            label3.TabIndex = 28;
            label3.Text = "* Tipo de identificacion:";
            // 
            // tabDatos
            // 
            tabDatos.Controls.Add(tabPage1);
            tabDatos.Controls.Add(tabPage2);
            tabDatos.Controls.Add(tabPage3);
            tabDatos.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabDatos.Location = new Point(46, 432);
            tabDatos.Name = "tabDatos";
            tabDatos.SelectedIndex = 0;
            tabDatos.Size = new Size(716, 161);
            tabDatos.TabIndex = 31;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEliminarPila);
            tabPage1.Controls.Add(btnReportePila);
            tabPage1.Controls.Add(dgPila);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(708, 133);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pila";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPila
            // 
            btnEliminarPila.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarPila.Location = new Point(609, 74);
            btnEliminarPila.Name = "btnEliminarPila";
            btnEliminarPila.Size = new Size(75, 23);
            btnEliminarPila.TabIndex = 30;
            btnEliminarPila.Text = "Eliminar";
            btnEliminarPila.UseVisualStyleBackColor = true;
            btnEliminarPila.Click += btnEliminarPila_Click_1;
            // 
            // btnReportePila
            // 
            btnReportePila.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportePila.Location = new Point(609, 45);
            btnReportePila.Name = "btnReportePila";
            btnReportePila.Size = new Size(75, 23);
            btnReportePila.TabIndex = 29;
            btnReportePila.Text = "Reporte";
            btnReportePila.UseVisualStyleBackColor = true;
            btnReportePila.Click += btnReportePila_Click_1;
            // 
            // dgPila
            // 
            dgPila.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPila.Location = new Point(21, 22);
            dgPila.Name = "dgPila";
            dgPila.RowHeadersWidth = 82;
            dgPila.RowTemplate.Height = 25;
            dgPila.Size = new Size(571, 92);
            dgPila.TabIndex = 28;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnEliminarCola);
            tabPage2.Controls.Add(btnReporteCola);
            tabPage2.Controls.Add(dgCola);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(708, 133);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cola";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCola
            // 
            btnEliminarCola.Location = new Point(609, 73);
            btnEliminarCola.Name = "btnEliminarCola";
            btnEliminarCola.Size = new Size(75, 23);
            btnEliminarCola.TabIndex = 30;
            btnEliminarCola.Text = "Eliminar";
            btnEliminarCola.UseVisualStyleBackColor = true;
            btnEliminarCola.Click += btnEliminarCola_Click_1;
            // 
            // btnReporteCola
            // 
            btnReporteCola.Location = new Point(609, 44);
            btnReporteCola.Name = "btnReporteCola";
            btnReporteCola.Size = new Size(75, 23);
            btnReporteCola.TabIndex = 29;
            btnReporteCola.Text = "Reporte";
            btnReporteCola.UseVisualStyleBackColor = true;
            // 
            // dgCola
            // 
            dgCola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCola.Location = new Point(21, 22);
            dgCola.Name = "dgCola";
            dgCola.RowHeadersWidth = 82;
            dgCola.RowTemplate.Height = 25;
            dgCola.Size = new Size(571, 93);
            dgCola.TabIndex = 28;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnEliminarLista);
            tabPage3.Controls.Add(btnReporteLista);
            tabPage3.Controls.Add(dgLista);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(708, 133);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Lista";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLista
            // 
            btnEliminarLista.Location = new Point(609, 71);
            btnEliminarLista.Name = "btnEliminarLista";
            btnEliminarLista.Size = new Size(75, 23);
            btnEliminarLista.TabIndex = 30;
            btnEliminarLista.Text = "Eliminar";
            btnEliminarLista.UseVisualStyleBackColor = true;
            btnEliminarLista.Click += btnEliminarLista_Click_1;
            // 
            // btnReporteLista
            // 
            btnReporteLista.Location = new Point(609, 42);
            btnReporteLista.Name = "btnReporteLista";
            btnReporteLista.Size = new Size(75, 23);
            btnReporteLista.TabIndex = 29;
            btnReporteLista.Text = "Reporte";
            btnReporteLista.UseVisualStyleBackColor = true;
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(21, 22);
            dgLista.Name = "dgLista";
            dgLista.RowHeadersWidth = 82;
            dgLista.RowTemplate.Height = 25;
            dgLista.Size = new Size(571, 91);
            dgLista.TabIndex = 28;
            // 
            // frmEstructuraDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 641);
            Controls.Add(tabDatos);
            Controls.Add(grpDatos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEstructuraDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EstructuraDatos";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabDatos.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPila).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCola).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox grpDatos;
        private TextBox txtReporteDatos;
        private DateTimePicker dtFechaRegistro;
        private Label label12;
        private ComboBox cbTipoEstructura;
        private Label label11;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Label label8;
        private Label label9;
        private GroupBox groupBox2;
        private RadioButton rdExamenes;
        private RadioButton rdMedicina;
        private ComboBox cbEstrato;
        private Label label7;
        private TextBox txtEdad;
        private Label label6;
        private TextBox txtNombre;
        private Label label5;
        private ComboBox cbITipoIdentificacion;
        private TextBox txtIdentificacion;
        private Label label4;
        private Label label3;
        private TabControl tabDatos;
        private TabPage tabPage1;
        private Button btnEliminarPila;
        private Button btnReportePila;
        private DataGridView dgPila;
        private TabPage tabPage2;
        private Button btnEliminarCola;
        private Button btnReporteCola;
        private DataGridView dgCola;
        private TabPage tabPage3;
        private Button btnEliminarLista;
        private Button btnReporteLista;
        private DataGridView dgLista;
        private Label label10;
        private TextBox txtCopago;
    }
}