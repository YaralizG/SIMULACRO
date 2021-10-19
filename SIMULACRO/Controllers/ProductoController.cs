using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIMULACRO.Models;

namespace SIMULACRO.Controllers
{
    public class ProductoController : Controller
    {
        private readonly  ProductoContext _context;
        public ProductoController(ProductoContext context){
            _context=context;
        }

        public IActionResult Productos(){
            var productos=_context.Productos.Include(x =>x.Categoria).OrderBy(r=>r.nombre).ToList();
            return View(productos);
        }
        
        /*Nuevo Producto*/
        public IActionResult NuevoProducto(){
           ViewBag.Categorias= _context.Categorias.ToList().Select(r => new SelectListItem(r.nombre, r.id.ToString()));
            return View();

        }
        [HttpPost]
        public IActionResult NuevoProducto(Producto r){
            if(ModelState.IsValid)
            {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevoProductoConfirmacion");
            }
            return View(r);
        }
        public IActionResult NuevoProductoConfirmacion(){
            return View();
        }

        /*Borrar Producto*/
        [HttpPost]
        public IActionResult BorrarProducto(int id){           
            var productos=_context.Productos.Find(id);
            _context.Remove(productos);
            _context.SaveChanges();
            return RedirectToAction("Productos");
        }

        /*Categoria*/
         public IActionResult NuevaCategoria(){
            return View();

        }
        [HttpPost]
        public IActionResult NuevaCategoria(Categoria r){
            if(ModelState.IsValid)
            {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevaCategoriaConfirmacion");
            }
            return View(r);
        }
        public IActionResult NuevaCategoriaConfirmacion(){
            return View();
        }

    }
}