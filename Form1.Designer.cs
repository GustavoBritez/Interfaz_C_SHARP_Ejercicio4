namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Enunciado = new System.Windows.Forms.Label();
            this.TX_1 = new System.Windows.Forms.TextBox();
            this.LB_1 = new System.Windows.Forms.Label();
            this.TX_2 = new System.Windows.Forms.TextBox();
            this.LB_2 = new System.Windows.Forms.Label();
            this.TX_Resultado = new System.Windows.Forms.TextBox();
            this.BTN_Suma = new System.Windows.Forms.CheckBox();
            this.BTN_Resta = new System.Windows.Forms.CheckBox();
            this.BTN_Multi = new System.Windows.Forms.CheckBox();
            this.BTN_Divisor = new System.Windows.Forms.CheckBox();
            this.BTN_Raiz = new System.Windows.Forms.CheckBox();
            this.RESULTADO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enunciado
            // 
            this.Enunciado.AllowDrop = true;
            this.Enunciado.AutoEllipsis = true;
            this.Enunciado.Enabled = false;
            this.Enunciado.Location = new System.Drawing.Point(17, 9);
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.Size = new System.Drawing.Size(501, 47);
            this.Enunciado.TabIndex = 0;
            this.Enunciado.Text = resources.GetString("Enunciado.Text");
            this.Enunciado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Enunciado.UseCompatibleTextRendering = true;
            // 
            // TX_1
            // 
            this.TX_1.Location = new System.Drawing.Point(192, 59);
            this.TX_1.Name = "TX_1";
            this.TX_1.Size = new System.Drawing.Size(182, 20);
            this.TX_1.TabIndex = 1;
            this.TX_1.TextChanged += new System.EventHandler(this.TX_1_TextChanged);
            // 
            // LB_1
            // 
            this.LB_1.AutoSize = true;
            this.LB_1.Location = new System.Drawing.Point(123, 62);
            this.LB_1.Name = "LB_1";
            this.LB_1.Size = new System.Drawing.Size(63, 13);
            this.LB_1.TabIndex = 2;
            this.LB_1.Text = "Operando 1";
            // 
            // TX_2
            // 
            this.TX_2.Location = new System.Drawing.Point(192, 85);
            this.TX_2.Name = "TX_2";
            this.TX_2.Size = new System.Drawing.Size(182, 20);
            this.TX_2.TabIndex = 3;
            // 
            // LB_2
            // 
            this.LB_2.AutoSize = true;
            this.LB_2.Location = new System.Drawing.Point(123, 88);
            this.LB_2.Name = "LB_2";
            this.LB_2.Size = new System.Drawing.Size(63, 13);
            this.LB_2.TabIndex = 4;
            this.LB_2.Text = "Operando 2";
            // 
            // TX_Resultado
            // 
            this.TX_Resultado.Location = new System.Drawing.Point(192, 126);
            this.TX_Resultado.Name = "TX_Resultado";
            this.TX_Resultado.Size = new System.Drawing.Size(182, 20);
            this.TX_Resultado.TabIndex = 5;
            // 
            // BTN_Suma
            // 
            this.BTN_Suma.AutoSize = true;
            this.BTN_Suma.Location = new System.Drawing.Point(415, 61);
            this.BTN_Suma.Name = "BTN_Suma";
            this.BTN_Suma.Size = new System.Drawing.Size(53, 17);
            this.BTN_Suma.TabIndex = 17;
            this.BTN_Suma.Text = "Suma";
            this.BTN_Suma.UseVisualStyleBackColor = true;
            // 
            // BTN_Resta
            // 
            this.BTN_Resta.AutoSize = true;
            this.BTN_Resta.Location = new System.Drawing.Point(415, 84);
            this.BTN_Resta.Name = "BTN_Resta";
            this.BTN_Resta.Size = new System.Drawing.Size(54, 17);
            this.BTN_Resta.TabIndex = 18;
            this.BTN_Resta.Text = "Resta";
            this.BTN_Resta.UseVisualStyleBackColor = true;
            // 
            // BTN_Multi
            // 
            this.BTN_Multi.AutoSize = true;
            this.BTN_Multi.Location = new System.Drawing.Point(415, 111);
            this.BTN_Multi.Name = "BTN_Multi";
            this.BTN_Multi.Size = new System.Drawing.Size(48, 17);
            this.BTN_Multi.TabIndex = 19;
            this.BTN_Multi.Text = "Multi";
            this.BTN_Multi.UseVisualStyleBackColor = true;
            // 
            // BTN_Divisor
            // 
            this.BTN_Divisor.AutoSize = true;
            this.BTN_Divisor.Location = new System.Drawing.Point(415, 134);
            this.BTN_Divisor.Name = "BTN_Divisor";
            this.BTN_Divisor.Size = new System.Drawing.Size(58, 17);
            this.BTN_Divisor.TabIndex = 20;
            this.BTN_Divisor.Text = "Divisor";
            this.BTN_Divisor.UseVisualStyleBackColor = true;
            // 
            // BTN_Raiz
            // 
            this.BTN_Raiz.AutoSize = true;
            this.BTN_Raiz.Location = new System.Drawing.Point(415, 157);
            this.BTN_Raiz.Name = "BTN_Raiz";
            this.BTN_Raiz.Size = new System.Drawing.Size(47, 17);
            this.BTN_Raiz.TabIndex = 21;
            this.BTN_Raiz.Text = "Raiz";
            this.BTN_Raiz.UseVisualStyleBackColor = true;
            // 
            // RESULTADO
            // 
            this.RESULTADO.Location = new System.Drawing.Point(111, 123);
            this.RESULTADO.Name = "RESULTADO";
            this.RESULTADO.Size = new System.Drawing.Size(75, 23);
            this.RESULTADO.TabIndex = 22;
            this.RESULTADO.Text = "Resultado";
            this.RESULTADO.UseVisualStyleBackColor = true;
            this.RESULTADO.Click += new System.EventHandler(this.RESULTADO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 191);
            this.Controls.Add(this.RESULTADO);
            this.Controls.Add(this.BTN_Raiz);
            this.Controls.Add(this.BTN_Divisor);
            this.Controls.Add(this.BTN_Multi);
            this.Controls.Add(this.BTN_Resta);
            this.Controls.Add(this.BTN_Suma);
            this.Controls.Add(this.TX_Resultado);
            this.Controls.Add(this.LB_2);
            this.Controls.Add(this.TX_2);
            this.Controls.Add(this.LB_1);
            this.Controls.Add(this.TX_1);
            this.Controls.Add(this.Enunciado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enunciado;
        private System.Windows.Forms.TextBox TX_1;
        private System.Windows.Forms.Label LB_1;
        private System.Windows.Forms.TextBox TX_2;
        private System.Windows.Forms.Label LB_2;
        private System.Windows.Forms.TextBox TX_Resultado;
        private System.Windows.Forms.CheckBox BTN_Suma;
        private System.Windows.Forms.CheckBox BTN_Resta;
        private System.Windows.Forms.CheckBox BTN_Multi;
        private System.Windows.Forms.CheckBox BTN_Divisor;
        private System.Windows.Forms.CheckBox BTN_Raiz;
        private System.Windows.Forms.Button RESULTADO;
    }
}

