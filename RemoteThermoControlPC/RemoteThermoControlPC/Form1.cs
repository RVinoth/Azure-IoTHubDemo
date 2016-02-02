using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Devices;
using Microsoft.ServiceBus.Messaging;
using System.Diagnostics;
using System.Runtime.Serialization.Json;
using System.IO;


namespace RemoteThermoControlPC
{
    public partial class Form1 : Form
    {
        static ServiceClient serviceClient;
        static string connectionString = "HostName=remotecamerahub.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=xhuG9TcaieP9s+bNN51KTKy3H73Pw/0Sd8XOyrVJet8=";
        static string iotHubD2cEndpoint = "messages/events";
        static EventHubClient eventHubClient;
        string DeviceID = "RPi2-WinIoT";
        SensorData SensorDataObj;
        int TempThres = 27;
        bool cooleron = false;
        public Form1()
        {
            InitializeComponent();
            SensorDataObj = new SensorData();
            this.Shown += Form_Shown;

        }


        private async void Form_Shown(object sender, EventArgs e)
        {
            try
            {
                serviceClient = ServiceClient.CreateFromConnectionString(connectionString);
                eventHubClient = EventHubClient.CreateFromConnectionString(connectionString, iotHubD2cEndpoint);
                var d2cPartitions = eventHubClient.GetRuntimeInformation().PartitionIds;

                foreach (string partition in d2cPartitions)
                {
                    ReceiveMessagesFromDeviceAsync(partition);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

        }

        public class SensorData
        {
            public double accel_x;
            public double accel_y;
            public double accel_z;
            public double mag_x;
            public double mag_y;
            public double mag_z;
            public double gyro_x;
            public double gyro_y;
            public double gyro_z;
            public double pressure;
            public double temperature;
            public double humidity;
            public string Currentdatetime;
            public string DeviceName;

            public SensorData() { } //required for JSON serializers
            public SensorData(double acc_x, double acc_y, double acc_z,
                              double ma_x, double ma_y, double ma_z,
                              double gyr_x, double gyr_y, double gyr_z,
                              double press, double temp, double humi, string Cdatetime)
            {
                accel_x = acc_x;
                accel_y = acc_y;
                accel_z = acc_z;
                mag_x = ma_x;
                mag_y = ma_y;
                mag_z = ma_z;
                gyro_x = gyr_x;
                gyro_y = gyr_y;
                gyro_z = gyr_z;
                pressure = press;
                temperature = temp;
                humidity = humi;
                Currentdatetime = Cdatetime;
                DeviceName = "Raspberry Pi-2";
            }

        }

        public T Deserialize<T>(string json)
        {
            var _Bytes = Encoding.Unicode.GetBytes(json);
            using (MemoryStream _Stream = new MemoryStream(_Bytes))
            {
                var _Serializer = new DataContractJsonSerializer(typeof(T));
                return (T)_Serializer.ReadObject(_Stream);
            }
        }
        private async Task ReceiveMessagesFromDeviceAsync(string partition)
        {
            var eventHubReceiver = eventHubClient.GetDefaultConsumerGroup().CreateReceiver(partition, DateTime.Now);

            while (true)
            {
                try
                {
                    EventData eventData = await eventHubReceiver.ReceiveAsync();
                    if (eventData == null) continue;
                    byte[] data = eventData.GetBytes();
                    string connectionDeviceId = eventData.SystemProperties["iothub-connection-device-id"].ToString();
                    Debug.WriteLine("Message from " + connectionDeviceId);
                    if (connectionDeviceId != DeviceID)
                        continue;
                    
                        string json = System.Text.Encoding.UTF8.GetString(data);
                        Debug.WriteLine(json);
                        SensorDataObj = Deserialize<SensorData>(json);
                        accx.Invoke(new Action(() =>
                        {
                            accx.Text = SensorDataObj.accel_x.ToString();
                         }));
                        accy.Invoke(new Action(() =>
                        {
                            accy.Text = SensorDataObj.accel_y.ToString();
                        }));
                        accz.Invoke(new Action(() =>
                        {
                            accz.Text = SensorDataObj.accel_z.ToString();
                        }));

                        gyrx.Invoke(new Action(() =>
                        {
                            gyrx.Text = SensorDataObj.gyro_x.ToString();
                        }));
                        gyry.Invoke(new Action(() =>
                        {
                            gyry.Text = SensorDataObj.gyro_y.ToString();
                        }));
                        gyrz.Invoke(new Action(() =>
                        {
                            gyrz.Text = SensorDataObj.gyro_z.ToString();
                        }));
                        max.Invoke(new Action(() =>
                        {
                            max.Text = SensorDataObj.mag_x.ToString();
                        }));
                        may.Invoke(new Action(() =>
                        {
                            may.Text = SensorDataObj.mag_y.ToString();
                        }));
                        maz.Invoke(new Action(() =>
                        {
                            maz.Text = SensorDataObj.mag_z.ToString();
                        }));
                        pressure.Invoke(new Action(() =>
                        {
                            pressure.Text = SensorDataObj.pressure.ToString();
                        }));
                        temperature.Invoke(new Action(() =>
                        {
                            temperature.Text = SensorDataObj.temperature.ToString();
                        }));
                        humi.Invoke(new Action(() =>
                        {
                            humi.Text = SensorDataObj.humidity.ToString();
                        }));
                        msgTime.Invoke(new Action(() =>
                        {
                            msgTime.Text = SensorDataObj.Currentdatetime;
                        }));
                    if (SensorDataObj.temperature >= TempThres)
                    {
                        if (!cooleron)
                        {
                            SendCloudToDeviceMessageAsync("On");    //Power on Cooler
                            sysstatus.Invoke(new Action(() =>
                            {
                                sysstatus.Text = "Cooler ON";
                            }));
                            cooleron = true;
                        }
                    }
                    else
                    {
                        if (cooleron)
                        {
                            SendCloudToDeviceMessageAsync("Off");    //Power on Cooler
                            sysstatus.Invoke(new Action(() =>
                            {
                                sysstatus.Text = "Cooler OFF";
                            }));
                            cooleron = false;
                        }
                    }


                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }

                //  string data = Encoding.UTF8.GetString(eventData.GetBytes());
                //  Debug.WriteLine(string.Format("Message received. Partition: {0} Data: '{1}'", partition, data));
            }
        }

        private void SendCloudToDeviceMessageAsync(string Data)
        {
            try
            {
                var commandMessage = new Microsoft.Azure.Devices.Message(Encoding.ASCII.GetBytes(Data));
                serviceClient.SendAsync(DeviceID, commandMessage);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }


        private void SetTemp_Click(object sender, EventArgs e)
        {
            TempThres = Convert.ToInt16(TempThreshold.Text);
        }
    }
}
