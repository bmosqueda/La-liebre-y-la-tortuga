namespace La_liebre_y_la_tortuga
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
            this.txtCarrera = new System.Windows.Forms.RichTextBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.lblGanador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(66, 63);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(342, 415);
            this.txtCarrera.TabIndex = 0;
            this.txtCarrera.Text = "";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(143, 14);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(206, 35);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "¡Comenzar carrera!";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Location = new System.Drawing.Point(62, 493);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(76, 20);
            this.lblGanador.TabIndex = 2;
            this.lblGanador.Text = "Ganador:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 533);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.txtCarrera);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La liebre y la tortuga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCarrera;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label lblGanador;
    }
}

