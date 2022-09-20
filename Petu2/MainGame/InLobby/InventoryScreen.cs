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
    public partial class InventoryScreen : Form
    {
        public static InventoryScreen Instance;
        public Hra.ChestTier JakaJeOtevirana = new Hra.ChestTier();
        public InventoryScreen()
        {
            InitializeComponent();

            Debug.WriteLine("Loading Inventory:");
            this.TopMost = true;
            Instance = this;
            for (int i = 0; i != 3; i++)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Size = new Size(521, 310);
                flowLayoutPanel.AutoScroll = true;
                switch (i)
                {
                    case 0:
                        Debug.WriteLine("Food");
                        FoodPage.Controls.Add(flowLayoutPanel);
                        foreach (Hra.Food a in Hra.ActivePet.foods)
                        {
                            Debug.WriteLine("- " + a.ID);
                            InventorySlot b = new InventorySlot(a);
                            flowLayoutPanel.Controls.Add(b);
                            
                            foreach (object d in b.Controls)
                            {
                                if (d.GetType().ToString() == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox e = (PictureBox)d;
                                    if (e.Name == "Confirm")
                                    {
                                        e.BackColor = Hra.GetColorOfRarity(a.rarity);
                                    }
                                }
                            }
                        }

                        break;
                    case 1:
                        Debug.WriteLine("Hats");

                        HatPage.Controls.Add(flowLayoutPanel);
                        foreach (Hra.Hat a in Hra.ActivePet.hats)
                        {
                            Debug.WriteLine("- " + a.ID);
                            InventorySlot b = new InventorySlot(a);
                            foreach (object d in b.Controls)
                            {
                                if (d.GetType().ToString() == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox e = (PictureBox)d;
                                    if (e.Name == "Confirm")
                                    {
                                        e.BackColor = Hra.GetColorOfRarity(a.rarity);
                                    }
                                }
                            }
                            flowLayoutPanel.Controls.Add(b);
                        }
                        break;
                    case 2:
                        Debug.WriteLine("GraphicCards");

                        MisicTab.Controls.Add(flowLayoutPanel);

                        foreach (Hra.GraphicCard a in Hra.ActivePet.graphicCards)
                        {
                            Debug.WriteLine("- " + a.ID);
                            InventorySlot b = new InventorySlot(a);
                            foreach (object d in b.Controls)
                            {
                                if (d.GetType().ToString() == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox e = (PictureBox)d;
                                    if (e.Name == "Confirm")
                                    {
                                        e.BackColor = Hra.GetColorOfRarity(a.rarity);
                                    }
                                }
                            }
                            flowLayoutPanel.Controls.Add(b);
                        }

                        Debug.WriteLine("Tickets");
                        foreach (Hra.Ticket a in Hra.ActivePet.tickets)
                        {
                            Debug.WriteLine("- " + a.ID);
                            InventorySlot b = new InventorySlot(a);
                            foreach (object d in b.Controls)
                            {
                                if (d.GetType().ToString() == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox e = (PictureBox)d;
                                    if (e.Name == "Confirm")
                                    {
                                        e.BackColor = Hra.GetColorOfRarity(a.rarity);
                                    }
                                }
                            }
                            flowLayoutPanel.Controls.Add(b);
                        }
                        Debug.WriteLine("Chests");
                        foreach (Hra.Chest a in Hra.ActivePet.chests)
                        {
                            Debug.WriteLine("- " + a.ID);
                            a.ReloadImage();
                            InventorySlot b = new InventorySlot(a);

                            foreach (object d in b.Controls)
                            {
                                if (d.GetType().ToString() == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox e = (PictureBox)d;
                                    if (e.Name == "Confirm")
                                    {
                                        e.BackColor = Hra.GetColorOfRarity(a.rarity);
                                    }
                                }
                            }
                            flowLayoutPanel.Controls.Add(b);
                        }
                        break;
                }
                


            }
            Debug.WriteLine("Done");



        }

        public void ReloadInventory()
        {
            Debug.WriteLine("Reloading Inventory");

            this.Controls.Clear();
            InitializeComponent();
            for (int i = 0; i != 3; i++)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Size = new Size(521, 310);
                flowLayoutPanel.AutoScroll = true;
                switch (i)
                {
                    case 0:
                        Debug.WriteLine("Food");
                        FoodPage.Controls.Add(flowLayoutPanel);
                        foreach (Hra.Food a in Hra.ActivePet.foods)
                        {
                            Debug.WriteLine("- " + a.ID);
                            InventorySlot b = new InventorySlot(a);
                            foreach (object d in b.Controls)
                            {
                                if (d.GetType().ToString() == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox e = (PictureBox)d;
                                    if (e.Name == "Confirm")
                                    {
                                        e.BackColor = Hra.GetColorOfRarity(a.rarity);
                                    }
                                }
                            }
                            flowLayoutPanel.Controls.Add(b);

                        }


                        break;
                    case 1:
                        Debug.WriteLine("Hats");
                        HatPage.Controls.Add(flowLayoutPanel);
                        foreach (Hra.Hat a in Hra.ActivePet.hats)
                        {
                            Debug.WriteLine("- " + a.ID);
                            InventorySlot b = new InventorySlot(a);
                            foreach (object d in b.Controls)
                            {
                                if (d.GetType().ToString() == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox e = (PictureBox)d;
                                    if (e.Name == "Confirm")
                                    {
                                        e.BackColor = Hra.GetColorOfRarity(a.rarity);
                                    }
                                }
                            }
                            flowLayoutPanel.Controls.Add(b);
                        }
                        break;
                    case 2:
                        MisicTab.Controls.Add(flowLayoutPanel);
                        Debug.WriteLine("GraphicCard");
                        foreach (Hra.GraphicCard a in Hra.ActivePet.graphicCards)
                        {
                            Debug.WriteLine("- " + a.ID);
                            InventorySlot b = new InventorySlot(a);
                            foreach (object d in b.Controls)
                            {
                                if (d.GetType().ToString() == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox e = (PictureBox)d;
                                    if (e.Name == "Confirm")
                                    {
                                        e.BackColor = Hra.GetColorOfRarity(a.rarity);
                                    }
                                }
                            }
                            flowLayoutPanel.Controls.Add(b);
                        }
                        Debug.WriteLine("Ticket");
                        foreach (Hra.Ticket a in Hra.ActivePet.tickets)
                        {
                            Debug.WriteLine("- " + a.ID);
                            InventorySlot b = new InventorySlot(a);
                            foreach (object d in b.Controls)
                            {
                                if (d.GetType().ToString() == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox e = (PictureBox)d;
                                    if (e.Name == "Confirm")
                                    {
                                        e.BackColor = Hra.GetColorOfRarity(a.rarity);
                                    }
                                }
                            }
                            flowLayoutPanel.Controls.Add(b);
                        }
                        Debug.WriteLine("Chest");
                        foreach (Hra.Chest a in Hra.ActivePet.chests)
                        {
                            Debug.WriteLine("- " + a.ID);
                            InventorySlot b = new InventorySlot(a);
                            foreach (object d in b.Controls)
                            {
                                if (d.GetType().ToString() == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox e = (PictureBox)d;
                                    if (e.Name == "Confirm")
                                    {
                                        e.BackColor = Hra.GetColorOfRarity(a.rarity);
                                    }
                                }
                            }
                            flowLayoutPanel.Controls.Add(b);
                        }
                        break;
                }


            }
            Debug.WriteLine("Done");
        }

        public void RemoveItem(int Category, string ID)
        {
            switch (Category)
            {
                case 0:
                    int counter = 0;
                    int selectedint = -1;
                    foreach (object a in FoodPage.Controls[0].Controls)
                    {
                        InventorySlot b = (InventorySlot)a;
                        if (b.Tag.ToString() == ID)
                        {
                            selectedint = counter;
                        }
                        counter++;

                    }
                    if (selectedint != -1)
                    {
                        FoodPage.Controls[0].Controls.RemoveAt(selectedint);
                    }
                    break;
                case 1:
                    int counter1 = 0;
                    int selectedint1 = -1;

                    foreach (object a in HatPage.Controls[0].Controls)
                    {
                        InventorySlot b = (InventorySlot)a;
                        if (b.Tag.ToString() == ID)
                        {
                            selectedint1 = counter1;
                        }
                        counter1++;

                    }
                    if (selectedint1 != -1)
                    {
                        HatPage.Controls[0].Controls.RemoveAt(selectedint1);
                    }
                    break;
               
                case 2:
                    int counter2 = 0;
                    int selectedint2 = -1;
                    
                    foreach (object a in MisicTab.Controls[0].Controls)
                    {
                        InventorySlot b = (InventorySlot)a;
                        if (b.Tag.ToString() == ID)
                        {
                            selectedint2 = counter2;
                        }
                        counter2++;

                    }
                    if (selectedint2 != -1)
                    {
                        MisicTab.Controls[0].Controls.RemoveAt(selectedint2);
                    }
                    break;

            }
        }
       
        private void CloseThis(object sender, EventArgs e)
        {
            MainGameScreen.instance.InventoryOpened = false;
            this.Close();
        }

        private bool mouseDown;
        private Point lastLocation;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
