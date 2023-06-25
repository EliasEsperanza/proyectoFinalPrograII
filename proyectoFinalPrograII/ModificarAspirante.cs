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
    public partial class ModificarAspirante : Form
    {
        public Aspirante F2;
        public int Fila;
        public ModificarAspirante(Aspirante f2, int fila)
        {
            F2 = f2;
            Fila = fila;
            InitializeComponent();
            tbDatGenerales.Text = F2.ListAspirante[fila].DatosPersonales.ToString();
            tbDatAcademico.Text = F2.ListAspirante[fila].NivelAcademico.ToString();
            tbRangoPisto.Text = F2.ListAspirante[fila].RangoSalario.ToString();
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            F2.ListAspirante[Fila].DatosPersonales = tbDatGenerales.Text;
            F2.ListAspirante[Fila].NivelAcademico = tbDatAcademico.Text;
            F2.ListAspirante[Fila].RangoSalario = tbRangoPisto.Text;
            F2.Actualizardt();
            F2.Show();
            this.Close();
        }

        private void ButtonRegresar_Click(object sender, EventArgs e)
        {
            F2.Show();
            this.Close();
        }
    }
}
