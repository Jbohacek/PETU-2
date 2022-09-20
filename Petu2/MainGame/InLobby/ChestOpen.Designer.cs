namespace Petu2.MainGame.InLobby
{
    partial class ChestOpen
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
            this.MoveBOx = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BaseBox = new System.Windows.Forms.PictureBox();
            this.TimeBetweenMove = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBOx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBOx
            // 
            this.MoveBOx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MoveBOx.Location = new System.Drawing.Point(-11, -11);
            this.MoveBOx.Name = "MoveBOx";
            this.MoveBOx.Size = new System.Drawing.Size(612, 38);
            this.MoveBOx.TabIndex = 0;
            this.MoveBOx.TabStop = false;
            this.MoveBOx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.MoveBOx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.MoveBOx.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(290, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 80);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BaseBox
            // 
            this.BaseBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BaseBox.Location = new System.Drawing.Point(-92, 47);
            this.BaseBox.Name = "BaseBox";
            this.BaseBox.Size = new System.Drawing.Size(80, 80);
            this.BaseBox.TabIndex = 2;
            this.BaseBox.TabStop = false;
            this.BaseBox.Visible = false;
            // 
            // TimeBetweenMove
            // 
            this.TimeBetweenMove.Enabled = true;
            this.TimeBetweenMove.Interval = 1;
            this.TimeBetweenMove.Tick += new System.EventHandler(this.MoveItems);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "SKIP";
            this.button1.UseVisualStyleBackColor = true;
            
            this.button1.Click += new System.EventHandler(this.SkipButton);
            // 
            // ChestOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 181);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BaseBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MoveBOx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChestOpen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.MoveBOx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MoveBOx;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BaseBox;
        private System.Windows.Forms.Timer TimeBetweenMove;
        private System.Windows.Forms.Button button1;
    }
}