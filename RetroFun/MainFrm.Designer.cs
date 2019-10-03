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
            this.ChatPg = new RetroFun.Pages.ChatPage();
            this.DicePg = new RetroFun.Pages.DicePage();
            this.FurniPg = new RetroFun.Pages.FurniturePage();
            this.MakeSayPg = new RetroFun.Pages.MakeSayPage();
            this.SpeechzPg = new RetroFun.Pages.SpeechzPage();
            this.StalkingPg = new RetroFun.Pages.StalkingPage();
            this.GiftEditorPg = new RetroFun.Pages.GiftEditor();
            this.AutoHoloDicePg = new RetroFun.Pages.AutoHoloDicePage();
            this.MoonLightFunPg = new RetroFun.Pages.MoonLightFunPage();
            this.MiscellaneousPg = new RetroFun.Pages.MiscellaneousPage();
            this.BuyFurniBruteforcerPg = new RetroFun.Pages.BuyFurniBruteforcerPage();
            this.RoomBackFunPg = new RetroFun.Pages.RoomBackFun();
            this.RetroFunTabs = new Sulakore.Components.SKoreTabControl();
            this.FurnitureTab = new System.Windows.Forms.TabPage();
            this.ChatTab = new System.Windows.Forms.TabPage();
            this.StalkingTab = new System.Windows.Forms.TabPage();
            this.MakeSayTab = new System.Windows.Forms.TabPage();
            this.DicePage = new System.Windows.Forms.TabPage();
            this.HoloTab = new System.Windows.Forms.TabPage();
            this.DiscoFunTab = new System.Windows.Forms.TabPage();
            this.RoomBGTab = new System.Windows.Forms.TabPage();
            this.CatalogBuyEditor = new System.Windows.Forms.TabPage();
            this.GiftPageTab = new System.Windows.Forms.TabPage();
            this.SpeechzTab = new System.Windows.Forms.TabPage();
            this.MiscellaneousTab = new System.Windows.Forms.TabPage();
            this.AlwaysOnTopChbx = new System.Windows.Forms.CheckBox();
            this.RetroFunTabs.SuspendLayout();
            this.FurnitureTab.SuspendLayout();
            this.ChatTab.SuspendLayout();
            this.StalkingTab.SuspendLayout();
            this.MakeSayTab.SuspendLayout();
            this.DicePage.SuspendLayout();
            this.HoloTab.SuspendLayout();
            this.DiscoFunTab.SuspendLayout();
            this.RoomBGTab.SuspendLayout();
            this.CatalogBuyEditor.SuspendLayout();
            this.GiftPageTab.SuspendLayout();
            this.SpeechzTab.SuspendLayout();
            this.MiscellaneousTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatPg
            // 
            this.ChatPg.AntiBobbaFilter = false;
            this.ChatPg.BackColor = System.Drawing.Color.White;
            this.ChatPg.HideSpeakingBubble = false;
            this.ChatPg.Location = new System.Drawing.Point(57, 6);
            this.ChatPg.Name = "ChatPg";
            this.ChatPg.Size = new System.Drawing.Size(465, 263);
            this.ChatPg.TabIndex = 0;
            this.ChatPg.TabStop = false;
            this.ChatPg.UseSelectedBubble = false;
            // 
            // DicePg
            // 
            this.DicePg.BackColor = System.Drawing.Color.White;
            this.DicePg.IsRegistrationMode = false;
            this.DicePg.IsUserFreezed = false;
            this.DicePg.Location = new System.Drawing.Point(79, 16);
            this.DicePg.Name = "DicePg";
            this.DicePg.Size = new System.Drawing.Size(465, 263);
            this.DicePg.TabIndex = 0;
            this.DicePg.TabStop = false;
            // 
            // FurniPg
            // 
            this.FurniPg.BackColor = System.Drawing.Color.White;
            this.FurniPg.ButtonRotateMoveItem = false;
            this.FurniPg.DoubleClickFurnitureRemoval = false;
            this.FurniPg.FurnitureIdText = null;
            this.FurniPg.Location = new System.Drawing.Point(178, 50);
            this.FurniPg.Name = "FurniPg";
            this.FurniPg.Size = new System.Drawing.Size(275, 199);
            this.FurniPg.TabIndex = 0;
            this.FurniPg.TabStop = false;
            // 
            // MakeSayPg
            // 
            this.MakeSayPg.BackColor = System.Drawing.Color.White;
            this.MakeSayPg.Location = new System.Drawing.Point(72, 24);
            this.MakeSayPg.Name = "MakeSayPg";
            this.MakeSayPg.Size = new System.Drawing.Size(465, 263);
            this.MakeSayPg.TabIndex = 0;
            this.MakeSayPg.TabStop = false;
            // 
            // SpeechzPg
            // 
            this.SpeechzPg.BackColor = System.Drawing.Color.White;
            this.SpeechzPg.Location = new System.Drawing.Point(66, 19);
            this.SpeechzPg.Name = "SpeechzPg";
            this.SpeechzPg.Size = new System.Drawing.Size(472, 276);
            this.SpeechzPg.TabIndex = 0;
            this.SpeechzPg.TabStop = false;
            // 
            // StalkingPg
            // 
            this.StalkingPg.BackColor = System.Drawing.Color.White;
            this.StalkingPg.Location = new System.Drawing.Point(69, 30);
            this.StalkingPg.Name = "StalkingPg";
            this.StalkingPg.Size = new System.Drawing.Size(465, 263);
            this.StalkingPg.TabIndex = 0;
            this.StalkingPg.TabStop = false;
            // 
            // GiftEditorPg
            // 
            this.GiftEditorPg.BackColor = System.Drawing.Color.White;
            this.GiftEditorPg.EnableLoop = false;
            this.GiftEditorPg.FurnIIDBruteforcerEnabled = false;
            this.GiftEditorPg.FurniIDint = 0;
            this.GiftEditorPg.GlobalBruteforcerEnabled = false;
            this.GiftEditorPg.isAnonymous = false;
            this.GiftEditorPg.Location = new System.Drawing.Point(60, 18);
            this.GiftEditorPg.Name = "GiftEditorPg";
            this.GiftEditorPg.PageIDBruteForcerEnabled = false;
            this.GiftEditorPg.PageIDInt = 0;
            this.GiftEditorPg.Purchased = false;
            this.GiftEditorPg.Size = new System.Drawing.Size(477, 273);
            this.GiftEditorPg.SpeedTimer = 6000;
            this.GiftEditorPg.TabIndex = 0;
            this.GiftEditorPg.TabStop = false;
            // 
            // AutoHoloDicePg
            // 
            this.AutoHoloDicePg.BackColor = System.Drawing.Color.White;
            this.AutoHoloDicePg.DiceHostResult = 0;
            this.AutoHoloDicePg.DiceOneResult = 0;
            this.AutoHoloDicePg.DiceThreeResult = 0;
            this.AutoHoloDicePg.DiceTwoResult = 0;
            this.AutoHoloDicePg.ISHolodiceCheat = false;
            this.AutoHoloDicePg.IsUserFreezed = false;
            this.AutoHoloDicePg.Location = new System.Drawing.Point(74, 17);
            this.AutoHoloDicePg.Name = "AutoHoloDicePg";
            this.AutoHoloDicePg.Size = new System.Drawing.Size(465, 263);
            this.AutoHoloDicePg.TabIndex = 0;
            this.AutoHoloDicePg.TabStop = false;
            // 
            // MoonLightFunPg
            // 
            this.MoonLightFunPg.BackColor = System.Drawing.Color.White;
            this.MoonLightFunPg.CustomColor = null;
            this.MoonLightFunPg.Density = 0;
            this.MoonLightFunPg.DiscoCooldown = 500;
            this.MoonLightFunPg.JustWallpapers = false;
            this.MoonLightFunPg.LiveEditCooldown = 500;
            this.MoonLightFunPg.Location = new System.Drawing.Point(83, 3);
            this.MoonLightFunPg.Name = "MoonLightFunPg";
            this.MoonLightFunPg.SelectedCustom = false;
            this.MoonLightFunPg.Size = new System.Drawing.Size(405, 298);
            this.MoonLightFunPg.TabIndex = 0;
            this.MoonLightFunPg.TabStop = false;
            // 
            // MiscellaneousPg
            // 
            this.MiscellaneousPg.AntiFriendRemove = false;
            this.MiscellaneousPg.BackColor = System.Drawing.Color.White;
            this.MiscellaneousPg.FreezeUserMovement = false;
            this.MiscellaneousPg.Location = new System.Drawing.Point(8, 21);
            this.MiscellaneousPg.Name = "MiscellaneousPg";
            this.MiscellaneousPg.Size = new System.Drawing.Size(425, 263);
            this.MiscellaneousPg.TabIndex = 0;
            this.MiscellaneousPg.TabStop = false;
            this.MiscellaneousPg.TrollSpeedChat = 6000;
            // 
            // BuyFurniBruteforcerPg
            // 
            this.BuyFurniBruteforcerPg.BackColor = System.Drawing.Color.White;
            this.BuyFurniBruteforcerPg.EnableLoop = false;
            this.BuyFurniBruteforcerPg.FurniIDint1 = 0;
            this.BuyFurniBruteforcerPg.Location = new System.Drawing.Point(72, 26);
            this.BuyFurniBruteforcerPg.Name = "BuyFurniBruteforcerPg";
            this.BuyFurniBruteforcerPg.PageIDInt1 = 0;
            this.BuyFurniBruteforcerPg.PurchaseSuccess = false;
            this.BuyFurniBruteforcerPg.Size = new System.Drawing.Size(475, 269);
            this.BuyFurniBruteforcerPg.SpeedTimer1 = 6000;
            this.BuyFurniBruteforcerPg.TabIndex = 0;
            this.BuyFurniBruteforcerPg.TabStop = false;
            this.BuyFurniBruteforcerPg.TextBox = null;
            // 
            // RoomBackFunPg
            // 
            this.RoomBackFunPg.BackColor = System.Drawing.Color.White;
            this.RoomBackFunPg.CaptureMode = false;
            this.RoomBackFunPg.FurniID = 0;
            this.RoomBackFunPg.Location = new System.Drawing.Point(18, 6);
            this.RoomBackFunPg.Luminosity = 0;
            this.RoomBackFunPg.Name = "RoomBackFunPg";
            this.RoomBackFunPg.Saturation = 0;
            this.RoomBackFunPg.Size = new System.Drawing.Size(578, 270);
            this.RoomBackFunPg.Speed = 0;
            this.RoomBackFunPg.TabIndex = 2;
            this.RoomBackFunPg.TabStop = false;
            this.RoomBackFunPg.Tonality = 0;
            // 
            // RetroFunTabs
            // 
            this.RetroFunTabs.Controls.Add(this.FurnitureTab);
            this.RetroFunTabs.Controls.Add(this.ChatTab);
            this.RetroFunTabs.Controls.Add(this.StalkingTab);
            this.RetroFunTabs.Controls.Add(this.MakeSayTab);
            this.RetroFunTabs.Controls.Add(this.DicePage);
            this.RetroFunTabs.Controls.Add(this.HoloTab);
            this.RetroFunTabs.Controls.Add(this.DiscoFunTab);
            this.RetroFunTabs.Controls.Add(this.RoomBGTab);
            this.RetroFunTabs.Controls.Add(this.CatalogBuyEditor);
            this.RetroFunTabs.Controls.Add(this.GiftPageTab);
            this.RetroFunTabs.Controls.Add(this.SpeechzTab);
            this.RetroFunTabs.Controls.Add(this.MiscellaneousTab);
            this.RetroFunTabs.DisplayBoundary = true;
            this.RetroFunTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.RetroFunTabs.IsDisplayingBorder = true;
            this.RetroFunTabs.ItemSize = new System.Drawing.Size(95, 24);
            this.RetroFunTabs.Location = new System.Drawing.Point(0, 0);
            this.RetroFunTabs.Name = "RetroFunTabs";
            this.RetroFunTabs.SelectedIndex = 0;
            this.RetroFunTabs.Size = new System.Drawing.Size(628, 347);
            this.RetroFunTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.RetroFunTabs.TabIndex = 0;
            // 
            // FurnitureTab
            // 
            this.FurnitureTab.Controls.Add(this.FurniPg);
            this.FurnitureTab.Location = new System.Drawing.Point(4, 28);
            this.FurnitureTab.Name = "FurnitureTab";
            this.FurnitureTab.Padding = new System.Windows.Forms.Padding(3);
            this.FurnitureTab.Size = new System.Drawing.Size(620, 315);
            this.FurnitureTab.TabIndex = 0;
            this.FurnitureTab.Text = "Furniture";
            this.FurnitureTab.UseVisualStyleBackColor = true;
            // 
            // ChatTab
            // 
            this.ChatTab.Controls.Add(this.ChatPg);
            this.ChatTab.Location = new System.Drawing.Point(4, 28);
            this.ChatTab.Name = "ChatTab";
            this.ChatTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChatTab.Size = new System.Drawing.Size(620, 315);
            this.ChatTab.TabIndex = 1;
            this.ChatTab.Text = "Chat";
            this.ChatTab.UseVisualStyleBackColor = true;
            // 
            // StalkingTab
            // 
            this.StalkingTab.Controls.Add(this.StalkingPg);
            this.StalkingTab.Location = new System.Drawing.Point(4, 28);
            this.StalkingTab.Name = "StalkingTab";
            this.StalkingTab.Padding = new System.Windows.Forms.Padding(3);
            this.StalkingTab.Size = new System.Drawing.Size(620, 315);
            this.StalkingTab.TabIndex = 2;
            this.StalkingTab.Text = "Stalking";
            this.StalkingTab.UseVisualStyleBackColor = true;
            // 
            // MakeSayTab
            // 
            this.MakeSayTab.Controls.Add(this.MakeSayPg);
            this.MakeSayTab.Location = new System.Drawing.Point(4, 28);
            this.MakeSayTab.Name = "MakeSayTab";
            this.MakeSayTab.Padding = new System.Windows.Forms.Padding(3);
            this.MakeSayTab.Size = new System.Drawing.Size(620, 315);
            this.MakeSayTab.TabIndex = 4;
            this.MakeSayTab.Text = "MakeSay";
            this.MakeSayTab.UseVisualStyleBackColor = true;
            // 
            // DicePage
            // 
            this.DicePage.Controls.Add(this.DicePg);
            this.DicePage.Location = new System.Drawing.Point(4, 28);
            this.DicePage.Name = "DicePage";
            this.DicePage.Size = new System.Drawing.Size(620, 315);
            this.DicePage.TabIndex = 5;
            this.DicePage.Text = "Dice ";
            this.DicePage.UseVisualStyleBackColor = true;
            // 
            // HoloTab
            // 
            this.HoloTab.Controls.Add(this.AutoHoloDicePg);
            this.HoloTab.Location = new System.Drawing.Point(4, 28);
            this.HoloTab.Name = "HoloTab";
            this.HoloTab.Padding = new System.Windows.Forms.Padding(3);
            this.HoloTab.Size = new System.Drawing.Size(620, 315);
            this.HoloTab.TabIndex = 6;
            this.HoloTab.Text = "AutomaticHolo";
            this.HoloTab.UseVisualStyleBackColor = true;
            // 
            // DiscoFunTab
            // 
            this.DiscoFunTab.Controls.Add(this.MoonLightFunPg);
            this.DiscoFunTab.Location = new System.Drawing.Point(4, 28);
            this.DiscoFunTab.Name = "DiscoFunTab";
            this.DiscoFunTab.Size = new System.Drawing.Size(620, 315);
            this.DiscoFunTab.TabIndex = 10;
            this.DiscoFunTab.Text = "Disco Fun";
            this.DiscoFunTab.UseVisualStyleBackColor = true;
            // 
            // RoomBGTab
            // 
            this.RoomBGTab.Controls.Add(this.RoomBackFunPg);
            this.RoomBGTab.Location = new System.Drawing.Point(4, 28);
            this.RoomBGTab.Name = "RoomBGTab";
            this.RoomBGTab.Padding = new System.Windows.Forms.Padding(3);
            this.RoomBGTab.Size = new System.Drawing.Size(620, 315);
            this.RoomBGTab.TabIndex = 11;
            this.RoomBGTab.Text = "Room Background";
            this.RoomBGTab.UseVisualStyleBackColor = true;
            // 
            // CatalogBuyEditor
            // 
            this.CatalogBuyEditor.Controls.Add(this.BuyFurniBruteforcerPg);
            this.CatalogBuyEditor.Location = new System.Drawing.Point(4, 28);
            this.CatalogBuyEditor.Name = "CatalogBuyEditor";
            this.CatalogBuyEditor.Size = new System.Drawing.Size(620, 315);
            this.CatalogBuyEditor.TabIndex = 8;
            this.CatalogBuyEditor.Text = "Catalog Buy Hack";
            this.CatalogBuyEditor.UseVisualStyleBackColor = true;
            // 
            // GiftPageTab
            // 
            this.GiftPageTab.Controls.Add(this.GiftEditorPg);
            this.GiftPageTab.Location = new System.Drawing.Point(4, 28);
            this.GiftPageTab.Name = "GiftPageTab";
            this.GiftPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.GiftPageTab.Size = new System.Drawing.Size(620, 315);
            this.GiftPageTab.TabIndex = 7;
            this.GiftPageTab.Text = "Gifts ";
            this.GiftPageTab.UseVisualStyleBackColor = true;
            // 
            // SpeechzTab
            // 
            this.SpeechzTab.Controls.Add(this.SpeechzPg);
            this.SpeechzTab.Location = new System.Drawing.Point(4, 28);
            this.SpeechzTab.Name = "SpeechzTab";
            this.SpeechzTab.Padding = new System.Windows.Forms.Padding(3);
            this.SpeechzTab.Size = new System.Drawing.Size(620, 315);
            this.SpeechzTab.TabIndex = 9;
            this.SpeechzTab.Text = "Speechz";
            this.SpeechzTab.UseVisualStyleBackColor = true;
            // 
            // MiscellaneousTab
            // 
            this.MiscellaneousTab.Controls.Add(this.MiscellaneousPg);
            this.MiscellaneousTab.Location = new System.Drawing.Point(4, 28);
            this.MiscellaneousTab.Name = "MiscellaneousTab";
            this.MiscellaneousTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiscellaneousTab.Size = new System.Drawing.Size(620, 315);
            this.MiscellaneousTab.TabIndex = 3;
            this.MiscellaneousTab.Text = "Miscellaneous";
            this.MiscellaneousTab.UseVisualStyleBackColor = true;
            // 
            // AlwaysOnTopChbx
            // 
            this.AlwaysOnTopChbx.AutoSize = true;
            this.AlwaysOnTopChbx.Location = new System.Drawing.Point(518, 353);
            this.AlwaysOnTopChbx.Name = "AlwaysOnTopChbx";
            this.AlwaysOnTopChbx.Size = new System.Drawing.Size(98, 17);
            this.AlwaysOnTopChbx.TabIndex = 0;
            this.AlwaysOnTopChbx.Text = "Always On Top";
            this.AlwaysOnTopChbx.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 384);
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
            this.DiscoFunTab.ResumeLayout(false);
            this.RoomBGTab.ResumeLayout(false);
            this.CatalogBuyEditor.ResumeLayout(false);
            this.GiftPageTab.ResumeLayout(false);
            this.SpeechzTab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage MakeSayTab;
        private System.Windows.Forms.TabPage DicePage;
        private System.Windows.Forms.TabPage HoloTab;
        private System.Windows.Forms.TabPage GiftPageTab;
        private System.Windows.Forms.TabPage CatalogBuyEditor;
        private System.Windows.Forms.TabPage SpeechzTab;
        private System.Windows.Forms.TabPage DiscoFunTab;
        private System.Windows.Forms.TabPage RoomBGTab;

        //REGISTER PAGES HERE

        private Pages.ChatPage ChatPg;
        private Pages.DicePage DicePg;
        private Pages.FurniturePage FurniPg;
        private Pages.MakeSayPage MakeSayPg;
        private Pages.SpeechzPage SpeechzPg;
        private Pages.GiftEditor GiftEditorPg;
        private Pages.StalkingPage StalkingPg;
        private Pages.AutoHoloDicePage AutoHoloDicePg;
        private Pages.MoonLightFunPage MoonLightFunPg;
        private Pages.MiscellaneousPage MiscellaneousPg;
        private Pages.BuyFurniBruteforcerPage BuyFurniBruteforcerPg;
        private Pages.RoomBackFun RoomBackFunPg;
    }
}