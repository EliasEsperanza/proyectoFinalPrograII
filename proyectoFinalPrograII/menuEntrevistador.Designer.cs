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
            this.SuspendLayout();
            // 
            // BTN_asignacion
            // 
            this.BTN_asignacion.Location = new System.Drawing.Point(77, 63);
            this.BTN_asignacion.Name = "BTN_asignacion";
            this.BTN_asignacion.Size = new System.Drawing.Size(175, 37);
            this.BTN_asignacion.TabIndex = 0;
            this.BTN_asignacion.Text = "Asignacion de preguntas";
            this.BTN_asignacion.UseVisualStyleBackColor = true;
            // 
            // BTN_Evaluar
            // 
            this.BTN_Evaluar.Location = new System.Drawing.Point(77, 146);
            this.BTN_Evaluar.Name = "BTN_Evaluar";
            this.BTN_Evaluar.Size = new System.Drawing.Size(175, 36);
            this.BTN_Evaluar.TabIndex = 1;
            this.BTN_Evaluar.Text = "Evaluar aspirante";
            this.BTN_Evaluar.UseVisualStyleBackColor = true;
            // 
            // BTN_Resultados
            // 
            this.BTN_Resultados.Location = new System.Drawing.Point(77, 229);
            this.BTN_Resultados.Name = "BTN_Resultados";
            this.BTN_Resultados.Size = new System.Drawing.Size(175, 37);
            this.BTN_Resultados.TabIndex = 2;
            this.BTN_Resultados.Text = "Ver resultados";
            this.BTN_Resultados.UseVisualStyleBackColor = true;
            // 
            // menuEntrevistador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 356);
            this.Controls.Add(this.BTN_Resultados);
            this.Controls.Add(this.BTN_Evaluar);
            this.Controls.Add(this.BTN_asignacion);
            this.Name = "menuEntrevistador";
            this.Text = "Menu Entrevistador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_asignacion;
        private System.Windows.Forms.Button BTN_Evaluar;
        private System.Windows.Forms.Button BTN_Resultados;
    }
}