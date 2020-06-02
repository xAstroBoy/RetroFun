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
            this.OnlyWallChbx = new System.Windows.Forms.CheckBox();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.BlackRadioBtn = new System.Windows.Forms.RadioButton();
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
            this.LiveEditBtn = new Sulakore.Components.SKoreButton();
            this.ColorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNm)).BeginInit();
            this.SuspendLayout();
            // 
            // OnlyWallChbx
            // 
            this.OnlyWallChbx.AutoSize = true;
            this.OnlyWallChbx.Location = new System.Drawing.Point(432, 131);
            this.OnlyWallChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OnlyWallChbx.Name = "OnlyWallChbx";
            this.OnlyWallChbx.Size = new System.Drawing.Size(141, 24);
            this.OnlyWallChbx.TabIndex = 43;
            this.OnlyWallChbx.Text = "Only Wallpaper";
            this.OnlyWallChbx.UseVisualStyleBackColor = true;
            // 
            // ColorBox
            // 
            this.ColorBox.Controls.Add(this.BlackRadioBtn);
            this.ColorBox.Controls.Add(this.ColorHTMLtxb);
            this.ColorBox.Controls.Add(this.CustomBtx);
            this.ColorBox.Controls.Add(this.GreenBtx);
            this.ColorBox.Controls.Add(this.YellowBtx);
            this.ColorBox.Controls.Add(this.RedBtx);
            this.ColorBox.Controls.Add(this.PurpleBtx);
            this.ColorBox.Controls.Add(this.DarkBluebtx);
            this.ColorBox.Controls.Add(this.LightBluebtx);
            this.ColorBox.Location = new System.Drawing.Point(24, 12);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorBox.Size = new System.Drawing.Size(380, 154);
            this.ColorBox.TabIndex = 44;
            this.ColorBox.TabStop = false;
            this.ColorBox.Text = "Colors";
            // 
            // BlackRadioBtn
            // 
            this.BlackRadioBtn.AutoSize = true;
            this.BlackRadioBtn.Location = new System.Drawing.Point(214, 29);
            this.BlackRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlackRadioBtn.Name = "BlackRadioBtn";
            this.BlackRadioBtn.Size = new System.Drawing.Size(73, 24);
            this.BlackRadioBtn.TabIndex = 46;
            this.BlackRadioBtn.Text = "Black";
            this.BlackRadioBtn.UseVisualStyleBackColor = true;
            this.BlackRadioBtn.CheckedChanged += new System.EventHandler(this.BlackRadioBtn_CheckedChanged);
            // 
            // ColorHTMLtxb
            // 
            this.ColorHTMLtxb.Enabled = false;
            this.ColorHTMLtxb.Location = new System.Drawing.Point(214, 95);
            this.ColorHTMLtxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorHTMLtxb.MaxLength = 6;
            this.ColorHTMLtxb.Name = "ColorHTMLtxb";
            this.ColorHTMLtxb.Size = new System.Drawing.Size(148, 26);
            this.ColorHTMLtxb.TabIndex = 45;
            this.ColorHTMLtxb.TextChanged += new System.EventHandler(this.ColorHTMLtxb_TextChanged);
            // 
            // CustomBtx
            // 
            this.CustomBtx.AutoSize = true;
            this.CustomBtx.Location = new System.Drawing.Point(214, 65);
            this.CustomBtx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomBtx.Name = "CustomBtx";
            this.CustomBtx.Size = new System.Drawing.Size(89, 24);
            this.CustomBtx.TabIndex = 6;
            this.CustomBtx.Text = "Custom";
            this.CustomBtx.UseVisualStyleBackColor = true;
            this.CustomBtx.CheckedChanged += new System.EventHandler(this.CustomBtx_CheckedChanged);
            // 
            // GreenBtx
            // 
            this.GreenBtx.AutoSize = true;
            this.GreenBtx.Location = new System.Drawing.Point(124, 100);
            this.GreenBtx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GreenBtx.Name = "GreenBtx";
            this.GreenBtx.Size = new System.Drawing.Size(79, 24);
            this.GreenBtx.TabIndex = 5;
            this.GreenBtx.Text = "Green";
            this.GreenBtx.UseVisualStyleBackColor = true;
            this.GreenBtx.CheckedChanged += new System.EventHandler(this.GreenBtx_CheckedChanged);
            // 
            // YellowBtx
            // 
            this.YellowBtx.AutoSize = true;
            this.YellowBtx.Location = new System.Drawing.Point(124, 65);
            this.YellowBtx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YellowBtx.Name = "YellowBtx";
            this.YellowBtx.Size = new System.Drawing.Size(80, 24);
            this.YellowBtx.TabIndex = 4;
            this.YellowBtx.Text = "Yellow";
            this.YellowBtx.UseVisualStyleBackColor = true;
            this.YellowBtx.CheckedChanged += new System.EventHandler(this.YellowBtx_CheckedChanged);
            // 
            // RedBtx
            // 
            this.RedBtx.AutoSize = true;
            this.RedBtx.Location = new System.Drawing.Point(124, 29);
            this.RedBtx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RedBtx.Name = "RedBtx";
            this.RedBtx.Size = new System.Drawing.Size(64, 24);
            this.RedBtx.TabIndex = 3;
            this.RedBtx.Text = "Red";
            this.RedBtx.UseVisualStyleBackColor = true;
            this.RedBtx.CheckedChanged += new System.EventHandler(this.RedBtx_CheckedChanged);
            // 
            // PurpleBtx
            // 
            this.PurpleBtx.AutoSize = true;
            this.PurpleBtx.Location = new System.Drawing.Point(10, 100);
            this.PurpleBtx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PurpleBtx.Name = "PurpleBtx";
            this.PurpleBtx.Size = new System.Drawing.Size(79, 24);
            this.PurpleBtx.TabIndex = 2;
            this.PurpleBtx.Text = "Purple";
            this.PurpleBtx.UseVisualStyleBackColor = true;
            this.PurpleBtx.CheckedChanged += new System.EventHandler(this.PurpleBtx_CheckedChanged);
            // 
            // DarkBluebtx
            // 
            this.DarkBluebtx.AutoSize = true;
            this.DarkBluebtx.Location = new System.Drawing.Point(9, 65);
            this.DarkBluebtx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DarkBluebtx.Name = "DarkBluebtx";
            this.DarkBluebtx.Size = new System.Drawing.Size(104, 24);
            this.DarkBluebtx.TabIndex = 1;
            this.DarkBluebtx.Text = "Dark Blue";
            this.DarkBluebtx.UseVisualStyleBackColor = true;
            this.DarkBluebtx.CheckedChanged += new System.EventHandler(this.DarkBluebtx_CheckedChanged);
            // 
            // LightBluebtx
            // 
            this.LightBluebtx.AutoSize = true;
            this.LightBluebtx.Checked = true;
            this.LightBluebtx.Location = new System.Drawing.Point(9, 29);
            this.LightBluebtx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LightBluebtx.Name = "LightBluebtx";
            this.LightBluebtx.Size = new System.Drawing.Size(103, 24);
            this.LightBluebtx.TabIndex = 0;
            this.LightBluebtx.TabStop = true;
            this.LightBluebtx.Text = "Light blue";
            this.LightBluebtx.UseVisualStyleBackColor = true;
            this.LightBluebtx.CheckedChanged += new System.EventHandler(this.LightBluebtx_CheckedChanged);
            // 
            // SetMoonBtx
            // 
            this.SetMoonBtx.Location = new System.Drawing.Point(24, 266);
            this.SetMoonBtx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetMoonBtx.Name = "SetMoonBtx";
            this.SetMoonBtx.Size = new System.Drawing.Size(278, 31);
            this.SetMoonBtx.TabIndex = 45;
            this.SetMoonBtx.Text = "Set Moonlight in room";
            this.SetMoonBtx.Click += new System.EventHandler(this.SetMoonBtx_Click);
            // 
            // DensityNm
            // 
            this.DensityNm.Location = new System.Drawing.Point(430, 63);
            this.DensityNm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.DensityNm.Size = new System.Drawing.Size(132, 26);
            this.DensityNm.TabIndex = 46;
            this.DensityNm.Value = new decimal(new int[] {
            79,
            0,
            0,
            0});
            this.DensityNm.ValueChanged += new System.EventHandler(this.DensityNm_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Density";
            // 
            // LiveEditBtn
            // 
            this.LiveEditBtn.Location = new System.Drawing.Point(24, 202);
            this.LiveEditBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LiveEditBtn.Name = "LiveEditBtn";
            this.LiveEditBtn.Size = new System.Drawing.Size(278, 31);
            this.LiveEditBtn.TabIndex = 50;
            this.LiveEditBtn.Text = "Live editing: Deactivated";
            this.LiveEditBtn.Click += new System.EventHandler(this.LiveEditBtn_Click);
            // 
            // MoonLightFunPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LiveEditBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DensityNm);
            this.Controls.Add(this.SetMoonBtx);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.OnlyWallChbx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MoonLightFunPage";
            this.Size = new System.Drawing.Size(632, 423);
            this.ColorBox.ResumeLayout(false);
            this.ColorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox OnlyWallChbx;
        private System.Windows.Forms.GroupBox ColorBox;
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
        private Sulakore.Components.SKoreButton LiveEditBtn;
        private System.Windows.Forms.RadioButton BlackRadioBtn;
    }
}
