using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPelicula.Models
{
    public class Director
    {
        public int ID { get; set; }

        
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Nombre de Director")]
        public String Nombre { get; set; }

        public ICollection<Pelicula> Peliculas { get; set; }

    }


}