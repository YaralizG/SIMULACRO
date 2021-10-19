using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIMULACRO.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}