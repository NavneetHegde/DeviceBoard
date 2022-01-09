
using DeviceBoard.Models;
using System.Collections.Generic;

namespace DeviceBoard.Interfaces;
public interface IDevice
{
    List<Device> GetAllDevices();
    Device GetDeviceById (int id);
    Device AddDevice (Device device);
    Device UpdateDevice(int id, Device device);
    void DeleteDevice (int id);

}
