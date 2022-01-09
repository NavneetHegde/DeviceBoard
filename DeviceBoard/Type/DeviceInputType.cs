
using GraphQL.Types;

namespace DeviceBoard.Type;
public class DeviceInputType : InputObjectGraphType
{
    public DeviceInputType()
    {
        Field<IntGraphType>("id");
        Field<StringGraphType>("Location");
        Field<StringGraphType>("Manufacture");
        Field<StringGraphType>("Make");
        Field<StringGraphType>("Model");
        Field<StringGraphType>("SerialNumber");
        Field<StringGraphType>("AssetTagNuber");
        Field<StringGraphType>("Application");
        Field<StringGraphType>("IsCanada");
        Field<StringGraphType>("HasCamera");
        Field<StringGraphType>("IsMocked");
        Field<StringGraphType>("HasAmexKey");
        Field<StringGraphType>("HasFreewayMACKey");
        Field<StringGraphType>("IsProduction");
        Field<StringGraphType>("Status");
        Field<StringGraphType>("Comment");
    }
}
