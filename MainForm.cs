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

namespace G31DDCExample
{
    public partial class MainForm : Form
    {
        #region Members

        private Wrapper wrapper = new Wrapper();
        private WaveOutHandler waveOutHandler = new WaveOutHandler();

        private delegate void WrapperDD2PreprocessedStreamCallbackHandler(object sender, DDC2PreprocessedStreamEventArgs eventArgs);
        private delegate void WrapperAudioStreamCallbackHandler(object sender, AudioStreamEventArgs eventArgs);

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

                panelMain.Enabled = true;

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

                buttonConnection.Enabled = true;

                panelMain.Enabled = false;
            }

            trackBarFrequency.Enabled = panelMain.Enabled;
        }

        #endregion

        #region GUI Event Handlers

        private void OnMainFormLoad(object theSender, EventArgs theEventArgs)
        {
            wrapper.deviceDDC2PreprocessedStreamReceived += new Wrapper.DeviceDDC2PreprocessedStreamReceivedHandler(OnWrapperDDC2PreprocessedStreamReceived);
            wrapper.deviceAudioStreamReceived += new Wrapper.DeviceAudioStreamReceivedHandler(OnWrapperAudioStreamReceived);

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
        }

        private void OnButtonConnectionClick(object theSender, EventArgs theEventArgs)
        {
            InitializeDeviceConnection();
        }

        private void OnNumericUpDownFrequencyValueChanged(object theSender, EventArgs theEventArgs)
        {
            trackBarFrequency.Value = (int)numericUpDownFrequency.Value;
        }

        #endregion

        #region Wrapper Event Handlers        
        
        private void OnWrapperDDC2PreprocessedStreamReceived(object theSender, EventArgs theEventArgs)
        {
            // If method was called from the same thread, handle received data
            if (!InvokeRequired)
            {
                DDC2PreprocessedStreamEventArgs anEventArgs = (DDC2PreprocessedStreamEventArgs)theEventArgs;

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

        private void OnWrapperAudioStreamReceived(object theSender, EventArgs theEventArgs)
        {
            if (!waveOutHandler.isOpened)
            {
                return;
            }

            // If method was called from the same thread, handle received data
            if (!InvokeRequired)
            {

                AudioStreamEventArgs anEventArgs = (AudioStreamEventArgs)theEventArgs;

                // Display audio level
                int aValue = 0;
                for (int anIx = 0; anIx < anEventArgs.numberOfSamples; anIx++)
                {
                    aValue = (int)Math.Max(aValue, 100 * Math.Abs(anEventArgs.buffer[anIx]));
                }
                //progressBarAudioLevel.Value = aValue < progressBarAudioLevel.Maximum ? aValue : progressBarAudioLevel.Maximum; 

                // Write to waveOut
                waveOutHandler.Write(anEventArgs.buffer, anEventArgs.numberOfSamples);
            }
            // Else, if this method was called from API thread, call it again from the same thread 
            else
            {
                // Prepare calling the method from the same thread
                WrapperAudioStreamCallbackHandler aWrapperHandler = new WrapperAudioStreamCallbackHandler(OnWrapperAudioStreamReceived);
                object aSender = Thread.CurrentThread;

                BeginInvoke(aWrapperHandler, new object[] { aSender, theEventArgs });
            }
        }

        #endregion

        private void groupBoxAudioLevel_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxSignalLevel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
