namespace Petu2.MainGame.InLobby
{
    partial class MainGameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameOfPet = new System.Windows.Forms.Label();
            this.PetImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonMinimaze = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Reloader = new System.Windows.Forms.Timer(this.components);
            this.FoodDown = new System.Windows.Forms.Timer(this.components);
            this.BackFood = new System.Windows.Forms.PictureBox();
            this.FrontFood = new System.Windows.Forms.PictureBox();
            this.leftControlPanel1 = new Petu2.MainGame.InLobby.LeftControlPanel();
            this.FooIndicator = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PetImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfPet
            // 
            this.NameOfPet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameOfPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameOfPet.Location = new System.Drawing.Point(207, 9);
            this.NameOfPet.Name = "NameOfPet";
            this.NameOfPet.Size = new System.Drawing.Size(655, 105);
            this.NameOfPet.TabIndex = 0;
            this.NameOfPet.Text = "4";
            this.NameOfPet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PetImage
            // 
            this.PetImage.Location = new System.Drawing.Point(417, 330);
            this.PetImage.Name = "PetImage";
            this.PetImage.Size = new System.Drawing.Size(200, 200);
            this.PetImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PetImage.TabIndex = 1;
            this.PetImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 90);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OpenPanel);
            // 
            // ButtonMinimaze
            // 
            this.ButtonMinimaze.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonMinimaze.Location = new System.Drawing.Point(1017, 9);
            this.ButtonMinimaze.Name = "ButtonMinimaze";
            this.ButtonMinimaze.Size = new System.Drawing.Size(55, 47);
            this.ButtonMinimaze.TabIndex = 3;
            this.ButtonMinimaze.TabStop = false;
            this.ButtonMinimaze.Click += new System.EventHandler(this.OpenMinimazed);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(12, 663);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 123);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.OpenInventory);
            // 
            // Reloader
            // 
            this.Reloader.Interval = 1;
            this.Reloader.Tick += new System.EventHandler(this.ReloadHungerAndXp);
            // 
            // FoodDown
            // 
            this.FoodDown.Enabled = true;
            this.FoodDown.Interval = 1000;
            this.FoodDown.Tick += new System.EventHandler(this.FoodGetDown);
            // 
            // BackFood
            // 
            this.BackFood.Location = new System.Drawing.Point(291, 736);
            this.BackFood.Name = "BackFood";
            this.BackFood.Size = new System.Drawing.Size(500, 50);
            this.BackFood.TabIndex = 6;
            this.BackFood.TabStop = false;
            // 
            // FrontFood
            // 
            this.FrontFood.BackColor = System.Drawing.Color.Coral;
            this.FrontFood.Location = new System.Drawing.Point(291, 736);
            this.FrontFood.Name = "FrontFood";
            this.FrontFood.Size = new System.Drawing.Size(500, 50);
            this.FrontFood.TabIndex = 7;
            this.FrontFood.TabStop = false;
            // 
            // leftControlPanel1
            // 
            this.leftControlPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.leftControlPanel1.Font = new System.Drawing.Font("Windows Command Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftControlPanel1.Location = new System.Drawing.Point(90, -3);
            this.leftControlPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftControlPanel1.Name = "leftControlPanel1";
            this.leftControlPanel1.Size = new System.Drawing.Size(150, 800);
            this.leftControlPanel1.TabIndex = 4;
            // 
            // FooIndicator
            // 
            this.FooIndicator.AutoSize = true;
            this.FooIndicator.Font = new System.Drawing.Font("Windows Command Prompt", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FooIndicator.Location = new System.Drawing.Point(793, 748);
            this.FooIndicator.Name = "FooIndicator";
            this.FooIndicator.Size = new System.Drawing.Size(116, 32);
            this.FooIndicator.TabIndex = 8;
            this.FooIndicator.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(969, 657);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 123);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.GoAdventure);
            // 
            // MainGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 798);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.FooIndicator);
            this.Controls.Add(this.FrontFood);
            this.Controls.Add(this.BackFood);
            this.Controls.Add(this.leftControlPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ButtonMinimaze);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PetImage);
            this.Controls.Add(this.NameOfPet);
            this.Font = new System.Drawing.Font("Windows Command Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainGameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            ((System.ComponentModel.ISupportInitialize)(this.PetImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfPet;
        private System.Windows.Forms.PictureBox PetImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ButtonMinimaze;
        private LeftControlPanel leftControlPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer Reloader;
        private System.Windows.Forms.Timer FoodDown;
        private System.Windows.Forms.PictureBox BackFood;
        private System.Windows.Forms.PictureBox FrontFood;
        private System.Windows.Forms.Label FooIndicator;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}