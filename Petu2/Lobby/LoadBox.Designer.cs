namespace Petu2.Lobby
{
    partial class LoadBox
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureOfPet = new System.Windows.Forms.PictureBox();
            this.NameOfPet = new System.Windows.Forms.Label();
            this.IndexShow = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FrontFood = new System.Windows.Forms.PictureBox();
            this.BackFood = new System.Windows.Forms.PictureBox();
            this.Hunger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackFood)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureOfPet
            // 
            this.PictureOfPet.Location = new System.Drawing.Point(3, 3);
            this.PictureOfPet.Name = "PictureOfPet";
            this.PictureOfPet.Size = new System.Drawing.Size(110, 111);
            this.PictureOfPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureOfPet.TabIndex = 1;
            this.PictureOfPet.TabStop = false;
            // 
            // NameOfPet
            // 
            this.NameOfPet.AutoSize = true;
            this.NameOfPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameOfPet.Location = new System.Drawing.Point(119, 22);
            this.NameOfPet.Name = "NameOfPet";
            this.NameOfPet.Size = new System.Drawing.Size(122, 25);
            this.NameOfPet.TabIndex = 2;
            this.NameOfPet.Text = "NameOfPet";
            // 
            // IndexShow
            // 
            this.IndexShow.AutoSize = true;
            this.IndexShow.Location = new System.Drawing.Point(566, 4);
            this.IndexShow.Name = "IndexShow";
            this.IndexShow.Size = new System.Drawing.Size(35, 13);
            this.IndexShow.TabIndex = 3;
            this.IndexShow.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Windows Command Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(522, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrontFood
            // 
            this.FrontFood.BackColor = System.Drawing.Color.Coral;
            this.FrontFood.Location = new System.Drawing.Point(138, 90);
            this.FrontFood.Name = "FrontFood";
            this.FrontFood.Size = new System.Drawing.Size(200, 24);
            this.FrontFood.TabIndex = 11;
            this.FrontFood.TabStop = false;
            // 
            // BackFood
            // 
            this.BackFood.Location = new System.Drawing.Point(138, 90);
            this.BackFood.Name = "BackFood";
            this.BackFood.Size = new System.Drawing.Size(200, 24);
            this.BackFood.TabIndex = 10;
            this.BackFood.TabStop = false;
            // 
            // Hunger
            // 
            this.Hunger.AutoSize = true;
            this.Hunger.Font = new System.Drawing.Font("Windows Command Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hunger.Location = new System.Drawing.Point(343, 94);
            this.Hunger.Name = "Hunger";
            this.Hunger.Size = new System.Drawing.Size(60, 17);
            this.Hunger.TabIndex = 12;
            this.Hunger.Text = "label1";
            // 
            // LoadBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Hunger);
            this.Controls.Add(this.FrontFood);
            this.Controls.Add(this.BackFood);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IndexShow);
            this.Controls.Add(this.NameOfPet);
            this.Controls.Add(this.PictureOfPet);
            this.Name = "LoadBox";
            this.Size = new System.Drawing.Size(600, 200);
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureOfPet;
        private System.Windows.Forms.Label NameOfPet;
        private System.Windows.Forms.Label IndexShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox FrontFood;
        private System.Windows.Forms.PictureBox BackFood;
        private System.Windows.Forms.Label Hunger;
    }
}
