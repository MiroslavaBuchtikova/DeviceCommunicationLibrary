using System;
using DeviceCommunicationLibrary.MessagePayloads;

namespace DeviceCommunicationLibrary
{
    public interface IDeviceMessage<TDevice, TPayload>
        where TDevice : IDevice
        where TPayload : SensorPayload
    {
        TDevice Device { get; }
        DateTime Timestamp { get; }
        TPayload Payload { get; }
    }
}