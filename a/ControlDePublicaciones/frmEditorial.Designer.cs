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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            txtAutor = new TextBox();
            txtPrecioLibro = new TextBox();
            txtPublicacion = new TextBox();
            txtTituloLibro = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            cboPeirodo = new ComboBox();
            label9 = new Label();
            txtPrecioevista = new TextBox();
            label8 = new Label();
            txtTitulorevista = new TextBox();
            label6 = new Label();
            dtgLibros = new DataGridView();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 57);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "TITULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(419, 28);
            label2.Name = "label2";
            label2.Size = new Size(172, 41);
            label2.TabIndex = 1;
            label2.Text = "EDITORIAL";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 105);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAutor);
            groupBox1.Controls.Add(txtPrecioLibro);
            groupBox1.Controls.Add(txtPublicacion);
            groupBox1.Controls.Add(txtTituloLibro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 131);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(487, 169);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "LIBRO";
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutor.Location = new Point(105, 125);
            txtAutor.Margin = new Padding(3, 4, 3, 4);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(82, 23);
            txtAutor.TabIndex = 7;
            // 
            // txtPrecioLibro
            // 
            txtPrecioLibro.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioLibro.Location = new Point(325, 121);
            txtPrecioLibro.Margin = new Padding(3, 4, 3, 4);
            txtPrecioLibro.Name = "txtPrecioLibro";
            txtPrecioLibro.Size = new Size(82, 23);
            txtPrecioLibro.TabIndex = 6;
            // 
            // txtPublicacion
            // 
            txtPublicacion.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublicacion.Location = new Point(105, 88);
            txtPublicacion.Margin = new Padding(3, 4, 3, 4);
            txtPublicacion.Name = "txtPublicacion";
            txtPublicacion.Size = new Size(82, 23);
            txtPublicacion.TabIndex = 5;
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txtTituloLibro.Location = new Point(105, 49);
            txtTituloLibro.Margin = new Padding(3, 4, 3, 4);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(284, 23);
            txtTituloLibro.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(273, 125);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 3;
            label5.Text = "PRECIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 136);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 2;
            label4.Text = "AUTOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 92);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 1;
            label3.Text = "PUBLICACION";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(cboPeirodo);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtPrecioevista);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtTitulorevista);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(546, 131);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(506, 169);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "REVISTA";
            // 
            // cboPeirodo
            // 
            cboPeirodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeirodo.Font = new Font("Segoe UI Black", 7F, FontStyle.Regular, GraphicsUnit.Point);
            cboPeirodo.FormattingEnabled = true;
            cboPeirodo.Items.AddRange(new object[] { "MENSUAL", "QUINCENAL ", "SEMANAL" });
            cboPeirodo.Location = new Point(89, 84);
            cboPeirodo.Margin = new Padding(3, 4, 3, 4);
            cboPeirodo.Name = "cboPeirodo";
            cboPeirodo.Size = new Size(138, 23);
            cboPeirodo.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(31, 48);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 8;
            label9.Text = "TITULO";
            // 
            // txtPrecioevista
            // 
            txtPrecioevista.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioevista.Location = new Point(375, 111);
            txtPrecioevista.Margin = new Padding(3, 4, 3, 4);
            txtPrecioevista.Name = "txtPrecioevista";
            txtPrecioevista.Size = new Size(82, 23);
            txtPrecioevista.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(27, 91);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 9;
            label8.Text = "PERIODO";
            // 
            // txtTitulorevista
            // 
            txtTitulorevista.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulorevista.Location = new Point(89, 47);
            txtTitulorevista.Margin = new Padding(3, 4, 3, 4);
            txtTitulorevista.Name = "txtTitulorevista";
            txtTitulorevista.Size = new Size(284, 23);
            txtTitulorevista.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(323, 116);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 11;
            label6.Text = "PRECIO";
            // 
            // dtgLibros
            // 
            dtgLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLibros.Location = new Point(119, 338);
            dtgLibros.Margin = new Padding(3, 4, 3, 4);
            dtgLibros.Name = "dtgLibros";
            dtgLibros.RowHeadersWidth = 51;
            dtgLibros.RowTemplate.Height = 25;
            dtgLibros.Size = new Size(781, 190);
            dtgLibros.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(119, 558);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(782, 137);
            dataGridView1.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(31, 128);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmEditorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 747);
            Controls.Add(dataGridView1);
            Controls.Add(dtgLibros);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEditorial";
            Text = "frmEditorial";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
        private DataGridView dataGridView1;
        private Button btnAdd;
    }
}