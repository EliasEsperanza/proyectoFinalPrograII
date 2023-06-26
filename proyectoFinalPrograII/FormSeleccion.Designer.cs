namespace proyectoFinalPrograII
{
    partial class FormSeleccion
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
            this.ButtonVerVacante = new System.Windows.Forms.Button();
            this.ButtonAspirantes = new System.Windows.Forms.Button();
            this.ButtonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonVerVacante
            // 
            this.ButtonVerVacante.Location = new System.Drawing.Point(102, 55);
            this.ButtonVerVacante.Name = "ButtonVerVacante";
            this.ButtonVerVacante.Size = new System.Drawing.Size(158, 34);
            this.ButtonVerVacante.TabIndex = 0;
            this.ButtonVerVacante.Text = "Ver Vacantes";
            this.ButtonVerVacante.UseVisualStyleBackColor = true;
            this.ButtonVerVacante.Click += new System.EventHandler(this.ButtonVerVacante_Click);
            // 
            // ButtonAspirantes
            // 
            this.ButtonAspirantes.Location = new System.Drawing.Point(102, 133);
            this.ButtonAspirantes.Name = "ButtonAspirantes";
            this.ButtonAspirantes.Size = new System.Drawing.Size(158, 34);
            this.ButtonAspirantes.TabIndex = 1;
            this.ButtonAspirantes.Text = "Ver Aspirantes";
            this.ButtonAspirantes.UseVisualStyleBackColor = true;
            this.ButtonAspirantes.Click += new System.EventHandler(this.ButtonAspirantes_Click);
            // 
            // ButtonRegresar
            // 
            this.ButtonRegresar.Location = new System.Drawing.Point(283, 235);
            this.ButtonRegresar.Name = "ButtonRegresar";
            this.ButtonRegresar.Size = new System.Drawing.Size(88, 23);
            this.ButtonRegresar.TabIndex = 3;
            this.ButtonRegresar.Text = "Regresa ";
            this.ButtonRegresar.UseVisualStyleBackColor = true;
            this.ButtonRegresar.Click += new System.EventHandler(this.ButtonRegresar_Click);
            // 
            // FormSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 270);
            this.Controls.Add(this.ButtonRegresar);
            this.Controls.Add(this.ButtonAspirantes);
            this.Controls.Add(this.ButtonVerVacante);
            this.Name = "FormSeleccion";
            this.Text = "FormSeleccion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonVerVacante;
        private System.Windows.Forms.Button ButtonAspirantes;
        private System.Windows.Forms.Button ButtonRegresar;
    }
}