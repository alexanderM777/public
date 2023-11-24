using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePublicaciones
{
    public class Autor : Revistas
    {
        public List<Libros> librosobj;

        public Autor()
        {
            librosobj = new()
        {
           new Libros() { pAutor = "Gabriel", Publicado = "12/10/96", titulo = "Relatodeunnaufrago", Costo = 1230 },
           new Libros() { pAutor = "Pablo", Publicado = "12/01/98", titulo = "Coronel no tiene quien le cuente", Costo = 1345 },
           new Libros() { pAutor = "Stepehen", Publicado = "17/03/91", titulo = "El Universo", Costo = 2145 },
           new Libros() { pAutor = "Ruben", Publicado = "16/06/1893", titulo = "Azul", Costo = 1768 },
           new Libros() { pAutor = "Ruben", Publicado = "25/09/19001", titulo = "Prosas Profanas", Costo = 1389},


          };
        }

        public List<Revistas> revistasobj = new()
        {
            new Revistas() { Publicado = "MENSUAL", titulo = "Nueva miss universo2023", Costo = 143 },
            new Revistas() {Publicado = "QUINCENAL", titulo = "que dice tu horoscopo", Costo = 123 },
            new Revistas() {Publicado = "MENSUAL", titulo = "Eliminatorial al mundial 2026", Costo = 245 },
            new Revistas() {Publicado = "SEMANAL", titulo = "Chess Tournanment", Costo = 546 },
            new Revistas() {Publicado = "MENSUAL", titulo = "Mejores regalos", Costo = 1234 },

        };
       

        public List<Libros> obtenerLista()
        {
            return (from lisya in librosobj
                    select lisya).ToList(); 
        }  
        public List<Revistas> obtenerLista2()
        {
            return(from lsita in revistasobj
                   select lsita).ToList(); 
        }
        public List<Libros> obtenerDatosLibros()
        {
            return(from datos in librosobj
                   where datos.pAutor == "Ruben"
                      select datos).ToList();
        
        }




    }
}

