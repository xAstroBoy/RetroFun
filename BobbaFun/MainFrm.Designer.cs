namespace BobbaFun
{
    partial class MainFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BobbaFunTabs = new Sulakore.Components.SKoreTabControl();
            this.FurnitureTab = new System.Windows.Forms.TabPage();
            this.FurniturePg = new BobbaFun.Pages.FurniturePage();
            this.ChatTab = new System.Windows.Forms.TabPage();
            this.ChatPg = new BobbaFun.Pages.ChatPage();
            this.StalkingTab = new System.Windows.Forms.TabPage();
            this.StalkingPg = new BobbaFun.Pages.StalkingPage();
            this.MakeSayTab = new System.Windows.Forms.TabPage();
            this.makeSayPage1 = new BobbaFun.Pages.MakeSayPage();
            this.DicePage = new System.Windows.Forms.TabPage();
            this.MiscellaneousTab = new System.Windows.Forms.TabPage();
            this.MiscellaneousPg = new BobbaFun.Pages.MiscellaneousPage();
            this.AlwaysOnTopChbx = new System.Windows.Forms.CheckBox();
            this.dicePage1 = new BobbaFun.Pages.DicePage();
            this.BobbaFunTabs.SuspendLayout();
            this.FurnitureTab.SuspendLayout();
            this.ChatTab.SuspendLayout();
            this.StalkingTab.SuspendLayout();
            this.MakeSayTab.SuspendLayout();
            this.DicePage.SuspendLayout();
            this.MiscellaneousTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BobbaFunTabs
            // 
            this.BobbaFunTabs.Controls.Add(this.FurnitureTab);
            this.BobbaFunTabs.Controls.Add(this.ChatTab);
            this.BobbaFunTabs.Controls.Add(this.StalkingTab);
            this.BobbaFunTabs.Controls.Add(this.MakeSayTab);
            this.BobbaFunTabs.Controls.Add(this.DicePage);
            this.BobbaFunTabs.Controls.Add(this.MiscellaneousTab);
            this.BobbaFunTabs.DisplayBoundary = true;
            this.BobbaFunTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.BobbaFunTabs.IsDisplayingBorder = true;
            this.BobbaFunTabs.ItemSize = new System.Drawing.Size(95, 24);
            this.BobbaFunTabs.Location = new System.Drawing.Point(0, 0);
            this.BobbaFunTabs.Name = "BobbaFunTabs";
            this.BobbaFunTabs.SelectedIndex = 0;
            this.BobbaFunTabs.Size = new System.Drawing.Size(479, 301);
            this.BobbaFunTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.BobbaFunTabs.TabIndex = 0;
            // 
            // FurnitureTab
            // 
            this.FurnitureTab.Controls.Add(this.FurniturePg);
            this.FurnitureTab.Location = new System.Drawing.Point(4, 28);
            this.FurnitureTab.Name = "FurnitureTab";
            this.FurnitureTab.Padding = new System.Windows.Forms.Padding(3);
            this.FurnitureTab.Size = new System.Drawing.Size(471, 269);
            this.FurnitureTab.TabIndex = 0;
            this.FurnitureTab.Text = "Furniture";
            this.FurnitureTab.UseVisualStyleBackColor = true;
            // 
            // FurniturePg
            // 
            this.FurniturePg.BackColor = System.Drawing.Color.White;
            this.FurniturePg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FurniturePg.DoubleClickFurnitureRemoval = false;
            this.FurniturePg.FurnitureIdText = null;
            this.FurniturePg.Location = new System.Drawing.Point(3, 3);
            this.FurniturePg.Name = "FurniturePg";
            this.FurniturePg.Size = new System.Drawing.Size(465, 263);
            this.FurniturePg.TabIndex = 0;
            this.FurniturePg.TabStop = false;
            // 
            // ChatTab
            // 
            this.ChatTab.Controls.Add(this.ChatPg);
            this.ChatTab.Location = new System.Drawing.Point(4, 28);
            this.ChatTab.Name = "ChatTab";
            this.ChatTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChatTab.Size = new System.Drawing.Size(471, 269);
            this.ChatTab.TabIndex = 1;
            this.ChatTab.Text = "Chat";
            this.ChatTab.UseVisualStyleBackColor = true;
            // 
            // ChatPg
            // 
            this.ChatPg.AntiBobbaFilter = false;
            this.ChatPg.BackColor = System.Drawing.Color.White;
            this.ChatPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatPg.HideSpeakingBubble = false;
            this.ChatPg.Location = new System.Drawing.Point(3, 3);
            this.ChatPg.Name = "ChatPg";
            this.ChatPg.Size = new System.Drawing.Size(465, 263);
            this.ChatPg.TabIndex = 0;
            this.ChatPg.TabStop = false;
            this.ChatPg.UseSelectedBubble = false;
            // 
            // StalkingTab
            // 
            this.StalkingTab.Controls.Add(this.StalkingPg);
            this.StalkingTab.Location = new System.Drawing.Point(4, 28);
            this.StalkingTab.Name = "StalkingTab";
            this.StalkingTab.Padding = new System.Windows.Forms.Padding(3);
            this.StalkingTab.Size = new System.Drawing.Size(471, 269);
            this.StalkingTab.TabIndex = 2;
            this.StalkingTab.Text = "Stalking";
            this.StalkingTab.UseVisualStyleBackColor = true;
            // 
            // StalkingPg
            // 
            this.StalkingPg.BackColor = System.Drawing.Color.White;
            this.StalkingPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StalkingPg.Location = new System.Drawing.Point(3, 3);
            this.StalkingPg.Name = "StalkingPg";
            this.StalkingPg.Size = new System.Drawing.Size(465, 263);
            this.StalkingPg.TabIndex = 0;
            this.StalkingPg.TabStop = false;
            // 
            // MakeSayTab
            // 
            this.MakeSayTab.Controls.Add(this.makeSayPage1);
            this.MakeSayTab.Location = new System.Drawing.Point(4, 28);
            this.MakeSayTab.Name = "MakeSayTab";
            this.MakeSayTab.Padding = new System.Windows.Forms.Padding(3);
            this.MakeSayTab.Size = new System.Drawing.Size(471, 269);
            this.MakeSayTab.TabIndex = 4;
            this.MakeSayTab.Text = "MakeSay";
            this.MakeSayTab.UseVisualStyleBackColor = true;
            // 
            // makeSayPage1
            // 
            this.makeSayPage1.BackColor = System.Drawing.Color.White;
            this.makeSayPage1.Location = new System.Drawing.Point(0, 0);
            this.makeSayPage1.Name = "makeSayPage1";
            this.makeSayPage1.Size = new System.Drawing.Size(475, 273);
            this.makeSayPage1.TabIndex = 0;
            this.makeSayPage1.TabStop = false;
            // 
            // DicePage
            // 
            this.DicePage.Controls.Add(this.dicePage1);
            this.DicePage.Location = new System.Drawing.Point(4, 28);
            this.DicePage.Name = "DicePage";
            this.DicePage.Size = new System.Drawing.Size(471, 269);
            this.DicePage.TabIndex = 5;
            this.DicePage.Text = "Dice ";
            this.DicePage.UseVisualStyleBackColor = true;
            // 
            // MiscellaneousTab
            // 
            this.MiscellaneousTab.Controls.Add(this.MiscellaneousPg);
            this.MiscellaneousTab.Location = new System.Drawing.Point(4, 28);
            this.MiscellaneousTab.Name = "MiscellaneousTab";
            this.MiscellaneousTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiscellaneousTab.Size = new System.Drawing.Size(471, 269);
            this.MiscellaneousTab.TabIndex = 3;
            this.MiscellaneousTab.Text = "Miscellaneous";
            this.MiscellaneousTab.UseVisualStyleBackColor = true;
            // 
            // MiscellaneousPg
            // 
            this.MiscellaneousPg.BackColor = System.Drawing.Color.White;
            this.MiscellaneousPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiscellaneousPg.FreezeUserMovement = false;
            this.MiscellaneousPg.Location = new System.Drawing.Point(3, 3);
            this.MiscellaneousPg.Name = "MiscellaneousPg";
            this.MiscellaneousPg.Size = new System.Drawing.Size(465, 263);
            this.MiscellaneousPg.TabIndex = 0;
            this.MiscellaneousPg.TabStop = false;
            // 
            // AlwaysOnTopChbx
            // 
            this.AlwaysOnTopChbx.AutoSize = true;
            this.AlwaysOnTopChbx.Location = new System.Drawing.Point(190, 307);
            this.AlwaysOnTopChbx.Name = "AlwaysOnTopChbx";
            this.AlwaysOnTopChbx.Size = new System.Drawing.Size(98, 17);
            this.AlwaysOnTopChbx.TabIndex = 0;
            this.AlwaysOnTopChbx.Text = "Always On Top";
            this.AlwaysOnTopChbx.UseVisualStyleBackColor = true;
            // 
            // dicePage1
            // 
            this.dicePage1.BackColor = System.Drawing.Color.White;
            this.dicePage1.IsRegistrationMode = false;
            this.dicePage1.Location = new System.Drawing.Point(0, 0);
            this.dicePage1.Name = "dicePage1";
            this.dicePage1.Size = new System.Drawing.Size(471, 269);
            this.dicePage1.TabIndex = 0;
            this.dicePage1.TabStop = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 336);
            this.Controls.Add(this.AlwaysOnTopChbx);
            this.Controls.Add(this.BobbaFunTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BobbaFun";
            this.BobbaFunTabs.ResumeLayout(false);
            this.FurnitureTab.ResumeLayout(false);
            this.ChatTab.ResumeLayout(false);
            this.StalkingTab.ResumeLayout(false);
            this.MakeSayTab.ResumeLayout(false);
            this.DicePage.ResumeLayout(false);
            this.MiscellaneousTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreTabControl BobbaFunTabs;
        private System.Windows.Forms.TabPage FurnitureTab;
        private System.Windows.Forms.TabPage ChatTab;
        private System.Windows.Forms.TabPage StalkingTab;
        private System.Windows.Forms.TabPage MiscellaneousTab;
        private System.Windows.Forms.CheckBox AlwaysOnTopChbx;
        private Pages.FurniturePage FurniturePg;
        private Pages.ChatPage ChatPg;
        private Pages.StalkingPage StalkingPg;
        private Pages.MiscellaneousPage MiscellaneousPg;
        private System.Windows.Forms.TabPage MakeSayTab;
        private Pages.MakeSayPage makeSayPage1;
        private System.Windows.Forms.TabPage DicePage;
        private Pages.DicePage dicePage1;
    }
}