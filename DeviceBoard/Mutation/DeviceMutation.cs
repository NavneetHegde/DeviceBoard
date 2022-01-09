
using DeviceBoard.Interfaces;
using DeviceBoard.Models;
using DeviceBoard.Type;
using GraphQL;
using GraphQL.Types;

namespace DeviceBoard.Mutation;
public class DeviceMutation : ObjectGraphType
{
    public DeviceMutation(IDevice deviceServices)
    {

        Field<DeviceType>("createDevice", arguments: new QueryArguments(new QueryArgument<DeviceInputType> { Name = "device" }),
            resolve: context =>
            {
                return deviceServices.AddDevice(context.GetArgument<Device>("device"));
            });

        Field<DeviceType>("updateDevice", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" },
            new QueryArgument<DeviceInputType> { Name = "device" }),
            resolve: context =>
            {
                var deviceObj = context.GetArgument<Device>("device");
                var deviceId = context.GetArgument<int>("id");
                return deviceServices.UpdateDevice(deviceId, deviceObj);
            });

        Field<DeviceType>("deleteDevice", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
           resolve: context =>
           {
               var deviceId = context.GetArgument<int>("id");
               deviceServices.DeleteDevice(deviceId);
               return "Device is deleted";
           });


    }
}
