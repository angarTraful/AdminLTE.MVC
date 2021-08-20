using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Models
{
    public enum Estados
    {
        Activo,
        Advertido,
        Inhabilitado
    }

    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string RazonSocial { get; set; }
        [Required]
        public string CUIT { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public Estados Estado { get; set; }
        
        public virtual Empresa Empresa { get; set; }
    }
}
