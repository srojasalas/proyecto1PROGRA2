using System;

namespace proyecto1PROGRA2
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lnum1 = new System.Windows.Forms.Label();
            this.lop = new System.Windows.Forms.Label();
            this.lnum2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tresultado = new System.Windows.Forms.TextBox();
            this.Baceptar = new System.Windows.Forms.Button();
            this.nivel = new System.Windows.Forms.Label();
            this.lnivel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.laciertos = new System.Windows.Forms.Label();
            this.lfallos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROYECTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lfallos);
            this.panel1.Controls.Add(this.laciertos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lnivel);
            this.panel1.Controls.Add(this.nivel);
            this.panel1.Controls.Add(this.Baceptar);
            this.panel1.Controls.Add(this.tresultado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lnum2);
            this.panel1.Controls.Add(this.lop);
            this.panel1.Controls.Add(this.lnum1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(37, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 440);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "OPERACIÓN";
            // 
            // lnum1
            // 
            this.lnum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnum1.Location = new System.Drawing.Point(71, 107);
            this.lnum1.Name = "lnum1";
            this.lnum1.Size = new System.Drawing.Size(52, 16);
            this.lnum1.TabIndex = 1;
            // 
            // lop
            // 
            this.lop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lop.Location = new System.Drawing.Point(155, 106);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(53, 17);
            this.lop.TabIndex = 2;
            // 
            // lnum2
            // 
            this.lnum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnum2.Location = new System.Drawing.Point(247, 107);
            this.lnum2.Name = "lnum2";
            this.lnum2.Size = new System.Drawing.Size(51, 16);
            this.lnum2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escriba el resultado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tresultado
            // 
            this.tresultado.Location = new System.Drawing.Point(239, 154);
            this.tresultado.Name = "tresultado";
            this.tresultado.Size = new System.Drawing.Size(150, 22);
            this.tresultado.TabIndex = 7;
            // 
            // Baceptar
            // 
            this.Baceptar.Location = new System.Drawing.Point(70, 196);
            this.Baceptar.Name = "Baceptar";
            this.Baceptar.Size = new System.Drawing.Size(169, 75);
            this.Baceptar.TabIndex = 8;
            this.Baceptar.Text = "Aceptar";
            this.Baceptar.UseVisualStyleBackColor = true;
            this.Baceptar.Click += new System.EventHandler(this.Baceptar_Click);
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.Location = new System.Drawing.Point(562, 51);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(59, 18);
            this.nivel.TabIndex = 9;
            this.nivel.Text = "NIVEL:";
            // 
            // lnivel
            // 
            this.lnivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnivel.Location = new System.Drawing.Point(627, 51);
            this.lnivel.Name = "lnivel";
            this.lnivel.Size = new System.Drawing.Size(63, 18);
            this.lnivel.TabIndex = 10;
            this.lnivel.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "ACIERTOS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "FALLOS:";
            // 
            // laciertos
            // 
            this.laciertos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.laciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laciertos.Location = new System.Drawing.Point(627, 85);
            this.laciertos.Name = "laciertos";
            this.laciertos.Size = new System.Drawing.Size(63, 18);
            this.laciertos.TabIndex = 13;
            this.laciertos.Text = "0";
            // 
            // lfallos
            // 
            this.lfallos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lfallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfallos.Location = new System.Drawing.Point(627, 117);
            this.lfallos.Name = "lfallos";
            this.lfallos.Size = new System.Drawing.Size(63, 18);
            this.lfallos.TabIndex = 14;
            this.lfallos.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lnum2;
        private System.Windows.Forms.Label lop;
        private System.Windows.Forms.Label lnum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Baceptar;
        private System.Windows.Forms.TextBox tresultado;
        private System.Windows.Forms.Label lnivel;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Label lfallos;
        private System.Windows.Forms.Label laciertos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

