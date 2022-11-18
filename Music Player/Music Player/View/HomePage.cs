using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            int minute = now.Minute;
            int hour = now.Hour;
            if(hour >= 17 || hour <= 5)
            {
                timeText.Text = "Good Evening";
            }
            else
            {
                timeText.Text = "Good Morning";
            }

            HomePanelSlider.Controls.Add(new LikedSongs());
            HomePanelSlider.Controls.Add(new NewMusics());
            HomePanelSlider.Controls.Add(new HotHitsTurkey());


        }

        private void likedSongsClicked_Click(object sender, EventArgs e)
        {
            HomePanelSlider.Controls.Find("LikedSongs", false)[0].BringToFront();
        }

        private void newMusicClicked_Click(object sender, EventArgs e)
        {
            HomePanelSlider.Controls.Find("NewMusics", false)[0].BringToFront();
        }

        private void hotHitsClicked_Click(object sender, EventArgs e)
        {
            HomePanelSlider.Controls.Find("HotHitsTurkey", false)[0].BringToFront();
        }
    }
}
