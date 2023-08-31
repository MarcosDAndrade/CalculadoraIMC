namespace CalculadoraIMC
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
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.rd6 = new System.Windows.Forms.RadioButton();
            this.rd7 = new System.Windows.Forms.RadioButton();
            this.IMC = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.btCalcula = new System.Windows.Forms.Button();
            this.lblImc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rd1
            // 
            this.rd1.AutoCheck = false;
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(225, 78);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(126, 17);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "Muito abaixo do peso";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoCheck = false;
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(225, 101);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(98, 17);
            this.rd2.TabIndex = 1;
            this.rd2.TabStop = true;
            this.rd2.Text = "Abaixo do peso";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.AutoCheck = false;
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(225, 124);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(74, 17);
            this.rd3.TabIndex = 2;
            this.rd3.TabStop = true;
            this.rd3.Text = "Peso ideal";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd4
            // 
            this.rd4.AutoCheck = false;
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(225, 147);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(95, 17);
            this.rd4.TabIndex = 3;
            this.rd4.TabStop = true;
            this.rd4.Text = "Acima do peso";
            this.rd4.UseVisualStyleBackColor = true;
            // 
            // rd5
            // 
            this.rd5.AutoCheck = false;
            this.rd5.AutoSize = true;
            this.rd5.Location = new System.Drawing.Point(225, 170);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(82, 17);
            this.rd5.TabIndex = 4;
            this.rd5.TabStop = true;
            this.rd5.Text = "Obesidade I";
            this.rd5.UseVisualStyleBackColor = true;
            // 
            // rd6
            // 
            this.rd6.AutoCheck = false;
            this.rd6.AutoSize = true;
            this.rd6.Location = new System.Drawing.Point(225, 193);
            this.rd6.Name = "rd6";
            this.rd6.Size = new System.Drawing.Size(85, 17);
            this.rd6.TabIndex = 5;
            this.rd6.TabStop = true;
            this.rd6.Text = "Obesidade II";
            this.rd6.UseVisualStyleBackColor = true;
            // 
            // rd7
            // 
            this.rd7.AutoCheck = false;
            this.rd7.AutoSize = true;
            this.rd7.Location = new System.Drawing.Point(225, 216);
            this.rd7.Name = "rd7";
            this.rd7.Size = new System.Drawing.Size(88, 17);
            this.rd7.TabIndex = 6;
            this.rd7.TabStop = true;
            this.rd7.Text = "Obesidade III";
            this.rd7.UseVisualStyleBackColor = true;
            // 
            // IMC
            // 
            this.IMC.AutoSize = true;
            this.IMC.Location = new System.Drawing.Point(222, 55);
            this.IMC.Name = "IMC";
            this.IMC.Size = new System.Drawing.Size(26, 13);
            this.IMC.TabIndex = 7;
            this.IMC.Text = "IMC";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(16, 30);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(55, 13);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "Peso (kg):";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(16, 55);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(54, 13);
            this.lblAltura.TabIndex = 9;
            this.lblAltura.Text = "Altura (m):";
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(77, 27);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(84, 20);
            this.tbPeso.TabIndex = 10;
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(77, 52);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(84, 20);
            this.tbAltura.TabIndex = 11;
            // 
            // btCalcula
            // 
            this.btCalcula.Location = new System.Drawing.Point(14, 90);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(184, 142);
            this.btCalcula.TabIndex = 12;
            this.btCalcula.Text = "Calcule";
            this.btCalcula.UseVisualStyleBackColor = true;
            this.btCalcula.Click += new System.EventHandler(this.btCalcula_Click);
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(254, 55);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(0, 13);
            this.lblImc.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 291);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.btCalcula);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.IMC);
            this.Controls.Add(this.rd7);
            this.Controls.Add(this.rd6);
            this.Controls.Add(this.rd5);
            this.Controls.Add(this.rd4);
            this.Controls.Add(this.rd3);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Name = "Form1";
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.RadioButton rd6;
        private System.Windows.Forms.RadioButton rd7;
        private System.Windows.Forms.Label IMC;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.Label lblImc;
    }
}

