namespace FlightControlApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.gbController = new System.Windows.Forms.GroupBox();
            this.btnSendControlUpdate = new System.Windows.Forms.Button();
            this.nudElevator = new System.Windows.Forms.NumericUpDown();
            this.nudThrottle = new System.Windows.Forms.NumericUpDown();
            this.lblCE = new System.Windows.Forms.Label();
            this.lblCT = new System.Windows.Forms.Label();
            this.gbTelemetry = new System.Windows.Forms.GroupBox();
            this.txtWarningCode = new System.Windows.Forms.TextBox();
            this.txtElevatorPitch = new System.Windows.Forms.TextBox();
            this.txtThrottle = new System.Windows.Forms.TextBox();
            this.txtVerticalSpeed = new System.Windows.Forms.TextBox();
            this.txtPitch = new System.Windows.Forms.TextBox();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lstSentUpdates = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.gbController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThrottle)).BeginInit();
            this.gbTelemetry.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblConnectionStatus);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIpAddress);
            this.groupBox1.Location = new System.Drawing.Point(57, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(102, 131);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(109, 13);
            this.lblConnectionStatus.TabIndex = 4;
            this.lblConnectionStatus.Text = "Status: Disconnected";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(145, 105);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(42, 105);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(117, 70);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(103, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "9999";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(117, 30);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(103, 20);
            this.txtIpAddress.TabIndex = 0;
            this.txtIpAddress.Text = "192.168.134.121";
            // 
            // gbController
            // 
            this.gbController.Controls.Add(this.btnSendControlUpdate);
            this.gbController.Controls.Add(this.nudElevator);
            this.gbController.Controls.Add(this.nudThrottle);
            this.gbController.Controls.Add(this.lblCE);
            this.gbController.Controls.Add(this.lblCT);
            this.gbController.Location = new System.Drawing.Point(68, 208);
            this.gbController.Name = "gbController";
            this.gbController.Size = new System.Drawing.Size(298, 209);
            this.gbController.TabIndex = 1;
            this.gbController.TabStop = false;
            this.gbController.Text = "groupBox2";
            // 
            // btnSendControlUpdate
            // 
            this.btnSendControlUpdate.Location = new System.Drawing.Point(83, 113);
            this.btnSendControlUpdate.Name = "btnSendControlUpdate";
            this.btnSendControlUpdate.Size = new System.Drawing.Size(142, 23);
            this.btnSendControlUpdate.TabIndex = 4;
            this.btnSendControlUpdate.Text = "Send Control Update";
            this.btnSendControlUpdate.UseVisualStyleBackColor = true;
            // 
            // nudElevator
            // 
            this.nudElevator.Location = new System.Drawing.Point(134, 70);
            this.nudElevator.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudElevator.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudElevator.Name = "nudElevator";
            this.nudElevator.Size = new System.Drawing.Size(120, 20);
            this.nudElevator.TabIndex = 3;
            // 
            // nudThrottle
            // 
            this.nudThrottle.Location = new System.Drawing.Point(6, 70);
            this.nudThrottle.Name = "nudThrottle";
            this.nudThrottle.Size = new System.Drawing.Size(120, 20);
            this.nudThrottle.TabIndex = 2;
            // 
            // lblCE
            // 
            this.lblCE.AutoSize = true;
            this.lblCE.Location = new System.Drawing.Point(150, 34);
            this.lblCE.Name = "lblCE";
            this.lblCE.Size = new System.Drawing.Size(75, 13);
            this.lblCE.TabIndex = 1;
            this.lblCE.Text = "ElevationPitch";
            // 
            // lblCT
            // 
            this.lblCT.AutoSize = true;
            this.lblCT.Location = new System.Drawing.Point(52, 34);
            this.lblCT.Name = "lblCT";
            this.lblCT.Size = new System.Drawing.Size(43, 13);
            this.lblCT.TabIndex = 0;
            this.lblCT.Text = "Throttle";
            // 
            // gbTelemetry
            // 
            this.gbTelemetry.Controls.Add(this.txtWarningCode);
            this.gbTelemetry.Controls.Add(this.txtElevatorPitch);
            this.gbTelemetry.Controls.Add(this.txtThrottle);
            this.gbTelemetry.Controls.Add(this.txtVerticalSpeed);
            this.gbTelemetry.Controls.Add(this.txtPitch);
            this.gbTelemetry.Controls.Add(this.txtAltitude);
            this.gbTelemetry.Controls.Add(this.txtSpeed);
            this.gbTelemetry.Location = new System.Drawing.Point(499, 36);
            this.gbTelemetry.Name = "gbTelemetry";
            this.gbTelemetry.Size = new System.Drawing.Size(197, 283);
            this.gbTelemetry.TabIndex = 2;
            this.gbTelemetry.TabStop = false;
            this.gbTelemetry.Text = "groupBox3";
            // 
            // txtWarningCode
            // 
            this.txtWarningCode.Location = new System.Drawing.Point(56, 242);
            this.txtWarningCode.Name = "txtWarningCode";
            this.txtWarningCode.Size = new System.Drawing.Size(103, 20);
            this.txtWarningCode.TabIndex = 7;
            // 
            // txtElevatorPitch
            // 
            this.txtElevatorPitch.Location = new System.Drawing.Point(56, 206);
            this.txtElevatorPitch.Name = "txtElevatorPitch";
            this.txtElevatorPitch.Size = new System.Drawing.Size(103, 20);
            this.txtElevatorPitch.TabIndex = 6;
            // 
            // txtThrottle
            // 
            this.txtThrottle.Location = new System.Drawing.Point(56, 172);
            this.txtThrottle.Name = "txtThrottle";
            this.txtThrottle.Size = new System.Drawing.Size(103, 20);
            this.txtThrottle.TabIndex = 5;
            // 
            // txtVerticalSpeed
            // 
            this.txtVerticalSpeed.Location = new System.Drawing.Point(56, 133);
            this.txtVerticalSpeed.Name = "txtVerticalSpeed";
            this.txtVerticalSpeed.Size = new System.Drawing.Size(103, 20);
            this.txtVerticalSpeed.TabIndex = 4;
            // 
            // txtPitch
            // 
            this.txtPitch.Location = new System.Drawing.Point(56, 96);
            this.txtPitch.Name = "txtPitch";
            this.txtPitch.Size = new System.Drawing.Size(103, 20);
            this.txtPitch.TabIndex = 3;
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(56, 19);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(103, 20);
            this.txtAltitude.TabIndex = 2;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(56, 58);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(103, 20);
            this.txtSpeed.TabIndex = 1;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Crimson;
            this.lblWarning.Location = new System.Drawing.Point(515, 356);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(47, 13);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "Warning";
            // 
            // lstSentUpdates
            // 
            this.lstSentUpdates.FormattingEnabled = true;
            this.lstSentUpdates.Location = new System.Drawing.Point(513, 387);
            this.lstSentUpdates.Name = "lstSentUpdates";
            this.lstSentUpdates.Size = new System.Drawing.Size(229, 43);
            this.lstSentUpdates.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSentUpdates);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.gbTelemetry);
            this.Controls.Add(this.gbController);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbController.ResumeLayout(false);
            this.gbController.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThrottle)).EndInit();
            this.gbTelemetry.ResumeLayout(false);
            this.gbTelemetry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbController;
        private System.Windows.Forms.GroupBox gbTelemetry;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblCT;
        private System.Windows.Forms.Label lblCE;
        private System.Windows.Forms.NumericUpDown nudElevator;
        private System.Windows.Forms.NumericUpDown nudThrottle;
        private System.Windows.Forms.Button btnSendControlUpdate;
        private System.Windows.Forms.TextBox txtElevatorPitch;
        private System.Windows.Forms.TextBox txtThrottle;
        private System.Windows.Forms.TextBox txtVerticalSpeed;
        private System.Windows.Forms.TextBox txtPitch;
        private System.Windows.Forms.TextBox txtAltitude;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtWarningCode;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ListBox lstSentUpdates;
    }
}

