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
            this.UserIdNbx = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CaptUserIDChbx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserIdNbx)).BeginInit();
            this.SuspendLayout();
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Location = new System.Drawing.Point(164, 235);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(100, 20);
            this.SendMessageBtn.TabIndex = 0;
            this.SendMessageBtn.Text = "Send CS message";
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // StringMessageTbx
            // 
            this.StringMessageTbx.Location = new System.Drawing.Point(30, 195);
            this.StringMessageTbx.MaxLength = 2147483647;
            this.StringMessageTbx.Name = "StringMessageTbx";
            this.StringMessageTbx.Size = new System.Drawing.Size(376, 20);
            this.StringMessageTbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message to receive in Client.";
            // 
            // UserIdNbx
            // 
            this.UserIdNbx.Location = new System.Drawing.Point(30, 47);
            this.UserIdNbx.Maximum = new decimal(new int[] {
            int.MaxValue,
            0,
            0,
            0});
            this.UserIdNbx.Name = "UserIdNbx";
            this.UserIdNbx.Size = new System.Drawing.Size(159, 20);
            this.UserIdNbx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserID ";
            // 
            // CaptUserIDChbx
            // 
            this.CaptUserIDChbx.AutoSize = true;
            this.CaptUserIDChbx.Location = new System.Drawing.Point(30, 89);
            this.CaptUserIDChbx.Name = "CaptUserIDChbx";
            this.CaptUserIDChbx.Size = new System.Drawing.Size(99, 17);
            this.CaptUserIDChbx.TabIndex = 5;
            this.CaptUserIDChbx.Text = "Capture UserID";
            this.CaptUserIDChbx.UseVisualStyleBackColor = true;
            // 
            // FakeMessagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CaptUserIDChbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserIdNbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StringMessageTbx);
            this.Controls.Add(this.SendMessageBtn);
            this.Name = "FakeMessagePage";
            this.Size = new System.Drawing.Size(432, 272);
            ((System.ComponentModel.ISupportInitialize)(this.UserIdNbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreButton SendMessageBtn;
        private System.Windows.Forms.TextBox StringMessageTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UserIdNbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CaptUserIDChbx;
    }
}
