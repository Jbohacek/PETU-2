using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu2
{
    public partial class MainScreen : Form
    {
        Lobby.LoadScreen aa = null;
        public MainScreen()
        {
            
            InitializeComponent();
            /*
            Hra.Pet lolik = new Hra.Pet("Adamek",Hra.PhotoOfPets.cat);
            Hra.Pet Aba = new Hra.Pet("Bublik", Hra.PhotoOfPets.squrtle);
            lolik.foods.Add(new Hra.Food("Mis", Hra.Rarity.Epic, Hra.Photo.Missing));
            Hra.pets.Add(Aba);
            Hra.pets.Add(lolik);

            
            /*
            Hra.SaveViaDataContractSerialization(Hra.pets, "ulozeni.xml");
            */

            if (Hra.SlozkaNalezena == false)
            {
                label2.Visible = true;
            }
            
            aa = new Lobby.LoadScreen();
            aa.Show();
            aa.Opacity = 0;

        }

        private void CloseApp(object sender, EventArgs e)
        {
           
            Hra.SaveViaDataContractSerialization(Hra.pets, "ulozeni.xml");
            Environment.Exit(0);
        }

        private void LoadScreenOpen(object sender, EventArgs e)
        {
            this.Hide();
            Lobby.LoadScreen.instance.ShowInTaskbar = true;
            aa.Opacity = 100;
        }

        private void AppClosing(object sender, FormClosedEventArgs e)
        {
            Hra.SaveViaDataContractSerialization(Hra.pets, "ulozeni.xml");
        }
    }
}
