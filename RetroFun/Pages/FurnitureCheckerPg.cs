using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
using Sulakore.Protocol;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Sulakore.Habbo;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using Label = System.Windows.Forms.Label;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Timers;
using RetroFun.Helpers;
using RetroFun.Utils.Furnitures.WallFurni;
using RetroFun.Utils.Furnitures.FloorFurni;
using System.Text.RegularExpressions;
using System.Text;
using RetroFun.Globals;
using RetroFun.Utils.Globals;
using RetroFun.Utils.HostFinder.BobbaItalia;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FurnitureChecker : ObservablePage
    {
        private List<HCatalogNode> PageNode = new List<HCatalogNode>();



        private List<HFloorItem> RoomFloorFurni { get => FloorFurnitures.Furni; }
        private List<HWallItem> RoomWallFurni { get => WallFurnitures.Furni; }

        private List<string> RegisteredPages = new List<string>();
        private Dictionary<int, string> pages
        {
            get => GlobalDictionaries.pagenames;
            set
            {
                GlobalDictionaries.pagenames = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool IsLoggingPageStuff;
        private bool isNewPage;
        private bool shouldaddnewchar;
        private bool shoudendline;
        private bool isNewPage1;
        private bool shouldaddnewchar1;
        private bool shoudendline1;
        private List<HFloorItem> RemovedFloorFurnis
        {
            get => FloorFurnitures.RemFurni;
            set
            {
                FloorFurnitures.RemFurni = value;
                RaiseOnPropertyChanged();
            }
        }

        private List<HWallItem> RemovedWallFurnis
        {
            get => WallFurnitures.RemFurni;
            set
            {
                WallFurnitures.RemFurni = value;
                RaiseOnPropertyChanged();
            }
        }


        List<HWallItem> IrregularWallFurni;
        List<HFloorItem> IrregularFloorFurni;

        List<HFloorItem> CreditsFloorFurnis;
        List<HFloorItem> CrystalsFloorFurnis;
        List<HWallItem> CrystalsWallItems;

        List<HFloorItem> CatalogueFloorFurnis;
        List<HWallItem> CatalogueWallFurnis;

        List<HFloorItem> RaresFloorFurnis;
        List<HWallItem> RaresWallFurnis;

        List<HWallItem> RegularWallFurni;
        List<HFloorItem> RegularFloorFurni;



        List<HWallItem> WhitelistedWallFurni;
        List<HFloorItem> WhiteListedFloorFurni;


        List<HWallItem> HIDDEN_IRREGULAR_WALLFURNIS;
        List<HFloorItem> HIDDEN_IRREGULAR_FLOORFURNIS;

        List<HWallItem> HIDDEN_REGULAR_WALLFURNIS;
        List<HFloorItem> HIDDEN_REGULAR_FLOORFURNIS;

        List<HFloorItem> FloorRaresSnapShotCount;
        List<HWallItem> WallRaresSnapshotCount;


        List<HFloorItem> RoomFloorItemsSnapshot;
        List<HWallItem> RoomWallItemsSnapshot;


        List<HFloorItem> SnapShotIrregularFloorFurni;
        List<HWallItem> SnapShotIrregularWallFurni;

        List<HFloorItem> SnapshotRegularFloorItems;
        List<HWallItem> SnapshotRegularWallItems;


        List<HFloorItem> SnapshotRemovedFloorItems;
        List<HWallItem> SnapshotRemovedWallItems;


        List<HFloorItem> SnapshotCatalogueFloorItems;
        List<HWallItem> SnapshotCatalogueWallItems;
        List<HFloorItem> UnknownFloorItems;
        List<HWallItem> UnknownWallItems;

        List<HFloorItem> SnapshotCreditsFloorFurnis;
        List<HFloorItem> SnapshotCrystalsFloorFurnis;
        List<HWallItem> SnapshotCrystalsWallFurnis;


        List<int> SpriteIds = new List<int>();

        private bool REM_IRR_FLOOR_FURNI;
        private bool REM_IRR_WALL_FURNI;
        private bool REM_REG_WALL_FURNI;
        private bool REM_REG_FLOOR_FURNI;

        private bool SHOULD_UPDATE_FILES;


        private bool AreRegisteredFurnisHidden;
        private bool AreUnRegisteredFurnisHidden;
        private bool AreRemovedFurnisHidden = true;
        private bool AreCataloguesFurnisHidden;
        private bool AreCrystalsFurnisHidden;
        private bool AreCreditsFurnisHidden;


        private string ExcelFilePath;
        private bool _doubleClickFurnitureRemoval;
        private bool ShouldIRemoveIrregolar;
        private bool FurniIDToCheckMode;
        private bool IS_REMOVE_FALSE_POSITIVE_MODE;
        private int _FloorFurniID;
        private bool IS_SCANNING_FLOORFURNIS;
        private bool IS_SCANNING_WALLFURNIS;
        private bool IS_HIDING_IRREGULAR_WALLFURNIS;
        private bool IS_HIDING_IRREGULAR_FLOORFURNIS;
        private bool IS_HIDING_REGULAR_WALLFURNIS;
        private bool IS_HIDING_REGULAR_FLOORFURNIS;

        private bool IS_HIDING_REMOVED_FLOORFURNI;
        private bool IS_HIDING_REMOVED_WALLFURNI;


        private bool IS_HIDING_CATALOGUE_FLOORFURNI;
        private bool IS_HIDING_CATALOGUE_WALLFURNI;

        private bool IS_HIDING_CRYSTALS_FLOORFURNIS;
        private bool IS_HIDING_CRYSTALS_WALLFURNIS;

        private bool IS_HIDING_CREDITS_FURNIS;

        private int _FurniIDToCheck;

        public int FurniIDToCheck
        {
            get => _FurniIDToCheck;
            set
            {
                _FurniIDToCheck = value;
                RaiseOnPropertyChanged();
            }
        }






        private int _FurniWalkingSpeed = 15;

        public int FurniWalkingSpeed
        {
            get => _FurniWalkingSpeed;
            set
            {
                _FurniWalkingSpeed = value;
                RaiseOnPropertyChanged();
            }
        }


        public int FloorFurniID
        {
            get => _FloorFurniID;
            set
            {
                _FloorFurniID = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _controlledFloorFurni;

        public int ControlledFloorFurni
        {
            get => _controlledFloorFurni;
            set
            {
                _controlledFloorFurni = value;
                RaiseOnPropertyChanged();
            }
        }




        private bool _isQuietMode;
        public bool isQuietMode
        {
            get => _isQuietMode;
            set
            {
                _isQuietMode = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _FloorFurniRotation;

        public int FloorFurniRotation
        {
            get => _FloorFurniRotation;
            set
            {
                _FloorFurniRotation = value;
                RaiseOnPropertyChanged();
            }
        }


        public bool DoubleClickFurnitureRemoval
        {
            get => _doubleClickFurnitureRemoval;
            set
            {
                _doubleClickFurnitureRemoval = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _StoreFurniID;

        public bool StoreFurniID
        {
            get => _StoreFurniID;
            set
            {
                _StoreFurniID = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _FurniPickedOutput;

        public bool FurniPickedOutput
        {
            get => _FurniPickedOutput;
            set
            {
                _FurniPickedOutput = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _FloorFurniLiveEditCooldown;

        public int FloorFurniLiveEditCooldown
        {
            get => _FloorFurniLiveEditCooldown;
            set
            {
                _FloorFurniLiveEditCooldown = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _AutomaticScanMode = true;

        public bool AutomaticScanMode
        {
            get => _AutomaticScanMode;
            set
            {
                _AutomaticScanMode = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _FloorFurniX;

        public int FloorFurniX
        {
            get => _FloorFurniX;
            set
            {
                _FloorFurniX = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _FloorFurniY;

        public int FloorFurniY
        {
            get => _FloorFurniY;
            set
            {
                _FloorFurniY = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _furnitureIdText;

        public string FurnitureIdText
        {
            get => _furnitureIdText;
            set
            {
                _furnitureIdText = value;
                RaiseOnPropertyChanged();

                // Set the default value(0) if it fails to parse.
                int.TryParse(value, out int furnitureId);

                FurnitureId = furnitureId;
                RaiseOnPropertyChanged(nameof(FurnitureId));
            }
        }


        private List<string> FilePathList;

        public int FurnitureId { get; private set; }


        public FurnitureChecker()
        {
            InitializeComponent();
            Bind(FurniIDToCheckNbx, "Value", nameof(ControlledFloorFurni));
            FilePathList = new List<string>();
            IrregularWallFurni = new List<HWallItem>();
            IrregularFloorFurni = new List<HFloorItem>();
            RegularWallFurni = new List<HWallItem>();
            RegularFloorFurni = new List<HFloorItem>();
            WhitelistedWallFurni = new List<HWallItem>();
            WhiteListedFloorFurni = new List<HFloorItem>();
            HIDDEN_IRREGULAR_WALLFURNIS = new List<HWallItem>();
            HIDDEN_IRREGULAR_FLOORFURNIS = new List<HFloorItem>();
            HIDDEN_REGULAR_WALLFURNIS = new List<HWallItem>();
            HIDDEN_REGULAR_FLOORFURNIS = new List<HFloorItem>();
            FloorRaresSnapShotCount = new List<HFloorItem>();
            WallRaresSnapshotCount = new List<HWallItem>();
            SnapshotRegularFloorItems = new List<HFloorItem>();
            SnapshotRegularWallItems = new List<HWallItem>();
            SnapShotIrregularFloorFurni = new List<HFloorItem>();
            SnapShotIrregularWallFurni = new List<HWallItem>();
            SnapshotRemovedFloorItems = new List<HFloorItem>();
            SnapshotRemovedWallItems = new List<HWallItem>();
            CreditsFloorFurnis = new List<HFloorItem>();
            CrystalsFloorFurnis = new List<HFloorItem>();
            CatalogueFloorFurnis = new List<HFloorItem>();
            CatalogueWallFurnis = new List<HWallItem>();
            RaresFloorFurnis = new List<HFloorItem>();
            RaresWallFurnis = new List<HWallItem>();
            RoomFloorItemsSnapshot = new List<HFloorItem>();
            RoomWallItemsSnapshot = new List<HWallItem>();
            SnapshotCatalogueFloorItems = new List<HFloorItem>();
            SnapshotCatalogueWallItems = new List<HWallItem>();
            SnapshotCreditsFloorFurnis = new List<HFloorItem>();
            SnapshotCrystalsFloorFurnis = new List<HFloorItem>();
            CrystalsWallItems = new List<HWallItem>();
            UnknownFloorItems = new List<HFloorItem>();
            UnknownWallItems = new List<HWallItem>();
            SnapshotCrystalsWallFurnis = new List<HWallItem>();
        }


        private void RecognizeFurnitureType(HWallItem item, bool isQuiet)
        {
            if (RecognizeDomain.GetHost(Connection.Host) == RecognizeDomain.bobbaitalia)
            {
                if (StaffRaresWallItems.isRareFurni(item))
                {
                    if (!RaresWallFurnis.Contains(item))
                    {
                        RaresWallFurnis.Add(item);
                    }
                    UpdateRaresLbl();
                    CheckForRares(item, isQuiet);
                }
                else if (PublicWallFurnis.IsCatalogueFurni(item))
                {
                    if (!CatalogueWallFurnis.Contains(item))
                    {
                        CatalogueWallFurnis.Add(item);
                    }
                    if(AreCataloguesFurnisHidden)
                    {
                        HideFurnisClient(item);
                    }
                    if (!isQuiet)
                    {
                        SpeakAnyways("This furni is in catalogue as Public furni");
                    }
                    UpdateCatalogFurnisLbl();

                }
                else if (KnownCurrency.isCrystals(item))
                {
                    if (!CrystalsWallItems.Contains(item))
                    {
                        CrystalsWallItems.Add(item);
                    }
                    if (AreCrystalsFurnisHidden)
                    {
                        HideFurnisClient(item);
                    }
                    if (!isQuiet)
                    {
                        SpeakAnyways("This furni is a Crystal Furni");
                    }
                    UpdateCatalogFurnisLbl();

                }
                else
                {

                    if (!UnknownWallItems.Contains(item))
                    {
                        UnknownWallItems.Add(item);
                    }
                    UpdateUnknownFurnisLbl();
                    if (!isQuiet)
                    {
                        Speak("This furni is not Identified Yet! , contact the developer on discord :" + GlobalStrings.DeveloperDiscord);
                    }
                }
            }
        }


        private void RecognizeFurnitureType(HFloorItem item, bool isQuiet)
        {
            if (RecognizeDomain.GetHost(Connection.Host) == RecognizeDomain.bobbaitalia)
            {
                if (StaffRaresFloorItems.isRareFurni(item))
                {
                    if (!RaresFloorFurnis.Contains(item))
                    {
                        RaresFloorFurnis.Add(item);
                    }
                    UpdateRaresLbl();
                    CheckForRares(item, isQuiet);
                }

                else if (PublicFloorFurnis.IsCatalogueFurni(item))
                {
                    if (!CatalogueFloorFurnis.Contains(item))
                    {
                        CatalogueFloorFurnis.Add(item);
                    }
                    if (!isQuiet)
                    {
                        Speak("This furni is in catalogue as Public furni");
                    }
                    UpdateCatalogFurnisLbl();
                }
                else if (KnownCurrency.isCredits(item))
                {
                    if (!CreditsFloorFurnis.Contains(item))
                    {
                        CreditsFloorFurnis.Add(item);
                    }
                    if(AreCreditsFurnisHidden)
                    {
                        HideFurnisClient(item);
                    }
                    if (!isQuiet)
                    {
                        Speak("This furni is in catalogue as Credits Currency");
                    }
                    UpdateCreditsLbl();
                }
                else if (KnownCurrency.isCrystals(item))
                {
                    if (!CrystalsFloorFurnis.Contains(item))
                    {
                        CrystalsFloorFurnis.Add(item);
                    }
                    if(AreCrystalsFurnisHidden)
                    {
                        HideFurnisClient(item);
                    }
                    if (!isQuiet)
                    {
                        SpeakAnyways("This furni is a Crystal Furni");
                    }
                    UpdateCrystalsLbl();
                    SyncCreditsCount();
                }
                else
                {
                    if (!UnknownFloorItems.Contains(item))
                    {
                        UnknownFloorItems.Add(item);
                    }
                    UpdateUnknownFurnisLbl();
                    if (!isQuiet)
                    {
                        Speak("This furni is not Identified Yet! , contact the developer on discord :" + GlobalStrings.DeveloperDiscord);
                    }
                }
            }
        }


        private void SelectFile()
        {
            OpenFileDialog SelectedFile = new OpenFileDialog();
            SelectedFile.Filter = "All Files (*.*)|*.*";
            SelectedFile.FilterIndex = 1;
            SelectedFile.Multiselect = true;

            if (SelectedFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in SelectedFile.FileNames)
                {

                    if (FilePathList.Contains(file))
                    {
                        Speak("Not Adding : " + file + " Because is already in the list", 34);
                    }
                    else
                    {
                        FilePathList.Add(file);
                        UpdateFileLabel();
                    }
                }
            }
        }
        private void SelectFileExcel()
        {
            OpenFileDialog SelectedFile = new OpenFileDialog();
            SelectedFile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            SelectedFile.FilterIndex = 1;
            SelectedFile.Multiselect = false;

            if (SelectedFile.ShowDialog() == DialogResult.OK)
            {
                ExcelFilePath = SelectedFile.FileName;
                StartExcelConverter();
                Speak("Starting conversion of file " + SelectedFile.FileName + " !");
            }
        }

        private void RareCheck(int id, bool isQuiet)
        {

            if (FilePathList != null && FilePathList.Count != 0)
            {
                var wall = RoomWallFurni.Find(f => f.Id == id);
                var floor = RoomFloorFurni.Find(f => f.Id == id);
                var remfloor = RemovedFloorFurnis.Find(f => f.Id == id);
                var remwall = RemovedWallFurnis.Find(f => f.Id == id);

                if (wall != null)
                {
                    RecognizeFurnitureType(wall, isQuiet);
                    return;
                }
                else if (floor != null)
                {
                    RecognizeFurnitureType(floor, isQuiet);
                    return;
                }
                else if (remfloor != null)
                {
                    RecognizeFurnitureType(remfloor, isQuiet);
                    return;
                }
                else if (remwall != null)
                {
                    RecognizeFurnitureType(remwall, isQuiet);
                    return;
                }
                else
                {
                    CheckForRares(id, isQuiet);
                    return;
                }
            }
        }

        private async void HideFurnisClient(HWallItem item)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(250);
                await Connection.SendToClientAsync(In.RemoveWallItem, item.Id.ToString(), 0);
            }
        }


        private async void HideFurnisClient(HFloorItem item)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(250);
                if (In.RemoveFloorItem == 0 && RecognizeDomain.GetHost(Connection.Host) == RecognizeDomain.bobbaitalia)
                {
                    await Connection.SendToClientAsync(2411, item.Id.ToString(), false, 0, 0);
                    return;
                }
                else
                {
                    await Connection.SendToClientAsync(In.RemoveFloorItem, item.Id.ToString(), false, 0, 0);
                    return;
                }
            }
        }

        private void CheckForRares(int itemid, bool isQuiet)
        {

            if (FilePathList != null && FilePathList.Count != 0)
            {
                bool isRegular = SearchPaymentRare(itemid, isQuiet);
                if (!isRegular)
                {

                    if (!isQuiet)
                    {
                        Speak("This Furni is Irregular!", 34);
                    }
                    RecordRareControl(false, "[IRREGOLARE] : " + itemid);
                }
            }
        }




        private void CheckForRares(HWallItem wall, bool isQuiet)
        {

            if (FilePathList != null && FilePathList.Count != 0)
            {
                bool isRegular = SearchPaymentRare(wall, isQuiet);
                if (!isRegular)
                {
                    if (!WhitelistedWallFurni.Contains(wall) && WhitelistedWallFurni != null)
                    {
                        if (!isQuiet)
                        {
                            SpeakAnyways("This Furni is Irregular!", 34);
                        }
                        RecordRareControl(false, "[IRREGOLARE] : " + wall.Id);


                        if (!IrregularWallFurni.Contains(wall))
                        {
                            IrregularWallFurni.Add(wall);
                            UpdateIrregolarFurniLabel();
                        }
                        if (AreUnRegisteredFurnisHidden)
                        {
                            if (!HIDDEN_IRREGULAR_WALLFURNIS.Contains(wall))
                            {
                                HIDDEN_IRREGULAR_WALLFURNIS.Add(wall);
                            }
                            HideFurnisClient(wall);
                            UpdateHiddenIrregolarFurniLabel();
                        }
                        if (ShouldIRemoveIrregolar)
                        {
                            PickFurniSS(wall.Id);
                        }
                    }
                    else
                    {
                        if (wall != null && !RegularWallFurni.Contains(wall))
                        {
                            RegularWallFurni.Add(wall);
                        }
                        if (AreRegisteredFurnisHidden)
                        {
                            if (!HIDDEN_REGULAR_WALLFURNIS.Contains(wall))
                            {
                                HIDDEN_REGULAR_WALLFURNIS.Add(wall);
                            }
                            HideFurnisClient(wall);
                            UpdateHiddenRegularFurniLabel();
                        }
                        if (!isQuiet)
                        {
                            SpeakAnyways("This Furni is whitelisted!", 34);
                        }

                    }
                }
            }
        }

        private void CheckForRares(HFloorItem furni, bool isQuiet)
        {
            if (FilePathList != null && FilePathList.Count != 0)
            {
                bool isParticularFurniture = isParticularFurni(furni, isQuiet);
                if (!isParticularFurniture)
                {
                    if (RecognizeDomain.GetHost(Connection.Host) == RecognizeDomain.bobbaitalia)
                    {
                        bool isRegular = SearchPaymentRare(furni, isQuiet);
                        if (!isRegular)
                        {
                            if (!WhiteListedFloorFurni.Contains(furni) && WhiteListedFloorFurni != null)
                            {
                                if (!isQuiet)
                                {
                                    SpeakAnyways("This Furni is Irregular!", 34);
                                }
                                RecordRareControl(false, "[IRREGOLARE] : " + furni.Id);

                                if (!IrregularFloorFurni.Contains(furni))
                                {
                                    IrregularFloorFurni.Add(furni);
                                    UpdateIrregolarFurniLabel();
                                }
                                if (AreUnRegisteredFurnisHidden)
                                {
                                    if (!HIDDEN_IRREGULAR_FLOORFURNIS.Contains(furni))
                                    {
                                        HIDDEN_IRREGULAR_FLOORFURNIS.Add(furni);
                                    }
                                    HideFurnisClient(furni);
                                    UpdateHiddenIrregolarFurniLabel();
                                }
                                if (ShouldIRemoveIrregolar)
                                {
                                    PickFurniSS(furni.Id);
                                }
                            }
                            else
                            {
                                if (!RegularFloorFurni.Contains(furni))
                                {
                                    RegularFloorFurni.Add(furni);
                                }
                                if (!isQuiet)
                                {
                                    SpeakAnyways("This Furni is whitelisted!", 34);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!RegularFloorFurni.Contains(furni))
                        {
                            RegularFloorFurni.Add(furni);
                        }
                        if (AreRegisteredFurnisHidden)
                        {
                            if (!HIDDEN_REGULAR_FLOORFURNIS.Contains(furni))
                            {
                                HIDDEN_REGULAR_FLOORFURNIS.Add(furni);
                            }
                            HideFurnisClient(furni);
                            UpdateHiddenIrregolarFurniLabel();
                        }
                        if (!isQuiet)
                        {
                            Speak("This Furni is Regular, Is available in public catalogue!", 34);
                        }
                    }
                }
                else
                {
                    if (!RegularFloorFurni.Contains(furni))
                    {
                        RegularFloorFurni.Add(furni);
                    }
                    if (AreRegisteredFurnisHidden)
                    {
                        if (!HIDDEN_REGULAR_FLOORFURNIS.Contains(furni))
                        {
                            HIDDEN_REGULAR_FLOORFURNIS.Add(furni);
                        }
                        HideFurnisClient(furni);
                        UpdateHiddenIrregolarFurniLabel();
                    }
                    if (!isQuiet)
                    {
                        Speak("This Furni is Regular, matches conditions set!!", 34);
                    }
                }
            }
        }

        private void FixExcel(string path, bool isManualUpdate)
        {
            string newpath = string.Empty;
            Missing missing = Missing.Value;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.DisplayAlerts = false;
            excel.ScreenUpdating = false;
            excel.Visible = false;
            excel.UserControl = false;
            excel.Interactive = false;
            Workbook workbook = excel.Workbooks.Open(path,
                missing, missing, missing, missing, missing,
                missing, missing, missing, missing, missing,
                missing, missing, missing, XlCorruptLoad.xlRepairFile);
            newpath = Path.GetTempPath() + "Converted_Excel.xlsx";
            workbook.SaveAs(newpath, XlFileFormat.xlWorkbookDefault,
                missing, missing, missing, missing,
                XlSaveAsAccessMode.xlExclusive, missing,
                missing, missing, missing, missing);
            ExcelFilePath = newpath;
            workbook.Save();
            workbook.Close(0);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            File.Delete(path);
            ConvertExcelSheetsToTexts(newpath, isManualUpdate);
        }


        private void ConvertExcelSheetsToTexts(string path, bool isManualUpdate)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application myExcel;
                Microsoft.Office.Interop.Excel.Workbook myWorkbook;
                myExcel = new Microsoft.Office.Interop.Excel.Application();
                myExcel.DisplayAlerts = false;
                myExcel.ScreenUpdating = false;
                myExcel.Visible = false;
                myExcel.UserControl = false;
                myExcel.Interactive = false;

                myExcel.Workbooks.Open(path, Missing.Value, ReadOnly: false, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, CorruptLoad: true);
                myWorkbook = myExcel.ActiveWorkbook;
                foreach (Worksheet sheet in myWorkbook.Worksheets)
                {
                    sheet.Tab.Color = System.Drawing.Color.Empty;
                    sheet.Tab.ColorIndex = XlColorIndex.xlColorIndexNone;
                    //sheet.EnableFormatConditionsCalculation = false;
                    //sheet.UsedRange.ClearFormats();
                    Directory.CreateDirectory("../" + "ConvertedSheets");
                    var SaveLocation = Environment.CurrentDirectory + @"/../ConvertedSheets/" + sheet.Name + ".txt";
                    sheet.SaveAs(
                    SaveLocation,//Filename
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlTextWindows, //FileFormat
                    Missing.Value, //Password
                    Missing.Value, //WriteResPassword
                    false, //ReadOnlyRecommended
                    false, //CreateBackup
                    Missing.Value, //AddToMru
                    Missing.Value, //TextCodepage
                    Missing.Value, //TextVisualLayout
                    Missing.Value //Local
                    );

                    AddToFilePathLists(SaveLocation);
                    if (!isQuietMode)
                    {
                        Speak("Converted " + sheet.Name + " into a txt file!");
                    }

                }

                if (isManualUpdate)
                {
                    Speak("All Files Have been refreshed!");
                }
                myWorkbook.Save();
                myWorkbook.Close();
                Marshal.ReleaseComObject(myWorkbook);
                myExcel.Quit();
                File.Delete(path);
            }
            catch (Exception e)
            {
                Speak("Exception :" + e);
            }
        }


        private void AddToFilePathLists(string path)
        {
            if (!FilePathList.Contains(path))
            {
                if (!path.Contains("Recuperati_Foglio1"))
                {
                    if (!path.Contains("irregolari"))
                    {
                        FilePathList.Add(path);
                        UpdateFileLabel();
                    }
                }
            }
        }


        private bool SearchPaymentRare(int id, bool isQuiet)
        {
            if (FilePathList.Count == 0)
            {
                return HandleNullList("Please add some files to check!");
            }
            foreach (string paths in FilePathList)
            {
                using (StreamReader reader = new StreamReader(paths))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(id.ToString()))
                        {
                            if (!isQuiet)
                            {
                                SpeakAnyways(FixLineSpaces(line), 34);
                            }
                            RecordRareControl(true, "[REGOLARE] : " + id);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool isParticularFurni(HFloorItem furni, bool IsQuiet)
        {
            if (GlobalLists.BobbaParticularRares.Contains(furni.TypeId) && RecognizeDomain.GetHost(Connection.Host) == RecognizeDomain.bobbaitalia)
            {
                if ((furni.Id > 684921524) && (furni.Id < 685173361))
                {
                    if (AreRegisteredFurnisHidden)
                    {
                        if (!HIDDEN_REGULAR_FLOORFURNIS.Contains(furni))
                        {
                            HIDDEN_REGULAR_FLOORFURNIS.Add(furni);
                        }
                        HideFurnisClient(furni);
                        UpdateHiddenRegularFurniLabel();
                    }
                    return true;
                }
                return false;
            }
            return false;
        }


        private string FixLineSpaces(string value)
        {
            if (value == null) { return null; }
            var sb = new StringBuilder();

            var lastCharWs = false;
            foreach (var c in value)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (lastCharWs) { continue; }
                    sb.Append(' ');
                    lastCharWs = true;
                }
                else
                {
                    sb.Append(c);
                    lastCharWs = false;
                }
            }
            return sb.ToString();
        }

        private bool SearchPaymentRare(HFloorItem flooritem, bool isQuiet)
        {
            try
            {
                if (FilePathList.Count == 0)
                {
                    return HandleNullList("Please add some files to check!");
                }

                foreach (string paths in FilePathList)
                {
                    using (StreamReader reader = new StreamReader(paths))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains(flooritem.Id.ToString()))
                            {
                                if (!isQuiet)
                                {
                                    SpeakAnyways(FixLineSpaces(line), 34);
                                }
                                if (!RegularFloorFurni.Contains(flooritem))
                                {
                                    RegularFloorFurni.Add(flooritem);
                                    UpdateRegularFurniLabel();
                                    if (AreRegisteredFurnisHidden)
                                    {
                                        if (!HIDDEN_REGULAR_FLOORFURNIS.Contains(flooritem))
                                        {
                                            HIDDEN_REGULAR_FLOORFURNIS.Add(flooritem);
                                        }
                                        HideFurnisClient(flooritem);
                                        UpdateHiddenRegularFurniLabel();
                                    }
                                }
                                RecordRareControl(true, "[REGOLARE] : " + flooritem.Id);
                                return true;
                            }
                        }
                    }
                }

                if (AreUnRegisteredFurnisHidden)
                {
                    if (!HIDDEN_IRREGULAR_FLOORFURNIS.Contains(flooritem))
                    {
                        HIDDEN_IRREGULAR_FLOORFURNIS.Add(flooritem);
                        UpdateHiddenRegularFurniLabel();
                    }
                    HideFurnisClient(flooritem);
                    UpdateHiddenIrregolarFurniLabel();
                }
                return false;
            }
            catch (Exception e)
            {
                return HandleBoolExc(e, true);
            }
        }


        private bool SearchPaymentRare(HWallItem wallitem, bool isQuiet)
        {
            if (FilePathList.Count == 0)
            {
                return HandleNullList("Please add some files to check!");
            }
            foreach (string paths in FilePathList)
            {
                using (StreamReader reader = new StreamReader(paths))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(wallitem.Id.ToString()))
                        {
                            if (!isQuiet)
                            {
                                SpeakAnyways(FixLineSpaces(line), 34);

                            }
                            if (!RegularWallFurni.Contains(wallitem))
                            {
                                RegularWallFurni.Add(wallitem);
                                UpdateRegularFurniLabel();
                                if (AreRegisteredFurnisHidden)
                                {
                                    if (!HIDDEN_REGULAR_WALLFURNIS.Contains(wallitem))
                                    {
                                        HIDDEN_REGULAR_WALLFURNIS.Add(wallitem);
                                    }
                                    HideFurnisClient(wallitem);
                                    UpdateHiddenRegularFurniLabel();
                                }
                            }
                            RecordRareControl(true, "[REGOLARE] : " + wallitem.Id);
                            return true;
                        }
                    }
                }
            }
            if (AreUnRegisteredFurnisHidden)
            {
                if (!HIDDEN_IRREGULAR_WALLFURNIS.Contains(wallitem))
                {
                    HIDDEN_IRREGULAR_WALLFURNIS.Add(wallitem);
                }
                HideFurnisClient(wallitem);
                UpdateHiddenIrregolarFurniLabel();
            }
            return false;
        }




        private bool HandleBoolExc(Exception exc, bool isQuiet)
        {
            if (!isQuiet)
            {
                Speak("EXCEPTION : " + exc);
            }
            return true;
        }

        private bool HandleNullList(string message)
        {
            Speak(message, 34);
            return true;
        }

        private void UpdateTotFurniInRoomLabel()
        {
            int a = SyncWallFurniCount();
            int b = SyncFloorFurniCount();
            int c = a + b;
            WriteToLabel(TotFurnisinroomLbl, "Tot Furni In room  : " + c);
        }


        private void UpdateRaresLbl()
        {
            int a = SyncRareFloorCount();
            int b = SyncRareWallCount();
            int c = a + b;
            WriteToLabel(RaresLbl, "Rares : " + c);
        }

        private void UpdateUnknownFurnisLbl()
        {
            int a = SyncUnknownFloorCount();
            int b = SyncUnknownWallCount();
            int c = a + b;
            WriteToLabel(UnknownFurniLbl, "Unknown Furnis : " + c);
        }
        private void UpdateFloorFurnisLabel()
        {
            WriteToLabel(FloorFurniCountLbl, "Tot Floor Furni In room  : " + SyncFloorFurniCount());
            UpdateTotFurniInRoomLabel();
        }


        private void UpdateWallFurnisLabel()
        {
            WriteToLabel(WallFurniCountLbl, "Tot WallFurni In room : " + SyncWallFurniCount());
            UpdateTotFurniInRoomLabel();

        }

        private void UpdateFileLabel()
        {
            int Files;

            if (FilePathList != null)
            {
                Files = FilePathList.Count();
            }
            else
            {
                Files = 0;
            }
            WriteToLabel(SelectedFileLbl, "Total Files : " + Files);
        }

        private void ResetFileLabel()
        {
            WriteToLabel(SelectedFileLbl, "Total Files : 0");
        }
        private int SyncIrregolarFloorFurniCount()
        {
            if (IrregularFloorFurni != null)
            {
                return IrregularFloorFurni.Count();
            }
            else
            {
                return 0;
            }
        }

        private int SyncIrregolarWallFurniCount()
        {
            if (IrregularWallFurni != null)
            {
                return IrregularWallFurni.Count();
            }
            else
            {
                return 0;
            }
        }


        private int SyncHiddenIrregolarFloorFurniCount()
        {
            if (HIDDEN_IRREGULAR_FLOORFURNIS != null)
            {
                return HIDDEN_IRREGULAR_FLOORFURNIS.Count();
            }
            else
            {
                return 0;
            }
        }

        private int SyncHiddenIrregolarWallFurniCount()
        {
            if (HIDDEN_IRREGULAR_WALLFURNIS != null)
            {
                return HIDDEN_IRREGULAR_WALLFURNIS.Count();
            }
            else
            {
                return 0;
            }
        }


        private int SyncHiddenRegularFloorFurniCount()
        {
            if (HIDDEN_REGULAR_FLOORFURNIS != null)
            {
                return HIDDEN_REGULAR_FLOORFURNIS.Count();
            }
            else
            {
                return 0;
            }
        }

        private int SyncHiddenRegularWallFurniCount()
        {
            if (HIDDEN_REGULAR_WALLFURNIS != null)
            {
                return HIDDEN_REGULAR_WALLFURNIS.Count();
            }
            else
            {
                return 0;
            }
        }

        private void UpdateHiddenIrregolarFurniLabel()
        {
            int a = SyncHiddenIrregolarFloorFurniCount();
            int b = SyncHiddenIrregolarWallFurniCount();
            int c = a + b;
            WriteToLabel(HiddenIrregularFurnisLbl, "Hidden Irregular Furnis : " + c);
        }

        private void UpdateHiddenRegularFurniLabel()
        {
            int a = SyncHiddenRegularFloorFurniCount();
            int b = SyncHiddenRegularWallFurniCount();
            int c = a + b;
            WriteToLabel(HiddenRegularFurnisLbl, "Hidden Regular Furnis : " + c);
        }

        private void UpdateIrregolarFurniLabel()
        {
            int a = SyncIrregolarFloorFurniCount();
            int b = SyncIrregolarWallFurniCount();
            int c = a + b;
            WriteToLabel(IrregularFurnisCountLbl, "Tot Irregular Furnis : " + c);
        }

        private int SyncRegularFloorFurniCount()
        {
            if (RegularFloorFurni != null)
            {
                return RegularFloorFurni.Count();
            }
            else
            {
                return 0;
            }

        }

        private int SyncRegularWallFurniCount()
        {
            if (RegularWallFurni != null)
            {
                return RegularWallFurni.Count();
            }
            else
            {
                return 0;
            }
        }

        private void UpdateRegularFurniLabel()
        {
            int a = SyncRegularFloorFurniCount();
            int b = SyncRegularWallFurniCount();
            int c = a + b;
            WriteToLabel(RegularFurnisCountLbl, "Tot Regular Furnis : " + c);
        }


        private void UpdateWhitelistFurniLabel()
        {
            int a = SyncWhitelistedWallFurniCount();
            int b = SyncWhitelisteFloorFurniCount();
            int c = a + b;
            WriteToLabel(WhitelistedFurniLbl, "Whitelisted Furnis : " + c);
        }



        private int SyncRemovedWallFurniCount()
        {
            if (RemovedWallFurnis != null)
            {
                return RemovedWallFurnis.Count();
            }
            else
            {
                return 0;
            }
        }
        private int SyncRemovedFloorFurniCount()
        {
            if (RemovedFloorFurnis != null)
            {
                return RemovedFloorFurnis.Count();
            }
            else
            {
                return 0;
            }
        }


        private void UpdateRemovedWallFurniLbl()
        {
            WriteToLabel(RemovedWallFurnisLbl, "Removed WallFurnis : " + SyncRemovedWallFurniCount());
        }

        private void UpdateRemovedFloorFurniLbl()
        {
            WriteToLabel(RemovedFloorFurnisLbl, "Removed Floor Furnis : " + SyncRemovedFloorFurniCount());
        }


        private void UpdateCreditsLbl()
        {
            WriteToLabel(CreditsLbl, "Credits : " + SyncCreditsCount());
        }


        private void UpdateCrystalsLbl()
        {
            int a = SyncFloorCrystalsCount();
            int b = SyncWallCrystalsCount();
            int c = a + b;
            WriteToLabel(CrystalsLbl, "Crystals : " + c);
        }


        private void UpdateCatalogFurnisLbl()
        {
            int a = SyncFloorCatalogueCount();
            int b = SyncWallCatalogueCount();
            int c = a + b;
            WriteToLabel(CatalogueLbl, "Catalogue : " + c);
        }



        private void UpdateRemovedFurnisLabel()
        {
            UpdateRemovedWallFurniLbl();
            UpdateRemovedFloorFurniLbl();
            UpdateTotFurniInRoomLabel();

        }

        private void UpdateAllLabels()
        {
            UpdateTotFurniInRoomLabel();
            UpdateFloorFurnisLabel();
            UpdateWallFurnisLabel();
            UpdateHiddenIrregolarFurniLabel();
            UpdateHiddenRegularFurniLabel();
            UpdateIrregolarFurniLabel();
            UpdateRegularFurniLabel();
            UpdateWhitelistFurniLabel();
            UpdateRemovedWallFurniLbl();
            UpdateRemovedFloorFurniLbl();
            UpdateCatalogFurnisLbl();
            UpdateCreditsLbl();
            UpdateCrystalsLbl();
            UpdateRaresLbl();
            UpdateUnknownFurnisLbl();

        }


        private void ResetRareFloorScanner()
        {
            IrregularFloorFurni.Clear();
            RegularFloorFurni.Clear();
            CatalogueFloorFurnis.Clear();
            RaresFloorFurnis.Clear();
            CreditsFloorFurnis.Clear();
            CrystalsFloorFurnis.Clear();
        }

        private void ResetRareWallScanner()
        {
            IrregularWallFurni.Clear();
            RegularWallFurni.Clear();
            RaresWallFurnis.Clear();
            CatalogueWallFurnis.Clear();
        }


        private int SyncFloorFurniCount()
        {
            if (RoomFloorFurni != null)
            {
                return RoomFloorFurni.Count();
            }
            else
            {
                return 0;
            }
        }

        private int SyncFloorCatalogueCount()
        {
            if (CatalogueFloorFurnis != null)
            {
                return CatalogueFloorFurnis.Count();
            }
            else
            {
                return 0;
            }
        }
        private int SyncWallCatalogueCount()
        {
            if (CatalogueWallFurnis != null)
            {
                return CatalogueWallFurnis.Count();
            }
            else
            {
                return 0;
            }
        }

        private int SyncFloorCrystalsCount()
        {
            if (CrystalsFloorFurnis != null)
            {
                return CrystalsFloorFurnis.Count();
            }
            else
            {
                return 0;
            }
        }
        private int SyncWallCrystalsCount()
        {
            if (CrystalsWallItems != null)
            {
                return CrystalsWallItems.Count();
            }
            else
            {
                return 0;
            }
        }

        private int SyncCreditsCount()
        {
            if (CreditsFloorFurnis != null)
            {
                return CreditsFloorFurnis.Count();
            }
            else
            {
                return 0;
            }
        }


        private int SyncRareFloorCount()
        {
            if (RaresFloorFurnis != null)
            {
                return RaresFloorFurnis.Count();
            }
            else
            {
                return 0;
            }
        }


        private int SyncRareWallCount()
        {
            if (RaresWallFurnis != null)
            {
                return RaresWallFurnis.Count();
            }
            else
            {
                return 0;
            }
        }



        private int SyncUnknownFloorCount()
        {
            if (UnknownFloorItems != null)
            {
                return UnknownFloorItems.Count();
            }
            else
            {
                return 0;
            }
        }


        private int SyncUnknownWallCount()
        {
            if (UnknownWallItems != null)
            {
                return UnknownWallItems.Count();
            }
            else
            {
                return 0;
            }
        }




        private int SyncWhitelisteFloorFurniCount()
        {
            if (WhiteListedFloorFurni != null)
            {
                return WhiteListedFloorFurni.Count();
            }
            else
            {
                return 0;
            }
        }


        private int SyncWhitelistedWallFurniCount()
        {
            if (WhitelistedWallFurni != null)
            {
                return WhitelistedWallFurni.Count();
            }
            else
            {
                return 0;
            }
        }
        private int SyncWallFurniCount()
        {
            if (RoomWallFurni != null)
            {
                return RoomWallFurni.Count();
            }
            else
            {
                return 0;
            }
        }
        private void ResetRoomScannerLabels()
        {
            WriteToLabel(WallFurniCountLbl, "Tot WallFurni In room : 0");
            WriteToLabel(FloorFurniCountLbl, "Tot Floor Furni In room  : 0");
            WriteToLabel(TotFurnisinroomLbl, "Tot Furni In room  : 0");
            WriteToLabel(RemovedFloorFurnisLbl, "Removed Floor Furnis : 0");
            WriteToLabel(RemovedWallFurnisLbl, "Removed WallFurnis : 0");
            WriteToLabel(WhitelistedFurniLbl, "Whitelisted Furnis : 0");
            WriteToLabel(HiddenIrregularFurnisLbl, "Hidden Irregular Furnis : 0");
            WriteToLabel(HiddenRegularFurnisLbl, "Hidden Regular Furnis : 0");
            WriteToLabel(RegularFurnisCountLbl, "Tot Regular Furnis : 0");
            WriteToLabel(IrregularFurnisCountLbl, "Tot Irregular Furnis : 0");
            WriteToLabel(CreditsLbl, "Credits : 0");
            WriteToLabel(CrystalsLbl, "Crystals : 0");
            WriteToLabel(CatalogueLbl, "Catalogue : 0");
            WriteToLabel(RaresLbl, "Rares : 0");
            WriteToLabel(UnknownFurniLbl, "Unknown Furnis : 0");

        }




        private void WriteToLabel(Label label, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                label.Text = text;
            });
        }


        private void WriteToButton(SKoreButton Button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                Button.Text = text;
            });
        }

        private void RecordPlacedRare(int rareid)
        {
            try
            {
                string Filepath = "../PlacedRares/" + RecognizeDomain.GetHost(Connection.Host) + "_rari" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
                string FolderName = "PlacedRares";

                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine("Rares ID stored at :" + DateTime.Now.ToString());
                        txtFile.WriteLine(rareid);
                    }
                }
                else if (File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine(rareid);
                    }
                }
            }

            catch (Exception)
            {

            }
        }


        private void RecordRareControl(bool isRegolar, string text)
        {
            string raretype;
            try
            {
                if (isRegolar)
                {
                    raretype = "_rari_regolari";
                }
                else
                {
                    raretype = "_rari_irregolari";
                }

                string Filepath = "../RareControls/" + RecognizeDomain.GetHost(Connection.Host) + raretype + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
                string FolderName = "RareControls";

                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine("Rares Control Done at :" + DateTime.Now.ToString());
                        txtFile.WriteLine(text);
                    }
                }
                else if (File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine(text);
                    }

                }
            }

            catch (Exception)
            {

            }
        }

        private void NoticePickup(string FurniID)
        {
            Speak("You are picking a furni ClientSide with ID : " + FurniID);
        }

        private void RadioButtonCheck(RadioButton button, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Checked = value;
            });
        }


        private async void SpeakAnyways(string text, int bubble)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(150);
                await Connection.SendToClientAsync(In.RoomUserTalk, 0, text, 0, bubble, 0, -1);
            }
        }
        private async void SpeakAnyways(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(150);
                await Connection.SendToClientAsync(In.RoomUserTalk, 0, text, 0, 34, 0, -1);
            }
        }

        private async void Speak(string text)
        {
            if (!isQuietMode)
            {
                if (Connection.Remote.IsConnected)
                {
                    await Task.Delay(150);
                    await Connection.SendToClientAsync(In.RoomUserTalk, 0, text, 0, 34, 0, -1);
                }
            }
        }

        private async void Speak(string text, int bubble)
        {
            if (!isQuietMode)
            {
                if (Connection.Remote.IsConnected)
                {
                    await Task.Delay(50);
                    await Connection.SendToClientAsync(In.RoomUserTalk, 0, text, 0, bubble, 0, -1);
                }
            }
        }

        public override void In_WallItemUpdate(DataInterceptedEventArgs e)
        {
            string furniid = e.Packet.ReadString();
            int typeIdIguess = e.Packet.ReadInteger();
            string newLocation = e.Packet.ReadString();
            if (int.TryParse(furniid, out int furni))
            {
                UpdateFurniMovement(furni, newLocation);
            }
            e.Packet.Position = 0;
            e.Continue();
        }


        public override void In_FloorItemUpdate(DataInterceptedEventArgs e)
        {
            int uniqueId = e.Packet.ReadInteger();
            int typeId = e.Packet.ReadInteger();
            int x = e.Packet.ReadInteger();
            int y = e.Packet.ReadInteger();
            int facingprob = e.Packet.ReadInteger();
            string z = e.Packet.ReadString();
            string heightthingyprob = e.Packet.ReadString();
            int stateprobidk = e.Packet.ReadInteger();
            int newXProb = e.Packet.ReadInteger();
            int newYProb = e.Packet.ReadInteger();
            UpdateFurniMovement(uniqueId, x, y, z);
            e.Packet.Position = 0;
            e.Continue();
            UpdateFloorFurnisLabel();
        }


        public override void Out_LatencyTest(DataInterceptedEventArgs e)
        {
            if (pages.Values.Count == 0)
            {
                RequestPageNode();
            }
        }

        private void RequestPageNode()
        {
            pages.Clear();
            if (RecognizeDomain.GetHost(Connection.Host) == RecognizeDomain.bobbaitalia)
            {
                Connection.SendToServerAsync(3566, "NORMAL");
            }
        }

        public static string RemoveSpecialCharacters(string str)
        {
            char[] buffer = new char[str.Length];
            int idx = 0;

            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z')
                    || (c >= 'a' && c <= 'z') || (c == '.') || (c == '_'))
                {
                    buffer[idx] = c;
                    idx++;
                }
            }

            return new string(buffer, 0, idx);
        }



        public override void In_CatalogPagesList(DataInterceptedEventArgs e)
        {
            var node = new HCatalogNode(e.Packet);
            foreach (HCatalogNode children in node.Children)
            {
                foreach (HCatalogNode children2 in children.Children)
                {
                    if (!pages.ContainsKey(children2.PageId))
                    {
                        pages.Add(children2.PageId, RemoveSpecialCharacters(children2.Localization));
                    }
                    foreach (HCatalogNode children3 in children2.Children)
                    {
                        if (!pages.ContainsKey(children3.PageId))
                        {
                            pages.Add(children3.PageId, RemoveSpecialCharacters(children3.Localization));
                        }
                        foreach (HCatalogNode children4 in children3.Children)
                        {
                            if (!pages.ContainsKey(children4.PageId))
                            {
                                pages.Add(children4.PageId, RemoveSpecialCharacters(children4.Localization));
                            }
                            foreach (HCatalogNode children5 in children4.Children)
                            {
                                if (!pages.ContainsKey(children5.PageId))
                                {
                                    pages.Add(children5.PageId, RemoveSpecialCharacters(children5.Localization));
                                }
                            }
                        }
                    }
                }
            }
        }
        public override void In_CatalogPage(DataInterceptedEventArgs e)
        {
            if (IsLoggingPageStuff)
            {
                isNewPage = true;
                shouldaddnewchar = false;
                shoudendline = true;
                isNewPage1 = true;
                shouldaddnewchar1 = false;
                shoudendline1 = true;
                SpriteIds.Clear();
                var catalog = new HCatalogPage(e.Packet);
                string pagename = FindPageNameByID(catalog.Id);

                var CatalogOffers = catalog.Offers.ToList();
                foreach (HCatalogOffer itemproduct in CatalogOffers)
                {
                    foreach (HCatalogProduct item in itemproduct.Products)
                    {
                        var furnitype = item.Type;
                        if (!SpriteIds.Contains(item.ClassId))
                        {
                            SpriteIds.Add(item.ClassId);
                            if (pagename == "NOT_FOUND")
                            {
                                RequestPageNode();
                            }
                            else
                            {
                                    if (furnitype == HProductType.Stuff)
                                    {
                                        PrintClassFloorIDTOFile(item.ClassId, "Bobba_" + pagename);
                                    }
                                    else if (furnitype == HProductType.Item)
                                    {
                                        PrintClassWallIDTOFile(item.ClassId, "Bobba_" + pagename);
                                    }
                                }
                            }
                        }

                    }
                }
            }
        


        private string FindPageNameByID(int id)
        {
            if (pages.TryGetValue(id, out string name))
            {
                return name;
            }
            else
            {
                return "NOT_FOUND";
            }

        }
        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            ResetAll();
        }


        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            ResetAll();
        }


        private void ResetAll()
        {
            IrregularWallFurni.Clear();
            IrregularFloorFurni.Clear();
            RegularWallFurni.Clear();
            RegularFloorFurni.Clear();
            WhitelistedWallFurni.Clear();
            WhiteListedFloorFurni.Clear();
            HIDDEN_IRREGULAR_WALLFURNIS.Clear();
            HIDDEN_IRREGULAR_FLOORFURNIS.Clear();
            HIDDEN_REGULAR_WALLFURNIS.Clear();
            HIDDEN_REGULAR_FLOORFURNIS.Clear();
            FloorRaresSnapShotCount.Clear();
            WallRaresSnapshotCount.Clear();
            SnapshotRegularFloorItems.Clear();
            SnapshotRegularWallItems.Clear();
            SnapShotIrregularFloorFurni.Clear();
            SnapShotIrregularWallFurni.Clear();
            SnapshotRemovedFloorItems.Clear();
            SnapshotRemovedWallItems.Clear();
            CreditsFloorFurnis.Clear();
            CrystalsFloorFurnis.Clear();
            CrystalsWallItems.Clear();
            CatalogueFloorFurnis.Clear();
            CatalogueWallFurnis.Clear();
            RaresFloorFurnis.Clear();
            RaresWallFurnis.Clear();
            RoomFloorItemsSnapshot.Clear();
            RoomWallItemsSnapshot.Clear();
            SnapshotCatalogueFloorItems.Clear();
            SnapshotCatalogueWallItems.Clear();
            SnapshotCreditsFloorFurnis.Clear();
            SnapshotCrystalsFloorFurnis.Clear();
            UnknownFloorItems.Clear();
            UnknownWallItems.Clear();
            IS_HIDING_IRREGULAR_WALLFURNIS = false;
            IS_HIDING_IRREGULAR_FLOORFURNIS = false;
            IS_HIDING_REGULAR_WALLFURNIS = false;
            IS_HIDING_REGULAR_FLOORFURNIS = false;
            IS_HIDING_REMOVED_FLOORFURNI = false;
            IS_HIDING_REMOVED_WALLFURNI = false;
            IS_HIDING_CATALOGUE_FLOORFURNI = false;
            IS_HIDING_CATALOGUE_WALLFURNI = false;
            IS_HIDING_CRYSTALS_FLOORFURNIS = false;
            IS_SCANNING_FLOORFURNIS = false;
            IS_SCANNING_WALLFURNIS = false;
            ResetRoomScannerLabels();
            ResetRareFloorScanner();
            ResetRareWallScanner();
            UpdateAllLabels();
            ResetBooleansAndButtons();
        }


        private void ResetBooleansAndButtons()
        {
            AreRegisteredFurnisHidden = false;
            AreUnRegisteredFurnisHidden = false;
            AreRemovedFurnisHidden = true;
            AreCataloguesFurnisHidden = false;
            AreCrystalsFurnisHidden = false;
            AreCreditsFurnisHidden = false;

            WriteToButton(ToggleVisibilityRegisteredRaresBtn, "Hide Registered Rares");
            WriteToButton(ToggleVisibilityUnregisteredRaresBtn, "Hide Unregistered Rares");
            WriteToButton(ToggleVisibilityRemovedFurnisBtn, "Show Removed Furnis");
            WriteToButton(ToggleVisibilityCatalogFurnisBtn, "Hide Catalogue Furnis");
            WriteToButton(ToggleVisibilityCrystalsFurnisBtn, "Hide Crystals Furnis");
            WriteToButton(ToggleVisibilityCreditsFurnisBtn, "Hide Credits Furnis");
        }



        private void PickWallItemCSBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            PickFurniSS(FurnitureId);
        }

        private void PickFloorFurniSSBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            PickFurniSS(FurnitureId);
        }

        private void PickFurniSS(int furniID)
        {
            Connection.SendToServerAsync(Out.RoomPickupItem, 2, furniID);
        }

        private void DoubleClickFurnitureRemovalChbx_CheckedChanged(object sender, EventArgs e)
        {
            Speak("You will be picking furni on Client, instead of Server side!");
        }

        private void FileCheckBtn_Click(object sender, EventArgs e)
        {
            if (FurniIDToCheckMode)
            {
                WriteToButton(FileCheckBtn, "Rare Check : OFF");
                FurniIDToCheckMode = false;
            }
            else
            {
                DisableWhitelistMode();
                WriteToButton(FileCheckBtn, "Rare Check : ON");
                FurniIDToCheckMode = true;
                SpeakAnyways("Rotate Furni / Rare To check if is a irregular or not!", 34);
            }
        }

        private void DisableWhitelistMode()
        {
            WriteToButton(RemoveFalsePositivesBtn, "Mark False Positives : OFF");
            IS_REMOVE_FALSE_POSITIVE_MODE = false;
        }

        private void SelectRareListBtn_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void CheckRegolarBtn_Click(object sender, EventArgs e)
        {
            RareCheck(ControlledFloorFurni, false);
        }

        private void RemoveIrregolarBtn_Click(object sender, EventArgs e)
        {
            if (ShouldIRemoveIrregolar)
            {
                WriteToButton(RemoveIrregolarBtn, "Remove irregular: OFF");
                ShouldIRemoveIrregolar = false;
            }
            else
            {
                WriteToButton(RemoveIrregolarBtn, "Remove irregular: ON");
                ShouldIRemoveIrregolar = true;
            }
        }

        private void THREAD_HIDE_REGULAR_WALLFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_REGULAR_WALLFURNIS)
                        {
                            if (FilePathList != null)
                            {
                                if (RegularWallFurni != null && !(RegularWallFurni.Count == HIDDEN_REGULAR_WALLFURNIS.Count()))
                                {

                                    foreach (HWallItem item in RegularWallFurni)
                                    {
                                        if (!HIDDEN_REGULAR_WALLFURNIS.Contains(item))
                                        {
                                            HIDDEN_REGULAR_WALLFURNIS.Add(item);
                                            UpdateHiddenRegularFurniLabel();
                                        }
                                        HideFurnisClient(item);
                                    }
                                    IS_HIDING_REGULAR_WALLFURNIS = false;
                                }
                                IS_HIDING_REGULAR_WALLFURNIS = false;
                            }
                            IS_HIDING_REGULAR_WALLFURNIS = false;
                        }
                        IS_HIDING_REGULAR_WALLFURNIS = false;
                    }
                    catch (Exception e)
                    {
                    }
                } while (IS_HIDING_REGULAR_WALLFURNIS);

            }).Start();

        }

        private void THREAD_HIDE_REGULAR_FLOORFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_REGULAR_FLOORFURNIS)
                        {
                            if (FilePathList != null)
                            {
                                if (RegularFloorFurni != null && !(RegularFloorFurni.Count == HIDDEN_REGULAR_FLOORFURNIS.Count()))
                                {

                                    foreach (HFloorItem flooritem in RegularFloorFurni)
                                    {
                                        if (!HIDDEN_REGULAR_FLOORFURNIS.Contains(flooritem))
                                        {
                                            HIDDEN_REGULAR_FLOORFURNIS.Add(flooritem);
                                            UpdateHiddenRegularFurniLabel();
                                        }
                                        HideFurnisClient(flooritem);
                                    }
                                    IS_HIDING_REGULAR_FLOORFURNIS = false;
                                }
                                IS_HIDING_REGULAR_FLOORFURNIS = false;
                            }
                            IS_HIDING_REGULAR_FLOORFURNIS = false;
                        }
                        IS_HIDING_REGULAR_FLOORFURNIS = false;
                    }

                    catch (Exception e)
                    {
                        IS_HIDING_REGULAR_FLOORFURNIS = false;
                    }
                } while (IS_HIDING_REGULAR_FLOORFURNIS);

            }).Start();

        }


        private void THREAD_HIDE_IRREGULAR_WALLFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_IRREGULAR_WALLFURNIS)
                        {
                            if (FilePathList != null)
                            {
                                if (IrregularWallFurni != null && !(IrregularWallFurni.Count == HIDDEN_IRREGULAR_WALLFURNIS.Count()))
                                {

                                    foreach (HWallItem item in IrregularWallFurni)
                                    {
                                        if (!HIDDEN_IRREGULAR_WALLFURNIS.Contains(item))
                                        {
                                            HIDDEN_IRREGULAR_WALLFURNIS.Add(item);
                                            UpdateHiddenIrregolarFurniLabel();
                                        }
                                        HideFurnisClient(item);
                                    }

                                }
                                IS_HIDING_IRREGULAR_WALLFURNIS = false;

                            }


                        }
                    }

                    catch (Exception e)
                    {
                        IS_HIDING_IRREGULAR_WALLFURNIS = false;

                    }
                } while (IS_HIDING_IRREGULAR_WALLFURNIS);





            }).Start();

        }

        private void THREAD_HIDE_IRREGULAR_FLOORFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_IRREGULAR_FLOORFURNIS)
                        {
                            if (FilePathList != null)
                            {
                                if (IrregularFloorFurni != null && !(IrregularFloorFurni.Count == HIDDEN_IRREGULAR_FLOORFURNIS.Count()))
                                {

                                    foreach (HFloorItem flooritem in IrregularFloorFurni)
                                    {
                                        if (!HIDDEN_IRREGULAR_FLOORFURNIS.Contains(flooritem))
                                        {
                                            HIDDEN_IRREGULAR_FLOORFURNIS.Add(flooritem);
                                            UpdateHiddenIrregolarFurniLabel();
                                        }
                                        HideFurnisClient(flooritem);
                                    }
                                }
                                else
                                {
                                    IS_HIDING_IRREGULAR_FLOORFURNIS = false;
                                }

                            }
                        }
                    }
                    catch (Exception e)
                    {
                        IS_HIDING_IRREGULAR_FLOORFURNIS = false;

                    }
                } while (IS_HIDING_IRREGULAR_FLOORFURNIS);

            }).Start();
        }

        private void THREAD_HIDE_CATALOGUE_FLOORFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_CATALOGUE_FLOORFURNI)
                        {
                            if (FilePathList != null)
                            {
                                if (SnapshotCatalogueFloorItems != null && !(SnapshotCatalogueFloorItems.Count == 0))
                                {

                                    foreach (HFloorItem flooritem in SnapshotCatalogueFloorItems)
                                    {
                                        HideFurnisClient(flooritem);
                                    }
                                    IS_HIDING_CATALOGUE_FLOORFURNI = false;

                                }
                                IS_HIDING_CATALOGUE_FLOORFURNI = false;
                            }
                            IS_HIDING_CATALOGUE_FLOORFURNI = false;
                        }
                    }
                    catch (Exception e)
                    {
                        IS_HIDING_CATALOGUE_FLOORFURNI = false;

                    }
                } while (IS_HIDING_CATALOGUE_FLOORFURNI);

            }).Start();
        }

        private void THREAD_HIDE_CRYSTALS_FLOORFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_CRYSTALS_FLOORFURNIS)
                        {
                            if (FilePathList != null)
                            {
                                if (SnapshotCrystalsFloorFurnis != null && !(SnapshotCrystalsFloorFurnis.Count == 0))
                                {

                                    foreach (HFloorItem flooritem in SnapshotCrystalsFloorFurnis)
                                    {
                                        HideFurnisClient(flooritem);
                                    }
                                    IS_HIDING_CRYSTALS_FLOORFURNIS = false;

                                }
                                IS_HIDING_CRYSTALS_FLOORFURNIS = false;
                            }
                            IS_HIDING_CRYSTALS_FLOORFURNIS = false;
                        }
                    }
                    catch (Exception e)
                    {
                        IS_HIDING_CRYSTALS_FLOORFURNIS = false;

                    }
                } while (IS_HIDING_CRYSTALS_FLOORFURNIS);

            }).Start();
        }


        private void THREAD_HIDE_CRYSTALS_WALLFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_CRYSTALS_WALLFURNIS)
                        {
                                if (SnapshotCrystalsWallFurnis != null && !(SnapshotCrystalsWallFurnis.Count == 0))
                                {

                                    foreach (HWallItem item in SnapshotCrystalsWallFurnis)
                                    {
                                        HideFurnisClient(item);
                                    }
                                IS_HIDING_CRYSTALS_WALLFURNIS = false;

                                }
                            IS_HIDING_CRYSTALS_WALLFURNIS = false;
                        }
                    }
                    catch (Exception e)
                    {
                        IS_HIDING_CRYSTALS_WALLFURNIS = false;

                    }
                } while (IS_HIDING_CRYSTALS_WALLFURNIS);

            }).Start();
        }


        private void THREAD_HIDE_CREDITS_FLOORFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_CREDITS_FURNIS)
                        {
                            if (FilePathList != null)
                            {
                                if (SnapshotCreditsFloorFurnis != null && !(SnapshotCreditsFloorFurnis.Count == 0))
                                {

                                    foreach (HFloorItem flooritem in SnapshotCreditsFloorFurnis)
                                    {
                                        HideFurnisClient(flooritem);
                                    }
                                    IS_HIDING_CREDITS_FURNIS = false;

                                }
                                IS_HIDING_CREDITS_FURNIS = false;
                            }
                            IS_HIDING_CREDITS_FURNIS = false;
                        }
                    }
                    catch (Exception e)
                    {
                        IS_HIDING_CREDITS_FURNIS = false;

                    }
                } while (IS_HIDING_CREDITS_FURNIS);

            }).Start();
        }


        private void THREAD_HIDE_CATALOGUE_WALLFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_CATALOGUE_WALLFURNI)
                        {
                            if (FilePathList != null)
                            {
                                if (SnapshotCatalogueWallItems != null && !(SnapshotCatalogueWallItems.Count == 0))
                                {

                                    foreach (HWallItem item in SnapshotCatalogueWallItems)
                                    {
                                        HideFurnisClient(item);
                                    }
                                    IS_HIDING_CATALOGUE_WALLFURNI = false;

                                }
                                IS_HIDING_CATALOGUE_WALLFURNI = false;
                            }
                            IS_HIDING_CATALOGUE_WALLFURNI = false;
                        }
                    }
                    catch (Exception e)
                    {
                        IS_HIDING_CATALOGUE_WALLFURNI = false;

                    }
                } while (IS_HIDING_CATALOGUE_WALLFURNI);

            }).Start();
        }



        private void THREAD_HIDE_REMOVED_FLOORFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_REMOVED_FLOORFURNI)
                        {
                            if (FilePathList != null)
                            {
                                if (SnapshotRemovedFloorItems != null && !(SnapshotRemovedFloorItems.Count == 0))
                                {

                                    foreach (HFloorItem flooritem in SnapshotRemovedFloorItems)
                                    {
                                        HideFurnisClient(flooritem);
                                    }
                                    IS_HIDING_REMOVED_FLOORFURNI = false;

                                }
                                IS_HIDING_REMOVED_FLOORFURNI = false;
                            }
                            IS_HIDING_REMOVED_FLOORFURNI = false;

                        }
                    }
                    catch (Exception e)
                    {
                        IS_HIDING_REMOVED_FLOORFURNI = false;

                    }
                } while (IS_HIDING_REMOVED_FLOORFURNI);

            }).Start();
        }



        private void THREAD_HIDE_REMOVED_WALLFURNIS()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IS_HIDING_REMOVED_WALLFURNI)
                        {
                            if (FilePathList != null)
                            {
                                if (SnapshotRemovedWallItems != null && !(SnapshotRemovedWallItems.Count == 0))
                                {

                                    foreach (HWallItem flooritem in SnapshotRemovedWallItems)
                                    {
                                        HideFurnisClient(flooritem);
                                    }
                                    IS_HIDING_REMOVED_WALLFURNI = false;
                                }
                                IS_HIDING_REMOVED_WALLFURNI = false;
                            }
                            IS_HIDING_REMOVED_WALLFURNI = false;

                        }
                    }
                    catch (Exception e)
                    {
                        IS_HIDING_REMOVED_WALLFURNI = false;

                    }
                } while (IS_HIDING_REMOVED_WALLFURNI);

            }).Start();
        }

        private void StartWallFurniAnalyzer()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                try
                {
                    if (FilePathList != null)
                    {
                        if (RoomWallItemsSnapshot != null && RoomWallItemsSnapshot.Count != 0)
                        {
                            foreach (HWallItem item in RoomWallItemsSnapshot)
                            {
                                RecognizeFurnitureType(item, true);
                                UpdateIrregolarFurniLabel();
                                UpdateRegularFurniLabel();
                            }
                            if (!isQuietMode)
                            {
                                Speak("Scanned all Wall Furnis!", 34);
                            }

                            IS_SCANNING_WALLFURNIS = false;
                        }
                        IS_SCANNING_WALLFURNIS = false;
                    }
                    IS_SCANNING_WALLFURNIS = false;

                }
                catch (Exception e)
                {
                    IS_SCANNING_WALLFURNIS = false;
                }
            }).Start();

        }


        private void StartFloorFurnIAnalyzer()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                try
                {
                    if (FilePathList != null)
                    {
                        if (RoomFloorItemsSnapshot != null && RoomFloorItemsSnapshot.Count != 0)
                        {

                            foreach (HFloorItem item in RoomFloorItemsSnapshot)
                            {
                                RecognizeFurnitureType(item, true);
                                UpdateIrregolarFurniLabel();
                                UpdateRegularFurniLabel();
                            }
                            if (!isQuietMode)
                            {
                                Speak("Scanned all Floor Furnis!", 34);
                            }
                            IS_SCANNING_FLOORFURNIS = false;
                        }
                        IS_SCANNING_FLOORFURNIS = false;
                    }
                    IS_SCANNING_FLOORFURNIS = false;
                }
                catch (Exception e)
                {
                    IS_SCANNING_FLOORFURNIS = false;

                }
            }).Start();

        }


        private void StartExcelConverter()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                FixExcel(ExcelFilePath, false);
            }).Start();
        }




        private void ClearRoomSnapshots()
        {
            WallRaresSnapshotCount.Clear();
            FloorRaresSnapShotCount.Clear();
        }
        private void SetRoomWallSnapshot()
        {
            RoomWallItemsSnapshot = RoomWallFurni.ToList();
        }

        private void SetRoomFloorSnapshot()
        {
            RoomFloorItemsSnapshot = RoomFloorFurni.ToList();
        }

        private void SetRareSnapshots()
        {
            SnapShotIrregularFloorFurni.Clear();
            SnapShotIrregularWallFurni.Clear();
            SnapshotRegularFloorItems.Clear();
            SnapshotRegularWallItems.Clear();

            SnapShotIrregularFloorFurni = GetIrregularFloorFurnis();
            SnapShotIrregularWallFurni = GetIrregularWallFurni();
            SnapshotRegularFloorItems = GetRegularFloorFurnis();
            SnapshotRegularWallItems = GetRegularWallItems();

        }

        private void RoomFloorChecker()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                SetRoomFloorSnapshot();
                if (RoomFloorItemsSnapshot != null && !(RoomFloorItemsSnapshot.Count == 0))
                {
                    if (!isQuietMode)
                    {
                        Speak("Scanning Room Floor Furnis....", 34);
                    }
                    StartFloorFurnIAnalyzer();
                }
                else
                {
                    if (!isQuietMode)
                    {
                        Speak("No Floor Furnis Detected.", 34);
                    }
                    IS_SCANNING_FLOORFURNIS = false;
                }
            }).Start();
        }


        private void RoomWallChecker()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                SetRoomWallSnapshot();
                if (RoomWallItemsSnapshot != null && !(RoomWallItemsSnapshot.Count == 0))
                {
                    if (!isQuietMode)
                    {
                        Speak("Scanning Room Wall Furnis....", 34);
                    }
                    StartWallFurniAnalyzer();
                }
                else
                {
                    if (!isQuietMode)
                    {
                        Speak("No Wall Furnis Detected.", 34);
                    }
                    IS_SCANNING_WALLFURNIS = false;
                }
            }).Start();
        }



        private List<HFloorItem> GetRoomFloorFurnis()
        {
            return RoomFloorFurni;
        }

        private List<HWallItem> GetRoomWallItems()
        {
            return RoomWallFurni;
        }


        private List<HFloorItem> GetRegularFloorFurnis()
        {
            return RegularFloorFurni;
        }


        private List<HFloorItem> GetIrregularFloorFurnis()
        {
            return IrregularFloorFurni;
        }


        private List<HWallItem> GetRegularWallItems()
        {
            return RegularWallFurni;
        }

        private List<HWallItem> GetIrregularWallFurni()
        {
            return IrregularWallFurni;
        }

        private void AnalyzeRooMFurnisBtn_Click(object sender, EventArgs e)
        {
            StartRoomAnalizzator();
        }

        private void StartRoomAnalizzator()
        {
            ClearRoomSnapshots();
            if (FilePathList != null && FilePathList.Count != 0)
            {
                if (!IS_SCANNING_FLOORFURNIS)
                {
                    IS_SCANNING_FLOORFURNIS = true;
                    ResetRareFloorScanner();
                    RoomFloorChecker();

                }
                else
                {
                    Speak("Wait, im still scanning All Floor Furnis in room!", 34);
                }
                if (!IS_SCANNING_WALLFURNIS)
                {
                    IS_SCANNING_WALLFURNIS = true;
                    ResetRareWallScanner();
                    RoomWallChecker();
                }
                else
                {
                    Speak("Wait, im still scanning All Wall Furnis in room!", 34);
                }

            }
            else
            {
                Speak("Please add some files!", 34);

            }
        }


        private void PickRegisteredFurnisBtn_Click(object sender, EventArgs e)
        {
            REM_REG_WALL_FURNI = false;
            REM_REG_FLOOR_FURNI = false;
            SetRareSnapshots();
            RemoveRegolarFurni();
        }

        private void PickUnregisteredFurniBtn_Click(object sender, EventArgs e)
        {
            REM_IRR_WALL_FURNI = false;
            REM_IRR_FLOOR_FURNI = false;
            SetRareSnapshots();
            RemoveIrregolarFloorFurni();
            RemoveIrregolarWallFurni();
        }


        private void ManualUpdateExcel()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                try
                {

                    if (SHOULD_UPDATE_FILES)
                    {
                        if (ExcelFilePath != null && ExcelFilePath != "")
                        {

                            FixExcel(ExcelFilePath, true);
                        }
                    }

                }
                catch (Exception)
                { }
            }).Start();
        }

        private void UpdateExcelFilesThread(object sender, ElapsedEventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                try
                {

                    if (SHOULD_UPDATE_FILES)
                    {
                        if (ExcelFilePath != null && ExcelFilePath != "")
                        {
                            FixExcel(ExcelFilePath, false);
                        }
                    }

                }
                catch (Exception)
                { }
            }).Start();
        }


        private void RemoveRegolarFurni()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (SnapshotRegularFloorItems.Count() == 0)
                        {
                            REM_REG_FLOOR_FURNI = true;
                        }
                        if (SnapshotRegularFloorItems != null && SnapshotRegularFloorItems.Count() != 0 && !REM_REG_FLOOR_FURNI)
                        {
                            foreach (HFloorItem floorfurni in SnapshotRegularFloorItems)
                            {
                                Task.Delay(8000);
                                Connection.SendToServerAsync(Out.RoomPickupItem, 2, floorfurni.Id);

                                if (RegularFloorFurni.Contains(floorfurni))
                                {
                                    RegularFloorFurni.Remove(floorfurni);
                                }
                                if (!RemovedFloorFurnis.Contains(floorfurni))
                                {
                                    RemovedFloorFurnis.Add(floorfurni);
                                }
                                UpdateRegularFurniLabel();
                            }
                        }

                        if (SnapshotRegularWallItems.Count() == 0)
                        {
                            REM_REG_WALL_FURNI = true;

                        }
                        if (SnapshotRegularWallItems != null && SnapshotRegularWallItems.Count() != 0 && !REM_REG_WALL_FURNI)
                        {
                            foreach (HWallItem wallitem in SnapshotRegularWallItems)
                            {
                                Task.Delay(8000);
                                Connection.SendToServerAsync(Out.RoomPickupItem, 2, wallitem.Id);

                                if (RegularWallFurni.Contains(wallitem))
                                {
                                    RegularWallFurni.Remove(wallitem);
                                }
                                if (!RemovedWallFurnis.Contains(wallitem))
                                {
                                    RemovedWallFurnis.Add(wallitem);
                                }
                                UpdateRegularFurniLabel();
                            }
                        }
                    }

                    catch (Exception)
                    { }
                } while (!REM_REG_FLOOR_FURNI && !REM_REG_WALL_FURNI);
            }).Start();
        }




        private void RemoveIrregolarFloorFurni()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (SnapShotIrregularFloorFurni != null && SnapShotIrregularFloorFurni.Count() != 0 && !REM_IRR_FLOOR_FURNI)
                        {
                            if (SnapShotIrregularFloorFurni.Count() == 0)
                            {
                                REM_IRR_WALL_FURNI = true;
                            }
                            foreach (HFloorItem floorfurni in SnapShotIrregularFloorFurni)
                            {
                                Task.Delay(250);
                                Connection.SendToServerAsync(Out.RoomPickupItem, 2, floorfurni.Id);
                                if (IrregularFloorFurni.Contains(floorfurni))
                                {
                                    IrregularFloorFurni.Remove(floorfurni);
                                }
                                if (!RemovedFloorFurnis.Contains(floorfurni))
                                {
                                    RemovedFloorFurnis.Add(floorfurni);
                                }
                                UpdateIrregolarFurniLabel();
                                UpdateRemovedFloorFurniLbl();
                            }
                            REM_IRR_FLOOR_FURNI = true;
                        }
                    }
                    catch (Exception)
                    {

                    }
                } while (!REM_IRR_FLOOR_FURNI);
            }).Start();
        }



        private void RemoveIrregolarWallFurni()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (SnapShotIrregularWallFurni.Count() == 0)
                        {
                            REM_IRR_WALL_FURNI = true;
                        }
                        if (SnapShotIrregularWallFurni != null && SnapShotIrregularWallFurni.Count() != 0 && !REM_IRR_WALL_FURNI)
                        {
                            foreach (HWallItem wallitem in SnapShotIrregularWallFurni)
                            {
                                Task.Delay(250);
                                Connection.SendToServerAsync(Out.RoomPickupItem, 2, wallitem.Id);

                                if (IrregularWallFurni.Contains(wallitem))
                                {
                                    IrregularWallFurni.Remove(wallitem);
                                }
                                if (!RemovedWallFurnis.Contains(wallitem))
                                {
                                    RemovedWallFurnis.Add(wallitem);
                                }
                                UpdateIrregolarFurniLabel();
                                UpdateRemovedWallFurniLbl();
                            }
                            REM_IRR_WALL_FURNI = true;
                        }
                    }
                    catch (Exception)
                    {

                    }
                } while (REM_IRR_WALL_FURNI);
            }).Start();
        }


        public override void Out_RotateMoveItem(DataInterceptedEventArgs e)
        {
            int FurniID = e.Packet.ReadInteger();
            int x = e.Packet.ReadInteger();
            int y = e.Packet.ReadInteger();
            int z = e.Packet.ReadInteger();

            if (FurniIDToCheckMode)
            {
                ControlledFloorFurni = FurniID;
                SpeakAnyways("Checking ID : " + FurniID, 34);
                RareCheck(ControlledFloorFurni, false);
            }
            if (IS_REMOVE_FALSE_POSITIVE_MODE)
            {
                ControlledFloorFurni = FurniID;
                WhitelistFurni(ControlledFloorFurni);
            }
            UpdateFurniMovement(FurniID, x, y, z);
            e.Packet.Position = 0;
            e.Continue();

        }

        private void UpdateFurniMovement(int furni, int Coord_x, int Coord_y)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, Coord_x, Coord_y);
                return;
            }
        }


        private void UpdateFurniMovement(int furni, int Coord_x, int Coord_y, int Coord_z)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, Coord_x, Coord_y, Coord_z);
                return;
            }
        }

        private void UpdateFurniMovement(int furni, int Coord_x, int Coord_y, string Coord_z)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, Coord_x, Coord_y, Coord_z);
                return;
            }
        }

        private void UpdateFurniMovement(int furni, string wallcoord)
        {
            var roomfurni = RoomWallFurni.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, wallcoord);
                return;
            }
        }

        private void UpdateFurniMovement(HFloorItem furni, int Coord_x, int Coord_y)
        {
            var hiddenregular = HIDDEN_REGULAR_FLOORFURNIS.Find(x => x == furni);
            var hiddenirregular = HIDDEN_IRREGULAR_FLOORFURNIS.Find(x => x == furni);
            var whitelist = WhiteListedFloorFurni.Find(x => x == furni);
            var regular = RegularFloorFurni.Find(x => x == furni);
            var irregular = IrregularFloorFurni.Find(x => x == furni);
            if (hiddenregular != null)
            {
                hiddenregular.Tile.X = Coord_x;
                hiddenregular.Tile.Y = Coord_y;
            }
            if (hiddenirregular != null)
            {
                hiddenirregular.Tile.X = Coord_x;
                hiddenirregular.Tile.Y = Coord_y;
            }
            if (whitelist != null)
            {
                whitelist.Tile.X = Coord_x;
                whitelist.Tile.Y = Coord_y;
            }
            if (regular != null)
            {
                regular.Tile.X = Coord_x;
                regular.Tile.Y = Coord_y;
            }
            if (irregular != null)
            {
                irregular.Tile.X = Coord_x;
                irregular.Tile.Y = Coord_y;
            }
        }

        private void UpdateFurniMovement(HFloorItem furni, int Coord_x, int Coord_y, int Coord_z)
        {
            var hiddenregular = HIDDEN_REGULAR_FLOORFURNIS.Find(x => x == furni);
            var hiddenirregular = HIDDEN_IRREGULAR_FLOORFURNIS.Find(x => x == furni);
            var whitelist = WhiteListedFloorFurni.Find(x => x == furni);
            var regular = RegularFloorFurni.Find(x => x == furni);
            var irregular = IrregularFloorFurni.Find(x => x == furni);
            if (hiddenregular != null)
            {
                hiddenregular.Tile.X = Coord_x;
                hiddenregular.Tile.Y = Coord_y;

                hiddenregular.Tile.Z = Coord_z;

            }
            if (hiddenirregular != null)
            {
                hiddenirregular.Tile.X = Coord_x;
                hiddenirregular.Tile.Y = Coord_y;

                hiddenirregular.Tile.Z = Coord_z;

            }
            if (whitelist != null)
            {
                whitelist.Tile.X = Coord_x;
                whitelist.Tile.Y = Coord_y;

                whitelist.Tile.Z = Coord_z;

            }
            if (regular != null)
            {
                regular.Tile.X = Coord_x;
                regular.Tile.Y = Coord_y;

                regular.Tile.Z = Coord_z;

            }
            if (irregular != null)
            {
                irregular.Tile.X = Coord_x;
                irregular.Tile.Y = Coord_y;
                irregular.Tile.Z = Coord_z;

            }
        }

        private void UpdateFurniMovement(HFloorItem furni, int Coord_x, int Coord_y, string Coord_z)
        {
            var hiddenregular = HIDDEN_REGULAR_FLOORFURNIS.Find(x => x == furni);
            var hiddenirregular = HIDDEN_IRREGULAR_FLOORFURNIS.Find(x => x == furni);
            var whitelist = WhiteListedFloorFurni.Find(x => x == furni);
            var regular = RegularFloorFurni.Find(x => x == furni);
            var irregular = IrregularFloorFurni.Find(x => x == furni);
            if (hiddenregular != null)
            {
                hiddenregular.Tile.X = Coord_x;
                hiddenregular.Tile.Y = Coord_y;
                if (Double.TryParse(Coord_z, out Double res))
                {
                    hiddenregular.Tile.Z = res;
                }
            }
            if (hiddenirregular != null)
            {
                hiddenirregular.Tile.X = Coord_x;
                hiddenirregular.Tile.Y = Coord_y;
                if (Double.TryParse(Coord_z, out Double res))
                {
                    hiddenirregular.Tile.Z = res;
                }
            }
            if (whitelist != null)
            {
                whitelist.Tile.X = Coord_x;
                whitelist.Tile.Y = Coord_y;
                if (Double.TryParse(Coord_z, out Double res))
                {
                    whitelist.Tile.Z = res;
                }
            }
            if (regular != null)
            {
                regular.Tile.X = Coord_x;
                regular.Tile.Y = Coord_y;
                if (Double.TryParse(Coord_z, out Double res))
                {
                    regular.Tile.Z = res;
                }
            }
            if (irregular != null)
            {
                irregular.Tile.X = Coord_x;
                irregular.Tile.Y = Coord_y;
                if (Double.TryParse(Coord_z, out Double res))
                {
                    irregular.Tile.Z = res;
                }
            }
        }

        private void UpdateFurniMovement(HWallItem furni, string wallcoord)
        {
            var roomfurni = RoomWallFurni.Find(x => x == furni);
            var hiddenregular = HIDDEN_REGULAR_WALLFURNIS.Find(x => x == furni);
            var hiddenirregular = HIDDEN_IRREGULAR_WALLFURNIS.Find(x => x == furni);
            var whitelist = WhitelistedWallFurni.Find(x => x == furni);
            var regular = RegularWallFurni.Find(x => x == furni);
            var irregular = IrregularWallFurni.Find(x => x == furni);

            if (roomfurni != null)
            {
                roomfurni.Location = wallcoord;
            }
            if (hiddenregular != null)
            {
                hiddenregular.Location = wallcoord;
            }
            if (hiddenirregular != null)
            {
                hiddenirregular.Location = wallcoord;
            }
            if (whitelist != null)
            {
                whitelist.Location = wallcoord;
            }
            if (regular != null)
            {
                regular.Location = wallcoord;
            }
            if (irregular != null)
            {
                irregular.Location = wallcoord;
            }

        }


        private void WhitelistFurni(int furni)
        {

            var wall = RoomWallFurni.Find(f => f.Id == furni);
            var floor = RoomFloorFurni.Find(f => f.Id == furni);
            if (floor != null)
            {
                WhitelistFurni(floor);
            }
            if (wall != null)
            {
                WhitelistFurni(wall);
            }
        }


        private void WhitelistFurni(HFloorItem furni)
        {
            if (WhiteListedFloorFurni != null)
            {
                if (!WhiteListedFloorFurni.Contains(furni))
                {
                    Speak(furni.Id + " : Added To The Whitelist!");
                    WhiteListedFloorFurni.Add(furni);
                    UpdateWhitelistFurniLabel();
                }
                if (IrregularFloorFurni.Contains(furni))
                {
                    IrregularFloorFurni.Remove(furni);
                    UpdateIrregolarFurniLabel();
                }
                if (!RegularFloorFurni.Contains(furni))
                {
                    RegularFloorFurni.Add(furni);
                    UpdateRegularFurniLabel();
                }
                if (AreRegisteredFurnisHidden)
                {
                    if (!HIDDEN_REGULAR_FLOORFURNIS.Contains(furni))
                    {
                        HIDDEN_REGULAR_FLOORFURNIS.Add(furni);
                        UpdateHiddenRegularFurniLabel();
                    }
                    HideFurnisClient(furni);
                }
                else
                {
                    Speak(furni.Id + " : Hey, im already in the whitelist!");
                    UpdateWhitelistFurniLabel();
                }
            }
        }

        private void WhitelistFurni(HWallItem furni)
        {
            if (WhitelistedWallFurni != null)
            {
                if (!WhitelistedWallFurni.Contains(furni))
                {
                    Speak(furni.Id + " : Added To The Whitelist!");
                    WhitelistedWallFurni.Add(furni);
                    UpdateWhitelistFurniLabel();
                }
                if (IrregularWallFurni.Contains(furni))
                {
                    IrregularWallFurni.Remove(furni);
                    UpdateIrregolarFurniLabel();
                }
                if (!RegularWallFurni.Contains(furni))
                {
                    RegularWallFurni.Add(furni);
                    UpdateRegularFurniLabel();

                }
                if (AreRegisteredFurnisHidden)
                {
                    if (!HIDDEN_REGULAR_WALLFURNIS.Contains(furni))
                    {
                        HIDDEN_REGULAR_WALLFURNIS.Add(furni);
                        UpdateHiddenRegularFurniLabel();
                    }
                    HideFurnisClient(furni);
                }
                else
                {
                    Speak(furni.Id + " : Hey, im already in the whitelist!");
                }
            }
        }


        public override void Out_MoveWallItem(DataInterceptedEventArgs e)
        {
            int WallFurni = e.Packet.ReadInteger();
            string wallfurnicoord = e.Packet.ReadString();
            if (FurniIDToCheckMode)
            {
                ControlledFloorFurni = WallFurni;
                SpeakAnyways("Checking ID : " + WallFurni, 34);
                RareCheck(ControlledFloorFurni, false);
            }
        }

        public override void In_RoomFloorItems(DataInterceptedEventArgs e)
        {
            if (AutomaticScanMode)
            {
                if (!IS_SCANNING_FLOORFURNIS)
                {
                    IS_SCANNING_FLOORFURNIS = true;
                    RoomFloorChecker();
                }
            }
            UpdateFloorFurnisLabel();
        }

        public override void In_RoomWallItems(DataInterceptedEventArgs e)
        {
            if (!IS_SCANNING_WALLFURNIS)
            {
                IS_SCANNING_WALLFURNIS = true;
                RoomWallChecker();
            }
            UpdateWallFurnisLabel();
            e.Continue();
        }

        public override void In_AddFloorItem(DataInterceptedEventArgs e)
        {
            try
            {
                var NewFloorFurnis = new HFloorItem(e.Packet);
                if (AutomaticScanMode)
                {
                    RecognizeFurnitureType(NewFloorFurnis, true);
                }
                UpdateRemovedFloorFurniLbl();
                UpdateFloorFurnisLabel();
                UpdateAllLabels();
            }
            catch (Exception) { }
        }

        public override void In_AddWallItem(DataInterceptedEventArgs e)
        {
            try
            {
                var NewPlacedWallFurni = new HWallItem(e.Packet);
                if (AutomaticScanMode)
                {
                    RecognizeFurnitureType(NewPlacedWallFurni, true);
                }
                UpdateWallFurnisLabel();
                UpdateRemovedWallFurniLbl();
            }
            catch (Exception) { }
        }


        private void ConvertExcelSheetsToTxtBtn_Click(object sender, EventArgs e)
        {
            SelectFileExcel();
        }

        private void ClearSelectedFilesBtn_Click(object sender, EventArgs e)
        {
            FilePathList.Clear();
            ResetFileLabel();
        }


        public override void In_RemoveWallItem(DataInterceptedEventArgs e)
        {
            HandleRemovedFurni(e.Packet.ReadString());
            if (!AreRemovedFurnisHidden)
            {
                e.Continue();
            }
            else
            {
                e.IsBlocked = true;
            }
        }

        public override void In_RemoveFloorItem(DataInterceptedEventArgs e)
        {
            HandleRemovedFurni(e.Packet.ReadString());
            e.Continue();
        }
        private void HandleRemovedFurni(string item)
        {
            if (int.TryParse(item, out int furni))
            {
                var foundfurni = RoomFloorFurni.Find(f => f.Id == furni);
                var wallfurni = RoomWallFurni.Find(f => f.Id == furni);

                if (foundfurni != null)
                {
                    HandleRemovedFurni(foundfurni);
                }
                if (wallfurni != null)
                {
                    HandleRemovedFurni(wallfurni);
                }
                UpdateRemovedFloorFurniLbl();
                UpdateFloorFurnisLabel();
                UpdateHiddenIrregolarFurniLabel();
                UpdateHiddenRegularFurniLabel();
            }
            else
            {
                return;
            }
        }


        private void HandleRemovedFurni(HWallItem item)
        {
            if (IrregularWallFurni.Contains(item)) { IrregularWallFurni.Remove(item); }
            if (RegularWallFurni.Contains(item)) { RegularWallFurni.Remove(item); }
            if (WhitelistedWallFurni.Contains(item)) { WhitelistedWallFurni.Remove(item); }
            if (HIDDEN_IRREGULAR_WALLFURNIS.Contains(item)) { HIDDEN_IRREGULAR_WALLFURNIS.Remove(item); }
            if (HIDDEN_REGULAR_WALLFURNIS.Contains(item)) { HIDDEN_REGULAR_WALLFURNIS.Remove(item); }
            if (WallRaresSnapshotCount.Contains(item)) { WallRaresSnapshotCount.Remove(item); }
            if (SnapshotRegularWallItems.Contains(item)) { SnapshotRegularWallItems.Remove(item); }
            if (SnapShotIrregularWallFurni.Contains(item)) { SnapShotIrregularWallFurni.Remove(item); }
            if (SnapshotRemovedWallItems.Contains(item)) { SnapshotRemovedWallItems.Remove(item); }
            if (CatalogueWallFurnis.Contains(item)) { CatalogueWallFurnis.Remove(item); }
            if (RaresWallFurnis.Contains(item)) { RaresWallFurnis.Remove(item); }
            if (RoomWallItemsSnapshot.Contains(item)) { RoomWallItemsSnapshot.Remove(item); }
            if (SnapshotCatalogueWallItems.Contains(item)) { SnapshotCatalogueWallItems.Remove(item); }
            if (CrystalsWallItems.Contains(item)) { CrystalsWallItems.Remove(item); }
            if (SnapshotCrystalsWallFurnis.Contains(item)) { SnapshotCrystalsWallFurnis.Remove(item); }
            if (UnknownWallItems.Contains(item)) { UnknownWallItems.Remove(item); }
            UpdateAllLabels();
        }


        private void HandleRemovedFurni(HFloorItem item)
        {
            if (IrregularFloorFurni.Contains(item)) { IrregularFloorFurni.Remove(item); }
            if (RegularFloorFurni.Contains(item)) { RegularFloorFurni.Remove(item); }
            if (WhiteListedFloorFurni.Contains(item)) { WhiteListedFloorFurni.Remove(item); }
            if (HIDDEN_IRREGULAR_FLOORFURNIS.Contains(item)) { HIDDEN_IRREGULAR_FLOORFURNIS.Remove(item); }
            if (HIDDEN_REGULAR_FLOORFURNIS.Contains(item)) { HIDDEN_REGULAR_FLOORFURNIS.Remove(item); }
            if (FloorRaresSnapShotCount.Contains(item)) { FloorRaresSnapShotCount.Remove(item); }
            if (SnapshotRegularFloorItems.Contains(item)) { SnapshotRegularFloorItems.Remove(item); }
            if (SnapShotIrregularFloorFurni.Contains(item)) { SnapShotIrregularFloorFurni.Remove(item); }
            if (SnapshotRemovedFloorItems.Contains(item)) { SnapshotRemovedFloorItems.Remove(item); }
            if (CreditsFloorFurnis.Contains(item)) { CreditsFloorFurnis.Remove(item); }
            if (CrystalsFloorFurnis.Contains(item)) { CrystalsFloorFurnis.Remove(item); }
            if (CatalogueFloorFurnis.Contains(item)) { CatalogueFloorFurnis.Remove(item); }
            if (RaresFloorFurnis.Contains(item)) { RaresFloorFurnis.Remove(item); }
            if (RoomFloorItemsSnapshot.Contains(item)) { RoomFloorItemsSnapshot.Remove(item); }
            if (SnapshotCatalogueFloorItems.Contains(item)) { SnapshotCatalogueFloorItems.Remove(item); }
            if (SnapshotCreditsFloorFurnis.Contains(item)) { SnapshotCreditsFloorFurnis.Remove(item); }
            if (SnapshotCrystalsFloorFurnis.Contains(item)) { SnapshotCrystalsFloorFurnis.Remove(item); }

            if (UnknownFloorItems.Contains(item)) { UnknownFloorItems.Remove(item); }
            UpdateAllLabels();
        }

        private void UpdateListConstantlyBtn_Click(object sender, EventArgs e)
        {
            if (ExcelFilePath != null && ExcelFilePath != "")
            {
                if (SHOULD_UPDATE_FILES)
                {
                    WriteToButton(UpdateListConstantlyBtn, "Update List Constantly : OFF");
                }
                else
                {
                    WriteToButton(UpdateListConstantlyBtn, "Update List Constantly : ON");
                    SHOULD_UPDATE_FILES = true;
                }
            }
            else
            {
                Speak("please select the excel file first!");
            }
        }

        private void RefreshExcelListBtn_Click(object sender, EventArgs e)
        {
            if (ExcelFilePath != null && ExcelFilePath != "")
            {
                SHOULD_UPDATE_FILES = true;
                ManualUpdateExcel();
                Speak("Updating Files...");
            }
            else
            {
                Speak("please select the excel file first!");
            }
        }


        private void DisableRareCheck()
        {
            WriteToButton(FileCheckBtn, "Rare Check : OFF");
            FurniIDToCheckMode = false;
        }
        private void RemoveFalsePositivesBtn_Click(object sender, EventArgs e)
        {
            if (IS_REMOVE_FALSE_POSITIVE_MODE)
            {
                WriteToButton(RemoveFalsePositivesBtn, "Mark False Positives : OFF");
                IS_REMOVE_FALSE_POSITIVE_MODE = false;
            }
            else
            {
                DisableRareCheck();
                IS_REMOVE_FALSE_POSITIVE_MODE = true;
                WriteToButton(RemoveFalsePositivesBtn, "Mark False Positives : ON");
            }
        }

        private void ClearWhiteListBtn_click(object sender, EventArgs e)
        {
            WhiteListedFloorFurni.Clear();
            WhitelistedWallFurni.Clear();
            Speak("Cleared Whitelisted furnis!");
            UpdateWhitelistFurniLabel();
        }

        public override void Out_ToggleFloorItem(DataInterceptedEventArgs e)
        {
            int FurniID = e.Packet.ReadInteger();
            if (FurniIDToCheckMode)
            {
                ControlledFloorFurni = FurniID;
                SpeakAnyways("Checking ID : " + FurniID, 34);
                RareCheck(ControlledFloorFurni, false);
                e.IsBlocked = true;
            }
            if (IS_REMOVE_FALSE_POSITIVE_MODE)
            {
                ControlledFloorFurni = FurniID;
                WhitelistFurni(ControlledFloorFurni);
                e.IsBlocked = true;

            }
        }


        public override void Out_ToggleWallItem(DataInterceptedEventArgs e)
        {
            int FurniID = e.Packet.ReadInteger();
            if (FurniIDToCheckMode)
            {
                ControlledFloorFurni = FurniID;
                SpeakAnyways("Checking ID : " + FurniID, 34);
                RareCheck(ControlledFloorFurni, false);
                e.IsBlocked = true;
            }
            if (IS_REMOVE_FALSE_POSITIVE_MODE)
            {
                ControlledFloorFurni = FurniID;
                WhitelistFurni(ControlledFloorFurni);
                e.IsBlocked = true;
            }
        }



        private void HideIrregularWallFurnis()
        {
            if (IrregularWallFurni.Count != 0 && IrregularWallFurni != null && !IS_HIDING_IRREGULAR_WALLFURNIS)
            {
                IS_HIDING_IRREGULAR_WALLFURNIS = true;
                THREAD_HIDE_IRREGULAR_WALLFURNIS();
                Speak("[HIDER]: Hiding all irregular Wall Furnis...", 34);
            }
            else
            {
                Speak("[HIDER]: Can't find any irregular wall furnis to hide!", 34);
            }
        }

        private void HideIrregularFloorFurnis()
        {
            if (IrregularFloorFurni.Count != 0 && IrregularFloorFurni != null && !IS_HIDING_IRREGULAR_FLOORFURNIS)
            {
                IS_HIDING_IRREGULAR_FLOORFURNIS = true;
                THREAD_HIDE_IRREGULAR_FLOORFURNIS();
                Speak("[HIDER]: Hiding all irregular floor Furnis...", 34);
            }
            else
            {
                Speak("[HIDER]: Can't find any irregular floor Furnis to hide!", 34);
            }
        }


        private void HideRegularWallFurnis()
        {
            if (RegularWallFurni.Count != 0 && RegularWallFurni != null && !IS_HIDING_REGULAR_WALLFURNIS)
            {
                IS_HIDING_REGULAR_WALLFURNIS = true;
                THREAD_HIDE_REGULAR_WALLFURNIS(); 
                Speak("[HIDER]: Hiding all regular Wall Furnis...", 34);
            }
            else
            {
                Speak("[HIDER]: Can't find any regular wall furnis to hide!", 34);
            }
        }

        private void HideRegularFloorFurnis()
        {
            if (RegularFloorFurni.Count != 0 && RegularFloorFurni != null && !IS_HIDING_REGULAR_FLOORFURNIS)
            {
                IS_HIDING_REGULAR_FLOORFURNIS = true;
                THREAD_HIDE_REGULAR_FLOORFURNIS();
                Speak("[HIDER]: Hiding all regular floor Furnis...", 34);
            }
            else
            {
                Speak("[HIDER]: Can't find any regular Floor Furnis to hide!", 34);
            }
        }


        private void UnhideIrregularFurnis()
        {
            IS_HIDING_IRREGULAR_FLOORFURNIS = false;
            if (HIDDEN_IRREGULAR_FLOORFURNIS.Count != 0)
            {
                Connection.SendToClientAsync(FloorFurnitures.PacketBuilder(HIDDEN_IRREGULAR_FLOORFURNIS, In.RoomFloorItems));
                HIDDEN_IRREGULAR_FLOORFURNIS.Clear();
                UpdateHiddenIrregolarFurniLabel();
                Speak("[HIDER]:All Irregular Floor Furnis are unhidden!", 34);
            }
            else
            {
                Speak("[HIDER]:I Can't detect any Irregular Hidden Floor Furni to Unhide!", 34);
            }
            IS_HIDING_IRREGULAR_WALLFURNIS = false;
            if (HIDDEN_IRREGULAR_WALLFURNIS.Count != 0)
            {
                Connection.SendToClientAsync(WallFurnitures.PacketBuilder(HIDDEN_IRREGULAR_WALLFURNIS, In.RoomWallItems));
                HIDDEN_IRREGULAR_WALLFURNIS.Clear();
                UpdateHiddenIrregolarFurniLabel();
                Speak("[HIDER]:All Irregular Wall Furnis are unhidden!", 34);
            }
            else
            {
                Speak("[HIDER]:I Can't detect any Irregular Hidden Wall Furni to Unhide!", 34);
            }
        }

        private void ToggleVisibilityRemovedFurnisBtn_Click(object sender, EventArgs e)
        {
            if (AreRemovedFurnisHidden)
            {
                HideRemovedFurnis();
                WriteToButton(ToggleVisibilityRemovedFurnisBtn, "Show Removed Furnis");
                AreRemovedFurnisHidden = false;
            }
            else
            {
                ShowRemovedFurnis();
                WriteToButton(ToggleVisibilityRemovedFurnisBtn, "Hide Removed Furnis");
                AreRemovedFurnisHidden = true;
            }


        }


        private void ShowRemovedFurnis()
        {
            ClearRemovedFurnisSnapshot();
            SetRemovedFurnisSnapshot();
            if (SnapshotRemovedFloorItems.Count != 0)
            {
                Connection.SendToClientAsync(FloorFurnitures.PacketBuilder(SnapshotRemovedFloorItems, In.RoomFloorItems));
                UpdateRemovedFurnisLabel();
                Speak("[HIDER]:All removed Floor Furnis are unhidden!", 34);
            }
            else
            {
                Speak("[HIDER]:I Can't detect any removed Hidden Floor Furni to Unhide!", 34);
            }
            if (SnapshotRemovedWallItems.Count != 0)
            {
                Connection.SendToClientAsync(WallFurnitures.PacketBuilder(SnapshotRemovedWallItems, In.RoomWallItems));
                UpdateRemovedFurnisLabel();
                Speak("[HIDER]:All removed Wall Furnis are unhidden!", 34);
            }
            else
            {
                Speak("[HIDER]:I Can't detect any removed Hidden Wall Furni to Unhide!", 34);
            }
        }
        private void HideRemovedFurnis()
        {
            ClearRemovedFurnisSnapshot();
            SetRemovedFurnisSnapshot();
            if (SnapshotRemovedFloorItems != null && !(SnapshotRemovedFloorItems.Count == 0))
            {
                IS_HIDING_REMOVED_FLOORFURNI = true;
                THREAD_HIDE_REMOVED_FLOORFURNIS();
            }
            else
            {
                Speak("[HIDER]:Can't find any removed Floor Furnis to hide!", 34);
            }

            if (SnapshotRegularWallItems != null && !(SnapshotRegularWallItems.Count == 0))
            {
                IS_HIDING_REMOVED_WALLFURNI = true;
                THREAD_HIDE_REMOVED_WALLFURNIS();
            }
            else
            {
                Speak("[HIDER]:Can't find any removed Wall Furnis to hide!", 34);
            }
        }

        private void ClearCatalogueSnapshots()
        {
            SnapshotCatalogueWallItems.Clear();
            SnapshotCatalogueFloorItems.Clear();
        }


        private void SetCatalogueFurnisSnapshot()
        {
            SnapshotCatalogueWallItems = CatalogueWallFurnis.ToList();
            SnapshotCatalogueFloorItems = CatalogueFloorFurnis.ToList();
        }


        private void ClearCreditsSnapshots()
        {
            SnapshotCreditsFloorFurnis.Clear();
        }


        private void SetCreditsSnapshots()
        {
            SnapshotCreditsFloorFurnis = CreditsFloorFurnis.ToList();
        }


        private void ClearCrystalsSnapshots()
        {
            SnapshotCrystalsFloorFurnis.Clear();
            SnapshotCrystalsWallFurnis.Clear();
        }


        private void SetCrystalsSnapshots()
        {
            SnapshotCrystalsFloorFurnis = CrystalsFloorFurnis.ToList();
            SnapshotCrystalsWallFurnis = CrystalsWallItems.ToList();
        }

        private void SetRemovedFurnisSnapshot()
        {
            SnapshotRemovedFloorItems = RemovedFloorFurnis.ToList();
            SnapshotRemovedWallItems = RemovedWallFurnis.ToList();
        }

        private void ClearRemovedFurnisSnapshot()
        {
            SnapshotRemovedFloorItems.Clear();
            SnapshotRemovedWallItems.Clear();
        }

        private void AutomaticAnalyzeBtn_Click(object sender, EventArgs e)
        {
            if (AutomaticScanMode)
            {
                WriteToButton(AutomaticAnalyzeBtn, "Automatic Scan : OFF");
                AutomaticScanMode = false;
            }
            else
            {
                WriteToButton(AutomaticAnalyzeBtn, "Automatic Scan : ON");
                AutomaticScanMode = true;
            }
        }


        private void ToggleRegisteredFurnituresVisibility_Click(object sender, EventArgs e)
        {
            if (AreRegisteredFurnisHidden)
            {
                ShowRegisteredFurnis();
                AreRegisteredFurnisHidden = false;
                WriteToButton(ToggleVisibilityRegisteredRaresBtn, "Hide Registered Rares");
            }
            else
            {
                HideRegularFloorFurnis();
                HideRegularWallFurnis();
                AreRegisteredFurnisHidden = true;
                WriteToButton(ToggleVisibilityRegisteredRaresBtn, "Show Registered Rares");
            }
        }


        private void ShowRegisteredFurnis()
        {
            IS_HIDING_REGULAR_FLOORFURNIS = false;
            if (HIDDEN_REGULAR_FLOORFURNIS.Count != 0)
            {
                Connection.SendToClientAsync(FloorFurnitures.PacketBuilder(HIDDEN_REGULAR_FLOORFURNIS, In.RoomFloorItems));
                HIDDEN_REGULAR_FLOORFURNIS.Clear();
                UpdateHiddenRegularFurniLabel();
                if (isQuietMode)
                {
                    Speak("[HIDER]:All Regular Floor Furnis are unhidden!", 34);
                }

            }
            else
            {
                if (isQuietMode)
                {
                    Speak("[HIDER]:I Can't detect any Regular Hidden Floor Furni to Unhide!", 34);
                }
            }
            IS_HIDING_REGULAR_WALLFURNIS = false;
            if (HIDDEN_REGULAR_WALLFURNIS.Count != 0)
            {
                Connection.SendToClientAsync(WallFurnitures.PacketBuilder(HIDDEN_REGULAR_WALLFURNIS, In.RoomWallItems));
                HIDDEN_REGULAR_WALLFURNIS.Clear();
                UpdateHiddenRegularFurniLabel();
                if (isQuietMode)
                {
                    Speak("[HIDER]:All Regular Wall Furnis are unhidden!", 34);
                }
            }
            else
            {
                if (isQuietMode)
                {
                    Speak("[HIDER]:I Can't detect any Regular Hidden Wall Furni to Unhide!", 34);
                }
            }
        }

        private void ToggleUnregisteredFurnituresVisibility_Click(object sender, EventArgs e)
        {
            if (AreUnRegisteredFurnisHidden)
            {
                UnhideIrregularFurnis();
                WriteToButton(ToggleVisibilityUnregisteredRaresBtn, "Hide Unregistered Rares");
                AreUnRegisteredFurnisHidden = false;
            }
            else
            {
                HideIrregularWallFurnis();
                HideIrregularFloorFurnis();
                WriteToButton(ToggleVisibilityUnregisteredRaresBtn, "Show Unregistered Rares");
                AreUnRegisteredFurnisHidden = true;
            }
        }


        private void SilencedScannerBtn_Click(object sender, EventArgs e)
        {
            if (isQuietMode)
            {
                WriteToButton(SilencedScannerBtn, "Silenced : OFF");
                SpeakAnyways("The scanner will show his output message now");
                isQuietMode = false;
            }
            else
            {
                WriteToButton(SilencedScannerBtn, "Silenced : ON");
                SpeakAnyways("The scanner wont' show his output message now");
                isQuietMode = true;
            }
        }

        private void LogPageFurnisBtn_Click(object sender, EventArgs e)
        {
            if (IsLoggingPageStuff)
            {
                WriteToButton(LogPageFurnisBtn, "Catalog Page Furni Logger : OFF");
                IsLoggingPageStuff = false;
            }
            else
            {
                WriteToButton(LogPageFurnisBtn, "Catalog Page Furni Logger : ON");
                IsLoggingPageStuff = true;
            }


        }

        private void PrintClassFloorIDTOFile(int spriteid, string pagename)
        {
            try
            {
                string Filepath = "../TypeIDDump/" + RecognizeDomain.GetHost(Connection.Host) + "_Furni_Floor_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".cs";
                string FolderName = "TypeIDDump";
                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        if (isNewPage)
                        {
                            if (shoudendline)
                            {
                                txtFile.Write("};");
                                txtFile.WriteLine("");
                                shoudendline = false;
                            }
                            txtFile.WriteLine("");
                            txtFile.Write("public static readonly List<int> " + pagename + " = new List<int> { ");
                            isNewPage = false;
                        }
                        if (shouldaddnewchar)
                        {
                            txtFile.Write(", ");

                        }
                        txtFile.Write(spriteid);
                        shouldaddnewchar = true;
                    }

                }
                else if (File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        if (isNewPage)
                        {
                            if (shoudendline)
                            {
                                txtFile.Write("};");
                                txtFile.WriteLine("");
                                shoudendline = false;
                            }
                            txtFile.Write("public static readonly List<int> " + pagename + " = new List<int> { ");
                            isNewPage = false;
                        }
                        if (shouldaddnewchar)
                        {
                            txtFile.Write(", ");
                        }
                        txtFile.Write(spriteid);
                        shouldaddnewchar = true;
                    }
                }

            }

            catch (Exception)
            {

            }
        }

        private void PrintClassWallIDTOFile(int spriteid, string pagename)
        {
            try
            {
                string Filepath = "../TypeIDDump/" + RecognizeDomain.GetHost(Connection.Host) + "_Furni_Wall_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".cs";
                string FolderName = "TypeIDDump";
                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        if (isNewPage1)
                        {
                            if (shoudendline1)
                            {
                                txtFile.Write("};");
                                txtFile.WriteLine("");
                                shoudendline1 = false;
                            }
                            txtFile.Write("public static readonly List<int> " + pagename + " = new List<int> { ");
                            isNewPage1 = false;
                        }
                        if (shouldaddnewchar1)
                        {
                            txtFile.Write(", ");
                        }
                        txtFile.Write(spriteid);
                        shouldaddnewchar1 = true;
                    }

                }
                else if (File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        if (isNewPage1)
                        {
                            if (shoudendline1)
                            {
                                txtFile.Write("};");
                                txtFile.WriteLine("");
                                shoudendline1 = false;
                            }
                            txtFile.Write("public static readonly List<int> " + pagename + " = new List<int> { ");
                            isNewPage1 = false;
                        }
                        if (shouldaddnewchar1)
                        {
                            txtFile.Write(", ");
                        }
                        txtFile.Write(spriteid);
                        shouldaddnewchar1 = true;
                    }
                }

            }

            catch (Exception)
            {

            }
        }
        private void ShowCatalogueFurnis()
        {
            ClearCatalogueSnapshots();
            SetCatalogueFurnisSnapshot();
            if (SnapshotCatalogueFloorItems.Count != 0)
            {
                Connection.SendToClientAsync(FloorFurnitures.PacketBuilder(SnapshotCatalogueFloorItems, In.RoomFloorItems));
                Speak("[HIDER]:All catalogue Floor Furnis are unhidden!", 34);
            }
            else
            {
                Speak("[HIDER]:I Can't detect any catalogue Floor Furni to Unhide!", 34);
            }
            if (SnapshotCatalogueWallItems.Count != 0)
            {
                Connection.SendToClientAsync(WallFurnitures.PacketBuilder(SnapshotCatalogueWallItems, In.RoomWallItems));
                Speak("[HIDER]:All catalogue Wall Furnis are unhidden!", 34);
            }
            else
            {
                Speak("[HIDER]:I Can't detect any catalogue Wall Furni to Unhide!", 34);
            }
        }

        private void HideCatalogueFurnis()
        {
            ClearCatalogueSnapshots();
            SetCatalogueFurnisSnapshot();
            if (SnapshotCatalogueFloorItems != null && !(SnapshotCatalogueFloorItems.Count == 0))
            {
                IS_HIDING_CATALOGUE_FLOORFURNI = true;
                THREAD_HIDE_CATALOGUE_FLOORFURNIS();
            }
            else
            {
                Speak("[HIDER]:Can't find any catalogue Floor Furnis to hide!", 34);
            }

            if (SnapshotCatalogueWallItems != null && !(SnapshotCatalogueWallItems.Count == 0))
            {
                IS_HIDING_CATALOGUE_WALLFURNI = true;
                THREAD_HIDE_CATALOGUE_WALLFURNIS();
            }
            else
            {
                Speak("[HIDER]:Can't find any catalogue Wall Furnis to hide!", 34);
            }
        }

        private void ToggleVisibilityCatalogFurnisBtn_Click(object sender, EventArgs e)
        {
            if (AreCataloguesFurnisHidden)
            {
                WriteToButton(ToggleVisibilityCatalogFurnisBtn, "Hide Catalogue Furnis");
                ShowCatalogueFurnis();
                AreCataloguesFurnisHidden = false;
            }
            else
            {
                WriteToButton(ToggleVisibilityCatalogFurnisBtn, "Show Catalogue Furnis");
                HideCatalogueFurnis();
                AreCataloguesFurnisHidden = true;
            }
        }

        private void HideCrystalsFurnis()
        {
            ClearCrystalsSnapshots();
            SetCrystalsSnapshots();
            if (SnapshotCrystalsFloorFurnis.Count != 0)
            {
                IS_HIDING_CRYSTALS_FLOORFURNIS = true;
                THREAD_HIDE_CRYSTALS_FLOORFURNIS();
            }
            else
            {
                Speak("[HIDER]:Can't find any Crystals Floor Furnis to hide!", 34);
            }
            if (SnapshotCrystalsWallFurnis.Count != 0)
            {
                IS_HIDING_CRYSTALS_WALLFURNIS = true;
                THREAD_HIDE_CRYSTALS_WALLFURNIS();
            }
            else
            {
                Speak("[HIDER]:Can't find any Crystals Wall Furnis to hide!", 34);
            }
        }
        private void ShowCrystalFurnis()
        {
            ClearCrystalsSnapshots();
            SetCrystalsSnapshots();
            if (SnapshotCrystalsFloorFurnis.Count != 0)
            {
                Connection.SendToClientAsync(FloorFurnitures.PacketBuilder(SnapshotCrystalsFloorFurnis, In.RoomFloorItems));
                Speak("[HIDER]:All Crystals Floor Furnis are unhidden!", 34);
            }
            else
            {
                Speak("[HIDER]:I Can't detect any Crystals Floor Furni to Unhide!", 34);
            }
            if (SnapshotCrystalsWallFurnis.Count != 0)
            {
                Connection.SendToClientAsync(WallFurnitures.PacketBuilder(SnapshotCrystalsWallFurnis, In.RoomWallItems));
                Speak("[HIDER]:All Crystals Wall Furnis are unhidden!", 34);
            }
            else
            {
                Speak("[HIDER]:I Can't detect any Crystals Wall Furni to Unhide!", 34);
            }
        }


        private void ToggleVisibilityCrystalsFurnisBtn_Click(object sender, EventArgs e)
        {
            if (AreCrystalsFurnisHidden)
            {
                WriteToButton(ToggleVisibilityCrystalsFurnisBtn, "Hide Crystals Furnis");
                ShowCrystalFurnis();
                AreCrystalsFurnisHidden = false;
            }
            else
            {
                WriteToButton(ToggleVisibilityCrystalsFurnisBtn, "Show Crystals Furnis");
                HideCrystalsFurnis();
                AreCrystalsFurnisHidden = true;
            }
        }

        private void HideCreditsFurnis()
        {
            ClearCreditsSnapshots();
            SetCreditsSnapshots();
            if (SnapshotCreditsFloorFurnis.Count != 0)
            {
                IS_HIDING_CREDITS_FURNIS = true;
                THREAD_HIDE_CREDITS_FLOORFURNIS();
            }
            else
            {
                Speak("[HIDER]:Can't find any Credits Furnis to hide!", 34);
            }
        }
        private void ShowCreditsFurnis()
        {
            ClearCreditsSnapshots();
            SetCreditsSnapshots();
            if (SnapshotCreditsFloorFurnis.Count != 0)
            {
                Connection.SendToClientAsync(FloorFurnitures.PacketBuilder(SnapshotCreditsFloorFurnis, In.RoomFloorItems));
                Speak("[HIDER]:All Credits Furnis are unhidden!", 34);
            }
            else
            {
                Speak("[HIDER]:I Can't detect any Crystals Floor Furni to Unhide!", 34);
            }
        }
        private void ToggleVisibilityCreditsFurnisBtn_Click(object sender, EventArgs e)
        {
                if (AreCreditsFurnisHidden)
                {
                    WriteToButton(ToggleVisibilityCreditsFurnisBtn, "Hide Credits Furnis");
                    ShowCreditsFurnis();
                AreCreditsFurnisHidden = false;
                }
                else
                {
                    WriteToButton(ToggleVisibilityCreditsFurnisBtn, "Show Credits Furnis");
                    HideCreditsFurnis();
                    AreCreditsFurnisHidden = true;
                }
            }
        } 
    }