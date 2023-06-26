using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPrograII
{
    public static class Datos
    {
        public static List<ObjAspirante> ListAspirante = new List<ObjAspirante> { new ObjAspirante(1, "Hieloeston", "Bachillerato", 170), new ObjAspirante(2, "Elias Esperanza", "Universitario", 2900), new ObjAspirante(3, "Angel Ramirez", "Univeritario Basado", 10000) };
        public static List<agreagraVS> lisvacante = new List<agreagraVS> { new agreagraVS("angel", "mucho habla", "comer mucho", 200, " 5 de mayo", "5 nomviembre", 32, 0) };
        public static double resultado;
        public static List<ObjAspirante> listResultado = new List<ObjAspirante>(); 
    }
}
