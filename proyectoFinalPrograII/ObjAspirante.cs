using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPrograII
{
    public class ObjAspirante
    {
        public int ID;
        public string DatosPersonales;
        public string NivelAcademico;
        public double RangoSalario;
        public double result;
        
        public ObjAspirante(int id, string datosPersonales, string nivelAcademico, double rangoSalario)
        {
            ID = id;
            DatosPersonales = datosPersonales;
            NivelAcademico = nivelAcademico;
            RangoSalario = rangoSalario;
            
        }
        public ObjAspirante(string datosPersonales, double result) {
            this.DatosPersonales = datosPersonales;
            this.result = result;
        }
    }
}
