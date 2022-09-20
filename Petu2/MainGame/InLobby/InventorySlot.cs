using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu2.MainGame.InLobby
{
    public partial class InventorySlot : UserControl
    {
        public string ItemId;
        public int FoodToAdd;
        public int ButtonType;
        public InventorySlot(Hra.Food a)
        {
            InitializeComponent();
            PictureOfItem.Image = a.PicutureToView;
            ItemName.Text = a.Name;
            ItemId = a.ID;
            this.Tag = ItemId;
            ItemAttribute.Visible = true;
            FoodToAdd = a.HowMuchToAdd;
            ItemAttribute.Text = "+ " + Math.Round(Convert.ToDouble(a.HowMuchToAdd) / 10).ToString();
            ButtonType = 0;
        }
        public InventorySlot(Hra.Hat a)
        {
            InitializeComponent();
            PictureOfItem.Image = a.PicutureToView;
            ItemName.Text = a.Name;
            ItemId = a.ID;
            this.Tag = ItemId;
            ButtonType = 1;
        }
        public InventorySlot(Hra.Ticket a)
        {
            InitializeComponent();
            PictureOfItem.Image = a.PicutureToView;
            ItemName.Text = a.Name;
            ItemId = a.ID;
            this.Tag = ItemId;
            ButtonType = 2;
        }
        public InventorySlot(Hra.GraphicCard a)
        {
            InitializeComponent();
            PictureOfItem.Image = a.PicutureToView;
            ItemName.Text = a.Name;
            ItemId = a.ID;
            this.Tag = ItemId;
            ButtonType = 3;
        }
        public InventorySlot(Hra.Chest a)
        {
            InitializeComponent();
            PictureOfItem.Image = a.PicutureToView;
            ItemName.Text = a.Name;
            ItemId = a.ID;
            this.Tag = ItemId;
            ButtonType = 4;
            Open_Button.Visible = true;
            Open_Button.Click += UseItem;
            Confirm.Click -= UseItem;
        }

        private void UseItem(object sender, EventArgs e)
        {
            int counter = 0;
            int selectedint = -1;
            System.Diagnostics.Debug.WriteLine(sender.GetType().ToString());
            switch (sender.GetType().ToString())
            {
                case "System.Windows.Forms.PictureBox":
                    PictureBox btn = sender as PictureBox;
                    Debug.WriteLine("Used item: " + btn.Parent.Tag.ToString());
                    ItemId = btn.Parent.Tag.ToString();
                    break;
                case "System.Windows.Forms.Button":
                    Button btn2 = sender as Button;
                    Debug.WriteLine("Used item: " + btn2.Parent.Tag.ToString());
                    ItemId = btn2.Parent.Tag.ToString();
                    break;
            }

            switch (ButtonType)
            {
                case 0:

                    foreach (Hra.Food a in Hra.ActivePet.foods)
                    {
                        if (a.ID == ItemId)
                        {
                            selectedint = counter;
                        }
                        counter++;
                    }
                    if (selectedint != -1)
                    {
                        Hra.ActivePet.foods.RemoveAt(selectedint);
                    }
                    InventoryScreen.Instance.RemoveItem(0, ItemId);
                    MainGameScreen.instance.AddFoodToPet(FoodToAdd);
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:

                    foreach (Hra.Chest a in Hra.ActivePet.chests)
                    {
                        if (a.ID == ItemId)
                        {
                            selectedint = counter;
                        }
                        counter++;
                    }
                    InventoryScreen.Instance.JakaJeOtevirana = Hra.ActivePet.chests[selectedint].ChestTier;
                    System.Diagnostics.Debug.WriteLine(InventoryScreen.Instance.JakaJeOtevirana);
                    if (selectedint != -1)
                    {
                        Hra.ActivePet.chests.RemoveAt(selectedint);
                    }

                    InventoryScreen.Instance.RemoveItem(2, ItemId);
                   

                    ChestOpen chestOpen = new ChestOpen();
                    chestOpen.Show();
                    break;
            }
        }
    }
}
