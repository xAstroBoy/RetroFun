namespace RetroFun.Pages
{
    partial class FakeMessagePage
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
            this.SendMessageBtn = new Sulakore.Components.SKoreButton();
            this.StringMessageTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectUserLabel = new System.Windows.Forms.Label();
            this.CSFriendAddBtn = new Sulakore.Components.SKoreButton();
            this.NoClientMessageBlockerChbx = new System.Windows.Forms.CheckBox();
            this.RemoveFriendBtn = new Sulakore.Components.SKoreButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Location = new System.Drawing.Point(173, 228);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(100, 20);
            this.SendMessageBtn.TabIndex = 0;
            this.SendMessageBtn.Text = "Send CS message";
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // StringMessageTbx
            // 
            this.StringMessageTbx.Location = new System.Drawing.Point(25, 202);
            this.StringMessageTbx.MaxLength = 2147483647;
            this.StringMessageTbx.Name = "StringMessageTbx";
            this.StringMessageTbx.Size = new System.Drawing.Size(376, 20);
            this.StringMessageTbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message to receive in Client.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectUserLabel);
            this.groupBox2.Location = new System.Drawing.Point(25, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 83);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected User";
            // 
            // SelectUserLabel
            // 
            this.SelectUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectUserLabel.AutoSize = true;
            this.SelectUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectUserLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectUserLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SelectUserLabel.Location = new System.Drawing.Point(29, 35);
            this.SelectUserLabel.Name = "SelectUserLabel";
            this.SelectUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectUserLabel.Size = new System.Drawing.Size(20, 23);
            this.SelectUserLabel.TabIndex = 0;
            this.SelectUserLabel.Text = "?";
            this.SelectUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CSFriendAddBtn
            // 
            this.CSFriendAddBtn.Location = new System.Drawing.Point(24, 119);
            this.CSFriendAddBtn.Name = "CSFriendAddBtn";
            this.CSFriendAddBtn.Size = new System.Drawing.Size(141, 20);
            this.CSFriendAddBtn.TabIndex = 8;
            this.CSFriendAddBtn.Text = "Add User as Friend CS";
            this.CSFriendAddBtn.Click += new System.EventHandler(this.CSFriendAddBtn_Click);
            // 
            // NoClientMessageBlockerChbx
            // 
            this.NoClientMessageBlockerChbx.AutoSize = true;
            this.NoClientMessageBlockerChbx.Location = new System.Drawing.Point(231, 148);
            this.NoClientMessageBlockerChbx.Name = "NoClientMessageBlockerChbx";
            this.NoClientMessageBlockerChbx.Size = new System.Drawing.Size(199, 17);
            this.NoClientMessageBlockerChbx.TabIndex = 9;
            this.NoClientMessageBlockerChbx.Text = "Block Offline / Unfriended messages";
            this.NoClientMessageBlockerChbx.UseVisualStyleBackColor = true;
            // 
            // sKoreButton1
            // 
            this.RemoveFriendBtn.Location = new System.Drawing.Point(25, 145);
            this.RemoveFriendBtn.Name = "RemoveFriendBtn";
            this.RemoveFriendBtn.Size = new System.Drawing.Size(141, 20);
            this.RemoveFriendBtn.TabIndex = 10;
            this.RemoveFriendBtn.Text = "Remove User as Friend CS";
            this.RemoveFriendBtn.Click += new System.EventHandler(this.RemoveFriendBtn_Click);
            // 
            // FakeMessagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveFriendBtn);
            this.Controls.Add(this.NoClientMessageBlockerChbx);
            this.Controls.Add(this.CSFriendAddBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StringMessageTbx);
            this.Controls.Add(this.SendMessageBtn);
            this.Name = "FakeMessagePage";
            this.Size = new System.Drawing.Size(469, 272);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreButton SendMessageBtn;
        private System.Windows.Forms.TextBox StringMessageTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SelectUserLabel;
        private Sulakore.Components.SKoreButton CSFriendAddBtn;
        private System.Windows.Forms.CheckBox NoClientMessageBlockerChbx;
        private Sulakore.Components.SKoreButton RemoveFriendBtn;
    }
}
