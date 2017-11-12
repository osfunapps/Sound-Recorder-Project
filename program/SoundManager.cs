using System;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;
using Sound_Recorder_Project.Properties;

namespace Sound_Recorder_Project.program
{
    class SoundManager
    {
        //instances
        private RecordCallback callbak;
        private WaveFileWriter waveFile;
        private static bool recording;
        private WaveInEvent waveSource;


        //string
        internal static string RECORDING_MSG = "yeap :)";

        internal static string NO_RECORDING_MSG = "nope :(\nIt takes the program 4 seconds to run initially.. have you waited 4 seconds lol?\nIf still no go, go to settings ==> apply and restart";

        private string SOUND_SUFFIX = ".wav";
        private string MSG_RECORDING_STARTS = "\n- Start recording";
        private string MSG_RECORDING_ENDS = "\n- End recording. Saved at: ";
        private string fileOutput;


        public SoundManager(RecordCallback callbak)
        {
            this.callbak = callbak;
        }


        public void StartRecording(string wavePath)
        {

            Thread.Sleep(4000);
            SetOutput(wavePath);

            recording = true;
            waveSource.StartRecording();

            int secondsToRun = Settings.Default.recordingCycleTime * 60000;
            Thread.Sleep(secondsToRun);

            waveSource.StopRecording();
            callbak.onRecordFinish();
        }

        private void SetOutput(string wavePath)
        {
            string parsedTime = DateTime.Now.ToShortTimeString().Replace(":", " ");
            fileOutput = wavePath + "\\" + parsedTime + SOUND_SUFFIX;
            RecreateWaveSource();
            waveFile = new WaveFileWriter(fileOutput, waveSource.WaveFormat);
            AppCoordinator.RecordLog += MSG_RECORDING_STARTS ;

        }

        private void RecreateWaveSource()
        {
            waveSource = new WaveInEvent();
            waveSource.WaveFormat = new WaveFormat(Settings.Default.waveRate, 1);
            waveSource.DataAvailable += waveSource_DataAvailable;
            waveSource.RecordingStopped += waveSource_RecordingStopped;
        }

        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }

        void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            AppCoordinator.RecordLog += MSG_RECORDING_ENDS + fileOutput +"\n\n";
            recording = false;

            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }

        }

        internal interface RecordCallback
        {
            void onRecordFinish();
        }


        public static bool Recording
        {
            get => recording;
            set => recording = value;
        }
    }
}
