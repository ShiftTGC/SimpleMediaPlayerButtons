using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//Almost copy-paste pretty much... Was hoping there would be more of a learning explanation to it. 
//Or that they would kind of explain the "why"s per say. They did not.
//https://ourcodeworld.com/articles/read/128/how-to-play-pause-music-or-go-to-next-and-previous-track-from-windows-using-c-valid-for-all-windows-music-players
//They did show me it tho and after a little bit of digging, well, I somewhat understand how it works now, but, eh, idk.
//Code has been "made". If anything, I managed to add the "stop" button that basically doesn't get used anymore.
//Small things, small things. 
namespace SimpleMediaPlayerButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public const int KEYEVENTF_EXTENTEDKEY = 1;
        public const int KEYEVENTF_KEYUP = 0;
        public const int VK_MEDIA_NEXT_TRACK = 0xB0;// code to jump to next track
        public const int VK_MEDIA_PLAY_PAUSE = 0xB3;// code to play or pause a song
        public const int VK_MEDIA_PREV_TRACK = 0xB1;// code to jump to prev track
        public const int VK_MEDIA_STOP = 0xB2;// code to stop a song
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);
        private void TrackPlayPause_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void TrackPrev_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void TrackNext_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }

        private void TrackStop_Click(object sender, EventArgs e)
        {
            keybd_event(VK_MEDIA_STOP, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }
    }
}
