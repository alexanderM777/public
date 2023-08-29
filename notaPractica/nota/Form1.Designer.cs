namespace nota
{
    partial class Form1
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
            txtnota1 = new TextBox();
            txtnota2 = new TextBox();
            label2 = new Label();
            txtnota3 = new TextBox();
            label3 = new Label();
            btnCalcular = new Button();
            btnBorrar = new Button();
            TEXTestado = new TextBox();
            label4 = new Label();
            txtPromedio = new TextBox();
            label5 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 124);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(151, 127);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(125, 27);
            txtnota1.TabIndex = 1;
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(151, 178);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(125, 27);
            txtnota2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 175);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // txtnota3
            // 
            txtnota3.Location = new Point(151, 237);
            txtnota3.Name = "txtnota3";
            txtnota3.Size = new Size(125, 27);
            txtnota3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 234);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(342, 84);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(145, 101);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(342, 218);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(145, 100);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // TEXTestado
            // 
            TEXTestado.Location = new Point(626, 197);
            TEXTestado.Name = "TEXTestado";
            TEXTestado.Size = new Size(125, 27);
            TEXTestado.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 194);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(626, 146);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(125, 27);
            txtPromedio.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 143);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 8;
            label5.Text = "label5";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(554, 338);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(145, 100);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(TEXTestado);
            Controls.Add(label4);
            Controls.Add(txtPromedio);
            Controls.Add(label5);
            Controls.Add(btnBorrar);
            Controls.Add(btnCalcular);
            Controls.Add(txtnota3);
            Controls.Add(label3);
            Controls.Add(txtnota2);
            Controls.Add(label2);
            Controls.Add(txtnota1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnota1;
        private TextBox txtnota2;
        private Label label2;
        private TextBox txtnota3;
        private Label label3;
        private Button btnCalcular;
        private Button btnBorrar;
        private TextBox TEXTestado;
        private Label label4;
        private TextBox txtPromedio;
        private Label label5;
        private Button btnSalir;
    }
}