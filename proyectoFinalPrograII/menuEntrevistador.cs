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
    public partial class menuEntrevistador : Form
    {
        public menuEntrevistador()
        {
            InitializeComponent();
        }

        private void BTN_asignacion_Click(object sender, EventArgs e)
        {
            Asignacion win1 = new Asignacion();
            win1.Show();
            this.Hide();
        }

        private void BTN_Evaluar_Click(object sender, EventArgs e)
        {
            Evaluacion win2 = new Evaluacion();
            win2.Show();
            this.Hide();
        }

        private void BTN_Resultados_Click(object sender, EventArgs e)
        {
            Resultado win3 = new Resultado();
            win3.Show();
            this.Hide();
        }
    }
}
