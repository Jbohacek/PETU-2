using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu2.MainGame.Adventure
{
    public partial class RoomTemplate : UserControl
    {
        public PictureBox CoverRoom = new PictureBox();
        public List<PictureBox> doors;
        public RoomTemplate(int PosX, int PosY, int Type)
        {
            InitializeComponent();
            doors = new List<PictureBox>();
            label1.Location = new Point(this.Width / 2, this.Height /2);
            this.Tag = PosX + "_" + PosY + "_" + Type;
            System.Threading.Thread.Sleep(1);
            Random random = new Random();
            label1.Text = PosX.ToString() + " " + PosY.ToString();

            if (Type != 0)
            {
                this.Controls.Add(CoverRoom);
                CoverRoom.BringToFront();
            }
            CoverRoom.Size = new Size(640, 360);
            CoverRoom.BackColor = Color.DarkGray;
            CoverRoom.Tag = "Cover";

            for (int i = 0; i != 4; i++)
            {
                PictureBox Door = new PictureBox();
                Door.BackColor = Color.Brown;
                if (i % 2 == 0)
                {
                    Door.Size = DoorUp.Size;
                }
                else
                {
                    Door.Size = DoorLeft.Size;
                }
                
                switch (i)
                {
                    case 0:
                        Door.Location = DoorUp.Location;
                        Door.Tag = "DoorUp";
                        break;
                    case 1:
                        Door.Location = DoorRight.Location;
                        Door.Tag = "DoorRight";
                        break;
                    case 2:
                        Door.Location = DoorDown.Location;
                        Door.Tag = "DoorDown";
                        break;
                    case 3:
                        Door.Location = DoorLeft.Location;
                        Door.Tag = "DoorLeft";
                        break;

                }
                this.Controls.Add(Door);
                Door.BringToFront();
                doors.Add(Door);
            }
            



            switch (Type)
            {
                case 1:
                    label1.Text += " Full";
                    this.BackColor = Color.White;
                    break;
                case 2:
                    label1.Text += " Tressure";
                    this.BackColor = Color.Yellow;
                    break;
                case 3:
                    label1.Text += " End";
                    this.BackColor = Color.Green;
                    PictureBox pictureBox1 = new PictureBox();
                    pictureBox1.BackColor = Color.Black;
                    pictureBox1.Tag = "Escape";
                    if (PosX == 2)
                    {
                        pictureBox1.Size = new Size(100,50);
                        pictureBox1.Location = new Point(this.Size.Width / 2 - pictureBox1.Size.Width /2, this.Height - pictureBox1.Size.Height);
                    }
                    if (PosY == 2)
                    {
                        pictureBox1.Size=new Size(50,100);
                        pictureBox1.Location = new Point(this.Size.Width - pictureBox1.Size.Width, this.Height /2 - pictureBox1.Size.Height/2);
                    }
                    if (PosX == 0)
                    {
                        pictureBox1.Size = new Size(100, 50);
                        pictureBox1.Location = new Point(this.Size.Width / 2 - pictureBox1.Size.Width / 2, 0);
                    }
                    if (PosY == 0)
                    {
                        pictureBox1.Size = new Size(50, 100);
                        pictureBox1.Location = new Point(0, this.Height / 2 - pictureBox1.Size.Height / 2);

                    }
                    this.Controls.Add(pictureBox1);
                    
                    break;
                default:
                    this.BackColor = Color.Black;
                    foreach (PictureBox pictureBox in doors)
                    {
                        pictureBox.Visible = true;
                        pictureBox.Tag += "Closed";
                    }
                    break;
                
            }
            
            
            
           

        }
        public void ShowMe()
        {
            
            CoverRoom.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
