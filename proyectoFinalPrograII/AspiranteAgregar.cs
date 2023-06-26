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
    public partial class AspiranteAgregar : Form
    {
        public Aspirante I;
        public AspiranteAgregar(Aspirante i)
        {
            InitializeComponent();
            I = i;
        }
        private void ButtonRegresar_Click_1(object sender, EventArgs e)
        {
            I.Actualizardt();
            I.Show();
            this.Close();
        }
        public int DarID()
        {
            int J = 0; bool K = false;
            for (int i = 0; i < Datos.ListAspirante.Count + 1; i++)
            {
                for (int j = 0; j < Datos.ListAspirante.Count; j++)
                {
                    if (i == Datos.ListAspirante[j].ID)
                    {
                        //J = i;
                        K = true;
                        break;
                    }
                    
                    
                }

                if (K == false)
                {
                    J = i;
                }
                else
                {
                    K = false;
                }
                
            }

            return J;
        }

        private void ButtonAgregar_Click_1(object sender, EventArgs e)
        {
            Datos.ListAspirante.Add(new ObjAspirante(DarID(), Convert.ToString(tbDatGenerales.Text), Convert.ToString(tbDatAcademico.Text), double.Parse(tbRangoPisto.Text)));
            I.Actualizardt();
            I.Show();
            this.Close();
        }
    }
}
