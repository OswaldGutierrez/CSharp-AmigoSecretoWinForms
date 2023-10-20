namespace Laboratorio_final_3
{
    partial class FormProximaEndulzada
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
            this.dateCalcularFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalcularProxEndulzada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateCalcularFecha
            // 
            this.dateCalcularFecha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCalcularFecha.Location = new System.Drawing.Point(155, 103);
            this.dateCalcularFecha.Name = "dateCalcularFecha";
            this.dateCalcularFecha.Size = new System.Drawing.Size(200, 25);
            this.dateCalcularFecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un día:";
            // 
            // buttonCalcularProxEndulzada
            // 
            this.buttonCalcularProxEndulzada.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcularProxEndulzada.Location = new System.Drawing.Point(96, 188);
            this.buttonCalcularProxEndulzada.Name = "buttonCalcularProxEndulzada";
            this.buttonCalcularProxEndulzada.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcularProxEndulzada.TabIndex = 2;
            this.buttonCalcularProxEndulzada.Text = "Calcular";
            this.buttonCalcularProxEndulzada.UseVisualStyleBackColor = true;
            this.buttonCalcularProxEndulzada.Click += new System.EventHandler(this.buttonCalcularProxEndulzada_Click);
            // 
            // FormProximaEndulzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 284);
            this.Controls.Add(this.buttonCalcularProxEndulzada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateCalcularFecha);
            this.Name = "FormProximaEndulzada";
            this.Text = "ProximaEndulzada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateCalcularFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalcularProxEndulzada;
    }
}