
using DeviceBoard.Mutation;
using DeviceBoard.Query;

namespace DeviceBoard.Schema;
public class DeviceSchema : GraphQL.Types.Schema
{
    public DeviceSchema(DeviceQuery deviceQuery, DeviceMutation deviceMutation)
    {
        Query = deviceQuery;
        Mutation = deviceMutation;
    }
}
