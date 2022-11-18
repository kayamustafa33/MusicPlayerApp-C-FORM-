using Guna.UI2.WinForms.Helpers;
using Siticone.Desktop.UI.WinForms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            new SiticoneShadowForm(this);
            new SiticoneDragControl(this);


            PanelSlider.Controls.Add(new HomePage());
            PanelSlider.Controls.Add(new SearchPage());           
            PanelSlider.Controls.Add(new SettingsPage());

        }


        private void HomeBtnClicked_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("HomePage", false)[0].BringToFront();
        }

        private void SearchBtnClicked_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("SearchPage", false)[0].BringToFront();
        }       

        private void SettingsBtnClicked_Click(object sender, EventArgs e)
        {
            PanelSlider.Controls.Find("SettingsPage", false)[0].BringToFront();
        }
    }
}