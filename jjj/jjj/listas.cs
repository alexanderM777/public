using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jjj
{
    public class listas : estadisticas
    {
        public List<estadisticas> jugadorr = new List<estadisticas>();
        
        public listas()
        {
            jugadorr = new List<estadisticas>()
            {
                new estadisticas() {playerID = "cabremi01", birthCountry = "Venezuela", lgLD = "AL", AB = 204, H = 51,  HAB = HAB      },
                new estadisticas() {playerID = "canoro1", birthCountry = "D.R", lgLD = "NL", AB = 171, H = 54 ,    HAB = HAB           },
                new estadisticas() {playerID = "choosh01", birthCountry = "South Korea", lgLD = "AL", AB = 110, H = 26 , HAB = HAB      },
                new estadisticas() {playerID = "cruzne02", birthCountry = "D.R", lgLD = "AL", AB = 185, H = 56 ,       HAB = HAB      },
                new estadisticas() {playerID = "encared01", birthCountry = "D.R", lgLD = "AL", AB = 159, H = 25 ,     HAB = HAB        },
                new estadisticas() {playerID = "molinya01", birthCountry = "P.R", lgLD = "NL", AB = 145, H = 38 ,     HAB = HAB        },
                new estadisticas() {playerID = "pujolal01", birthCountry = "D.R", lgLD = "AL", AB = 152, H = 34 ,     HAB = HAB         },
                new estadisticas() {playerID = "suzukku01", birthCountry = "USA", lgLD = "NL", AB = 111, H = 30 ,       HAB = HAB       },        
            

            };
        }
        public List<estadisticas> Obtener()
        {
            return(from estadisitcas in jugadorr
                   select estadisitcas).ToList();
        }

        public List<estadisticas> filtros()
        {
            
            return (from filtro in jugadorr
                         where filtro.lgLD == "AL" && filtro.birthCountry == "D.R" && filtro.promedio() >= 0.050
                         select filtro).ToList();

        }
}
}
