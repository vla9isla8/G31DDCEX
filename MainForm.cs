using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using G31DDCAPIWrapperSpace;
using System.IO;

namespace G31DDCExample
{
    public partial class MainForm : Form
    {
        #region Members

        private Wrapper wrapper                 =   new Wrapper();
        private WaveOutHandler waveOutHandler   =   new WaveOutHandler();
        private delegate void WrapperDD2PreprocessedStreamCallbackHandler(object sender, DDC2PreprocessedStreamEventArgs eventArgs);
        //private delegate void WrapperAudioStreamCallbackHandler(object sender, AudioStreamEventArgs eventArgs);

        public float[] IQDataBuffer;

        public float[] BUFFER
        {
            get
            {
                return IQDataBuffer;
            }
        }

        private int Loops = 1;

        private int compleetedLoops = 0;

        private StreamWriter fileStream;
        private Wrapper.DeviceDDC2PreprocessedStreamReceivedHandler Handler;
        private string filepath;
        private string fileSize;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void InitializeDeviceConnection()
        {
            if (wrapper.Init())
            {
                G31DDCAPIWrapperDeviceInfo aDeviceInfo = wrapper.deviceInfo;

                textBoxSerialNumber.Text = aDeviceInfo.serialNumber;
                textBoxInterface.Text = aDeviceInfo.interfaceType == G31DDCAPIWrapper.DEVICE_INTERFACE_USB ? "USB" : "PCI";

                // Frequency range
                wrapper.SetFrequency(0 /* As minimum */);
                numericUpDownFrequency.Minimum = trackBarFrequency.Minimum = (int)wrapper.GetFrequency();
                wrapper.SetFrequency(123456789 /* As maximum */);
                numericUpDownFrequency.Maximum = trackBarFrequency.Maximum = (int)wrapper.GetFrequency();
                textBoxFrequencyRange.Text = trackBarFrequency.Minimum + " to " + trackBarFrequency.Maximum;

                numericUpDownFrequency.Value = trackBarFrequency.Value;
            }
            else
            {
                toolStripStatusLabel.ForeColor = Color.Red;
                if (wrapper.apiStatus == Wrapper.APISTATUS_WRAPPERLIBRARY_NOTFOUND)
                {
                    toolStripStatusLabel.Text = "Unable to find " + Wrapper.APIWRAPPERLIBRARY + " library!";
                }
                else
                {
                    toolStripStatusLabel.Text = "Unable to find device!";
                }
            }

            HandleDeviceConnection();
        }

        private void HandleDeviceConnection()
        {
            if (wrapper.IsDeviceConnected())
            {

                toolStripStatusLabel.ForeColor = Color.Black;
                toolStripStatusLabel.Text = "Device connected";

                buttonConnection.Enabled = false;

                groupBoxFrequency.Enabled = groupBoxSignalLevel.Enabled = true;
                groupBoxFrequency.Visible = groupBoxSignalLevel.Visible = true;

                timerConnection.Start();
            }
            else
            {
                timerConnection.Stop();

                wrapper.CloseDevice();

                toolStripStatusLabel.ForeColor = Color.Red;
                toolStripStatusLabel.Text = "Device not connected";

                textBoxSerialNumber.Text = textBoxInterface.Text = textBoxFrequencyRange.Text = textBoxSignalLevel.Text = "";
                trackBarFrequency.Value = trackBarFrequency.Minimum = 0;
                progressBarAudioLevel.Value = 0;
                numericUpDownFrequency.Value = numericUpDownFrequency.Minimum = 0;

                groupBoxFrequency.Enabled = groupBoxSignalLevel.Enabled  = false;
                groupBoxFrequency.Visible = groupBoxSignalLevel.Visible  = false;

                buttonConnection.Enabled = true;

            }

            trackBarFrequency.Enabled = panelMain.Enabled;
        }

        #endregion

        #region GUI Event Handlers

        private void OnMainFormLoad(object theSender, EventArgs theEventArgs)
        {
            wrapper.deviceDDC2PreprocessedStreamReceived += new Wrapper.DeviceDDC2PreprocessedStreamReceivedHandler(OnWrapperDDC2PreprocessedStreamReceived);
            //wrapper.deviceAudioStreamReceived += new Wrapper.DeviceAudioStreamReceivedHandler(OnWrapperAudioStreamReceived);

            InitializeDeviceConnection();
        }

        private void OnMainFormClosing(object theSender, FormClosingEventArgs theEventArgs)
        {
            timerConnection.Stop();

            if (waveOutHandler.isOpened)
            {
                waveOutHandler.Close();
            }

            if (wrapper.IsDeviceConnected())
            {
                wrapper.CloseDevice();
            }
        }

        private void OnTrackBarFrequencyValueChanged(object theSender, EventArgs theEventArgs)
        {
            if (wrapper.IsDeviceConnected())
            {
                wrapper.SetFrequency((UInt32)trackBarFrequency.Value);
                UInt32 aFrequency = wrapper.GetFrequency();
                numericUpDownFrequency.Value = aFrequency;
            }
        }

        private void OnTimerConnectionTick(object theSender, EventArgs theEventArgs)
        {
            HandleDeviceConnection();

            label1.Text = fileSize;
        }

        private void OnButtonConnectionClick(object theSender, EventArgs theEventArgs)
        {
            InitializeDeviceConnection();
        }

        private void OnNumericUpDownFrequencyValueChanged(object theSender, EventArgs theEventArgs)
        {
            trackBarFrequency.Value = (int)numericUpDownFrequency.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Wrapper Event Handlers
        
        private void OnWrapperDDC2PreprocessedStreamReceived(object theSender, EventArgs theEventArgs)
        {
            // If method was called from the same thread, handle received data
            if (!InvokeRequired)
            {
                DDC2PreprocessedStreamEventArgs anEventArgs = (DDC2PreprocessedStreamEventArgs)theEventArgs;

                IQDataBuffer   =   anEventArgs.buffer;

                double aValue = 10.0 * Math.Log10(Math.Pow(anEventArgs.sLevelRms, 2) * (1000.0 / 50.0));
                
                textBoxSignalLevel.Text = aValue.ToString("N1") + " dBm";

                progressBarAudioLevel.Value = (int)(aValue + 120)*10;

            
            }
            // Else, if this method was called from API thread, call it again from the same thread 
            else
            {
                // Prepare calling the method from the same thread
                WrapperDD2PreprocessedStreamCallbackHandler aWrapperHandler = new WrapperDD2PreprocessedStreamCallbackHandler(OnWrapperDDC2PreprocessedStreamReceived);
                object aSender = Thread.CurrentThread;

                BeginInvoke(aWrapperHandler, new object[] { aSender, theEventArgs });
            }
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            graph graph = new graph(this);
            graph.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Handler = new Wrapper.DeviceDDC2PreprocessedStreamReceivedHandler(OnReseaveSaveToFile);

            wrapper.deviceDDC2PreprocessedStreamReceived += Handler;

        }

        private void OnReseaveSaveToFile(object sender, EventArgs eventArgs)
        {
            if (fileStream == null || fileStream.BaseStream == null)
            {
                filepath = @DateTime.Today.Day.ToString() + ".txt";

                fileStream = new StreamWriter(filepath);
            }

            for (int i = 0; i < IQDataBuffer.Length; i++)
            {
                fileStream.WriteLine(IQDataBuffer[i] + ";" + IQDataBuffer[++i] + "\n");
            }

            fileSize = new FileInfo(filepath).Length.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wrapper.deviceDDC2PreprocessedStreamReceived -= Handler;

            fileStream.Close();
        }


    }
}
