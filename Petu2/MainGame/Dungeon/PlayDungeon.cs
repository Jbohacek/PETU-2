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
using static System.Net.Mime.MediaTypeNames;


namespace Petu2.MainGame.Dungeon
{
    public partial class PlayDungeon : Form
    {
        enum Strany {Nahoru,Dolu,Doleva,Doprava, none }

        Strany PohybHorizontalne = new Strany();
        Strany PohybVerticalne = new Strany();

        List<Point> PosledniPolohy20 = new List<Point>();
        
        double Rychlost = 0;

        LoadingBox LoadBox = new LoadingBox();

        public Policko[,] polickos = new Policko[3,3];
        public List<PictureBox> Tmy = new List<PictureBox>();
        public PlayDungeon()
        {

            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            Cursor.Position = new Point(this.PointToScreen(Player.Location).X + Player.Width / 2, this.PointToScreen(Player.Location).Y + Player.Height);
            Cursor.Hide();
            PohybHorizontalne = Strany.Doprava;
            PohybVerticalne = Strany.Nahoru;

            //public enum Typy {
            //  None - 0
            //, Empty - 1
            //, Starter - 2
            //, Tressure - 3
            //, LockTressure - 4 
            //};
            Random rnd = new Random();

            int[,] GeneracniRada = { {0,0,0 },{0,0,0 },{0,0,0 } };
            int StartX = rnd.Next(0, 2);
            System.Threading.Thread.Sleep(20);
            int StartY = rnd.Next(0, 2);
            GeneracniRada[StartX, StartY] = 2;

            //Nesmí být na středu
            if (GeneracniRada[1, 1] == 2) { GeneracniRada[1, 2] = 2; GeneracniRada[1, 1] = 0; }

            int Delka = 4;
            
            for (int i = 0; i != Delka; i++)
            {
                int KamPujde = rnd.Next(0, 3);

                switch (KamPujde)
                {
                    case 0://Nahoru

                        break;
                    case 1://Dolu
                        break;
                    case 2://Doleva
                        break;
                    case 3://Doprava
                        break;
                }
            }



            for (int i = 0; i != 3; i++)
            {
                for (int j = 0; j != 3; j++)
                {
                    switch (GeneracniRada[i, j])
                    {
                        case 0:
                            polickos[i, j] = new Policko(i, j , Policko.Typy.None);
                            break;
                        case 2:
                            polickos[i, j] = new Policko(i, j, Policko.Typy.Starter);
                            Player.Location = new Point(polickos[i, j].RoomPoloha.X+320, polickos[i, j].RoomPoloha.Y + 160);
                            break;
                    }
                    this.Controls.Add(polickos[i, j].RoomTma);
                    polickos[i, j].RoomTma.BringToFront();
                    Tmy.Add(polickos[i, j].RoomTma);
                }
            }

            Bitmap MapaBackground = new Bitmap(1920, 1080);
            using (Graphics g = Graphics.FromImage(MapaBackground))
            {
                g.Clear(Color.Orange);
                for (int i = 0; i != 3; i++)
                {
                    for (int j = 0; j != 3; j++)
                    {
                        
                        g.DrawImage(Pozadi.BackgroundTemplate,i*640,j*360);
                    
                    }
                }
            }
                this.BackgroundImage = MapaBackground;
            //LoadBox Show
            Task.Run(() => {
                for (int i = 0; i != 4; i++)
                {
                    System.Threading.Thread.Sleep(250);
                    LoadBox.Controls[0].Text += ".";
                }
                LoadBox.Visible = false;
            });
            this.Controls.Add(LoadBox);
            LoadBox.BringToFront();
        }
        private void PlayDungeon_Load(object sender, EventArgs e)
        {

            foreach (object a in this.Controls)
            {
                Debug.WriteLine(a.GetType().ToString());
                if (a.GetType().ToString() == "System.Windows.Forms.PictureBox")
                {
                    PictureBox b = (PictureBox)a;
                    if (b.Tag != null)
                    {
                        if (b.Tag.ToString() == "Wall")
                        {
                            b.MouseEnter += GetPlayerBack;
                            b.MouseMove += GetPlayerBack;
                            
                        }
                        if (b.Tag.ToString() == "DoorS")
                        {
                            b.MouseEnter += DoorOpenS;
                        }
                        if (b.Tag.ToString() == "DoorV")
                        {
                            b.MouseEnter += DoorOpenV;
                        }

                    }

                }
            }

        }
        private void Vykresli(object sender, PaintEventArgs e)
        {
            



        }
        Point PosledniLokace = new Point(0,0);
        private void PlayerMove(object sender, MouseEventArgs e)
        {
            
            // Move
            Player.Location = new Point(this.PointToClient(Cursor.Position).X - Player.Width / 2, this.PointToClient(Cursor.Position).Y - Player.Height / 2);

            // Get Move Direction
            if (Player.Location.X > PosledniLokace.X)
            {
                PohybHorizontalne = Strany.Doprava;
            }
            else
            {
                PohybVerticalne = Strany.none;
            }

            if (Player.Location.X < PosledniLokace.X)
            {
                PohybHorizontalne = Strany.Doleva;
            }
            else
            {
                PohybVerticalne = Strany.none;
            }



            if (Player.Location.Y > PosledniLokace.Y)
            {
                PohybVerticalne = Strany.Dolu;
            }
            else
            {
                PohybVerticalne = Strany.none;
            }

            if (Player.Location.Y < PosledniLokace.Y)
            {
                PohybVerticalne = Strany.Nahoru;
            }
            else
            {
                PohybVerticalne = Strany.none;
            }
            


            // Get Speed
            int Distance(Point a, Point b)
            {
                if (a != b)
                {
                    double c = Math.Sqrt((Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)));
                    return Convert.ToInt32(c);
                }
                else
                {
                    return 0;
                }
            }

            Rychlost = Distance(PosledniLokace, Player.Location) ;
            

            if (Rychlost > 35 && PosledniPolohy20.Count > 8)
            {
                Player.Location = PosledniPolohy20[PosledniPolohy20.Count - 8];
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Point PoziceNaVraceni = new Point(this.PointToScreen(Player.Location).X + Player.Width / 2, this.PointToScreen(Player.Location).Y + Player.Height / 2);
                Cursor.Position = PoziceNaVraceni;
            }
            


            PosledniLokace = Player.Location;

            if (PosledniPolohy20.Count > 20)
            {
                PosledniPolohy20.RemoveRange(0, 10);
            }

            PosledniPolohy20.Add(PosledniLokace);

            //Debug.WriteLine(PohybHorizontalne.ToString() + " " + PohybVerticalne.ToString());

            //

            foreach (PictureBox a in Tmy)
            {
                if (a.Bounds.IntersectsWith(Player.Bounds))
                {
                    a.Visible = false;
                }
            }

        }

        private void GetPlayerBack(object sender, EventArgs e)
        {
            
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Point PoziceNaVraceni = new Point(this.PointToScreen(Player.Location).X + Player.Width / 2, this.PointToScreen(Player.Location).Y + Player.Height / 2);
            
            switch (PohybHorizontalne)
            {
                case Strany.Doleva:
                    PoziceNaVraceni.X += Player.Height / 4;
                    
                    break;
                case Strany.Doprava:
                    PoziceNaVraceni.X -= Player.Height / 4;
                    
                    break;
            }
          
            switch (PohybVerticalne)
            {
                case Strany.Nahoru:
                    PoziceNaVraceni.Y += Player.Height / 4;
                    break;
                case Strany.Dolu:
                    PoziceNaVraceni.Y -= Player.Height / 4;
                    break;
            }
            Cursor.Position = PoziceNaVraceni;
        }

        private void GetPlayerBack(object sender, MouseEventArgs e)
        {

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Point PoziceNaVraceni = new Point(this.PointToScreen(Player.Location).X + Player.Width / 2, this.PointToScreen(Player.Location).Y + Player.Height / 2);

            switch (PohybHorizontalne)
            {
                case Strany.Doleva:
                    PoziceNaVraceni.X += Player.Height / 4;

                    break;
                case Strany.Doprava:
                    PoziceNaVraceni.X -= Player.Height / 4;

                    break;
            }
            
            switch (PohybVerticalne)
            {
                case Strany.Nahoru:
                    PoziceNaVraceni.Y += Player.Height / 4;
                    break;
                case Strany.Dolu:
                    PoziceNaVraceni.Y -= Player.Height / 4;
                    break;
            }
            Cursor.Position = PoziceNaVraceni;
        }

        

        private void PlayDungeon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Space)
            {
                this.WindowState = FormWindowState.Minimized; 
            }
        }

        private void DoorOpenS(object sender, EventArgs e)
        {
            switch (PohybHorizontalne)
            {
                case Strany.Doleva:
                    

                    break;
                case Strany.Doprava:
                    

                    break;
            }
        }
        private void DoorOpenV(object sender, EventArgs e)
        {
            switch (PohybVerticalne)
            {
                case Strany.Nahoru:

                    break;
                case Strany.Dolu:

                    break;
            }
        }



    }
}
