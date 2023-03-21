using System;

namespace Operaciones
{
    partial class Operaciones
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
            this.boton_Calcular = new System.Windows.Forms.Button();
            this.txt_Calculadora = new System.Windows.Forms.Label();
            this.ingresar_Num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.Label();
            this.text_signo = new System.Windows.Forms.Label();
            this.ingresar_Num1 = new System.Windows.Forms.TextBox();
            this.txt_signoIgual = new System.Windows.Forms.Label();
            this.Boton_Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_Calcular
            // 
            this.boton_Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.boton_Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_Calcular.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Calcular.ForeColor = System.Drawing.SystemColors.Highlight;
            this.boton_Calcular.Location = new System.Drawing.Point(251, 293);
            this.boton_Calcular.Name = "boton_Calcular";
            this.boton_Calcular.Size = new System.Drawing.Size(207, 42);
            this.boton_Calcular.TabIndex = 0;
            this.boton_Calcular.Text = "Calcular";
            this.boton_Calcular.UseVisualStyleBackColor = false;
            this.boton_Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Calculadora
            // 
            this.txt_Calculadora.AutoSize = true;
            this.txt_Calculadora.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Calculadora.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Calculadora.Location = new System.Drawing.Point(262, 31);
            this.txt_Calculadora.Name = "txt_Calculadora";
            this.txt_Calculadora.Size = new System.Drawing.Size(244, 39);
            this.txt_Calculadora.TabIndex = 2;
            this.txt_Calculadora.Text = "CALCULADORA";
            // 
            // ingresar_Num2
            // 
            this.ingresar_Num2.Location = new System.Drawing.Point(278, 180);
            this.ingresar_Num2.Name = "ingresar_Num2";
            this.ingresar_Num2.Size = new System.Drawing.Size(136, 20);
            this.ingresar_Num2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Primer Numero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Segundo Numero";
            // 
            // txt_resultado
            // 
            this.txt_resultado.AutoSize = true;
            this.txt_resultado.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.Location = new System.Drawing.Point(489, 153);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(81, 39);
            this.txt_resultado.TabIndex = 9;
            this.txt_resultado.Text = "----";
            this.txt_resultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_signo
            // 
            this.text_signo.AutoSize = true;
            this.text_signo.Font = new System.Drawing.Font("Brush Script MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_signo.Location = new System.Drawing.Point(246, 153);
            this.text_signo.Name = "text_signo";
            this.text_signo.Size = new System.Drawing.Size(26, 26);
            this.text_signo.TabIndex = 10;
            this.text_signo.Text = "+";
            // 
            // ingresar_Num1
            // 
            this.ingresar_Num1.Location = new System.Drawing.Point(278, 137);
            this.ingresar_Num1.Name = "ingresar_Num1";
            this.ingresar_Num1.Size = new System.Drawing.Size(136, 20);
            this.ingresar_Num1.TabIndex = 11;
            // 
            // txt_signoIgual
            // 
            this.txt_signoIgual.AutoSize = true;
            this.txt_signoIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_signoIgual.Location = new System.Drawing.Point(438, 154);
            this.txt_signoIgual.Name = "txt_signoIgual";
            this.txt_signoIgual.Size = new System.Drawing.Size(24, 25);
            this.txt_signoIgual.TabIndex = 12;
            this.txt_signoIgual.Text = "=";
            // 
            // Boton_Limpiar
            // 
            this.Boton_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Boton_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Limpiar.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Limpiar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Boton_Limpiar.Location = new System.Drawing.Point(581, 387);
            this.Boton_Limpiar.Name = "Boton_Limpiar";
            this.Boton_Limpiar.Size = new System.Drawing.Size(207, 42);
            this.Boton_Limpiar.TabIndex = 13;
            this.Boton_Limpiar.Text = "Limpiar";
            this.Boton_Limpiar.UseVisualStyleBackColor = false;
            this.Boton_Limpiar.Click += new System.EventHandler(this.Boton_Limpiar_Click);
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton_Limpiar);
            this.Controls.Add(this.txt_signoIgual);
            this.Controls.Add(this.ingresar_Num1);
            this.Controls.Add(this.text_signo);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingresar_Num2);
            this.Controls.Add(this.txt_Calculadora);
            this.Controls.Add(this.boton_Calcular);
            this.Name = "Operaciones";
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        

        #endregion

        private System.Windows.Forms.Button boton_Calcular;
        private System.Windows.Forms.Label txt_Calculadora;
        private System.Windows.Forms.TextBox ingresar_Num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_resultado;
        private System.Windows.Forms.Label text_signo;
        private System.Windows.Forms.TextBox ingresar_Num1;
        private System.Windows.Forms.Label txt_signoIgual;
        private System.Windows.Forms.Button Boton_Limpiar;
    }
}

