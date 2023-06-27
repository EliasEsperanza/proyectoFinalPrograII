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
        public Preguntas P;
        public menuEntrevistador(Preguntas p)
        {
            InitializeComponent();
            P = p;
        }
        //public menuEntrevistador()
        //{
        //    InitializeComponent();
        //}
        

        private void BTN_asignacion_Click(object sender, EventArgs e)
        {
            Asignacion win1 = new Asignacion();
            win1.Show();
            this.Hide();
        }

        private void BTN_Evaluar_Click(object sender, EventArgs e)
        {
            if (P.TenerPreguntas == false)
            {
                MessageBox.Show("Por favor elija pregunta para evaluar");
            }
            else
            {
                try//Por un posible error que viene XD
                {
                    Evaluacion win2 = new Evaluacion(P);
                    win2.Show();
                    this.Hide();
                }
                catch (Exception JK)
                {
                    MessageBox.Show($"Elias mira y dime que pasa: {JK.Message}");
                    
                }
               
            }
        }

        private void BTN_Resultados_Click(object sender, EventArgs e)
        {
            Resultado win3 = new Resultado(this);
            win3.Show();
            this.Hide();
        }
    }
}
