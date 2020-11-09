namespace testeunitti87
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
            this.ACEITAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ACEITAR
            // 
            this.ACEITAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ACEITAR.ForeColor = System.Drawing.Color.Transparent;
            this.ACEITAR.Location = new System.Drawing.Point(259, 182);
            this.ACEITAR.Name = "ACEITAR";
            this.ACEITAR.Size = new System.Drawing.Size(246, 101);
            this.ACEITAR.TabIndex = 0;
            this.ACEITAR.Text = "GUITOU";
            this.ACEITAR.UseVisualStyleBackColor = false;
            this.ACEITAR.Click += new System.EventHandler(this.ACEITAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ACEITAR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ACEITAR;
    }
}

