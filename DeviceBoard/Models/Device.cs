
namespace DeviceBoard.Models;
public class Device
{
    public int Id { get; set; }
    public string Location { get; set; }
    public string Manufacture { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public string AssetTagNuber { get; set; }
    public string Application { get; set; }
    public bool IsCanada { get; set; } = false;
    public bool HasCamera { get; set; } = false;
    public bool IsMocked { get; set; } = false;
    public bool HasAmexKey { get; set; } = false;
    public int HasFreewayMACKey { get; set; }
    public bool IsProduction { get; set; } = false;
    public string Status { get; set; }
    public string Comment { get; set; }
}
