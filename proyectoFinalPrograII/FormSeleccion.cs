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
    public partial class FormSeleccion : Form
    {
        public LOGIN FG;

        public FormSeleccion(LOGIN fG)//Metele un this cuando llames este contructor Elias Esperanza Torres
        {
            InitializeComponent();
            FG = fG;
        }

        private void ButtonAspirantes_Click(object sender, EventArgs e)
        {
            Aspirante F2 = new Aspirante(this);
            F2.Show();
            this.Hide();
        }

        private void ButtonVerVacante_Click(object sender, EventArgs e)
        {
            vacantes F2 = new vacantes(this);
            F2.Show();
            this.Hide();
        }

        private void ButtonVerTablas_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRegresar_Click(object sender, EventArgs e)
        {
            FG.Show();
            this.Close();
        }
    }
}
