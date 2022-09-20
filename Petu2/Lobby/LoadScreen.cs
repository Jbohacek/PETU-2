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

namespace Petu2.Lobby
{
    public partial class LoadScreen : Form
    {
        public static LoadScreen instance;
        Lobby.CreateScreen createScreen = new Lobby.CreateScreen();
        public LoadScreen()
        {
            InitializeComponent();
            
            instance = this;
        }
        public void CreateNewPetButtonClick(object sender, EventArgs e)
        {
            //Hra.pets.Add(new Hra.Pet("Andilek", Hra.PhotoOfPets.Red_panda));
            createScreen = new CreateScreen();
            createScreen.Show();
        }
        public void NacistPets()
        {
           
            int indexCount = 0;
            if (Hra.pets != null)
            {
                SavesShower.Controls.Clear();
                foreach (Hra.Pet o in Hra.pets)
                {
                    LoadBox loadBox = new LoadBox(indexCount);
                    loadBox.Cursor = Cursors.Hand;
                    loadBox.Tag = indexCount.ToString();
                    foreach (object x in loadBox.Controls)
                    {
                        
                        if (x.GetType().ToString() == "System.Windows.Forms.PictureBox")
                        {
                            PictureBox t = (PictureBox)x;
                            t.Click += LoadPet;
                            t.Tag = indexCount.ToString();
                            if (t.Name == "PictureOfPet")
                            { t.Image = o.ImageOfPet; }
                        }
                        if (x.GetType().ToString() == "System.Windows.Forms.Label")
                        {
                            Label t = (Label)x;
                            t.Click += LoadPet;
                            t.Tag = indexCount.ToString();
                            if (t.Name == "NameOfPet")
                            { t.Text = o.Name; }
                            if (t.Name == "IndexShow")
                            { t.Text = indexCount.ToString(); }
                        }
                        if (x.GetType().ToString() == "System.Windows.Forms.Button")
                        {
                            Button t = (Button)x;
                            t.Tag = indexCount;
                            t.Click += RemovePet;
                        }

                        
                    }
                    
                    SavesShower.Controls.Add(loadBox);
                    indexCount++;
                    loadBox.MouseDown += LoadPet;
                    
                }
                
                Button NewButton = new Button();
                SavesShower.Controls.Add(NewButton);
                NewButton.Size = new Size(600, 200);
                NewButton.Text = "Create new";
                NewButton.Font = new Font("Windows Command Prompt", 50f);
                NewButton.Click += CreateNewPetButtonClick;
            }
        }
        public void LoadPet(object sender, EventArgs e)
        {
            if (sender.GetType().ToString() == "System.Windows.Forms.PictureBox")
            {
                PictureBox t = (PictureBox)sender;
                Hra.IndexPet = Convert.ToInt32(t.Tag.ToString());
            }
            if (sender.GetType().ToString() == "System.Windows.Forms.Label")
            {
                Label t = (Label)sender;
                Hra.IndexPet = Convert.ToInt32(t.Tag.ToString());
            }
            if (sender.GetType().ToString() == "Petu2.Lobby.LoadBox")
            {
               LoadBox t = (LoadBox)sender;
               Hra.IndexPet = Convert.ToInt32(t.Tag.ToString());
            }
            MainGame.InLobby.MainGameScreen aa = new MainGame.InLobby.MainGameScreen();
            aa.Show();
            this.Close();
        }
        public void RemovePet(object sender, EventArgs e)
        {
            Button t = (Button)sender;
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this pet?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                Hra.pets.RemoveAt(Convert.ToInt32(t.Tag));
                SavesShower.Controls.RemoveAt(Convert.ToInt32(t.Tag));
                NacistPets();
            }

        }
        private void GetToMainScreen(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            createScreen.Close();
            this.Close();
        }

        private void LoadScreen_Shown(object sender, EventArgs e)
        {
            NacistPets();
        }
    }
}
