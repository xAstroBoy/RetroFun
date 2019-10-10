namespace RetroFun.Pages
{
    partial class MiscellaneousPage
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

        private void InitializeComponent()
        {
            this.NoRemoveFriendOnReport = new System.Windows.Forms.CheckBox();
            this.SignCountGroup = new System.Windows.Forms.GroupBox();
            this.CountingBtn = new Sulakore.Components.SKoreButton();
            this.FiveChbx = new System.Windows.Forms.CheckBox();
            this.ZeroChbx = new System.Windows.Forms.CheckBox();
            this.TenChBx = new System.Windows.Forms.CheckBox();
            this.SixChbx = new System.Windows.Forms.CheckBox();
            this.SevenChbx = new System.Windows.Forms.CheckBox();
            this.EightChbx = new System.Windows.Forms.CheckBox();
            this.NineChbx = new System.Windows.Forms.CheckBox();
            this.ThreeChbx = new System.Windows.Forms.CheckBox();
            this.FourChbx = new System.Windows.Forms.CheckBox();
            this.TwoChbx = new System.Windows.Forms.CheckBox();
            this.OneChbx = new System.Windows.Forms.CheckBox();
            this.SignCountBtn = new Sulakore.Components.SKoreButton();
            this.SignCountCoolDown = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Action_Kiss = new System.Windows.Forms.RadioButton();
            this.Action_laugh = new System.Windows.Forms.RadioButton();
            this.Action_sleep = new System.Windows.Forms.RadioButton();
            this.Action_handwave = new System.Windows.Forms.RadioButton();
            this.Action_respect = new System.Windows.Forms.RadioButton();
            this.ActionsCooldownnbx = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionOnLoopBtn = new Sulakore.Components.SKoreButton();
            this.UserSitBtn = new Sulakore.Components.SKoreButton();
            this.SitOnLoopBtn = new Sulakore.Components.SKoreButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SitCoolDownNbx = new System.Windows.Forms.NumericUpDown();
            this.GenMaleLookBtn = new Sulakore.Components.SKoreButton();
            this.GenLookGenThreadBtn = new Sulakore.Components.SKoreButton();
            this.GenFemaleLookBtn = new Sulakore.Components.SKoreButton();
            this.SignCountGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignCountCoolDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionsCooldownnbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SitCoolDownNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // NoRemoveFriendOnReport
            // 
            this.NoRemoveFriendOnReport.AutoSize = true;
            this.NoRemoveFriendOnReport.Checked = true;
            this.NoRemoveFriendOnReport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NoRemoveFriendOnReport.Location = new System.Drawing.Point(24, 28);
            this.NoRemoveFriendOnReport.Name = "NoRemoveFriendOnReport";
            this.NoRemoveFriendOnReport.Size = new System.Drawing.Size(195, 17);
            this.NoRemoveFriendOnReport.TabIndex = 4;
            this.NoRemoveFriendOnReport.Text = "Anti-Friend Removal when reported.";
            this.NoRemoveFriendOnReport.UseVisualStyleBackColor = true;
            // 
            // SignCountGroup
            // 
            this.SignCountGroup.Controls.Add(this.CountingBtn);
            this.SignCountGroup.Controls.Add(this.FiveChbx);
            this.SignCountGroup.Controls.Add(this.ZeroChbx);
            this.SignCountGroup.Controls.Add(this.TenChBx);
            this.SignCountGroup.Controls.Add(this.SixChbx);
            this.SignCountGroup.Controls.Add(this.SevenChbx);
            this.SignCountGroup.Controls.Add(this.EightChbx);
            this.SignCountGroup.Controls.Add(this.NineChbx);
            this.SignCountGroup.Controls.Add(this.ThreeChbx);
            this.SignCountGroup.Controls.Add(this.FourChbx);
            this.SignCountGroup.Controls.Add(this.TwoChbx);
            this.SignCountGroup.Controls.Add(this.OneChbx);
            this.SignCountGroup.Location = new System.Drawing.Point(24, 100);
            this.SignCountGroup.Name = "SignCountGroup";
            this.SignCountGroup.Size = new System.Drawing.Size(121, 111);
            this.SignCountGroup.TabIndex = 5;
            this.SignCountGroup.TabStop = false;
            this.SignCountGroup.Text = "Sign Counter";
            // 
            // CountingBtn
            // 
            this.CountingBtn.Location = new System.Drawing.Point(76, 85);
            this.CountingBtn.Name = "CountingBtn";
            this.CountingBtn.Size = new System.Drawing.Size(45, 20);
            this.CountingBtn.TabIndex = 56;
            this.CountingBtn.Text = "0→10";
            this.CountingBtn.Click += new System.EventHandler(this.CountingBtn_Click);
            // 
            // FiveChbx
            // 
            this.FiveChbx.AutoSize = true;
            this.FiveChbx.Location = new System.Drawing.Point(44, 42);
            this.FiveChbx.Name = "FiveChbx";
            this.FiveChbx.Size = new System.Drawing.Size(32, 17);
            this.FiveChbx.TabIndex = 10;
            this.FiveChbx.Text = "5";
            this.FiveChbx.UseVisualStyleBackColor = true;
            // 
            // ZeroChbx
            // 
            this.ZeroChbx.AutoSize = true;
            this.ZeroChbx.Location = new System.Drawing.Point(6, 19);
            this.ZeroChbx.Name = "ZeroChbx";
            this.ZeroChbx.Size = new System.Drawing.Size(32, 17);
            this.ZeroChbx.TabIndex = 9;
            this.ZeroChbx.Text = "0";
            this.ZeroChbx.UseVisualStyleBackColor = true;
            // 
            // TenChBx
            // 
            this.TenChBx.AutoSize = true;
            this.TenChBx.Location = new System.Drawing.Point(82, 65);
            this.TenChBx.Name = "TenChBx";
            this.TenChBx.Size = new System.Drawing.Size(38, 17);
            this.TenChBx.TabIndex = 8;
            this.TenChBx.Text = "10";
            this.TenChBx.UseVisualStyleBackColor = true;
            // 
            // SixChbx
            // 
            this.SixChbx.AutoSize = true;
            this.SixChbx.Location = new System.Drawing.Point(44, 65);
            this.SixChbx.Name = "SixChbx";
            this.SixChbx.Size = new System.Drawing.Size(32, 17);
            this.SixChbx.TabIndex = 7;
            this.SixChbx.Text = "6";
            this.SixChbx.UseVisualStyleBackColor = true;
            // 
            // SevenChbx
            // 
            this.SevenChbx.AutoSize = true;
            this.SevenChbx.Location = new System.Drawing.Point(44, 88);
            this.SevenChbx.Name = "SevenChbx";
            this.SevenChbx.Size = new System.Drawing.Size(32, 17);
            this.SevenChbx.TabIndex = 6;
            this.SevenChbx.Text = "7";
            this.SevenChbx.UseVisualStyleBackColor = true;
            // 
            // EightChbx
            // 
            this.EightChbx.AutoSize = true;
            this.EightChbx.Location = new System.Drawing.Point(82, 19);
            this.EightChbx.Name = "EightChbx";
            this.EightChbx.Size = new System.Drawing.Size(32, 17);
            this.EightChbx.TabIndex = 5;
            this.EightChbx.Text = "8";
            this.EightChbx.UseVisualStyleBackColor = true;
            // 
            // NineChbx
            // 
            this.NineChbx.AutoSize = true;
            this.NineChbx.Location = new System.Drawing.Point(82, 42);
            this.NineChbx.Name = "NineChbx";
            this.NineChbx.Size = new System.Drawing.Size(32, 17);
            this.NineChbx.TabIndex = 4;
            this.NineChbx.Text = "9";
            this.NineChbx.UseVisualStyleBackColor = true;
            // 
            // ThreeChbx
            // 
            this.ThreeChbx.AutoSize = true;
            this.ThreeChbx.Location = new System.Drawing.Point(6, 88);
            this.ThreeChbx.Name = "ThreeChbx";
            this.ThreeChbx.Size = new System.Drawing.Size(32, 17);
            this.ThreeChbx.TabIndex = 3;
            this.ThreeChbx.Text = "3";
            this.ThreeChbx.UseVisualStyleBackColor = true;
            // 
            // FourChbx
            // 
            this.FourChbx.AutoSize = true;
            this.FourChbx.Location = new System.Drawing.Point(44, 19);
            this.FourChbx.Name = "FourChbx";
            this.FourChbx.Size = new System.Drawing.Size(32, 17);
            this.FourChbx.TabIndex = 2;
            this.FourChbx.Text = "4";
            this.FourChbx.UseVisualStyleBackColor = true;
            // 
            // TwoChbx
            // 
            this.TwoChbx.AutoSize = true;
            this.TwoChbx.Location = new System.Drawing.Point(6, 65);
            this.TwoChbx.Name = "TwoChbx";
            this.TwoChbx.Size = new System.Drawing.Size(32, 17);
            this.TwoChbx.TabIndex = 1;
            this.TwoChbx.Text = "2";
            this.TwoChbx.UseVisualStyleBackColor = true;
            // 
            // OneChbx
            // 
            this.OneChbx.AutoSize = true;
            this.OneChbx.Location = new System.Drawing.Point(6, 42);
            this.OneChbx.Name = "OneChbx";
            this.OneChbx.Size = new System.Drawing.Size(32, 17);
            this.OneChbx.TabIndex = 0;
            this.OneChbx.Text = "1";
            this.OneChbx.UseVisualStyleBackColor = true;
            // 
            // SignCountBtn
            // 
            this.SignCountBtn.Location = new System.Drawing.Point(24, 256);
            this.SignCountBtn.Name = "SignCountBtn";
            this.SignCountBtn.Size = new System.Drawing.Size(100, 20);
            this.SignCountBtn.TabIndex = 6;
            this.SignCountBtn.Text = "Sign Count : Off";
            this.SignCountBtn.Click += new System.EventHandler(this.SignCountBtn_Click);
            // 
            // SignCountCoolDown
            // 
            this.SignCountCoolDown.Location = new System.Drawing.Point(30, 230);
            this.SignCountCoolDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SignCountCoolDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.SignCountCoolDown.Name = "SignCountCoolDown";
            this.SignCountCoolDown.Size = new System.Drawing.Size(88, 20);
            this.SignCountCoolDown.TabIndex = 54;
            this.SignCountCoolDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(27, 214);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(118, 13);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "Sign Counter Cooldown";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Action_Kiss);
            this.groupBox1.Controls.Add(this.Action_laugh);
            this.groupBox1.Controls.Add(this.Action_sleep);
            this.groupBox1.Controls.Add(this.Action_handwave);
            this.groupBox1.Controls.Add(this.Action_respect);
            this.groupBox1.Location = new System.Drawing.Point(188, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 131);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions On Loop";
            // 
            // Action_Kiss
            // 
            this.Action_Kiss.AutoSize = true;
            this.Action_Kiss.Location = new System.Drawing.Point(6, 108);
            this.Action_Kiss.Name = "Action_Kiss";
            this.Action_Kiss.Size = new System.Drawing.Size(44, 17);
            this.Action_Kiss.TabIndex = 4;
            this.Action_Kiss.Text = "Kiss";
            this.Action_Kiss.UseVisualStyleBackColor = true;
            // 
            // Action_laugh
            // 
            this.Action_laugh.AutoSize = true;
            this.Action_laugh.Location = new System.Drawing.Point(6, 85);
            this.Action_laugh.Name = "Action_laugh";
            this.Action_laugh.Size = new System.Drawing.Size(55, 17);
            this.Action_laugh.TabIndex = 3;
            this.Action_laugh.Text = "Laugh";
            this.Action_laugh.UseVisualStyleBackColor = true;
            // 
            // Action_sleep
            // 
            this.Action_sleep.AutoSize = true;
            this.Action_sleep.Location = new System.Drawing.Point(6, 62);
            this.Action_sleep.Name = "Action_sleep";
            this.Action_sleep.Size = new System.Drawing.Size(52, 17);
            this.Action_sleep.TabIndex = 2;
            this.Action_sleep.Text = "Sleep";
            this.Action_sleep.UseVisualStyleBackColor = true;
            // 
            // Action_handwave
            // 
            this.Action_handwave.AutoSize = true;
            this.Action_handwave.Location = new System.Drawing.Point(5, 39);
            this.Action_handwave.Name = "Action_handwave";
            this.Action_handwave.Size = new System.Drawing.Size(75, 17);
            this.Action_handwave.TabIndex = 1;
            this.Action_handwave.Text = "handwave";
            this.Action_handwave.UseVisualStyleBackColor = true;
            // 
            // Action_respect
            // 
            this.Action_respect.AutoSize = true;
            this.Action_respect.Checked = true;
            this.Action_respect.Location = new System.Drawing.Point(6, 18);
            this.Action_respect.Name = "Action_respect";
            this.Action_respect.Size = new System.Drawing.Size(65, 17);
            this.Action_respect.TabIndex = 0;
            this.Action_respect.TabStop = true;
            this.Action_respect.Text = "Respect";
            this.Action_respect.UseVisualStyleBackColor = true;
            // 
            // ActionsCooldownnbx
            // 
            this.ActionsCooldownnbx.Location = new System.Drawing.Point(188, 237);
            this.ActionsCooldownnbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ActionsCooldownnbx.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ActionsCooldownnbx.Name = "ActionsCooldownnbx";
            this.ActionsCooldownnbx.Size = new System.Drawing.Size(88, 20);
            this.ActionsCooldownnbx.TabIndex = 57;
            this.ActionsCooldownnbx.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Action Cooldown";
            // 
            // ActionOnLoopBtn
            // 
            this.ActionOnLoopBtn.Location = new System.Drawing.Point(188, 266);
            this.ActionOnLoopBtn.Name = "ActionOnLoopBtn";
            this.ActionOnLoopBtn.Size = new System.Drawing.Size(119, 20);
            this.ActionOnLoopBtn.TabIndex = 59;
            this.ActionOnLoopBtn.Text = "Actions On Loop : Off";
            this.ActionOnLoopBtn.Click += new System.EventHandler(this.ActionOnLoopBtn_Click);
            // 
            // UserSitBtn
            // 
            this.UserSitBtn.Location = new System.Drawing.Point(335, 142);
            this.UserSitBtn.Name = "UserSitBtn";
            this.UserSitBtn.Size = new System.Drawing.Size(119, 20);
            this.UserSitBtn.TabIndex = 60;
            this.UserSitBtn.Text = "Make user Sit";
            this.UserSitBtn.Click += new System.EventHandler(this.UserSitBtn_Click);
            // 
            // SitOnLoopBtn
            // 
            this.SitOnLoopBtn.Location = new System.Drawing.Point(335, 191);
            this.SitOnLoopBtn.Name = "SitOnLoopBtn";
            this.SitOnLoopBtn.Size = new System.Drawing.Size(119, 20);
            this.SitOnLoopBtn.TabIndex = 61;
            this.SitOnLoopBtn.Text = "Sit Loop : Off";
            this.SitOnLoopBtn.Click += new System.EventHandler(this.SitOnLoopBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Sit Cooldown";
            // 
            // SitCoolDownNbx
            // 
            this.SitCoolDownNbx.Location = new System.Drawing.Point(335, 237);
            this.SitCoolDownNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SitCoolDownNbx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SitCoolDownNbx.Name = "SitCoolDownNbx";
            this.SitCoolDownNbx.Size = new System.Drawing.Size(88, 20);
            this.SitCoolDownNbx.TabIndex = 62;
            this.SitCoolDownNbx.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // GenMaleLookBtn
            // 
            this.GenMaleLookBtn.Location = new System.Drawing.Point(335, 100);
            this.GenMaleLookBtn.Name = "GenMaleLookBtn";
            this.GenMaleLookBtn.Size = new System.Drawing.Size(119, 20);
            this.GenMaleLookBtn.TabIndex = 64;
            this.GenMaleLookBtn.Text = "Look Generator (Male)";
            this.GenMaleLookBtn.Click += new System.EventHandler(this.GenMaleLookBtn_Click);
            // 
            // GenLookGenThreadBtn
            // 
            this.GenLookGenThreadBtn.Location = new System.Drawing.Point(573, 222);
            this.GenLookGenThreadBtn.Name = "GenLookGenThreadBtn";
            this.GenLookGenThreadBtn.Size = new System.Drawing.Size(100, 20);
            this.GenLookGenThreadBtn.TabIndex = 65;
            this.GenLookGenThreadBtn.Text = "Look Generator : Off";
            this.GenLookGenThreadBtn.Click += new System.EventHandler(this.GenLookGenThreadBtn_Click);
            // 
            // GenFemaleLookBtn
            // 
            this.GenFemaleLookBtn.Location = new System.Drawing.Point(335, 74);
            this.GenFemaleLookBtn.Name = "GenFemaleLookBtn";
            this.GenFemaleLookBtn.Size = new System.Drawing.Size(119, 20);
            this.GenFemaleLookBtn.TabIndex = 66;
            this.GenFemaleLookBtn.Text = "Look Generator (Female)";
            this.GenFemaleLookBtn.Click += new System.EventHandler(this.GenFemaleLookBtn_Click);
            // 
            // MiscellaneousPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenFemaleLookBtn);
            this.Controls.Add(this.GenLookGenThreadBtn);
            this.Controls.Add(this.GenMaleLookBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SitCoolDownNbx);
            this.Controls.Add(this.SitOnLoopBtn);
            this.Controls.Add(this.UserSitBtn);
            this.Controls.Add(this.ActionOnLoopBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionsCooldownnbx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.SignCountCoolDown);
            this.Controls.Add(this.SignCountBtn);
            this.Controls.Add(this.SignCountGroup);
            this.Controls.Add(this.NoRemoveFriendOnReport);
            this.Name = "MiscellaneousPage";
            this.Size = new System.Drawing.Size(736, 305);
            this.SignCountGroup.ResumeLayout(false);
            this.SignCountGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignCountCoolDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionsCooldownnbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SitCoolDownNbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.CheckBox NoRemoveFriendOnReport;
        private System.Windows.Forms.GroupBox SignCountGroup;
        private System.Windows.Forms.CheckBox ZeroChbx;
        private System.Windows.Forms.CheckBox TenChBx;
        private System.Windows.Forms.CheckBox SixChbx;
        private System.Windows.Forms.CheckBox SevenChbx;
        private System.Windows.Forms.CheckBox EightChbx;
        private System.Windows.Forms.CheckBox NineChbx;
        private System.Windows.Forms.CheckBox ThreeChbx;
        private System.Windows.Forms.CheckBox FourChbx;
        private System.Windows.Forms.CheckBox TwoChbx;
        private System.Windows.Forms.CheckBox OneChbx;
        private System.Windows.Forms.CheckBox FiveChbx;
        private Sulakore.Components.SKoreButton SignCountBtn;
        private System.Windows.Forms.NumericUpDown SignCountCoolDown;
        private System.Windows.Forms.Label Label2;
        private Sulakore.Components.SKoreButton CountingBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Action_Kiss;
        private System.Windows.Forms.RadioButton Action_laugh;
        private System.Windows.Forms.RadioButton Action_sleep;
        private System.Windows.Forms.RadioButton Action_handwave;
        private System.Windows.Forms.RadioButton Action_respect;
        private System.Windows.Forms.NumericUpDown ActionsCooldownnbx;
        private System.Windows.Forms.Label label1;
        private Sulakore.Components.SKoreButton ActionOnLoopBtn;
        private Sulakore.Components.SKoreButton UserSitBtn;
        private Sulakore.Components.SKoreButton SitOnLoopBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SitCoolDownNbx;
        private Sulakore.Components.SKoreButton GenMaleLookBtn;
        private Sulakore.Components.SKoreButton GenLookGenThreadBtn;
        private Sulakore.Components.SKoreButton GenFemaleLookBtn;
    }
}
