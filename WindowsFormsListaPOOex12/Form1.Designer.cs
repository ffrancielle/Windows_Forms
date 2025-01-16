namespace ListaPooFormsExer12
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
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_lado3 = new System.Windows.Forms.Label();
            this.lbl_lado2 = new System.Windows.Forms.Label();
            this.tbx_lado2 = new System.Windows.Forms.TextBox();
            this.tbx_lado3 = new System.Windows.Forms.TextBox();
            this.tbx_lado1 = new System.Windows.Forms.TextBox();
            this.btn_descobrir = new System.Windows.Forms.Button();
            this.lbl_lado1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(227, 176);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultado.TabIndex = 15;
            this.lbl_resultado.Text = "label4";
            this.lbl_resultado.Visible = false;
            // 
            // lbl_lado3
            // 
            this.lbl_lado3.AutoSize = true;
            this.lbl_lado3.Location = new System.Drawing.Point(76, 199);
            this.lbl_lado3.Name = "lbl_lado3";
            this.lbl_lado3.Size = new System.Drawing.Size(40, 13);
            this.lbl_lado3.TabIndex = 14;
            this.lbl_lado3.Text = "Lado 3";
            // 
            // lbl_lado2
            // 
            this.lbl_lado2.AutoSize = true;
            this.lbl_lado2.Location = new System.Drawing.Point(76, 160);
            this.lbl_lado2.Name = "lbl_lado2";
            this.lbl_lado2.Size = new System.Drawing.Size(40, 13);
            this.lbl_lado2.TabIndex = 13;
            this.lbl_lado2.Text = "Lado 2";
            // 
            // tbx_lado2
            // 
            this.tbx_lado2.Location = new System.Drawing.Point(79, 176);
            this.tbx_lado2.Name = "tbx_lado2";
            this.tbx_lado2.Size = new System.Drawing.Size(100, 20);
            this.tbx_lado2.TabIndex = 12;
            // 
            // tbx_lado3
            // 
            this.tbx_lado3.Location = new System.Drawing.Point(79, 212);
            this.tbx_lado3.Name = "tbx_lado3";
            this.tbx_lado3.Size = new System.Drawing.Size(100, 20);
            this.tbx_lado3.TabIndex = 11;
            // 
            // tbx_lado1
            // 
            this.tbx_lado1.Location = new System.Drawing.Point(79, 134);
            this.tbx_lado1.Name = "tbx_lado1";
            this.tbx_lado1.Size = new System.Drawing.Size(100, 20);
            this.tbx_lado1.TabIndex = 10;
            // 
            // btn_descobrir
            // 
            this.btn_descobrir.Location = new System.Drawing.Point(79, 238);
            this.btn_descobrir.Name = "btn_descobrir";
            this.btn_descobrir.Size = new System.Drawing.Size(75, 23);
            this.btn_descobrir.TabIndex = 9;
            this.btn_descobrir.Text = "Descobrir";
            this.btn_descobrir.UseVisualStyleBackColor = true;
            this.btn_descobrir.Click += new System.EventHandler(this.Descobrir_Triangulo);
            // 
            // lbl_lado1
            // 
            this.lbl_lado1.AutoSize = true;
            this.lbl_lado1.Location = new System.Drawing.Point(76, 118);
            this.lbl_lado1.Name = "lbl_lado1";
            this.lbl_lado1.Size = new System.Drawing.Size(40, 13);
            this.lbl_lado1.TabIndex = 8;
            this.lbl_lado1.Text = "Lado 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_lado3);
            this.Controls.Add(this.lbl_lado2);
            this.Controls.Add(this.tbx_lado2);
            this.Controls.Add(this.tbx_lado3);
            this.Controls.Add(this.tbx_lado1);
            this.Controls.Add(this.btn_descobrir);
            this.Controls.Add(this.lbl_lado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_lado3;
        private System.Windows.Forms.Label lbl_lado2;
        private System.Windows.Forms.TextBox tbx_lado2;
        private System.Windows.Forms.TextBox tbx_lado3;
        private System.Windows.Forms.TextBox tbx_lado1;
        private System.Windows.Forms.Button btn_descobrir;
        private System.Windows.Forms.Label lbl_lado1;
    }
}

