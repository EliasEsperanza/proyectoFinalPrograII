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
        Aspirante I = new Aspirante();
        public AspiranteAgregar(Aspirante i)
        {
            InitializeComponent();
            I = i;
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            I.ListAspirante.Add(new ObjAspirante(I.ListAspirante.Count + 1, Convert.ToString(tbDatGenerales), Convert.ToString(tbDatAcademico), Convert.ToString(tbRangoPisto)));
            I.Show();
            this.Close();
        }

        private void ButtonRegresar_Click(object sender, EventArgs e)
        {
            I.Show();
            this.Close();
        }
    }
}
