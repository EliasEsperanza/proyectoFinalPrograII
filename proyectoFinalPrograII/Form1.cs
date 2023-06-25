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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_User.Text == Credenciales.userEntrevistador && TB_passWord.Text == Credenciales.passEntrevistador)
                {
                    menuEntrevistador menu1 = new menuEntrevistador();
                    menu1.Show();
                    this.Hide();
                }
                else if (TB_User.Text == Credenciales.userRecursos && TB_passWord.Text == Credenciales.passRecursos)
                {
                    FormSeleccion menu2 = new FormSeleccion();
                    menu2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {

            }
            

        }
    }
}
