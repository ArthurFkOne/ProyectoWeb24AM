using System.ComponentModel.DataAnnotations;

namespace _24AMProyecto.Models.Entities
{
    public class Libro
    {
        [Key]
        public int PkLibro { get; set; }
        public string Titulo { get; set;}
        public string Descripcion { get; set; }
        public string Images { get; set; }

    }
}
