using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePublicaciones
{
    public class Libros
    {
        //Los libros tienen título, autor, fecha de publicación y costo. (2 puntos)
        public string titulo { get; set; }
        public string pAutor { get; set; }
        public string Publicado { get; set; }
        public double Costo { get; set; }



        public override string ToString()
        {
            return string.Format($" Autor :{pAutor}\n" +
                $" publicado : {Publicado} +" +
                $" El libro con titulo:{ titulo}\n" +
                $" con un precio de { Costo} ");
        }
    }
}
