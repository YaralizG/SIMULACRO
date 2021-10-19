using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SIMULACRO.Models
{
    public class Producto
    {
       public int id { get; set; }
        public string nombre{get; set;}
        public string fotoproducto{get; set;}
        public string descripcion{get;set;}
        public int precio { get; set; }
        public string nrocelular { get; set; }
        public string lugarcompra { get; set; }
        public string nombrecomprador { get; set; }
        public Categoria Categoria{get; set;}
        
        public int? Categoriaid { get; set; }
        
              
    }
}