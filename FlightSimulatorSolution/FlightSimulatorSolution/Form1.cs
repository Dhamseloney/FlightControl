using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using Newtonsoft.Json;
using RemoteFlightController;

namespace FlightControlApp
{
    public partial class Form1 : Form
    {
        private FlightControlLogic flightController;

        public Form1()
        {
            InitializeComponent();
            flightController = new FlightControlLogic(txtIpAddress.Text, int.Parse(txtPort.Text));
            // Register event handlers
            flightController.TelemetryUpdateReceived += OnTelemetryUpdateReceived;
            flightController.WarningCodeReceived += OnWarningCodeReceived;
            flightController.ControlUpdateSent += OnControlUpdateSent;


            btnDisconnect.Enabled = false; // Initially disable disconnect button
            lblConnectionStatus.Text = "Disconnected";
        }
        
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                    // Initialize flightController only if it hasn't been initialized yet
                    string ipAddress = txtIpAddress.Text;
                    int port = int.Parse(txtPort.Text);
                    flightController = new FlightControlLogic(ipAddress, port);

                    // Register event handlers
                    flightController.TelemetryUpdateReceived += OnTelemetryUpdateReceived;
                    flightController.WarningCodeReceived += OnWarningCodeReceived;
                    flightController.ControlUpdateSent += OnControlUpdateSent;
                

                // Update UI
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                lblConnectionStatus.Text = "Connecting...";

                // Attempt to connect
                await flightController.ConnectAsync();

                // Update UI on success
                lblConnectionStatus.Text = "Connected";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to Connect: {ex.Message}");
                lblConnectionStatus.Text = "Disconnected";
                btnConnect.Enabled = true; // Re-enable the connect button on failure
            }
        }

        private void OnTelemetryUpdateReceived(object sender, FlightControlLogic.TelemetryUpdate telemetry)
        {
            // Update UI elements on the UI thread
            if (this.InvokeRequired)
            {
                Invoke(new Action(() => OnTelemetryUpdateReceived(sender, telemetry)));
                return;
            }

            txtAltitude.Text = telemetry.Altitude.ToString();
            txtSpeed.Text = telemetry.Speed.ToString();
            txtPitch.Text = telemetry.Pitch.ToString();
            txtVerticalSpeed.Text = telemetry.VerticalSpeed.ToString();
            txtThrottle.Text = telemetry.Throttle.ToString();
            txtElevatorPitch.Text = telemetry.ElevatorPitch.ToString();
            txtWarningCode.Text = telemetry.WarningCode.ToString();
        }

        private void OnWarningCodeReceived(object sender, string warning)
        {
            // Update UI elements on the UI thread
            if (this.InvokeRequired)
            {
                Invoke(new Action(() => OnWarningCodeReceived(sender, warning)));
                return;
            }

            lblWarning.Text = $"Warning: {warning}";
        }

        private void OnControlUpdateSent(object sender, FlightControlLogic.ControlsUpdate controls)
        {
            var mappedControls = new FlightControlLogic.ControlsUpdate
            {
                Throttle = controls.Throttle,
                ElevatorPitch = controls.ElevatorPitch,
            };
        }
        private FlightControlLogic.ControlsUpdate MapControlsUpdate(RemoteFlightController.ControlsUpdate source)
        {
            return new FlightControlLogic.ControlsUpdate
            {
                Throttle = source.Throttle,
                ElevatorPitch = source.ElevatorPitch
            };
        }

        private void btnSendControlUpdate_Click(object sender, EventArgs e)
        {
                var controls = new ControlsUpdate
                {
                    Throttle = (double)nudThrottle.Value,
                    ElevatorPitch = (double)nudElevator.Value
                };
                


            
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                flightController?.Disconnect();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                lblConnectionStatus.Text = "Disconnected";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during disconnect: {ex.Message}", "Disconnection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {

        }
    }
}