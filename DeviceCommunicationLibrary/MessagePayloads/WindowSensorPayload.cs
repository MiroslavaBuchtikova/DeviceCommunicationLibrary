namespace DeviceCommunicationLibrary.MessagePayloads;

public class MagneticSensorPayload
{
    public bool IsWindowOpen { get; set; } // Indicates if the window is open (true) or closed (false)
    public int FloorNumber { get; set; } // Floor number where the sensor is located
    public string BuildingName { get; set; } // Name of the building
    public string WindowName { get; set; } // Name or identifier of the window
    public string OfficeName { get; set; } // Name or identifier of the office
}