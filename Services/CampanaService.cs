using PortalCampanas.Models;

namespace PortalCampanas.Services;

public class CampanaService
{
    private static readonly List<Campana> _campanas = new()
    {
        new Campana
        {
            Id = 1,
            Nombre = "CyberWow Electro",
            Categoria = "Electro",
            Estado = "Vigente",
            FechaInicio = new DateTime(2026, 3, 15),
            FechaFin = new DateTime(2026, 3, 31),
            DescuentoPct = 30,
            Canal = "Web",
            Descripcion = "Campaña enfocada en televisores, laptops y accesorios de audio."
        },
        new Campana
        {
            Id = 2,
            Nombre = "Renueva tu Hogar",
            Categoria = "Hogar",
            Estado = "Vigente",
            FechaInicio = new DateTime(2026, 3, 1),
            FechaFin = new DateTime(2026, 4, 1),
            DescuentoPct = 25,
            Canal = "Tienda",
            Descripcion = "Campaña especial para renovar tu hogar con muebles y decoración a precios increíbles."
        },
        new Campana
        {
            Id = 3,
            Nombre = "Fashion Week Lima",
            Categoria = "Moda",
            Estado = "Próxima",
            FechaInicio = new DateTime(2026, 4, 10),
            FechaFin = new DateTime(2026, 4, 20),
            DescuentoPct = 40,
            Canal = "App",
            Descripcion = "Descuentos por temporada en ropa, calzado y accesorios."
        },
        new Campana
        {
            Id = 4,
            Nombre = "Tech Days",
            Categoria = "Tecnología",
            Estado = "Próxima",
            FechaInicio = new DateTime(2026, 5, 1),
            FechaFin = new DateTime(2026, 5, 8),
            DescuentoPct = 35,
            Canal = "Web",
            Descripcion = "Semana promocional de gadgets, smartwatches y periféricos."
        },
        new Campana
        {
            Id = 5,
            Nombre = "Liquidación Verano",
            Categoria = "Moda",
            Estado = "Finalizada",
            FechaInicio = new DateTime(2026, 1, 5),
            FechaFin = new DateTime(2026, 1, 10),
            DescuentoPct = 50,
            Canal = "Tienda",
            Descripcion = "Liquidación de productos de verano con stock limitado."
        },
        new Campana
        {
            Id = 6,
            Nombre = "Electro Fiestas Patrias",
            Categoria = "Electro",
            Estado = "Finalizada",
            FechaInicio = new DateTime(2026, 1, 10),
            FechaFin = new DateTime(2026, 1, 15),
            DescuentoPct = 20,
            Canal = "Web",
            Descripcion = "Promociones especiales para productos electro durante campaña estacional."
        },
        new Campana
        {
            Id = 7,
            Nombre = "Smart Home Fest",
            Categoria = "Tecnología",
            Estado = "Vigente",
            FechaInicio = new DateTime(2026, 3, 20),
            FechaFin = new DateTime(2026, 3, 30),
            DescuentoPct = 15,
            Canal = "App",
            Descripcion = "Campaña de domótica y dispositivos inteligentes para el hogar."
        },
        new Campana
        {
            Id = 8,
            Nombre = "Deco Primavera",
            Categoria = "Hogar",
            Estado = "Próxima",
            FechaInicio = new DateTime(2026, 9, 1),
            FechaFin = new DateTime(2026, 9, 15),
            DescuentoPct = 20,
            Canal = "Tienda",
            Descripcion = "Promociones en decoración, textiles y organización del hogar."
        }
    };

    public List<Campana> ObtenerTodas()
    {
        return _campanas;
    }

    public Campana? ObtenerPorId(int id)
    {
        return _campanas.FirstOrDefault(c => c.Id == id);
    }
}