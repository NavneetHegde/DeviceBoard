
using DeviceBoard.Interfaces;
using DeviceBoard.Type;
using GraphQL;
using GraphQL.Types;

namespace DeviceBoard.Query;
public class DeviceQuery : ObjectGraphType
{
    public DeviceQuery(IDevice deviceServices)
    {
        Field<ListGraphType<DeviceType>>("devices", resolve: context => { return deviceServices.GetAllDevices(); });

        Field<DeviceType>("device", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id"})
           , 
            resolve: context =>
        {
            return deviceServices.GetDeviceById(context.GetArgument<int>("id"));
        });
    }
}
