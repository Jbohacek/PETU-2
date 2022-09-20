namespace Petu2.MainGame.InLobby
{
    partial class SettingMinimazed
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButTopLeft = new System.Windows.Forms.RadioButton();
            this.ButTopRight = new System.Windows.Forms.RadioButton();
            this.ButBotLeft = new System.Windows.Forms.RadioButton();
            this.ButBotRight = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 28);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(157, 45);
            this.trackBar1.SmallChange = 0;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.OpacitySettings);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Opacity";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(3, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(96, 22);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Movable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.MovableSeting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(5, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Default Location";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ButBotRight);
            this.panel1.Controls.Add(this.ButBotLeft);
            this.panel1.Controls.Add(this.ButTopRight);
            this.panel1.Controls.Add(this.ButTopLeft);
            this.panel1.Location = new System.Drawing.Point(3, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 59);
            this.panel1.TabIndex = 5;
            // 
            // ButTopLeft
            // 
            this.ButTopLeft.AutoSize = true;
            this.ButTopLeft.Font = new System.Drawing.Font("Windows Command Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButTopLeft.Location = new System.Drawing.Point(4, 4);
            this.ButTopLeft.Name = "ButTopLeft";
            this.ButTopLeft.Size = new System.Drawing.Size(76, 17);
            this.ButTopLeft.TabIndex = 0;
            this.ButTopLeft.TabStop = true;
            this.ButTopLeft.Text = "TopLeft";
            this.ButTopLeft.UseVisualStyleBackColor = true;
            this.ButTopLeft.Click += new System.EventHandler(this.TopLeft);
            // 
            // ButTopRight
            // 
            this.ButTopRight.AutoSize = true;
            this.ButTopRight.Font = new System.Drawing.Font("Windows Command Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButTopRight.Location = new System.Drawing.Point(78, 4);
            this.ButTopRight.Name = "ButTopRight";
            this.ButTopRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButTopRight.Size = new System.Drawing.Size(85, 17);
            this.ButTopRight.TabIndex = 1;
            this.ButTopRight.TabStop = true;
            this.ButTopRight.Text = "TopRight";
            this.ButTopRight.UseVisualStyleBackColor = true;
            this.ButTopRight.Click += new System.EventHandler(this.TopRight);
            // 
            // ButBotLeft
            // 
            this.ButBotLeft.AutoSize = true;
            this.ButBotLeft.Font = new System.Drawing.Font("Windows Command Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButBotLeft.Location = new System.Drawing.Point(4, 27);
            this.ButBotLeft.Name = "ButBotLeft";
            this.ButBotLeft.Size = new System.Drawing.Size(76, 17);
            this.ButBotLeft.TabIndex = 2;
            this.ButBotLeft.TabStop = true;
            this.ButBotLeft.Text = "BotLeft";
            this.ButBotLeft.UseVisualStyleBackColor = true;
            this.ButBotLeft.Click += new System.EventHandler(this.BotLeft);
            // 
            // ButBotRight
            // 
            this.ButBotRight.AutoSize = true;
            this.ButBotRight.Font = new System.Drawing.Font("Windows Command Prompt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButBotRight.Location = new System.Drawing.Point(78, 27);
            this.ButBotRight.Name = "ButBotRight";
            this.ButBotRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButBotRight.Size = new System.Drawing.Size(85, 17);
            this.ButBotRight.TabIndex = 3;
            this.ButBotRight.TabStop = true;
            this.ButBotRight.Text = "BotRight";
            this.ButBotRight.UseVisualStyleBackColor = true;
            this.ButBotRight.Click += new System.EventHandler(this.BotRight);
            // 
            // SettingMinimazed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Name = "SettingMinimazed";
            this.Size = new System.Drawing.Size(177, 237);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ButBotRight;
        private System.Windows.Forms.RadioButton ButBotLeft;
        private System.Windows.Forms.RadioButton ButTopRight;
        private System.Windows.Forms.RadioButton ButTopLeft;
    }
}
