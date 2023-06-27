namespace proyectoFinalPrograII
{
    partial class ModificarAspirante
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
            this.components = new System.ComponentModel.Container();
            this.ButtonRegresar = new System.Windows.Forms.Button();
            this.ButtonModificar = new System.Windows.Forms.Button();
            this.tbRangoPisto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDatAcademico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDatGenerales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRegresar
            // 
            this.ButtonRegresar.Location = new System.Drawing.Point(324, 378);
            this.ButtonRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonRegresar.Name = "ButtonRegresar";
            this.ButtonRegresar.Size = new System.Drawing.Size(100, 28);
            this.ButtonRegresar.TabIndex = 27;
            this.ButtonRegresar.Text = "Regresar";
            this.ButtonRegresar.UseVisualStyleBackColor = true;
            this.ButtonRegresar.Click += new System.EventHandler(this.ButtonRegresar_Click);
            // 
            // ButtonModificar
            // 
            this.ButtonModificar.Location = new System.Drawing.Point(76, 282);
            this.ButtonModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonModificar.Name = "ButtonModificar";
            this.ButtonModificar.Size = new System.Drawing.Size(247, 47);
            this.ButtonModificar.TabIndex = 26;
            this.ButtonModificar.Text = "Modificar";
            this.ButtonModificar.UseVisualStyleBackColor = true;
            this.ButtonModificar.Click += new System.EventHandler(this.ButtonModificar_Click);
            // 
            // tbRangoPisto
            // 
            this.tbRangoPisto.Location = new System.Drawing.Point(31, 164);
            this.tbRangoPisto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRangoPisto.Name = "tbRangoPisto";
            this.tbRangoPisto.Size = new System.Drawing.Size(308, 22);
            this.tbRangoPisto.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Rango de Preteciones Salariales:";
            // 
            // tbDatAcademico
            // 
            this.tbDatAcademico.Location = new System.Drawing.Point(31, 103);
            this.tbDatAcademico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDatAcademico.Name = "tbDatAcademico";
            this.tbDatAcademico.Size = new System.Drawing.Size(308, 22);
            this.tbDatAcademico.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Datos de Niveles Academica:";
            // 
            // tbDatGenerales
            // 
            this.tbDatGenerales.Location = new System.Drawing.Point(31, 42);
            this.tbDatGenerales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDatGenerales.Name = "tbDatGenerales";
            this.tbDatGenerales.Size = new System.Drawing.Size(308, 22);
            this.tbDatGenerales.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Datos generales de la persona:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModificarAspirante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 425);
            this.Controls.Add(this.ButtonRegresar);
            this.Controls.Add(this.ButtonModificar);
            this.Controls.Add(this.tbRangoPisto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDatAcademico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDatGenerales);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificarAspirante";
            this.Text = "ModificarAspirante";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonRegresar;
        private System.Windows.Forms.Button ButtonModificar;
        private System.Windows.Forms.TextBox tbRangoPisto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDatAcademico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDatGenerales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}