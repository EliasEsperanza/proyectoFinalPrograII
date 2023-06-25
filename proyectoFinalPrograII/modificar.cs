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
    public partial class modificar : Form
    {
        public vacantes F2;
        public int Fila;
        public modificar(vacantes f2, int fila)
        {
            InitializeComponent();
            F2 = f2;
            Fila = fila;
            txtnombreM.Text = F2.lisvacante[fila].NombreV.ToString();
            txtdesM.Text = F2.lisvacante[fila].DescripcionV.ToString();
            txtRequisitosM.Text = F2.lisvacante[fila].RequisitosV.ToString();
            txtsalarioM.Text = Convert.ToString(F2.lisvacante[fila].SalarioV.ToString());
            txtFCDeInM.Text = F2.lisvacante[fila].FCDEIV.ToString();
            txtFCDeFinM.Text = F2.lisvacante[fila].FCDEFinV.ToString();
            txtCantidadVM.Text = F2.lisvacante[fila].CantidadV.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F2.lisvacante[Fila].NombreV=txtnombreM.Text;
            F2.lisvacante[Fila].DescripcionV=txtdesM.Text;
            F2.lisvacante[Fila].RequisitosV=txtRequisitosM.Text;
            F2.lisvacante[Fila].SalarioV= Convert.ToDouble(txtsalarioM.Text);
            F2.lisvacante[Fila].FCDEIV = txtFCDeInM.Text;
            F2.lisvacante[Fila].FCDEFinV = txtFCDeFinM.Text;
            F2.lisvacante[Fila].CantidadV= int.Parse(txtCantidadVM.Text);

            F2.actualizar();
            F2.Show();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            F2.Show();
            F2.actualizar();
            this.Close();
        }
    }
}
