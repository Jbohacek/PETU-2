namespace Petu2.MainGame.InLobby
{
    partial class MainMinimazed
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RightTop = new System.Windows.Forms.PictureBox();
            this.LeftTop = new System.Windows.Forms.PictureBox();
            this.RightBot = new System.Windows.Forms.PictureBox();
            this.LeftBot = new System.Windows.Forms.PictureBox();
            this.settingMinimazed1 = new Petu2.MainGame.InLobby.SettingMinimazed();
            this.PicOfPet = new System.Windows.Forms.PictureBox();
            this.FrontFood = new System.Windows.Forms.PictureBox();
            this.BackFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOfPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackFood)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(238, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ShowSettings);
            // 
            // RightTop
            // 
            this.RightTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RightTop.Location = new System.Drawing.Point(284, 0);
            this.RightTop.Name = "RightTop";
            this.RightTop.Size = new System.Drawing.Size(40, 40);
            this.RightTop.TabIndex = 3;
            this.RightTop.TabStop = false;
            this.RightTop.Click += new System.EventHandler(this.GoRightUp);
            // 
            // LeftTop
            // 
            this.LeftTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LeftTop.Location = new System.Drawing.Point(0, 0);
            this.LeftTop.Name = "LeftTop";
            this.LeftTop.Size = new System.Drawing.Size(40, 40);
            this.LeftTop.TabIndex = 2;
            this.LeftTop.TabStop = false;
            this.LeftTop.Click += new System.EventHandler(this.GoLeftUp);
            // 
            // RightBot
            // 
            this.RightBot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RightBot.Location = new System.Drawing.Point(284, 352);
            this.RightBot.Name = "RightBot";
            this.RightBot.Size = new System.Drawing.Size(40, 40);
            this.RightBot.TabIndex = 1;
            this.RightBot.TabStop = false;
            this.RightBot.Click += new System.EventHandler(this.GoRightBot);
            // 
            // LeftBot
            // 
            this.LeftBot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LeftBot.Location = new System.Drawing.Point(0, 352);
            this.LeftBot.Name = "LeftBot";
            this.LeftBot.Size = new System.Drawing.Size(40, 40);
            this.LeftBot.TabIndex = 0;
            this.LeftBot.TabStop = false;
            this.LeftBot.Click += new System.EventHandler(this.GoLeftBot);
            // 
            // settingMinimazed1
            // 
            this.settingMinimazed1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingMinimazed1.Location = new System.Drawing.Point(78, 384);
            this.settingMinimazed1.Name = "settingMinimazed1";
            this.settingMinimazed1.Size = new System.Drawing.Size(174, 210);
            this.settingMinimazed1.TabIndex = 5;
            this.settingMinimazed1.Visible = false;
            // 
            // PicOfPet
            // 
            this.PicOfPet.Location = new System.Drawing.Point(108, 143);
            this.PicOfPet.Name = "PicOfPet";
            this.PicOfPet.Size = new System.Drawing.Size(100, 100);
            this.PicOfPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicOfPet.TabIndex = 6;
            this.PicOfPet.TabStop = false;
            // 
            // FrontFood
            // 
            this.FrontFood.BackColor = System.Drawing.Color.Coral;
            this.FrontFood.Location = new System.Drawing.Point(61, 328);
            this.FrontFood.Name = "FrontFood";
            this.FrontFood.Size = new System.Drawing.Size(200, 50);
            this.FrontFood.TabIndex = 9;
            this.FrontFood.TabStop = false;
            // 
            // BackFood
            // 
            this.BackFood.Location = new System.Drawing.Point(61, 328);
            this.BackFood.Name = "BackFood";
            this.BackFood.Size = new System.Drawing.Size(200, 50);
            this.BackFood.TabIndex = 8;
            this.BackFood.TabStop = false;
            // 
            // MainMinimazed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 392);
            this.ControlBox = false;
            this.Controls.Add(this.FrontFood);
            this.Controls.Add(this.BackFood);
            this.Controls.Add(this.PicOfPet);
            this.Controls.Add(this.settingMinimazed1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RightTop);
            this.Controls.Add(this.LeftTop);
            this.Controls.Add(this.RightBot);
            this.Controls.Add(this.LeftBot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMinimazed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.LocationChanged += new System.EventHandler(this.MainMinimazed_LocationChanged);
            this.DoubleClick += new System.EventHandler(this.GetBack);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMinimazed_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMinimazed_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainMinimazed_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOfPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftBot;
        private System.Windows.Forms.PictureBox RightBot;
        private System.Windows.Forms.PictureBox LeftTop;
        private System.Windows.Forms.PictureBox RightTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SettingMinimazed settingMinimazed1;
        private System.Windows.Forms.PictureBox PicOfPet;
        private System.Windows.Forms.PictureBox FrontFood;
        private System.Windows.Forms.PictureBox BackFood;
    }
}