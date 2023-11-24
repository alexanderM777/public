using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jjj
{
    public class estadisticas
    {
        public string? playerID { get; set; }
        public string? birthCountry { get; set; }
        public string? lgLD { get; set; }
        public double AB { get; set; }
        public double H { get; set; }
        public double HAB { get; set; }


        public double promedio()
        {
          return(double)H / AB;
           
        }
        public override string ToString()
        {
            return string.Format($"Jugador {playerID} pais de nacimiento {birthCountry} liga {lgLD} con un ab de {AB} y su h {H} con un hb de {HAB} ");
            
        }
    }
}
