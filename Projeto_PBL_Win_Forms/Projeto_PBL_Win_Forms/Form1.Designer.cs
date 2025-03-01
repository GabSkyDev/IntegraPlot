namespace Projeto_PBL_Win_Forms
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
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textoFuncao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonSenx = new System.Windows.Forms.Button();
            this.buttonCosx = new System.Windows.Forms.Button();
            this.buttonTanx = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEuler = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(540, 353);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(147, 48);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textoFuncao
            // 
            this.textoFuncao.BackColor = System.Drawing.Color.White;
            this.textoFuncao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoFuncao.Location = new System.Drawing.Point(61, 50);
            this.textoFuncao.Multiline = true;
            this.textoFuncao.Name = "textoFuncao";
            this.textoFuncao.Size = new System.Drawing.Size(271, 34);
            this.textoFuncao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite a função f(x):";
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.White;
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA.Location = new System.Drawing.Point(61, 148);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(271, 34);
            this.textBoxA.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Digite o ponto inicial (a):";
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.Color.White;
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxB.Location = new System.Drawing.Point(61, 248);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(271, 34);
            this.textBoxB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Digite o ponto final (b):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Digite o  número de divisões (n):";
            // 
            // textBoxN
            // 
            this.textBoxN.BackColor = System.Drawing.Color.White;
            this.textBoxN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxN.Location = new System.Drawing.Point(61, 353);
            this.textBoxN.Multiline = true;
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(271, 34);
            this.textBoxN.TabIndex = 11;
            // 
            // buttonSenx
            // 
            this.buttonSenx.BackColor = System.Drawing.Color.White;
            this.buttonSenx.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSenx.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonSenx.Location = new System.Drawing.Point(478, 50);
            this.buttonSenx.Name = "buttonSenx";
            this.buttonSenx.Size = new System.Drawing.Size(80, 46);
            this.buttonSenx.TabIndex = 12;
            this.buttonSenx.Text = "Sen(x)";
            this.buttonSenx.UseVisualStyleBackColor = false;
            this.buttonSenx.Click += new System.EventHandler(this.buttonSenx_Click);
            // 
            // buttonCosx
            // 
            this.buttonCosx.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCosx.Location = new System.Drawing.Point(573, 50);
            this.buttonCosx.Name = "buttonCosx";
            this.buttonCosx.Size = new System.Drawing.Size(80, 46);
            this.buttonCosx.TabIndex = 13;
            this.buttonCosx.Text = "Cos(x)";
            this.buttonCosx.UseVisualStyleBackColor = true;
            this.buttonCosx.Click += new System.EventHandler(this.buttonCosx_Click);
            // 
            // buttonTanx
            // 
            this.buttonTanx.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTanx.Location = new System.Drawing.Point(672, 50);
            this.buttonTanx.Name = "buttonTanx";
            this.buttonTanx.Size = new System.Drawing.Size(80, 46);
            this.buttonTanx.TabIndex = 14;
            this.buttonTanx.Text = "Tan(x)";
            this.buttonTanx.UseVisualStyleBackColor = true;
            this.buttonTanx.Click += new System.EventHandler(this.buttonTanx_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(478, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "√";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEuler
            // 
            this.buttonEuler.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEuler.Location = new System.Drawing.Point(573, 114);
            this.buttonEuler.Name = "buttonEuler";
            this.buttonEuler.Size = new System.Drawing.Size(80, 46);
            this.buttonEuler.TabIndex = 16;
            this.buttonEuler.Text = "e";
            this.buttonEuler.UseVisualStyleBackColor = true;
            this.buttonEuler.Click += new System.EventHandler(this.buttonEuler_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPi.Location = new System.Drawing.Point(672, 114);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(80, 46);
            this.buttonPi.TabIndex = 18;
            this.buttonPi.Text = "π";
            this.buttonPi.UseVisualStyleBackColor = true;
            this.buttonPi.Click += new System.EventHandler(this.buttonPi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonEuler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTanx);
            this.Controls.Add(this.buttonCosx);
            this.Controls.Add(this.buttonSenx);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoFuncao);
            this.Controls.Add(this.buttonCalcular);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textoFuncao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonSenx;
        private System.Windows.Forms.Button buttonCosx;
        private System.Windows.Forms.Button buttonTanx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEuler;
        private System.Windows.Forms.Button buttonPi;
    }
}

