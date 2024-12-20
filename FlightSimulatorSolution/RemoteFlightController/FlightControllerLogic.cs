using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RemoteFlightController;


namespace FlightControlApp
{
    public class FlightControlLogic
    {

        
        // Using EventHandler<T> for a more standard event pattern
        public event EventHandler<ControlsUpdate> ControlUpdateSent;
        public event EventHandler<TelemetryUpdate> TelemetryUpdateReceived;
        public event EventHandler<string> WarningCodeReceived;

        private string ipAddress;
        private int port;
        private TcpClient client;
        private NetworkStream stream;
        private bool isConnected = false;
        

        public bool IsConnected => client?.Connected ?? false;
        
          
        

        public FlightControlLogic(string ipAddress, int port)
        {
            this.ipAddress = ipAddress;
            this.port = port;
        }

        public void SendControlUpdate(ControlsUpdate controls)
        {
            if (isConnected)
            {
                
                
                    string json = JsonConvert.SerializeObject(controls);
                    byte[] data = Encoding.ASCII.GetBytes(json);
                    stream.Write(data, 0, data.Length);

                    ControlUpdateSent?.Invoke(this, controls);
                }
               
                
            }


        public async Task ConnectAsync()
        {
            try
            {
                client = new TcpClient();
                await client.ConnectAsync(ipAddress, port);
                stream = client.GetStream();
                isConnected = true;
                _ = Task.Run(ListenForTelemetry); // Fire and forget telemetry listener
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to server: {ex.Message}");
                isConnected = false;
                throw;
            }
        }

        private async Task ListenForTelemetry()
        {
            byte[] buffer = new byte[1024];
            while (isConnected)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string json = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        var telemetry = ParseTelemetry(json);
                        TelemetryUpdateReceived?.Invoke(this, telemetry);

                        if (telemetry.WarningCode != 0)
                        {
                            WarningCodeReceived?.Invoke(this, telemetry.WarningCode.ToString());
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error receiving telemetry: {ex.Message}");
                    break; //exit the loop on error
                }
            }  
        }

        private TelemetryUpdate ParseTelemetry(string data)
        {
            try
            {
                var telemetryDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
                return new TelemetryUpdate
                {
                    Altitude = telemetryDict.ContainsKey("Altitude") ? Convert.ToDouble(telemetryDict["Altitude"]) : 0,
                    Speed = telemetryDict.ContainsKey("Speed") ? Convert.ToDouble(telemetryDict["Speed"]) : 0,
                    Pitch = telemetryDict.ContainsKey("Pitch") ? Convert.ToDouble(telemetryDict["Pitch"]) : 0,
                    VerticalSpeed = telemetryDict.ContainsKey("VerticalSpeed") ? Convert.ToDouble(telemetryDict["VerticalSpeed"]) : 0,
                    Throttle = telemetryDict.ContainsKey("Throttle") ? Convert.ToDouble(telemetryDict["Throttle"]) : 0,
                    ElevatorPitch = telemetryDict.ContainsKey("ElevatorPitch") ? Convert.ToDouble(telemetryDict["ElevatorPitch"]) : 0,
                    WarningCode = telemetryDict.ContainsKey("WarningCode") ? Convert.ToInt32(telemetryDict["WarningCode"]) : 0
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error parsing telemetry data: " + ex.Message);
                Console.WriteLine("Raw data: " + data);
                return new TelemetryUpdate(); // Return default object on failure
            };
        }

        public void Disconnect()
        {
            isConnected = false;
            try
            {
                stream?.Close(); // Close the stream if it exists
                client?.Close(); // Close the client if it exists
            }
            catch (Exception ex)
            {
                // Handle disconnection error
                Console.WriteLine($"Error during disconnect: {ex.Message}");
            }
        }

        protected virtual void OnControlUpdateSent(ControlsUpdate e)
        {
            ControlUpdateSent?.Invoke(this, e);
        }

        protected virtual void OnTelemetryUpdateReceived(TelemetryUpdate e)
        {
            TelemetryUpdateReceived?.Invoke(this, e);
        }

        protected virtual void OnWarningCodeReceived(string e)
        {
            WarningCodeReceived?.Invoke(this, e);
        }
        public void Initialize()
        {
            


        }
        public class ControlsUpdate
        {
            public double Throttle { get; set; }
            public double ElevatorPitch { get; set; }
        }
        public class TelemetryUpdate
        {
            public double Altitude { get; set; }
            public double Speed { get; set; }
            public double Pitch { get; set; }
            public double VerticalSpeed { get; set; }
            public double Throttle { get; set; }
            public double ElevatorPitch { get; set; }
            public int WarningCode { get; set; }
        }

    }
}