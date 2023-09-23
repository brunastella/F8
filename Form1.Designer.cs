namespace F8
{
    partial class FormCalculoFolhaPagamento
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
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioHora.Location = new System.Drawing.Point(243, 82);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(100, 27);
            this.txtSalarioHora.TabIndex = 0;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHorasTrabalhadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(243, 143);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(100, 27);
            this.txtHorasTrabalhadas.TabIndex = 1;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(70, 209);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(107, 20);
            this.lblSalarioBruto.TabIndex = 2;
            this.lblSalarioBruto.Text = "Salario Bruto";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(71, 255);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(47, 20);
            this.lblINSS.TabIndex = 3;
            this.lblINSS.Text = "INSS";
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR.Location = new System.Drawing.Point(71, 299);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(25, 20);
            this.lblIR.TabIndex = 4;
            this.lblIR.Text = "IR";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(71, 347);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(120, 20);
            this.lblSalarioLiquido.TabIndex = 5;
            this.lblSalarioLiquido.Text = "Salario Liquido";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(286, 384);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 43);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioHora.Location = new System.Drawing.Point(71, 89);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(108, 20);
            this.lblSalarioHora.TabIndex = 7;
            this.lblSalarioHora.Text = "Salario  Hora";
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(71, 150);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(152, 20);
            this.lblHorasTrabalhadas.TabIndex = 8;
            this.lblHorasTrabalhadas.Text = "Horas Trabalhadas";
            // 
            // FormCalculoFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 448);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblIR);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioHora);
            this.Name = "FormCalculoFolhaPagamento";
            this.Text = "Folha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
    }
}

