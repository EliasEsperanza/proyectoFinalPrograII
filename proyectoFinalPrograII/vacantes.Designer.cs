namespace proyectoFinalPrograII
{
    partial class vacantes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crequisitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfchDeini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfchDefina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidevacantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cnombre,
            this.Cdescripcion,
            this.Crequisitos,
            this.Csalario,
            this.CfchDeini,
            this.CfchDefina,
            this.Ccantidevacantes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "eliminar vacante";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "modificar vacante";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Agregar vacantes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Cnombre
            // 
            this.Cnombre.HeaderText = "Nombre de vacante";
            this.Cnombre.MinimumWidth = 6;
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            this.Cnombre.Width = 125;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.HeaderText = "Descripcion";
            this.Cdescripcion.MinimumWidth = 6;
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.ReadOnly = true;
            this.Cdescripcion.Width = 125;
            // 
            // Crequisitos
            // 
            this.Crequisitos.HeaderText = "Requisitos";
            this.Crequisitos.MinimumWidth = 6;
            this.Crequisitos.Name = "Crequisitos";
            this.Crequisitos.ReadOnly = true;
            this.Crequisitos.Width = 125;
            // 
            // Csalario
            // 
            this.Csalario.HeaderText = "Salario";
            this.Csalario.MinimumWidth = 6;
            this.Csalario.Name = "Csalario";
            this.Csalario.ReadOnly = true;
            this.Csalario.Width = 125;
            // 
            // CfchDeini
            // 
            this.CfchDeini.HeaderText = "Fecha de inicio de seleccion";
            this.CfchDeini.MinimumWidth = 6;
            this.CfchDeini.Name = "CfchDeini";
            this.CfchDeini.ReadOnly = true;
            this.CfchDeini.Width = 125;
            // 
            // CfchDefina
            // 
            this.CfchDefina.HeaderText = "Fecha de finalizacion de seleccion";
            this.CfchDefina.MinimumWidth = 6;
            this.CfchDefina.Name = "CfchDefina";
            this.CfchDefina.ReadOnly = true;
            this.CfchDefina.Width = 125;
            // 
            // Ccantidevacantes
            // 
            this.Ccantidevacantes.HeaderText = "Cantidad de vacantes";
            this.Ccantidevacantes.MinimumWidth = 6;
            this.Ccantidevacantes.Name = "Ccantidevacantes";
            this.Ccantidevacantes.ReadOnly = true;
            this.Ccantidevacantes.Width = 125;
            // 
            // vacantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "vacantes";
            this.Text = "vacantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crequisitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfchDeini;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfchDefina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidevacantes;
    }
}