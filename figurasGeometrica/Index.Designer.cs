namespace figurasGeometrica
{
    partial class Index
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
            this.btnDi = new System.Windows.Forms.Button();
            this.btnTri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDi
            // 
            this.btnDi.Location = new System.Drawing.Point(86, 205);
            this.btnDi.Name = "btnDi";
            this.btnDi.Size = new System.Drawing.Size(180, 110);
            this.btnDi.TabIndex = 0;
            this.btnDi.Text = "Figuras bidimensionales";
            this.btnDi.UseVisualStyleBackColor = true;
            this.btnDi.Click += new System.EventHandler(this.btnDi_Click);
            // 
            // btnTri
            // 
            this.btnTri.Location = new System.Drawing.Point(360, 205);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(180, 110);
            this.btnTri.TabIndex = 1;
            this.btnTri.Text = "Figuras Tridimensionales";
            this.btnTri.UseVisualStyleBackColor = true;
            this.btnTri.Click += new System.EventHandler(this.btnTri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTri);
            this.Controls.Add(this.btnDi);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDi;
        private Button btnTri;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}