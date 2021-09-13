using MvcPelicula.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace MvcPelicula.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MvcPelicula.Contexts.PeliculasDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcPelicula.Contexts.PeliculasDBContext";
        }

        protected override void Seed(MvcPelicula.Contexts.PeliculasDBContext context)
        {
            context.Directores.AddOrUpdate(i => i.Nombre,
                new Director
                {
                    ID = 1,
                    Nombre = "Espen Sandberg"
                });
            context.SaveChanges();
            context.Peliculas.AddOrUpdate(i => i.Titulo,
                 new Pelicula
                 {
                     Titulo = "Los piratas del Caribe",
                     FechaLanzamiento = DateTime.Parse("2003-06-28"),
                     Genero = "Accion",
                     Precio = 4.50M,
                     Calificacion = "A",
                     Productor = "Jerry Bruckheimer",
                     DirectorId = 1
                 }
                 );
        }
    }
}
