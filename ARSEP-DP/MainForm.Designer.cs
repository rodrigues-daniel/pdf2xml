
namespace ARSEP_DP
{
    partial class MainForm
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
            this.sle01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sle01
            // 
            this.sle01.Location = new System.Drawing.Point(239, 156);
            this.sle01.Name = "sle01";
            this.sle01.Size = new System.Drawing.Size(75, 23);
            this.sle01.TabIndex = 2;
            this.sle01.Text = "Selecionar";
            this.sle01.UseVisualStyleBackColor = true;
            this.sle01.Click += new System.EventHandler(this.sle01_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sle01);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sle01;
    }
}

