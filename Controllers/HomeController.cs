using Microsoft.AspNetCore.Mvc;

namespace mvc;


public class HomeController : Controller
{
    private readonly IDataContext _context;

    public HomeController(IDataContext context) {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        // Obtiene la lista de productos
        List<Producto> productos = await _context.GetProductosAsync();
        // Envia el modelo a la vista
        return View(productos);
    }

    public IActionResult Error()
    {
        return View();
    }
}