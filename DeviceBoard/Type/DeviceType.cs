
using DeviceBoard.Models;
using GraphQL.Types;

namespace DeviceBoard.Type;
public class DeviceType : ObjectGraphType<Device>
{
    public DeviceType()
    {
        Field(d => d.Id);
        Field(d => d.Location);
        Field(d => d.Manufacture);
        Field(d => d.Make);
        Field(d => d.Model);
        Field(d => d.SerialNumber);
        Field(d => d.AssetTagNuber);
        Field(d => d.Application);
        Field(d => d.IsCanada);
        Field(d => d.HasCamera);
        Field(d => d.IsMocked);
        Field(d => d.HasAmexKey);
        Field(d => d.HasFreewayMACKey);
        Field(d => d.IsProduction);
        Field(d => d.Status);
        Field(d => d.Comment);
    }
}
