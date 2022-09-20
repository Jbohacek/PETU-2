using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace Petu2.MainGame.Adventure
{
    static public class Adventure
    {
        public static Route ActiveRoute;
        public static int[] ActiveRoomBoundries;
        public static int[] PlayerPosition = new int[2] {0,0 };
        public static int[,] Path = new int[3, 3] { { 0, 0, 0 }, {0,0,0 }, {0,0,0 } };
        public static List<Enemy> enemies = new List<Enemy>();
        public static List<Tresure> tresures = new List<Tresure>();
        public static List<Hra.Chest> Reward = new List<Hra.Chest>();
        public class Route
        {
            public Room[,] rooms = new Room[3,3];
            public Route()
            {
                enemies.Clear();
                Path = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                Path[0, 0] = 1;
                PlayerPosition = new int[2] { 0, 0 };
                int[] position = new int[2] {0,0 };
                int RouteEnd = 0;
                int Tries = 0;
                Debug.WriteLine("Generating path");
                while (RouteEnd != 5)
                {
                    Tries++;
                    System.Threading.Thread.Sleep(1);
                    Random rnd = new Random();
                    int NextMove = rnd.Next(1, 7);
                    bool CanMove = false;
                    switch (NextMove)
                    {
                        case 1:
                            if (position[0] != 0)
                            {
                                position[0] -= 1;
                                CanMove = true;
                            }
                            break;
                        case 2:
                            if (position[1] != 2)
                            {
                                position[1] += 1;
                                CanMove = true;
                            }
                            break;
                        case 3:
                            if (position[0] != 2)
                            {
                                position[0] += 1;
                                CanMove = true;
                            }
                            break;
                        case 4:
                            if (position[1] != 0)
                            {
                                position[1] -= 1;
                                CanMove = true;
                            }
                            break;
                        case 5:
                            if (position[0] != 2)
                            {
                                position[0] += 1;
                                CanMove = true;
                            }
                            break;
                        case 6:
                            if (position[1] != 2)
                            {
                                position[1] += 1;
                                CanMove = true;
                            }
                            break;
                    }
                    if (CanMove == true)
                    {
                        if (Path[position[0], position[1]] != 1)
                        {
                            Path[position[0], position[1]] = 1;
                            RouteEnd++;
                            if (RouteEnd == 5)
                            {
                                Path[position[0], position[1]] = 3;
                            }
                        }
                    }
                    Debug.WriteLine("Can move: " + CanMove + "\t Postion X:{0} Y: {1}\t RouteEnd: {2}\t Tries: {3}", position[0], position[1], RouteEnd, Tries);
                    if (Tries > 100)
                    {
                        break;
                    }
                }



                Debug.WriteLine("Generating Rooms");
                for (int i = 0; i != 3; i++)
			    {
                    for (int j = 0; j != 3; j++)
                    {
                        if (Path[i, j] == 1 && (i+j) != 0)
                        {
                            System.Threading.Thread.Sleep(1);
                            Random rnd = new Random();
                            if (rnd.Next(10) == 1)
                            {
                                Path[i, j] = 2;
                            }
                        }

                        rooms[i, j] = new Room(360*i,640*j,i,j,WillBefull(i,j));
                    }
			    }
            }
            private int WillBefull(int LocationX,int LocationY)
            {
                return Path[LocationX, LocationY];
            }
               
            
        }
        public class Room
        {
            public int Type;
            public bool Visited;
            public bool Active;
            public int[] Pos = new int[2];
            public RoomTemplate RoomInstance;
            
            public Room(int PosY,int PosX,int LocationX,int LocationY,int _Type)
            {
                this.Type = _Type;
                Visited = false;
                Active = false;
                Pos[0] = LocationX;
                Pos[1] = LocationY;
                RoomTemplate roomTemplate = new RoomTemplate(LocationX,LocationY,_Type);
                roomTemplate.Location = new System.Drawing.Point(PosX, PosY);
                
                GameRoomTemplate.Instance.Controls.Add(roomTemplate);
                RoomInstance = roomTemplate;
                if (Type != 0 && (PosX + PosY) != 0)
                {
                    System.Threading.Thread.Sleep(1);
                    Random rnd = new Random();
                    int a = rnd.Next(0,10);
                    int enemyCount = 0;

                    if (a > 5)
                    {
                        enemyCount = 1;
                    }
                    if (a <= 5 && a >= 2)
                    {
                        enemyCount = 2;
                    }
                    if (a <= 1)
                    {
                        enemyCount = 2;
                    }

                    for (int i = 0; i != enemyCount; i++)
                    {
                        Enemy enemy = new Enemy(new Point(LocationX,LocationY));
                        RoomInstance.Controls.Add(enemy.EnemyPicture);
                        enemies.Add(enemy);
                    }
                
                
                }
                System.Threading.Thread.Sleep(1);

                if (new Random().Next(11) <= 3 && Type != 0)
                {
                    Tresure tres = new Tresure(new Point(LocationX,LocationY));
                    RoomInstance.Controls.Add(tres.ChesPicture);
                    tresures.Add(tres);
                }
            }
        }
        public class Enemy
        {
            public PictureBox EnemyPicture;
            public string ID;
            public Point EnemyLocation;

            public Enemy(Point RoomLoaction)
            {
                System.Threading.Thread.Sleep(1);
                Random random = new Random();
                EnemyPicture = new PictureBox();
                EnemyPicture.Tag = "e" + random.Next();
                ID = EnemyPicture.Tag.ToString();
                EnemyLocation = new Point(random.Next(60, 550), random.Next(60, 270));
                EnemyPicture.Location = EnemyLocation;
                EnemyPicture.BackColor = Color.Red;
                EnemyPicture.Size = new Size(50, 50);
            }
        }
        public class Tresure
        {
            public PictureBox ChesPicture;
            public string ID;
            public Point ChestLocation;
            public Hra.Chest ObtainedChest;

            public Tresure(Point RoomLoaction)
            {
                System.Threading.Thread.Sleep(1);
                Random random = new Random();
                ChesPicture = new PictureBox();
                ChesPicture.Tag = "t" + random.Next();
                ID = ChesPicture.Tag.ToString();
                ChestLocation = new Point(random.Next(60, 550), random.Next(60, 270));
                ChesPicture.Location = ChestLocation;
                //ChesPicture.BackColor = Color.Orange;
                ChesPicture.Size = new Size(50, 50);

                Hra.ChestTier TierChestkyPredmet = new Hra.ChestTier();
                Hra.Photo PhotoChestkyPredmet = new Hra.Photo();
                Hra.Rarity RaritaPredmetu = new Hra.Rarity();
                string NazevPredmetu = "";
                int sance = random.Next(1, 100);
                if (sance <= 65)
                {
                    TierChestkyPredmet = Hra.ChestTier.Wooden;
                    PhotoChestkyPredmet = Hra.Photo.WoodenChestClosed;
                    RaritaPredmetu = Hra.Rarity.Rare;
                    NazevPredmetu = "Wooden Chest";
                }
                else if (sance <= 85)
                {
                    TierChestkyPredmet = Hra.ChestTier.Iron;
                    PhotoChestkyPredmet = Hra.Photo.IronChestClosed;
                    RaritaPredmetu = Hra.Rarity.Epic;
                    NazevPredmetu = "Iron Chest";
                }
                else if (sance <= 100)
                {
                    TierChestkyPredmet = Hra.ChestTier.Gold;
                    PhotoChestkyPredmet = Hra.Photo.GoldChestClosed;
                    RaritaPredmetu = Hra.Rarity.Legendary;
                    NazevPredmetu = "Gold Chest";
                }
                ChesPicture.Image = Hra.GetObrazekPhoto(PhotoChestkyPredmet);
                ChesPicture.SizeMode = PictureBoxSizeMode.Zoom;

                ObtainedChest = new Hra.Chest(NazevPredmetu, RaritaPredmetu, PhotoChestkyPredmet, TierChestkyPredmet);
            }
        }
           
           
           

    }
}
