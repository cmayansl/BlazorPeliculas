using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>
            {
                new Pelicula() {Titulo = "Spiderman1",Lanzamiento = new DateTime(2015, 1, 2)},
                new Pelicula() {Titulo = "Spiderman2",Lanzamiento = new DateTime(2017, 7, 13)},
                new Pelicula() {Titulo = "Spiderman3",Lanzamiento = new DateTime(2019, 12, 23)}

            };
        }
    }
}
