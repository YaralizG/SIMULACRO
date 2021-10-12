namespace SIMULACRO.Models
{
    public class SolicitudCompra
    {
        public int Id { get; set; }
        public string NombreProducto{get; set;}
        public string FotoProducto{get; set;}
        public string Descripcion{get;set;}
        public int PrecioProducto{ get; set; }
        public string Celular{ get; set; }
        public string LugarCompra{ get; set; } 
        public string NombreComprador{ get; set; }               
        public string CategoriaProducto{get; set;}
              
    }
}