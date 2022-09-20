using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu2.MainGame.InLobby
{
    public partial class MainMinimazed : Form
    {
        public bool CanMove = true;
        public static MainMinimazed instance;
        public MainMinimazed()
        {
            InitializeComponent();
            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(res.Width - Size.Width);
            RightTop.Visible = false;
            RightBot.Visible = true;
            LeftBot.Visible = true;
            LeftTop.Visible = true;
            instance = this;
            settingMinimazed1.Location = new Point(68, 72);
            PicOfPet.Image = Hra.ActivePet.ImageOfPet;
            this.TopMost = true;
            settingMinimazed1.BringToFront();
            switch (SettingsMinimazedSetUp.Default.DefaulPosition)
            {
                case 0:
                    this.Location = new Point(0, 0);
                    RightTop.Visible = true;
                    RightBot.Visible = true;
                    LeftBot.Visible = true;
                    LeftTop.Visible = false;
                    break;
                case 1:
                    Rectangle resc = Screen.PrimaryScreen.Bounds;
                    this.Location = new Point(resc.Width - Size.Width);
                    RightTop.Visible = false;
                    RightBot.Visible = true;
                    LeftBot.Visible = true;
                    LeftTop.Visible = true;
                    break;
                case 2:
                    Rectangle resa = Screen.PrimaryScreen.Bounds;
                    this.Location = new Point(0, (resa.Height - Size.Height) - 40);
                    RightTop.Visible = true;
                    RightBot.Visible = true;
                    LeftBot.Visible = false;
                    LeftTop.Visible = true;
                    break;
                case 3:
                    Rectangle resb = Screen.PrimaryScreen.Bounds;
                    this.Location = new Point(resb.Width - Size.Width, (resb.Height - Size.Height) - 40);
                    RightTop.Visible = true;
                    RightBot.Visible = false;
                    LeftBot.Visible = true;
                    LeftTop.Visible = true;
                    break;
            }
            Reload();
        }
        public void Reload()
        {
            this.Opacity = Convert.ToDouble(SettingsMinimazedSetUp.Default.Opacity)/100;
            this.CanMove = SettingsMinimazedSetUp.Default.CanMove;
            
        }
        private void GetBack(object sender, EventArgs e)
        {
            MainGameScreen.instance.Show();
            this.Hide();
        }

        private void GoRightBot(object sender, EventArgs e)
        {
            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(res.Width - Size.Width,(res.Height - Size.Height) - 40);
            RightTop.Visible = true;
            RightBot.Visible = false;
            LeftBot.Visible = true;
            LeftTop.Visible = true;
        }

        private void GoLeftBot(object sender, EventArgs e)
        {
            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(0, (res.Height - Size.Height) - 40);
            RightTop.Visible = true;
            RightBot.Visible = true;
            LeftBot.Visible = false;
            LeftTop.Visible = true;
        }

        private void GoLeftUp(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            RightTop.Visible = true;
            RightBot.Visible = true;
            LeftBot.Visible = true;
            LeftTop.Visible = false;
        }

        private void GoRightUp(object sender, EventArgs e)
        {
            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(res.Width - Size.Width);
            RightTop.Visible = false;
            RightBot.Visible = true;
            LeftBot.Visible = true;
            LeftTop.Visible = true;
        }

        private void ShowSettings(object sender, EventArgs e)
        {
            if (settingMinimazed1.Visible)
            {
                settingMinimazed1.Visible = false;
            }
            else
            {
                settingMinimazed1.Visible = true;
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void MainMinimazed_MouseDown(object sender, MouseEventArgs e)
        {
            
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainMinimazed_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MainMinimazed_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && CanMove)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainMinimazed_LocationChanged(object sender, EventArgs e)
        {
            RightTop.Visible = true;
            RightBot.Visible = true;
            LeftBot.Visible = true;
            LeftTop.Visible = true;
        }
        public void SetHunger(int a)
        {
            FrontFood.Size = new Size(a, FrontFood.Height);
        }
    }
}
