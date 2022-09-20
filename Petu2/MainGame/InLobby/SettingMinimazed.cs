using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Petu2.MainGame.InLobby
{
    public partial class SettingMinimazed : UserControl
    {
        bool changeAllowed = false;
        public SettingMinimazed()
        {
            
            InitializeComponent();
            trackBar1.Value = SettingsMinimazedSetUp.Default.Opacity;
            checkBox1.Checked = SettingsMinimazedSetUp.Default.CanMove;
            changeAllowed = true;
            switch (SettingsMinimazedSetUp.Default.DefaulPosition)
            {
                case 0:
                    ButTopLeft.Checked = true;
                    break;
                case 1:
                    ButTopRight.Checked = true;
                    break;
                case 2:
                    ButBotLeft.Checked = true;
                    break;
                case 3:
                    ButBotRight.Checked = true;
                    break;
            }
        }

        private void OpacitySettings(object sender, EventArgs e)
        {
            if (changeAllowed)
            {
                SettingsMinimazedSetUp.Default.Opacity = trackBar1.Value;
                SettingsMinimazedSetUp.Default.Save();
                MainMinimazed.instance.Reload();
            }
        }

        private void MovableSeting(object sender, EventArgs e)
        {
            if (changeAllowed)
            {
                SettingsMinimazedSetUp.Default.CanMove = checkBox1.Checked;
                SettingsMinimazedSetUp.Default.Save();
                MainMinimazed.instance.Reload();
            }
        }

        private void TopLeft(object sender, EventArgs e)
        {
            if (ButTopLeft.Checked)
            {
                SettingsMinimazedSetUp.Default.DefaulPosition = 0;
                SettingsMinimazedSetUp.Default.Save();
            }
        }

        private void TopRight(object sender, EventArgs e)
        {
            if (ButTopRight.Checked)
            {
                SettingsMinimazedSetUp.Default.DefaulPosition = 1;
                SettingsMinimazedSetUp.Default.Save();
            }
        }

        private void BotLeft(object sender, EventArgs e)
        {
            if (ButBotLeft.Checked)
            {
                SettingsMinimazedSetUp.Default.DefaulPosition = 2;
                SettingsMinimazedSetUp.Default.Save();
            }
        }

        private void BotRight(object sender, EventArgs e)
        {
            if (ButBotRight.Checked)
            {
                SettingsMinimazedSetUp.Default.DefaulPosition = 3;
                SettingsMinimazedSetUp.Default.Save();
            }
        }
    }
}
