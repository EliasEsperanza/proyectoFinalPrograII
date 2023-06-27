namespace proyectoFinalPrograII
{
    partial class Evaluacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataAcademico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEvaluar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciones un aspirante para evaluar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cNombre,
            this.cDataAcademico,
            this.cSalario,
            this.cEvaluar});
            this.dataGridView1.Location = new System.Drawing.Point(125, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(788, 373);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EvaluarClick);
            // 
            // cId
            // 
            this.cId.HeaderText = "ID";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Datos personales";
            this.cNombre.MinimumWidth = 6;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cDataAcademico
            // 
            this.cDataAcademico.HeaderText = "Datos Academicos";
            this.cDataAcademico.MinimumWidth = 6;
            this.cDataAcademico.Name = "cDataAcademico";
            this.cDataAcademico.ReadOnly = true;
            // 
            // cSalario
            // 
            this.cSalario.HeaderText = "Rango Salarial";
            this.cSalario.MinimumWidth = 6;
            this.cSalario.Name = "cSalario";
            this.cSalario.ReadOnly = true;
            // 
            // cEvaluar
            // 
            this.cEvaluar.HeaderText = "";
            this.cEvaluar.MinimumWidth = 6;
            this.cEvaluar.Name = "cEvaluar";
            this.cEvaluar.ReadOnly = true;
            // 
            // Evaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Evaluacion";
            this.Text = "Evaluacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataAcademico;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSalario;
        private System.Windows.Forms.DataGridViewButtonColumn cEvaluar;
    }
}