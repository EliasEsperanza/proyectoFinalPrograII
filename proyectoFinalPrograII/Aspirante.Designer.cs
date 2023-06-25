namespace proyectoFinalPrograII
{
    partial class Aspirante
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
            this.dgvAspirante = new System.Windows.Forms.DataGridView();
            this.tbfiltrar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDatGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDatAcadermico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRangodeSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButtonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAspirante)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAspirante
            // 
            this.dgvAspirante.AllowUserToAddRows = false;
            this.dgvAspirante.AllowUserToDeleteRows = false;
            this.dgvAspirante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAspirante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAspirante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CDatGen,
            this.CDatAcadermico,
            this.CRangodeSalario,
            this.CModificar,
            this.CEliminar});
            this.dgvAspirante.Location = new System.Drawing.Point(12, 41);
            this.dgvAspirante.Name = "dgvAspirante";
            this.dgvAspirante.ReadOnly = true;
            this.dgvAspirante.Size = new System.Drawing.Size(621, 310);
            this.dgvAspirante.TabIndex = 0;
            this.dgvAspirante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModificarEliminarClick);
            // 
            // tbfiltrar
            // 
            this.tbfiltrar.Location = new System.Drawing.Point(12, 12);
            this.tbfiltrar.Name = "tbfiltrar";
            this.tbfiltrar.Size = new System.Drawing.Size(383, 20);
            this.tbfiltrar.TabIndex = 1;
            this.tbfiltrar.TextChanged += new System.EventHandler(this.tbfiltrar_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar Aspirante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            // 
            // CDatGen
            // 
            this.CDatGen.HeaderText = "Datos Generales";
            this.CDatGen.Name = "CDatGen";
            this.CDatGen.ReadOnly = true;
            // 
            // CDatAcadermico
            // 
            this.CDatAcadermico.HeaderText = "Datos Academico";
            this.CDatAcadermico.Name = "CDatAcadermico";
            this.CDatAcadermico.ReadOnly = true;
            // 
            // CRangodeSalario
            // 
            this.CRangodeSalario.HeaderText = "Rango de Salario";
            this.CRangodeSalario.Name = "CRangodeSalario";
            this.CRangodeSalario.ReadOnly = true;
            // 
            // CModificar
            // 
            this.CModificar.HeaderText = "Modificar";
            this.CModificar.Name = "CModificar";
            this.CModificar.ReadOnly = true;
            // 
            // CEliminar
            // 
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            this.CEliminar.ReadOnly = true;
            // 
            // ButtonRegresar
            // 
            this.ButtonRegresar.Location = new System.Drawing.Point(528, 12);
            this.ButtonRegresar.Name = "ButtonRegresar";
            this.ButtonRegresar.Size = new System.Drawing.Size(105, 23);
            this.ButtonRegresar.TabIndex = 3;
            this.ButtonRegresar.Text = "Regresar";
            this.ButtonRegresar.UseVisualStyleBackColor = true;
            this.ButtonRegresar.Click += new System.EventHandler(this.ButtonRegresar_Click);
            // 
            // Aspirante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 363);
            this.Controls.Add(this.ButtonRegresar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbfiltrar);
            this.Controls.Add(this.dgvAspirante);
            this.Name = "Aspirante";
            this.Text = "Aspirante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAspirante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAspirante;
        private System.Windows.Forms.TextBox tbfiltrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDatGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDatAcadermico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRangodeSalario;
        private System.Windows.Forms.DataGridViewButtonColumn CModificar;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        private System.Windows.Forms.Button ButtonRegresar;
    }
}