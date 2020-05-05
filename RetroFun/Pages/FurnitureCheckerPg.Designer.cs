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
            this.RemovedFloorFurnisLbl = new System.Windows.Forms.Label();
            this.RemovedWallFurnisLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshExcelListBtn = new Sulakore.Components.SKoreButton();
            this.UpdateListConstantlyBtn = new Sulakore.Components.SKoreButton();
            this.ConvertExcelSheetsToTxtBtn = new Sulakore.Components.SKoreButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDToCheckNbx)).BeginInit();
            this.RoomScannerGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectRareListBtn
            // 
            this.SelectRareListBtn.Location = new System.Drawing.Point(7, 86);
            this.SelectRareListBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectRareListBtn.Name = "SelectRareListBtn";
            this.SelectRareListBtn.Size = new System.Drawing.Size(165, 31);
            this.SelectRareListBtn.TabIndex = 10;
            this.SelectRareListBtn.Text = "Select Rare List";
            this.SelectRareListBtn.Click += new System.EventHandler(this.SelectRareListBtn_Click);
            // 
            // FileCheckBtn
            // 
            this.FileCheckBtn.Location = new System.Drawing.Point(37, 169);
            this.FileCheckBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileCheckBtn.Name = "FileCheckBtn";
            this.FileCheckBtn.Size = new System.Drawing.Size(165, 31);
            this.FileCheckBtn.TabIndex = 13;
            this.FileCheckBtn.Text = "Rare Check : OFF";
            this.FileCheckBtn.Click += new System.EventHandler(this.FileCheckBtn_Click);
            // 
            // FurniIDToCheckNbx
            // 
            this.FurniIDToCheckNbx.Location = new System.Drawing.Point(37, 97);
            this.FurniIDToCheckNbx.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.FurniIDToCheckNbx.Name = "FurniIDToCheckNbx";
            this.FurniIDToCheckNbx.Size = new System.Drawing.Size(177, 26);
            this.FurniIDToCheckNbx.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "FurniID To Check";
            // 
            // CheckRegolarBtn
            // 
            this.CheckRegolarBtn.Location = new System.Drawing.Point(37, 38);
            this.CheckRegolarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckRegolarBtn.Name = "CheckRegolarBtn";
            this.CheckRegolarBtn.Size = new System.Drawing.Size(165, 31);
            this.CheckRegolarBtn.TabIndex = 17;
            this.CheckRegolarBtn.Text = "Check If Regular";
            this.CheckRegolarBtn.Click += new System.EventHandler(this.CheckRegolarBtn_Click);
            // 
            // RemoveIrregolarBtn
            // 
            this.RemoveIrregolarBtn.Location = new System.Drawing.Point(37, 210);
            this.RemoveIrregolarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveIrregolarBtn.Name = "RemoveIrregolarBtn";
            this.RemoveIrregolarBtn.Size = new System.Drawing.Size(165, 31);
            this.RemoveIrregolarBtn.TabIndex = 18;
            this.RemoveIrregolarBtn.Text = "Remove irregular: OFF";
            this.RemoveIrregolarBtn.Click += new System.EventHandler(this.RemoveIrregolarBtn_Click);
            // 
            // AnalyzeRooMFurnisBtn
            // 
            this.AnalyzeRooMFurnisBtn.Location = new System.Drawing.Point(18, 418);
            this.AnalyzeRooMFurnisBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnalyzeRooMFurnisBtn.Name = "AnalyzeRooMFurnisBtn";
            this.AnalyzeRooMFurnisBtn.Size = new System.Drawing.Size(165, 31);
            this.AnalyzeRooMFurnisBtn.TabIndex = 20;
            this.AnalyzeRooMFurnisBtn.Text = "Analyze Room Furnis";
            this.AnalyzeRooMFurnisBtn.Click += new System.EventHandler(this.AnalyzeRooMFurnisBtn_Click);
            // 
            // PickRegisteredFurnisBtn
            // 
            this.PickRegisteredFurnisBtn.Location = new System.Drawing.Point(219, 455);
            this.PickRegisteredFurnisBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PickRegisteredFurnisBtn.Name = "PickRegisteredFurnisBtn";
            this.PickRegisteredFurnisBtn.Size = new System.Drawing.Size(191, 27);
            this.PickRegisteredFurnisBtn.TabIndex = 21;
            this.PickRegisteredFurnisBtn.Text = "Pick Registered Furnis";
            this.PickRegisteredFurnisBtn.Click += new System.EventHandler(this.PickRegisteredFurnisBtn_Click);
            // 
            // PickUnregisteredFurniBtn
            // 
            this.PickUnregisteredFurniBtn.Location = new System.Drawing.Point(219, 418);
            this.PickUnregisteredFurniBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PickUnregisteredFurniBtn.Name = "PickUnregisteredFurniBtn";
            this.PickUnregisteredFurniBtn.Size = new System.Drawing.Size(191, 27);
            this.PickUnregisteredFurniBtn.TabIndex = 22;
            this.PickUnregisteredFurniBtn.Text = "Pick Unregistered Furnis";
            this.PickUnregisteredFurniBtn.Click += new System.EventHandler(this.PickUnregisteredFurniBtn_Click);
            // 
            // SelectedFileLbl
            // 
            this.SelectedFileLbl.AutoSize = true;
            this.SelectedFileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileLbl.Location = new System.Drawing.Point(27, 17);
            this.SelectedFileLbl.Name = "SelectedFileLbl";
            this.SelectedFileLbl.Size = new System.Drawing.Size(193, 36);
            this.SelectedFileLbl.TabIndex = 24;
            this.SelectedFileLbl.Text = "Total Files : 0";
            // 
            // ClearSelectedFilesBtn
            // 
            this.ClearSelectedFilesBtn.Location = new System.Drawing.Point(7, 127);
            this.ClearSelectedFilesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearSelectedFilesBtn.Name = "ClearSelectedFilesBtn";
            this.ClearSelectedFilesBtn.Size = new System.Drawing.Size(165, 31);
            this.ClearSelectedFilesBtn.TabIndex = 25;
            this.ClearSelectedFilesBtn.Text = "Clear Selected Files";
            this.ClearSelectedFilesBtn.Click += new System.EventHandler(this.ClearSelectedFilesBtn_Click);
            // 
            // TotFurnisinroomLbl
            // 
            this.TotFurnisinroomLbl.AutoSize = true;
            this.TotFurnisinroomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotFurnisinroomLbl.Location = new System.Drawing.Point(12, 17);
            this.TotFurnisinroomLbl.Name = "TotFurnisinroomLbl";
            this.TotFurnisinroomLbl.Size = new System.Drawing.Size(292, 36);
            this.TotFurnisinroomLbl.TabIndex = 26;
            this.TotFurnisinroomLbl.Text = "Tot Furni In room  : 0";
            // 
            // FloorFurniCountLbl
            // 
            this.FloorFurniCountLbl.AutoSize = true;
            this.FloorFurniCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorFurniCountLbl.Location = new System.Drawing.Point(12, 70);
            this.FloorFurniCountLbl.Name = "FloorFurniCountLbl";
            this.FloorFurniCountLbl.Size = new System.Drawing.Size(369, 36);
            this.FloorFurniCountLbl.TabIndex = 27;
            this.FloorFurniCountLbl.Text = "Tot Floor Furni In room  : 0";
            // 
            // WallFurniCountLbl
            // 
            this.WallFurniCountLbl.AutoSize = true;
            this.WallFurniCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WallFurniCountLbl.Location = new System.Drawing.Point(12, 131);
            this.WallFurniCountLbl.Name = "WallFurniCountLbl";
            this.WallFurniCountLbl.Size = new System.Drawing.Size(343, 36);
            this.WallFurniCountLbl.TabIndex = 28;
            this.WallFurniCountLbl.Text = "Tot WallFurni In room : 0";
            // 
            // IrregularFurnisCountLbl
            // 
            this.IrregularFurnisCountLbl.AutoSize = true;
            this.IrregularFurnisCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrregularFurnisCountLbl.Location = new System.Drawing.Point(12, 186);
            this.IrregularFurnisCountLbl.Name = "IrregularFurnisCountLbl";
            this.IrregularFurnisCountLbl.Size = new System.Drawing.Size(310, 36);
            this.IrregularFurnisCountLbl.TabIndex = 29;
            this.IrregularFurnisCountLbl.Text = "Tot Irregular Furnis : 0";
            // 
            // RegularFurnisCountLbl
            // 
            this.RegularFurnisCountLbl.AutoSize = true;
            this.RegularFurnisCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegularFurnisCountLbl.Location = new System.Drawing.Point(12, 241);
            this.RegularFurnisCountLbl.Name = "RegularFurnisCountLbl";
            this.RegularFurnisCountLbl.Size = new System.Drawing.Size(304, 36);
            this.RegularFurnisCountLbl.TabIndex = 30;
            this.RegularFurnisCountLbl.Text = "Tot Regular Furnis : 0";
            // 
            // RoomScannerGroupbox
            // 
            this.RoomScannerGroupbox.Controls.Add(this.RemovedFloorFurnisLbl);
            this.RoomScannerGroupbox.Controls.Add(this.RemovedWallFurnisLbl);
            this.RoomScannerGroupbox.Controls.Add(this.RegularFurnisCountLbl);
            this.RoomScannerGroupbox.Controls.Add(this.IrregularFurnisCountLbl);
            this.RoomScannerGroupbox.Controls.Add(this.PickRegisteredFurnisBtn);
            this.RoomScannerGroupbox.Controls.Add(this.PickUnregisteredFurniBtn);
            this.RoomScannerGroupbox.Controls.Add(this.WallFurniCountLbl);
            this.RoomScannerGroupbox.Controls.Add(this.FloorFurniCountLbl);
            this.RoomScannerGroupbox.Controls.Add(this.TotFurnisinroomLbl);
            this.RoomScannerGroupbox.Controls.Add(this.AnalyzeRooMFurnisBtn);
            this.RoomScannerGroupbox.Location = new System.Drawing.Point(662, 10);
            this.RoomScannerGroupbox.Name = "RoomScannerGroupbox";
            this.RoomScannerGroupbox.Size = new System.Drawing.Size(648, 487);
            this.RoomScannerGroupbox.TabIndex = 31;
            this.RoomScannerGroupbox.TabStop = false;
            this.RoomScannerGroupbox.Text = "Room Scanner";
            // 
            // RemovedFloorFurnisLbl
            // 
            this.RemovedFloorFurnisLbl.AutoSize = true;
            this.RemovedFloorFurnisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovedFloorFurnisLbl.Location = new System.Drawing.Point(12, 354);
            this.RemovedFloorFurnisLbl.Name = "RemovedFloorFurnisLbl";
            this.RemovedFloorFurnisLbl.Size = new System.Drawing.Size(351, 36);
            this.RemovedFloorFurnisLbl.TabIndex = 32;
            this.RemovedFloorFurnisLbl.Text = "Removed Floor Furnis : 0";
            // 
            // RemovedWallFurnisLbl
            // 
            this.RemovedWallFurnisLbl.AutoSize = true;
            this.RemovedWallFurnisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovedWallFurnisLbl.Location = new System.Drawing.Point(12, 301);
            this.RemovedWallFurnisLbl.Name = "RemovedWallFurnisLbl";
            this.RemovedWallFurnisLbl.Size = new System.Drawing.Size(333, 36);
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
            this.groupBox1.Location = new System.Drawing.Point(287, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 260);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // RefreshExcelListBtn
            // 
            this.RefreshExcelListBtn.Enabled = false;
            this.RefreshExcelListBtn.Location = new System.Drawing.Point(7, 209);
            this.RefreshExcelListBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshExcelListBtn.Name = "RefreshExcelListBtn";
            this.RefreshExcelListBtn.Size = new System.Drawing.Size(223, 31);
            this.RefreshExcelListBtn.TabIndex = 28;
            this.RefreshExcelListBtn.Text = "Refresh Excel List";
            this.RefreshExcelListBtn.Visible = false;
            this.RefreshExcelListBtn.Click += new System.EventHandler(this.RefreshExcelListBtn_Click);
            // 
            // UpdateListConstantlyBtn
            // 
            this.UpdateListConstantlyBtn.Enabled = false;
            this.UpdateListConstantlyBtn.Location = new System.Drawing.Point(7, 168);
            this.UpdateListConstantlyBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateListConstantlyBtn.Name = "UpdateListConstantlyBtn";
            this.UpdateListConstantlyBtn.Size = new System.Drawing.Size(223, 31);
            this.UpdateListConstantlyBtn.TabIndex = 27;
            this.UpdateListConstantlyBtn.Text = "Update List Constantly : OFF";
            this.UpdateListConstantlyBtn.Visible = false;
            this.UpdateListConstantlyBtn.Click += new System.EventHandler(this.UpdateListConstantlyBtn_Click);
            // 
            // ConvertExcelSheetsToTxtBtn
            // 
            this.ConvertExcelSheetsToTxtBtn.Location = new System.Drawing.Point(187, 87);
            this.ConvertExcelSheetsToTxtBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConvertExcelSheetsToTxtBtn.Name = "ConvertExcelSheetsToTxtBtn";
            this.ConvertExcelSheetsToTxtBtn.Size = new System.Drawing.Size(165, 31);
            this.ConvertExcelSheetsToTxtBtn.TabIndex = 26;
            this.ConvertExcelSheetsToTxtBtn.Text = "Convert Excel to txt";
            this.ConvertExcelSheetsToTxtBtn.Click += new System.EventHandler(this.ConvertExcelSheetsToTxtBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveIrregolarBtn);
            this.groupBox2.Controls.Add(this.CheckRegolarBtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.FurniIDToCheckNbx);
            this.groupBox2.Controls.Add(this.FileCheckBtn);
            this.groupBox2.Location = new System.Drawing.Point(20, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 279);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rare Check (MANUAL)";
            // 
            // FurnitureChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomScannerGroupbox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FurnitureChecker";
            this.Size = new System.Drawing.Size(1310, 567);
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDToCheckNbx)).EndInit();
            this.RoomScannerGroupbox.ResumeLayout(false);
            this.RoomScannerGroupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}