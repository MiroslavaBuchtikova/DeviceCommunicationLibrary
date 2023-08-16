namespace DeviceCommunicationLibrary;

public interface IDeviceMessage<TDevice, TPayload> where TDevice : IDevice
{
    TDevice Device { get; }
    DateTime Timestamp { get; }
    TPayload Payload { get; }
}

public interface IDevice
{
    string DeviceId { get; }
}