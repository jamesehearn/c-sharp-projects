/*
 * Program: Audio Browser
 * Programmer: James E. Hearn
 * Description: The extreme beginning stages of development of
 *              a C# program that will be able to search for 
 *              audio files, using an SQL database, display
 *              the selected file to the user, visually, and
 *              play the file back.
 *              
 *              This program currenlty plays back wave files, 
 *              using the NAudio library.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace AudioBrowser
{    
    public partial class browserForm : Form
    {       
        public browserForm()
        {
            InitializeComponent();
        }
        
        private WaveOut waveOut;
        private WaveFileReader reader;

        private void playButton_Click(object sender, EventArgs e)
        {
            waveOut = new WaveOut();
            waveOut.PlaybackStopped += waveOut_PlaybackStopped;
            reader = new WaveFileReader("sample.wav");
            waveOut.Init(reader);
            waveOut.Play();
        }

        private void waveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            reader.Dispose();
            waveOut.Dispose();
            //throw new NotImplementedException();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (var reader = new AudioFileReader("sample.wav"))
            {
                int xPos = 2;
                var yScale = 50;

                var topPoints = new List<Point>();
                var bottomPoints = new List<Point>();

                var samplesPerSecond = reader.WaveFormat.SampleRate * reader.WaveFormat.Channels;
                var readBuffer = new float[samplesPerSecond];

                int samplesRead;
            }
        }
/*
                do
                {
                    samplesRead = reader.Read(readBuffer, 0, samplesPerSecond);
                    if (samplesPerSecond > 0)
                    {
                        var max = readBuffer.Take(samplesRead).Max();
                        topPoints.Add(new Point(xPos, yScale + max * yScale));
                        bottomPoints.Add(new Point(xPos, yScale - max * yScale));
                        xPos += 2;
                    }

                } while (samplesRead > 0);
 
            }
 
            var polyline = new Polyline();
                
        }
 */               
        private void stopButton_Click(object sender, EventArgs e)
        {
            waveOut.Stop();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
