namespace Paralel_Detecter_and_Rectangle_checker
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
            this.Paralel_label = new System.Windows.Forms.Label();
            this.Quadrilatero_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Paralel_label
            // 
            this.Paralel_label.AutoSize = true;
            this.Paralel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paralel_label.Location = new System.Drawing.Point(12, 413);
            this.Paralel_label.Name = "Paralel_label";
            this.Paralel_label.Size = new System.Drawing.Size(70, 26);
            this.Paralel_label.TabIndex = 0;
            this.Paralel_label.Text = "label1";
            // 
            // Quadrilatero_label
            // 
            this.Quadrilatero_label.AutoSize = true;
            this.Quadrilatero_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quadrilatero_label.Location = new System.Drawing.Point(12, 365);
            this.Quadrilatero_label.Name = "Quadrilatero_label";
            this.Quadrilatero_label.Size = new System.Drawing.Size(70, 26);
            this.Quadrilatero_label.TabIndex = 1;
            this.Quadrilatero_label.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quadrilatero_label);
            this.Controls.Add(this.Paralel_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Paralel_label;
        private System.Windows.Forms.Label Quadrilatero_label;
    }
}

