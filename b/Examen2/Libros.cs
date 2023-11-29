using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Libros : Publicacion
    {
        public string Autor { set; get; }
        public DateTime FechaPublicacion { set; get; }

        public Libros(string Titulo, decimal Costo, string Autor, DateTime FechaPublicacion)
        {
            this.Titulo = Titulo;
            this.Costo = Costo;
            this.Autor = Autor;
            this.FechaPublicacion = FechaPublicacion;
        }

        public string cosas()
        {
            string Componentes = $"Titulo: {Titulo}, Costo: {Costo} , Autor: {Autor}, Fecha de Publicacion: {FechaPublicacion}";
            return Componentes;
        }


    }
}
