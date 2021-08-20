using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Models
{    
    public class Empleado
    {
        public int Id { get; set; }
        public string Legajo { get; set; }
        public string NombreApellido { get; set; }
        public string Area { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
