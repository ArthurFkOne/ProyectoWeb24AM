﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _24AMProyecto.Models.Entities
{
    public class Usuario
    {
        [Key]
        public int PkUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string UserNmae { get; set;}
        public string Password { get; set;}
        [ForeignKey("Roles")]
        public int FkRol { get; set;}
        public Rol Roles { get; set;}
    }
}