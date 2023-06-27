namespace proyectoFinalPrograII
{
    partial class Resultado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cScore});
            this.dataGridView1.Location = new System.Drawing.Point(143, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(737, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Datos Personales";
            this.cNombre.MinimumWidth = 6;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cScore
            // 
            this.cScore.HeaderText = "Nota";
            this.cScore.MinimumWidth = 6;
            this.cScore.Name = "cScore";
            this.cScore.ReadOnly = true;
            // 
            // BTN_regresar
            // 
            this.BTN_regresar.Location = new System.Drawing.Point(820, 478);
            this.BTN_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_regresar.Name = "BTN_regresar";
            this.BTN_regresar.Size = new System.Drawing.Size(180, 33);
            this.BTN_regresar.TabIndex = 1;
            this.BTN_regresar.Text = "Regresar";
            this.BTN_regresar.UseVisualStyleBackColor = true;
            this.BTN_regresar.Click += new System.EventHandler(this.BTN_regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultados";
            // 
            // t1
            // 
            this.t1.Tick += new System.EventHandler(this.Tick);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_regresar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Resultado";
            this.Text = "Resultado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cScore;
        private System.Windows.Forms.Timer t1;
    }
}