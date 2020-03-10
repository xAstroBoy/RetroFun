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
            this.BubblesCmbx = new RetroFun.Controls.ImageComboBox();
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
            this.GroupChatDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // BubblesCmbx
            // 
            this.BubblesCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BubblesCmbx.DropDownHeight = 200;
            this.BubblesCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BubblesCmbx.FormattingEnabled = true;
            this.BubblesCmbx.IntegralHeight = false;
            this.BubblesCmbx.ItemHeight = 25;
            this.BubblesCmbx.Location = new System.Drawing.Point(62, 55);
            this.BubblesCmbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BubblesCmbx.Name = "BubblesCmbx";
            this.BubblesCmbx.Size = new System.Drawing.Size(156, 31);
            this.BubblesCmbx.TabIndex = 0;
            this.BubblesCmbx.SelectedIndexChanged += new System.EventHandler(this.BubblesCmbx_SelectedIndexChanged);
            // 
            // UseSelectedBubbleSSChbx
            // 
            this.UseSelectedBubbleSSChbx.AutoSize = true;
            this.UseSelectedBubbleSSChbx.Location = new System.Drawing.Point(62, 120);
            this.UseSelectedBubbleSSChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseSelectedBubbleSSChbx.Name = "UseSelectedBubbleSSChbx";
            this.UseSelectedBubbleSSChbx.Size = new System.Drawing.Size(310, 24);
            this.UseSelectedBubbleSSChbx.TabIndex = 1;
            this.UseSelectedBubbleSSChbx.Text = "Use Selected Bubble (SERVER SIDE)";
            this.UseSelectedBubbleSSChbx.UseVisualStyleBackColor = true;
            // 
            // HideSpeakingBubbleChbx
            // 
            this.HideSpeakingBubbleChbx.AutoSize = true;
            this.HideSpeakingBubbleChbx.Location = new System.Drawing.Point(62, 310);
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
            this.AntiBobbaFilterChbx.Location = new System.Drawing.Point(64, 276);
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
            this.RainbowChatChbx.Location = new System.Drawing.Point(62, 344);
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
            this.UseSelectedBubbleCSChbx.Location = new System.Drawing.Point(62, 174);
            this.UseSelectedBubbleCSChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UseSelectedBubbleCSChbx.Name = "UseSelectedBubbleCSChbx";
            this.UseSelectedBubbleCSChbx.Size = new System.Drawing.Size(298, 24);
            this.UseSelectedBubbleCSChbx.TabIndex = 8;
            this.UseSelectedBubbleCSChbx.Text = "Use Selected Bubble (CLIENT SIDE)";
            this.UseSelectedBubbleCSChbx.UseVisualStyleBackColor = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(64, 206);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(308, 26);
            this.UsernameTextBox.TabIndex = 9;
            this.UsernameTextBox.Text = "Please put username...";
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UseSelectedBubbleCSChbx);
            this.Controls.Add(this.RainbowChatChbx);
            this.Controls.Add(this.ForceDefSpeakBox);
            this.Controls.Add(this.GroupChatDefault);
            this.Controls.Add(this.AntiBobbaFilterChbx);
            this.Controls.Add(this.HideSpeakingBubbleChbx);
            this.Controls.Add(this.UseSelectedBubbleSSChbx);
            this.Controls.Add(this.BubblesCmbx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChatPage";
            this.Size = new System.Drawing.Size(905, 469);
            this.GroupChatDefault.ResumeLayout(false);
            this.GroupChatDefault.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ImageComboBox BubblesCmbx;
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
