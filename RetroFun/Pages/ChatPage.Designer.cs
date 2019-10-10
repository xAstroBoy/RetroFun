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
            this.UseSelectedBubbleChbx = new System.Windows.Forms.CheckBox();
            this.HideSpeakingBubbleChbx = new System.Windows.Forms.CheckBox();
            this.AntiBobbaFilterChbx = new System.Windows.Forms.CheckBox();
            this.GroupChatDefault = new System.Windows.Forms.GroupBox();
            this.WhisperChatBox = new System.Windows.Forms.RadioButton();
            this.ShoutTalkBox = new System.Windows.Forms.RadioButton();
            this.NormalTalkBox = new System.Windows.Forms.RadioButton();
            this.ForceDefSpeakBox = new System.Windows.Forms.CheckBox();
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
            this.BubblesCmbx.Location = new System.Drawing.Point(37, 78);
            this.BubblesCmbx.Name = "BubblesCmbx";
            this.BubblesCmbx.Size = new System.Drawing.Size(105, 31);
            this.BubblesCmbx.TabIndex = 0;
            this.BubblesCmbx.SelectedIndexChanged += new System.EventHandler(this.BubblesCmbx_SelectedIndexChanged);
            // 
            // UseSelectedBubbleChbx
            // 
            this.UseSelectedBubbleChbx.AutoSize = true;
            this.UseSelectedBubbleChbx.Location = new System.Drawing.Point(37, 138);
            this.UseSelectedBubbleChbx.Name = "UseSelectedBubbleChbx";
            this.UseSelectedBubbleChbx.Size = new System.Drawing.Size(126, 17);
            this.UseSelectedBubbleChbx.TabIndex = 1;
            this.UseSelectedBubbleChbx.Text = "Use Selected Bubble";
            this.UseSelectedBubbleChbx.UseVisualStyleBackColor = true;
            // 
            // HideSpeakingBubbleChbx
            // 
            this.HideSpeakingBubbleChbx.AutoSize = true;
            this.HideSpeakingBubbleChbx.Location = new System.Drawing.Point(37, 161);
            this.HideSpeakingBubbleChbx.Name = "HideSpeakingBubbleChbx";
            this.HideSpeakingBubbleChbx.Size = new System.Drawing.Size(132, 17);
            this.HideSpeakingBubbleChbx.TabIndex = 2;
            this.HideSpeakingBubbleChbx.Text = "Hide Speaking Bubble";
            this.HideSpeakingBubbleChbx.UseVisualStyleBackColor = true;
            // 
            // AntiBobbaFilterChbx
            // 
            this.AntiBobbaFilterChbx.AutoSize = true;
            this.AntiBobbaFilterChbx.Location = new System.Drawing.Point(37, 115);
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
            this.GroupChatDefault.Location = new System.Drawing.Point(282, 77);
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
            this.ForceDefSpeakBox.Location = new System.Drawing.Point(37, 184);
            this.ForceDefSpeakBox.Name = "ForceDefSpeakBox";
            this.ForceDefSpeakBox.Size = new System.Drawing.Size(136, 17);
            this.ForceDefSpeakBox.TabIndex = 5;
            this.ForceDefSpeakBox.Text = "Force Default speaking";
            this.ForceDefSpeakBox.UseVisualStyleBackColor = true;
            this.ForceDefSpeakBox.CheckedChanged += new System.EventHandler(this.ForceDefSpeakBox_CheckedChanged);
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ForceDefSpeakBox);
            this.Controls.Add(this.GroupChatDefault);
            this.Controls.Add(this.AntiBobbaFilterChbx);
            this.Controls.Add(this.HideSpeakingBubbleChbx);
            this.Controls.Add(this.UseSelectedBubbleChbx);
            this.Controls.Add(this.BubblesCmbx);
            this.Name = "ChatPage";
            this.GroupChatDefault.ResumeLayout(false);
            this.GroupChatDefault.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ImageComboBox BubblesCmbx;
        private System.Windows.Forms.CheckBox UseSelectedBubbleChbx;
        private System.Windows.Forms.CheckBox HideSpeakingBubbleChbx;
        private System.Windows.Forms.CheckBox AntiBobbaFilterChbx;
        private System.Windows.Forms.GroupBox GroupChatDefault;
        private System.Windows.Forms.RadioButton WhisperChatBox;
        private System.Windows.Forms.RadioButton ShoutTalkBox;
        private System.Windows.Forms.RadioButton NormalTalkBox;
        private System.Windows.Forms.CheckBox ForceDefSpeakBox;
    }
}
