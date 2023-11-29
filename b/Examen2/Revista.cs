using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Revista : Publicacion
    {
        public string Periodicidad { set; get; }

        public Revista(string Titulo, decimal Costo, string Periodicidad)
        {
            this.Titulo = Titulo;
            this.Costo = Costo;
            this.Periodicidad = Periodicidad;
        }
        public string cosas()
        {
            string Componentes = $"Titulo: {Titulo}, Costo: {Costo} , Periodicidad: {Periodicidad}";
            return Componentes;
        }
    }
}
