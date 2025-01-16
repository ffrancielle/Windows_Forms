namespace ListaPooFormsExer11
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
            this.lbl_lado1 = new System.Windows.Forms.Label();
            this.btn_descobrir = new System.Windows.Forms.Button();
            this.tbx_lado1 = new System.Windows.Forms.TextBox();
            this.tbx_lado3 = new System.Windows.Forms.TextBox();
            this.tbx_lado2 = new System.Windows.Forms.TextBox();
            this.lbl_lado2 = new System.Windows.Forms.Label();
            this.lbl_lado3 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_lado1
            // 
            this.lbl_lado1.AutoSize = true;
            this.lbl_lado1.Location = new System.Drawing.Point(50, 116);
            this.lbl_lado1.Name = "lbl_lado1";
            this.lbl_lado1.Size = new System.Drawing.Size(40, 13);
            this.lbl_lado1.TabIndex = 0;
            this.lbl_lado1.Text = "Lado 1";
            // 
            // btn_descobrir
            // 
            this.btn_descobrir.Location = new System.Drawing.Point(53, 236);
            this.btn_descobrir.Name = "btn_descobrir";
            this.btn_descobrir.Size = new System.Drawing.Size(75, 23);
            this.btn_descobrir.TabIndex = 1;
            this.btn_descobrir.Text = "Descobrir";
            this.btn_descobrir.UseVisualStyleBackColor = true;
            this.btn_descobrir.Click += new System.EventHandler(this.descobrir_Seetriangulo);
            // 
            // tbx_lado1
            // 
            this.tbx_lado1.Location = new System.Drawing.Point(53, 132);
            this.tbx_lado1.Name = "tbx_lado1";
            this.tbx_lado1.Size = new System.Drawing.Size(100, 20);
            this.tbx_lado1.TabIndex = 2;
            // 
            // tbx_lado3
            // 
            this.tbx_lado3.Location = new System.Drawing.Point(53, 210);
            this.tbx_lado3.Name = "tbx_lado3";
            this.tbx_lado3.Size = new System.Drawing.Size(100, 20);
            this.tbx_lado3.TabIndex = 3;
            // 
            // tbx_lado2
            // 
            this.tbx_lado2.Location = new System.Drawing.Point(53, 174);
            this.tbx_lado2.Name = "tbx_lado2";
            this.tbx_lado2.Size = new System.Drawing.Size(100, 20);
            this.tbx_lado2.TabIndex = 4;
            // 
            // lbl_lado2
            // 
            this.lbl_lado2.AutoSize = true;
            this.lbl_lado2.Location = new System.Drawing.Point(50, 158);
            this.lbl_lado2.Name = "lbl_lado2";
            this.lbl_lado2.Size = new System.Drawing.Size(40, 13);
            this.lbl_lado2.TabIndex = 5;
            this.lbl_lado2.Text = "Lado 2";
            // 
            // lbl_lado3
            // 
            this.lbl_lado3.AutoSize = true;
            this.lbl_lado3.Location = new System.Drawing.Point(50, 197);
            this.lbl_lado3.Name = "lbl_lado3";
            this.lbl_lado3.Size = new System.Drawing.Size(40, 13);
            this.lbl_lado3.TabIndex = 6;
            this.lbl_lado3.Text = "Lado 3";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(201, 174);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultado.TabIndex = 7;
            this.lbl_resultado.Text = "label4";
            this.lbl_resultado.Visible = false;
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

        private System.Windows.Forms.Label lbl_lado1;
        private System.Windows.Forms.Button btn_descobrir;
        private System.Windows.Forms.TextBox tbx_lado1;
        private System.Windows.Forms.TextBox tbx_lado3;
        private System.Windows.Forms.TextBox tbx_lado2;
        private System.Windows.Forms.Label lbl_lado2;
        private System.Windows.Forms.Label lbl_lado3;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

