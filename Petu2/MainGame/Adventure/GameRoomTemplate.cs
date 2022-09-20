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

namespace Petu2.MainGame.Adventure
{
    public partial class GameRoomTemplate : Form
    {
        public static GameRoomTemplate Instance;
        public bool PlayerIsPlaying = false;
        public string[] Room = new string[2] { "0","0"};
        public Adventure.Route aa;
        public Point EscapePoint;
        public int Floor = 0;
        
        public GameRoomTemplate()
        {
            InitializeComponent();
            
            Instance = this;
            PlayerBox.Image = Hra.ActivePet.ImageOfPet;
            PlayerBox.MouseMove += MoveCharakter;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(this.DesktopLocation.X);
            this.Close();
            
        }
        public void NextRoom()
        {
            if (Floor == 5)
            {
                foreach (Hra.Chest chest in Adventure.Reward)
                {
                    Hra.ActivePet.chests.Add(chest);
                }
                this.Close();

            }
            else
            {
                Floor++;
                this.Controls.Clear();
                PictureBox d = new PictureBox();
                d.Size = new Size(1920, 1080);
                d.BackColor = Color.Black;
                this.Controls.Add(d);
                InitializeComponent();
                PlayerBox.Image = Hra.ActivePet.ImageOfPet;
                PlayerBox.MouseMove += MoveCharakter;
                aa = new Adventure.Route();
                System.Windows.Forms.Cursor.Position = new Point(this.DesktopLocation.X + 320 + PlayerBox.Width / 2, this.DesktopLocation.Y + 180 + PlayerBox.Height / 2);
                foreach (object a in Controls)
                {
                    if (a.GetType().Name.ToString() == "RoomTemplate")
                    {
                        RoomTemplate room = (RoomTemplate)a;
                        string[] b = room.Tag.ToString().Split('_');
                        if (b[2] == "0")
                        {
                            room.BringToFront();
                        }
                        foreach (object c in room.Controls)
                        {
                            if (b.GetType().Name.ToString() == "PictureBox")
                            {
                                PictureBox pictureBox = (PictureBox)c;
                                pictureBox.BringToFront();
                            }
                        }
                    }
                }
                d.BringToFront();
                aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].Active = true;
                aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].Visited = true;
                aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].RoomInstance.ShowMe();

                aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].RoomInstance.doors.ForEach(r => r.Visible = false);
                d.Visible = false;
                button1.BringToFront();
            }
        }
        private void Loaded(object sender, EventArgs e)
        {
            Adventure.Reward.Clear();
            aa = new Adventure.Route();
            System.Windows.Forms.Cursor.Position = new Point(this.DesktopLocation.X + 320 + PlayerBox.Width/2, this.DesktopLocation.Y + 180 + PlayerBox.Height/2);
            foreach (object a in Controls)
            {
                if (a.GetType().Name.ToString() == "RoomTemplate")
                {
                    RoomTemplate room = (RoomTemplate)a;
                    string[] b = room.Tag.ToString().Split('_');
                    if (b[2] == "0")
                    {
                        room.BringToFront();
                    }
                    foreach (object c in room.Controls)
                    {
                        if (b.GetType().Name.ToString() == "PictureBox")
                        {
                            PictureBox pictureBox = (PictureBox)c;
                            pictureBox.BringToFront();
                        }
                    }
                }
            }
            aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].Active = true;
            aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].Visited = true;
            aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].RoomInstance.ShowMe();

            aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].RoomInstance.doors.ForEach(r => r.Visible = false);
            button1.BringToFront();
        }
        

        public void MoveCharakter(object sender, MouseEventArgs e)
        {
            PlayerBox.Location = new Point(this.PointToClient(Cursor.Position).X - PlayerBox.Width / 2, this.PointToClient(Cursor.Position).Y - PlayerBox.Height / 2);
            int[] LastCort = new int[2] { Adventure.PlayerPosition[0],Adventure.PlayerPosition[1] };
            if (this.PointToClient(Cursor.Position).X > (640*Adventure.PlayerPosition[0]))
            {
                Adventure.PlayerPosition[0]++;
            }
            if (this.PointToClient(Cursor.Position).X < (640 * Adventure.PlayerPosition[0]))
            {
                Adventure.PlayerPosition[0]--;
            }
            if (this.PointToClient(Cursor.Position).Y > (360 * Adventure.PlayerPosition[1]))
            {
                Adventure.PlayerPosition[1]++;
            }
            if (this.PointToClient(Cursor.Position).Y < (360 * Adventure.PlayerPosition[1]))
            {
                Adventure.PlayerPosition[1]--;
            }

            if (LastCort[0] != Adventure.PlayerPosition[0] || LastCort[1] != Adventure.PlayerPosition[1])
            {
                foreach (Adventure.Room room in aa.rooms)
                {
                    room.Active = false;
                }
                aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].Active = true;
                aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].Visited = true;
                aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].RoomInstance.ShowMe();
                
                aa.rooms[Adventure.PlayerPosition[1], Adventure.PlayerPosition[0]].RoomInstance.doors.ForEach(r => r.Visible = false);
                
                
            }
            
            //Debug.WriteLine("X: {0} Y:{1}",Adventure.PlayerPosition[0],Adventure.PlayerPosition[1]);
        }
        public void CharakterEnterRoom(object sender, EventArgs e)
        {
            RoomTemplate O = (RoomTemplate)sender;
            string[] a = O.Tag.ToString().Split('_');
            if (Room[0] != a[0] || Room[1] != a[1])
            {
                Room[0] = a[0];
                Room[1] = a[1];
                Debug.WriteLine("Entered = " + O.Tag.ToString());
            }
        }

        private void PlayerIsBack(object sender, EventArgs e)
        {
            Cursor.Hide();
           PlayerIsPlaying = true;
    }

        private void PlayerLeft(object sender, EventArgs e)
        {
            Cursor.Show();
            PlayerIsPlaying = false;
        }

        private void UseButton(object sender, EventArgs e)
        {
           Debug.WriteLine("--------\nUse");
            
            string idEnemy = null;
            string idTressure = null;
            foreach (Adventure.Room d in aa.rooms)
           {
                //Debug.WriteLine(d.Pos[0] + " " + d.Pos[1] + "\t Active:" + d.Active);
                if (d.Active)
                {
                    foreach (object b in d.RoomInstance.Controls)
                    {
                        if (b.GetType().Name == "PictureBox")
                        {
                            PictureBox pic = (PictureBox)b;
                            if (pic.Tag.ToString().Substring(0, 1) == "e")
                            {
                                //Debug.WriteLine(Distance(GetMidPoint(PlayerBox.PointToClient(Point.Empty)), GetMidPoint(pic.PointToClient(Point.Empty))));
                                if (Distance(GetMidPoint(PlayerBox.PointToClient(Point.Empty)), GetMidPoint(pic.PointToClient(Point.Empty))) < 110)
                                {
                                    if (pic.Visible == true)
                                    {
                                        pic.Visible = false; 
                                        idEnemy = pic.Tag.ToString();
                                        Debug.WriteLine("EnemyKilled");
                                        break;
                                    }
                                    
                                }
                                
                            }
                            if (pic.Tag.ToString().Substring(0, 1) == "t")
                            {
                                if (Distance(GetMidPoint(PlayerBox.PointToClient(Point.Empty)), GetMidPoint(pic.PointToClient(Point.Empty))) < 110)
                                {
                                    if (pic.Visible == true)
                                    {
                                        pic.Visible = false;
                                        idTressure = pic.Tag.ToString();
                                        Debug.WriteLine("ItemCollected");
                                        break;
                                    }
                                    
                                }
                            }
                            if (pic.Tag.ToString() == "Escape" && Adventure.enemies.Count == 0)
                            {
                                if (Distance(GetMidPoint(PlayerBox.PointToClient(Point.Empty)), GetMidPoint(pic.PointToClient(Point.Empty))) < 80)
                                {
                                    Debug.WriteLine("NextRoom");
                                    NextRoom();
                                    break;
                                }
                            }
                        }
                    
                    }
                }
           }
            if (idEnemy != null)
            {
                int pos = 0;
                int ?Killindex = null;
                foreach (Adventure.Enemy c in Adventure.enemies)
                {
                    
                    if (c.ID == idEnemy)
                    {
                        Killindex = pos;
                        
                    }
                    pos++;
                }
                if (Killindex != null)
                {
                    Adventure.enemies.RemoveAt((int)Killindex);
                }
                
            }
            Debug.WriteLine("Enemy left: " + Adventure.enemies.Count);
            Debug.WriteLine("Items collected: " + Adventure.Reward.Count);

            if (idTressure != null)
            {
                int pos = 0;
                int ?Killindex = null;
                foreach (Adventure.Tresure c in Adventure.tresures)
                {

                    if (c.ID == idTressure)
                    {
                        Killindex = pos;
                        Adventure.Reward.Add(c.ObtainedChest);
                        
                    }
                    pos++;
                }
                if (Killindex != null)
                {
                    Adventure.tresures.RemoveAt((int)Killindex);
                }
            }
        }
        
        public Point GetMidPoint(Point a)
        {
            return new Point(a.X + 25,a.Y + 25) ;
        }
        public int Distance(Point a, Point b)
        {
            double c = Math.Round(Math.Sqrt((Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2))));
            return Convert.ToInt32(c);
        }
    }
}
