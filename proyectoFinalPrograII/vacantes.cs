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
    public partial class vacantes : Form
    {
        public List<agreagraVS> lisvacante= new List<agreagraVS> { new agreagraVS ("angel","mucho habla", "comer mucho",200," 5 de mayo", "5 nomviembre", 32,0)};
        public FormSeleccion FA;
        public vacantes(FormSeleccion fa)
        {
            InitializeComponent();
            FA = fa;
            actualizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           agregarVacantes f2 = new agregarVacantes(this);
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fila = DTvacantes.CurrentRow.Index;
            int celda = DTvacantes.CurrentCell.ColumnIndex;
            int J = 0;
            
            for(int i = 0; i< lisvacante.Count; i++)
            {
                if (lisvacante[i].T == Convert.ToInt16(DTvacantes.Rows[fila].Cells[0].Value))
                {
                    J= i;
                }
                
            }
            modificar F1= new modificar(this,J);
        }

        public void actualizar()
        {
            
            DTvacantes.Rows.Clear();
            foreach (agreagraVS item in lisvacante)
            {
                DTvacantes.Rows.Add(item.T,item.NombreV, item.DescripcionV, item.RequisitosV, item.SalarioV, item.FCDEIV, item.FCDEFinV, item.CantidadV);
                
            }
        }

        private void txtfiltrador_TextChanged(object sender, EventArgs e)
        {
            DTvacantes.Rows.Clear();
            if (string.IsNullOrEmpty(txtfiltrador.Text))
            {
                actualizar();
            }
            else
            {
                List<agreagraVS> respuesta = (from Obj in lisvacante where Obj.NombreV == txtfiltrador.Text select Obj).ToList();
                foreach (agreagraVS item in respuesta)
                {
                    DTvacantes.Rows.Add(item.T,item.NombreV, item.DescripcionV, item.RequisitosV, item.SalarioV, item.FCDEIV, item.FCDEFinV, item.CantidadV);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fila = DTvacantes.CurrentRow.Index;
            int celda = DTvacantes.CurrentCell.ColumnIndex;
            int J = 0;

            for (int i = 0; i < lisvacante.Count; i++)
            {
                if (lisvacante[i].T == Convert.ToInt16(DTvacantes.Rows[fila].Cells[0].Value))
                {
                    J = i;
                }

            }
            lisvacante.RemoveAt(J);
            actualizar();
        }
    }
}
