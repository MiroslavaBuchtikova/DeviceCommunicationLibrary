using System;
using DeviceCommunicationLibrary.Enums;
using Newtonsoft.Json.Linq;

namespace DeviceCommunicationLibrary.MessagePayloads
{
    public abstract class SensorPayload
    {
        public abstract SensorTypes Type { get; }
        
        public Guid SensorId { get; set; }
        public int FloorNumber { get; set; } // Floor number where the sensor is located
        public string BuildingName { get; set; } // Name of the building
        public string WindowName { get; set; } // Name or identifier of the window
        public string OfficeName { get; set; } // Name or identifier of the office
    }
}