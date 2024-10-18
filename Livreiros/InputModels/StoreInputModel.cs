using Livreiros.Models.Enums;

namespace Livreiros.InputModels;

public class StoreInputModel
{
    public string Name { get; set; } = string.Empty;
    public TypeOfStore TypeOfStore { get; set; }
    public string State { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool IsAlwaysAvailable { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public DateTime BusinessHours { get; set; }
}