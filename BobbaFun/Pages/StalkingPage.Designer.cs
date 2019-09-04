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
            this.Stalkbotgamescheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // VictimsCmbx
            // 
            this.VictimsCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VictimsCmbx.FormattingEnabled = true;
            this.VictimsCmbx.Location = new System.Drawing.Point(48, 90);
            this.VictimsCmbx.Name = "VictimsCmbx";
            this.VictimsCmbx.Size = new System.Drawing.Size(139, 21);
            this.VictimsCmbx.TabIndex = 0;
            // 
            // StalkVictimBtn
            // 
            this.StalkVictimBtn.Location = new System.Drawing.Point(48, 117);
            this.StalkVictimBtn.Name = "StalkVictimBtn";
            this.StalkVictimBtn.Size = new System.Drawing.Size(139, 20);
            this.StalkVictimBtn.TabIndex = 1;
            this.StalkVictimBtn.Text = "Stalk Victim";
            this.StalkVictimBtn.Click += new System.EventHandler(this.StalkVictimBtn_Click);
            // 
            // Stalkbotgamescheck
            // 
            this.Stalkbotgamescheck.AutoSize = true;
            this.Stalkbotgamescheck.Location = new System.Drawing.Point(226, 80);
            this.Stalkbotgamescheck.Name = "Stalkbotgamescheck";
            this.Stalkbotgamescheck.Size = new System.Drawing.Size(218, 17);
            this.Stalkbotgamescheck.TabIndex = 5;
            this.Stalkbotgamescheck.Text = "Always Follow bot-giochi on games alerts";
            this.Stalkbotgamescheck.UseVisualStyleBackColor = true;
            // 
            // StalkingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Stalkbotgamescheck);
            this.Controls.Add(this.StalkVictimBtn);
            this.Controls.Add(this.VictimsCmbx);
            this.Name = "StalkingPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VictimsCmbx;
        private Sulakore.Components.SKoreButton StalkVictimBtn;
        private System.Windows.Forms.CheckBox Stalkbotgamescheck;
    }
}
