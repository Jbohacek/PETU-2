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
    public partial class LeftControlPanel : UserControl
    {
        public LeftControlPanel()
        {
            InitializeComponent();
            
        }

        private void GetBack(object sender, EventArgs e)
        {
            MainGameScreen.instance.Close();
            MainScreen aa = new MainScreen();
            aa.Show();
        }

        private void ClosePanel(object sender, EventArgs e)
        {
            if (MainGameScreen.instance.CanBeClosed == true)
            {
                MainGameScreen.instance.CanBeClosed = false;
                MainGameScreen.instance.a = new Timer();
                MainGameScreen.instance.a.Interval = 1;
                MainGameScreen.instance.a.Tick += MainGameScreen.instance.MovePanel;
                MainGameScreen.instance.a.Start();
                MainGameScreen.instance.a.Tag = "Close";
            }
        }
    }
}
