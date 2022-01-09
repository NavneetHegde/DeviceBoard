
using DeviceBoard.Data;
using DeviceBoard.Interfaces;
using DeviceBoard.Models;
using System.Collections.Generic;
using System.Linq;

namespace DeviceBoard.Services;
public class DeviceService : IDevice
{
    private GraphQLDbContext _dbContext;

    public DeviceService(GraphQLDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public Device AddDevice(Device device)
    {
        _dbContext.Devices.Add(device);
        _dbContext.SaveChanges();
        return device;
    }

    public void DeleteDevice(int id)
    {
        var deviceObject = _dbContext.Devices.Find(id);
        _dbContext.Devices.Remove(deviceObject);
        _dbContext.SaveChanges();
    }

    public List<Device> GetAllDevices()
    {
        return _dbContext.Devices.ToList();
    }

    public Device GetDeviceById(int id)
    {
        return _dbContext.Devices.Find(id);
    }

    public Device UpdateDevice(int id, Device device)
    {
        var deviceObject = _dbContext.Devices.Find(id);
        deviceObject.Status = device.Status;
        deviceObject.Comment = device.Comment;
        _dbContext.SaveChanges();
        return device;
    }
}
