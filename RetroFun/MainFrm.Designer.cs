using RetroFun.Pages;

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
            this.DicePage = new System.Windows.Forms.TabPage();
            this.dicePage1 = new RetroFun.Pages.DicePage();
            this.HoloTab = new System.Windows.Forms.TabPage();
            this.autoHoloDicePage1 = new RetroFun.Pages.AutoHoloDicePage();
            this.CatalogBuyEditor = new System.Windows.Forms.TabPage();
            this.GiftPageTab = new System.Windows.Forms.TabPage();
            this.giftEditor1 = new RetroFun.Pages.GiftEditor();
            this.MiscellaneousTab = new System.Windows.Forms.TabPage();
            this.miscellaneousPage2 = new RetroFun.Pages.MiscellaneousPage();
            this.AlwaysOnTopChbx = new System.Windows.Forms.CheckBox();
            this.buyFurniBruteforcer1 = new RetroFun.Pages.BuyFurniBruteforcer();
            this.RetroFunTabs.SuspendLayout();
            this.FurnitureTab.SuspendLayout();
            this.ChatTab.SuspendLayout();
            this.StalkingTab.SuspendLayout();
            this.MakeSayTab.SuspendLayout();
            this.DicePage.SuspendLayout();
            this.HoloTab.SuspendLayout();
            this.CatalogBuyEditor.SuspendLayout();
            this.GiftPageTab.SuspendLayout();
            this.MiscellaneousTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // RetroFunTabs
            // 
            this.RetroFunTabs.Controls.Add(this.FurnitureTab);
            this.RetroFunTabs.Controls.Add(this.ChatTab);
            this.RetroFunTabs.Controls.Add(this.StalkingTab);
            this.RetroFunTabs.Controls.Add(this.MakeSayTab);
            this.RetroFunTabs.Controls.Add(this.DicePage);
            this.RetroFunTabs.Controls.Add(this.HoloTab);
            this.RetroFunTabs.Controls.Add(this.CatalogBuyEditor);
            this.RetroFunTabs.Controls.Add(this.GiftPageTab);
            this.RetroFunTabs.Controls.Add(this.MiscellaneousTab);
            this.RetroFunTabs.DisplayBoundary = true;
            this.RetroFunTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.RetroFunTabs.IsDisplayingBorder = true;
            this.RetroFunTabs.ItemSize = new System.Drawing.Size(95, 24);
            this.RetroFunTabs.Location = new System.Drawing.Point(0, 0);
            this.RetroFunTabs.Name = "RetroFunTabs";
            this.RetroFunTabs.SelectedIndex = 0;
            this.RetroFunTabs.Size = new System.Drawing.Size(479, 301);
            this.RetroFunTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
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
            this.furniturePage1.Size = new System.Drawing.Size(465, 263);
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
            this.chatPage1.Location = new System.Drawing.Point(-4, 0);
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
            this.makeSayPage1.Location = new System.Drawing.Point(3, 3);
            this.makeSayPage1.Name = "makeSayPage1";
            this.makeSayPage1.Size = new System.Drawing.Size(465, 263);
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
            // CatalogBuyEditor
            // 
            this.CatalogBuyEditor.Controls.Add(this.buyFurniBruteforcer1);
            this.CatalogBuyEditor.Location = new System.Drawing.Point(4, 28);
            this.CatalogBuyEditor.Name = "CatalogBuyEditor";
            this.CatalogBuyEditor.Size = new System.Drawing.Size(471, 269);
            this.CatalogBuyEditor.TabIndex = 8;
            this.CatalogBuyEditor.Text = "Catalog Buy Hack";
            this.CatalogBuyEditor.UseVisualStyleBackColor = true;
            // 
            // GiftPageTab
            // 
            this.GiftPageTab.Controls.Add(this.giftEditor1);
            this.GiftPageTab.Location = new System.Drawing.Point(4, 28);
            this.GiftPageTab.Name = "GiftPageTab";
            this.GiftPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.GiftPageTab.Size = new System.Drawing.Size(471, 269);
            this.GiftPageTab.TabIndex = 7;
            this.GiftPageTab.Text = "Gifts ";
            this.GiftPageTab.UseVisualStyleBackColor = true;
            // 
            // giftEditor1
            // 
            this.giftEditor1.BackColor = System.Drawing.Color.White;
            this.giftEditor1.EnableLoop = false;
            this.giftEditor1.FurnIIDBruteforcerEnabled = false;
            this.giftEditor1.FurniIDint = 0;
            this.giftEditor1.GlobalBruteforcerEnabled = false;
            this.giftEditor1.isAnonymous = false;
            this.giftEditor1.Location = new System.Drawing.Point(0, 0);
            this.giftEditor1.Name = "giftEditor1";
            this.giftEditor1.PageIDBruteForcerEnabled = false;
            this.giftEditor1.PageIDInt = 0;
            this.giftEditor1.Purchased = false;
            this.giftEditor1.Size = new System.Drawing.Size(477, 273);
            this.giftEditor1.SpeedTimer = 6000;
            this.giftEditor1.TabIndex = 0;
            this.giftEditor1.TabStop = false;
            // 
            // MiscellaneousTab
            // 
            this.MiscellaneousTab.Controls.Add(this.miscellaneousPage2);
            this.MiscellaneousTab.Location = new System.Drawing.Point(4, 28);
            this.MiscellaneousTab.Name = "MiscellaneousTab";
            this.MiscellaneousTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiscellaneousTab.Size = new System.Drawing.Size(471, 269);
            this.MiscellaneousTab.TabIndex = 3;
            this.MiscellaneousTab.Text = "Miscellaneous";
            this.MiscellaneousTab.UseVisualStyleBackColor = true;
            // 
            // miscellaneousPage2
            // 
            this.miscellaneousPage2.AntiFriendRemove = false;
            this.miscellaneousPage2.BackColor = System.Drawing.Color.White;
            this.miscellaneousPage2.FreezeUserMovement = false;
            this.miscellaneousPage2.Location = new System.Drawing.Point(5, 3);
            this.miscellaneousPage2.Name = "miscellaneousPage2";
            this.miscellaneousPage2.Size = new System.Drawing.Size(463, 263);
            this.miscellaneousPage2.TabIndex = 0;
            this.miscellaneousPage2.TabStop = false;
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
            // buyFurniBruteforcer1
            // 
            this.buyFurniBruteforcer1.BackColor = System.Drawing.Color.White;
            this.buyFurniBruteforcer1.EnableLoop = false;
            this.buyFurniBruteforcer1.FurniIDint1 = 0;
            this.buyFurniBruteforcer1.Location = new System.Drawing.Point(0, 0);
            this.buyFurniBruteforcer1.Name = "buyFurniBruteforcer1";
            this.buyFurniBruteforcer1.PageIDInt1 = 0;
            this.buyFurniBruteforcer1.Size = new System.Drawing.Size(475, 269);
            this.buyFurniBruteforcer1.SpeedTimer1 = 6000;
            this.buyFurniBruteforcer1.TabIndex = 0;
            this.buyFurniBruteforcer1.TabStop = false;
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
            this.DicePage.ResumeLayout(false);
            this.HoloTab.ResumeLayout(false);
            this.CatalogBuyEditor.ResumeLayout(false);
            this.GiftPageTab.ResumeLayout(false);
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
        private BuyFurniBruteforcer buyFurniBruteforcer1;
        private Pages.FurniturePage FurniturePg;
        private Pages.ChatPage ChatPg;
        private Pages.StalkingPage StalkingPg;
        private Pages.MiscellaneousPage MiscellaneousPg;
        private System.Windows.Forms.TabPage MakeSayTab;
        private Pages.MakeSayPage MakeSayPg;
        private System.Windows.Forms.TabPage DicePage;
        private Pages.DicePage DicePg;
        private Pages.BuyFurniBruteforcer catalogBruteForcerPg;
        private Pages.GiftEditor gifteditorpg;
        private System.Windows.Forms.TabPage HoloTab;
        private Pages.AutoHoloDicePage AutoHoloDicePg;
        private Pages.FurniturePage furniturePage1;
        private Pages.ChatPage chatPage1;
        private Pages.StalkingPage stalkingPage1;
        private Pages.MakeSayPage makeSayPage1;
        private Pages.DicePage dicePage1;
        private Pages.AutoHoloDicePage autoHoloDicePage1;
        private System.Windows.Forms.TabPage GiftPageTab;
        private Pages.GiftEditor giftEditor1;
        private System.Windows.Forms.TabPage CatalogBuyEditor;
        private Pages.MiscellaneousPage miscellaneousPage2;
    }
}