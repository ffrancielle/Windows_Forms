namespace ListaPooFormsExer6
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dollar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Coverção";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Converção_Preal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dollar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dollar
            // 
            this.Dollar.Location = new System.Drawing.Point(270, 172);
            this.Dollar.Name = "Dollar";
            this.Dollar.Size = new System.Drawing.Size(100, 20);
            this.Dollar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(314, 242);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(13, 13);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dollar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Dollar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Resultado;
    }
}

