using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stream_Deck
{
    public partial class StreamDeck : Form
    {
        public StreamDeck()
        {
            InitializeComponent();
        }

        SoundPlayer simpleSound;

        public string SoundsFilePath { get; set; } = Path.Join(Application.StartupPath, "Media");

        private void BTN_APAREIAGE_Click(object sender, EventArgs e)
        {

        }

        private void BTN_swoosh_Click(object sender, EventArgs e)
        {
            simpleSound = new SoundPlayer(Path.Combine(SoundsFilePath, "swoosh.wav"));
            simpleSound.Play();
        }

        private void BTN_AIAI_Click(object sender, EventArgs e)
        {
            simpleSound = new SoundPlayer(Path.Combine(SoundsFilePath, "aiai.wav"));
            simpleSound.Play();
        }
    }
}
