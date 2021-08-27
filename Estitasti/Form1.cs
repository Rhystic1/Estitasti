using Estitasti.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Estitasti
{
    public partial class Estitasti : Form
    {
        public Estitasti()
        {
            InitializeComponent();
        }

        private void estiButton_Click(object sender, EventArgs e)
        {
            /// string Numb = RandomSel.RandomNumber();
            RandomSel.RandomNumber();
            switch(RandomSel.RandomNumber()) // randomly selects an option (an audio clip) every time we press the button
            {
                case "ESTI_001.wav":
                    SoundPlayer sndPing = new SoundPlayer(Resource1.ESTI_001);
                    sndPing.Play();
                    break;
                case "ESTI_002.wav":
                    SoundPlayer sndPing1 = new SoundPlayer(Resource1.ESTI_002);
                    sndPing1.Play();
                    break;
                case "ESTI_003.wav":
                    SoundPlayer sndPing2 = new SoundPlayer(Resource1.ESTI_003);
                    sndPing2.Play();
                    break;
                case "ESTI_004.wav":
                    SoundPlayer sndPing3 = new SoundPlayer(Resource1.ESTI_004);
                    sndPing3.Play();
                    break;
                case "ESTI_005.wav":
                    SoundPlayer sndPing4 = new SoundPlayer(Resource1.ESTI_005);
                    sndPing4.Play();
                    break;
                case "ESTI_006.wav":
                    SoundPlayer sndPing5 = new SoundPlayer(Resource1.ESTI_006);
                    sndPing5.Play();
                    break;
                case "ESTI_007.wav":
                    SoundPlayer sndPing6 = new SoundPlayer(Resource1.ESTI_007);
                    sndPing6.Play();
                    break;
                case "ESTI_008.wav":
                    SoundPlayer sndPing7 = new SoundPlayer(Resource1.ESTI_008);
                    sndPing7.Play();
                    break;
                default:
                    break;
            }
        }
    }
}
