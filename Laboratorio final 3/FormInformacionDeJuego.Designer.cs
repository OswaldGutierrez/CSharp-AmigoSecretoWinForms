namespace Laboratorio_final_3
{
    partial class FormInformacionDeJuego
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCantidadDeJugadores = new System.Windows.Forms.Label();
            this.labelNumeroDeEndulzadas = new System.Windows.Forms.Label();
            this.labelFrecuenciaDeEndulzadas = new System.Windows.Forms.Label();
            this.labelValorEndulzada = new System.Windows.Forms.Label();
            this.labelValorRegalo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "El regalo final tendrá un valor de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cada endulzada tendrá un valor de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "La frecuencia de las  endulzadas en días es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "El número de endulzadas que se darán durante el juego es:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "La cantidad de jugadores que hacen parte de \'Amigo Secreto\' es:";
            // 
            // labelCantidadDeJugadores
            // 
            this.labelCantidadDeJugadores.AutoSize = true;
            this.labelCantidadDeJugadores.Location = new System.Drawing.Point(408, 57);
            this.labelCantidadDeJugadores.Name = "labelCantidadDeJugadores";
            this.labelCantidadDeJugadores.Size = new System.Drawing.Size(35, 13);
            this.labelCantidadDeJugadores.TabIndex = 20;
            this.labelCantidadDeJugadores.Text = "label6";
            // 
            // labelNumeroDeEndulzadas
            // 
            this.labelNumeroDeEndulzadas.AutoSize = true;
            this.labelNumeroDeEndulzadas.Location = new System.Drawing.Point(408, 107);
            this.labelNumeroDeEndulzadas.Name = "labelNumeroDeEndulzadas";
            this.labelNumeroDeEndulzadas.Size = new System.Drawing.Size(35, 13);
            this.labelNumeroDeEndulzadas.TabIndex = 21;
            this.labelNumeroDeEndulzadas.Text = "label7";
            // 
            // labelFrecuenciaDeEndulzadas
            // 
            this.labelFrecuenciaDeEndulzadas.AutoSize = true;
            this.labelFrecuenciaDeEndulzadas.Location = new System.Drawing.Point(408, 159);
            this.labelFrecuenciaDeEndulzadas.Name = "labelFrecuenciaDeEndulzadas";
            this.labelFrecuenciaDeEndulzadas.Size = new System.Drawing.Size(35, 13);
            this.labelFrecuenciaDeEndulzadas.TabIndex = 22;
            this.labelFrecuenciaDeEndulzadas.Text = "label8";
            // 
            // labelValorEndulzada
            // 
            this.labelValorEndulzada.AutoSize = true;
            this.labelValorEndulzada.Location = new System.Drawing.Point(408, 212);
            this.labelValorEndulzada.Name = "labelValorEndulzada";
            this.labelValorEndulzada.Size = new System.Drawing.Size(35, 13);
            this.labelValorEndulzada.TabIndex = 23;
            this.labelValorEndulzada.Text = "label9";
            // 
            // labelValorRegalo
            // 
            this.labelValorRegalo.AutoSize = true;
            this.labelValorRegalo.Location = new System.Drawing.Point(408, 263);
            this.labelValorRegalo.Name = "labelValorRegalo";
            this.labelValorRegalo.Size = new System.Drawing.Size(41, 13);
            this.labelValorRegalo.TabIndex = 24;
            this.labelValorRegalo.Text = "label10";
            // 
            // FormInformacionDeJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 335);
            this.Controls.Add(this.labelValorRegalo);
            this.Controls.Add(this.labelValorEndulzada);
            this.Controls.Add(this.labelFrecuenciaDeEndulzadas);
            this.Controls.Add(this.labelNumeroDeEndulzadas);
            this.Controls.Add(this.labelCantidadDeJugadores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInformacionDeJuego";
            this.Text = "FormInformacionDeJuego";
            this.Load += new System.EventHandler(this.FormInformacionDeJuego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCantidadDeJugadores;
        private System.Windows.Forms.Label labelNumeroDeEndulzadas;
        private System.Windows.Forms.Label labelFrecuenciaDeEndulzadas;
        private System.Windows.Forms.Label labelValorEndulzada;
        private System.Windows.Forms.Label labelValorRegalo;
    }
}