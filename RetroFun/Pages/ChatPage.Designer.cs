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
            this.GroupChatDefault.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownFloodNbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.BubblesSSCmbx.Location = new System.Drawing.Point(30, 29);
            this.BubblesSSCmbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BubblesSSCmbx.Name = "BubblesSSCmbx";
            this.BubblesSSCmbx.Size = new System.Drawing.Size(156, 31);
            this.BubblesSSCmbx.TabIndex = 0;
            this.BubblesSSCmbx.SelectedIndexChanged += new System.EventHandler(this.BubblesCmbx_SelectedIndexChanged);
            // 
            // UseSelectedBubbleSSChbx
            // 
            this.UseSelectedBubbleSSChbx.AutoSize = true;
            this.UseSelectedBubbleSSChbx.Location = new System.Drawing.Point(28, 84);
            this.UseSelectedBubbleSSChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseSelectedBubbleSSChbx.Name = "UseSelectedBubbleSSChbx";
            this.UseSelectedBubbleSSChbx.Size = new System.Drawing.Size(135, 24);
            this.UseSelectedBubbleSSChbx.TabIndex = 1;
            this.UseSelectedBubbleSSChbx.Text = "Server Bubble";
            this.UseSelectedBubbleSSChbx.UseVisualStyleBackColor = true;
            // 
            // HideSpeakingBubbleChbx
            // 
            this.HideSpeakingBubbleChbx.AutoSize = true;
            this.HideSpeakingBubbleChbx.Location = new System.Drawing.Point(29, 36);
            this.HideSpeakingBubbleChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HideSpeakingBubbleChbx.Name = "HideSpeakingBubbleChbx";
            this.HideSpeakingBubbleChbx.Size = new System.Drawing.Size(193, 24);
            this.HideSpeakingBubbleChbx.TabIndex = 2;
            this.HideSpeakingBubbleChbx.Text = "Hide Speaking Bubble";
            this.HideSpeakingBubbleChbx.UseVisualStyleBackColor = true;
            // 
            // AntiBobbaFilterChbx
            // 
            this.AntiBobbaFilterChbx.AutoSize = true;
            this.AntiBobbaFilterChbx.Location = new System.Drawing.Point(29, 104);
            this.AntiBobbaFilterChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AntiBobbaFilterChbx.Name = "AntiBobbaFilterChbx";
            this.AntiBobbaFilterChbx.Size = new System.Drawing.Size(154, 24);
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
            this.GroupChatDefault.Location = new System.Drawing.Point(20, 54);
            this.GroupChatDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupChatDefault.Name = "GroupChatDefault";
            this.GroupChatDefault.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupChatDefault.Size = new System.Drawing.Size(178, 155);
            this.GroupChatDefault.TabIndex = 4;
            this.GroupChatDefault.TabStop = false;
            this.GroupChatDefault.Text = "Chat control";
            // 
            // WhisperChatBox
            // 
            this.WhisperChatBox.AutoSize = true;
            this.WhisperChatBox.Location = new System.Drawing.Point(9, 109);
            this.WhisperChatBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WhisperChatBox.Name = "WhisperChatBox";
            this.WhisperChatBox.Size = new System.Drawing.Size(92, 24);
            this.WhisperChatBox.TabIndex = 2;
            this.WhisperChatBox.Text = "Whisper";
            this.WhisperChatBox.UseVisualStyleBackColor = true;
            // 
            // ShoutTalkBox
            // 
            this.ShoutTalkBox.AutoSize = true;
            this.ShoutTalkBox.Location = new System.Drawing.Point(9, 74);
            this.ShoutTalkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShoutTalkBox.Name = "ShoutTalkBox";
            this.ShoutTalkBox.Size = new System.Drawing.Size(77, 24);
            this.ShoutTalkBox.TabIndex = 1;
            this.ShoutTalkBox.Text = "Shout";
            this.ShoutTalkBox.UseVisualStyleBackColor = true;
            // 
            // NormalTalkBox
            // 
            this.NormalTalkBox.AutoSize = true;
            this.NormalTalkBox.Checked = true;
            this.NormalTalkBox.Location = new System.Drawing.Point(9, 38);
            this.NormalTalkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NormalTalkBox.Name = "NormalTalkBox";
            this.NormalTalkBox.Size = new System.Drawing.Size(84, 24);
            this.NormalTalkBox.TabIndex = 0;
            this.NormalTalkBox.TabStop = true;
            this.NormalTalkBox.Text = "Normal";
            this.NormalTalkBox.UseVisualStyleBackColor = true;
            // 
            // ForceDefSpeakBox
            // 
            this.ForceDefSpeakBox.AutoSize = true;
            this.ForceDefSpeakBox.Location = new System.Drawing.Point(20, 20);
            this.ForceDefSpeakBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ForceDefSpeakBox.Name = "ForceDefSpeakBox";
            this.ForceDefSpeakBox.Size = new System.Drawing.Size(185, 24);
            this.ForceDefSpeakBox.TabIndex = 5;
            this.ForceDefSpeakBox.Text = "Chat Packet Override";
            this.ForceDefSpeakBox.UseVisualStyleBackColor = true;
            this.ForceDefSpeakBox.CheckedChanged += new System.EventHandler(this.ForceDefSpeakBox_CheckedChanged);
            // 
            // RainbowChatChbx
            // 
            this.RainbowChatChbx.AutoSize = true;
            this.RainbowChatChbx.Location = new System.Drawing.Point(29, 70);
            this.RainbowChatChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RainbowChatChbx.Name = "RainbowChatChbx";
            this.RainbowChatChbx.Size = new System.Drawing.Size(135, 24);
            this.RainbowChatChbx.TabIndex = 6;
            this.RainbowChatChbx.Text = "Rainbow Chat";
            this.RainbowChatChbx.UseVisualStyleBackColor = true;
            this.RainbowChatChbx.CheckedChanged += new System.EventHandler(this.RainbowChatChbx_CheckedChanged);
            // 
            // UseSelectedBubbleCSChbx
            // 
            this.UseSelectedBubbleCSChbx.AutoSize = true;
            this.UseSelectedBubbleCSChbx.Location = new System.Drawing.Point(238, 84);
            this.UseSelectedBubbleCSChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseSelectedBubbleCSChbx.Name = "UseSelectedBubbleCSChbx";
            this.UseSelectedBubbleCSChbx.Size = new System.Drawing.Size(129, 24);
            this.UseSelectedBubbleCSChbx.TabIndex = 8;
            this.UseSelectedBubbleCSChbx.Text = "Client Bubble";
            this.UseSelectedBubbleCSChbx.UseVisualStyleBackColor = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Enabled = false;
            this.UsernameTextBox.Location = new System.Drawing.Point(30, 122);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(308, 26);
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
            this.BubblesCSCmbx.Location = new System.Drawing.Point(238, 29);
            this.BubblesCSCmbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BubblesCSCmbx.Name = "BubblesCSCmbx";
            this.BubblesCSCmbx.Size = new System.Drawing.Size(156, 31);
            this.BubblesCSCmbx.TabIndex = 10;
            this.BubblesCSCmbx.SelectedIndexChanged += new System.EventHandler(this.BubblesCSCmbx_SelectedIndexChanged);
            // 
            // TextFloodPhraseBox
            // 
            this.TextFloodPhraseBox.Location = new System.Drawing.Point(8, 62);
            this.TextFloodPhraseBox.MaxLength = 2147483647;
            this.TextFloodPhraseBox.Name = "TextFloodPhraseBox";
            this.TextFloodPhraseBox.Size = new System.Drawing.Size(308, 26);
            this.TextFloodPhraseBox.TabIndex = 12;
            // 
            // FloodBtn
            // 
            this.FloodBtn.Location = new System.Drawing.Point(8, 178);
            this.FloodBtn.Name = "FloodBtn";
            this.FloodBtn.Size = new System.Drawing.Size(308, 37);
            this.FloodBtn.TabIndex = 13;
            this.FloodBtn.Text = "Flooder : OFF";
            this.FloodBtn.Click += new System.EventHandler(this.FloodBtn_Click);
            // 
            // CooldownFloodNbx
            // 
            this.CooldownFloodNbx.Location = new System.Drawing.Point(10, 132);
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
            this.CooldownFloodNbx.Size = new System.Drawing.Size(120, 26);
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
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cooldown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 167);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bubble Choice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RainbowChatChbx);
            this.groupBox2.Controls.Add(this.AntiBobbaFilterChbx);
            this.groupBox2.Controls.Add(this.HideSpeakingBubbleChbx);
            this.groupBox2.Location = new System.Drawing.Point(33, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 141);
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
            this.groupBox3.Location = new System.Drawing.Point(481, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 240);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flooder";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ForceDefSpeakBox);
            this.groupBox4.Controls.Add(this.GroupChatDefault);
            this.groupBox4.Location = new System.Drawing.Point(840, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 233);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chat Override";
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChatPage";
            this.Size = new System.Drawing.Size(1090, 469);
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
    }
}
