namespace RetroFun.Pages
{
    partial class UserEditorPage
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditUserBtn = new Sulakore.Components.SKoreButton();
            this.UserNameTxbx = new System.Windows.Forms.TextBox();
            this.RemoveUserFromRoomBtn = new Sulakore.Components.SKoreButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectUserLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TotUserRegistered = new System.Windows.Forms.Label();
            this.MottoTxbx = new System.Windows.Forms.TextBox();
            this.LookTxbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lockLookChbx = new System.Windows.Forms.CheckBox();
            this.LockMottoBoxChbx = new System.Windows.Forms.CheckBox();
            this.LockNicknameBoxChbx = new System.Windows.Forms.CheckBox();
            this.AddSelectedUserInBlacklistBtn = new Sulakore.Components.SKoreButton();
            this.ClearBlacklistBtn = new Sulakore.Components.SKoreButton();
            this.BlacklistBtn = new Sulakore.Components.SKoreButton();
            this.BlacklistCountLbl = new System.Windows.Forms.Label();
            this.BlackListUserRoomLbl = new System.Windows.Forms.Label();
            this.RestoreBlacklistBtn = new Sulakore.Components.SKoreButton();
            this.AddAllUsersOnBlacklistBtn = new Sulakore.Components.SKoreButton();
            this.FakeRespectUserBtn = new Sulakore.Components.SKoreButton();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.Location = new System.Drawing.Point(466, 223);
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.Size = new System.Drawing.Size(176, 28);
            this.EditUserBtn.TabIndex = 25;
            this.EditUserBtn.Text = "Edit Selected User";
            this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // UserNameTxbx
            // 
            this.UserNameTxbx.Location = new System.Drawing.Point(466, 55);
            this.UserNameTxbx.MaxLength = 2147483647;
            this.UserNameTxbx.Name = "UserNameTxbx";
            this.UserNameTxbx.Size = new System.Drawing.Size(234, 26);
            this.UserNameTxbx.TabIndex = 24;
            // 
            // RemoveUserFromRoomBtn
            // 
            this.RemoveUserFromRoomBtn.Location = new System.Drawing.Point(22, 232);
            this.RemoveUserFromRoomBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveUserFromRoomBtn.Name = "RemoveUserFromRoomBtn";
            this.RemoveUserFromRoomBtn.Size = new System.Drawing.Size(236, 31);
            this.RemoveUserFromRoomBtn.TabIndex = 21;
            this.RemoveUserFromRoomBtn.Text = "Remove User From Room (CS)";
            this.RemoveUserFromRoomBtn.Click += new System.EventHandler(this.RemoveUserFromRoomBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectUserLabel);
            this.groupBox1.Location = new System.Drawing.Point(22, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(368, 92);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected User";
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
            this.SelectUserLabel.Location = new System.Drawing.Point(44, 38);
            this.SelectUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectUserLabel.Name = "SelectUserLabel";
            this.SelectUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectUserLabel.Size = new System.Drawing.Size(29, 36);
            this.SelectUserLabel.TabIndex = 0;
            this.SelectUserLabel.Text = "?";
            this.SelectUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TotUserRegistered);
            this.groupBox4.Location = new System.Drawing.Point(22, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(153, 105);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logged Users.";
            // 
            // TotUserRegistered
            // 
            this.TotUserRegistered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotUserRegistered.AutoSize = true;
            this.TotUserRegistered.BackColor = System.Drawing.Color.Transparent;
            this.TotUserRegistered.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotUserRegistered.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TotUserRegistered.Location = new System.Drawing.Point(58, 38);
            this.TotUserRegistered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotUserRegistered.Name = "TotUserRegistered";
            this.TotUserRegistered.Size = new System.Drawing.Size(29, 36);
            this.TotUserRegistered.TabIndex = 0;
            this.TotUserRegistered.Text = "?";
            this.TotUserRegistered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MottoTxbx
            // 
            this.MottoTxbx.Location = new System.Drawing.Point(466, 126);
            this.MottoTxbx.MaxLength = 2147483647;
            this.MottoTxbx.Name = "MottoTxbx";
            this.MottoTxbx.Size = new System.Drawing.Size(234, 26);
            this.MottoTxbx.TabIndex = 26;
            // 
            // LookTxbx
            // 
            this.LookTxbx.Location = new System.Drawing.Point(466, 191);
            this.LookTxbx.MaxLength = 2147483647;
            this.LookTxbx.Name = "LookTxbx";
            this.LookTxbx.Size = new System.Drawing.Size(234, 26);
            this.LookTxbx.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nickname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Motto";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(462, 168);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 20);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Look";
            // 
            // lockLookChbx
            // 
            this.lockLookChbx.AutoSize = true;
            this.lockLookChbx.Location = new System.Drawing.Point(706, 202);
            this.lockLookChbx.Name = "lockLookChbx";
            this.lockLookChbx.Size = new System.Drawing.Size(22, 21);
            this.lockLookChbx.TabIndex = 31;
            this.lockLookChbx.UseVisualStyleBackColor = true;
            this.lockLookChbx.CheckedChanged += new System.EventHandler(this.lockLookChbx_CheckedChanged);
            // 
            // LockMottoBoxChbx
            // 
            this.LockMottoBoxChbx.AutoSize = true;
            this.LockMottoBoxChbx.Location = new System.Drawing.Point(706, 129);
            this.LockMottoBoxChbx.Name = "LockMottoBoxChbx";
            this.LockMottoBoxChbx.Size = new System.Drawing.Size(22, 21);
            this.LockMottoBoxChbx.TabIndex = 32;
            this.LockMottoBoxChbx.UseVisualStyleBackColor = true;
            this.LockMottoBoxChbx.CheckedChanged += new System.EventHandler(this.LockMottoBoxChbx_CheckedChanged);
            // 
            // LockNicknameBoxChbx
            // 
            this.LockNicknameBoxChbx.AutoSize = true;
            this.LockNicknameBoxChbx.Location = new System.Drawing.Point(706, 63);
            this.LockNicknameBoxChbx.Name = "LockNicknameBoxChbx";
            this.LockNicknameBoxChbx.Size = new System.Drawing.Size(22, 21);
            this.LockNicknameBoxChbx.TabIndex = 33;
            this.LockNicknameBoxChbx.UseVisualStyleBackColor = true;
            this.LockNicknameBoxChbx.CheckedChanged += new System.EventHandler(this.LockNicknameBoxChbx_CheckedChanged);
            // 
            // AddSelectedUserInBlacklistBtn
            // 
            this.AddSelectedUserInBlacklistBtn.Location = new System.Drawing.Point(784, 118);
            this.AddSelectedUserInBlacklistBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddSelectedUserInBlacklistBtn.Name = "AddSelectedUserInBlacklistBtn";
            this.AddSelectedUserInBlacklistBtn.Size = new System.Drawing.Size(236, 31);
            this.AddSelectedUserInBlacklistBtn.TabIndex = 34;
            this.AddSelectedUserInBlacklistBtn.Text = "Add Selected User in blacklist";
            this.AddSelectedUserInBlacklistBtn.Click += new System.EventHandler(this.AddSelectedUserInBlacklistBtn_Click);
            // 
            // ClearBlacklistBtn
            // 
            this.ClearBlacklistBtn.Location = new System.Drawing.Point(784, 32);
            this.ClearBlacklistBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearBlacklistBtn.Name = "ClearBlacklistBtn";
            this.ClearBlacklistBtn.Size = new System.Drawing.Size(236, 29);
            this.ClearBlacklistBtn.TabIndex = 35;
            this.ClearBlacklistBtn.Text = "Clear Blacklisted User List";
            this.ClearBlacklistBtn.Click += new System.EventHandler(this.ClearBlacklistBtn_Click);
            // 
            // BlacklistBtn
            // 
            this.BlacklistBtn.Location = new System.Drawing.Point(784, 234);
            this.BlacklistBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlacklistBtn.Name = "BlacklistBtn";
            this.BlacklistBtn.Size = new System.Drawing.Size(236, 29);
            this.BlacklistBtn.TabIndex = 36;
            this.BlacklistBtn.Text = "Blacklist : OFF";
            this.BlacklistBtn.Click += new System.EventHandler(this.BlacklistBtn_Click);
            // 
            // BlacklistCountLbl
            // 
            this.BlacklistCountLbl.AutoSize = true;
            this.BlacklistCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlacklistCountLbl.Location = new System.Drawing.Point(15, 294);
            this.BlacklistCountLbl.Name = "BlacklistCountLbl";
            this.BlacklistCountLbl.Size = new System.Drawing.Size(285, 36);
            this.BlacklistCountLbl.TabIndex = 1;
            this.BlacklistCountLbl.Text = "Blacklisted Users : 0";
            // 
            // BlackListUserRoomLbl
            // 
            this.BlackListUserRoomLbl.AutoSize = true;
            this.BlackListUserRoomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackListUserRoomLbl.Location = new System.Drawing.Point(15, 355);
            this.BlackListUserRoomLbl.Name = "BlackListUserRoomLbl";
            this.BlackListUserRoomLbl.Size = new System.Drawing.Size(392, 36);
            this.BlackListUserRoomLbl.TabIndex = 37;
            this.BlackListUserRoomLbl.Text = "Blacklisted Users in room : 0";
            // 
            // RestoreBlacklistBtn
            // 
            this.RestoreBlacklistBtn.Location = new System.Drawing.Point(784, 158);
            this.RestoreBlacklistBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RestoreBlacklistBtn.Name = "RestoreBlacklistBtn";
            this.RestoreBlacklistBtn.Size = new System.Drawing.Size(236, 29);
            this.RestoreBlacklistBtn.TabIndex = 38;
            this.RestoreBlacklistBtn.Text = "Remove Blacklisted User";
            this.RestoreBlacklistBtn.Click += new System.EventHandler(this.RestoreBlacklistBtn_Click);
            // 
            // AddAllUsersOnBlacklistBtn
            // 
            this.AddAllUsersOnBlacklistBtn.Location = new System.Drawing.Point(782, 397);
            this.AddAllUsersOnBlacklistBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddAllUsersOnBlacklistBtn.Name = "AddAllUsersOnBlacklistBtn";
            this.AddAllUsersOnBlacklistBtn.Size = new System.Drawing.Size(262, 46);
            this.AddAllUsersOnBlacklistBtn.TabIndex = 39;
            this.AddAllUsersOnBlacklistBtn.Text = "Add All Users in blacklist : OFF";
            this.AddAllUsersOnBlacklistBtn.Click += new System.EventHandler(this.AddAllUsersOnBlacklistBtn_Click);
            // 
            // FakeRespectUserBtn
            // 
            this.FakeRespectUserBtn.Enabled = false;
            this.FakeRespectUserBtn.Location = new System.Drawing.Point(21, 444);
            this.FakeRespectUserBtn.Name = "FakeRespectUserBtn";
            this.FakeRespectUserBtn.Size = new System.Drawing.Size(214, 37);
            this.FakeRespectUserBtn.TabIndex = 45;
            this.FakeRespectUserBtn.Text = "Fake Respect This User!";
            this.FakeRespectUserBtn.Visible = false;
            this.FakeRespectUserBtn.Click += new System.EventHandler(this.FakeRespectUserBtn_Click);
            // 
            // UserEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FakeRespectUserBtn);
            this.Controls.Add(this.AddAllUsersOnBlacklistBtn);
            this.Controls.Add(this.RestoreBlacklistBtn);
            this.Controls.Add(this.BlackListUserRoomLbl);
            this.Controls.Add(this.BlacklistCountLbl);
            this.Controls.Add(this.BlacklistBtn);
            this.Controls.Add(this.ClearBlacklistBtn);
            this.Controls.Add(this.AddSelectedUserInBlacklistBtn);
            this.Controls.Add(this.LockNicknameBoxChbx);
            this.Controls.Add(this.LockMottoBoxChbx);
            this.Controls.Add(this.lockLookChbx);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LookTxbx);
            this.Controls.Add(this.MottoTxbx);
            this.Controls.Add(this.EditUserBtn);
            this.Controls.Add(this.UserNameTxbx);
            this.Controls.Add(this.RemoveUserFromRoomBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "UserEditorPage";
            this.Size = new System.Drawing.Size(1048, 517);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion
        private Sulakore.Components.SKoreButton EditUserBtn;
        private System.Windows.Forms.TextBox UserNameTxbx;
        private Sulakore.Components.SKoreButton RemoveUserFromRoomBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SelectUserLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label TotUserRegistered;
        private System.Windows.Forms.TextBox MottoTxbx;
        private System.Windows.Forms.TextBox LookTxbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.CheckBox lockLookChbx;
        private System.Windows.Forms.CheckBox LockMottoBoxChbx;
        private System.Windows.Forms.CheckBox LockNicknameBoxChbx;
        private Sulakore.Components.SKoreButton AddSelectedUserInBlacklistBtn;
        private Sulakore.Components.SKoreButton ClearBlacklistBtn;
        private Sulakore.Components.SKoreButton BlacklistBtn;
        private System.Windows.Forms.Label BlacklistCountLbl;
        private System.Windows.Forms.Label BlackListUserRoomLbl;
        private Sulakore.Components.SKoreButton RestoreBlacklistBtn;
        private Sulakore.Components.SKoreButton AddAllUsersOnBlacklistBtn;
        private Sulakore.Components.SKoreButton FakeRespectUserBtn;
    }
}
