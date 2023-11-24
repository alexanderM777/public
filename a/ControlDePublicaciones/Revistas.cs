using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePublicaciones
{
    public class Revistas : Libros
    {
        //Las revistas tienen título, periodicidad (mensual, semanal o quincenal) y costo. (2 puntos)
        public string Periodicidad { get; set; }

        public override string ToString()
        {
            return string.Format($"El libro con periocidad :{Periodicidad}\n " +
                $" con un titulo : {titulo} +" +
                $" con un costo de {Costo}");
        }
    }
}
