using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proyectoFinalPrograII
{
    public partial class vacantes : Form
    {
        
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
            //Agregar tryCacth
            int fila = DTvacantes.CurrentRow.Index;
            int celda = DTvacantes.CurrentCell.ColumnIndex;
            int J = 0;
            
            for(int i = 0; i< Datos.lisvacante.Count; i++)
            {
                if (Datos.lisvacante[i].T == Convert.ToInt16(DTvacantes.Rows[fila].Cells[0].Value))
                {
                    J= i;
                }
                
            }
            modificar F1= new modificar(this,J);
            F1.Show();
            this.Hide();
        }

        public void actualizar()
        {
            
            DTvacantes.Rows.Clear();
            foreach (agreagraVS item in Datos.lisvacante)
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
                List<agreagraVS> respuesta = (from Obj in Datos.lisvacante where Convert.ToString(Obj.T) == txtfiltrador.Text select Obj).ToList();
                foreach (agreagraVS item in respuesta)
                {
                    DTvacantes.Rows.Add(item.T,item.NombreV, item.DescripcionV, item.RequisitosV, item.SalarioV, item.FCDEIV, item.FCDEFinV, item.CantidadV);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Datos.lisvacante.Count > 0)
            {
                int fila = DTvacantes.CurrentRow.Index;
                int celda = DTvacantes.CurrentCell.ColumnIndex;
                int J = 0;

                for (int i = 0; i < Datos.lisvacante.Count; i++)
                {
                    if (Datos.lisvacante[i].T == Convert.ToInt16(DTvacantes.Rows[fila].Cells[0].Value))
                    {
                        J = i;
                    }

                }
                Datos.lisvacante.RemoveAt(J);
                actualizar();
            }
            else
            {
                MessageBox.Show("No se puede borrar una fila inexistente");
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FA.Show();
            this.Close();
        }

        private void checkordenar_CheckedChanged(object sender, EventArgs e)
        {
            List<agreagraVS> mayoromenor = (from xd in Datos.lisvacante orderby xd.T select xd).ToList();
            
            if (checkordenar.Checked)
            {   
                DTvacantes.Rows.Clear();
                foreach (agreagraVS item in mayoromenor )
                {
                    DTvacantes.Rows.Add(item.T, item.NombreV, item.DescripcionV, item.RequisitosV, item.SalarioV, item.FCDEIV, item.FCDEFinV, item.CantidadV);
                }
            }
            else
            {
                actualizar();
            }
        }
    }
}
