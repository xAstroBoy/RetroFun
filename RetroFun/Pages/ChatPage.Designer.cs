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
            this.GroupChatDefault.SuspendLayout();
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
            this.BubblesSSCmbx.Location = new System.Drawing.Point(64, 41);
            this.BubblesSSCmbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BubblesSSCmbx.Name = "BubblesSSCmbx";
            this.BubblesSSCmbx.Size = new System.Drawing.Size(156, 31);
            this.BubblesSSCmbx.TabIndex = 0;
            this.BubblesSSCmbx.SelectedIndexChanged += new System.EventHandler(this.BubblesCmbx_SelectedIndexChanged);
            // 
            // UseSelectedBubbleSSChbx
            // 
            this.UseSelectedBubbleSSChbx.AutoSize = true;
            this.UseSelectedBubbleSSChbx.Location = new System.Drawing.Point(62, 96);
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
            this.HideSpeakingBubbleChbx.Location = new System.Drawing.Point(62, 225);
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
            this.AntiBobbaFilterChbx.Location = new System.Drawing.Point(64, 191);
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
            this.GroupChatDefault.Location = new System.Drawing.Point(485, 191);
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
            this.ForceDefSpeakBox.Location = new System.Drawing.Point(485, 157);
            this.ForceDefSpeakBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ForceDefSpeakBox.Name = "ForceDefSpeakBox";
            this.ForceDefSpeakBox.Size = new System.Drawing.Size(200, 24);
            this.ForceDefSpeakBox.TabIndex = 5;
            this.ForceDefSpeakBox.Text = "Force Default speaking";
            this.ForceDefSpeakBox.UseVisualStyleBackColor = true;
            this.ForceDefSpeakBox.CheckedChanged += new System.EventHandler(this.ForceDefSpeakBox_CheckedChanged);
            // 
            // RainbowChatChbx
            // 
            this.RainbowChatChbx.AutoSize = true;
            this.RainbowChatChbx.Location = new System.Drawing.Point(62, 259);
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
            this.UseSelectedBubbleCSChbx.Location = new System.Drawing.Point(272, 96);
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
            this.UsernameTextBox.Location = new System.Drawing.Point(64, 141);
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
            this.BubblesCSCmbx.Location = new System.Drawing.Point(272, 41);
            this.BubblesCSCmbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BubblesCSCmbx.Name = "BubblesCSCmbx";
            this.BubblesCSCmbx.Size = new System.Drawing.Size(156, 31);
            this.BubblesCSCmbx.TabIndex = 10;
            this.BubblesCSCmbx.SelectedIndexChanged += new System.EventHandler(this.BubblesCSCmbx_SelectedIndexChanged);
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BubblesCSCmbx);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UseSelectedBubbleCSChbx);
            this.Controls.Add(this.RainbowChatChbx);
            this.Controls.Add(this.ForceDefSpeakBox);
            this.Controls.Add(this.GroupChatDefault);
            this.Controls.Add(this.AntiBobbaFilterChbx);
            this.Controls.Add(this.HideSpeakingBubbleChbx);
            this.Controls.Add(this.UseSelectedBubbleSSChbx);
            this.Controls.Add(this.BubblesSSCmbx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChatPage";
            this.Size = new System.Drawing.Size(905, 469);
            this.GroupChatDefault.ResumeLayout(false);
            this.GroupChatDefault.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
