using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinalPrograII
{
    public partial class Aspirante : Form
    {
        public FormSeleccion FA;
        
        public Aspirante(FormSeleccion fA)
        {
            
            InitializeComponent();
            Actualizardt();
            FA = fA;
        }
        public void Actualizardt()
        {
            dgvAspirante.Rows.Clear();
            //List<ObjAspirante> ListRespuesta = (from ObjAspirante in ListAspirante where).ToList();
            foreach (ObjAspirante item in Datos.ListAspirante)
            {
                dgvAspirante.Rows.Add(item.ID, item.DatosPersonales, item.NivelAcademico, item.RangoSalario, "Modificar", "Eliminar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AspiranteAgregar Gf = new AspiranteAgregar(this);
            Gf.Show();
            this.Hide();
        }

        private void tbfiltrar_TextChanged(object sender, EventArgs e)
        {

            dgvAspirante.Rows.Clear();
            if (String.IsNullOrEmpty(tbfiltrar.Text))
            {
                Actualizardt();
            }
            else
            {
                List<ObjAspirante> ListRespuesta = (from OBJ in Datos.ListAspirante where OBJ.ID == Convert.ToInt32(tbfiltrar.Text) select OBJ).ToList();
                foreach (ObjAspirante item in ListRespuesta)
                {
                    dgvAspirante.Rows.Add(item.ID, item.DatosPersonales, item.NivelAcademico, item.RangoSalario, "Modificar", "Eliminar");
                }
            }
        }

        private void ModificarEliminarClick(object sender, DataGridViewCellEventArgs e)
        {
            int Fila = dgvAspirante.CurrentRow.Index;
            int Celda = dgvAspirante.CurrentCell.ColumnIndex;
            int L= 0;
            for (int i = 0; i < Datos.ListAspirante.Count; i++)
            {
                if (Datos.ListAspirante[i].ID == Convert.ToInt16(dgvAspirante.Rows[Fila].Cells[0].Value))
                {
                    L = i;
                }
            }
            if(Celda == 4)
            {
                ModificarAspirante JH = new ModificarAspirante(this, L);
                JH.Show();
                this.Hide();

            }
            else if(Celda == 5)
            {
                Datos.ListAspirante.RemoveAt(L);
                Actualizardt();
            }
        }

        private void ButtonRegresar_Click(object sender, EventArgs e)
        {
            FA.Show();
            this.Close();
        }
    }
}
