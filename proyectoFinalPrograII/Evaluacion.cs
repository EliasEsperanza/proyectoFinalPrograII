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
    public partial class Evaluacion : Form
    {
        public Preguntas winPregunta;
        public Evaluacion(Preguntas winPregunta)
        {
            InitializeComponent();
            Actualizardt();
            this.winPregunta = winPregunta;
        }

        public void Actualizardt()
        {
            dataGridView1.Rows.Clear();
            //List<ObjAspirante> ListRespuesta = (from ObjAspirante in ListAspirante where).ToList();
            foreach (ObjAspirante item in Datos.ListAspirante)
            {
                dataGridView1.Rows.Add(item.ID, item.DatosPersonales, item.NivelAcademico, item.RangoSalario, "Evaluar");
            }
        }

        public void EvaluarClick(object sender, DataGridViewCellEventArgs e)
        {
            int Fila = dataGridView1.CurrentRow.Index;
            int Celda = dataGridView1.CurrentCell.ColumnIndex;
            int L = 0;
            for (int i = 0; i < Datos.ListAspirante.Count; i++)
            {
                if (Datos.ListAspirante[i].ID == Convert.ToInt16(dataGridView1.Rows[Fila].Cells[0].Value))
                {
                    L = i;
                }
            }
            if (Celda == 4)
            {
                
                winPreguntas.Show();
                this.Hide();

            }
        }
    }
 }
