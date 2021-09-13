using MvcPelicula.Models;
using System.Data.Entity;

namespace MvcPelicula.Contexts
{
    public class PeliculasDBContext : DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }

        public DbSet<Director> Directores { get; set; }

    }
}