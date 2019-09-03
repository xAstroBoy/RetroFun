namespace BobbaFun.Pages
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
            this.BubblesCmbx = new BobbaFun.Controls.ImageComboBox();
            this.UseSelectedBubbleChbx = new System.Windows.Forms.CheckBox();
            this.HideSpeakingBubbleChbx = new System.Windows.Forms.CheckBox();
            this.AntiBobbaFilterChbx = new System.Windows.Forms.CheckBox();
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
            this.BubblesCmbx.Location = new System.Drawing.Point(164, 80);
            this.BubblesCmbx.Name = "BubblesCmbx";
            this.BubblesCmbx.Size = new System.Drawing.Size(105, 31);
            this.BubblesCmbx.TabIndex = 0;
            this.BubblesCmbx.SelectedIndexChanged += new System.EventHandler(this.BubblesCmbx_SelectedIndexChanged);
            // 
            // UseSelectedBubbleChbx
            // 
            this.UseSelectedBubbleChbx.AutoSize = true;
            this.UseSelectedBubbleChbx.Location = new System.Drawing.Point(164, 140);
            this.UseSelectedBubbleChbx.Name = "UseSelectedBubbleChbx";
            this.UseSelectedBubbleChbx.Size = new System.Drawing.Size(126, 17);
            this.UseSelectedBubbleChbx.TabIndex = 1;
            this.UseSelectedBubbleChbx.Text = "Use Selected Bubble";
            this.UseSelectedBubbleChbx.UseVisualStyleBackColor = true;
            // 
            // HideSpeakingBubbleChbx
            // 
            this.HideSpeakingBubbleChbx.AutoSize = true;
            this.HideSpeakingBubbleChbx.Location = new System.Drawing.Point(164, 163);
            this.HideSpeakingBubbleChbx.Name = "HideSpeakingBubbleChbx";
            this.HideSpeakingBubbleChbx.Size = new System.Drawing.Size(132, 17);
            this.HideSpeakingBubbleChbx.TabIndex = 2;
            this.HideSpeakingBubbleChbx.Text = "Hide Speaking Bubble";
            this.HideSpeakingBubbleChbx.UseVisualStyleBackColor = true;
            // 
            // AntiBobbaFilterChbx
            // 
            this.AntiBobbaFilterChbx.AutoSize = true;
            this.AntiBobbaFilterChbx.Location = new System.Drawing.Point(164, 117);
            this.AntiBobbaFilterChbx.Name = "AntiBobbaFilterChbx";
            this.AntiBobbaFilterChbx.Size = new System.Drawing.Size(103, 17);
            this.AntiBobbaFilterChbx.TabIndex = 3;
            this.AntiBobbaFilterChbx.Text = "Anti-Bobba Filter";
            this.AntiBobbaFilterChbx.UseVisualStyleBackColor = true;
            // 
            // ChatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AntiBobbaFilterChbx);
            this.Controls.Add(this.HideSpeakingBubbleChbx);
            this.Controls.Add(this.UseSelectedBubbleChbx);
            this.Controls.Add(this.BubblesCmbx);
            this.Name = "ChatPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ImageComboBox BubblesCmbx;
        private System.Windows.Forms.CheckBox UseSelectedBubbleChbx;
        private System.Windows.Forms.CheckBox HideSpeakingBubbleChbx;
        private System.Windows.Forms.CheckBox AntiBobbaFilterChbx;
    }
}
