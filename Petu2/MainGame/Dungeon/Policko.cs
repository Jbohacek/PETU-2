using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu2.MainGame.Dungeon
{
    public class Policko
    {
        public enum Typy { None,Empty, Starter, Tresure, LockTresure };

        public Policko.Typy Typ = new Typy();
        public bool RoomVidno = false;
        public Point PolohaXY;
        public Point RoomPoloha { get {
                return new Point(PolohaXY.X * 640,PolohaXY.Y*360);
            } }

        public PictureBox RoomTma = new PictureBox() { Size = new Size(640,360),BackColor = Color.Black,SizeMode = PictureBoxSizeMode.Zoom };
        public Image RoomBackground = null;

        public Policko(int PolohaX, int PolohaY, Policko.Typy TypMistnosti)
        {
            PolohaXY = new Point(PolohaX, PolohaY);
            Typ = TypMistnosti;
            if (Typ == Typy.Starter)
            {
                RoomVidno = true;
                RoomTma.Visible = false;
            }
            if (Typ == Typy.None)
            {
                RoomTma.BackColor = Color.Red;
            }
            RoomTma.Location = RoomPoloha;
        }
    }
}
