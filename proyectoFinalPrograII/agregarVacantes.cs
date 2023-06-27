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
    public partial class agregarVacantes : Form
    {
       public vacantes F2;
        public agregarVacantes(vacantes f2)
        {
            InitializeComponent();
            F2 = f2;

            //VALIDACIONES PAPA =)
            txtSalarioV.KeyPress += new KeyPressEventHandler(Validar);
            txtCantidadV.KeyPress += new KeyPressEventHandler(Validar);
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

        private void agregarVacantes_Load(object sender, EventArgs e)
        {
           
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.lisvacante.Add(new agreagraVS(txtnombrev.Text, txtdescripV.Text, txtrequisitoV.Text, Convert.ToDouble(txtSalarioV.Text),
                             txtFCDeinV.Text, txtFCDeFinV.Text, int.Parse(txtCantidadV.Text),Datos.lisvacante.Count));
            F2.Show();
            F2.actualizar();
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
