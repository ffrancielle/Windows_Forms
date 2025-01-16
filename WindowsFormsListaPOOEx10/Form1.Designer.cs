namespace ListaPooFormsExer10
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
            this.tbx_altura = new System.Windows.Forms.TextBox();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.tbx_peso = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(44, 251);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "IMC";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.Calcular_IMC);
            // 
            // tbx_altura
            // 
            this.tbx_altura.Location = new System.Drawing.Point(35, 138);
            this.tbx_altura.Name = "tbx_altura";
            this.tbx_altura.Size = new System.Drawing.Size(100, 20);
            this.tbx_altura.TabIndex = 1;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(32, 122);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(33, 13);
            this.lbl_altura.TabIndex = 2;
            this.lbl_altura.Text = "altura";
            // 
            // tbx_peso
            // 
            this.tbx_peso.Location = new System.Drawing.Point(35, 192);
            this.tbx_peso.Name = "tbx_peso";
            this.tbx_peso.Size = new System.Drawing.Size(100, 20);
            this.tbx_peso.TabIndex = 3;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(32, 176);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(30, 13);
            this.lbl_peso.TabIndex = 4;
            this.lbl_peso.Text = "peso";
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Location = new System.Drawing.Point(147, 166);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(13, 13);
            this.lbl_imc.TabIndex = 5;
            this.lbl_imc.Text = "0";
            this.lbl_imc.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_imc);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.tbx_peso);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.tbx_altura);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox tbx_altura;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.TextBox tbx_peso;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_imc;
    }
}

