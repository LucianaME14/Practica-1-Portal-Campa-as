namespace PortalCampanas.Models;

public class ResumenCampanasViewModel
{
    public int TotalCampanas { get; set; }
    public int CampanasVigentes { get; set; }
    public int CampanasProximas { get; set; }
    public decimal PromedioDescuento { get; set; }
    public Dictionary<string, int> CantidadPorCanal { get; set; } = new();
}