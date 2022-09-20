using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Petu2.Hra;

namespace Petu2.MainGame.InLobby
{
    public partial class ChestOpen : Form
    {
        // List do kterého je možno davat boxy které se točí
        public List<PictureBox> Items = new List<PictureBox>();

        // Začínací rychlost
        double rychlost = 20;
        // Doba kterou system čaka než předmět udělí (v milisekundach)
        int counterProdlouzeni = 75;

        Hra.ChestTier TierTetoChestky = new Hra.ChestTier();

        public ChestOpen()
        {
            InitializeComponent();
            // Získanání Tieru
            TierTetoChestky = InventoryScreen.Instance.JakaJeOtevirana;

            // Vytvoření prvního boxu
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(80, 80);
            Random random = new Random();
            pictureBox.Tag = "First";
            pictureBox.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            pictureBox.Location = BaseBox.Location;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = Hra.GetRandomItemFoodPicturebox().Image;
            Items.Add(pictureBox);
            this.Controls.Add(pictureBox);

            // Aby to nebylo po každé stejné
            rychlost = random.Next(20, 25);
        }


        // Movable 
        // Slouží aby se to dalo přesouvat
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
        //Movable



        private void MoveItems(object sender, EventArgs e)
        {

            //System.Diagnostics.Debug.WriteLine(rychlost);
            for (int i = 0; i != Items.Count; i++)
            {
                Items[i].Location = new Point(Items[i].Location.X + Convert.ToInt32(Math.Round(rychlost)), Items[i].Location.Y);

                if (Items[i].Tag.ToString() == "First" && Items[i].Location.X > 0)
                {
                    Items[i].Tag = "Next";

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(80, 80);
                    Random random = new Random();

                    int NahodaCommon = 100;
                    int NahodaRare = 100;
                    int NahodaEpic = 100;
                    int NahodaLegendary = 100;

                    switch (TierTetoChestky)
                    {
                        case Hra.ChestTier.Wooden:
                            NahodaCommon -= GetSancePriRarity.WoodenCommon;
                            NahodaRare -= GetSancePriRarity.WoodenRare;
                            NahodaEpic -= GetSancePriRarity.WoodenEpic;
                            NahodaLegendary -= GetSancePriRarity.WoodenLegendary;
                            break;
                        case Hra.ChestTier.Iron:
                            NahodaCommon -= GetSancePriRarity.IronCommon;
                            NahodaRare -= GetSancePriRarity.IronRare;
                            NahodaEpic -= GetSancePriRarity.IronEpic;
                            NahodaLegendary -= GetSancePriRarity.IronLegendary;
                            break;
                        case Hra.ChestTier.Gold:
                            NahodaCommon -= GetSancePriRarity.GoldCommon;
                            NahodaRare -= GetSancePriRarity.GoldRare;
                            NahodaEpic -= GetSancePriRarity.GoldEpic;
                            NahodaLegendary -= GetSancePriRarity.GoldLegendary;
                            break;
                    }
                    pictureBox.BackColor = Color.Black;
                    int sance = random.Next(1, 94);
                    if (sance <= NahodaCommon)
                    {
                        pictureBox.BackColor = Color.Green;
                    }
                    else if (sance <= NahodaRare)
                    {
                        pictureBox.BackColor = Color.LightBlue;
                    }
                    else if (sance <= NahodaEpic)
                    {
                        pictureBox.BackColor = Color.Purple;
                    }
                    else if (sance <= NahodaLegendary)
                    {
                        pictureBox.BackColor = Color.Orange;
                    }

                    //pictureBox.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                    pictureBox.Location = BaseBox.Location;

                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Tag = "First";

                    PictureBox Provizorni = Hra.GetRandomItemFoodPicturebox();
                    pictureBox.Image = Provizorni.Image;
                    pictureBox.Name = Provizorni.Name;
                    System.Diagnostics.Debug.WriteLine(pictureBox.Name);

                    Items.Add(pictureBox);
                    this.Controls.Add(pictureBox);

                }

                if (Items[i].Location.X > 600 && Items[i].Enabled == true)
                {
                    Items[i].Enabled = false;
                    Items[i].Visible = false;
                }
            }
            if (rychlost > 0)
            {
                rychlost -= 0.05;
            }
            else
            {
                rychlost = 0;
                counterProdlouzeni--;
                Debug.WriteLine(counterProdlouzeni);
                if (counterProdlouzeni < 0)
                {
                    TimeBetweenMove.Stop();

                    int count = 0;
                    for (int i = 0; i != Items.Count; i++)
                    {
                        if (Items[i].Location.X > 600)
                        {
                            count++;
                        }
                    }


                    Items.RemoveRange(0, count);
                    System.Diagnostics.Debug.WriteLine(Items.Count);
                    List<Konecny> NejblisziHodnoty = new List<Konecny>();
                    for (int i = 0; i != Items.Count; i++)
                    {
                        NejblisziHodnoty.Add(new Konecny(Distance(pictureBox2.Location, new Point(Items[i].Location.X + 40, Items[0].Location.Y)), Items[i]));
                    }
                    List<Konecny> serazeny = NejblisziHodnoty.OrderBy(o => o.vzdalenost).ToList();

                    Hra.Rarity raritaPredmetu = new Hra.Rarity();
                    raritaPredmetu = Hra.Rarity.Common;
                    if (serazeny[0].objektJmenoPictureBox.BackColor == Color.Green)
                    {
                        raritaPredmetu = Hra.Rarity.Common;
                    }
                    if (serazeny[0].objektJmenoPictureBox.BackColor == Color.LightBlue)
                    {
                        raritaPredmetu = Hra.Rarity.Rare;
                    }
                    if (serazeny[0].objektJmenoPictureBox.BackColor == Color.Purple)
                    {
                        raritaPredmetu = Hra.Rarity.Epic;
                    }
                    if (serazeny[0].objektJmenoPictureBox.BackColor == Color.Orange)
                    {
                        raritaPredmetu = Hra.Rarity.Legendary;
                    }
                    Debug.WriteLine(serazeny[0].objektJmenoPictureBox.Name);

                    Hra.Photo fotkapredmetu = (Hra.Photo)Enum.Parse(typeof(Hra.Photo), serazeny[0].objektJmenoPictureBox.Name.ToString());

                    GetReward(raritaPredmetu, fotkapredmetu, serazeny[0].objektJmenoPictureBox.Name.ToString(), serazeny[0].objektJmenoPictureBox.BackColor);

                }



            }
            

        }
        public void GetReward(Hra.Rarity a, Hra.Photo b, string nazev, Color barvapozadi)
        {

            string nazevPredmetu = nazev;

            this.Controls.Clear();
            InitializeComponent();
            TimeBetweenMove.Stop();
            this.Size = new Size(300, 300);
            button1.Visible = false;
            pictureBox2.Visible = false;

            Button CloseThisClaim = new Button();

            CloseThisClaim.Location = new Point(75, 240);
            CloseThisClaim.Size = new Size(150, 50);
            CloseThisClaim.Text = "Claim";
            CloseThisClaim.Click += Close;
            CloseThisClaim.Font = new Font("Windows Command Prompt", 24f);
            this.Controls.Add(CloseThisClaim);

            PictureBox Preview = new PictureBox()
            {
                Size = new Size(150, 150),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(75, 25),
                Image = Hra.GetObrazekPhoto(b),
                BackColor = barvapozadi,
            };
            this.Controls.Add(Preview);

            float velikostTextu = 24f;
            if (nazevPredmetu.Length > 37)
            {
                velikostTextu = 15f;
            }
            Label Properties = new Label()
            {
                Text = nazevPredmetu,
                TextAlign = ContentAlignment.TopCenter,
                Size = new Size(300, 80),
                Location = new Point(0, 175),
                Font = new Font("Windows Command Prompt", velikostTextu)
            };
            this.Controls.Add(Properties);

            // Pridani predmetu
            int jidloPridani = 0;
            switch (a)
            {
                case Hra.Rarity.Common: jidloPridani = 150;
                    break;
                case Hra.Rarity.Rare:
                    jidloPridani = 300;
                    break;
                case Hra.Rarity.Epic:
                    jidloPridani = 600;
                    break;
                case Hra.Rarity.Legendary:
                    jidloPridani = 900;
                    break;
            }
            Hra.Food NovyPredmet = new Hra.Food(nazev, a, b, jidloPridani);
            Hra.ActivePet.foods.Add(NovyPredmet);
            Hra.SaveViaDataContractSerialization(Hra.pets, "ulozeni.xml");
            InventoryScreen.Instance.ReloadInventory();
            this.TopMost = true;
        }
        public void GetRewardSkip()
        {
            Hra.Food GetThisItem = Hra.GetRandomFoodItem(Hra.ChestTier.Wooden);
            string nazevPredmetu = GetThisItem.Name;

            this.Controls.Clear();
            InitializeComponent();
            TimeBetweenMove.Stop();
            this.Size = new Size(300, 300);
            button1.Visible = false;
            pictureBox2.Visible = false;

            Button CloseThisClaim = new Button();

            CloseThisClaim.Location = new Point(75, 240);
            CloseThisClaim.Size = new Size(150, 50);
            CloseThisClaim.Text = "Claim";
            CloseThisClaim.Click += Close;
            CloseThisClaim.Font = new Font("Windows Command Prompt", 24f);
            this.Controls.Add(CloseThisClaim);

            PictureBox Preview = new PictureBox()
            {
                Size = new Size(150, 150),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(75, 25),
                Image = GetThisItem.PicutureToView,
                BackColor = Hra.GetColorOfRarity(GetThisItem.rarity),
            };
            this.Controls.Add(Preview);

            //    TextBox Properties = new TextBox()
            //    {
            //        Text = "To Be addedaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab",
            //        TextAlign = HorizontalAlignment.Center,
            //        Size = new Size(300, 50),
            //        Location = new Point(0, 175),
            //        BorderStyle = BorderStyle.None,
            //        Font = new Font("Windows Command Prompt", 24f),
            //        Multiline = true,

            //     };
            //    this.Controls.Add(Properties);

            float velikostTextu = 24f;
            if (nazevPredmetu.Length > 37)
            {
                velikostTextu = 15f;
            }
            Label Properties = new Label()
            {
                Text = nazevPredmetu,
                TextAlign = ContentAlignment.TopCenter,
                Size = new Size(300, 80),
                Location = new Point(0, 175),
                Font = new Font("Windows Command Prompt", velikostTextu)
            };
            this.Controls.Add(Properties);

            // Pridani predmetu

           
            Hra.ActivePet.foods.Add(GetThisItem);
            Hra.SaveViaDataContractSerialization(Hra.pets, "ulozeni.xml");
            InventoryScreen.Instance.ReloadInventory();
            this.TopMost = true;
        }

        public int Distance(Point a, Point b)
        {
            double c = Math.Round(Math.Sqrt((Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2))));
            return Convert.ToInt32(c);
        }

        private void SkipButton(object sender, EventArgs e)
        {
            
            rychlost = 0;
            TimeBetweenMove.Stop();

            int count = 0;
            for (int i = 0; i != Items.Count; i++)
            {
                if (Items[i].Location.X > 600)
                {
                    count++;
                }
            }

            Items.RemoveRange(0, count);
            
            
            GetRewardSkip();

        }
        private void Close(object sender, EventArgs e)
        {
            this.Close();

        }
        public class Konecny
        {
            public int vzdalenost;
            public PictureBox objektJmenoPictureBox;
            public Konecny(int vzdalenost, PictureBox objektJmenoPictureBox)
            {
                this.vzdalenost = vzdalenost;
                this.objektJmenoPictureBox = objektJmenoPictureBox;
            }
        }
    }
    
}
