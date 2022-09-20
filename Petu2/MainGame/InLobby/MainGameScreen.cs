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
    public partial class MainGameScreen : Form
    {
        public static MainGameScreen instance;
        public MainMinimazed aa;
        public MainGameScreen()
        {
            InitializeComponent();
            instance = this;
            aa = new MainMinimazed();
            Reloader.Start();
            NameOfPet.Text = Hra.ActivePet.Name;
            PetImage.Image = Hra.ActivePet.ImageOfPet;

            leftControlPanel1.Location = new Point(-150, 0);
            leftControlPanel1.BringToFront();


            
        }

        private void OpenMinimazed(object sender, EventArgs e)
        {
            aa.Show();
            this.Hide();
        }

        public bool CanBeOpenned = true;
        public bool CanBeClosed = false;
        public Timer a;
        private void OpenPanel(object sender, EventArgs e)
        {
            if (InventoryScreen.Instance != null)
            {
                InventoryScreen.Instance.Close();
            }
            if (CanBeOpenned)
            {
                CanBeOpenned = false;
                a = new Timer();
                a.Interval = 1;
                a.Tick += MovePanel;
                a.Start();
                a.Tag = "Open";
            }
            
            
        }
        public void MovePanel(object sender, EventArgs e)
        {
            if (a != null)
            {
                if (a.Tag.ToString() == "Open")
                {
                    if (leftControlPanel1.Location.X == 0)
                    {
                        a.Stop();
                        a = null;
                        CanBeClosed = true;
                    }
                    else
                    {
                        leftControlPanel1.Location = new Point(leftControlPanel1.Location.X + 15, 0);
                    }
                }
                else if (a.Tag.ToString() == "Close")
                {
                    if (leftControlPanel1.Location.X == -150)
                    {
                        a.Stop();
                        a = null;
                        CanBeOpenned = true;
                    }
                    else
                    {
                        leftControlPanel1.Location = new Point(leftControlPanel1.Location.X - 15, 0);
                    }
                }
            }

        }
        public bool InventoryOpened = false;
        private void OpenInventory(object sender, EventArgs e)
        {
            if (InventoryOpened == false)
            {
                InventoryOpened = true;
                InventoryScreen screen = new InventoryScreen();
                screen.Show();
            }
            else
            {
                InventoryScreen.Instance.Close();
                InventoryOpened = false;
            }
            
        }

        private void FoodGetDown(object sender, EventArgs e)
        {
            Hra.ActivePet.Hunger--;
        }

        private void ReloadHungerAndXp(object sender, EventArgs e)
        {
            if (Hra.ActivePet.Hunger > 500)
            {
                Hra.ActivePet.Hunger = 500;
            }
            FooIndicator.Text = Math.Max(Math.Round((Convert.ToDouble(Hra.ActivePet.Hunger) * 2) / 10),0).ToString();
            FrontFood.Size = new Size(Math.Max(0,Hra.ActivePet.Hunger), FrontFood.Height);
            MainMinimazed.instance.SetHunger(Math.Max(0,Convert.ToInt32(Math.Round(Convert.ToDouble(Hra.ActivePet.Hunger) * 0.4))));
        }
        public void AddFoodToPet(int HowMuch)
        {
            Hra.ActivePet.Hunger += HowMuch;
        }

        private void GoAdventure(object sender, EventArgs e)
        {
            if (InventoryScreen.Instance != null)
            {
                InventoryScreen.Instance.Close();
            }
            
            MainGame.Adventure.GameRoomTemplate a = new Adventure.GameRoomTemplate();
            a.Show();
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            if (InventoryScreen.Instance != null)
            {
                InventoryScreen.Instance.Close();
            }
        }
    }
}
