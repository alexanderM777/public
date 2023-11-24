namespace jjj
{
    partial class linq
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
            dtgPlayers = new DataGridView();
            dtgListaFilttrada = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgListaFilttrada).BeginInit();
            SuspendLayout();
            // 
            // dtgPlayers
            // 
            dtgPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPlayers.Location = new Point(47, 57);
            dtgPlayers.Name = "dtgPlayers";
            dtgPlayers.RowHeadersWidth = 51;
            dtgPlayers.RowTemplate.Height = 29;
            dtgPlayers.Size = new Size(823, 168);
            dtgPlayers.TabIndex = 0;
            // 
            // dtgListaFilttrada
            // 
            dtgListaFilttrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaFilttrada.Location = new Point(47, 266);
            dtgListaFilttrada.Name = "dtgListaFilttrada";
            dtgListaFilttrada.RowHeadersWidth = 51;
            dtgListaFilttrada.RowTemplate.Height = 29;
            dtgListaFilttrada.Size = new Size(823, 176);
            dtgListaFilttrada.TabIndex = 1;
            // 
            // linq
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 532);
            Controls.Add(dtgListaFilttrada);
            Controls.Add(dtgPlayers);
            Name = "linq";
            Text = "linq";
            ((System.ComponentModel.ISupportInitialize)dtgPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgListaFilttrada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgPlayers;
        private DataGridView dtgListaFilttrada;
    }
}