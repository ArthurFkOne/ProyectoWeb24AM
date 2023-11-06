using System.ComponentModel.DataAnnotations;

namespace _24AMProyecto.Models.Entities
{
    public class Rol
    {
        [Key]
        public int PkRoles { get; set; }
        public string Nombre { get; set; }
    }
}
