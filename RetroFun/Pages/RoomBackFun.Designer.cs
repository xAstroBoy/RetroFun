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
            this.CaptureBtn = new Sulakore.Components.SKoreButton();
            this.TonFadeBtn = new Sulakore.Components.SKoreButton();
            this.SaturationFadeBtn = new Sulakore.Components.SKoreButton();
            this.LuminosityFadeBtn = new Sulakore.Components.SKoreButton();
            this.GlobalSpeedNbx = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.LiveEditBtn = new Sulakore.Components.SKoreButton();
            this.RestoreSettingsBtn = new Sulakore.Components.SKoreButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TonSpeednbx = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.SatSpeednbx = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.LumSpeedNbx = new System.Windows.Forms.NumericUpDown();
            this.GlobalSpeedChbx = new System.Windows.Forms.CheckBox();
            this.ApplyCurrentSettingsBtn = new Sulakore.Components.SKoreButton();
            ((System.ComponentModel.ISupportInitialize)(this.TonNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDnb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalSpeedNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TonSpeednbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatSpeednbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LumSpeedNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tonality";
            // 
            // TonNbx
            // 
            this.TonNbx.Location = new System.Drawing.Point(44, 112);
            this.TonNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TonNbx.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.TonNbx.Name = "TonNbx";
            this.TonNbx.Size = new System.Drawing.Size(180, 26);
            this.TonNbx.TabIndex = 1;
            this.TonNbx.ValueChanged += new System.EventHandler(this.TonNbx_ValueChanged);
            // 
            // SatNbx
            // 
            this.SatNbx.Location = new System.Drawing.Point(44, 182);
            this.SatNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SatNbx.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SatNbx.Name = "SatNbx";
            this.SatNbx.Size = new System.Drawing.Size(180, 26);
            this.SatNbx.TabIndex = 2;
            this.SatNbx.ValueChanged += new System.EventHandler(this.SatNbx_ValueChanged);
            // 
            // LightNbx
            // 
            this.LightNbx.Location = new System.Drawing.Point(45, 257);
            this.LightNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LightNbx.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LightNbx.Name = "LightNbx";
            this.LightNbx.Size = new System.Drawing.Size(180, 26);
            this.LightNbx.TabIndex = 3;
            this.LightNbx.ValueChanged += new System.EventHandler(this.LightNbx_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Luminosity";
            // 
            // FurniIDnb
            // 
            this.FurniIDnb.Location = new System.Drawing.Point(355, 406);
            this.FurniIDnb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FurniIDnb.Maximum = new decimal(new int[] {
            2147483647,
            2147483647,
            2147483647,
            0});
            this.FurniIDnb.Name = "FurniIDnb";
            this.FurniIDnb.Size = new System.Drawing.Size(180, 26);
            this.FurniIDnb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "FurniID";
            // 
            // CaptureBtn
            // 
            this.CaptureBtn.Location = new System.Drawing.Point(16, 408);
            this.CaptureBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaptureBtn.Name = "CaptureBtn";
            this.CaptureBtn.Size = new System.Drawing.Size(314, 24);
            this.CaptureBtn.TabIndex = 8;
            this.CaptureBtn.Text = "Capture Current RoomBackground : OFF";
            this.CaptureBtn.Click += new System.EventHandler(this.CaptureBtn_Click);
            // 
            // TonFadeBtn
            // 
            this.TonFadeBtn.Location = new System.Drawing.Point(254, 112);
            this.TonFadeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TonFadeBtn.Name = "TonFadeBtn";
            this.TonFadeBtn.Size = new System.Drawing.Size(214, 31);
            this.TonFadeBtn.TabIndex = 10;
            this.TonFadeBtn.Text = "Tonality Fade : Deactivated";
            this.TonFadeBtn.Click += new System.EventHandler(this.TonFadeBtn_Click);
            // 
            // SaturationFadeBtn
            // 
            this.SaturationFadeBtn.Location = new System.Drawing.Point(254, 182);
            this.SaturationFadeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaturationFadeBtn.Name = "SaturationFadeBtn";
            this.SaturationFadeBtn.Size = new System.Drawing.Size(214, 31);
            this.SaturationFadeBtn.TabIndex = 11;
            this.SaturationFadeBtn.Text = "Saturation Fade : Deactivated";
            this.SaturationFadeBtn.Click += new System.EventHandler(this.SaturationFadeBtn_Click);
            // 
            // LuminosityFadeBtn
            // 
            this.LuminosityFadeBtn.Location = new System.Drawing.Point(254, 257);
            this.LuminosityFadeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LuminosityFadeBtn.Name = "LuminosityFadeBtn";
            this.LuminosityFadeBtn.Size = new System.Drawing.Size(214, 31);
            this.LuminosityFadeBtn.TabIndex = 12;
            this.LuminosityFadeBtn.Text = "Luminosity Fade : Deactivated";
            this.LuminosityFadeBtn.Click += new System.EventHandler(this.LuminosityFadeBtn_Click);
            // 
            // GlobalSpeedNbx
            // 
            this.GlobalSpeedNbx.Enabled = false;
            this.GlobalSpeedNbx.Location = new System.Drawing.Point(623, 406);
            this.GlobalSpeedNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GlobalSpeedNbx.Maximum = new decimal(new int[] {
            2147483647,
            2147483647,
            2147483647,
            0});
            this.GlobalSpeedNbx.Name = "GlobalSpeedNbx";
            this.GlobalSpeedNbx.Size = new System.Drawing.Size(180, 26);
            this.GlobalSpeedNbx.TabIndex = 13;
            this.GlobalSpeedNbx.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Global Speed";
            // 
            // LiveEditBtn
            // 
            this.LiveEditBtn.Location = new System.Drawing.Point(300, 313);
            this.LiveEditBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LiveEditBtn.Name = "LiveEditBtn";
            this.LiveEditBtn.Size = new System.Drawing.Size(212, 31);
            this.LiveEditBtn.TabIndex = 15;
            this.LiveEditBtn.Text = "Live Edit Mode : Off";
            this.LiveEditBtn.Click += new System.EventHandler(this.LiveEditBtn_Click);
            // 
            // RestoreSettingsBtn
            // 
            this.RestoreSettingsBtn.Location = new System.Drawing.Point(574, 313);
            this.RestoreSettingsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RestoreSettingsBtn.Name = "RestoreSettingsBtn";
            this.RestoreSettingsBtn.Size = new System.Drawing.Size(212, 31);
            this.RestoreSettingsBtn.TabIndex = 16;
            this.RestoreSettingsBtn.Text = "Restore Saved Settings";
            this.RestoreSettingsBtn.Click += new System.EventHandler(this.RestoreSettingsBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tonality Speed";
            // 
            // TonSpeednbx
            // 
            this.TonSpeednbx.Location = new System.Drawing.Point(524, 112);
            this.TonSpeednbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TonSpeednbx.Maximum = new decimal(new int[] {
            2147483647,
            2147483647,
            2147483647,
            0});
            this.TonSpeednbx.Name = "TonSpeednbx";
            this.TonSpeednbx.Size = new System.Drawing.Size(180, 26);
            this.TonSpeednbx.TabIndex = 17;
            this.TonSpeednbx.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Saturation Speed";
            // 
            // SatSpeednbx
            // 
            this.SatSpeednbx.Location = new System.Drawing.Point(524, 182);
            this.SatSpeednbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SatSpeednbx.Maximum = new decimal(new int[] {
            2147483647,
            2147483647,
            2147483647,
            0});
            this.SatSpeednbx.Name = "SatSpeednbx";
            this.SatSpeednbx.Size = new System.Drawing.Size(180, 26);
            this.SatSpeednbx.TabIndex = 19;
            this.SatSpeednbx.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Luminosity Speed";
            // 
            // LumSpeedNbx
            // 
            this.LumSpeedNbx.Location = new System.Drawing.Point(524, 262);
            this.LumSpeedNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LumSpeedNbx.Maximum = new decimal(new int[] {
            2147483647,
            2147483647,
            2147483647,
            0});
            this.LumSpeedNbx.Name = "LumSpeedNbx";
            this.LumSpeedNbx.Size = new System.Drawing.Size(180, 26);
            this.LumSpeedNbx.TabIndex = 21;
            this.LumSpeedNbx.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // GlobalSpeedChbx
            // 
            this.GlobalSpeedChbx.AutoSize = true;
            this.GlobalSpeedChbx.Location = new System.Drawing.Point(813, 411);
            this.GlobalSpeedChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GlobalSpeedChbx.Name = "GlobalSpeedChbx";
            this.GlobalSpeedChbx.Size = new System.Drawing.Size(22, 21);
            this.GlobalSpeedChbx.TabIndex = 24;
            this.GlobalSpeedChbx.UseVisualStyleBackColor = true;
            this.GlobalSpeedChbx.CheckedChanged += new System.EventHandler(this.GlobalSpeedChbx_CheckedChanged);
            // 
            // ApplyCurrentSettingsBtn
            // 
            this.ApplyCurrentSettingsBtn.Location = new System.Drawing.Point(43, 313);
            this.ApplyCurrentSettingsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApplyCurrentSettingsBtn.Name = "ApplyCurrentSettingsBtn";
            this.ApplyCurrentSettingsBtn.Size = new System.Drawing.Size(212, 31);
            this.ApplyCurrentSettingsBtn.TabIndex = 25;
            this.ApplyCurrentSettingsBtn.Text = "Apply Current Settings";
            this.ApplyCurrentSettingsBtn.Click += new System.EventHandler(this.ApplyCurrentSettingsBtn_Click);
            // 
            // RoomBackFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ApplyCurrentSettingsBtn);
            this.Controls.Add(this.GlobalSpeedChbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LumSpeedNbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SatSpeednbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TonSpeednbx);
            this.Controls.Add(this.RestoreSettingsBtn);
            this.Controls.Add(this.LiveEditBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GlobalSpeedNbx);
            this.Controls.Add(this.LuminosityFadeBtn);
            this.Controls.Add(this.SaturationFadeBtn);
            this.Controls.Add(this.TonFadeBtn);
            this.Controls.Add(this.CaptureBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FurniIDnb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LightNbx);
            this.Controls.Add(this.SatNbx);
            this.Controls.Add(this.TonNbx);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomBackFun";
            this.Size = new System.Drawing.Size(867, 459);
            ((System.ComponentModel.ISupportInitialize)(this.TonNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDnb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalSpeedNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TonSpeednbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatSpeednbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LumSpeedNbx)).EndInit();
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
        private Sulakore.Components.SKoreButton CaptureBtn;
        private Sulakore.Components.SKoreButton TonFadeBtn;
        private Sulakore.Components.SKoreButton SaturationFadeBtn;
        private Sulakore.Components.SKoreButton LuminosityFadeBtn;
        private System.Windows.Forms.NumericUpDown GlobalSpeedNbx;
        private System.Windows.Forms.Label label5;
        private Sulakore.Components.SKoreButton LiveEditBtn;
        private Sulakore.Components.SKoreButton RestoreSettingsBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TonSpeednbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown SatSpeednbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown LumSpeedNbx;
        private System.Windows.Forms.CheckBox GlobalSpeedChbx;
        private Sulakore.Components.SKoreButton ApplyCurrentSettingsBtn;
    }
}
