using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petu2.Lobby
{
    public partial class CreateScreen : Form
    {
        public Hra.PhotoOfPets PicToSave;
        public CreateScreen()
        {
            InitializeComponent();
            foreach (Hra.PhotoOfPets suit in (Hra.PhotoOfPets[])Enum.GetValues(typeof(Hra.PhotoOfPets)))
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = (Image)Obrazky.PetsPic.ResourceManager.GetObject(Enum.GetName(typeof(Hra.PhotoOfPets), suit));
                pictureBox.Size = new Size(80, 80);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Click += SelectedPicOption;
                pictureBox.Name = Enum.GetName(typeof(Hra.PhotoOfPets), suit).ToString();
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }

        private void CreatePet(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && SelectedPicutre.Image != null)
            {
                Hra.pets.Add(new Hra.Pet(textBox1.Text, PicToSave));
                LoadScreen.instance.NacistPets();
                this.Close();
            }
        }
        public void SelectedPicOption(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            PictureBox a = (PictureBox)sender;
            PicToSave = (Hra.PhotoOfPets)Enum.Parse(typeof(Hra.PhotoOfPets), a.Name);
            SelectedPicutre.Image = (Image)Obrazky.PetsPic.ResourceManager.GetObject(a.Name);

        }
        private void CloseThis(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MouseEnterExit(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void MouseLeaveExit(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void OpenSelectImage(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible)
            {
                flowLayoutPanel1.Visible = false;
            }
            else
            {

                flowLayoutPanel1.Visible = true;
            }
        }
    }
}
