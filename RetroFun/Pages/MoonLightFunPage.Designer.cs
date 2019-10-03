namespace RetroFun.Pages
{
    partial class MoonLightFunPage
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
            this.SMoonDiscoBtn = new Sulakore.Components.SKoreButton();
            this.OnlyWallChbx = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorHTMLtxb = new System.Windows.Forms.TextBox();
            this.CustomBtx = new System.Windows.Forms.RadioButton();
            this.GreenBtx = new System.Windows.Forms.RadioButton();
            this.YellowBtx = new System.Windows.Forms.RadioButton();
            this.RedBtx = new System.Windows.Forms.RadioButton();
            this.PurpleBtx = new System.Windows.Forms.RadioButton();
            this.DarkBluebtx = new System.Windows.Forms.RadioButton();
            this.LightBluebtx = new System.Windows.Forms.RadioButton();
            this.SetMoonBtx = new Sulakore.Components.SKoreButton();
            this.DensityNm = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscoNumericcool = new System.Windows.Forms.NumericUpDown();
            this.LiveEditCoolNb = new System.Windows.Forms.NumericUpDown();
            this.LiveEditBtn = new Sulakore.Components.SKoreButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscoNumericcool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveEditCoolNb)).BeginInit();
            this.SuspendLayout();
            // 
            // SMoonDiscoBtn
            // 
            this.SMoonDiscoBtn.Location = new System.Drawing.Point(15, 33);
            this.SMoonDiscoBtn.Name = "SMoonDiscoBtn";
            this.SMoonDiscoBtn.Size = new System.Drawing.Size(185, 20);
            this.SMoonDiscoBtn.TabIndex = 42;
            this.SMoonDiscoBtn.Text = "MoonLight Disco : Deactivated";
            this.SMoonDiscoBtn.Click += new System.EventHandler(this.SMoonDiscoBtn_Click);
            // 
            // OnlyWallChbx
            // 
            this.OnlyWallChbx.AutoSize = true;
            this.OnlyWallChbx.Location = new System.Drawing.Point(278, 170);
            this.OnlyWallChbx.Name = "OnlyWallChbx";
            this.OnlyWallChbx.Size = new System.Drawing.Size(98, 17);
            this.OnlyWallChbx.TabIndex = 43;
            this.OnlyWallChbx.Text = "Only Wallpaper";
            this.OnlyWallChbx.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorHTMLtxb);
            this.groupBox1.Controls.Add(this.CustomBtx);
            this.groupBox1.Controls.Add(this.GreenBtx);
            this.groupBox1.Controls.Add(this.YellowBtx);
            this.groupBox1.Controls.Add(this.RedBtx);
            this.groupBox1.Controls.Add(this.PurpleBtx);
            this.groupBox1.Controls.Add(this.DarkBluebtx);
            this.groupBox1.Controls.Add(this.LightBluebtx);
            this.groupBox1.Location = new System.Drawing.Point(15, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 100);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // ColorHTMLtxb
            // 
            this.ColorHTMLtxb.Enabled = false;
            this.ColorHTMLtxb.Location = new System.Drawing.Point(145, 42);
            this.ColorHTMLtxb.MaxLength = 6;
            this.ColorHTMLtxb.Name = "ColorHTMLtxb";
            this.ColorHTMLtxb.Size = new System.Drawing.Size(100, 20);
            this.ColorHTMLtxb.TabIndex = 45;
            // 
            // CustomBtx
            // 
            this.CustomBtx.AutoSize = true;
            this.CustomBtx.Location = new System.Drawing.Point(145, 19);
            this.CustomBtx.Name = "CustomBtx";
            this.CustomBtx.Size = new System.Drawing.Size(60, 17);
            this.CustomBtx.TabIndex = 6;
            this.CustomBtx.Text = "Custom";
            this.CustomBtx.UseVisualStyleBackColor = true;
            this.CustomBtx.CheckedChanged += new System.EventHandler(this.CustomBtx_CheckedChanged);
            // 
            // GreenBtx
            // 
            this.GreenBtx.AutoSize = true;
            this.GreenBtx.Location = new System.Drawing.Point(83, 65);
            this.GreenBtx.Name = "GreenBtx";
            this.GreenBtx.Size = new System.Drawing.Size(54, 17);
            this.GreenBtx.TabIndex = 5;
            this.GreenBtx.Text = "Green";
            this.GreenBtx.UseVisualStyleBackColor = true;
            this.GreenBtx.CheckedChanged += new System.EventHandler(this.GreenBtx_CheckedChanged);
            // 
            // YellowBtx
            // 
            this.YellowBtx.AutoSize = true;
            this.YellowBtx.Location = new System.Drawing.Point(83, 42);
            this.YellowBtx.Name = "YellowBtx";
            this.YellowBtx.Size = new System.Drawing.Size(56, 17);
            this.YellowBtx.TabIndex = 4;
            this.YellowBtx.Text = "Yellow";
            this.YellowBtx.UseVisualStyleBackColor = true;
            this.YellowBtx.CheckedChanged += new System.EventHandler(this.YellowBtx_CheckedChanged);
            // 
            // RedBtx
            // 
            this.RedBtx.AutoSize = true;
            this.RedBtx.Checked = true;
            this.RedBtx.Location = new System.Drawing.Point(83, 19);
            this.RedBtx.Name = "RedBtx";
            this.RedBtx.Size = new System.Drawing.Size(45, 17);
            this.RedBtx.TabIndex = 3;
            this.RedBtx.TabStop = true;
            this.RedBtx.Text = "Red";
            this.RedBtx.UseVisualStyleBackColor = true;
            this.RedBtx.CheckedChanged += new System.EventHandler(this.RedBtx_CheckedChanged);
            // 
            // PurpleBtx
            // 
            this.PurpleBtx.AutoSize = true;
            this.PurpleBtx.Location = new System.Drawing.Point(7, 65);
            this.PurpleBtx.Name = "PurpleBtx";
            this.PurpleBtx.Size = new System.Drawing.Size(55, 17);
            this.PurpleBtx.TabIndex = 2;
            this.PurpleBtx.Text = "Purple";
            this.PurpleBtx.UseVisualStyleBackColor = true;
            this.PurpleBtx.CheckedChanged += new System.EventHandler(this.PurpleBtx_CheckedChanged);
            // 
            // DarkBluebtx
            // 
            this.DarkBluebtx.AutoSize = true;
            this.DarkBluebtx.Location = new System.Drawing.Point(6, 42);
            this.DarkBluebtx.Name = "DarkBluebtx";
            this.DarkBluebtx.Size = new System.Drawing.Size(72, 17);
            this.DarkBluebtx.TabIndex = 1;
            this.DarkBluebtx.Text = "Dark Blue";
            this.DarkBluebtx.UseVisualStyleBackColor = true;
            this.DarkBluebtx.CheckedChanged += new System.EventHandler(this.DarkBluebtx_CheckedChanged);
            // 
            // LightBluebtx
            // 
            this.LightBluebtx.AutoSize = true;
            this.LightBluebtx.Location = new System.Drawing.Point(6, 19);
            this.LightBluebtx.Name = "LightBluebtx";
            this.LightBluebtx.Size = new System.Drawing.Size(71, 17);
            this.LightBluebtx.TabIndex = 0;
            this.LightBluebtx.Text = "Light blue";
            this.LightBluebtx.UseVisualStyleBackColor = true;
            this.LightBluebtx.CheckedChanged += new System.EventHandler(this.LightBluebtx_CheckedChanged);
            // 
            // SetMoonBtx
            // 
            this.SetMoonBtx.Location = new System.Drawing.Point(15, 252);
            this.SetMoonBtx.Name = "SetMoonBtx";
            this.SetMoonBtx.Size = new System.Drawing.Size(185, 20);
            this.SetMoonBtx.TabIndex = 45;
            this.SetMoonBtx.Text = "Set Moonlight in room";
            this.SetMoonBtx.Click += new System.EventHandler(this.SetMoonBtx_Click);
            // 
            // DensityNm
            // 
            this.DensityNm.Location = new System.Drawing.Point(277, 126);
            this.DensityNm.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.DensityNm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DensityNm.Name = "DensityNm";
            this.DensityNm.Size = new System.Drawing.Size(88, 20);
            this.DensityNm.TabIndex = 46;
            this.DensityNm.Value = new decimal(new int[] {
            79,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Density";
            // 
            // DiscoNumericcool
            // 
            this.DiscoNumericcool.Location = new System.Drawing.Point(220, 33);
            this.DiscoNumericcool.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.DiscoNumericcool.Name = "DiscoNumericcool";
            this.DiscoNumericcool.Size = new System.Drawing.Size(88, 20);
            this.DiscoNumericcool.TabIndex = 48;
            this.DiscoNumericcool.Value = new decimal(new int[] {
            79,
            0,
            0,
            0});
            // 
            // LiveEditCoolNb
            // 
            this.LiveEditCoolNb.Location = new System.Drawing.Point(220, 210);
            this.LiveEditCoolNb.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.LiveEditCoolNb.Name = "LiveEditCoolNb";
            this.LiveEditCoolNb.Size = new System.Drawing.Size(88, 20);
            this.LiveEditCoolNb.TabIndex = 49;
            this.LiveEditCoolNb.Value = new decimal(new int[] {
            79,
            0,
            0,
            0});
            // 
            // LiveEditBtn
            // 
            this.LiveEditBtn.Location = new System.Drawing.Point(15, 210);
            this.LiveEditBtn.Name = "LiveEditBtn";
            this.LiveEditBtn.Size = new System.Drawing.Size(185, 20);
            this.LiveEditBtn.TabIndex = 50;
            this.LiveEditBtn.Text = "Live editing: Deactivated";
            this.LiveEditBtn.Click += new System.EventHandler(this.LiveEditBtn_Click);
            // 
            // MoonLightFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LiveEditBtn);
            this.Controls.Add(this.LiveEditCoolNb);
            this.Controls.Add(this.DiscoNumericcool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DensityNm);
            this.Controls.Add(this.SetMoonBtx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OnlyWallChbx);
            this.Controls.Add(this.SMoonDiscoBtn);
            this.Name = "MoonLightFun";

            this.Size = new System.Drawing.Size(398, 275);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscoNumericcool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveEditCoolNb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreButton SMoonDiscoBtn;
        private System.Windows.Forms.CheckBox OnlyWallChbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CustomBtx;
        private System.Windows.Forms.RadioButton GreenBtx;
        private System.Windows.Forms.RadioButton YellowBtx;
        private System.Windows.Forms.RadioButton RedBtx;
        private System.Windows.Forms.RadioButton PurpleBtx;
        private System.Windows.Forms.RadioButton DarkBluebtx;
        private System.Windows.Forms.RadioButton LightBluebtx;
        private System.Windows.Forms.TextBox ColorHTMLtxb;
        private Sulakore.Components.SKoreButton SetMoonBtx;
        private System.Windows.Forms.NumericUpDown DensityNm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DiscoNumericcool;
        private System.Windows.Forms.NumericUpDown LiveEditCoolNb;
        private Sulakore.Components.SKoreButton LiveEditBtn;
    }
}
