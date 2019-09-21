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
            this.NoFriendRemove = new System.Windows.Forms.CheckBox();
            this.FreezeMovementCheck = new System.Windows.Forms.CheckBox();
            this.AcquireMODPermissionsBtn = new Sulakore.Components.SKoreButton();
            this.SuspendLayout();
            // 
            // NoFriendRemove
            // 
            this.NoFriendRemove.AutoSize = true;
            this.NoFriendRemove.Checked = true;
            this.NoFriendRemove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NoFriendRemove.Location = new System.Drawing.Point(276, 88);
            this.NoFriendRemove.Name = "NoFriendRemove";
            this.NoFriendRemove.Size = new System.Drawing.Size(167, 17);
            this.NoFriendRemove.TabIndex = 5;
            this.NoFriendRemove.Text = "Block Friend Removal Packet";
            this.NoFriendRemove.UseVisualStyleBackColor = true;
            // 
            // FreezeMovementCheck
            // 
            this.FreezeMovementCheck.AutoSize = true;
            this.FreezeMovementCheck.Location = new System.Drawing.Point(276, 46);
            this.FreezeMovementCheck.Name = "FreezeMovementCheck";
            this.FreezeMovementCheck.Size = new System.Drawing.Size(111, 17);
            this.FreezeMovementCheck.TabIndex = 4;
            this.FreezeMovementCheck.Text = "Freeze Movement";
            this.FreezeMovementCheck.UseVisualStyleBackColor = true;
            // 
            // AcquireMODPermissionsBtn
            // 
            this.AcquireMODPermissionsBtn.Location = new System.Drawing.Point(45, 46);
            this.AcquireMODPermissionsBtn.Name = "AcquireMODPermissionsBtn";
            this.AcquireMODPermissionsBtn.Size = new System.Drawing.Size(185, 20);
            this.AcquireMODPermissionsBtn.TabIndex = 3;
            this.AcquireMODPermissionsBtn.Text = "Acquire MOD Permissions (CS)";
            this.AcquireMODPermissionsBtn.Click += new System.EventHandler(this.AcquireMODPermissionsBtn_Click_1);
            // 
            // MiscellaneousPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoFriendRemove);
            this.Controls.Add(this.FreezeMovementCheck);
            this.Controls.Add(this.AcquireMODPermissionsBtn);
            this.Name = "MiscellaneousPage";
            this.Size = new System.Drawing.Size(482, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.CheckBox NoFriendRemove;
        private System.Windows.Forms.CheckBox FreezeMovementCheck;
        private Sulakore.Components.SKoreButton AcquireMODPermissionsBtn;
    }
}
