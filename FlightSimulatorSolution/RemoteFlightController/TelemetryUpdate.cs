using Newtonsoft.Json;

namespace RemoteFlightController
{
    public struct TelemetryUpdate
    {
        [JsonProperty("Altitude")]
        public double Altitude { get; set; }

        [JsonProperty("Speed")]
        public double Speed { get; set; }

        [JsonProperty("Pitch")]
        public double Pitch { get; set; }

        [JsonProperty("VerticalSpeed")]
        public double VerticalSpeed { get; set; }

        [JsonProperty("Throttle")]
        public double Throttle { get; set; }

        [JsonProperty("ElevatorPitch")]
        public double ElevatorPitch { get; set; }

        [JsonProperty("WarningCode")]
        public int WarningCode { get; set; }
    }
}