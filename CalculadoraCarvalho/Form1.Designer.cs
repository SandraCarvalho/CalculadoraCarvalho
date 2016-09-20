namespace CalculadoraCarvalho
{
    partial class Form1
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
            this.numeroA = new System.Windows.Forms.Label();
            this.numeroB = new System.Windows.Forms.Label();
            this.textBoxNumeroA = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.textBoxNumeroB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numeroA
            // 
            this.numeroA.AutoSize = true;
            this.numeroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroA.Location = new System.Drawing.Point(36, 40);
            this.numeroA.Name = "numeroA";
            this.numeroA.Size = new System.Drawing.Size(106, 25);
            this.numeroA.TabIndex = 1;
            this.numeroA.Text = "Número A:";
            // 
            // numeroB
            // 
            this.numeroB.AutoSize = true;
            this.numeroB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroB.Location = new System.Drawing.Point(36, 104);
            this.numeroB.Name = "numeroB";
            this.numeroB.Size = new System.Drawing.Size(105, 25);
            this.numeroB.TabIndex = 2;
            this.numeroB.Text = "Número B:";
            // 
            // textBoxNumeroA
            // 
            this.textBoxNumeroA.Location = new System.Drawing.Point(161, 44);
            this.textBoxNumeroA.Name = "textBoxNumeroA";
            this.textBoxNumeroA.Size = new System.Drawing.Size(379, 22);
            this.textBoxNumeroA.TabIndex = 3;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(38, 288);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(105, 25);
            this.resultado.TabIndex = 15;
            this.resultado.Text = "Resultado:";
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(149, 288);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(379, 22);
            this.textBoxResultado.TabIndex = 14;
            // 
            // btnFactorial
            // 
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.Location = new System.Drawing.Point(453, 173);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(75, 62);
            this.btnFactorial.TabIndex = 13;
            this.btnFactorial.Text = "A!";
            this.btnFactorial.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(315, 173);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 62);
            this.btnMultiplicar.TabIndex = 12;
            this.btnMultiplicar.Text = "A * B";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(171, 173);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 62);
            this.btnSubtrair.TabIndex = 11;
            this.btnSubtrair.Text = "A - B";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(41, 174);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 61);
            this.btnSomar.TabIndex = 10;
            this.btnSomar.Text = "A + B";
            this.btnSomar.UseVisualStyleBackColor = true;
            // 
            // textBoxNumeroB
            // 
            this.textBoxNumeroB.Location = new System.Drawing.Point(161, 108);
            this.textBoxNumeroB.Name = "textBoxNumeroB";
            this.textBoxNumeroB.Size = new System.Drawing.Size(379, 22);
            this.textBoxNumeroB.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 338);
            this.Controls.Add(this.textBoxNumeroB);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.textBoxNumeroA);
            this.Controls.Add(this.numeroB);
            this.Controls.Add(this.numeroA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroA;
        private System.Windows.Forms.Label numeroB;
        private System.Windows.Forms.TextBox textBoxNumeroA;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox textBoxNumeroB;
    }
}

