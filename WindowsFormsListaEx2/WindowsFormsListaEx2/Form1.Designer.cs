namespace WindowsFormsListaEx2
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
            this.txtLado = new System.Windows.Forms.TextBox();
            this.labLado = new System.Windows.Forms.Label();
            this.labArea = new System.Windows.Forms.Label();
            this.labResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(235, 95);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 0;
            this.txtLado.Text = "0";
            // 
            // labLado
            // 
            this.labLado.AutoSize = true;
            this.labLado.Location = new System.Drawing.Point(232, 79);
            this.labLado.Name = "labLado";
            this.labLado.Size = new System.Drawing.Size(115, 13);
            this.labLado.TabIndex = 1;
            this.labLado.Text = "Informe o valor do lado";
            // 
            // labArea
            // 
            this.labArea.AutoSize = true;
            this.labArea.Location = new System.Drawing.Point(238, 186);
            this.labArea.Name = "labArea";
            this.labArea.Size = new System.Drawing.Size(110, 13);
            this.labArea.TabIndex = 2;
            this.labArea.Text = "A área do quadrado é";
            this.labArea.Click += new System.EventHandler(this.label2_Click);
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Location = new System.Drawing.Point(243, 222);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(94, 13);
            this.labResultado.TabIndex = 3;
            this.labResultado.Text = "Area do Quadrado";
            this.labResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(241, 147);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.calcular);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.labArea);
            this.Controls.Add(this.labLado);
            this.Controls.Add(this.txtLado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label labLado;
        private System.Windows.Forms.Label labArea;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

