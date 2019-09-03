namespace BobbaFun.Pages
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AcquireMODPermissionsBtn = new Sulakore.Components.SKoreButton();
            this.FreezeMovementCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AcquireMODPermissionsBtn
            // 
            this.AcquireMODPermissionsBtn.Location = new System.Drawing.Point(39, 55);
            this.AcquireMODPermissionsBtn.Name = "AcquireMODPermissionsBtn";
            this.AcquireMODPermissionsBtn.Size = new System.Drawing.Size(185, 20);
            this.AcquireMODPermissionsBtn.TabIndex = 0;
            this.AcquireMODPermissionsBtn.Text = "Acquire MOD Permissions (CS)";
            this.AcquireMODPermissionsBtn.Click += new System.EventHandler(this.AcquireMODPermissionsBtn_Click);
            // 
            // FreezeMovementCheck
            // 
            this.FreezeMovementCheck.AutoSize = true;
            this.FreezeMovementCheck.Location = new System.Drawing.Point(270, 55);
            this.FreezeMovementCheck.Name = "FreezeMovementCheck";
            this.FreezeMovementCheck.Size = new System.Drawing.Size(111, 17);
            this.FreezeMovementCheck.TabIndex = 1;
            this.FreezeMovementCheck.Text = "Freeze Movement";
            this.FreezeMovementCheck.UseVisualStyleBackColor = true;
            // 
            // MiscellaneousPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FreezeMovementCheck);
            this.Controls.Add(this.AcquireMODPermissionsBtn);
            this.Name = "MiscellaneousPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreButton AcquireMODPermissionsBtn;
        private System.Windows.Forms.CheckBox FreezeMovementCheck;
    }
}
