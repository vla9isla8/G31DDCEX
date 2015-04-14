using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G31DDCExample
{
    public class DDC2PreprocessedStreamEventArgs : EventArgs
    {
        public UInt32 channel;
        public float[] buffer;
        public UInt32 numberOfSamples;
        public float sLevelPeak;
        public float sLevelRms;
    }

    public class AudioStreamEventArgs : EventArgs
    {
        public UInt32 channel;
        public float[] buffer;
        public UInt32 numberOfSamples;
    }
}
