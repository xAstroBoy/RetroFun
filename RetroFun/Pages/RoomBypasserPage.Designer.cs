namespace RetroFun.Pages
{
    partial class RoomBypasserPage
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
            this.EnterRoomBtn = new Sulakore.Components.SKoreButton();
            this.ReloadChbx = new System.Windows.Forms.CheckBox();
            this.BypassLimitsChbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EnterRoomBtn
            // 
            this.EnterRoomBtn.Location = new System.Drawing.Point(27, 39);
            this.EnterRoomBtn.Name = "EnterRoomBtn";
            this.EnterRoomBtn.Size = new System.Drawing.Size(187, 68);
            this.EnterRoomBtn.TabIndex = 0;
            this.EnterRoomBtn.Text = "Enter Room";
            this.EnterRoomBtn.Click += new System.EventHandler(this.EnterRoomBtn_Click);
            // 
            // ReloadChbx
            // 
            this.ReloadChbx.AutoSize = true;
            this.ReloadChbx.Location = new System.Drawing.Point(27, 131);
            this.ReloadChbx.Name = "ReloadChbx";
            this.ReloadChbx.Size = new System.Drawing.Size(60, 17);
            this.ReloadChbx.TabIndex = 1;
            this.ReloadChbx.Text = "Reload";
            this.ReloadChbx.UseVisualStyleBackColor = true;
            // 
            // BypassLimitsChbx
            // 
            this.BypassLimitsChbx.AutoSize = true;
            this.BypassLimitsChbx.Location = new System.Drawing.Point(27, 154);
            this.BypassLimitsChbx.Name = "BypassLimitsChbx";
            this.BypassLimitsChbx.Size = new System.Drawing.Size(114, 17);
            this.BypassLimitsChbx.TabIndex = 2;
            this.BypassLimitsChbx.Text = "Bypass The Limits.";
            this.BypassLimitsChbx.UseVisualStyleBackColor = true;
            // 
            // RoomBypasserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BypassLimitsChbx);
            this.Controls.Add(this.ReloadChbx);
            this.Controls.Add(this.EnterRoomBtn);
            this.Name = "RoomBypasserPage";
            this.Size = new System.Drawing.Size(243, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreButton EnterRoomBtn;
        private System.Windows.Forms.CheckBox ReloadChbx;
        private System.Windows.Forms.CheckBox BypassLimitsChbx;
    }
}
