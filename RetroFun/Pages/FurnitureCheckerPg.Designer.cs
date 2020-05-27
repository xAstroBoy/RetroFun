namespace RetroFun.Pages
{
    partial class FurnitureChecker
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
            this.SelectRareListBtn = new Sulakore.Components.SKoreButton();
            this.FileCheckBtn = new Sulakore.Components.SKoreButton();
            this.FurniIDToCheckNbx = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckRegolarBtn = new Sulakore.Components.SKoreButton();
            this.RemoveIrregolarBtn = new Sulakore.Components.SKoreButton();
            this.AnalyzeRooMFurnisBtn = new Sulakore.Components.SKoreButton();
            this.PickRegisteredFurnisBtn = new Sulakore.Components.SKoreButton();
            this.PickUnregisteredFurniBtn = new Sulakore.Components.SKoreButton();
            this.SelectedFileLbl = new System.Windows.Forms.Label();
            this.ClearSelectedFilesBtn = new Sulakore.Components.SKoreButton();
            this.TotFurnisinroomLbl = new System.Windows.Forms.Label();
            this.FloorFurniCountLbl = new System.Windows.Forms.Label();
            this.WallFurniCountLbl = new System.Windows.Forms.Label();
            this.IrregularFurnisCountLbl = new System.Windows.Forms.Label();
            this.RegularFurnisCountLbl = new System.Windows.Forms.Label();
            this.RoomScannerGroupbox = new System.Windows.Forms.GroupBox();
            this.UnknownFurniLbl = new System.Windows.Forms.Label();
            this.CrystalsLbl = new System.Windows.Forms.Label();
            this.SilencedScannerBtn = new Sulakore.Components.SKoreButton();
            this.RaresLbl = new System.Windows.Forms.Label();
            this.CatalogueLbl = new System.Windows.Forms.Label();
            this.CreditsLbl = new System.Windows.Forms.Label();
            this.AutomaticAnalyzeBtn = new Sulakore.Components.SKoreButton();
            this.HiddenRegularFurnisLbl = new System.Windows.Forms.Label();
            this.HiddenIrregularFurnisLbl = new System.Windows.Forms.Label();
            this.WhitelistedFurniLbl = new System.Windows.Forms.Label();
            this.RemovedFloorFurnisLbl = new System.Windows.Forms.Label();
            this.RemovedWallFurnisLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshExcelListBtn = new Sulakore.Components.SKoreButton();
            this.UpdateListConstantlyBtn = new Sulakore.Components.SKoreButton();
            this.ConvertExcelSheetsToTxtBtn = new Sulakore.Components.SKoreButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearWhiteListBtn = new Sulakore.Components.SKoreButton();
            this.RemoveFalsePositivesBtn = new Sulakore.Components.SKoreButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ToggleVisibilityCreditsFurnisBtn = new Sulakore.Components.SKoreButton();
            this.ToggleVisibilityCrystalsFurnisBtn = new Sulakore.Components.SKoreButton();
            this.ToggleVisibilityCatalogFurnisBtn = new Sulakore.Components.SKoreButton();
            this.ToggleVisibilityUnregisteredRaresBtn = new Sulakore.Components.SKoreButton();
            this.ToggleVisibilityRegisteredRaresBtn = new Sulakore.Components.SKoreButton();
            this.ToggleVisibilityRemovedFurnisBtn = new Sulakore.Components.SKoreButton();
            this.LogPageFurnisBtn = new Sulakore.Components.SKoreButton();
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDToCheckNbx)).BeginInit();
            this.RoomScannerGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectRareListBtn
            // 
            this.SelectRareListBtn.Location = new System.Drawing.Point(5, 56);
            this.SelectRareListBtn.Name = "SelectRareListBtn";
            this.SelectRareListBtn.Size = new System.Drawing.Size(110, 20);
            this.SelectRareListBtn.TabIndex = 10;
            this.SelectRareListBtn.Text = "Select Rare List";
            this.SelectRareListBtn.Click += new System.EventHandler(this.SelectRareListBtn_Click);
            // 
            // FileCheckBtn
            // 
            this.FileCheckBtn.Location = new System.Drawing.Point(25, 110);
            this.FileCheckBtn.Name = "FileCheckBtn";
            this.FileCheckBtn.Size = new System.Drawing.Size(110, 20);
            this.FileCheckBtn.TabIndex = 13;
            this.FileCheckBtn.Text = "Rare Check : OFF";
            this.FileCheckBtn.Click += new System.EventHandler(this.FileCheckBtn_Click);
            // 
            // FurniIDToCheckNbx
            // 
            this.FurniIDToCheckNbx.Location = new System.Drawing.Point(25, 63);
            this.FurniIDToCheckNbx.Margin = new System.Windows.Forms.Padding(2);
            this.FurniIDToCheckNbx.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.FurniIDToCheckNbx.Name = "FurniIDToCheckNbx";
            this.FurniIDToCheckNbx.Size = new System.Drawing.Size(118, 20);
            this.FurniIDToCheckNbx.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "FurniID To Check";
            // 
            // CheckRegolarBtn
            // 
            this.CheckRegolarBtn.Location = new System.Drawing.Point(25, 25);
            this.CheckRegolarBtn.Name = "CheckRegolarBtn";
            this.CheckRegolarBtn.Size = new System.Drawing.Size(110, 20);
            this.CheckRegolarBtn.TabIndex = 17;
            this.CheckRegolarBtn.Text = "Check If Regular";
            this.CheckRegolarBtn.Click += new System.EventHandler(this.CheckRegolarBtn_Click);
            // 
            // RemoveIrregolarBtn
            // 
            this.RemoveIrregolarBtn.Location = new System.Drawing.Point(25, 140);
            this.RemoveIrregolarBtn.Name = "RemoveIrregolarBtn";
            this.RemoveIrregolarBtn.Size = new System.Drawing.Size(110, 20);
            this.RemoveIrregolarBtn.TabIndex = 18;
            this.RemoveIrregolarBtn.Text = "Remove irregular: OFF";
            this.RemoveIrregolarBtn.Click += new System.EventHandler(this.RemoveIrregolarBtn_Click);
            // 
            // AnalyzeRooMFurnisBtn
            // 
            this.AnalyzeRooMFurnisBtn.Location = new System.Drawing.Point(5, 351);
            this.AnalyzeRooMFurnisBtn.Name = "AnalyzeRooMFurnisBtn";
            this.AnalyzeRooMFurnisBtn.Size = new System.Drawing.Size(114, 20);
            this.AnalyzeRooMFurnisBtn.TabIndex = 20;
            this.AnalyzeRooMFurnisBtn.Text = "Analyze Room Furnis";
            this.AnalyzeRooMFurnisBtn.Click += new System.EventHandler(this.AnalyzeRooMFurnisBtn_Click);
            // 
            // PickRegisteredFurnisBtn
            // 
            this.PickRegisteredFurnisBtn.Location = new System.Drawing.Point(12, 46);
            this.PickRegisteredFurnisBtn.Name = "PickRegisteredFurnisBtn";
            this.PickRegisteredFurnisBtn.Size = new System.Drawing.Size(127, 18);
            this.PickRegisteredFurnisBtn.TabIndex = 21;
            this.PickRegisteredFurnisBtn.Text = "Pick Registered Rares";
            this.PickRegisteredFurnisBtn.Click += new System.EventHandler(this.PickRegisteredFurnisBtn_Click);
            // 
            // PickUnregisteredFurniBtn
            // 
            this.PickUnregisteredFurniBtn.Location = new System.Drawing.Point(12, 22);
            this.PickUnregisteredFurniBtn.Name = "PickUnregisteredFurniBtn";
            this.PickUnregisteredFurniBtn.Size = new System.Drawing.Size(127, 18);
            this.PickUnregisteredFurniBtn.TabIndex = 22;
            this.PickUnregisteredFurniBtn.Text = "Pick Unregistered Rares";
            this.PickUnregisteredFurniBtn.Click += new System.EventHandler(this.PickUnregisteredFurniBtn_Click);
            // 
            // SelectedFileLbl
            // 
            this.SelectedFileLbl.AutoSize = true;
            this.SelectedFileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileLbl.Location = new System.Drawing.Point(18, 11);
            this.SelectedFileLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedFileLbl.Name = "SelectedFileLbl";
            this.SelectedFileLbl.Size = new System.Drawing.Size(129, 25);
            this.SelectedFileLbl.TabIndex = 24;
            this.SelectedFileLbl.Text = "Total Files : 0";
            // 
            // ClearSelectedFilesBtn
            // 
            this.ClearSelectedFilesBtn.Location = new System.Drawing.Point(5, 83);
            this.ClearSelectedFilesBtn.Name = "ClearSelectedFilesBtn";
            this.ClearSelectedFilesBtn.Size = new System.Drawing.Size(110, 20);
            this.ClearSelectedFilesBtn.TabIndex = 25;
            this.ClearSelectedFilesBtn.Text = "Clear Selected Files";
            this.ClearSelectedFilesBtn.Click += new System.EventHandler(this.ClearSelectedFilesBtn_Click);
            // 
            // TotFurnisinroomLbl
            // 
            this.TotFurnisinroomLbl.AutoSize = true;
            this.TotFurnisinroomLbl.BackColor = System.Drawing.Color.White;
            this.TotFurnisinroomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotFurnisinroomLbl.Location = new System.Drawing.Point(4, 16);
            this.TotFurnisinroomLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotFurnisinroomLbl.Name = "TotFurnisinroomLbl";
            this.TotFurnisinroomLbl.Size = new System.Drawing.Size(155, 20);
            this.TotFurnisinroomLbl.TabIndex = 26;
            this.TotFurnisinroomLbl.Text = "Tot Furni In room  : 0";
            // 
            // FloorFurniCountLbl
            // 
            this.FloorFurniCountLbl.AutoSize = true;
            this.FloorFurniCountLbl.BackColor = System.Drawing.Color.White;
            this.FloorFurniCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorFurniCountLbl.Location = new System.Drawing.Point(4, 34);
            this.FloorFurniCountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FloorFurniCountLbl.Name = "FloorFurniCountLbl";
            this.FloorFurniCountLbl.Size = new System.Drawing.Size(195, 20);
            this.FloorFurniCountLbl.TabIndex = 27;
            this.FloorFurniCountLbl.Text = "Tot Floor Furni In room  : 0";
            // 
            // WallFurniCountLbl
            // 
            this.WallFurniCountLbl.AutoSize = true;
            this.WallFurniCountLbl.BackColor = System.Drawing.Color.White;
            this.WallFurniCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WallFurniCountLbl.Location = new System.Drawing.Point(4, 54);
            this.WallFurniCountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WallFurniCountLbl.Name = "WallFurniCountLbl";
            this.WallFurniCountLbl.Size = new System.Drawing.Size(181, 20);
            this.WallFurniCountLbl.TabIndex = 28;
            this.WallFurniCountLbl.Text = "Tot WallFurni In room : 0";
            // 
            // IrregularFurnisCountLbl
            // 
            this.IrregularFurnisCountLbl.AutoSize = true;
            this.IrregularFurnisCountLbl.BackColor = System.Drawing.Color.White;
            this.IrregularFurnisCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrregularFurnisCountLbl.Location = new System.Drawing.Point(4, 134);
            this.IrregularFurnisCountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IrregularFurnisCountLbl.Name = "IrregularFurnisCountLbl";
            this.IrregularFurnisCountLbl.Size = new System.Drawing.Size(164, 20);
            this.IrregularFurnisCountLbl.TabIndex = 29;
            this.IrregularFurnisCountLbl.Text = "Tot Irregular Furnis : 0";
            // 
            // RegularFurnisCountLbl
            // 
            this.RegularFurnisCountLbl.AutoSize = true;
            this.RegularFurnisCountLbl.BackColor = System.Drawing.Color.White;
            this.RegularFurnisCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegularFurnisCountLbl.Location = new System.Drawing.Point(4, 114);
            this.RegularFurnisCountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegularFurnisCountLbl.Name = "RegularFurnisCountLbl";
            this.RegularFurnisCountLbl.Size = new System.Drawing.Size(161, 20);
            this.RegularFurnisCountLbl.TabIndex = 30;
            this.RegularFurnisCountLbl.Text = "Tot Regular Furnis : 0";
            // 
            // RoomScannerGroupbox
            // 
            this.RoomScannerGroupbox.Controls.Add(this.UnknownFurniLbl);
            this.RoomScannerGroupbox.Controls.Add(this.CrystalsLbl);
            this.RoomScannerGroupbox.Controls.Add(this.SilencedScannerBtn);
            this.RoomScannerGroupbox.Controls.Add(this.RaresLbl);
            this.RoomScannerGroupbox.Controls.Add(this.CatalogueLbl);
            this.RoomScannerGroupbox.Controls.Add(this.CreditsLbl);
            this.RoomScannerGroupbox.Controls.Add(this.AutomaticAnalyzeBtn);
            this.RoomScannerGroupbox.Controls.Add(this.HiddenRegularFurnisLbl);
            this.RoomScannerGroupbox.Controls.Add(this.HiddenIrregularFurnisLbl);
            this.RoomScannerGroupbox.Controls.Add(this.WhitelistedFurniLbl);
            this.RoomScannerGroupbox.Controls.Add(this.RemovedFloorFurnisLbl);
            this.RoomScannerGroupbox.Controls.Add(this.RemovedWallFurnisLbl);
            this.RoomScannerGroupbox.Controls.Add(this.RegularFurnisCountLbl);
            this.RoomScannerGroupbox.Controls.Add(this.IrregularFurnisCountLbl);
            this.RoomScannerGroupbox.Controls.Add(this.WallFurniCountLbl);
            this.RoomScannerGroupbox.Controls.Add(this.FloorFurniCountLbl);
            this.RoomScannerGroupbox.Controls.Add(this.TotFurnisinroomLbl);
            this.RoomScannerGroupbox.Controls.Add(this.AnalyzeRooMFurnisBtn);
            this.RoomScannerGroupbox.Location = new System.Drawing.Point(552, 10);
            this.RoomScannerGroupbox.Margin = new System.Windows.Forms.Padding(2);
            this.RoomScannerGroupbox.Name = "RoomScannerGroupbox";
            this.RoomScannerGroupbox.Padding = new System.Windows.Forms.Padding(2);
            this.RoomScannerGroupbox.Size = new System.Drawing.Size(246, 376);
            this.RoomScannerGroupbox.TabIndex = 31;
            this.RoomScannerGroupbox.TabStop = false;
            this.RoomScannerGroupbox.Text = "Room Scanner";
            // 
            // UnknownFurniLbl
            // 
            this.UnknownFurniLbl.AutoSize = true;
            this.UnknownFurniLbl.BackColor = System.Drawing.Color.White;
            this.UnknownFurniLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnknownFurniLbl.Location = new System.Drawing.Point(4, 294);
            this.UnknownFurniLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UnknownFurniLbl.Name = "UnknownFurniLbl";
            this.UnknownFurniLbl.Size = new System.Drawing.Size(145, 20);
            this.UnknownFurniLbl.TabIndex = 41;
            this.UnknownFurniLbl.Text = "Unknown Furnis : 0";
            // 
            // CrystalsLbl
            // 
            this.CrystalsLbl.AutoSize = true;
            this.CrystalsLbl.BackColor = System.Drawing.Color.White;
            this.CrystalsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrystalsLbl.Location = new System.Drawing.Point(4, 234);
            this.CrystalsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CrystalsLbl.Name = "CrystalsLbl";
            this.CrystalsLbl.Size = new System.Drawing.Size(86, 20);
            this.CrystalsLbl.TabIndex = 40;
            this.CrystalsLbl.Text = "Crystals : 0";
            // 
            // SilencedScannerBtn
            // 
            this.SilencedScannerBtn.Location = new System.Drawing.Point(125, 325);
            this.SilencedScannerBtn.Name = "SilencedScannerBtn";
            this.SilencedScannerBtn.Size = new System.Drawing.Size(110, 20);
            this.SilencedScannerBtn.TabIndex = 37;
            this.SilencedScannerBtn.Text = "Silenced : OFF";
            this.SilencedScannerBtn.Click += new System.EventHandler(this.SilencedScannerBtn_Click);
            // 
            // RaresLbl
            // 
            this.RaresLbl.AutoSize = true;
            this.RaresLbl.BackColor = System.Drawing.Color.White;
            this.RaresLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaresLbl.Location = new System.Drawing.Point(4, 274);
            this.RaresLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RaresLbl.Name = "RaresLbl";
            this.RaresLbl.Size = new System.Drawing.Size(73, 20);
            this.RaresLbl.TabIndex = 39;
            this.RaresLbl.Text = "Rares : 0";
            // 
            // CatalogueLbl
            // 
            this.CatalogueLbl.AutoSize = true;
            this.CatalogueLbl.BackColor = System.Drawing.Color.White;
            this.CatalogueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatalogueLbl.Location = new System.Drawing.Point(4, 254);
            this.CatalogueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CatalogueLbl.Name = "CatalogueLbl";
            this.CatalogueLbl.Size = new System.Drawing.Size(103, 20);
            this.CatalogueLbl.TabIndex = 38;
            this.CatalogueLbl.Text = "Catalogue : 0";
            // 
            // CreditsLbl
            // 
            this.CreditsLbl.AutoSize = true;
            this.CreditsLbl.BackColor = System.Drawing.Color.White;
            this.CreditsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsLbl.Location = new System.Drawing.Point(4, 214);
            this.CreditsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreditsLbl.Name = "CreditsLbl";
            this.CreditsLbl.Size = new System.Drawing.Size(80, 20);
            this.CreditsLbl.TabIndex = 37;
            this.CreditsLbl.Text = "Credits : 0";
            // 
            // AutomaticAnalyzeBtn
            // 
            this.AutomaticAnalyzeBtn.Location = new System.Drawing.Point(125, 351);
            this.AutomaticAnalyzeBtn.Name = "AutomaticAnalyzeBtn";
            this.AutomaticAnalyzeBtn.Size = new System.Drawing.Size(110, 20);
            this.AutomaticAnalyzeBtn.TabIndex = 36;
            this.AutomaticAnalyzeBtn.Text = "Automatic Scan : ON";
            this.AutomaticAnalyzeBtn.Click += new System.EventHandler(this.AutomaticAnalyzeBtn_Click);
            // 
            // HiddenRegularFurnisLbl
            // 
            this.HiddenRegularFurnisLbl.AutoSize = true;
            this.HiddenRegularFurnisLbl.BackColor = System.Drawing.Color.White;
            this.HiddenRegularFurnisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiddenRegularFurnisLbl.Location = new System.Drawing.Point(4, 174);
            this.HiddenRegularFurnisLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HiddenRegularFurnisLbl.Name = "HiddenRegularFurnisLbl";
            this.HiddenRegularFurnisLbl.Size = new System.Drawing.Size(189, 20);
            this.HiddenRegularFurnisLbl.TabIndex = 35;
            this.HiddenRegularFurnisLbl.Text = "Hidden Regular Furnis : 0";
            // 
            // HiddenIrregularFurnisLbl
            // 
            this.HiddenIrregularFurnisLbl.AutoSize = true;
            this.HiddenIrregularFurnisLbl.BackColor = System.Drawing.Color.White;
            this.HiddenIrregularFurnisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiddenIrregularFurnisLbl.Location = new System.Drawing.Point(4, 154);
            this.HiddenIrregularFurnisLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HiddenIrregularFurnisLbl.Name = "HiddenIrregularFurnisLbl";
            this.HiddenIrregularFurnisLbl.Size = new System.Drawing.Size(192, 20);
            this.HiddenIrregularFurnisLbl.TabIndex = 34;
            this.HiddenIrregularFurnisLbl.Text = "Hidden Irregular Furnis : 0";
            // 
            // WhitelistedFurniLbl
            // 
            this.WhitelistedFurniLbl.AutoSize = true;
            this.WhitelistedFurniLbl.BackColor = System.Drawing.Color.White;
            this.WhitelistedFurniLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhitelistedFurniLbl.Location = new System.Drawing.Point(4, 194);
            this.WhitelistedFurniLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WhitelistedFurniLbl.Name = "WhitelistedFurniLbl";
            this.WhitelistedFurniLbl.Size = new System.Drawing.Size(156, 20);
            this.WhitelistedFurniLbl.TabIndex = 33;
            this.WhitelistedFurniLbl.Text = "Whitelisted Furnis : 0";
            // 
            // RemovedFloorFurnisLbl
            // 
            this.RemovedFloorFurnisLbl.AutoSize = true;
            this.RemovedFloorFurnisLbl.BackColor = System.Drawing.Color.White;
            this.RemovedFloorFurnisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovedFloorFurnisLbl.Location = new System.Drawing.Point(4, 94);
            this.RemovedFloorFurnisLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemovedFloorFurnisLbl.Name = "RemovedFloorFurnisLbl";
            this.RemovedFloorFurnisLbl.Size = new System.Drawing.Size(186, 20);
            this.RemovedFloorFurnisLbl.TabIndex = 32;
            this.RemovedFloorFurnisLbl.Text = "Removed Floor Furnis : 0";
            // 
            // RemovedWallFurnisLbl
            // 
            this.RemovedWallFurnisLbl.AutoSize = true;
            this.RemovedWallFurnisLbl.BackColor = System.Drawing.Color.White;
            this.RemovedWallFurnisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovedWallFurnisLbl.Location = new System.Drawing.Point(4, 74);
            this.RemovedWallFurnisLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemovedWallFurnisLbl.Name = "RemovedWallFurnisLbl";
            this.RemovedWallFurnisLbl.Size = new System.Drawing.Size(176, 20);
            this.RemovedWallFurnisLbl.TabIndex = 31;
            this.RemovedWallFurnisLbl.Text = "Removed WallFurnis : 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshExcelListBtn);
            this.groupBox1.Controls.Add(this.UpdateListConstantlyBtn);
            this.groupBox1.Controls.Add(this.ConvertExcelSheetsToTxtBtn);
            this.groupBox1.Controls.Add(this.ClearSelectedFilesBtn);
            this.groupBox1.Controls.Add(this.SelectedFileLbl);
            this.groupBox1.Controls.Add(this.SelectRareListBtn);
            this.groupBox1.Location = new System.Drawing.Point(191, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(239, 101);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // RefreshExcelListBtn
            // 
            this.RefreshExcelListBtn.Enabled = false;
            this.RefreshExcelListBtn.Location = new System.Drawing.Point(5, 136);
            this.RefreshExcelListBtn.Name = "RefreshExcelListBtn";
            this.RefreshExcelListBtn.Size = new System.Drawing.Size(149, 20);
            this.RefreshExcelListBtn.TabIndex = 28;
            this.RefreshExcelListBtn.Text = "Refresh Excel List";
            this.RefreshExcelListBtn.Visible = false;
            this.RefreshExcelListBtn.Click += new System.EventHandler(this.RefreshExcelListBtn_Click);
            // 
            // UpdateListConstantlyBtn
            // 
            this.UpdateListConstantlyBtn.Enabled = false;
            this.UpdateListConstantlyBtn.Location = new System.Drawing.Point(4, 109);
            this.UpdateListConstantlyBtn.Name = "UpdateListConstantlyBtn";
            this.UpdateListConstantlyBtn.Size = new System.Drawing.Size(149, 20);
            this.UpdateListConstantlyBtn.TabIndex = 27;
            this.UpdateListConstantlyBtn.Text = "Update List Constantly : OFF";
            this.UpdateListConstantlyBtn.Visible = false;
            this.UpdateListConstantlyBtn.Click += new System.EventHandler(this.UpdateListConstantlyBtn_Click);
            // 
            // ConvertExcelSheetsToTxtBtn
            // 
            this.ConvertExcelSheetsToTxtBtn.Location = new System.Drawing.Point(125, 57);
            this.ConvertExcelSheetsToTxtBtn.Name = "ConvertExcelSheetsToTxtBtn";
            this.ConvertExcelSheetsToTxtBtn.Size = new System.Drawing.Size(110, 20);
            this.ConvertExcelSheetsToTxtBtn.TabIndex = 26;
            this.ConvertExcelSheetsToTxtBtn.Text = "Convert Excel to txt";
            this.ConvertExcelSheetsToTxtBtn.Click += new System.EventHandler(this.ConvertExcelSheetsToTxtBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearWhiteListBtn);
            this.groupBox2.Controls.Add(this.RemoveFalsePositivesBtn);
            this.groupBox2.Controls.Add(this.RemoveIrregolarBtn);
            this.groupBox2.Controls.Add(this.CheckRegolarBtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.FurniIDToCheckNbx);
            this.groupBox2.Controls.Add(this.FileCheckBtn);
            this.groupBox2.Location = new System.Drawing.Point(13, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(166, 240);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rare Check (MANUAL)";
            // 
            // ClearWhiteListBtn
            // 
            this.ClearWhiteListBtn.Location = new System.Drawing.Point(25, 204);
            this.ClearWhiteListBtn.Name = "ClearWhiteListBtn";
            this.ClearWhiteListBtn.Size = new System.Drawing.Size(123, 20);
            this.ClearWhiteListBtn.TabIndex = 20;
            this.ClearWhiteListBtn.Text = "Reset False positives";
            this.ClearWhiteListBtn.Click += new System.EventHandler(this.ClearWhiteListBtn_click);
            // 
            // RemoveFalsePositivesBtn
            // 
            this.RemoveFalsePositivesBtn.Location = new System.Drawing.Point(9, 177);
            this.RemoveFalsePositivesBtn.Name = "RemoveFalsePositivesBtn";
            this.RemoveFalsePositivesBtn.Size = new System.Drawing.Size(153, 20);
            this.RemoveFalsePositivesBtn.TabIndex = 19;
            this.RemoveFalsePositivesBtn.Text = "Mark False Positives : OFF";
            this.RemoveFalsePositivesBtn.Click += new System.EventHandler(this.RemoveFalsePositivesBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PickUnregisteredFurniBtn);
            this.groupBox4.Controls.Add(this.PickRegisteredFurnisBtn);
            this.groupBox4.Location = new System.Drawing.Point(13, 264);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(157, 82);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Furni Picker ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ToggleVisibilityCreditsFurnisBtn);
            this.groupBox3.Controls.Add(this.ToggleVisibilityCrystalsFurnisBtn);
            this.groupBox3.Controls.Add(this.ToggleVisibilityCatalogFurnisBtn);
            this.groupBox3.Controls.Add(this.ToggleVisibilityUnregisteredRaresBtn);
            this.groupBox3.Controls.Add(this.ToggleVisibilityRegisteredRaresBtn);
            this.groupBox3.Controls.Add(this.ToggleVisibilityRemovedFurnisBtn);
            this.groupBox3.Location = new System.Drawing.Point(196, 119);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(332, 100);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Furni Hider  / Unhider";
            // 
            // ToggleVisibilityCreditsFurnisBtn
            // 
            this.ToggleVisibilityCreditsFurnisBtn.Location = new System.Drawing.Point(8, 73);
            this.ToggleVisibilityCreditsFurnisBtn.Name = "ToggleVisibilityCreditsFurnisBtn";
            this.ToggleVisibilityCreditsFurnisBtn.Size = new System.Drawing.Size(129, 18);
            this.ToggleVisibilityCreditsFurnisBtn.TabIndex = 31;
            this.ToggleVisibilityCreditsFurnisBtn.Text = "Hide Credits Furnis ";
            this.ToggleVisibilityCreditsFurnisBtn.Click += new System.EventHandler(this.ToggleVisibilityCreditsFurnisBtn_Click);
            // 
            // ToggleVisibilityCrystalsFurnisBtn
            // 
            this.ToggleVisibilityCrystalsFurnisBtn.Location = new System.Drawing.Point(158, 49);
            this.ToggleVisibilityCrystalsFurnisBtn.Name = "ToggleVisibilityCrystalsFurnisBtn";
            this.ToggleVisibilityCrystalsFurnisBtn.Size = new System.Drawing.Size(129, 18);
            this.ToggleVisibilityCrystalsFurnisBtn.TabIndex = 29;
            this.ToggleVisibilityCrystalsFurnisBtn.Text = "Hide Crystals Furnis ";
            this.ToggleVisibilityCrystalsFurnisBtn.Click += new System.EventHandler(this.ToggleVisibilityCrystalsFurnisBtn_Click);
            // 
            // ToggleVisibilityCatalogFurnisBtn
            // 
            this.ToggleVisibilityCatalogFurnisBtn.Location = new System.Drawing.Point(8, 49);
            this.ToggleVisibilityCatalogFurnisBtn.Name = "ToggleVisibilityCatalogFurnisBtn";
            this.ToggleVisibilityCatalogFurnisBtn.Size = new System.Drawing.Size(129, 18);
            this.ToggleVisibilityCatalogFurnisBtn.TabIndex = 27;
            this.ToggleVisibilityCatalogFurnisBtn.Text = "Hide Catalogue Furnis";
            this.ToggleVisibilityCatalogFurnisBtn.Click += new System.EventHandler(this.ToggleVisibilityCatalogFurnisBtn_Click);
            // 
            // ToggleVisibilityUnregisteredRaresBtn
            // 
            this.ToggleVisibilityUnregisteredRaresBtn.Location = new System.Drawing.Point(158, 25);
            this.ToggleVisibilityUnregisteredRaresBtn.Name = "ToggleVisibilityUnregisteredRaresBtn";
            this.ToggleVisibilityUnregisteredRaresBtn.Size = new System.Drawing.Size(129, 18);
            this.ToggleVisibilityUnregisteredRaresBtn.TabIndex = 26;
            this.ToggleVisibilityUnregisteredRaresBtn.Text = "Hide Unregistered Rares";
            this.ToggleVisibilityUnregisteredRaresBtn.Click += new System.EventHandler(this.ToggleUnregisteredFurnituresVisibility_Click);
            // 
            // ToggleVisibilityRegisteredRaresBtn
            // 
            this.ToggleVisibilityRegisteredRaresBtn.Location = new System.Drawing.Point(8, 25);
            this.ToggleVisibilityRegisteredRaresBtn.Name = "ToggleVisibilityRegisteredRaresBtn";
            this.ToggleVisibilityRegisteredRaresBtn.Size = new System.Drawing.Size(129, 18);
            this.ToggleVisibilityRegisteredRaresBtn.TabIndex = 25;
            this.ToggleVisibilityRegisteredRaresBtn.Text = "Hide Registered Rares";
            this.ToggleVisibilityRegisteredRaresBtn.Click += new System.EventHandler(this.ToggleRegisteredFurnituresVisibility_Click);
            // 
            // ToggleVisibilityRemovedFurnisBtn
            // 
            this.ToggleVisibilityRemovedFurnisBtn.Location = new System.Drawing.Point(158, 73);
            this.ToggleVisibilityRemovedFurnisBtn.Name = "ToggleVisibilityRemovedFurnisBtn";
            this.ToggleVisibilityRemovedFurnisBtn.Size = new System.Drawing.Size(129, 18);
            this.ToggleVisibilityRemovedFurnisBtn.TabIndex = 23;
            this.ToggleVisibilityRemovedFurnisBtn.Text = "Show Removed Furnis";
            this.ToggleVisibilityRemovedFurnisBtn.Click += new System.EventHandler(this.ToggleVisibilityRemovedFurnisBtn_Click);
            // 
            // LogPageFurnisBtn
            // 
            this.LogPageFurnisBtn.Location = new System.Drawing.Point(196, 228);
            this.LogPageFurnisBtn.Name = "LogPageFurnisBtn";
            this.LogPageFurnisBtn.Size = new System.Drawing.Size(157, 18);
            this.LogPageFurnisBtn.TabIndex = 23;
            this.LogPageFurnisBtn.Text = "Catalog Page Furni Logger : OFF";
            this.LogPageFurnisBtn.Click += new System.EventHandler(this.LogPageFurnisBtn_Click);
            // 
            // FurnitureChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogPageFurnisBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomScannerGroupbox);
            this.Name = "FurnitureChecker";
            this.Size = new System.Drawing.Size(823, 404);
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDToCheckNbx)).EndInit();
            this.RoomScannerGroupbox.ResumeLayout(false);
            this.RoomScannerGroupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sulakore.Components.SKoreButton SelectRareListBtn;
        private Sulakore.Components.SKoreButton FileCheckBtn;
        private System.Windows.Forms.NumericUpDown FurniIDToCheckNbx;
        private System.Windows.Forms.Label label4;
        private Sulakore.Components.SKoreButton CheckRegolarBtn;
        private Sulakore.Components.SKoreButton RemoveIrregolarBtn;
        private Sulakore.Components.SKoreButton AnalyzeRooMFurnisBtn;
        private Sulakore.Components.SKoreButton PickRegisteredFurnisBtn;
        private Sulakore.Components.SKoreButton PickUnregisteredFurniBtn;
        private System.Windows.Forms.Label SelectedFileLbl;
        private Sulakore.Components.SKoreButton ClearSelectedFilesBtn;
        private System.Windows.Forms.Label TotFurnisinroomLbl;
        private System.Windows.Forms.Label FloorFurniCountLbl;
        private System.Windows.Forms.Label WallFurniCountLbl;
        private System.Windows.Forms.Label IrregularFurnisCountLbl;
        private System.Windows.Forms.Label RegularFurnisCountLbl;
        private System.Windows.Forms.GroupBox RoomScannerGroupbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sulakore.Components.SKoreButton ConvertExcelSheetsToTxtBtn;
        private System.Windows.Forms.Label RemovedFloorFurnisLbl;
        private System.Windows.Forms.Label RemovedWallFurnisLbl;
        private Sulakore.Components.SKoreButton UpdateListConstantlyBtn;
        private Sulakore.Components.SKoreButton RefreshExcelListBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private Sulakore.Components.SKoreButton RemoveFalsePositivesBtn;
        private Sulakore.Components.SKoreButton ClearWhiteListBtn;
        private System.Windows.Forms.Label WhitelistedFurniLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label HiddenRegularFurnisLbl;
        private System.Windows.Forms.Label HiddenIrregularFurnisLbl;
        private Sulakore.Components.SKoreButton ToggleVisibilityRemovedFurnisBtn;
        private Sulakore.Components.SKoreButton AutomaticAnalyzeBtn;
        private Sulakore.Components.SKoreButton ToggleVisibilityUnregisteredRaresBtn;
        private Sulakore.Components.SKoreButton ToggleVisibilityRegisteredRaresBtn;
        private Sulakore.Components.SKoreButton SilencedScannerBtn;
        private Sulakore.Components.SKoreButton LogPageFurnisBtn;
        private System.Windows.Forms.Label RaresLbl;
        private System.Windows.Forms.Label CatalogueLbl;
        private System.Windows.Forms.Label CreditsLbl;
        private System.Windows.Forms.Label CrystalsLbl;
        private Sulakore.Components.SKoreButton ToggleVisibilityCatalogFurnisBtn;
        private Sulakore.Components.SKoreButton ToggleVisibilityCrystalsFurnisBtn;
        private System.Windows.Forms.Label UnknownFurniLbl;
        private Sulakore.Components.SKoreButton ToggleVisibilityCreditsFurnisBtn;
    }
}