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
            this.AcquireMODPermissionsBtn = new Sulakore.Components.SKoreButton();
            this.NoRemoveFriendOnReport = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AcquireMODPermissionsBtn
            // 
            this.AcquireMODPermissionsBtn.Location = new System.Drawing.Point(65, 189);
            this.AcquireMODPermissionsBtn.Name = "AcquireMODPermissionsBtn";
            this.AcquireMODPermissionsBtn.Size = new System.Drawing.Size(185, 20);
            this.AcquireMODPermissionsBtn.TabIndex = 3;
            this.AcquireMODPermissionsBtn.Text = "Acquire MOD Permissions (CS)";
            this.AcquireMODPermissionsBtn.Click += new System.EventHandler(this.AcquireMODPermissionsBtn_Click_1);
            // 
            // NoRemoveFriendOnReport
            // 
            this.NoRemoveFriendOnReport.AutoSize = true;
            this.NoRemoveFriendOnReport.Checked = true;
            this.NoRemoveFriendOnReport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NoRemoveFriendOnReport.Location = new System.Drawing.Point(65, 80);
            this.NoRemoveFriendOnReport.Name = "NoRemoveFriendOnReport";
            this.NoRemoveFriendOnReport.Size = new System.Drawing.Size(195, 17);
            this.NoRemoveFriendOnReport.TabIndex = 4;
            this.NoRemoveFriendOnReport.Text = "Anti-Friend Removal when reported.";
            this.NoRemoveFriendOnReport.UseVisualStyleBackColor = true;
            // 
            // MiscellaneousPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NoRemoveFriendOnReport);
            this.Controls.Add(this.AcquireMODPermissionsBtn);
            this.Name = "MiscellaneousPage";
            this.Size = new System.Drawing.Size(322, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Sulakore.Components.SKoreButton AcquireMODPermissionsBtn;
        private System.Windows.Forms.CheckBox NoRemoveFriendOnReport;
    }
}
