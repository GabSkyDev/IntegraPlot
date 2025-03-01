namespace Projeto_PBL_Win_Forms
{
    partial class FormGrafico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valorFuncao = new System.Windows.Forms.Label();
            this.valorArea = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valorInicial = new System.Windows.Forms.Label();
            this.valorFinal = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da Área:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(582, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Função:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // valorFuncao
            // 
            this.valorFuncao.AutoSize = true;
            this.valorFuncao.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorFuncao.Location = new System.Drawing.Point(658, 35);
            this.valorFuncao.Name = "valorFuncao";
            this.valorFuncao.Size = new System.Drawing.Size(120, 22);
            this.valorFuncao.TabIndex = 2;
            this.valorFuncao.Text = "valorFuncao";
            this.valorFuncao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.valorFuncao.Click += new System.EventHandler(this.valorFuncao_Click);
            // 
            // valorArea
            // 
            this.valorArea.AutoSize = true;
            this.valorArea.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorArea.Location = new System.Drawing.Point(658, 156);
            this.valorArea.Name = "valorArea";
            this.valorArea.Size = new System.Drawing.Size(100, 22);
            this.valorArea.TabIndex = 3;
            this.valorArea.Text = "valorArea";
            this.valorArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.valorArea.Click += new System.EventHandler(this.valorArea_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ponto Inicial:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ponto Final:";
            // 
            // valorInicial
            // 
            this.valorInicial.AutoSize = true;
            this.valorInicial.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorInicial.Location = new System.Drawing.Point(658, 75);
            this.valorInicial.Name = "valorInicial";
            this.valorInicial.Size = new System.Drawing.Size(130, 22);
            this.valorInicial.TabIndex = 6;
            this.valorInicial.Text = "valorInicial";
            this.valorInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valorFinal
            // 
            this.valorFinal.AutoSize = true;
            this.valorFinal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorFinal.Location = new System.Drawing.Point(657, 119);
            this.valorFinal.Name = "valorFinal";
            this.valorFinal.Size = new System.Drawing.Size(110, 22);
            this.valorFinal.TabIndex = 7;
            this.valorFinal.Text = "valorFinal";
            this.valorFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.Location = new System.Drawing.Point(661, 380);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(117, 45);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // FormGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.valorFinal);
            this.Controls.Add(this.valorInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valorArea);
            this.Controls.Add(this.valorFuncao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGrafico";
            this.Text = "FormGrafico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valorFuncao;
        private System.Windows.Forms.Label valorArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label valorInicial;
        private System.Windows.Forms.Label valorFinal;
        private System.Windows.Forms.Button buttonVoltar;
    }
}