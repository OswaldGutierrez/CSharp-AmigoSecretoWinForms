namespace Laboratorio_final_3
{
    partial class FormPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFechaDeInicio = new System.Windows.Forms.DateTimePicker();
            this.textBoxNumeroDeEndulzadas = new System.Windows.Forms.TextBox();
            this.textBoxFrecuenciaDeEndulzadas = new System.Windows.Forms.TextBox();
            this.textBoxValorDeRegalo = new System.Windows.Forms.TextBox();
            this.textBoxValorDeEndulzadas = new System.Windows.Forms.TextBox();
            this.dateFechaDeDescubrimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxCantidadDeJugadores = new System.Windows.Forms.TextBox();
            this.buttonInformacionDeJuego = new System.Windows.Forms.Button();
            this.buttonProximaEndulzada = new System.Windows.Forms.Button();
            this.buttonCrearJugadores = new System.Windows.Forms.Button();
            this.buttonAsignarAmigosSecretos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de jugadores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de descubrimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor de las endulzadas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Frecuencia en días de la endulzada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Número de endulzadas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor del regalo:";
            // 
            // dateFechaDeInicio
            // 
            this.dateFechaDeInicio.Location = new System.Drawing.Point(246, 188);
            this.dateFechaDeInicio.Name = "dateFechaDeInicio";
            this.dateFechaDeInicio.Size = new System.Drawing.Size(200, 20);
            this.dateFechaDeInicio.TabIndex = 15;
            // 
            // textBoxNumeroDeEndulzadas
            // 
            this.textBoxNumeroDeEndulzadas.Location = new System.Drawing.Point(246, 292);
            this.textBoxNumeroDeEndulzadas.Name = "textBoxNumeroDeEndulzadas";
            this.textBoxNumeroDeEndulzadas.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroDeEndulzadas.TabIndex = 21;
            this.textBoxNumeroDeEndulzadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeroDeEndulzadas_KeyPress);
            // 
            // textBoxFrecuenciaDeEndulzadas
            // 
            this.textBoxFrecuenciaDeEndulzadas.Location = new System.Drawing.Point(246, 344);
            this.textBoxFrecuenciaDeEndulzadas.Name = "textBoxFrecuenciaDeEndulzadas";
            this.textBoxFrecuenciaDeEndulzadas.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrecuenciaDeEndulzadas.TabIndex = 20;
            this.textBoxFrecuenciaDeEndulzadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFrecuenciaDeEndulzadas_KeyPress);
            // 
            // textBoxValorDeRegalo
            // 
            this.textBoxValorDeRegalo.Location = new System.Drawing.Point(246, 448);
            this.textBoxValorDeRegalo.Name = "textBoxValorDeRegalo";
            this.textBoxValorDeRegalo.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorDeRegalo.TabIndex = 19;
            this.textBoxValorDeRegalo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorDeRegalo_KeyPress);
            // 
            // textBoxValorDeEndulzadas
            // 
            this.textBoxValorDeEndulzadas.Location = new System.Drawing.Point(246, 396);
            this.textBoxValorDeEndulzadas.Name = "textBoxValorDeEndulzadas";
            this.textBoxValorDeEndulzadas.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorDeEndulzadas.TabIndex = 18;
            this.textBoxValorDeEndulzadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorDeEndulzadas_KeyPress);
            // 
            // dateFechaDeDescubrimiento
            // 
            this.dateFechaDeDescubrimiento.Location = new System.Drawing.Point(246, 240);
            this.dateFechaDeDescubrimiento.Name = "dateFechaDeDescubrimiento";
            this.dateFechaDeDescubrimiento.Size = new System.Drawing.Size(200, 20);
            this.dateFechaDeDescubrimiento.TabIndex = 17;
            // 
            // textBoxCantidadDeJugadores
            // 
            this.textBoxCantidadDeJugadores.Location = new System.Drawing.Point(246, 136);
            this.textBoxCantidadDeJugadores.Name = "textBoxCantidadDeJugadores";
            this.textBoxCantidadDeJugadores.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidadDeJugadores.TabIndex = 23;
            // 
            // buttonInformacionDeJuego
            // 
            this.buttonInformacionDeJuego.Location = new System.Drawing.Point(721, 247);
            this.buttonInformacionDeJuego.Name = "buttonInformacionDeJuego";
            this.buttonInformacionDeJuego.Size = new System.Drawing.Size(175, 23);
            this.buttonInformacionDeJuego.TabIndex = 24;
            this.buttonInformacionDeJuego.Text = "Información de juego";
            this.buttonInformacionDeJuego.UseVisualStyleBackColor = true;
            this.buttonInformacionDeJuego.Click += new System.EventHandler(this.buttonInformacionDeJuego_Click);
            // 
            // buttonProximaEndulzada
            // 
            this.buttonProximaEndulzada.Location = new System.Drawing.Point(721, 360);
            this.buttonProximaEndulzada.Name = "buttonProximaEndulzada";
            this.buttonProximaEndulzada.Size = new System.Drawing.Size(175, 23);
            this.buttonProximaEndulzada.TabIndex = 25;
            this.buttonProximaEndulzada.Text = "Próxima endulzada";
            this.buttonProximaEndulzada.UseVisualStyleBackColor = true;
            this.buttonProximaEndulzada.Click += new System.EventHandler(this.buttonProximaEndulzada_Click);
            // 
            // buttonCrearJugadores
            // 
            this.buttonCrearJugadores.Location = new System.Drawing.Point(721, 195);
            this.buttonCrearJugadores.Name = "buttonCrearJugadores";
            this.buttonCrearJugadores.Size = new System.Drawing.Size(175, 23);
            this.buttonCrearJugadores.TabIndex = 26;
            this.buttonCrearJugadores.Text = "Crear jugadores y sus gustos";
            this.buttonCrearJugadores.UseVisualStyleBackColor = true;
            this.buttonCrearJugadores.Click += new System.EventHandler(this.buttonCrearJugadores_Click);
            // 
            // buttonAsignarAmigosSecretos
            // 
            this.buttonAsignarAmigosSecretos.Location = new System.Drawing.Point(721, 299);
            this.buttonAsignarAmigosSecretos.Name = "buttonAsignarAmigosSecretos";
            this.buttonAsignarAmigosSecretos.Size = new System.Drawing.Size(175, 23);
            this.buttonAsignarAmigosSecretos.TabIndex = 27;
            this.buttonAsignarAmigosSecretos.Text = "Asignar amigos secretos";
            this.buttonAsignarAmigosSecretos.UseVisualStyleBackColor = true;
            this.buttonAsignarAmigosSecretos.Click += new System.EventHandler(this.buttonAsignarAmigosSecretos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(597, 79);
            this.label8.TabIndex = 29;
            this.label8.Text = "AMIGO SECRETO";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 566);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAsignarAmigosSecretos);
            this.Controls.Add(this.buttonCrearJugadores);
            this.Controls.Add(this.buttonProximaEndulzada);
            this.Controls.Add(this.buttonInformacionDeJuego);
            this.Controls.Add(this.textBoxCantidadDeJugadores);
            this.Controls.Add(this.textBoxNumeroDeEndulzadas);
            this.Controls.Add(this.textBoxFrecuenciaDeEndulzadas);
            this.Controls.Add(this.textBoxValorDeRegalo);
            this.Controls.Add(this.textBoxValorDeEndulzadas);
            this.Controls.Add(this.dateFechaDeDescubrimiento);
            this.Controls.Add(this.dateFechaDeInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFechaDeInicio;
        private System.Windows.Forms.TextBox textBoxNumeroDeEndulzadas;
        private System.Windows.Forms.TextBox textBoxFrecuenciaDeEndulzadas;
        private System.Windows.Forms.TextBox textBoxValorDeRegalo;
        private System.Windows.Forms.TextBox textBoxValorDeEndulzadas;
        private System.Windows.Forms.DateTimePicker dateFechaDeDescubrimiento;
        private System.Windows.Forms.TextBox textBoxCantidadDeJugadores;
        private System.Windows.Forms.Button buttonInformacionDeJuego;
        private System.Windows.Forms.Button buttonProximaEndulzada;
        private System.Windows.Forms.Button buttonCrearJugadores;
        private System.Windows.Forms.Button buttonAsignarAmigosSecretos;
        private System.Windows.Forms.Label label8;
    }
}

