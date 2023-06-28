using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalPrograII
{
    public static class Datos
    {
        public static List<ObjAspirante> ListAspirante = new List<ObjAspirante> { new ObjAspirante(1, "Gabriel Aguirre", "Bachillerato", 2550), new ObjAspirante(2, "Elias Esperanza", "Universitario", 2900), new ObjAspirante(3, "Angel Ramirez", "Univeritario Basado", 3000) };
        public static List<agreagraVS> lisvacante = new List<agreagraVS> { new agreagraVS("Asistente de Programador", "Asistir a los programadores en cualquier cosa que necesiten", "Conocimiento de c++ y c#", 200, "5 de mayo", "5 nomviembre", 4, 0) };
        public static double resultado;
        public static List<ObjAspirante> listResultado = new List<ObjAspirante>(); 


    }
}
