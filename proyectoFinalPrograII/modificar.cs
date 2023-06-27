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
            txtnombreM.Text = Datos.lisvacante[fila].NombreV.ToString();
            txtdesM.Text = Datos.lisvacante[fila].DescripcionV.ToString();
            txtRequisitosM.Text = Datos.lisvacante[fila].RequisitosV.ToString();
            txtsalarioM.Text = Convert.ToString(Datos.lisvacante[fila].SalarioV.ToString());
            txtFCDeInM.Text = Datos.lisvacante[fila].FCDEIV.ToString();
            txtFCDeFinM.Text = Datos.lisvacante[fila].FCDEFinV.ToString();
            txtCantidadVM.Text = Datos.lisvacante[fila].CantidadV.ToString();

            //VALIDACIONES PAPA =)
            txtsalarioM.KeyPress += new KeyPressEventHandler(Validar);
            txtCantidadVM.KeyPress += new KeyPressEventHandler(Validar);
        }
        private void Validar(Object sender, KeyPressEventArgs E)
        {
            TextBox Caja = (TextBox)sender;
            if (char.IsLetter(E.KeyChar))
            {
                errorProvider1.SetError(Caja, "Solo se permite numero");
                E.Handled = true;
            }
            else
            {
                errorProvider1.SetError(Caja, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.lisvacante[Fila].NombreV=txtnombreM.Text;
            Datos.lisvacante[Fila].DescripcionV=txtdesM.Text;
            Datos.lisvacante[Fila].RequisitosV=txtRequisitosM.Text;
            Datos.lisvacante[Fila].SalarioV= Convert.ToDouble(txtsalarioM.Text);
            Datos.lisvacante[Fila].FCDEIV = txtFCDeInM.Text;
            Datos.lisvacante[Fila].FCDEFinV = txtFCDeFinM.Text;
            Datos.lisvacante[Fila].CantidadV= int.Parse(txtCantidadVM.Text);

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
