namespace Teste2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLigarDesligar = new System.Windows.Forms.Button();
            this.lblPorcentagemBateria = new System.Windows.Forms.Label();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLigarDesligar
            // 
            this.btnLigarDesligar.Location = new System.Drawing.Point(28, 24);
            this.btnLigarDesligar.Name = "btnLigarDesligar";
            this.btnLigarDesligar.Size = new System.Drawing.Size(121, 47);
            this.btnLigarDesligar.TabIndex = 1;
            this.btnLigarDesligar.Text = "Ligar";
            this.btnLigarDesligar.Click += new System.EventHandler(this.btnLigarDesligar_Click);
            // 
            // lblPorcentagemBateria
            // 
            this.lblPorcentagemBateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagemBateria.Location = new System.Drawing.Point(28, 87);
            this.lblPorcentagemBateria.Name = "lblPorcentagemBateria";
            this.lblPorcentagemBateria.Size = new System.Drawing.Size(242, 54);
            this.lblPorcentagemBateria.TabIndex = 0;
            this.lblPorcentagemBateria.Text = "100%";
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Location = new System.Drawing.Point(155, 24);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(115, 47);
            this.btnRecarregar.TabIndex = 2;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 108);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bateria:";
            // 
            // backColor
            // 
            this.backColor.BackColor = System.Drawing.Color.Black;
            this.backColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backColor.Location = new System.Drawing.Point(0, 0);
            this.backColor.Name = "backColor";
            this.backColor.Size = new System.Drawing.Size(295, 170);
            this.backColor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 170);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.lblPorcentagemBateria);
            this.Controls.Add(this.btnLigarDesligar);
            this.Controls.Add(this.backColor);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lanterna";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLigarDesligar;
        private System.Windows.Forms.Label lblPorcentagemBateria;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label backColor;
    }
}

