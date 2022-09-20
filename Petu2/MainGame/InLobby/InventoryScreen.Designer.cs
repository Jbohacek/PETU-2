namespace Petu2.MainGame.InLobby
{
    partial class InventoryScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FoodPage = new System.Windows.Forms.TabPage();
            this.HatPage = new System.Windows.Forms.TabPage();
            this.MisicTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FoodPage);
            this.tabControl1.Controls.Add(this.HatPage);
            this.tabControl1.Controls.Add(this.MisicTab);
            this.tabControl1.Font = new System.Drawing.Font("Windows Command Prompt", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // FoodPage
            // 
            this.FoodPage.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FoodPage.Location = new System.Drawing.Point(4, 34);
            this.FoodPage.Name = "FoodPage";
            this.FoodPage.Padding = new System.Windows.Forms.Padding(3);
            this.FoodPage.Size = new System.Drawing.Size(521, 310);
            this.FoodPage.TabIndex = 0;
            this.FoodPage.Text = "Food";
            this.FoodPage.UseVisualStyleBackColor = true;
            // 
            // HatPage
            // 
            this.HatPage.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HatPage.Location = new System.Drawing.Point(4, 34);
            this.HatPage.Name = "HatPage";
            this.HatPage.Padding = new System.Windows.Forms.Padding(3);
            this.HatPage.Size = new System.Drawing.Size(521, 310);
            this.HatPage.TabIndex = 1;
            this.HatPage.Text = "Hats";
            this.HatPage.UseVisualStyleBackColor = true;
            // 
            // MisicTab
            // 
            this.MisicTab.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MisicTab.Location = new System.Drawing.Point(4, 34);
            this.MisicTab.Name = "MisicTab";
            this.MisicTab.Size = new System.Drawing.Size(521, 310);
            this.MisicTab.TabIndex = 2;
            this.MisicTab.Text = "Misc.";
            this.MisicTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(18, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CloseThis);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // InventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 423);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InventoryScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FoodPage;
        private System.Windows.Forms.TabPage HatPage;
        private System.Windows.Forms.TabPage MisicTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}