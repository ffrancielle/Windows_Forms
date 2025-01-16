namespace ListaPooFormsExer9
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.tbx_altura = new System.Windows.Forms.TextBox();
            this.tbx_base = new System.Windows.Forms.TextBox();
            this.lbl_base = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(117, 232);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.Calcular_AreaRet);
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(114, 118);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(33, 13);
            this.lbl_altura.TabIndex = 1;
            this.lbl_altura.Text = "altura";
            // 
            // tbx_altura
            // 
            this.tbx_altura.Location = new System.Drawing.Point(117, 134);
            this.tbx_altura.Name = "tbx_altura";
            this.tbx_altura.Size = new System.Drawing.Size(100, 20);
            this.tbx_altura.TabIndex = 2;
            // 
            // tbx_base
            // 
            this.tbx_base.Location = new System.Drawing.Point(117, 190);
            this.tbx_base.Name = "tbx_base";
            this.tbx_base.Size = new System.Drawing.Size(100, 20);
            this.tbx_base.TabIndex = 3;
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(114, 171);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(30, 13);
            this.lbl_base.TabIndex = 4;
            this.lbl_base.Text = "base";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(245, 171);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultado.TabIndex = 5;
            this.lbl_resultado.Text = "label3";
            this.lbl_resultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_base);
            this.Controls.Add(this.tbx_base);
            this.Controls.Add(this.tbx_altura);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.TextBox tbx_altura;
        private System.Windows.Forms.TextBox tbx_base;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

