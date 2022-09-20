namespace Petu2.MainGame.InLobby
{
    partial class InventorySlot
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
            this.PictureOfItem = new System.Windows.Forms.PictureBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.PictureBox();
            this.ItemAttribute = new System.Windows.Forms.Label();
            this.Open_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Confirm)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureOfItem
            // 
            this.PictureOfItem.Location = new System.Drawing.Point(7, 7);
            this.PictureOfItem.Name = "PictureOfItem";
            this.PictureOfItem.Size = new System.Drawing.Size(60, 60);
            this.PictureOfItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureOfItem.TabIndex = 0;
            this.PictureOfItem.TabStop = false;
            this.PictureOfItem.Tag = "None";
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Windows Command Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ItemName.Location = new System.Drawing.Point(0, 70);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(75, 17);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "label1";
            this.ItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Confirm.Location = new System.Drawing.Point(0, 103);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 17);
            this.Confirm.TabIndex = 2;
            this.Confirm.TabStop = false;
            this.Confirm.Click += new System.EventHandler(this.UseItem);
            // 
            // ItemAttribute
            // 
            this.ItemAttribute.Font = new System.Drawing.Font("Windows Command Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ItemAttribute.ForeColor = System.Drawing.Color.Olive;
            this.ItemAttribute.Location = new System.Drawing.Point(0, 87);
            this.ItemAttribute.Name = "ItemAttribute";
            this.ItemAttribute.Size = new System.Drawing.Size(75, 13);
            this.ItemAttribute.TabIndex = 3;
            this.ItemAttribute.Text = "+50";
            this.ItemAttribute.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ItemAttribute.Visible = false;
            // 
            // Open_Button
            // 
            this.Open_Button.Font = new System.Drawing.Font("Windows Command Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Open_Button.Location = new System.Drawing.Point(11, 80);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(50, 23);
            this.Open_Button.TabIndex = 4;
            this.Open_Button.Text = "Open";
            this.Open_Button.UseVisualStyleBackColor = true;
            this.Open_Button.Visible = false;
            // 
            // InventorySlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Open_Button);
            this.Controls.Add(this.ItemAttribute);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.PictureOfItem);
            this.Name = "InventorySlot";
            this.Size = new System.Drawing.Size(73, 118);
            this.Tag = "None";
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Confirm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureOfItem;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.PictureBox Confirm;
        private System.Windows.Forms.Label ItemAttribute;
        private System.Windows.Forms.Button Open_Button;
    }
}
