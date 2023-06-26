﻿using System;
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
        public Resultado()
        {
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
        }

        private void BTN_regresar_Click(object sender, EventArgs e)
        {
            menuEntrevistador winMenu = new menuEntrevistador();
            winMenu.Show();
            this.Hide();
        }
    }
}
