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
            this.DTvacantes = new System.Windows.Forms.DataGridView();
            this.IDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crequisitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfchDeini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfchDefina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccantidevacantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnagregarV = new System.Windows.Forms.Button();
            this.txtfiltrador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTvacantes)).BeginInit();
            this.SuspendLayout();
            // 
            // DTvacantes
            // 
            this.DTvacantes.AllowUserToAddRows = false;
            this.DTvacantes.AllowUserToDeleteRows = false;
            this.DTvacantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTvacantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTvacantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDC,
            this.Cnombre,
            this.Cdescripcion,
            this.Crequisitos,
            this.Csalario,
            this.CfchDeini,
            this.CfchDefina,
            this.Ccantidevacantes});
            this.DTvacantes.Location = new System.Drawing.Point(12, 12);
            this.DTvacantes.Name = "DTvacantes";
            this.DTvacantes.ReadOnly = true;
            this.DTvacantes.RowHeadersWidth = 51;
            this.DTvacantes.RowTemplate.Height = 24;
            this.DTvacantes.Size = new System.Drawing.Size(753, 279);
            this.DTvacantes.TabIndex = 0;
            // 
            // IDC
            // 
            this.IDC.HeaderText = "ID";
            this.IDC.MinimumWidth = 6;
            this.IDC.Name = "IDC";
            this.IDC.ReadOnly = true;
            // 
            // Cnombre
            // 
            this.Cnombre.HeaderText = "Nombre de vacante";
            this.Cnombre.MinimumWidth = 6;
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.HeaderText = "Descripcion";
            this.Cdescripcion.MinimumWidth = 6;
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.ReadOnly = true;
            // 
            // Crequisitos
            // 
            this.Crequisitos.HeaderText = "Requisitos";
            this.Crequisitos.MinimumWidth = 6;
            this.Crequisitos.Name = "Crequisitos";
            this.Crequisitos.ReadOnly = true;
            // 
            // Csalario
            // 
            this.Csalario.HeaderText = "Salario";
            this.Csalario.MinimumWidth = 6;
            this.Csalario.Name = "Csalario";
            this.Csalario.ReadOnly = true;
            // 
            // CfchDeini
            // 
            this.CfchDeini.HeaderText = "Fecha de inicio de seleccion";
            this.CfchDeini.MinimumWidth = 6;
            this.CfchDeini.Name = "CfchDeini";
            this.CfchDeini.ReadOnly = true;
            // 
            // CfchDefina
            // 
            this.CfchDefina.HeaderText = "Fecha de finalizacion de seleccion";
            this.CfchDefina.MinimumWidth = 6;
            this.CfchDefina.Name = "CfchDefina";
            this.CfchDefina.ReadOnly = true;
            // 
            // Ccantidevacantes
            // 
            this.Ccantidevacantes.HeaderText = "Cantidad de vacantes";
            this.Ccantidevacantes.MinimumWidth = 6;
            this.Ccantidevacantes.Name = "Ccantidevacantes";
            this.Ccantidevacantes.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "eliminar vacante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(120, 338);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 48);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "modificar vacante";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnagregarV
            // 
            this.btnagregarV.Location = new System.Drawing.Point(228, 340);
            this.btnagregarV.Name = "btnagregarV";
            this.btnagregarV.Size = new System.Drawing.Size(101, 46);
            this.btnagregarV.TabIndex = 3;
            this.btnagregarV.Text = "Agregar vacantes";
            this.btnagregarV.UseVisualStyleBackColor = true;
            this.btnagregarV.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtfiltrador
            // 
            this.txtfiltrador.Location = new System.Drawing.Point(496, 364);
            this.txtfiltrador.Name = "txtfiltrador";
            this.txtfiltrador.Size = new System.Drawing.Size(292, 22);
            this.txtfiltrador.TabIndex = 4;
            this.txtfiltrador.TextChanged += new System.EventHandler(this.txtfiltrador_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "filtrador";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(335, 339);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 46);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // vacantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfiltrador);
            this.Controls.Add(this.btnagregarV);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DTvacantes);
            this.Name = "vacantes";
            this.Text = "vacantes";
            ((System.ComponentModel.ISupportInitialize)(this.DTvacantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTvacantes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnagregarV;
        private System.Windows.Forms.TextBox txtfiltrador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crequisitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfchDeini;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfchDefina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccantidevacantes;
        private System.Windows.Forms.Button btnRegresar;
    }
}