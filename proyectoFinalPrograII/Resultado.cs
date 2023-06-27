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
    public partial class Resultado : Form
    {
        public menuEntrevistador J;
        public Resultado(menuEntrevistador j)
        {
            J = j;
            InitializeComponent();
            llenarData();
            
        }

        public void llenarData()
        {
            
            foreach(ObjAspirante item in Datos.listResultado)
            {
                dataGridView1.Rows.Add(item.DatosPersonales, item.result);
            }
            Datos.resultado = 0;
            t1.Start();

            //int Fila = dataGridView1.CurrentRow.Index;
            //int Celda = dataGridView1.CurrentCell.ColumnIndex;

        }

        private void BTN_regresar_Click(object sender, EventArgs e)
        {
           
            J.Show();
            this.Hide();
        }

        private void Tick(object sender, EventArgs e)
        {
            if (Datos.listResultado.Count == 1)
            {
                int L = 0;
                //MessageBox.Show("Fila "+ Fila + "Columna " + Celda);
                for (int i = 0; i < Datos.ListAspirante.Count; i++)
                {
                    if (Datos.ListAspirante[i].DatosPersonales == Datos.listResultado[0].DatosPersonales)
                    {
                        L = i;
                    }
                }
                t1.Stop();
                MessageBox.Show($"Aspirante recomendado: {Datos.listResultado[0].DatosPersonales} Pago Anual: {Datos.ListAspirante[L].RangoSalario} Descuenton ISSS: {Datos.ListAspirante[L].RangoSalario * 0.14}, AFP: {Datos.ListAspirante[L].RangoSalario * 0.0725}, Renta: {Datos.ListAspirante[L].RangoSalario * 0.10}");
            }
            else if (Datos.listResultado.Count > 1)
            {
                int L = 999;
                string NombredelElegido = Datos.listResultado[0].DatosPersonales;
                double MayorResultado = Datos.listResultado[0].result;
                for (int i = 0; i < Datos.listResultado.Count; i++)
                {
                    if (Datos.listResultado[i].result > MayorResultado)
                    {
                        MayorResultado = Datos.listResultado[i].result;
                        NombredelElegido = Datos.listResultado[i].DatosPersonales;
                    }
                }
                for (int i = 0; i < Datos.ListAspirante.Count; i++)
                {
                    if (Datos.ListAspirante[i].DatosPersonales == NombredelElegido)
                    {
                        L = i;
                    }
                }
                t1.Stop();
                MessageBox.Show($"Aspirante recomendado: {Datos.ListAspirante[L].DatosPersonales} Pago Anual: {Datos.ListAspirante[L].RangoSalario} Descuenton ISSS: {Datos.ListAspirante[L].RangoSalario * 0.14}, AFP: {Datos.ListAspirante[L].RangoSalario * 0.0725}, Renta: {Datos.ListAspirante[L].RangoSalario * 0.10}");
            }
            else
            {

            }
            
        }

        
    }
}
