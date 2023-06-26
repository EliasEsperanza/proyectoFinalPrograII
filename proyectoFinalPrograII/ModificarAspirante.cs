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
            tbDatGenerales.Text = Datos.ListAspirante[Fila].DatosPersonales.ToString();
            tbDatAcademico.Text = Datos.ListAspirante[Fila].NivelAcademico.ToString();
            tbRangoPisto.Text = Datos.ListAspirante[Fila].RangoSalario.ToString();
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            Datos.ListAspirante[Fila].DatosPersonales = tbDatGenerales.Text;
            Datos.ListAspirante[Fila].NivelAcademico = tbDatAcademico.Text;
            Datos.ListAspirante[Fila].RangoSalario = Convert.ToDouble(tbRangoPisto.Text);
            F2.Show();
            F2.Actualizardt();
            this.Close();
        }

        private void ButtonRegresar_Click(object sender, EventArgs e)
        {
            F2.Show();
            this.Close();
        }
    }
}
