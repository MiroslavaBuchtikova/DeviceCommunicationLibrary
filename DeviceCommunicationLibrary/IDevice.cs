using System;

namespace DeviceCommunicationLibrary
{
    public interface IDevice
    {
        public Guid DeviceId { get; set; }
        public string Location { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}