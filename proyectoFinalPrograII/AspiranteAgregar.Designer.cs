﻿namespace proyectoFinalPrograII
{
    partial class AspiranteAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDatGenerales = new System.Windows.Forms.TextBox();
            this.tbDatAcademico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRangoPisto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonAgregar = new System.Windows.Forms.Button();
            this.ButtonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos generales de la persona:";
            // 
            // tbDatGenerales
            // 
            this.tbDatGenerales.Location = new System.Drawing.Point(39, 48);
            this.tbDatGenerales.Name = "tbDatGenerales";
            this.tbDatGenerales.Size = new System.Drawing.Size(232, 20);
            this.tbDatGenerales.TabIndex = 1;
            // 
            // tbDatAcademico
            // 
            this.tbDatAcademico.Location = new System.Drawing.Point(39, 109);
            this.tbDatAcademico.Name = "tbDatAcademico";
            this.tbDatAcademico.Size = new System.Drawing.Size(232, 20);
            this.tbDatAcademico.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datos de Niveles Academica:";
            // 
            // tbRangoPisto
            // 
            this.tbRangoPisto.Location = new System.Drawing.Point(39, 166);
            this.tbRangoPisto.Name = "tbRangoPisto";
            this.tbRangoPisto.Size = new System.Drawing.Size(232, 20);
            this.tbRangoPisto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rango de Preteciones Salariales:";
            // 
            // ButtonAgregar
            // 
            this.ButtonAgregar.Location = new System.Drawing.Point(73, 243);
            this.ButtonAgregar.Name = "ButtonAgregar";
            this.ButtonAgregar.Size = new System.Drawing.Size(185, 38);
            this.ButtonAgregar.TabIndex = 6;
            this.ButtonAgregar.Text = "Agregar";
            this.ButtonAgregar.UseVisualStyleBackColor = true;
            this.ButtonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // ButtonRegresar
            // 
            this.ButtonRegresar.Location = new System.Drawing.Point(259, 321);
            this.ButtonRegresar.Name = "ButtonRegresar";
            this.ButtonRegresar.Size = new System.Drawing.Size(75, 23);
            this.ButtonRegresar.TabIndex = 7;
            this.ButtonRegresar.Text = "Regresar";
            this.ButtonRegresar.UseVisualStyleBackColor = true;
            this.ButtonRegresar.Click += new System.EventHandler(this.ButtonRegresar_Click);
            // 
            // AspiranteAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 356);
            this.Controls.Add(this.ButtonRegresar);
            this.Controls.Add(this.ButtonAgregar);
            this.Controls.Add(this.tbRangoPisto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDatAcademico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDatGenerales);
            this.Controls.Add(this.label1);
            this.Name = "AspiranteAgregar";
            this.Text = "AspiranteAgregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDatGenerales;
        private System.Windows.Forms.TextBox tbDatAcademico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRangoPisto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonAgregar;
        private System.Windows.Forms.Button ButtonRegresar;
    }
}