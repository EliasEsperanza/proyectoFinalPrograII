using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPrograII
{
    public class agreagraVS
    {
        public string NombreV;
        public string DescripcionV;
        public string RequisitosV;
        public double SalarioV;
        public string FCDEIV;
        public string FCDEFinV;
        public int CantidadV;
        public int T;

        public agreagraVS(string nombre, string descripcion, string requisito, double salario, string FCDEIV,
                          string FCDEFinV, int cantidad, int t)
        {
            this.NombreV = nombre;
            this.DescripcionV = descripcion;
            this.RequisitosV = requisito;
            this.SalarioV = salario;
            this.FCDEIV = FCDEIV;
            this.FCDEFinV = FCDEFinV;
            this.CantidadV = cantidad;
            T = t;
        }

       
    }
}
