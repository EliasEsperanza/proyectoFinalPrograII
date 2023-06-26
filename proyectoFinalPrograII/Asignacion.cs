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
    public partial class Asignacion : Form
    {
        private List<CheckBox> checkBoxes;
        public Asignacion()
        {
            InitializeComponent();

            checkBoxes = new List<CheckBox>()
            {
                quest1, quest2,quest3, quest4, quest5,
                quest6, quest7, quest8, quest9, quest10
            };
        }

        private void BTN_confirmar_Click(object sender, EventArgs e)
        {
            var checkboxeSelecionados = checkBoxes.Where(cb => cb.Checked).ToList();
            Preguntas winPreguntas = new Preguntas();

            if(checkboxeSelecionados.Count == 5)
            {

                for (int i = 0; i < checkboxeSelecionados.Count; i++)
                {
                    winPreguntas.obtenerTexto(i, checkboxeSelecionados[i].Text);
                }

                menuEntrevistador winMenu = new menuEntrevistador(winPreguntas);

                //winPreguntas.Show();
                this.Hide();
                winMenu.Show();

            }
            else
            {
                MessageBox.Show("Debe seleccionar exactamente 5 preguntas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
