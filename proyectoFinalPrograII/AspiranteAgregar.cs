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
        Aspirante I;
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
        private void ButtonAgregar_Click_1(object sender, EventArgs e)
        {
            Datos.ListAspirante.Add(new ObjAspirante(Datos.ListAspirante.Count + 1, Convert.ToString(tbDatGenerales.Text), Convert.ToString(tbDatAcademico.Text), double.Parse(tbRangoPisto.Text)));
            I.Actualizardt();
            I.Show();
            this.Close();
        }
    }
}
