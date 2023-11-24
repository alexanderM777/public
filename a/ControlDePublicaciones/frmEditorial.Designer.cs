namespace ControlDePublicaciones
{
    partial class frmEditorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgLibros = new System.Windows.Forms.DataGridView();
            this.dtgRevistas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtPublicacion = new System.Windows.Forms.TextBox();
            this.txtPrecioLibro = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtPrecioevista = new System.Windows.Forms.TextBox();
            this.txtTitulorevista = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPeirodo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRevistas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(367, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "EDITORIAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 79);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtPrecioLibro);
            this.groupBox1.Controls.Add(this.txtPublicacion);
            this.groupBox1.Controls.Add(this.txtTituloLibro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIBRO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.cboPeirodo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPrecioevista);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTitulorevista);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(478, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 127);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REVISTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "PUBLICACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "AUTOR";
            // 
            // dtgLibros
            // 
            this.dtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibros.Location = new System.Drawing.Point(30, 263);
            this.dtgLibros.Name = "dtgLibros";
            this.dtgLibros.RowTemplate.Height = 25;
            this.dtgLibros.Size = new System.Drawing.Size(369, 126);
            this.dtgLibros.TabIndex = 5;
            // 
            // dtgRevistas
            // 
            this.dtgRevistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRevistas.Location = new System.Drawing.Point(523, 263);
            this.dtgRevistas.Name = "dtgRevistas";
            this.dtgRevistas.RowTemplate.Height = 25;
            this.dtgRevistas.Size = new System.Drawing.Size(369, 126);
            this.dtgRevistas.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(239, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "PRECIO";
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTituloLibro.Location = new System.Drawing.Point(92, 37);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(249, 20);
            this.txtTituloLibro.TabIndex = 4;
            // 
            // txtPublicacion
            // 
            this.txtPublicacion.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPublicacion.Location = new System.Drawing.Point(92, 66);
            this.txtPublicacion.Name = "txtPublicacion";
            this.txtPublicacion.Size = new System.Drawing.Size(72, 20);
            this.txtPublicacion.TabIndex = 5;
            // 
            // txtPrecioLibro
            // 
            this.txtPrecioLibro.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioLibro.Location = new System.Drawing.Point(284, 91);
            this.txtPrecioLibro.Name = "txtPrecioLibro";
            this.txtPrecioLibro.Size = new System.Drawing.Size(72, 20);
            this.txtPrecioLibro.TabIndex = 6;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAutor.Location = new System.Drawing.Point(92, 94);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(72, 20);
            this.txtAutor.TabIndex = 7;
            // 
            // txtPrecioevista
            // 
            this.txtPrecioevista.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioevista.Location = new System.Drawing.Point(328, 83);
            this.txtPrecioevista.Name = "txtPrecioevista";
            this.txtPrecioevista.Size = new System.Drawing.Size(72, 20);
            this.txtPrecioevista.TabIndex = 14;
            // 
            // txtTitulorevista
            // 
            this.txtTitulorevista.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulorevista.Location = new System.Drawing.Point(78, 35);
            this.txtTitulorevista.Name = "txtTitulorevista";
            this.txtTitulorevista.Size = new System.Drawing.Size(249, 20);
            this.txtTitulorevista.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(283, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "PRECIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "PERIODO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(27, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "TITULO";
            // 
            // cboPeirodo
            // 
            this.cboPeirodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeirodo.Font = new System.Drawing.Font("Segoe UI Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPeirodo.FormattingEnabled = true;
            this.cboPeirodo.Items.AddRange(new object[] {
            "MENSUAL",
            "QUINCENAL ",
            "SEMANAL"});
            this.cboPeirodo.Location = new System.Drawing.Point(78, 63);
            this.cboPeirodo.Name = "cboPeirodo";
            this.cboPeirodo.Size = new System.Drawing.Size(121, 20);
            this.cboPeirodo.TabIndex = 16;
            // 
            // frmEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.dtgRevistas);
            this.Controls.Add(this.dtgLibros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmEditorial";
            this.Text = "frmEditorial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRevistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView dtgLibros;
        private DataGridView dtgRevistas;
        private Label label5;
        private TextBox txtAutor;
        private TextBox txtPrecioLibro;
        private TextBox txtPublicacion;
        private TextBox txtTituloLibro;
        private ComboBox cboPeirodo;
        private Label label9;
        private TextBox txtPrecioevista;
        private Label label8;
        private TextBox txtTitulorevista;
        private Label label6;
    }
}