namespace proyectoFinalPrograII
{
    partial class menuEntrevistador
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
            this.BTN_asignacion = new System.Windows.Forms.Button();
            this.BTN_Evaluar = new System.Windows.Forms.Button();
            this.BTN_Resultados = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_asignacion
            // 
            this.BTN_asignacion.Location = new System.Drawing.Point(103, 76);
            this.BTN_asignacion.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_asignacion.Name = "BTN_asignacion";
            this.BTN_asignacion.Size = new System.Drawing.Size(233, 46);
            this.BTN_asignacion.TabIndex = 0;
            this.BTN_asignacion.Text = "Asignacion de preguntas";
            this.BTN_asignacion.UseVisualStyleBackColor = true;
            this.BTN_asignacion.Click += new System.EventHandler(this.BTN_asignacion_Click);
            // 
            // BTN_Evaluar
            // 
            this.BTN_Evaluar.Location = new System.Drawing.Point(103, 180);
            this.BTN_Evaluar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Evaluar.Name = "BTN_Evaluar";
            this.BTN_Evaluar.Size = new System.Drawing.Size(233, 44);
            this.BTN_Evaluar.TabIndex = 1;
            this.BTN_Evaluar.Text = "Evaluar aspirante";
            this.BTN_Evaluar.UseVisualStyleBackColor = true;
            this.BTN_Evaluar.Click += new System.EventHandler(this.BTN_Evaluar_Click);
            // 
            // BTN_Resultados
            // 
            this.BTN_Resultados.Location = new System.Drawing.Point(103, 282);
            this.BTN_Resultados.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Resultados.Name = "BTN_Resultados";
            this.BTN_Resultados.Size = new System.Drawing.Size(233, 46);
            this.BTN_Resultados.TabIndex = 2;
            this.BTN_Resultados.Text = "Ver resultados";
            this.BTN_Resultados.UseVisualStyleBackColor = true;
            this.BTN_Resultados.Click += new System.EventHandler(this.BTN_Resultados_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(369, 403);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 3;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // menuEntrevistador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 438);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.BTN_Resultados);
            this.Controls.Add(this.BTN_Evaluar);
            this.Controls.Add(this.BTN_asignacion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menuEntrevistador";
            this.Text = "Menu Entrevistador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_asignacion;
        private System.Windows.Forms.Button BTN_Evaluar;
        private System.Windows.Forms.Button BTN_Resultados;
        private System.Windows.Forms.Button buttonRegresar;
    }
}