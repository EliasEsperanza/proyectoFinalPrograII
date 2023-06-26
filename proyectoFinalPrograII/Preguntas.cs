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
    public partial class Preguntas : Form
    {
        public int L;
        public Preguntas()
        {
            InitializeComponent();
        }
 
        public void getL(int l)
        {
            L = l;
        }

        public void obtenerTexto(int answerIndex,string texto)
        {
            if(answerIndex >= 0 && answerIndex < 5)
            {
                Label respuesta = Controls.Find("answer" + (answerIndex + 1), true)[0] as Label; 
                respuesta.Text = texto;
            }
        }

        private void BTN_guardarResultado_Click(object sender, EventArgs e)
        {
            Datos.resultado = Convert.ToDouble((score1.Value + score2.Value + score3.Value + score4.Value + score5.Value) / 5);

            Datos.listResultado.Add(new ObjAspirante(Datos.ListAspirante[L].DatosPersonales, Datos.resultado));

            menuEntrevistador winMenu = new menuEntrevistador();
            winMenu.Show();
            this.Hide();
        }
    }
}
