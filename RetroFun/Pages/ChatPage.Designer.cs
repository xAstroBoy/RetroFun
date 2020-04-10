namespace RetroFun.Pages
{
    partial class ChatPage
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
            this.BubblesSSCmbx = new RetroFun.Controls.ImageComboBox();
            this.UseSelectedBubbleSSChbx = new System.Windows.Forms.CheckBox();
            this.HideSpeakingBubbleChbx = new System.Windows.Forms.CheckBox();
            this.AntiBobbaFilterChbx = new System.Windows.Forms.CheckBox();
            this.GroupChatDefault = new System.Windows.Forms.GroupBox();
            this.WhisperChatBox = new System.Windows.Forms.RadioButton();
            this.ShoutTalkBox = new System.Windows.Forms.RadioButton();
            this.NormalTalkBox = new System.Windows.Forms.RadioButton();
            this.ForceDefSpeakBox = new System.Windows.Forms.CheckBox();
            this.RainbowChatChbx = new System.Windows.Forms.CheckBox();
            this.UseSelectedBubbleCSChbx = new System.Windows.Forms.CheckBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.BubblesCSCmbx = new RetroFun.Controls.ImageComboBox();
            this.TextFloodPhraseBox = new System.Windows.Forms.TextBox();
            this.FloodBtn = new Sulakore.Components.SKoreButton();
            this.CooldownFloodNbx = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CooldownCloneUserChatNbx = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.FindIndexBtn = new Sulakore.Components.SKoreButton();
            this.IndexNbx = new System.Windows.Forms.NumericUpDown();
            this.CloneUserSpeakBtn = new Sulakore.Components.SKoreButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TargetUserTxb = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SendMessageBtn = new Sulakore.Components.SKoreButton();
            this.ChatMsgTxb = new System.Windows.Forms.TextBox();
            this.GroupChatDefault.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownFloodNbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownCloneUserChatNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexNbx)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // BubblesSSCmbx
            // 
            this.BubblesSSCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BubblesSSCmbx.DropDownHeight = 200;
            this.BubblesSSCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BubblesSSCmbx.FormattingEnabled = true;
            this.BubblesSSCmbx.IntegralHeight = false;
            this.BubblesSSCmbx.ItemHeight = 25;
            this.BubblesSSCmbx.Location = new System.Drawing.Point(20, 19);
            this.BubblesSSCmbx.Name = "BubblesSSCmbx";
            this.BubblesSSCmbx.Size = new System.Drawing.Size(105, 31);
            this.BubblesSSCmbx.TabIndex = 0;
            this.BubblesSSCmbx.SelectedIndexChanged += new System.EventHandler(this.BubblesCmbx_SelectedIndexChanged);
            // 
            // UseSelectedBubbleSSChbx
            // 
            this.UseSelectedBubbleSSChbx.AutoSize = true;
            this.UseSelectedBubbleSSChbx.Location = new System.Drawing.Point(19, 55);
            this.UseSelectedBubbleSSChbx.Name = "UseSelectedBubbleSSChbx";
            this.UseSelectedBubbleSSChbx.Size = new System.Drawing.Size(93, 17);
            this.UseSelectedBubbleSSChbx.TabIndex = 1;
            this.UseSelectedBubbleSSChbx.Text = "Server Bubble";
            this.UseSelectedBubbleSSChbx.UseVisualStyleBackColor = true;
            // 
            // HideSpeakingBubbleChbx
            // 
            this.HideSpeakingBubbleChbx.AutoSize = true;
            this.HideSpeakingBubbleChbx.Location = new System.Drawing.Point(19, 23);
            this.HideSpeakingBubbleChbx.Name = "HideSpeakingBubbleChbx";
            this.HideSpeakingBubbleChbx.Size = new System.Drawing.Size(132, 17);
            this.HideSpeakingBubbleChbx.TabIndex = 2;
            this.HideSpeakingBubbleChbx.Text = "Hide Speaking Bubble";
            this.HideSpeakingBubbleChbx.UseVisualStyleBackColor = true;
            // 
            // AntiBobbaFilterChbx
            // 
            this.AntiBobbaFilterChbx.AutoSize = true;
            this.AntiBobbaFilterChbx.Location = new System.Drawing.Point(19, 68);
            this.AntiBobbaFilterChbx.Name = "AntiBobbaFilterChbx";
            this.AntiBobbaFilterChbx.Size = new System.Drawing.Size(103, 17);
            this.AntiBobbaFilterChbx.TabIndex = 3;
            this.AntiBobbaFilterChbx.Text = "Anti-Bobba Filter";
            this.AntiBobbaFilterChbx.UseVisualStyleBackColor = true;
            // 
            // GroupChatDefault
            // 
            this.GroupChatDefault.Controls.Add(this.WhisperChatBox);
            this.GroupChatDefault.Controls.Add(this.ShoutTalkBox);
            this.GroupChatDefault.Controls.Add(this.NormalTalkBox);
            this.GroupChatDefault.Enabled = false;
            this.GroupChatDefault.Location = new System.Drawing.Point(13, 35);
            this.GroupChatDefault.Name = "GroupChatDefault";
            this.GroupChatDefault.Size = new System.Drawing.Size(119, 101);
            this.GroupChatDefault.TabIndex = 4;
            this.GroupChatDefault.TabStop = false;
            this.GroupChatDefault.Text = "Chat control";
            // 
            // WhisperChatBox
            // 
            this.WhisperChatBox.AutoSize = true;
            this.WhisperChatBox.Location = new System.Drawing.Point(6, 71);
            this.WhisperChatBox.Name = "WhisperChatBox";
            this.WhisperChatBox.Size = new System.Drawing.Size(64, 17);
            this.WhisperChatBox.TabIndex = 2;
            this.WhisperChatBox.Text = "Whisper";
            this.WhisperChatBox.UseVisualStyleBackColor = true;
            // 
            // ShoutTalkBox
            // 
            this.ShoutTalkBox.AutoSize = true;
            this.ShoutTalkBox.Location = new System.Drawing.Point(6, 48);
            this.ShoutTalkBox.Name = "ShoutTalkBox";
            this.ShoutTalkBox.Size = new System.Drawing.Size(53, 17);
            this.ShoutTalkBox.TabIndex = 1;
            this.ShoutTalkBox.Text = "Shout";
            this.ShoutTalkBox.UseVisualStyleBackColor = true;
            // 
            // NormalTalkBox
            // 
            this.NormalTalkBox.AutoSize = true;
            this.NormalTalkBox.Checked = true;
            this.NormalTalkBox.Location = new System.Drawing.Point(6, 25);
            this.NormalTalkBox.Name = "NormalTalkBox";
            this.NormalTalkBox.Size = new System.Drawing.Size(58, 17);
            this.NormalTalkBox.TabIndex = 0;
            this.NormalTalkBox.TabStop = true;
            this.NormalTalkBox.Text = "Normal";
            this.NormalTalkBox.UseVisualStyleBackColor = true;
            // 
            // ForceDefSpeakBox
            // 
            this.ForceDefSpeakBox.AutoSize = true;
            this.ForceDefSpeakBox.Location = new System.Drawing.Point(13, 13);
            this.ForceDefSpeakBox.Name = "ForceDefSpeakBox";
            this.ForceDefSpeakBox.Size = new System.Drawing.Size(128, 17);
            this.ForceDefSpeakBox.TabIndex = 5;
            this.ForceDefSpeakBox.Text = "Chat Packet Override";
            this.ForceDefSpeakBox.UseVisualStyleBackColor = true;
            // 
            // RainbowChatChbx
            // 
            this.RainbowChatChbx.AutoSize = true;
            this.RainbowChatChbx.Location = new System.Drawing.Point(19, 45);
            this.RainbowChatChbx.Name = "RainbowChatChbx";
            this.RainbowChatChbx.Size = new System.Drawing.Size(93, 17);
            this.RainbowChatChbx.TabIndex = 6;
            this.RainbowChatChbx.Text = "Rainbow Chat";
            this.RainbowChatChbx.UseVisualStyleBackColor = true;
            this.RainbowChatChbx.CheckedChanged += new System.EventHandler(this.RainbowChatChbx_CheckedChanged);
            // 
            // UseSelectedBubbleCSChbx
            // 
            this.UseSelectedBubbleCSChbx.AutoSize = true;
            this.UseSelectedBubbleCSChbx.Location = new System.Drawing.Point(159, 55);
            this.UseSelectedBubbleCSChbx.Name = "UseSelectedBubbleCSChbx";
            this.UseSelectedBubbleCSChbx.Size = new System.Drawing.Size(88, 17);
            this.UseSelectedBubbleCSChbx.TabIndex = 8;
            this.UseSelectedBubbleCSChbx.Text = "Client Bubble";
            this.UseSelectedBubbleCSChbx.UseVisualStyleBackColor = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Enabled = false;
            this.UsernameTextBox.Location = new System.Drawing.Point(20, 79);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ReadOnly = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(207, 20);
            this.UsernameTextBox.TabIndex = 9;
            this.UsernameTextBox.Text = "Finding Username...";
            // 
            // BubblesCSCmbx
            // 
            this.BubblesCSCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BubblesCSCmbx.DropDownHeight = 200;
            this.BubblesCSCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BubblesCSCmbx.FormattingEnabled = true;
            this.BubblesCSCmbx.IntegralHeight = false;
            this.BubblesCSCmbx.ItemHeight = 25;
            this.BubblesCSCmbx.Location = new System.Drawing.Point(159, 19);
            this.BubblesCSCmbx.Name = "BubblesCSCmbx";
            this.BubblesCSCmbx.Size = new System.Drawing.Size(105, 31);
            this.BubblesCSCmbx.TabIndex = 10;
            this.BubblesCSCmbx.SelectedIndexChanged += new System.EventHandler(this.BubblesCSCmbx_SelectedIndexChanged);
            // 
            // TextFloodPhraseBox
            // 
            this.TextFloodPhraseBox.Location = new System.Drawing.Point(5, 40);
            this.TextFloodPhraseBox.Margin = new System.Windows.Forms.Padding(2);
            this.TextFloodPhraseBox.MaxLength = 2147483647;
            this.TextFloodPhraseBox.Name = "TextFloodPhraseBox";
            this.TextFloodPhraseBox.Size = new System.Drawing.Size(207, 20);
            this.TextFloodPhraseBox.TabIndex = 12;
            // 
            // FloodBtn
            // 
            this.FloodBtn.Location = new System.Drawing.Point(5, 116);
            this.FloodBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FloodBtn.Name = "FloodBtn";
            this.FloodBtn.Size = new System.Drawing.Size(205, 24);
            this.FloodBtn.TabIndex = 13;
            this.FloodBtn.Text = "Flooder : OFF";
            this.FloodBtn.Click += new System.EventHandler(this.FloodBtn_Click);
            // 
            // CooldownFloodNbx
            // 
            this.CooldownFloodNbx.Location = new System.Drawing.Point(7, 86);
            this.CooldownFloodNbx.Margin = new System.Windows.Forms.Padding(2);
            this.CooldownFloodNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CooldownFloodNbx.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CooldownFloodNbx.Name = "CooldownFloodNbx";
            this.CooldownFloodNbx.Size = new System.Drawing.Size(80, 20);
            this.CooldownFloodNbx.TabIndex = 14;
            this.CooldownFloodNbx.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cooldown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Flood Text";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BubblesCSCmbx);
            this.groupBox1.Controls.Add(this.UsernameTextBox);
            this.groupBox1.Controls.Add(this.UseSelectedBubbleCSChbx);
            this.groupBox1.Controls.Add(this.UseSelectedBubbleSSChbx);
            this.groupBox1.Controls.Add(this.BubblesSSCmbx);
            this.groupBox1.Location = new System.Drawing.Point(23, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(283, 109);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bubble Choice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RainbowChatChbx);
            this.groupBox2.Controls.Add(this.AntiBobbaFilterChbx);
            this.groupBox2.Controls.Add(this.HideSpeakingBubbleChbx);
            this.groupBox2.Location = new System.Drawing.Point(22, 125);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(185, 92);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.CooldownFloodNbx);
            this.groupBox3.Controls.Add(this.FloodBtn);
            this.groupBox3.Controls.Add(this.TextFloodPhraseBox);
            this.groupBox3.Location = new System.Drawing.Point(321, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(231, 156);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flooder";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ForceDefSpeakBox);
            this.groupBox4.Controls.Add(this.GroupChatDefault);
            this.groupBox4.Location = new System.Drawing.Point(560, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(150, 151);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chat Override";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CooldownCloneUserChatNbx);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.FindIndexBtn);
            this.groupBox5.Controls.Add(this.IndexNbx);
            this.groupBox5.Controls.Add(this.CloneUserSpeakBtn);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.TargetUserTxb);
            this.groupBox5.Location = new System.Drawing.Point(321, 170);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(376, 185);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Raid With Clone";
            // 
            // CooldownCloneUserChatNbx
            // 
            this.CooldownCloneUserChatNbx.Location = new System.Drawing.Point(255, 47);
            this.CooldownCloneUserChatNbx.Margin = new System.Windows.Forms.Padding(2);
            this.CooldownCloneUserChatNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CooldownCloneUserChatNbx.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CooldownCloneUserChatNbx.Name = "CooldownCloneUserChatNbx";
            this.CooldownCloneUserChatNbx.Size = new System.Drawing.Size(80, 20);
            this.CooldownCloneUserChatNbx.TabIndex = 17;
            this.CooldownCloneUserChatNbx.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cooldown:";
            // 
            // FindIndexBtn
            // 
            this.FindIndexBtn.Location = new System.Drawing.Point(7, 136);
            this.FindIndexBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FindIndexBtn.Name = "FindIndexBtn";
            this.FindIndexBtn.Size = new System.Drawing.Size(205, 24);
            this.FindIndexBtn.TabIndex = 19;
            this.FindIndexBtn.Text = "Find Index";
            this.FindIndexBtn.Click += new System.EventHandler(this.FindIndexBtn_click);
            // 
            // IndexNbx
            // 
            this.IndexNbx.Location = new System.Drawing.Point(8, 87);
            this.IndexNbx.Margin = new System.Windows.Forms.Padding(2);
            this.IndexNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.IndexNbx.Name = "IndexNbx";
            this.IndexNbx.ReadOnly = true;
            this.IndexNbx.Size = new System.Drawing.Size(204, 20);
            this.IndexNbx.TabIndex = 18;
            // 
            // CloneUserSpeakBtn
            // 
            this.CloneUserSpeakBtn.Location = new System.Drawing.Point(7, 108);
            this.CloneUserSpeakBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloneUserSpeakBtn.Name = "CloneUserSpeakBtn";
            this.CloneUserSpeakBtn.Size = new System.Drawing.Size(205, 24);
            this.CloneUserSpeakBtn.TabIndex = 17;
            this.CloneUserSpeakBtn.Text = "Clone User Speak : OFF";
            this.CloneUserSpeakBtn.Click += new System.EventHandler(this.CloneUserSpeakBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Target User :";
            // 
            // TargetUserTxb
            // 
            this.TargetUserTxb.Location = new System.Drawing.Point(7, 66);
            this.TargetUserTxb.Margin = new System.Windows.Forms.Padding(2);
            this.TargetUserTxb.MaxLength = 2147483647;
            this.TargetUserTxb.Name = "TargetUserTxb";
            this.TargetUserTxb.Size = new System.Drawing.Size(207, 20);
            this.TargetUserTxb.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.SendMessageBtn);
            this.groupBox6.Controls.Add(this.ChatMsgTxb);
            this.groupBox6.Location = new System.Drawing.Point(23, 237);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(231, 105);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Flooder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Chat Text";
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Location = new System.Drawing.Point(4, 69);
            this.SendMessageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(205, 24);
            this.SendMessageBtn.TabIndex = 13;
            this.SendMessageBtn.Text = "Send To Server";
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // ChatMsgTxb
            // 
            this.ChatMsgTxb.Location = new System.Drawing.Point(5, 40);
            this.ChatMsgTxb.Margin = new System.Windows.Forms.Padding(2);
            this.ChatMsgTxb.MaxLength = 2147483647;
            this.ChatMsgTxb.Name = "ChatMsgTxb";
            this.ChatMsgTxb.Size = new System.Drawing.Size(207, 20);
            this.ChatMsgTxb.TabIndex = 12;
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChatPage";
            this.Size = new System.Drawing.Size(727, 357);
            this.GroupChatDefault.ResumeLayout(false);
            this.GroupChatDefault.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownFloodNbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownCloneUserChatNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexNbx)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ImageComboBox BubblesSSCmbx;
        private Controls.ImageComboBox BubblesCSCmbx;

        private System.Windows.Forms.CheckBox UseSelectedBubbleSSChbx;
        private System.Windows.Forms.CheckBox HideSpeakingBubbleChbx;
        private System.Windows.Forms.CheckBox AntiBobbaFilterChbx;
        private System.Windows.Forms.GroupBox GroupChatDefault;
        private System.Windows.Forms.RadioButton WhisperChatBox;
        private System.Windows.Forms.RadioButton ShoutTalkBox;
        private System.Windows.Forms.RadioButton NormalTalkBox;
        private System.Windows.Forms.CheckBox ForceDefSpeakBox;
        private System.Windows.Forms.CheckBox RainbowChatChbx;
        private System.Windows.Forms.CheckBox UseSelectedBubbleCSChbx;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox TextFloodPhraseBox;
        private Sulakore.Components.SKoreButton FloodBtn;
        private System.Windows.Forms.NumericUpDown CooldownFloodNbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private Sulakore.Components.SKoreButton CloneUserSpeakBtn;
        private System.Windows.Forms.TextBox TargetUserTxb;
        private System.Windows.Forms.NumericUpDown IndexNbx;
        private Sulakore.Components.SKoreButton FindIndexBtn;
        private System.Windows.Forms.NumericUpDown CooldownCloneUserChatNbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private Sulakore.Components.SKoreButton SendMessageBtn;
        private System.Windows.Forms.TextBox ChatMsgTxb;
    }
}
