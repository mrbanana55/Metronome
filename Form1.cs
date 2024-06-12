using Metronome.Properties;
using System.Media;
using System.Windows.Forms;

namespace Metronome
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        static bool play = false; //to determine wether the metronome is playing or not
        int tempo;


        private void SetBeatsPerSecond()
        {
            tempo = Convert.ToInt32(Bpm.Value);  // Get the BPM value from Bpm
            double beatsPerSecond = tempo / 60.0;  // Calculate beats per second
            double interval = (1000 / beatsPerSecond);  // Calculate the interval in milliseconds
            Timer.Interval = (int)interval;  // Set the timer interval
        }
        private void PlayPause_Click(object sender, EventArgs e)
        {
            //Changes the Play/Pause button
            if (!play)
            {
                PlayPause.Image = Resources.Play;
                play = true;
                Timer.Enabled = false;
                Beat.Image = Resources.BlackBeat;
            }
            else
            {
                SetBeatsPerSecond();
                PlayPause.Image = Resources.Pause;
                play = false;
                Timer.Enabled = true;
            }


        }

        private void Bpm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetBeatsPerSecond();

                // Prevent the beep sound on Enter key press
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\dlega\Desktop\Metronome\Sounds\BeatSound.wav");
            sound.Play();
            Beat.Image = Resources.WhiteBeat;
            BeatChanger.Start();

        }

        private void BeatChanger_Tick(object sender, EventArgs e)
        {
            Beat.Image = Resources.BlackBeat;
            BeatChanger.Stop();
        }

        private void Bpm_ValueChanged(object sender, EventArgs e)
        {
            SetBeatsPerSecond();
        }
    }
}
