namespace Examen2
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgvrevista = new System.Windows.Forms.DataGridView();
            this.revistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.cboperiodicidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkfecha = new System.Windows.Forms.DateTimePicker();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoPubli = new System.Windows.Forms.ComboBox();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtgvlibros = new System.Windows.Forms.DataGridView();
            this.autorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvrevista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revistaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(589, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 28);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgvrevista
            // 
            this.dtgvrevista.AllowUserToDeleteRows = false;
            this.dtgvrevista.AutoGenerateColumns = false;
            this.dtgvrevista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvrevista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tituloDataGridViewTextBoxColumn,
            this.Periodicidad,
            this.costoDataGridViewTextBoxColumn});
            this.dtgvrevista.DataSource = this.revistaBindingSource;
            this.dtgvrevista.Location = new System.Drawing.Point(233, 127);
            this.dtgvrevista.Name = "dtgvrevista";
            this.dtgvrevista.ReadOnly = true;
            this.dtgvrevista.RowTemplate.Height = 25;
            this.dtgvrevista.Size = new System.Drawing.Size(721, 92);
            this.dtgvrevista.TabIndex = 1;
            // 
            // revistaBindingSource
            // 
            this.revistaBindingSource.DataSource = typeof(Examen2.Revista);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor";
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(26, 50);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(89, 23);
            this.txttitulo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmostrar);
            this.groupBox1.Controls.Add(this.cboperiodicidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpkfecha);
            this.groupBox1.Controls.Add(this.txtautor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtcosto);
            this.groupBox1.Controls.Add(this.txttitulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(233, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicacion";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(589, 56);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(107, 28);
            this.btnmostrar.TabIndex = 13;
            this.btnmostrar.Text = "MOSTRAR";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // cboperiodicidad
            // 
            this.cboperiodicidad.FormattingEnabled = true;
            this.cboperiodicidad.Items.AddRange(new object[] {
            "mensual",
            "quincenal",
            "semanal"});
            this.cboperiodicidad.Location = new System.Drawing.Point(453, 50);
            this.cboperiodicidad.Name = "cboperiodicidad";
            this.cboperiodicidad.Size = new System.Drawing.Size(113, 23);
            this.cboperiodicidad.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha de Publicacion";
            // 
            // dtpkfecha
            // 
            this.dtpkfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkfecha.Location = new System.Drawing.Point(328, 50);
            this.dtpkfecha.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dtpkfecha.Name = "dtpkfecha";
            this.dtpkfecha.Size = new System.Drawing.Size(119, 23);
            this.dtpkfecha.TabIndex = 9;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(230, 50);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(89, 23);
            this.txtautor.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Perodicidad";
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(127, 50);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(89, 23);
            this.txtcosto.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnregistrar);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboTipoPubli);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 385);
            this.panel1.TabIndex = 6;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(21, 103);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(111, 32);
            this.btnregistrar.TabIndex = 7;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(12, 333);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(111, 32);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de Publicacion";
            // 
            // cboTipoPubli
            // 
            this.cboTipoPubli.FormattingEnabled = true;
            this.cboTipoPubli.Items.AddRange(new object[] {
            "Libro",
            "Revista"});
            this.cboTipoPubli.Location = new System.Drawing.Point(21, 58);
            this.cboTipoPubli.Name = "cboTipoPubli";
            this.cboTipoPubli.Size = new System.Drawing.Size(111, 23);
            this.cboTipoPubli.TabIndex = 4;
            this.cboTipoPubli.SelectedIndexChanged += new System.EventHandler(this.cboTipoPubli_SelectedIndexChanged);
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataSource = typeof(Examen2.Libros);
            // 
            // librosBindingSource1
            // 
            this.librosBindingSource1.DataSource = typeof(Examen2.Libros);
            // 
            // dtgvlibros
            // 
            this.dtgvlibros.AllowUserToDeleteRows = false;
            this.dtgvlibros.AutoGenerateColumns = false;
            this.dtgvlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autorDataGridViewTextBoxColumn1,
            this.fechaPublicacionDataGridViewTextBoxColumn1,
            this.tituloDataGridViewTextBoxColumn1,
            this.costoDataGridViewTextBoxColumn1});
            this.dtgvlibros.DataSource = this.librosBindingSource;
            this.dtgvlibros.Location = new System.Drawing.Point(233, 235);
            this.dtgvlibros.Name = "dtgvlibros";
            this.dtgvlibros.ReadOnly = true;
            this.dtgvlibros.RowTemplate.Height = 25;
            this.dtgvlibros.Size = new System.Drawing.Size(721, 92);
            this.dtgvlibros.TabIndex = 7;
            // 
            // autorDataGridViewTextBoxColumn1
            // 
            this.autorDataGridViewTextBoxColumn1.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn1.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn1.Name = "autorDataGridViewTextBoxColumn1";
            this.autorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaPublicacionDataGridViewTextBoxColumn1
            // 
            this.fechaPublicacionDataGridViewTextBoxColumn1.DataPropertyName = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn1.HeaderText = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn1.Name = "fechaPublicacionDataGridViewTextBoxColumn1";
            this.fechaPublicacionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn1
            // 
            this.tituloDataGridViewTextBoxColumn1.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.Name = "tituloDataGridViewTextBoxColumn1";
            this.tituloDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // costoDataGridViewTextBoxColumn1
            // 
            this.costoDataGridViewTextBoxColumn1.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn1.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn1.Name = "costoDataGridViewTextBoxColumn1";
            this.costoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Periodicidad
            // 
            this.Periodicidad.DataPropertyName = "Periodicidad";
            this.Periodicidad.HeaderText = "Periodicidad";
            this.Periodicidad.Name = "Periodicidad";
            this.Periodicidad.ReadOnly = true;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 384);
            this.Controls.Add(this.dtgvlibros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvrevista);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvrevista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revistaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAgregar;
        private DataGridView dtgvrevista;
        private Label label1;
        private Label label2;
        private TextBox txttitulo;
        private GroupBox groupBox1;
        private ComboBox cboperiodicidad;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpkfecha;
        private TextBox txtautor;
        private Label label7;
        private TextBox txtcosto;
        private Panel panel1;
        private Button btnregistrar;
        private Button btnsalir;
        private Label label5;
        private ComboBox cboTipoPubli;
        private Button btnmostrar;
        private BindingSource revistaBindingSource;
        private BindingSource librosBindingSource;
        private BindingSource librosBindingSource1;
        private DataGridView dtgvlibros;
        private DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fechaPublicacionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Periodicidad;
        private DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
    }
}