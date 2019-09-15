namespace RetroFun
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
            this.RetroFunTabs = new Sulakore.Components.SKoreTabControl();
            this.FurnitureTab = new System.Windows.Forms.TabPage();
            this.furniturePage1 = new RetroFun.Pages.FurniturePage();
            this.ChatTab = new System.Windows.Forms.TabPage();
            this.chatPage1 = new RetroFun.Pages.ChatPage();
            this.StalkingTab = new System.Windows.Forms.TabPage();
            this.stalkingPage1 = new RetroFun.Pages.StalkingPage();
            this.MakeSayTab = new System.Windows.Forms.TabPage();
            this.makeSayPage1 = new RetroFun.Pages.MakeSayPage();
            this.DiceTab = new System.Windows.Forms.TabPage();
            this.dicePage1 = new RetroFun.Pages.DicePage();
            this.HoloTab = new System.Windows.Forms.TabPage();
            this.autoHoloDicePage1 = new RetroFun.Pages.AutoHoloDicePage();
            this.MottoTab = new System.Windows.Forms.TabPage();
            this.MiscellaneousTab = new System.Windows.Forms.TabPage();
            this.miscPage = new RetroFun.Pages.MiscPage();
            this.AlwaysOnTopChbx = new System.Windows.Forms.CheckBox();
            this.customMotto1 = new RetroFun.Pages.CustomMotto();
            this.RetroFunTabs.SuspendLayout();
            this.FurnitureTab.SuspendLayout();
            this.ChatTab.SuspendLayout();
            this.StalkingTab.SuspendLayout();
            this.MakeSayTab.SuspendLayout();
            this.DiceTab.SuspendLayout();
            this.HoloTab.SuspendLayout();
            this.MottoTab.SuspendLayout();
            this.MiscellaneousTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // RetroFunTabs
            // 
            this.RetroFunTabs.Controls.Add(this.FurnitureTab);
            this.RetroFunTabs.Controls.Add(this.ChatTab);
            this.RetroFunTabs.Controls.Add(this.StalkingTab);
            this.RetroFunTabs.Controls.Add(this.MakeSayTab);
            this.RetroFunTabs.Controls.Add(this.DiceTab);
            this.RetroFunTabs.Controls.Add(this.HoloTab);
            this.RetroFunTabs.Controls.Add(this.MottoTab);
            this.RetroFunTabs.Controls.Add(this.MiscellaneousTab);
            this.RetroFunTabs.DisplayBoundary = true;
            this.RetroFunTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.RetroFunTabs.IsDisplayingBorder = true;
            this.RetroFunTabs.ItemSize = new System.Drawing.Size(95, 24);
            this.RetroFunTabs.Location = new System.Drawing.Point(0, 0);
            this.RetroFunTabs.Name = "RetroFunTabs";
            this.RetroFunTabs.SelectedIndex = 0;
            this.RetroFunTabs.Size = new System.Drawing.Size(479, 301);
            this.RetroFunTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.RetroFunTabs.TabIndex = 0;
            // 
            // FurnitureTab
            // 
            this.FurnitureTab.Controls.Add(this.furniturePage1);
            this.FurnitureTab.Location = new System.Drawing.Point(4, 28);
            this.FurnitureTab.Name = "FurnitureTab";
            this.FurnitureTab.Padding = new System.Windows.Forms.Padding(3);
            this.FurnitureTab.Size = new System.Drawing.Size(471, 269);
            this.FurnitureTab.TabIndex = 0;
            this.FurnitureTab.Text = "Furniture";
            this.FurnitureTab.UseVisualStyleBackColor = true;
            // 
            // furniturePage1
            // 
            this.furniturePage1.BackColor = System.Drawing.Color.White;
            this.furniturePage1.ButtonRotateMoveItem = false;
            this.furniturePage1.DoubleClickFurnitureRemoval = false;
            this.furniturePage1.FurnitureIdText = null;
            this.furniturePage1.Location = new System.Drawing.Point(0, 0);
            this.furniturePage1.Name = "furniturePage1";
            this.furniturePage1.Size = new System.Drawing.Size(471, 269);
            this.furniturePage1.TabIndex = 0;
            this.furniturePage1.TabStop = false;
            // 
            // ChatTab
            // 
            this.ChatTab.Controls.Add(this.chatPage1);
            this.ChatTab.Location = new System.Drawing.Point(4, 28);
            this.ChatTab.Name = "ChatTab";
            this.ChatTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChatTab.Size = new System.Drawing.Size(471, 269);
            this.ChatTab.TabIndex = 1;
            this.ChatTab.Text = "Chat";
            this.ChatTab.UseVisualStyleBackColor = true;
            // 
            // chatPage1
            // 
            this.chatPage1.AntiBobbaFilter = false;
            this.chatPage1.BackColor = System.Drawing.Color.White;
            this.chatPage1.HideSpeakingBubble = false;
            this.chatPage1.Location = new System.Drawing.Point(0, 0);
            this.chatPage1.Name = "chatPage1";
            this.chatPage1.Size = new System.Drawing.Size(465, 263);
            this.chatPage1.TabIndex = 0;
            this.chatPage1.TabStop = false;
            this.chatPage1.UseSelectedBubble = false;
            // 
            // StalkingTab
            // 
            this.StalkingTab.Controls.Add(this.stalkingPage1);
            this.StalkingTab.Location = new System.Drawing.Point(4, 28);
            this.StalkingTab.Name = "StalkingTab";
            this.StalkingTab.Padding = new System.Windows.Forms.Padding(3);
            this.StalkingTab.Size = new System.Drawing.Size(471, 269);
            this.StalkingTab.TabIndex = 2;
            this.StalkingTab.Text = "Stalking";
            this.StalkingTab.UseVisualStyleBackColor = true;
            // 
            // stalkingPage1
            // 
            this.stalkingPage1.BackColor = System.Drawing.Color.White;
            this.stalkingPage1.Location = new System.Drawing.Point(3, 0);
            this.stalkingPage1.Name = "stalkingPage1";
            this.stalkingPage1.Size = new System.Drawing.Size(465, 263);
            this.stalkingPage1.TabIndex = 0;
            this.stalkingPage1.TabStop = false;
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
            this.makeSayPage1.Location = new System.Drawing.Point(3, 0);
            this.makeSayPage1.Name = "makeSayPage1";
            this.makeSayPage1.Size = new System.Drawing.Size(465, 263);
            this.makeSayPage1.TabIndex = 0;
            this.makeSayPage1.TabStop = false;
            // 
            // DiceTab
            // 
            this.DiceTab.Controls.Add(this.dicePage1);
            this.DiceTab.Location = new System.Drawing.Point(4, 28);
            this.DiceTab.Name = "DiceTab";
            this.DiceTab.Size = new System.Drawing.Size(471, 269);
            this.DiceTab.TabIndex = 5;
            this.DiceTab.Text = "Dice ";
            this.DiceTab.UseVisualStyleBackColor = true;
            // 
            // dicePage1
            // 
            this.dicePage1.BackColor = System.Drawing.Color.White;
            this.dicePage1.IsRegistrationMode = false;
            this.dicePage1.IsUserFreezed = false;
            this.dicePage1.Location = new System.Drawing.Point(3, 0);
            this.dicePage1.Name = "dicePage1";
            this.dicePage1.Size = new System.Drawing.Size(465, 263);
            this.dicePage1.TabIndex = 0;
            this.dicePage1.TabStop = false;
            // 
            // HoloTab
            // 
            this.HoloTab.Controls.Add(this.autoHoloDicePage1);
            this.HoloTab.Location = new System.Drawing.Point(4, 28);
            this.HoloTab.Name = "HoloTab";
            this.HoloTab.Padding = new System.Windows.Forms.Padding(3);
            this.HoloTab.Size = new System.Drawing.Size(471, 269);
            this.HoloTab.TabIndex = 6;
            this.HoloTab.Text = "AutomaticHolo";
            this.HoloTab.UseVisualStyleBackColor = true;
            // 
            // autoHoloDicePage1
            // 
            this.autoHoloDicePage1.BackColor = System.Drawing.Color.White;
            this.autoHoloDicePage1.DiceHostResult = 0;
            this.autoHoloDicePage1.DiceOneResult = 0;
            this.autoHoloDicePage1.DiceThreeResult = 0;
            this.autoHoloDicePage1.DiceTwoResult = 0;
            this.autoHoloDicePage1.ISHolodiceCheat = false;
            this.autoHoloDicePage1.IsUserFreezed = false;
            this.autoHoloDicePage1.Location = new System.Drawing.Point(3, 0);
            this.autoHoloDicePage1.Name = "autoHoloDicePage1";
            this.autoHoloDicePage1.Size = new System.Drawing.Size(465, 263);
            this.autoHoloDicePage1.TabIndex = 0;
            this.autoHoloDicePage1.TabStop = false;
            // 
            // MottoTab
            // 
            this.MottoTab.Controls.Add(this.customMotto1);
            this.MottoTab.Location = new System.Drawing.Point(4, 28);
            this.MottoTab.Name = "MottoTab";
            this.MottoTab.Padding = new System.Windows.Forms.Padding(3);
            this.MottoTab.Size = new System.Drawing.Size(471, 269);
            this.MottoTab.TabIndex = 7;
            this.MottoTab.Text = "Motto";
            this.MottoTab.UseVisualStyleBackColor = true;
            // 
            // MiscellaneousTab
            // 
            this.MiscellaneousTab.Controls.Add(this.miscPage);
            this.MiscellaneousTab.Location = new System.Drawing.Point(4, 28);
            this.MiscellaneousTab.Name = "MiscellaneousTab";
            this.MiscellaneousTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiscellaneousTab.Size = new System.Drawing.Size(471, 269);
            this.MiscellaneousTab.TabIndex = 3;
            this.MiscellaneousTab.Text = "Miscellaneous";
            this.MiscellaneousTab.UseVisualStyleBackColor = true;
            // 
            // miscPage
            // 
            this.miscPage.AntiFriendRemove = true;
            this.miscPage.BackColor = System.Drawing.Color.White;
            this.miscPage.FreezeUserMovement = false;
            this.miscPage.Location = new System.Drawing.Point(0, 0);
            this.miscPage.Name = "miscPage";
            this.miscPage.Size = new System.Drawing.Size(471, 269);
            this.miscPage.TabIndex = 0;
            this.miscPage.TabStop = false;
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
            // customMotto1
            // 
            this.customMotto1.animatedMottoChecked = false;
            this.customMotto1.BackColor = System.Drawing.Color.White;
            this.customMotto1.Location = new System.Drawing.Point(3, 0);
            this.customMotto1.Name = "customMotto1";
            this.customMotto1.ShowPreview = false;
            this.customMotto1.Size = new System.Drawing.Size(468, 265);
            this.customMotto1.TabIndex = 0;
            this.customMotto1.TabStop = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 336);
            this.Controls.Add(this.AlwaysOnTopChbx);
            this.Controls.Add(this.RetroFunTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetroFun";
            this.RetroFunTabs.ResumeLayout(false);
            this.FurnitureTab.ResumeLayout(false);
            this.ChatTab.ResumeLayout(false);
            this.StalkingTab.ResumeLayout(false);
            this.MakeSayTab.ResumeLayout(false);
            this.DiceTab.ResumeLayout(false);
            this.HoloTab.ResumeLayout(false);
            this.MottoTab.ResumeLayout(false);
            this.MiscellaneousTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Sulakore.Components.SKoreTabControl RetroFunTabs;
        private System.Windows.Forms.TabPage FurnitureTab;
        private System.Windows.Forms.TabPage ChatTab;
        private System.Windows.Forms.TabPage StalkingTab;
        private System.Windows.Forms.TabPage MiscellaneousTab;
        private System.Windows.Forms.CheckBox AlwaysOnTopChbx;
        private Pages.FurniturePage FurniturePg;
        private Pages.ChatPage ChatPg;
        private Pages.StalkingPage StalkingPg;
        private System.Windows.Forms.TabPage MakeSayTab;
        private Pages.MiscPage miscPg;
        private Pages.MakeSayPage MakeSayPg;
        private System.Windows.Forms.TabPage DiceTab;
        private Pages.DicePage DicePg;
        private System.Windows.Forms.TabPage HoloTab;
        private Pages.AutoHoloDicePage AutoHoloDicePg;
        private System.Windows.Forms.TabPage MottoTab;
        private Pages.FurniturePage furniturePage1;
        private Pages.ChatPage chatPage1;
        private Pages.StalkingPage stalkingPage1;
        private Pages.MakeSayPage makeSayPage1;
        private Pages.DicePage dicePage1;
        private Pages.AutoHoloDicePage autoHoloDicePage1;
        private Pages.MiscPage miscPage;
        private Pages.CustomMotto customMotto1;
    }
}