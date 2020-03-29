using RetroFun.Pages;
using System.Net;

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
            this.AutoHoloDicePg = new RetroFun.Pages.DiceBotPage();
            this.MiscellaneousPg = new RetroFun.Pages.MiscellaneousPage();
            this.RoomBackFunPg = new RetroFun.Pages.RoomBackFun();
            this.RetroFunTabs = new Sulakore.Components.SKoreTabControl();
            this.PersonalTab = new System.Windows.Forms.TabPage();
            this.PersonalPg = new RetroFun.Pages.PersonalPage();
            this.UtiliesTab = new System.Windows.Forms.TabPage();
            this.UtilitiesPg = new RetroFun.Pages.UtilitiesPage();
            this.FurnitureTab = new System.Windows.Forms.TabPage();
            this.FurnitureSpawnerTab = new System.Windows.Forms.TabPage();
            this.furniSpawnPg = new RetroFun.Pages.FurniSpawnPage();
            this.FurnitureSpamTab = new System.Windows.Forms.TabPage();
            this.FurniTrollPg = new RetroFun.Pages.FurniTrollPg();
            this.ChatTab = new System.Windows.Forms.TabPage();
            this.UserEditorTab = new System.Windows.Forms.TabPage();
            this.UserEditorPg = new RetroFun.Pages.UserEditorPage();
            this.MakeSayTab = new System.Windows.Forms.TabPage();
            this.StalkingTab = new System.Windows.Forms.TabPage();
            this.FakeMsgTab = new System.Windows.Forms.TabPage();
            this.FakeMessagePg = new RetroFun.Pages.FakeMessagePage();
            this.PetTab = new System.Windows.Forms.TabPage();
            this.PetPg = new RetroFun.Pages.PetPage();
            this.DicePageTab = new System.Windows.Forms.TabPage();
            this.DiceBotTab = new System.Windows.Forms.TabPage();
            this.DiscoFunTab = new System.Windows.Forms.TabPage();
            this.MoonlightPages = new Sulakore.Components.SKoreTabControl();
            this.MoonLightTab = new System.Windows.Forms.TabPage();
            this.MoonLightFunPg = new RetroFun.Pages.MoonLightFunPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DiscoRoomFunPg = new RetroFun.Pages.DiscoRoomLight();
            this.RoomBGTab = new System.Windows.Forms.TabPage();
            this.CatalogBuyEditorTab = new System.Windows.Forms.TabPage();
            this.GiftPageTab = new System.Windows.Forms.TabPage();
            this.SpeechzTab = new System.Windows.Forms.TabPage();
            this.DoorbelTab = new System.Windows.Forms.TabPage();
            this.roomBypasserPage = new RetroFun.Pages.RoomBypasserPage();
            this.MiscellaneousTab = new System.Windows.Forms.TabPage();
            this.AlwaysOnTopChbx = new System.Windows.Forms.CheckBox();
            this.BottomPg = new RetroFun.Pages.BottomPage();
            this.BuyFurniBruteforcerPg = new RetroFun.Pages.BuyFurniBruteforcerPage();
            this.RetroFunTabs.SuspendLayout();
            this.PersonalTab.SuspendLayout();
            this.UtiliesTab.SuspendLayout();
            this.FurnitureTab.SuspendLayout();
            this.FurnitureSpawnerTab.SuspendLayout();
            this.FurnitureSpamTab.SuspendLayout();
            this.ChatTab.SuspendLayout();
            this.UserEditorTab.SuspendLayout();
            this.MakeSayTab.SuspendLayout();
            this.StalkingTab.SuspendLayout();
            this.FakeMsgTab.SuspendLayout();
            this.PetTab.SuspendLayout();
            this.DicePageTab.SuspendLayout();
            this.DiceBotTab.SuspendLayout();
            this.DiscoFunTab.SuspendLayout();
            this.MoonlightPages.SuspendLayout();
            this.MoonLightTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.RoomBGTab.SuspendLayout();
            this.CatalogBuyEditorTab.SuspendLayout();
            this.GiftPageTab.SuspendLayout();
            this.SpeechzTab.SuspendLayout();
            this.DoorbelTab.SuspendLayout();
            this.MiscellaneousTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatPg
            // 
            this.ChatPg.AntiBobbaFilter = false;
            this.ChatPg.BackColor = System.Drawing.Color.White;
            this.ChatPg.FlooderCooldown = 50;
            this.ChatPg.FlooderEnabled = false;
            this.ChatPg.FlooderText = null;
            this.ChatPg.ForceChatSpeak = false;
            this.ChatPg.ForceNormalSpeak = true;
            this.ChatPg.ForceShoutChat = false;
            this.ChatPg.ForceWhisperChat = false;
            this.ChatPg.HideSpeakingBubble = false;
            this.ChatPg.Location = new System.Drawing.Point(9, 0);
            this.ChatPg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ChatPg.Name = "ChatPg";
            this.ChatPg.RainbowChatEnabled = false;
            this.ChatPg.Size = new System.Drawing.Size(1180, 612);
            this.ChatPg.TabIndex = 0;
            this.ChatPg.TabStop = false;
            this.ChatPg.UsernameFilter = null;
            this.ChatPg.UseSelectedBubbleClientSide = false;
            this.ChatPg.UseSelectedBubbleServerSide = false;
            // 
            // DicePg
            // 
            this.DicePg.BackColor = System.Drawing.Color.White;
            this.DicePg.DiceID1 = 0;
            this.DicePg.DiceID2 = 0;
            this.DicePg.DiceID3 = 0;
            this.DicePg.DiceID4 = 0;
            this.DicePg.DiceID5 = 0;
            this.DicePg.DiceID6 = 0;
            this.DicePg.DiceResult1 = 0;
            this.DicePg.DiceResult2 = 0;
            this.DicePg.DiceResult3 = 0;
            this.DicePg.DiceResult4 = 0;
            this.DicePg.DiceResult5 = 0;
            this.DicePg.DiceResult6 = 0;
            this.DicePg.DiceSelected1 = false;
            this.DicePg.DiceSelected2 = false;
            this.DicePg.DiceSelected3 = false;
            this.DicePg.DiceSelected4 = false;
            this.DicePg.DiceSelected5 = false;
            this.DicePg.DiceSelected6 = false;
            this.DicePg.IsRegistrationMode = false;
            this.DicePg.Location = new System.Drawing.Point(4, 5);
            this.DicePg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DicePg.Name = "DicePg";
            this.DicePg.Size = new System.Drawing.Size(1185, 608);
            this.DicePg.TabIndex = 0;
            this.DicePg.TabStop = false;
            // 
            // FurniPg
            // 
            this.FurniPg.BackColor = System.Drawing.Color.White;
            this.FurniPg.DoubleClickFurnitureRemoval = false;
            this.FurniPg.FloorFurniID = 0;
            this.FurniPg.FloorFurniLiveEditCooldown = 0;
            this.FurniPg.FloorFurniRotation = 0;
            this.FurniPg.FloorFurniX = 0;
            this.FurniPg.FloorFurniY = 0;
            this.FurniPg.FurniPickedOutput = false;
            this.FurniPg.FurnitureIdText = null;
            this.FurniPg.FurniWalkingSpeed = 300;
            this.FurniPg.Location = new System.Drawing.Point(8, 8);
            this.FurniPg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FurniPg.Name = "FurniPg";
            this.FurniPg.Size = new System.Drawing.Size(1180, 608);
            this.FurniPg.TabIndex = 0;
            this.FurniPg.TabStop = false;
            // 
            // MakeSayPg
            // 
            this.MakeSayPg.BackColor = System.Drawing.Color.White;
            this.MakeSayPg.Location = new System.Drawing.Point(4, 0);
            this.MakeSayPg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MakeSayPg.Name = "MakeSayPg";
            this.MakeSayPg.Size = new System.Drawing.Size(1180, 608);
            this.MakeSayPg.TabIndex = 0;
            this.MakeSayPg.TabStop = false;
            // 
            // SpeechzPg
            // 
            this.SpeechzPg.BackColor = System.Drawing.Color.White;
            this.SpeechzPg.Location = new System.Drawing.Point(0, 0);
            this.SpeechzPg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.SpeechzPg.Name = "SpeechzPg";
            this.SpeechzPg.Size = new System.Drawing.Size(1190, 617);
            this.SpeechzPg.TabIndex = 0;
            this.SpeechzPg.TabStop = false;
            // 
            // StalkingPg
            // 
            this.StalkingPg.BackColor = System.Drawing.Color.White;
            this.StalkingPg.Location = new System.Drawing.Point(4, 0);
            this.StalkingPg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.StalkingPg.Name = "StalkingPg";
            this.StalkingPg.ShouldCaptureIDMode = false;
            this.StalkingPg.Size = new System.Drawing.Size(1180, 617);
            this.StalkingPg.TabIndex = 0;
            this.StalkingPg.TabStop = false;
            this.StalkingPg.UserIDCapture = 0;
            // 
            // GiftEditorPg
            // 
            this.GiftEditorPg.BackColor = System.Drawing.Color.White;
            this.GiftEditorPg.EnableLoop = false;
            this.GiftEditorPg.FileNameSave = "Unnamed.RetroFun";
            this.GiftEditorPg.FurnIIDBruteforcerEnabled = false;
            this.GiftEditorPg.FurniIDint = 0;
            this.GiftEditorPg.FurniIDint1 = 0;
            this.GiftEditorPg.FurniIDIntRange = 0;
            this.GiftEditorPg.FurniIDOptionToggle = true;
            this.GiftEditorPg.FurniIDRangeToggle = false;
            this.GiftEditorPg.GiftCaptureModeCatalog = false;
            this.GiftEditorPg.GlobalBruteforcerEnabled = false;
            this.GiftEditorPg.isAnonymous = false;
            this.GiftEditorPg.Location = new System.Drawing.Point(0, 0);
            this.GiftEditorPg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.GiftEditorPg.Name = "GiftEditorPg";
            this.GiftEditorPg.PageIDBruteForcerEnabled = false;
            this.GiftEditorPg.PageIDInt = 0;
            this.GiftEditorPg.PageIDInt1 = 0;
            this.GiftEditorPg.PageIDIntRange = 0;
            this.GiftEditorPg.PageIDOptionToggle = false;
            this.GiftEditorPg.PageIDRangeToggle = false;
            this.GiftEditorPg.Purchased = false;
            this.GiftEditorPg.PurchaseSuccess = false;
            this.GiftEditorPg.Size = new System.Drawing.Size(1190, 623);
            this.GiftEditorPg.SpeedTimer = 6000;
            this.GiftEditorPg.SpeedTimer1 = 100;
            this.GiftEditorPg.TabIndex = 0;
            this.GiftEditorPg.TabStop = false;
            this.GiftEditorPg.TextBox = "";
            // 
            // AutoHoloDicePg
            // 
            this.AutoHoloDicePg.BackColor = System.Drawing.Color.White;
            this.AutoHoloDicePg.DiceHostResult = 0;
            this.AutoHoloDicePg.DiceResult1 = 0;
            this.AutoHoloDicePg.DiceResult2 = 0;
            this.AutoHoloDicePg.DiceResult3 = 0;
            this.AutoHoloDicePg.DiceResult4 = 0;
            this.AutoHoloDicePg.DiceResult5 = 0;
            this.AutoHoloDicePg.DiceResult6 = 0;
            this.AutoHoloDicePg.DiceSelected1 = false;
            this.AutoHoloDicePg.DiceSelected2 = false;
            this.AutoHoloDicePg.DiceSelected3 = false;
            this.AutoHoloDicePg.DiceSelected4 = false;
            this.AutoHoloDicePg.DiceSelected5 = false;
            this.AutoHoloDicePg.DiceSelected6 = false;
            this.AutoHoloDicePg.DiceSelectedResult1 = 0;
            this.AutoHoloDicePg.DiceSelectedResult2 = 0;
            this.AutoHoloDicePg.DiceSelectedResult3 = 0;
            this.AutoHoloDicePg.DiceSelectedResult4 = 0;
            this.AutoHoloDicePg.DiceSelectedResult5 = 0;
            this.AutoHoloDicePg.DiceSelectedResult6 = 0;
            this.AutoHoloDicePg.GlobalSelectResult = 0;
            this.AutoHoloDicePg.IsBotActive = false;
            this.AutoHoloDicePg.Location = new System.Drawing.Point(2, 0);
            this.AutoHoloDicePg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AutoHoloDicePg.Name = "AutoHoloDicePg";
            this.AutoHoloDicePg.ShoutPhrase = null;
            this.AutoHoloDicePg.Size = new System.Drawing.Size(1186, 634);
            this.AutoHoloDicePg.TabIndex = 0;
            this.AutoHoloDicePg.TabStop = false;
            // 
            // MiscellaneousPg
            // 
            this.MiscellaneousPg.AntiFriendRemove = true;
            this.MiscellaneousPg.BackColor = System.Drawing.Color.White;
            this.MiscellaneousPg.BlockMessageForYou = false;
            this.MiscellaneousPg.BlockStaffAlerts = false;
            this.MiscellaneousPg.ConvertMessageForYou = false;
            this.MiscellaneousPg.Dance_Cooldown = 500;
            this.MiscellaneousPg.Dance_DuckFunkSelected = false;
            this.MiscellaneousPg.Dance_NoneSelected = false;
            this.MiscellaneousPg.Dance_NormalSelected = false;
            this.MiscellaneousPg.Dance_PogoMogoSelected = false;
            this.MiscellaneousPg.Dance_TheRollieSelected = false;
            this.MiscellaneousPg.EightSelected = false;
            this.MiscellaneousPg.ExclamationSelected = false;
            this.MiscellaneousPg.FiveSelected = false;
            this.MiscellaneousPg.FourSelected = false;
            this.MiscellaneousPg.GestureCooldown = 250;
            this.MiscellaneousPg.HeartSelected = false;
            this.MiscellaneousPg.InvisibleSignSelected = false;
            this.MiscellaneousPg.KissSelected = false;
            this.MiscellaneousPg.LaughSelected = false;
            this.MiscellaneousPg.Location = new System.Drawing.Point(6, 8);
            this.MiscellaneousPg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MiscellaneousPg.Name = "MiscellaneousPg";
            this.MiscellaneousPg.NineSelected = false;
            this.MiscellaneousPg.NoneGestureSelected = false;
            this.MiscellaneousPg.OneSelected = false;
            this.MiscellaneousPg.PogoHopSelected = false;
            this.MiscellaneousPg.RedcardSelected = false;
            this.MiscellaneousPg.SevenSelected = false;
            this.MiscellaneousPg.SignCounterCoolDown = 0;
            this.MiscellaneousPg.SitsCooldown = 250;
            this.MiscellaneousPg.SixSelected = false;
            this.MiscellaneousPg.Size = new System.Drawing.Size(1190, 617);
            this.MiscellaneousPg.SkullSelected = false;
            this.MiscellaneousPg.SleepSelected = false;
            this.MiscellaneousPg.SmileySelected = false;
            this.MiscellaneousPg.SoccerballSelected = false;
            this.MiscellaneousPg.TabIndex = 0;
            this.MiscellaneousPg.TabStop = false;
            this.MiscellaneousPg.TenSelected = false;
            this.MiscellaneousPg.ThreeSelected = false;
            this.MiscellaneousPg.ThumbsUpSelected = false;
            this.MiscellaneousPg.TrollLookCooldown = 500;
            this.MiscellaneousPg.TwoSelected = false;
            this.MiscellaneousPg.UsernameFilter = null;
            this.MiscellaneousPg.WaveSelected = false;
            this.MiscellaneousPg.YellowcardSelected = false;
            this.MiscellaneousPg.ZeroSelected = false;
            // 
            // RoomBackFunPg
            // 
            this.RoomBackFunPg.BackColor = System.Drawing.Color.White;
            this.RoomBackFunPg.CaptureMode = false;
            this.RoomBackFunPg.FurniID = 0;
            this.RoomBackFunPg.GlobalSpeed = 150;
            this.RoomBackFunPg.GlobalSpeedSwitch = false;
            this.RoomBackFunPg.LiveEditSpeed = 150;
            this.RoomBackFunPg.Location = new System.Drawing.Point(0, 0);
            this.RoomBackFunPg.Luminosity = 0;
            this.RoomBackFunPg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.RoomBackFunPg.Name = "RoomBackFunPg";
            this.RoomBackFunPg.Saturation = 0;
            this.RoomBackFunPg.Size = new System.Drawing.Size(1190, 617);
            this.RoomBackFunPg.SpeedLuminosity = 150;
            this.RoomBackFunPg.SpeedSaturation = 150;
            this.RoomBackFunPg.SpeedTonality = 150;
            this.RoomBackFunPg.TabIndex = 2;
            this.RoomBackFunPg.TabStop = false;
            this.RoomBackFunPg.Tonality = 0;
            // 
            // RetroFunTabs
            // 
            this.RetroFunTabs.Controls.Add(this.PersonalTab);
            this.RetroFunTabs.Controls.Add(this.UtiliesTab);
            this.RetroFunTabs.Controls.Add(this.FurnitureTab);
            this.RetroFunTabs.Controls.Add(this.FurnitureSpawnerTab);
            this.RetroFunTabs.Controls.Add(this.FurnitureSpamTab);
            this.RetroFunTabs.Controls.Add(this.ChatTab);
            this.RetroFunTabs.Controls.Add(this.UserEditorTab);
            this.RetroFunTabs.Controls.Add(this.MakeSayTab);
            this.RetroFunTabs.Controls.Add(this.StalkingTab);
            this.RetroFunTabs.Controls.Add(this.FakeMsgTab);
            this.RetroFunTabs.Controls.Add(this.PetTab);
            this.RetroFunTabs.Controls.Add(this.DicePageTab);
            this.RetroFunTabs.Controls.Add(this.DiceBotTab);
            this.RetroFunTabs.Controls.Add(this.DiscoFunTab);
            this.RetroFunTabs.Controls.Add(this.RoomBGTab);
            this.RetroFunTabs.Controls.Add(this.CatalogBuyEditorTab);
            this.RetroFunTabs.Controls.Add(this.GiftPageTab);
            this.RetroFunTabs.Controls.Add(this.SpeechzTab);
            this.RetroFunTabs.Controls.Add(this.DoorbelTab);
            this.RetroFunTabs.Controls.Add(this.MiscellaneousTab);
            this.RetroFunTabs.DisplayBoundary = true;
            this.RetroFunTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.RetroFunTabs.IsDisplayingBorder = true;
            this.RetroFunTabs.ItemSize = new System.Drawing.Size(95, 24);
            this.RetroFunTabs.Location = new System.Drawing.Point(0, 0);
            this.RetroFunTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RetroFunTabs.Name = "RetroFunTabs";
            this.RetroFunTabs.SelectedIndex = 0;
            this.RetroFunTabs.Size = new System.Drawing.Size(1202, 666);
            this.RetroFunTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.RetroFunTabs.TabIndex = 0;
            // 
            // PersonalTab
            // 
            this.PersonalTab.Controls.Add(this.PersonalPg);
            this.PersonalTab.Location = new System.Drawing.Point(4, 28);
            this.PersonalTab.Name = "PersonalTab";
            this.PersonalTab.Size = new System.Drawing.Size(1194, 634);
            this.PersonalTab.TabIndex = 15;
            this.PersonalTab.Text = "Personal";
            this.PersonalTab.UseVisualStyleBackColor = true;
            // 
            // PersonalPg
            // 
            this.PersonalPg.BackColor = System.Drawing.Color.White;
            this.PersonalPg.CreditsChecked = false;
            this.PersonalPg.CreditsValue = 0;
            this.PersonalPg.CrystalsChecked = false;
            this.PersonalPg.CrystalsValue = 0;
            this.PersonalPg.DucketsChecked = false;
            this.PersonalPg.DucketsValue = 0;
            this.PersonalPg.HasModToolsUnlocked = false;
            this.PersonalPg.HasStaffPermissions = false;
            this.PersonalPg.Location = new System.Drawing.Point(3, 3);
            this.PersonalPg.Name = "PersonalPg";
            this.PersonalPg.Size = new System.Drawing.Size(1195, 636);
            this.PersonalPg.TabIndex = 0;
            this.PersonalPg.TabStop = false;
            this.PersonalPg.TradeSpammerCooldown = 0;
            this.PersonalPg.TradeSpammerUserID = 0;
            // 
            // UtiliesTab
            // 
            this.UtiliesTab.Controls.Add(this.UtilitiesPg);
            this.UtiliesTab.Location = new System.Drawing.Point(4, 28);
            this.UtiliesTab.Name = "UtiliesTab";
            this.UtiliesTab.Size = new System.Drawing.Size(1194, 634);
            this.UtiliesTab.TabIndex = 17;
            this.UtiliesTab.Text = "Utils";
            this.UtiliesTab.UseVisualStyleBackColor = true;
            // 
            // UtilitiesPg
            // 
            this.UtilitiesPg.BackColor = System.Drawing.Color.White;
            this.UtilitiesPg.CreditExchangeMode = false;
            this.UtilitiesPg.CreditIDInt = 1;
            this.UtilitiesPg.CreditMultiplierAmount = 1;
            this.UtilitiesPg.CreditMultiplierEnabled = false;
            this.UtilitiesPg.GiftExchangeMode = false;
            this.UtilitiesPg.GiftInt = 1;
            this.UtilitiesPg.Location = new System.Drawing.Point(8, 16);
            this.UtilitiesPg.Name = "UtilitiesPg";
            this.UtilitiesPg.Size = new System.Drawing.Size(1089, 422);
            this.UtilitiesPg.TabIndex = 0;
            this.UtilitiesPg.TabStop = false;
            // 
            // FurnitureTab
            // 
            this.FurnitureTab.Controls.Add(this.FurniPg);
            this.FurnitureTab.Location = new System.Drawing.Point(4, 28);
            this.FurnitureTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FurnitureTab.Name = "FurnitureTab";
            this.FurnitureTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FurnitureTab.Size = new System.Drawing.Size(1194, 634);
            this.FurnitureTab.TabIndex = 0;
            this.FurnitureTab.Text = "Furniture";
            this.FurnitureTab.UseVisualStyleBackColor = true;
            // 
            // FurnitureSpawnerTab
            // 
            this.FurnitureSpawnerTab.Controls.Add(this.furniSpawnPg);
            this.FurnitureSpawnerTab.Location = new System.Drawing.Point(4, 28);
            this.FurnitureSpawnerTab.Name = "FurnitureSpawnerTab";
            this.FurnitureSpawnerTab.Size = new System.Drawing.Size(1194, 634);
            this.FurnitureSpawnerTab.TabIndex = 14;
            this.FurnitureSpawnerTab.Text = "Furniture Spawner";
            this.FurnitureSpawnerTab.UseVisualStyleBackColor = true;
            // 
            // furniSpawnPg
            // 
            this.furniSpawnPg.BackColor = System.Drawing.Color.White;
            this.furniSpawnPg.CoordX = 0;
            this.furniSpawnPg.CoordY = 0;
            this.furniSpawnPg.CoordZ = 0;
            this.furniSpawnPg.FloorFurniID = 0;
            this.furniSpawnPg.FurniAmountInv = 0;
            this.furniSpawnPg.FurniOwnerName = " ";
            this.furniSpawnPg.FurniRotation = 6;
            this.furniSpawnPg.FurniType = "I";
            this.furniSpawnPg.InventoryFurniID = 0;
            this.furniSpawnPg.Location = new System.Drawing.Point(3, 0);
            this.furniSpawnPg.Name = "furniSpawnPg";
            this.furniSpawnPg.PosterID = "2005";
            this.furniSpawnPg.Size = new System.Drawing.Size(1195, 634);
            this.furniSpawnPg.SpawnFloorFurniOnClick = false;
            this.furniSpawnPg.SpawnFloorFurniOnValueChange = false;
            this.furniSpawnPg.SpawnWallFurniOnClick = false;
            this.furniSpawnPg.SpawnWallFurniOnValueChange = false;
            this.furniSpawnPg.TabIndex = 0;
            this.furniSpawnPg.TabStop = false;
            this.furniSpawnPg.Wallcoords2l = 0;
            this.furniSpawnPg.Wallcoords2w = 0;
            this.furniSpawnPg.Wallcoordsl = 0;
            this.furniSpawnPg.Wallcoordsw = 0;
            this.furniSpawnPg.WallCSRotation = "l";
            this.furniSpawnPg.WallFurniID = 0;
            this.furniSpawnPg.WallPosterID = "2005";
            // 
            // FurnitureSpamTab
            // 
            this.FurnitureSpamTab.Controls.Add(this.FurniTrollPg);
            this.FurnitureSpamTab.Location = new System.Drawing.Point(4, 28);
            this.FurnitureSpamTab.Name = "FurnitureSpamTab";
            this.FurnitureSpamTab.Size = new System.Drawing.Size(1194, 634);
            this.FurnitureSpamTab.TabIndex = 16;
            this.FurnitureSpamTab.Text = "Furniture Troll";
            this.FurnitureSpamTab.UseVisualStyleBackColor = true;
            // 
            // FurniTrollPg
            // 
            this.FurniTrollPg.BackColor = System.Drawing.Color.White;
            this.FurniTrollPg.CooldownThread1 = 150;
            this.FurniTrollPg.CooldownThread10 = 650;
            this.FurniTrollPg.CooldownThread2 = 200;
            this.FurniTrollPg.CooldownThread3 = 250;
            this.FurniTrollPg.CooldownThread4 = 300;
            this.FurniTrollPg.CooldownThread5 = 400;
            this.FurniTrollPg.CooldownThread6 = 450;
            this.FurniTrollPg.CooldownThread7 = 500;
            this.FurniTrollPg.CooldownThread8 = 550;
            this.FurniTrollPg.CooldownThread9 = 600;
            this.FurniTrollPg.FurniIDInt1 = 0;
            this.FurniTrollPg.FurniIDInt10 = 0;
            this.FurniTrollPg.FurniIDInt2 = 0;
            this.FurniTrollPg.FurniIDInt3 = 0;
            this.FurniTrollPg.FurniIDInt4 = 0;
            this.FurniTrollPg.FurniIDInt5 = 0;
            this.FurniTrollPg.FurniIDInt6 = 0;
            this.FurniTrollPg.FurniIDInt7 = 0;
            this.FurniTrollPg.FurniIDInt8 = 0;
            this.FurniTrollPg.FurniIDInt9 = 0;
            this.FurniTrollPg.GlobalCooldown = 150;
            this.FurniTrollPg.isFurniBoxChecked1 = true;
            this.FurniTrollPg.isFurniBoxChecked10 = false;
            this.FurniTrollPg.isFurniBoxChecked2 = false;
            this.FurniTrollPg.isFurniBoxChecked3 = false;
            this.FurniTrollPg.isFurniBoxChecked4 = false;
            this.FurniTrollPg.isFurniBoxChecked5 = false;
            this.FurniTrollPg.isFurniBoxChecked6 = false;
            this.FurniTrollPg.isFurniBoxChecked7 = false;
            this.FurniTrollPg.isFurniBoxChecked8 = false;
            this.FurniTrollPg.isFurniBoxChecked9 = false;
            this.FurniTrollPg.IsGlobalCooldownEnabled = false;
            this.FurniTrollPg.IsRegistrationMode = false;
            this.FurniTrollPg.Location = new System.Drawing.Point(4, 5);
            this.FurniTrollPg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FurniTrollPg.Name = "FurniTrollPg";
            this.FurniTrollPg.Size = new System.Drawing.Size(1194, 632);
            this.FurniTrollPg.StartFurniThread1 = false;
            this.FurniTrollPg.StartFurniThread10 = false;
            this.FurniTrollPg.StartFurniThread2 = false;
            this.FurniTrollPg.StartFurniThread3 = false;
            this.FurniTrollPg.StartFurniThread4 = false;
            this.FurniTrollPg.StartFurniThread5 = false;
            this.FurniTrollPg.StartFurniThread6 = false;
            this.FurniTrollPg.StartFurniThread7 = false;
            this.FurniTrollPg.StartFurniThread8 = false;
            this.FurniTrollPg.StartFurniThread9 = false;
            this.FurniTrollPg.TabIndex = 0;
            this.FurniTrollPg.TabStop = false;
            // 
            // ChatTab
            // 
            this.ChatTab.Controls.Add(this.ChatPg);
            this.ChatTab.Location = new System.Drawing.Point(4, 28);
            this.ChatTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChatTab.Name = "ChatTab";
            this.ChatTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChatTab.Size = new System.Drawing.Size(1194, 634);
            this.ChatTab.TabIndex = 1;
            this.ChatTab.Text = "Chat";
            this.ChatTab.UseVisualStyleBackColor = true;
            // 
            // UserEditorTab
            // 
            this.UserEditorTab.Controls.Add(this.UserEditorPg);
            this.UserEditorTab.Location = new System.Drawing.Point(4, 28);
            this.UserEditorTab.Name = "UserEditorTab";
            this.UserEditorTab.Size = new System.Drawing.Size(1194, 634);
            this.UserEditorTab.TabIndex = 19;
            this.UserEditorTab.Text = "User Editor";
            this.UserEditorTab.UseVisualStyleBackColor = true;
            // 
            // UserEditorPg
            // 
            this.UserEditorPg.BackColor = System.Drawing.Color.White;
            this.UserEditorPg.Location = new System.Drawing.Point(2, 0);
            this.UserEditorPg.LockLook = false;
            this.UserEditorPg.LockMotto = false;
            this.UserEditorPg.LockNickname = false;
            this.UserEditorPg.Name = "UserEditorPg";
            this.UserEditorPg.SelectedIndex = 0;
            this.UserEditorPg.Size = new System.Drawing.Size(1192, 631);
            this.UserEditorPg.TabIndex = 0;
            this.UserEditorPg.TabStop = false;
            this.UserEditorPg.UserLook = null;
            this.UserEditorPg.UserMotto = null;
            this.UserEditorPg.UserNickname = null;
            // 
            // MakeSayTab
            // 
            this.MakeSayTab.Controls.Add(this.MakeSayPg);
            this.MakeSayTab.Location = new System.Drawing.Point(4, 28);
            this.MakeSayTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MakeSayTab.Name = "MakeSayTab";
            this.MakeSayTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MakeSayTab.Size = new System.Drawing.Size(1194, 634);
            this.MakeSayTab.TabIndex = 4;
            this.MakeSayTab.Text = "MakeSay";
            this.MakeSayTab.UseVisualStyleBackColor = true;
            // 
            // StalkingTab
            // 
            this.StalkingTab.Controls.Add(this.StalkingPg);
            this.StalkingTab.Location = new System.Drawing.Point(4, 28);
            this.StalkingTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StalkingTab.Name = "StalkingTab";
            this.StalkingTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StalkingTab.Size = new System.Drawing.Size(1194, 634);
            this.StalkingTab.TabIndex = 2;
            this.StalkingTab.Text = "Stalking";
            this.StalkingTab.UseVisualStyleBackColor = true;
            // 
            // FakeMsgTab
            // 
            this.FakeMsgTab.Controls.Add(this.FakeMessagePg);
            this.FakeMsgTab.Location = new System.Drawing.Point(4, 28);
            this.FakeMsgTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FakeMsgTab.Name = "FakeMsgTab";
            this.FakeMsgTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FakeMsgTab.Size = new System.Drawing.Size(1194, 634);
            this.FakeMsgTab.TabIndex = 12;
            this.FakeMsgTab.Text = "PrivateMsg";
            this.FakeMsgTab.UseVisualStyleBackColor = true;
            // 
            // FakeMessagePg
            // 
            this.FakeMessagePg.BackColor = System.Drawing.Color.White;
            this.FakeMessagePg.Location = new System.Drawing.Point(195, 69);
            this.FakeMessagePg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FakeMessagePg.Name = "FakeMessagePg";
            this.FakeMessagePg.ShouldBlockReminders = true;
            this.FakeMessagePg.Size = new System.Drawing.Size(726, 460);
            this.FakeMessagePg.TabIndex = 0;
            this.FakeMessagePg.TabStop = false;
            this.FakeMessagePg.UserMessage = "";
            // 
            // PetTab
            // 
            this.PetTab.Controls.Add(this.PetPg);
            this.PetTab.Location = new System.Drawing.Point(4, 28);
            this.PetTab.Name = "PetTab";
            this.PetTab.Size = new System.Drawing.Size(1194, 634);
            this.PetTab.TabIndex = 18;
            this.PetTab.Text = "Pets";
            this.PetTab.UseVisualStyleBackColor = true;
            // 
            // PetPg
            // 
            this.PetPg.BackColor = System.Drawing.Color.White;
            this.PetPg.Location = new System.Drawing.Point(8, 3);
            this.PetPg.Name = "PetPg";
            this.PetPg.PageID = 0;
            this.PetPg.PetHTMLColor = null;
            this.PetPg.PetID = 0;
            this.PetPg.PetName = null;
            this.PetPg.PetRace = 0;
            this.PetPg.Size = new System.Drawing.Size(1178, 628);
            this.PetPg.TabIndex = 0;
            this.PetPg.TabStop = false;
            // 
            // DicePageTab
            // 
            this.DicePageTab.Controls.Add(this.DicePg);
            this.DicePageTab.Location = new System.Drawing.Point(4, 28);
            this.DicePageTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DicePageTab.Name = "DicePageTab";
            this.DicePageTab.Size = new System.Drawing.Size(1194, 634);
            this.DicePageTab.TabIndex = 5;
            this.DicePageTab.Text = "Dice ";
            this.DicePageTab.UseVisualStyleBackColor = true;
            // 
            // DiceBotTab
            // 
            this.DiceBotTab.Controls.Add(this.AutoHoloDicePg);
            this.DiceBotTab.Location = new System.Drawing.Point(4, 28);
            this.DiceBotTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiceBotTab.Name = "DiceBotTab";
            this.DiceBotTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiceBotTab.Size = new System.Drawing.Size(1194, 634);
            this.DiceBotTab.TabIndex = 6;
            this.DiceBotTab.Text = "Dice Bot";
            this.DiceBotTab.UseVisualStyleBackColor = true;
            // 
            // DiscoFunTab
            // 
            this.DiscoFunTab.Controls.Add(this.MoonlightPages);
            this.DiscoFunTab.Location = new System.Drawing.Point(4, 28);
            this.DiscoFunTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiscoFunTab.Name = "DiscoFunTab";
            this.DiscoFunTab.Size = new System.Drawing.Size(1194, 634);
            this.DiscoFunTab.TabIndex = 10;
            this.DiscoFunTab.Text = "Disco Fun";
            this.DiscoFunTab.UseVisualStyleBackColor = true;
            // 
            // MoonlightPages
            // 
            this.MoonlightPages.Controls.Add(this.MoonLightTab);
            this.MoonlightPages.Controls.Add(this.tabPage1);
            this.MoonlightPages.DisplayBoundary = false;
            this.MoonlightPages.ItemSize = new System.Drawing.Size(95, 24);
            this.MoonlightPages.Location = new System.Drawing.Point(-6, 5);
            this.MoonlightPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoonlightPages.Multiline = true;
            this.MoonlightPages.Name = "MoonlightPages";
            this.MoonlightPages.SelectedIndex = 0;
            this.MoonlightPages.Size = new System.Drawing.Size(1196, 612);
            this.MoonlightPages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MoonlightPages.TabIndex = 1;
            // 
            // MoonLightTab
            // 
            this.MoonLightTab.Controls.Add(this.MoonLightFunPg);
            this.MoonLightTab.Location = new System.Drawing.Point(4, 28);
            this.MoonLightTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoonLightTab.Name = "MoonLightTab";
            this.MoonLightTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoonLightTab.Size = new System.Drawing.Size(1188, 580);
            this.MoonLightTab.TabIndex = 1;
            this.MoonLightTab.Text = "MoonLight";
            this.MoonLightTab.UseVisualStyleBackColor = true;
            // 
            // MoonLightFunPg
            // 
            this.MoonLightFunPg.BackColor = System.Drawing.Color.White;
            this.MoonLightFunPg.CustomColor = null;
            this.MoonLightFunPg.Density = 79;
            this.MoonLightFunPg.JustWallpapers = false;
            this.MoonLightFunPg.LiveEditCooldown = 150;
            this.MoonLightFunPg.Location = new System.Drawing.Point(12, 5);
            this.MoonLightFunPg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MoonLightFunPg.Name = "MoonLightFunPg";
            this.MoonLightFunPg.SelectedCustom = false;
            this.MoonLightFunPg.Size = new System.Drawing.Size(1167, 558);
            this.MoonLightFunPg.TabIndex = 0;
            this.MoonLightFunPg.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DiscoRoomFunPg);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1188, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Disco";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DiscoRoomFunPg
            // 
            this.DiscoRoomFunPg.BackColor = System.Drawing.Color.White;
            this.DiscoRoomFunPg.Density = 79;
            this.DiscoRoomFunPg.DiscoCooldown = 150;
            this.DiscoRoomFunPg.FlashDensity = 79;
            this.DiscoRoomFunPg.JustWallpapers = false;
            this.DiscoRoomFunPg.Location = new System.Drawing.Point(4, 5);
            this.DiscoRoomFunPg.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DiscoRoomFunPg.Name = "DiscoRoomFunPg";
            this.DiscoRoomFunPg.SelectedBlack = false;
            this.DiscoRoomFunPg.SelectedDarkBlue = false;
            this.DiscoRoomFunPg.SelectedGreen = false;
            this.DiscoRoomFunPg.SelectedLightblue = false;
            this.DiscoRoomFunPg.SelectedPurple = false;
            this.DiscoRoomFunPg.SelectedRed = false;
            this.DiscoRoomFunPg.SelectedYellow = false;
            this.DiscoRoomFunPg.Size = new System.Drawing.Size(1179, 560);
            this.DiscoRoomFunPg.TabIndex = 0;
            this.DiscoRoomFunPg.TabStop = false;
            // 
            // RoomBGTab
            // 
            this.RoomBGTab.Controls.Add(this.RoomBackFunPg);
            this.RoomBGTab.Location = new System.Drawing.Point(4, 28);
            this.RoomBGTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomBGTab.Name = "RoomBGTab";
            this.RoomBGTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomBGTab.Size = new System.Drawing.Size(1194, 634);
            this.RoomBGTab.TabIndex = 11;
            this.RoomBGTab.Text = "Room Background";
            this.RoomBGTab.UseVisualStyleBackColor = true;
            // 
            // CatalogBuyEditorTab
            // 
            this.CatalogBuyEditorTab.Controls.Add(this.BuyFurniBruteforcerPg);
            this.CatalogBuyEditorTab.Location = new System.Drawing.Point(4, 28);
            this.CatalogBuyEditorTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatalogBuyEditorTab.Name = "CatalogBuyEditorTab";
            this.CatalogBuyEditorTab.Size = new System.Drawing.Size(1194, 634);
            this.CatalogBuyEditorTab.TabIndex = 8;
            this.CatalogBuyEditorTab.Text = "Catalog Buy Hack";
            this.CatalogBuyEditorTab.UseVisualStyleBackColor = true;
            // 
            // GiftPageTab
            // 
            this.GiftPageTab.Controls.Add(this.GiftEditorPg);
            this.GiftPageTab.Location = new System.Drawing.Point(4, 28);
            this.GiftPageTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GiftPageTab.Name = "GiftPageTab";
            this.GiftPageTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GiftPageTab.Size = new System.Drawing.Size(1194, 634);
            this.GiftPageTab.TabIndex = 7;
            this.GiftPageTab.Text = "Gifts ";
            this.GiftPageTab.UseVisualStyleBackColor = true;
            // 
            // SpeechzTab
            // 
            this.SpeechzTab.Controls.Add(this.SpeechzPg);
            this.SpeechzTab.Location = new System.Drawing.Point(4, 28);
            this.SpeechzTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpeechzTab.Name = "SpeechzTab";
            this.SpeechzTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpeechzTab.Size = new System.Drawing.Size(1194, 634);
            this.SpeechzTab.TabIndex = 9;
            this.SpeechzTab.Text = "Speechz";
            this.SpeechzTab.UseVisualStyleBackColor = true;
            // 
            // DoorbelTab
            // 
            this.DoorbelTab.Controls.Add(this.roomBypasserPage);
            this.DoorbelTab.Location = new System.Drawing.Point(4, 28);
            this.DoorbelTab.Name = "DoorbelTab";
            this.DoorbelTab.Padding = new System.Windows.Forms.Padding(3);
            this.DoorbelTab.Size = new System.Drawing.Size(1194, 634);
            this.DoorbelTab.TabIndex = 13;
            this.DoorbelTab.Text = "DoorbellBypass";
            this.DoorbelTab.UseVisualStyleBackColor = true;
            // 
            // roomBypasserPage
            // 
            this.roomBypasserPage.BackColor = System.Drawing.Color.White;
            this.roomBypasserPage.BlockBypassers = true;
            this.roomBypasserPage.Location = new System.Drawing.Point(0, 5);
            this.roomBypasserPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomBypasserPage.Name = "roomBypasserPage";
            this.roomBypasserPage.ReloadCheckbox = false;
            this.roomBypasserPage.Size = new System.Drawing.Size(1190, 624);
            this.roomBypasserPage.TabIndex = 0;
            this.roomBypasserPage.TabStop = false;
            // 
            // MiscellaneousTab
            // 
            this.MiscellaneousTab.Controls.Add(this.MiscellaneousPg);
            this.MiscellaneousTab.Location = new System.Drawing.Point(4, 28);
            this.MiscellaneousTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MiscellaneousTab.Name = "MiscellaneousTab";
            this.MiscellaneousTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MiscellaneousTab.Size = new System.Drawing.Size(1194, 634);
            this.MiscellaneousTab.TabIndex = 3;
            this.MiscellaneousTab.Text = "Miscellaneous";
            this.MiscellaneousTab.UseVisualStyleBackColor = true;
            // 
            // AlwaysOnTopChbx
            // 
            this.AlwaysOnTopChbx.AutoSize = true;
            this.AlwaysOnTopChbx.Location = new System.Drawing.Point(6, 675);
            this.AlwaysOnTopChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlwaysOnTopChbx.Name = "AlwaysOnTopChbx";
            this.AlwaysOnTopChbx.Size = new System.Drawing.Size(140, 24);
            this.AlwaysOnTopChbx.TabIndex = 0;
            this.AlwaysOnTopChbx.Text = "Always On Top";
            this.AlwaysOnTopChbx.UseVisualStyleBackColor = true;
            // 
            // BottomPg
            // 
            this.BottomPg.BackColor = System.Drawing.Color.White;
            this.BottomPg.FreezeUserMovement = false;
            this.BottomPg.Location = new System.Drawing.Point(162, 670);
            this.BottomPg.Name = "BottomPg";
            this.BottomPg.Size = new System.Drawing.Size(232, 37);
            this.BottomPg.TabIndex = 1;
            this.BottomPg.TabStop = false;
            // 
            // buyFurniBruteforcerPage1
            // 
            this.BuyFurniBruteforcerPg.BackColor = System.Drawing.Color.White;
            this.BuyFurniBruteforcerPg.CaptureModeCatalog = false;
            this.BuyFurniBruteforcerPg.EnableLoop = false;
            this.BuyFurniBruteforcerPg.FileNameLockToggle = false;
            this.BuyFurniBruteforcerPg.FileNameSave = null;
            this.BuyFurniBruteforcerPg.FurniIDint1 = 0;
            this.BuyFurniBruteforcerPg.FurniIDIntRange = 0;
            this.BuyFurniBruteforcerPg.FurniIDOptionToggle = true;
            this.BuyFurniBruteforcerPg.FurniIDRangeToggle = false;
            this.BuyFurniBruteforcerPg.GlobalSleeper = 0;
            this.BuyFurniBruteforcerPg.Location = new System.Drawing.Point(9, 17);
            this.BuyFurniBruteforcerPg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuyFurniBruteforcerPg.Name = "buyFurniBruteforcerPage1";
            this.BuyFurniBruteforcerPg.PageIDInt1 = 0;
            this.BuyFurniBruteforcerPg.PageIDIntRange = 0;
            this.BuyFurniBruteforcerPg.PageIDOptionToggle = false;
            this.BuyFurniBruteforcerPg.PageIDRangeToggle = false;
            this.BuyFurniBruteforcerPg.PurchaseSuccess = false;
            this.BuyFurniBruteforcerPg.ShowPurchase = false;
            this.BuyFurniBruteforcerPg.ShowPurchaseFurniName = true;
            this.BuyFurniBruteforcerPg.Size = new System.Drawing.Size(1181, 612);
            this.BuyFurniBruteforcerPg.SpeedTimer1 = 100;
            this.BuyFurniBruteforcerPg.TabIndex = 0;
            this.BuyFurniBruteforcerPg.TabStop = false;
            this.BuyFurniBruteforcerPg.TextBox = "";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 703);
            this.Controls.Add(this.BottomPg);
            this.Controls.Add(this.AlwaysOnTopChbx);
            this.Controls.Add(this.RetroFunTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetroFun";
            this.RetroFunTabs.ResumeLayout(false);
            this.PersonalTab.ResumeLayout(false);
            this.UtiliesTab.ResumeLayout(false);
            this.FurnitureTab.ResumeLayout(false);
            this.FurnitureSpawnerTab.ResumeLayout(false);
            this.FurnitureSpamTab.ResumeLayout(false);
            this.ChatTab.ResumeLayout(false);
            this.UserEditorTab.ResumeLayout(false);
            this.MakeSayTab.ResumeLayout(false);
            this.StalkingTab.ResumeLayout(false);
            this.FakeMsgTab.ResumeLayout(false);
            this.PetTab.ResumeLayout(false);
            this.DicePageTab.ResumeLayout(false);
            this.DiceBotTab.ResumeLayout(false);
            this.DiscoFunTab.ResumeLayout(false);
            this.MoonlightPages.ResumeLayout(false);
            this.MoonLightTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.RoomBGTab.ResumeLayout(false);
            this.CatalogBuyEditorTab.ResumeLayout(false);
            this.GiftPageTab.ResumeLayout(false);
            this.SpeechzTab.ResumeLayout(false);
            this.DoorbelTab.ResumeLayout(false);
            this.MiscellaneousTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage FurnitureTab;
        private System.Windows.Forms.TabPage ChatTab;
        private System.Windows.Forms.TabPage StalkingTab;
        private System.Windows.Forms.TabPage MiscellaneousTab;
        private System.Windows.Forms.CheckBox AlwaysOnTopChbx;
        private System.Windows.Forms.TabPage MakeSayTab;
        private System.Windows.Forms.TabPage DicePageTab;
        private System.Windows.Forms.TabPage DiceBotTab;
        private System.Windows.Forms.TabPage GiftPageTab;
        private System.Windows.Forms.TabPage CatalogBuyEditorTab;
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
        private Pages.DiceBotPage AutoHoloDicePg;
        private Pages.MiscellaneousPage MiscellaneousPg;
        private BuyFurniBruteforcerPage BuyFurniBruteforcerPg;
        private Pages.FakeMessagePage FakeMessagePg;
        private Pages.RoomBackFun RoomBackFunPg;
        private Pages.FurniSpawnPage furniSpawnPg;
        private Pages.RoomBypasserPage roomBypasserPage;
        private Pages.MoonLightFunPage MoonLightFunPg;
        private Pages.DiscoRoomLight DiscoRoomFunPg;
        private Pages.BottomPage BottomPg;
        private Pages.FurniTrollPg FurniTrollPg;
        private Pages.UtilitiesPage UtilitiesPg;
        private Pages.PetPage PetPg;
        private Pages.UserEditorPage UserEditorPg;

        private Sulakore.Components.SKoreTabControl MoonlightPages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage MoonLightTab;
        private System.Windows.Forms.TabPage FakeMsgTab;
        public Sulakore.Components.SKoreTabControl RetroFunTabs;
        private System.Windows.Forms.TabPage DoorbelTab;
        private System.Windows.Forms.TabPage FurnitureSpawnerTab;
        private System.Windows.Forms.TabPage PersonalTab;
        private System.Windows.Forms.TabPage FurnitureSpamTab;
        private System.Windows.Forms.TabPage UtiliesTab;
        private System.Windows.Forms.TabPage PetTab;
        private System.Windows.Forms.TabPage UserEditorTab;
        private PersonalPage PersonalPg;
    }
}