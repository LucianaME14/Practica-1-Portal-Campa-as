using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Models;
using PortalCampanas.Services;

namespace PortalCampanas.Controllers;

public class CampanasController : Controller
{
    private readonly CampanaService _campanaService;

    public CampanasController(CampanaService campanaService)
    {
        _campanaService = campanaService;
    }

    public IActionResult Index(string? categoria, string? estado)
    {
        var campanas = _campanaService.ObtenerTodas().AsQueryable();

        if (!string.IsNullOrWhiteSpace(categoria))
            campanas = campanas.Where(c => c.Categoria == categoria);

        if (!string.IsNullOrWhiteSpace(estado))
            campanas = campanas.Where(c => c.Estado == estado);

        return View(campanas.ToList());
    }

    public IActionResult Detalle(int id)
    {
        var campana = _campanaService.ObtenerPorId(id);

        if (campana == null)
            return NotFound();

        return View(campana);
    }

    public IActionResult Resumen()
    {
        var campanas = _campanaService.ObtenerTodas();

        var model = new ResumenCampanasViewModel
        {
            TotalCampanas = campanas.Count,
            CampanasVigentes = campanas.Count(c => c.Estado == "Vigente"),
            CampanasProximas = campanas.Count(c => c.Estado == "Próxima"),
            PromedioDescuento = campanas.Any() ? campanas.Average(c => c.DescuentoPct) : 0,
            CantidadPorCanal = campanas.GroupBy(c => c.Canal)
                                       .ToDictionary(g => g.Key, g => g.Count())
        };

        return View(model);
    }
}