namespace RetroFun.Pages
{
    partial class StalkingPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VictimsCmbx = new System.Windows.Forms.ComboBox();
            this.StalkVictimBtn = new Sulakore.Components.SKoreButton();
            this.Stalkbotgamescheckbx = new System.Windows.Forms.CheckBox();
            this.StalkVictimID = new Sulakore.Components.SKoreButton();
            this.InterceptVictimIDChbx = new System.Windows.Forms.CheckBox();
            this.IdOfVictimNbx = new System.Windows.Forms.NumericUpDown();
            this.SpamWalkChb = new System.Windows.Forms.CheckBox();
            this.CooldownFloodNbx = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SpectatorChbx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdOfVictimNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownFloodNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // VictimsCmbx
            // 
            this.VictimsCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VictimsCmbx.FormattingEnabled = true;
            this.VictimsCmbx.Location = new System.Drawing.Point(18, 131);
            this.VictimsCmbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VictimsCmbx.Name = "VictimsCmbx";
            this.VictimsCmbx.Size = new System.Drawing.Size(206, 28);
            this.VictimsCmbx.TabIndex = 0;
            // 
            // StalkVictimBtn
            // 
            this.StalkVictimBtn.Location = new System.Drawing.Point(18, 173);
            this.StalkVictimBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StalkVictimBtn.Name = "StalkVictimBtn";
            this.StalkVictimBtn.Size = new System.Drawing.Size(208, 31);
            this.StalkVictimBtn.TabIndex = 1;
            this.StalkVictimBtn.Text = "Stalk Victim";
            this.StalkVictimBtn.Click += new System.EventHandler(this.StalkVictimBtn_Click);
            // 
            // Stalkbotgamescheckbx
            // 
            this.Stalkbotgamescheckbx.AutoSize = true;
            this.Stalkbotgamescheckbx.Location = new System.Drawing.Point(281, 33);
            this.Stalkbotgamescheckbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Stalkbotgamescheckbx.Name = "Stalkbotgamescheckbx";
            this.Stalkbotgamescheckbx.Size = new System.Drawing.Size(323, 24);
            this.Stalkbotgamescheckbx.TabIndex = 5;
            this.Stalkbotgamescheckbx.Text = "Always Follow bot-giochi on games alerts";
            this.Stalkbotgamescheckbx.UseVisualStyleBackColor = true;
            // 
            // StalkVictimID
            // 
            this.StalkVictimID.Location = new System.Drawing.Point(18, 281);
            this.StalkVictimID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StalkVictimID.Name = "StalkVictimID";
            this.StalkVictimID.Size = new System.Drawing.Size(208, 31);
            this.StalkVictimID.TabIndex = 7;
            this.StalkVictimID.Text = "Stalk Victim ID";
            this.StalkVictimID.Click += new System.EventHandler(this.StalkVictimID_Click);
            // 
            // InterceptVictimIDChbx
            // 
            this.InterceptVictimIDChbx.AutoSize = true;
            this.InterceptVictimIDChbx.Location = new System.Drawing.Point(268, 227);
            this.InterceptVictimIDChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InterceptVictimIDChbx.Name = "InterceptVictimIDChbx";
            this.InterceptVictimIDChbx.Size = new System.Drawing.Size(171, 24);
            this.InterceptVictimIDChbx.TabIndex = 8;
            this.InterceptVictimIDChbx.Text = "Intercept Victim ID.";
            this.InterceptVictimIDChbx.UseVisualStyleBackColor = true;
            // 
            // IdOfVictimNbx
            // 
            this.IdOfVictimNbx.Location = new System.Drawing.Point(18, 241);
            this.IdOfVictimNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdOfVictimNbx.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.IdOfVictimNbx.Name = "IdOfVictimNbx";
            this.IdOfVictimNbx.Size = new System.Drawing.Size(208, 26);
            this.IdOfVictimNbx.TabIndex = 9;
            // 
            // SpamWalkChb
            // 
            this.SpamWalkChb.AutoSize = true;
            this.SpamWalkChb.Location = new System.Drawing.Point(281, 79);
            this.SpamWalkChb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpamWalkChb.Name = "SpamWalkChb";
            this.SpamWalkChb.Size = new System.Drawing.Size(265, 24);
            this.SpamWalkChb.TabIndex = 10;
            this.SpamWalkChb.Text = "Spam Coordinates Once in room";
            this.SpamWalkChb.UseVisualStyleBackColor = true;
            // 
            // CooldownFloodNbx
            // 
            this.CooldownFloodNbx.Location = new System.Drawing.Point(281, 124);
            this.CooldownFloodNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CooldownFloodNbx.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.CooldownFloodNbx.Name = "CooldownFloodNbx";
            this.CooldownFloodNbx.Size = new System.Drawing.Size(120, 26);
            this.CooldownFloodNbx.TabIndex = 15;
            this.CooldownFloodNbx.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Walking Speed";
            // 
            // SpectatorChbx
            // 
            this.SpectatorChbx.AutoSize = true;
            this.SpectatorChbx.Location = new System.Drawing.Point(268, 281);
            this.SpectatorChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpectatorChbx.Name = "SpectatorChbx";
            this.SpectatorChbx.Size = new System.Drawing.Size(316, 24);
            this.SpectatorChbx.TabIndex = 17;
            this.SpectatorChbx.Text = "Should Spectate on Bot-Giochi games?";
            this.SpectatorChbx.UseVisualStyleBackColor = true;
            // 
            // StalkingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpectatorChbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CooldownFloodNbx);
            this.Controls.Add(this.SpamWalkChb);
            this.Controls.Add(this.IdOfVictimNbx);
            this.Controls.Add(this.InterceptVictimIDChbx);
            this.Controls.Add(this.StalkVictimID);
            this.Controls.Add(this.Stalkbotgamescheckbx);
            this.Controls.Add(this.StalkVictimBtn);
            this.Controls.Add(this.VictimsCmbx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StalkingPage";
            this.Size = new System.Drawing.Size(698, 405);
            ((System.ComponentModel.ISupportInitialize)(this.IdOfVictimNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownFloodNbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VictimsCmbx;
        private Sulakore.Components.SKoreButton StalkVictimBtn;
        private System.Windows.Forms.CheckBox Stalkbotgamescheckbx;
        private Sulakore.Components.SKoreButton StalkVictimID;
        private System.Windows.Forms.CheckBox InterceptVictimIDChbx;
        private System.Windows.Forms.NumericUpDown IdOfVictimNbx;
        private System.Windows.Forms.CheckBox SpamWalkChb;
        private System.Windows.Forms.NumericUpDown CooldownFloodNbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SpectatorChbx;
    }
}
