namespace RetroFun.Pages
{
    partial class RoomBackFun
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
            this.label1 = new System.Windows.Forms.Label();
            this.TonNbx = new System.Windows.Forms.NumericUpDown();
            this.SatNbx = new System.Windows.Forms.NumericUpDown();
            this.LightNbx = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FurniIDnb = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CaptureBtn = new System.Windows.Forms.CheckBox();
            this.StoreSettingBtn = new Sulakore.Components.SKoreButton();
            this.TonFadeBtn = new Sulakore.Components.SKoreButton();
            this.SaturationFadeBtn = new Sulakore.Components.SKoreButton();
            this.LuminosityFadeBtn = new Sulakore.Components.SKoreButton();
            this.SpeedMan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.LiveEditBtn = new Sulakore.Components.SKoreButton();
            this.RestoreSettingsBtn = new Sulakore.Components.SKoreButton();
            ((System.ComponentModel.ISupportInitialize)(this.TonNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDnb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedMan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tonality";
            // 
            // TonNbx
            // 
            this.TonNbx.Location = new System.Drawing.Point(29, 73);
            this.TonNbx.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.TonNbx.Name = "TonNbx";
            this.TonNbx.Size = new System.Drawing.Size(120, 20);
            this.TonNbx.TabIndex = 1;
            // 
            // SatNbx
            // 
            this.SatNbx.Location = new System.Drawing.Point(29, 118);
            this.SatNbx.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SatNbx.Name = "SatNbx";
            this.SatNbx.Size = new System.Drawing.Size(120, 20);
            this.SatNbx.TabIndex = 2;
            // 
            // LightNbx
            // 
            this.LightNbx.Location = new System.Drawing.Point(30, 167);
            this.LightNbx.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LightNbx.Name = "LightNbx";
            this.LightNbx.Size = new System.Drawing.Size(120, 20);
            this.LightNbx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Luminosity";
            // 
            // FurniIDnb
            // 
            this.FurniIDnb.Location = new System.Drawing.Point(232, 231);
            this.FurniIDnb.Maximum = new decimal(new int[] {
            2147483647,
            2147483647,
            2147483647,
            0});
            this.FurniIDnb.Name = "FurniIDnb";
            this.FurniIDnb.Size = new System.Drawing.Size(120, 20);
            this.FurniIDnb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FurniID";
            // 
            // CaptureBtn
            // 
            this.CaptureBtn.AutoSize = true;
            this.CaptureBtn.Location = new System.Drawing.Point(365, 170);
            this.CaptureBtn.Name = "CaptureBtn";
            this.CaptureBtn.Size = new System.Drawing.Size(189, 17);
            this.CaptureBtn.TabIndex = 8;
            this.CaptureBtn.Text = "Capture Current RoomBackground";
            this.CaptureBtn.UseVisualStyleBackColor = true;
            // 
            // StoreSettingBtn
            // 
            this.StoreSettingBtn.Location = new System.Drawing.Point(29, 205);
            this.StoreSettingBtn.Name = "StoreSettingBtn";
            this.StoreSettingBtn.Size = new System.Drawing.Size(141, 20);
            this.StoreSettingBtn.TabIndex = 9;
            this.StoreSettingBtn.Text = "Store Current Settings";
            this.StoreSettingBtn.Click += new System.EventHandler(this.StoreSettingBtn_Click);
            // 
            // TonFadeBtn
            // 
            this.TonFadeBtn.Location = new System.Drawing.Point(169, 73);
            this.TonFadeBtn.Name = "TonFadeBtn";
            this.TonFadeBtn.Size = new System.Drawing.Size(143, 20);
            this.TonFadeBtn.TabIndex = 10;
            this.TonFadeBtn.Text = "Tonality Fade : Deactivated";
            this.TonFadeBtn.Click += new System.EventHandler(this.TonFadeBtn_Click);
            // 
            // SaturationFadeBtn
            // 
            this.SaturationFadeBtn.Location = new System.Drawing.Point(169, 118);
            this.SaturationFadeBtn.Name = "SaturationFadeBtn";
            this.SaturationFadeBtn.Size = new System.Drawing.Size(143, 20);
            this.SaturationFadeBtn.TabIndex = 11;
            this.SaturationFadeBtn.Text = "Saturation Fade : Deactivated";
            this.SaturationFadeBtn.Click += new System.EventHandler(this.SaturationFadeBtn_Click);
            // 
            // LuminosityFadeBtn
            // 
            this.LuminosityFadeBtn.Location = new System.Drawing.Point(169, 167);
            this.LuminosityFadeBtn.Name = "LuminosityFadeBtn";
            this.LuminosityFadeBtn.Size = new System.Drawing.Size(143, 20);
            this.LuminosityFadeBtn.TabIndex = 12;
            this.LuminosityFadeBtn.Text = "Luminosity Fade : Deactivated";
            this.LuminosityFadeBtn.Click += new System.EventHandler(this.LuminosityFadeBtn_Click);
            // 
            // SpeedMan
            // 
            this.SpeedMan.Location = new System.Drawing.Point(411, 231);
            this.SpeedMan.Maximum = new decimal(new int[] {
            2147483647,
            2147483647,
            2147483647,
            0});
            this.SpeedMan.Name = "SpeedMan";
            this.SpeedMan.Size = new System.Drawing.Size(120, 20);
            this.SpeedMan.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Speed";
            // 
            // LiveEditBtn
            // 
            this.LiveEditBtn.Location = new System.Drawing.Point(365, 118);
            this.LiveEditBtn.Name = "LiveEditBtn";
            this.LiveEditBtn.Size = new System.Drawing.Size(141, 20);
            this.LiveEditBtn.TabIndex = 15;
            this.LiveEditBtn.Text = "Live Edit Mode : Disabled";
            this.LiveEditBtn.Click += new System.EventHandler(this.LiveEditBtn_Click);
            // 
            // RestoreSettingsBtn
            // 
            this.RestoreSettingsBtn.Location = new System.Drawing.Point(29, 231);
            this.RestoreSettingsBtn.Name = "RestoreSettingsBtn";
            this.RestoreSettingsBtn.Size = new System.Drawing.Size(141, 20);
            this.RestoreSettingsBtn.TabIndex = 16;
            this.RestoreSettingsBtn.Text = "Restore Saved Settings";
            this.RestoreSettingsBtn.Click += new System.EventHandler(this.RestoreSettingsBtn_Click);
            // 
            // RoomBackFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RestoreSettingsBtn);
            this.Controls.Add(this.LiveEditBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SpeedMan);
            this.Controls.Add(this.LuminosityFadeBtn);
            this.Controls.Add(this.SaturationFadeBtn);
            this.Controls.Add(this.TonFadeBtn);
            this.Controls.Add(this.StoreSettingBtn);
            this.Controls.Add(this.CaptureBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FurniIDnb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LightNbx);
            this.Controls.Add(this.SatNbx);
            this.Controls.Add(this.TonNbx);
            this.Controls.Add(this.label1);
            this.Name = "RoomBackFun";
            this.Size = new System.Drawing.Size(578, 271);
            ((System.ComponentModel.ISupportInitialize)(this.TonNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDnb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TonNbx;
        private System.Windows.Forms.NumericUpDown SatNbx;
        private System.Windows.Forms.NumericUpDown LightNbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FurniIDnb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CaptureBtn;
        private Sulakore.Components.SKoreButton StoreSettingBtn;
        private Sulakore.Components.SKoreButton TonFadeBtn;
        private Sulakore.Components.SKoreButton SaturationFadeBtn;
        private Sulakore.Components.SKoreButton LuminosityFadeBtn;
        private System.Windows.Forms.NumericUpDown SpeedMan;
        private System.Windows.Forms.Label label5;
        private Sulakore.Components.SKoreButton LiveEditBtn;
        private Sulakore.Components.SKoreButton RestoreSettingsBtn;
    }
}
