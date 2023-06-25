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
        public Preguntas()
        {
            InitializeComponent();
        }

        public void obtenerTexto(int answerIndex,string texto)
        {
            if(answerIndex >= 0 && answerIndex < 5)
            {
                Label respuesta = Controls.Find("answer" + (answerIndex + 1), true)[0] as Label; 
                respuesta.Text = texto;
            }
        }
    }
}
