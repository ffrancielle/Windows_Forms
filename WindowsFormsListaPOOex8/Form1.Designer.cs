namespace ListaPooFormsExer8
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
            this.lbl_valor1 = new System.Windows.Forms.Label();
            this.btt_calcular = new System.Windows.Forms.Button();
            this.tbx_valor1 = new System.Windows.Forms.TextBox();
            this.tbx_valor2 = new System.Windows.Forms.TextBox();
            this.lbl_valor2 = new System.Windows.Forms.Label();
            this.lbl_pre_resul = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_valor1
            // 
            this.lbl_valor1.AutoSize = true;
            this.lbl_valor1.Location = new System.Drawing.Point(82, 145);
            this.lbl_valor1.Name = "lbl_valor1";
            this.lbl_valor1.Size = new System.Drawing.Size(40, 13);
            this.lbl_valor1.TabIndex = 0;
            this.lbl_valor1.Text = "Valor 1";
            // 
            // btt_calcular
            // 
            this.btt_calcular.Location = new System.Drawing.Point(85, 265);
            this.btt_calcular.Name = "btt_calcular";
            this.btt_calcular.Size = new System.Drawing.Size(75, 23);
            this.btt_calcular.TabIndex = 1;
            this.btt_calcular.Text = "descobrir";
            this.btt_calcular.UseVisualStyleBackColor = true;
            this.btt_calcular.Click += new System.EventHandler(this.maior_Emenor);
            // 
            // tbx_valor1
            // 
            this.tbx_valor1.Location = new System.Drawing.Point(85, 161);
            this.tbx_valor1.Name = "tbx_valor1";
            this.tbx_valor1.Size = new System.Drawing.Size(100, 20);
            this.tbx_valor1.TabIndex = 2;
            // 
            // tbx_valor2
            // 
            this.tbx_valor2.Location = new System.Drawing.Point(85, 213);
            this.tbx_valor2.Name = "tbx_valor2";
            this.tbx_valor2.Size = new System.Drawing.Size(100, 20);
            this.tbx_valor2.TabIndex = 3;
            // 
            // lbl_valor2
            // 
            this.lbl_valor2.AutoSize = true;
            this.lbl_valor2.Location = new System.Drawing.Point(82, 197);
            this.lbl_valor2.Name = "lbl_valor2";
            this.lbl_valor2.Size = new System.Drawing.Size(40, 13);
            this.lbl_valor2.TabIndex = 4;
            this.lbl_valor2.Text = "Valor 2";
            // 
            // lbl_pre_resul
            // 
            this.lbl_pre_resul.AutoSize = true;
            this.lbl_pre_resul.Location = new System.Drawing.Point(213, 197);
            this.lbl_pre_resul.Name = "lbl_pre_resul";
            this.lbl_pre_resul.Size = new System.Drawing.Size(0, 13);
            this.lbl_pre_resul.TabIndex = 5;
            this.lbl_pre_resul.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(238, 197);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(13, 13);
            this.lbl_resultado.TabIndex = 6;
            this.lbl_resultado.Text = "0";
            this.lbl_resultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_pre_resul);
            this.Controls.Add(this.lbl_valor2);
            this.Controls.Add(this.tbx_valor2);
            this.Controls.Add(this.tbx_valor1);
            this.Controls.Add(this.btt_calcular);
            this.Controls.Add(this.lbl_valor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_valor1;
        private System.Windows.Forms.Button btt_calcular;
        private System.Windows.Forms.TextBox tbx_valor1;
        private System.Windows.Forms.TextBox tbx_valor2;
        private System.Windows.Forms.Label lbl_valor2;
        private System.Windows.Forms.Label lbl_pre_resul;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

