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

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FurnitureChecker:  ObservablePage
    {
        private List<HFloorItem> RoomFloorFurni { get => FloorFurnitures.Furni; }
        private List<HWallItem> RoomWallFurni { get => WallFurnitures.Furni; }

        List<HWallItem> IrregularWallFurni;
        List<HFloorItem> IrregularFloorFurni;

        List<HWallItem> RegularWallFurni;
        List<HFloorItem> RegularFloorFurni;



        List<HWallItem> WhitelistedWallFurni;
        List<HFloorItem> WhiteListedFloorFurni;


        List<HWallItem> HIDDEN_IRREGULAR_WALLFURNIS;
        List<HFloorItem> HIDDEN_IRREGULAR_FLOORFURNIS;

        List<HWallItem> HIDDEN_REGULAR_WALLFURNIS;
        List<HFloorItem> HIDDEN_REGULAR_FLOORFURNIS;

        List<HFloorItem> RoomSnapshotFloorFurni;
        List<HWallItem> RoomSnapshotWallFurni;

        List<HFloorItem> RemovedFloorFurnis;
        List<HWallItem> RemovedWallFurnis;

        List<HFloorItem> SnapShotIrregularFloorFurni;
        List<HWallItem> SnapShotIrregularWallFurni;

        List<HFloorItem> SnapshotRegularFloorItems;
        List<HWallItem> SnapshotRegularWallItems;


        List<HFloorItem> SnapshotRemovedFloorItems;
        List<HWallItem> SnapshotRemovedWallItems;

        private readonly List<int> SelectedSpriteIds = new List<int>{2757,3014,2734,3055,1967,1966,1738,2969,2975,1977,1764,1979,285,2520,3896,1980,4542,285,1971,3191,2374,285,3191,285,3091 };
        private readonly List<int> SelectedPublicCrystalsIds = new List<int> { 3191, 457, 2631, 4425, 2940, 2995, 1625, 1624, 1621, 1620, 3929, 4532, 1627, 1590, 1588, 1587, 1586, 1585, 1584, 1583, 1582, 1581, 1580, 1579, 1574, 1573, 1572, 1571, 1609, 1570, 1568, 1567, 1566, 1565, 1564, 1562, 1559, 1560, 1563, 1606, 1561, 1558, 1557, 1556, 1555, 1554, 1552, 1553, 1551, 1550, 1549, 1638, 1637, 1636, 1635, 1634, 1633, 1632, 1631, 1630, 1629, 1608, 1607, 1599, 1605, 1604, 1603, 1602, 1601, 1600, 1618, 1617, 1616, 1615, 1614, 1612, 1613, 4661, 4660, 1610, 1611, 18854, 10698, 1775, 1774, 1770, 1769, 1768, 1767, 1766, 1765, 1648, 1647, 1646, 1645, 1644, 1643, 1641, 1642, 1640, 1639, 1592, 1598, 1597, 1596, 1595, 1594, 1593, 1589, 1591 };

        private bool REM_IRR_FLOOR_FURNI;
        private bool REM_IRR_WALL_FURNI;
        private bool REM_REG_WALL_FURNI;
        private bool REM_REG_FLOOR_FURNI;

        private bool SHOULD_UPDATE_FILES;


        private string ExcelFilePath;

        private Random ran = new Random();

        #region hideshit
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

        private bool _AUTOMATIC_IRREGULAR_HIDER;

        public bool AUTOMATIC_IRREGULAR_HIDER
        {
            get => _AUTOMATIC_IRREGULAR_HIDER;
            set
            {
                _AUTOMATIC_IRREGULAR_HIDER = value;
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
        private bool _AUTOMATIC_REGULAR_HIDER;

        public bool AUTOMATIC_REGULAR_HIDER
        {
            get => _AUTOMATIC_REGULAR_HIDER;
            set
            {
                _AUTOMATIC_REGULAR_HIDER = value;
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


        #endregion
        public FurnitureChecker()
        {
            InitializeComponent();
            Bind(FurniIDToCheckNbx, "Value", nameof(ControlledFloorFurni));

            //System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromMinutes(3).TotalMilliseconds);
            //timer.AutoReset = true;
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(UpdateExcelFilesThread);
            //timer.Start();


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
            RoomSnapshotFloorFurni = new List<HFloorItem>();
            RoomSnapshotWallFurni = new List<HWallItem>();
            RemovedWallFurnis = new List<HWallItem>();
            RemovedFloorFurnis = new List<HFloorItem>();

            SnapshotRegularFloorItems = new List<HFloorItem>();
            SnapshotRegularWallItems = new List<HWallItem>();
            SnapShotIrregularFloorFurni = new List<HFloorItem>();
            SnapShotIrregularWallFurni = new List<HWallItem>();

            SnapshotRemovedFloorItems = new List<HFloorItem>();
            SnapshotRemovedWallItems = new List<HWallItem>();
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
                        Speak("Not Adding : " + file + " Because is already in the list", 30);
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
                    CheckForRares(wall, isQuiet);
                    return;
                }
                if (floor != null)
                {
                    CheckForRares(floor, isQuiet);

                    return;
                }

                if (remfloor != null)
                {
                    CheckForRares(remfloor, isQuiet);
                    return;
                }
                if (remwall != null)
                {
                    CheckForRares(remwall, isQuiet);
                    return;
                }

                CheckForRares(id, isQuiet);
                return;
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
                            Speak("This Furni is Irregular!", 30);
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
                                Speak("This Furni is Irregular!", 30);
                        }
                        RecordRareControl(false, "[IRREGOLARE] : " + wall.Id);


                        if (!IrregularWallFurni.Contains(wall))
                        {
                            IrregularWallFurni.Add(wall);
                            UpdateIrregolarFurniLabel();
                        }
                        if (AUTOMATIC_IRREGULAR_HIDER)
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
                        if (AUTOMATIC_REGULAR_HIDER)
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
                            Speak("This Furni is whitelisted!", 30);
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
                    if (!SelectedPublicCrystalsIds.Contains(furni.TypeId))
                    {
                        bool isRegular = SearchPaymentRare(furni, isQuiet);
                        if (!isRegular)
                        {
                            if (!WhiteListedFloorFurni.Contains(furni) && WhiteListedFloorFurni != null)
                            {
                                if (!isQuiet)
                                {
                                    Speak("This Furni is Irregular!", 30);
                                }
                                RecordRareControl(false, "[IRREGOLARE] : " + furni.Id);

                                if (!IrregularFloorFurni.Contains(furni))
                                {
                                    IrregularFloorFurni.Add(furni);
                                    UpdateIrregolarFurniLabel();
                                }
                                if (AUTOMATIC_IRREGULAR_HIDER)
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
                                    Speak("This Furni is whitelisted!", 30);
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
                        if (AUTOMATIC_REGULAR_HIDER)
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
                            Speak("This Furni is Regular, Is available in public catalogue!", 30);
                        }
                    }
                }
                else
                {
                    if (!RegularFloorFurni.Contains(furni))
                    {
                        RegularFloorFurni.Add(furni);
                    }
                    if (AUTOMATIC_REGULAR_HIDER)
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
                        Speak("This Furni is Regular, matches conditions set!!", 30);
                    }
                }
            }
        }

        private void FixExcel(string path, bool isQuiet, bool isManualUpdate)
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
            //foreach (Worksheet sheet in workbook.Worksheets)
            //{
            //    sheet.Tab.ColorIndex = XlColorIndex.xlColorIndexNone;
            //    if(sheet.Name.Contains("MISTERYBOX"))
            //    {
            //        sheet.Name = "misterybox_fixed";
            //        sheet.Columns.ClearOutline();
            //        sheet.Cells.Font.Color = Color.Empty;
            //        sheet.Cells.Font.ColorIndex = Color.Empty;
            //    }
            //}
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
            ConvertExcelSheetsToTexts(newpath, isQuiet, isManualUpdate);
        }


        private void ConvertExcelSheetsToTexts(string path, bool isQuiet, bool isManualUpdate)
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
                    if (!isQuiet)
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
                                Speak(line, 30);
                            }
                            RecordRareControl(true, "[REGOLARE] : " + id);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool isParticularFurni(HFloorItem flooritem, bool IsQuiet)
        {
            if (SelectedSpriteIds.Contains(flooritem.TypeId))
            {
                if ((flooritem.Id > 684921524) && (flooritem.Id < 685173361))
                {
                        if (AUTOMATIC_REGULAR_HIDER)
                        {
                            if (!HIDDEN_REGULAR_FLOORFURNIS.Contains(flooritem))
                            {
                                HIDDEN_REGULAR_FLOORFURNIS.Add(flooritem);
                            }
                            HideFurnisClient(flooritem);
                        UpdateHiddenRegularFurniLabel();
                        }
                        return true;
                    }
                    return false;
                }
                return false;
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
                                    Speak(line, 30);
                                }
                                if (!RegularFloorFurni.Contains(flooritem))
                                {
                                    RegularFloorFurni.Add(flooritem);
                                    UpdateRegularFurniLabel();
                                    if (AUTOMATIC_REGULAR_HIDER)
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

                if (AUTOMATIC_IRREGULAR_HIDER)
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
                                Speak(line, 30);
                            }
                            if (!RegularWallFurni.Contains(wallitem))
                            {
                                RegularWallFurni.Add(wallitem);
                                UpdateRegularFurniLabel();
                                if (AUTOMATIC_REGULAR_HIDER)
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
            if (AUTOMATIC_IRREGULAR_HIDER)
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
            Speak(message, 30);
            return true;
        }

        private void UpdateTotFurniInRoomLabel()
        {
            int a = SyncWallFurniCount();
            int b = SyncFloorFurniCount();
            int c = a + b;
            WriteToLabel(TotFurnisinroomLbl, "Tot Furni In room  : " + c);
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
            UpdateTotFurniInRoomLabel();
        }

        private void UpdateRemovedFloorFurniLbl()
        {
            WriteToLabel(RemovedFloorFurnisLbl, "Removed Floor Furnis : " + SyncRemovedFloorFurniCount());
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

        }


        private void ResetRareFloorScanner()
        {
            IrregularFloorFurni.Clear();
            RegularFloorFurni.Clear();
        }

        private void ResetRareWallScanner()
        {
            IrregularWallFurni.Clear();
            RegularWallFurni.Clear();
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

        private async void Speak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(150);
                await Connection.SendToClientAsync(In.RoomUserTalk, 0, text, 0, 34, 0, -1);
            }
        }

        private async void Speak(string text, int bubble)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(50);
                await Connection.SendToClientAsync(In.RoomUserTalk, 0, text, 0, bubble, 0, -1);
            }
        }

        public override void In_WallItemUpdate(DataInterceptedEventArgs e )
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
            RemovedWallFurnis.Clear();
            RemovedFloorFurnis.Clear();
            WhiteListedFloorFurni.Clear();
            WhitelistedWallFurni.Clear();
            RoomSnapshotFloorFurni.Clear();
            RoomSnapshotWallFurni.Clear();
            HIDDEN_IRREGULAR_FLOORFURNIS.Clear();
            HIDDEN_IRREGULAR_WALLFURNIS.Clear();
            HIDDEN_REGULAR_FLOORFURNIS.Clear();
            HIDDEN_REGULAR_WALLFURNIS.Clear();
            SnapshotRegularFloorItems.Clear();
            SnapshotRegularWallItems.Clear();
            SnapShotIrregularFloorFurni.Clear();
            SnapShotIrregularWallFurni.Clear();
            SnapshotRemovedFloorItems.Clear();
            SnapshotRegularWallItems.Clear();
            IS_SCANNING_FLOORFURNIS = false;
            IS_SCANNING_WALLFURNIS = false;
            IS_HIDING_REGULAR_WALLFURNIS = false;
            IS_HIDING_REGULAR_FLOORFURNIS = false;
            ResetRoomScannerLabels();
            ResetRareFloorScanner();
            ResetRareWallScanner();
            UpdateAllLabels();
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
                Speak("Rotate Furni / Rare To check if is a irregular or not!", 30);
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

        private void StoreFurniIDOnFileChbx_CheckedChanged(object sender, EventArgs e)
        {

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
                        if (RoomSnapshotWallFurni != null && RoomSnapshotWallFurni.Count != 0)
                        {
                            foreach (HWallItem item in RoomSnapshotWallFurni)
                            {
                                CheckForRares(item, true);
                                UpdateIrregolarFurniLabel();
                                UpdateRegularFurniLabel();
                            }
                            if (!isQuietMode)
                            {
                                Speak("Scanned all Wall Furnis!", 30);
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
                        if (RoomSnapshotFloorFurni != null && RoomSnapshotFloorFurni.Count != 0)
                        {

                            foreach (HFloorItem item in RoomSnapshotFloorFurni)
                            {
                                CheckForRares(item, true);
                                UpdateIrregolarFurniLabel();
                                UpdateRegularFurniLabel();
                            }
                            if (!isQuietMode)
                            {
                                Speak("Scanned all Floor Furnis!", 30);
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
                FixExcel(ExcelFilePath, false, false);
            }).Start();
        }




        private void ClearRoomSnapshots()
        {
            RoomSnapshotWallFurni.Clear();
            RoomSnapshotFloorFurni.Clear();
        }
        private void SetRoomWallSnapshot()
        {
            RoomSnapshotWallFurni = RoomWallFurni.ToList();
        }

        private void SetRoomFloorSnapshot()
        {
            RoomSnapshotFloorFurni = RoomFloorFurni.ToList();
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
                if (RoomSnapshotFloorFurni != null && !(RoomSnapshotFloorFurni.Count == 0))
                {
                    if (!isQuietMode)
                    {
                    Speak("Scanning Room Floor Furnis....", 30);
                    }
                    StartFloorFurnIAnalyzer();
                }
                else
                {
                    if (!isQuietMode)
                    {
                        Speak("No Floor Furnis Detected.", 30);
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
                if (RoomSnapshotWallFurni != null && !(RoomSnapshotWallFurni.Count == 0))
                {
                    if (!isQuietMode)
                    {
                        Speak("Scanning Room Wall Furnis....", 30);
                    }
                    StartWallFurniAnalyzer();
                }
                else
                {
                    if (!isQuietMode)
                    {
                        Speak("No Wall Furnis Detected.", 30);
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
                    Speak("Wait, im still scanning All Floor Furnis in room!", 30);
                }
                if (!IS_SCANNING_WALLFURNIS)
                {
                    IS_SCANNING_WALLFURNIS = true;
                    ResetRareWallScanner();
                    RoomWallChecker();
                }
                else
                {
                    Speak("Wait, im still scanning All Wall Furnis in room!", 30);
                }

            }
            else
            {
                Speak("Please add some files!", 30);

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

                            FixExcel(ExcelFilePath, true, true);
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
                            FixExcel(ExcelFilePath, true, false);
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
                Speak("Checking ID : " + FurniID, 30);
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
            var removedfloorfurni = RemovedFloorFurnis.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, Coord_x, Coord_y);
                return;
            }
            if (removedfloorfurni != null)
            {
                UpdateFurniMovement(removedfloorfurni, Coord_x, Coord_y);
                return;
            }
        }


        private void UpdateFurniMovement(int furni, int Coord_x, int Coord_y, int Coord_z)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == furni);
            var removedfloorfurni = RemovedFloorFurnis.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, Coord_x, Coord_y, Coord_z);
                return;
            }
            if (removedfloorfurni != null)
            {
                UpdateFurniMovement(removedfloorfurni, Coord_x, Coord_y, Coord_z);
                return;
            }
        }

        private void UpdateFurniMovement(int furni, int Coord_x, int Coord_y, string Coord_z)
        {
            var roomfurni = RoomFloorFurni.Find(x => x.Id == furni);
            var removedfloorfurni = RemovedFloorFurnis.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, Coord_x, Coord_y, Coord_z);
                return;
            }
            if (removedfloorfurni != null)
            {
                UpdateFurniMovement(removedfloorfurni, Coord_x, Coord_y, Coord_z);
                return;
            }
        }

        private void UpdateFurniMovement(int furni, string wallcoord)
        {
            var roomfurni = RoomWallFurni.Find(x => x.Id == furni);
            var removedfloorfurni = RemovedWallFurnis.Find(x => x.Id == furni);
            if (roomfurni != null)
            {
                UpdateFurniMovement(roomfurni, wallcoord);
                return;
            }
            if (removedfloorfurni != null)
            {
                UpdateFurniMovement(removedfloorfurni, wallcoord);
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
            var removedfloorfurni = RemovedFloorFurnis.Find(x => x == furni);
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
            if (removedfloorfurni != null)
            {
                removedfloorfurni.Tile.X = Coord_x;
                removedfloorfurni.Tile.Y = Coord_y;
            }
        }

        private void UpdateFurniMovement(HFloorItem furni, int Coord_x, int Coord_y, int Coord_z)
        {
            var hiddenregular = HIDDEN_REGULAR_FLOORFURNIS.Find(x => x == furni);
            var hiddenirregular = HIDDEN_IRREGULAR_FLOORFURNIS.Find(x => x == furni);
            var whitelist = WhiteListedFloorFurni.Find(x => x == furni);
            var regular = RegularFloorFurni.Find(x => x == furni);
            var irregular = IrregularFloorFurni.Find(x => x == furni);
            var removedfloorfurni = RemovedFloorFurnis.Find(x => x == furni);
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
            if (removedfloorfurni != null)
            {
                removedfloorfurni.Tile.X = Coord_x;
                removedfloorfurni.Tile.Y = Coord_y;

                    removedfloorfurni.Tile.Z = Coord_z;
                
            }
        }

        private void UpdateFurniMovement(HFloorItem furni, int Coord_x, int Coord_y, string Coord_z)
        {
            var hiddenregular = HIDDEN_REGULAR_FLOORFURNIS.Find(x => x == furni);
            var hiddenirregular = HIDDEN_IRREGULAR_FLOORFURNIS.Find(x => x == furni);
            var whitelist = WhiteListedFloorFurni.Find(x => x == furni);
            var regular = RegularFloorFurni.Find(x => x == furni);
            var irregular = IrregularFloorFurni.Find(x => x == furni);
            var removedfloorfurni = RemovedFloorFurnis.Find(x => x == furni);
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
            if (removedfloorfurni != null)
            {
                removedfloorfurni.Tile.X = Coord_x;
                removedfloorfurni.Tile.Y = Coord_y;
                if (Double.TryParse(Coord_z, out Double res))
                {
                    removedfloorfurni.Tile.Z = res;
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
            var removedwallfurni = RemovedWallFurnis.Find(x => x == furni);

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
            if (removedwallfurni != null)
            {
                removedwallfurni.Location = wallcoord;
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
                if (AUTOMATIC_REGULAR_HIDER)
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
                if (AUTOMATIC_REGULAR_HIDER)
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
                Speak("Checking ID : " + WallFurni, 30);
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
                if (RemovedFloorFurnis.Contains(NewFloorFurnis))
                {
                    RemovedFloorFurnis.Remove(NewFloorFurnis);
                }
                if (!RoomFloorFurni.Contains(NewFloorFurnis))
                {
                    RoomFloorFurni.Add(NewFloorFurnis);
                }
                if (AutomaticScanMode)
                {
                    CheckForRares(NewFloorFurnis, true);
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

                if (RemovedWallFurnis.Contains(NewPlacedWallFurni))
                {
                    RemovedWallFurnis.Remove(NewPlacedWallFurni);
                }
                if (AutomaticScanMode)
                {
                    CheckForRares(NewPlacedWallFurni, true);
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
            e.Continue();
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
            if (!RemovedWallFurnis.Contains(item))
            {
                RemovedWallFurnis.Add(item);
            }
            if (HIDDEN_IRREGULAR_WALLFURNIS.Contains(item))
            {
                HIDDEN_IRREGULAR_WALLFURNIS.Remove(item);
            }
            if (HIDDEN_REGULAR_WALLFURNIS.Contains(item))
            {
                HIDDEN_REGULAR_WALLFURNIS.Remove(item);
            }
            UpdateAllLabels();
        }


        private void HandleRemovedFurni(HFloorItem item)
        {
            try
            {
                if (IrregularFloorFurni.Contains(item))
                {
                    IrregularFloorFurni.Remove(item);
                }
                if (RegularFloorFurni.Contains(item))
                {
                    RegularFloorFurni.Remove(item);
                }
                if (!RemovedFloorFurnis.Contains(item))
                {
                    RemovedFloorFurnis.Add(item);
                }
                if (HIDDEN_IRREGULAR_FLOORFURNIS.Contains(item))
                {
                    HIDDEN_IRREGULAR_FLOORFURNIS.Remove(item);
                }
                if (HIDDEN_REGULAR_FLOORFURNIS.Contains(item))
                {
                    HIDDEN_REGULAR_FLOORFURNIS.Remove(item);
                }
                UpdateAllLabels();
            }

            catch (Exception) { }
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
                Speak("Checking ID : " + FurniID, 30);
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
                Speak("Checking ID : " + FurniID, 30);
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


        private void HideRegisteredFurnisBtn_Click(object sender, EventArgs e)
        {
            if (AUTOMATIC_REGULAR_HIDER)
            {
                WriteToButton(HideRegisteredFurnisBtn, "Hide Registered Furnis : OFF");
                AUTOMATIC_REGULAR_HIDER = false;
            }
            else
            {
                WriteToButton(HideRegisteredFurnisBtn, "Hide Registered Furnis : ON");
                AUTOMATIC_REGULAR_HIDER = true;
            }
        }


        private void HideIrregularWallFurnis()
        {
            if (IrregularWallFurni.Count != 0 && IrregularWallFurni != null && !IS_HIDING_IRREGULAR_WALLFURNIS)
            {
                IS_HIDING_IRREGULAR_WALLFURNIS = true;
                THREAD_HIDE_IRREGULAR_WALLFURNIS();
                Speak("[AUTOMATIC HIDER CLIENT]: Hiding all irregular Wall Furnis...", 30);
            }
            else
            {
                Speak("[AUTOMATIC HIDER CLIENT]: Can't find any irregular wall furnis to hide!", 30);
            }
        }

        private void HideIrregularFloorFurnis()
        {
            if (IrregularFloorFurni.Count != 0 && IrregularFloorFurni != null && !IS_HIDING_IRREGULAR_FLOORFURNIS)
            {
                IS_HIDING_IRREGULAR_FLOORFURNIS = true;
                THREAD_HIDE_IRREGULAR_FLOORFURNIS();
                Speak("[AUTOMATIC HIDER CLIENT]: Hiding all irregular floor Furnis...", 30);
            }
            else
            {
                Speak("[AUTOMATIC HIDER CLIENT]: Can't find any irregular floor floor to hide!", 30);
            }
        }


        private void HideRegularWallFurnis()
        {
            if (RegularWallFurni.Count != 0 && RegularWallFurni != null && !IS_HIDING_REGULAR_WALLFURNIS)
            {
                IS_HIDING_REGULAR_WALLFURNIS = true;
                THREAD_HIDE_REGULAR_WALLFURNIS();
                Speak("[AUTOMATIC HIDER CLIENT]: Hiding all regular Wall Furnis...", 30);
            }
            else
            {
                Speak("[AUTOMATIC HIDER CLIENT]: Can't find any regular wall furnis to hide!", 30);
            }
        }

        private void HideRegularFloorFurnis()
        {
            if (RegularFloorFurni.Count != 0 && RegularFloorFurni != null && !IS_HIDING_REGULAR_FLOORFURNIS)
            {
                IS_HIDING_REGULAR_FLOORFURNIS = true;
                THREAD_HIDE_REGULAR_FLOORFURNIS();
                Speak("[AUTOMATIC HIDER CLIENT]: Hiding all regular floor Furnis...", 30);
            }
            else
            {
                Speak("[AUTOMATIC HIDER CLIENT]: Can't find any regular wall floor to hide!", 30);
            }
        }

        private void HideIrregularFurnisBtn_Click(object sender, EventArgs e)
        {
            if (AUTOMATIC_IRREGULAR_HIDER)
            {
                WriteToButton(HideIrregularFurnisBtn, "Hide Unregistered Furnis : OFF");
                AUTOMATIC_IRREGULAR_HIDER = false;
            }
            else
            {
                WriteToButton(HideIrregularFurnisBtn, "Hide Unregistered Furnis : ON");
                AUTOMATIC_IRREGULAR_HIDER = true;
            }
        }

        private void RestoreRegisteredFurnisBtn_Click(object sender, EventArgs e)
        {
            IS_HIDING_REGULAR_FLOORFURNIS = false;
            if (HIDDEN_REGULAR_FLOORFURNIS.Count != 0)
            {
                Connection.SendToClientAsync(FloorFurnitures.PacketBuilder(HIDDEN_REGULAR_FLOORFURNIS, In.RoomFloorItems));
                HIDDEN_REGULAR_FLOORFURNIS.Clear();
                UpdateHiddenRegularFurniLabel();
                Speak("[CLIENT]:All Regular Floor Furnis are unhidden!", 30);

            }
            else
            {
                Speak("[CLIENT]:I Can't detect any Regular Hidden Floor Furni to Unhide!", 30);
            }
            IS_HIDING_REGULAR_WALLFURNIS = false;
            if (HIDDEN_REGULAR_WALLFURNIS.Count != 0)
            {
                Connection.SendToClientAsync(WallFurnitures.PacketBuilder(HIDDEN_REGULAR_WALLFURNIS, In.RoomWallItems));
                HIDDEN_REGULAR_WALLFURNIS.Clear();
                UpdateHiddenRegularFurniLabel();
                Speak("[CLIENT]:All Regular Wall Furnis are unhidden!", 30);

            }
            else
            {
                Speak("[CLIENT]:I Can't detect any Regular Hidden Wall Furni to Unhide!", 30);
            }
        }

        private void RestoreUnregisteredFurnisBtn_Click(object sender, EventArgs e)
        {
            IS_HIDING_IRREGULAR_FLOORFURNIS = false;
            if (HIDDEN_IRREGULAR_FLOORFURNIS.Count != 0)
            {
                Connection.SendToClientAsync(FloorFurnitures.PacketBuilder(HIDDEN_IRREGULAR_FLOORFURNIS, In.RoomFloorItems));
                HIDDEN_IRREGULAR_FLOORFURNIS.Clear();
                UpdateHiddenRegularFurniLabel();
                Speak("[CLIENT]:All Irregular Floor Furnis are unhidden!", 30);
            }
            else
            {
                Speak("[CLIENT]:I Can't detect any Irregular Hidden Floor Furni to Unhide!", 30);
            }
            IS_HIDING_IRREGULAR_WALLFURNIS = false;
            if (HIDDEN_IRREGULAR_WALLFURNIS.Count != 0)
            {
                Connection.SendToClientAsync(WallFurnitures.PacketBuilder(HIDDEN_IRREGULAR_WALLFURNIS, In.RoomWallItems));
                HIDDEN_IRREGULAR_WALLFURNIS.Clear();
                UpdateHiddenRegularFurniLabel();
                Speak("[CLIENT]:All Irregular Wall Furnis are unhidden!", 30);
            }
            else
            {
                Speak("[CLIENT]:I Can't detect any Irregular Hidden Wall Furni to Unhide!", 30);
            }
        }

        private void RemoveRemovedFurnisBtn_Click(object sender, EventArgs e)
        {
            ClearRemovedFurnisSnapshot();
            SetRemovedFurnisSnapshot();
            if(SnapshotRemovedFloorItems != null && !(SnapshotRemovedFloorItems.Count == 0))
            {
                IS_HIDING_REMOVED_FLOORFURNI = true;
                THREAD_HIDE_REMOVED_FLOORFURNIS();
            }
            else
            {
                Speak("[CLIENT]:Can't find any removed Floor Furnis to remove!", 30);
            }

            if (SnapshotRegularWallItems != null && !(SnapshotRegularWallItems.Count == 0))
            {
                IS_HIDING_REMOVED_WALLFURNI = true;
                THREAD_HIDE_REMOVED_WALLFURNIS();
            }
            else
            {
                Speak("[CLIENT]:Can't find any removed Wall Furnis to remove!", 30);
            }


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
        private void ShowRemovedFurnisBtn_Click(object sender, EventArgs e)
        {
            ClearRemovedFurnisSnapshot();
            SetRemovedFurnisSnapshot();
            if (SnapshotRemovedFloorItems.Count != 0)
            {
                Connection.SendToClientAsync(FloorFurnitures.PacketBuilder(SnapshotRemovedFloorItems, In.RoomFloorItems));
                UpdateHiddenRegularFurniLabel();
                Speak("[CLIENT]:All removed Floor Furnis are unhidden!", 30);
            }
            else
            {
                Speak("[CLIENT]:I Can't detect any removed Hidden Floor Furni to Unhide!", 30);
            }
            if (SnapshotRemovedWallItems.Count != 0)
            {
                Connection.SendToClientAsync(WallFurnitures.PacketBuilder(SnapshotRemovedWallItems, In.RoomWallItems));
                UpdateHiddenRegularFurniLabel();
                Speak("[CLIENT]:All removed Wall Furnis are unhidden!", 30);
            }
            else
            {
                Speak("[CLIENT]:I Can't detect any removed Hidden Wall Furni to Unhide!", 30);
            }
        }

        private void AutomaticAnalyzeBtn_Click(object sender, EventArgs e)
        {
            if(AutomaticScanMode)
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

        private void HIDEREGISTEREDFURNITURES_Click(object sender, EventArgs e)
        {
                HideRegularFloorFurnis();
                HideRegularWallFurnis();
        }

        private void HideUnregisteredFurnitures_Click(object sender, EventArgs e)
        {
                HideIrregularWallFurnis();
                HideIrregularFloorFurnis();
        }


        private void SilencedScannerBtn_Click(object sender, EventArgs e)
        {
            if (isQuietMode)
            {
                WriteToButton(SilencedScannerBtn, "Silenced : OFF");
                Speak("The scanner will show his output message now");
                isQuietMode = false;
            }
            else
            {
                WriteToButton(SilencedScannerBtn, "Silenced : ON");
                Speak("The scanner wont' show his output message now");
                isQuietMode = true;
            }
        }

    }

}