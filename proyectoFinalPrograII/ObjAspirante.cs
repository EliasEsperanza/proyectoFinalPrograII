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
        public string RangoSalario;
        
        public ObjAspirante(int id, string datosPersonales, string nivelAcademico, string rangoSalario)
        {
            ID = id;
            DatosPersonales = datosPersonales;
            NivelAcademico = nivelAcademico;
            RangoSalario = rangoSalario;
            
        }
    }
}
