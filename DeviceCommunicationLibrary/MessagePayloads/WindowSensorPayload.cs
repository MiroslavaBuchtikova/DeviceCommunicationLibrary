namespace DeviceCommunicationLibrary.MessagePayloads
{
    public class WindowSensorPayload : SensorPayload
    {
        public bool IsWindowOpen { get; set; } // Indicates if the window is open (true) or closed (false)
    }
}