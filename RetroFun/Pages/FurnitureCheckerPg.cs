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
using System.Deployment.Internal;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Timers;
using System.Linq.Expressions;
using System.Drawing;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FurnitureChecker : ObservablePage, ISubscriber
    {
        private HMessage FurniDataStored;

        List<HFloorItem> RoomFloorFurni;
        List<HWallItem> RoomWallFurni;


        List<HWallItem> IrregularWallFurni;
        List<HFloorItem> IrregularFloorFurni;

        List<HWallItem> RegularWallFurni;
        List<HFloorItem> RegularFloorFurni;

        List<int> RemovedWallFurnis;
        List<int> RemovedFloorFurnis;


        private bool REM_IRR_FLOOR_FURNI;
        private bool REM_IRR_WALL_FURNI;
        private bool REM_REG_WALL_FURNI;
        private bool REM_REG_FLOOR_FURNI;

        private bool SHOULD_UPDATE_FILES;

        private string ExcelFilePath;

        private Random ran = new Random();
        private bool _doubleClickFurnitureRemoval;
        private bool ConvertWalkinFurniMovement;
        private bool ShouldIRemoveIrregolar;
        private bool FurniIDToCheckMode;
        private bool IsRoomScannerActivated;

        private int _FloorFurniID;


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



        private bool isTeleportFurni = true;
        private bool IsWalkingFurni;

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

        public bool IsReceiving => true;

        public FurnitureChecker()
        {
            InitializeComponent();
            Bind(FurniIDToCheckNbx, "Value", nameof(ControlledFloorFurni));

            System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromMinutes(3).TotalMilliseconds);
            timer.AutoReset = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(UpdateExcelFilesThread);
            timer.Start();


            FilePathList = new List<string>();
            RoomFloorFurni = new List<HFloorItem>();
            RoomWallFurni = new List<HWallItem>();
            IrregularWallFurni = new List<HWallItem>();
            IrregularFloorFurni = new List<HFloorItem>();
            RegularWallFurni = new List<HWallItem>();
            RegularFloorFurni = new List<HFloorItem>();
            RemovedWallFurnis = new List<int>();
            RemovedFloorFurnis = new List<int>();
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
            SelectedFile.Filter = "All Files (*.*)|*.*";
            SelectedFile.FilterIndex = 1;
            SelectedFile.Multiselect = false;

            if (SelectedFile.ShowDialog() == DialogResult.OK)
            {
                ExcelFilePath = SelectedFile.FileName;
                StartExcelConverter();
                Speak("Starting conversion of file " + SelectedFile.FileName + " !");
            }
        }

        private void CheckForRares(int id, bool isQuiet)
        {

            if (FilePathList != null && FilePathList.Count != 0)
            {
                bool isRegular = SearchPaymentRare(id, isQuiet);
                if (!isRegular)
                {
                    if (!isQuiet)
                    {
                        Speak("This Furni is NOT Registered!", 30);
                    }
                    RecordRareControl(false, "[IRREGOLARE] : " + id);
                    if (ShouldIRemoveIrregolar)
                    {
                        PickFurniSS(id);
                    }
                }
            }
        }


        private void CheckForRares(HWallItem wallitem, bool isQuiet)
        {

            if (FilePathList != null && FilePathList.Count != 0)
            {
                bool isRegular = SearchPaymentRare(wallitem, isQuiet);
                if (!isRegular)
                {
                    if (!isQuiet)
                    {
                        Speak("This Furni is NOT Registered!", 30);
                    }
                    RecordRareControl(false, "[IRREGOLARE] : " + wallitem.Id);
                    if (!IrregularWallFurni.Contains(wallitem))
                    {
                        IrregularWallFurni.Add(wallitem);
                        UpdateIrregolarFurniLabel();
                    }
                    if (ShouldIRemoveIrregolar)
                    {
                        PickFurniSS(wallitem.Id);
                    }
                }
            }
        }

        private void CheckForRares(HFloorItem FloorItem, bool isQuiet)
        {
            if (FilePathList != null && FilePathList.Count != 0)
            {
                bool isRegular = SearchPaymentRare(FloorItem, isQuiet);
                if (!isRegular)
                {
                    if (!isQuiet)
                    {
                        Speak("This Furni is NOT Registered!", 30);
                    }
                    RecordRareControl(false, "[IRREGOLARE] : " + FloorItem.Id);
                    if (!IrregularFloorFurni.Contains(FloorItem))
                    {
                        IrregularFloorFurni.Add(FloorItem);
                        UpdateIrregolarFurniLabel();
                    }
                    if (ShouldIRemoveIrregolar)
                    {
                        PickFurniSS(FloorItem.Id);
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
            if (!FilePathList.Contains(path) && !path.Contains("Recuperati_Foglio1"))
            {
                FilePathList.Add(path);
                UpdateFileLabel();
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
                                }
                                RecordRareControl(true, "[REGOLARE] : " + flooritem.Id);
                                return true;
                            }
                        }
                    }
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
                            }
                            RecordRareControl(true, "[REGOLARE] : " + wallitem.Id);
                            return true;
                        }
                    }
                }
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


        private void ResetRareCheckScanner()
        {
            IrregularWallFurni.Clear();
            IrregularFloorFurni.Clear();
            RegularWallFurni.Clear();
            RegularFloorFurni.Clear();
            WriteToLabel(RegularFurnisCountLbl, "Tot Regular Furnis : 0");
            WriteToLabel(IrregularFurnisCountLbl, "Tot Irregular Furnis : 0");
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


        private void RemoveWallItemBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            RemoveWallItem(FurnitureIdText);
        }

        private void RemoveFloorItemBtn_Click(object sender, EventArgs e)
        {
            if (FurnitureId == 0) return;
            RemoveFloorItem(FurnitureIdText);
        }

        private void RoomPickupItem(DataInterceptedEventArgs obj)
        {
        }

        private string GetHost(string host)
        {
            if (host == "217.182.58.18")
            {
                return "bobbaitalia.it";
            }
            else
            {
                return host;
            }
        }




        private void RecordPlacedRare(int rareid)
        {
            try
            {
                string Filepath = "../PlacedRares/" + GetHost(Connection.Host) + "_rari" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
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

                string Filepath = "../RareControls/" + GetHost(Connection.Host) + raretype + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
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


        private async void RemoveWallItem(string furnitureId)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToClientAsync(In.RemoveWallItem, furnitureId, 0);
            }
        }

        private async void RemoveFloorItem(string furnitureId)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToClientAsync(In.RemoveFloorItem, furnitureId, false, 0, 0);
            }
        }

        private void RadioButtonCheck(RadioButton button, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Checked = value;
            });
        }



        private void RestoreFurnisBtn_Click(object sender, EventArgs e)
        {
            if (FurniDataStored != null)
            {
                if (Connection.Remote.IsConnected)
                {
                    Connection.SendToClientAsync(FurniDataStored);
                }
            }
            else
            {
                Speak("Stored Furnidata is empty! Try refreshing the room!");
            }
        }

        private async void Speak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(150);
                await Connection.SendToClientAsync(In.RoomUserTalk, 0, text, 0, 1, 0, -1);
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






        public async void TeleportfurniToCoord(int X, int Y)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, X, Y, FloorFurniRotation);
            }
        }


        private async void WalkFurniToCoordX(int X)
        {
            if (ConvertWalkinFurniMovement)
            {
                while (FloorFurniX != X)
                {
                    if (FloorFurniX < X)
                    {
                        FloorFurniX++;
                        await Task.Delay(FurniWalkingSpeed);
                        SendWalkingFurniPacket(FloorFurniX, FloorFurniY);
                    }
                    if (FloorFurniX > X)
                    {
                        FloorFurniX--;
                        await Task.Delay(FurniWalkingSpeed);
                        SendWalkingFurniPacket(FloorFurniX, FloorFurniY);

                    }
                }
            }
            else
            {
                return;
            }
        }

        private async void WalkFurniToCoordY(int Y)
        {
            if (ConvertWalkinFurniMovement)
            {
                while (FloorFurniY != Y)
                {
                    if (FloorFurniY < Y)
                    {
                        FloorFurniY++;
                        await Task.Delay(FurniWalkingSpeed);
                        SendWalkingFurniPacket(FloorFurniX, FloorFurniY);

                    }
                    if (FloorFurniY > Y)
                    {
                        FloorFurniY--;
                        await Task.Delay(FurniWalkingSpeed);
                        SendWalkingFurniPacket(FloorFurniX, FloorFurniY);
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void SendWalkingFurniPacket(int X, int Y)
        {
            if (ConvertWalkinFurniMovement)
            {
                if (Connection.Remote.IsConnected)
                {
                    Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, X, Y, FloorFurniRotation);
                }
            }
        }
        private void FloorFurniXNbx_ValueChanged(object sender, EventArgs e)
        {
            if (ConvertWalkinFurniMovement)
            {
                Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
            }
        }

        private void FloorFurniYNbx_ValueChanged(object sender, EventArgs e)
        {
            if (ConvertWalkinFurniMovement)
            {
                Connection.SendToServerAsync(Out.RotateMoveItem, FloorFurniID, FloorFurniX, FloorFurniY, FloorFurniRotation);
            }
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {

        }

        public void InFloorItemUpdate(DataInterceptedEventArgs e)
        {
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {

        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {

        }

        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
        {
            RoomFloorFurni.Clear();
            RoomWallFurni.Clear();
            IrregularWallFurni.Clear();
            IrregularFloorFurni.Clear();
            RegularWallFurni.Clear();
            RegularFloorFurni.Clear();
            RemovedWallFurnis.Clear();
            RemovedFloorFurnis.Clear();
            FurniDataStored = null;
            ResetRoomScannerLabels();
            ResetRareCheckScanner();
        }

        public void OnLatencyTest(DataInterceptedEventArgs e)
        {

        }

        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {
        }

        public void OnUsername(DataInterceptedEventArgs e)
        {

        }

        public void InRoomData(DataInterceptedEventArgs e)
        {

        }

        public void InItemExtraData(DataInterceptedEventArgs e)
        {
        }
        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
            int coordX = e.Packet.ReadInteger();
            int coordY = e.Packet.ReadInteger();

            if (ConvertWalkinFurniMovement)
            {
                if (isTeleportFurni)
                {
                    TeleportfurniToCoord(coordX, coordY);
                    e.IsBlocked = true;
                }
                else if (IsWalkingFurni)
                {

                    WalkFurniToCoord(coordX, coordY);
                    e.IsBlocked = true;
                }
            }
        }

        public static List<HWallItem> BobbaParser(HMessage packet)
        {
            int ownersCount = packet.ReadInteger();
            for (int i = 0; i < ownersCount; i++)
            {
                packet.ReadInteger();
                packet.ReadString();
            }

            var wallItems = new HWallItem[packet.ReadInteger()];
            for (int i = 0; i < wallItems.Length; i++)
            {
                wallItems[i] = new HWallItem(packet);
            }
            return wallItems.ToList();
        }


        private async void WalkFurniToCoord(int X, int Y)
        {
            WalkFurniToCoordX(X);
            await Task.Delay(10);
            WalkFurniToCoordY(Y);
            await Task.Delay(10);
        }

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
        }

        public void InUserEnterRoom(DataInterceptedEventArgs e)
        {
        }

        public void InUserProfile(DataInterceptedEventArgs e)
        {
        }

        public void OnRoomUserTalk(DataInterceptedEventArgs e)
        {

        }

        public void OnRoomUserShout(DataInterceptedEventArgs e)
        {

        }

        public void OnRoomUserWhisper(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserTalk(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserShout(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserWhisper(DataInterceptedEventArgs e)
        {

        }

        public void OnRoomUserStartTyping(DataInterceptedEventArgs e)
        {
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
                WriteToButton(FileCheckBtn, "Rare Check : ON");
                FurniIDToCheckMode = true;
                Speak("Rotate Furni / Rare To check if is a irregular or not!", 30);
            }
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
            CheckForRares(ControlledFloorFurni, false);
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

        private void AnalyzeCurrentFurnis()
        {

            if (FilePathList != null)
            {
                if (RoomWallFurni != null && RoomWallFurni.Count != 0)
                {
                    foreach (HWallItem wallfurni in RoomWallFurni)
                    {
                        CheckForRares(wallfurni, true);
                    }
                }
                if (RoomFloorFurni != null && RoomFloorFurni.Count != 0)
                {
                    foreach (HFloorItem flooritem in RoomFloorFurni)
                    {
                        CheckForRares(flooritem, true);
                    }
                }
                if (RoomWallFurni != null)
                {
                    Speak("Found Tot Wall Furni : " + SyncWallFurniCount(), 34);
                }
                if (RoomFloorFurni != null)
                {
                    Speak("Found Tot Floor Furni : " + SyncFloorFurniCount(), 34);
                }
                int regolar1 = SyncRegularFloorFurniCount();
                int regolar2 = SyncRegularWallFurniCount();
                int totalreg = regolar1 + regolar2;

                int irr1 = SyncIrregolarFloorFurniCount();
                int irr2 = SyncIrregolarWallFurniCount();
                int totirr = irr1 + irr2;


                Speak("Regolari : " + totalreg + ".", 34);
                Speak("Irregolari : " + totirr + ".", 34);
                IsRoomScannerActivated = false;
            }
        }
    

        

        private void StartExcelConverter()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                FixExcel(ExcelFilePath, false, false);
            }).Start();
        }



        private void StartRoomAnalyze()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                ResetRareCheckScanner();
                AnalyzeCurrentFurnis();
            }).Start();
        }



        private void AnalyzeRooMFurnisBtn_Click(object sender, EventArgs e)
        {
            if (FilePathList != null && FilePathList.Count != 0)
            {
                if (RoomFloorFurni.Count != 0 || RoomWallFurni.Count != 0 || RoomWallFurni.Count != 0 && RoomFloorFurni.Count != 0)
                {
                    if (!IsRoomScannerActivated)
                    {
                        Speak("Scanning room, please wait!", 30);
                        StartRoomAnalyze();
                        IsRoomScannerActivated = true;
                    }
                    else
                    {
                        Speak("Wait, im still scanning the room!", 30);
                    }
                }
                else
                {
                    Speak("Im unable to scan this room because there's no Wall/Floor Furni, can you try re-entering the room?! ", 30);
                }
            }
            else
            {
                Speak("Please select some files to check!", 30);

            }
        }

        private void PickRegisteredFurnisBtn_Click(object sender, EventArgs e)
        {
            REM_REG_WALL_FURNI = false;
            REM_REG_FLOOR_FURNI = false;
            RemoveRegolarFurni();
        }

        private void PickUnregisteredFurniBtn_Click(object sender, EventArgs e)
        {
            REM_IRR_WALL_FURNI = false;
            REM_IRR_FLOOR_FURNI = false;

            RemoveIrregolarFurni();
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
                        if (RegularFloorFurni.Count() == 0)
                        {
                            REM_REG_FLOOR_FURNI = true;
                        }
                        if (RegularFloorFurni != null && RegularFloorFurni.Count() != 0 && !REM_REG_FLOOR_FURNI)
                        {
                            foreach (HFloorItem floorfurni in RegularFloorFurni)
                            {
                                Task.Delay(250);
                                Connection.SendToServerAsync(Out.RoomPickupItem, 2, floorfurni.Id);
                                if (RegularFloorFurni.Contains(floorfurni))
                                {
                                    RegularFloorFurni.Remove(floorfurni);
                                    RemovedFloorFurnis.Add(floorfurni.Id);
                                    UpdateRegularFurniLabel();
                                }
                            }
                        }
                        if (RegularWallFurni.Count() == 0)
                        {
                            REM_REG_WALL_FURNI = true;

                        }
                        if (RegularWallFurni != null && RegularWallFurni.Count() != 0 && !REM_REG_WALL_FURNI)
                        {
                            foreach (HWallItem wallitem in RegularWallFurni)
                            {
                                Task.Delay(250);
                                Connection.SendToServerAsync(Out.RoomPickupItem, 2, wallitem.Id);
                                if (RegularWallFurni.Contains(wallitem))
                                {
                                    RegularWallFurni.Remove(wallitem);
                                    RemovedWallFurnis.Add(wallitem.Id);
                                    UpdateRegularFurniLabel();
                                }
                            }
                        }
                    }
                    catch (Exception)
                    { }
                } while (!REM_REG_FLOOR_FURNI && !REM_REG_WALL_FURNI);
            }).Start();
        }




        private void RemoveIrregolarFurni()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (IrregularWallFurni.Count() == 0)
                        {
                            REM_IRR_FLOOR_FURNI = true;
                        }
                        if (IrregularFloorFurni != null && IrregularFloorFurni.Count() != 0 && !REM_IRR_FLOOR_FURNI)
                        {
                            foreach (HFloorItem floorfurni in IrregularFloorFurni)
                            {
                                Task.Delay(250);
                                Connection.SendToServerAsync(Out.RoomPickupItem, 2, floorfurni.Id);
                                if (IrregularFloorFurni.Contains(floorfurni))
                                {
                                    IrregularFloorFurni.Remove(floorfurni);
                                    RemovedFloorFurnis.Add(floorfurni.Id);
                                    UpdateIrregolarFurniLabel();
                                }
                            }
                        }
                        if (IrregularWallFurni.Count() == 0)
                        {
                            REM_IRR_WALL_FURNI = true;
                        }
                        if (IrregularWallFurni != null && IrregularWallFurni.Count() != 0 && !REM_IRR_WALL_FURNI)
                        {
                            foreach (HWallItem wallitem in IrregularWallFurni)
                            {
                                Task.Delay(250);
                                Connection.SendToServerAsync(Out.RoomPickupItem, 2, wallitem.Id);
                                if (IrregularWallFurni.Contains(wallitem))
                                {
                                    IrregularWallFurni.Remove(wallitem);
                                    RemovedWallFurnis.Add(wallitem.Id);
                                    UpdateIrregolarFurniLabel();
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                } while (!REM_IRR_FLOOR_FURNI && !REM_IRR_WALL_FURNI);
            }).Start();
        }



        public void OnRoomPickupItem(DataInterceptedEventArgs e)
        {
        }

        public void OnRotateMoveItem(DataInterceptedEventArgs e)
        {
            int FurniID = e.Packet.ReadInteger();
            if (FurniIDToCheckMode)
            {
                ControlledFloorFurni = FurniID;
                Speak("Checking ID : " + FurniID, 30);
                CheckForRares(ControlledFloorFurni, false);
                e.IsBlocked = true;
            }
        }

        public void OnMoveWallItem(DataInterceptedEventArgs e)
        {
            int WallFurni = e.Packet.ReadInteger();
            if (FurniIDToCheckMode)
            {
                ControlledFloorFurni = WallFurni;
                Speak("Checking ID : " + WallFurni, 30);
                CheckForRares(ControlledFloorFurni, false);
                e.IsBlocked = true;
            }
        }

        public void InRoomFloorItems(DataInterceptedEventArgs e)
        {
            RoomFloorFurni = HFloorItem.Parse(e.Packet).ToList(); //All Floor Objects
            UpdateFloorFurnisLabel();
            e.Continue();
        }

        public void InRoomWallItems(DataInterceptedEventArgs e)
        {
            RoomWallFurni = BobbaParser(e.Packet);
            UpdateWallFurnisLabel();
            e.Continue();
        }

        public void InAddFloorItem(DataInterceptedEventArgs e)
        {
            try
            {
                var NewFloorFurnis = new HFloorItem(e.Packet);
                if (RemovedFloorFurnis.Contains(NewFloorFurnis.Id))
                {
                    RemovedFloorFurnis.Remove(NewFloorFurnis.Id);
                }
                if (!RoomFloorFurni.Contains(NewFloorFurnis))
                {
                    RoomFloorFurni.Add(NewFloorFurnis);
                }
                UpdateRemovedFloorFurniLbl();
                UpdateFloorFurnisLabel();
            }
            catch (Exception) { }
        }

        public void InAddWallItem(DataInterceptedEventArgs e)
        {
            try
            {
                var NewPlacedWallFurni = new HWallItem(e.Packet);

                if (RemovedWallFurnis.Contains(NewPlacedWallFurni.Id))
                {
                    RemovedWallFurnis.Remove(NewPlacedWallFurni.Id);
                }
                if (!RoomWallFurni.Contains(NewPlacedWallFurni))
                {
                    RoomWallFurni.Add(NewPlacedWallFurni);
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


        public void InRemoveWallItem(DataInterceptedEventArgs e)
        {
            if (int.TryParse(e.Packet.ReadString(), out int furni))
            {
                var foundfurni = RoomWallFurni.Find(f => f.Id == furni);
                if (foundfurni != null)
                {
                    if (RoomWallFurni.Contains(foundfurni))
                    {
                        RoomWallFurni.Remove(foundfurni);
                    }
                    if (!RemovedWallFurnis.Contains(foundfurni.Id))
                    {
                        RemovedWallFurnis.Add(foundfurni.Id);
                    }
                }
                UpdateRemovedWallFurniLbl();
            }
        }

        public void InRemoveFloorItem(DataInterceptedEventArgs e)
        {
            if (int.TryParse(e.Packet.ReadString(), out int furni))
            {
                var foundfurni = RoomFloorFurni.Find(f => f.Id == furni);
                if (RoomFloorFurni.Contains(foundfurni))
                {
                    RoomFloorFurni.Remove(foundfurni);
                }
                if (!RemovedFloorFurnis.Contains(foundfurni.Id))
                {
                    RemovedFloorFurnis.Add(foundfurni.Id);
                }
                UpdateRemovedFloorFurniLbl();
                UpdateFloorFurnisLabel();
            }
        }


        private void RemoveFloorFurni(HFloorItem furni)
        {
            try
            {

                if (RoomFloorFurni.Contains(furni))
                {
                    RoomFloorFurni.Remove(furni);
                }
                if (IrregularFloorFurni.Contains(furni))
                {
                    IrregularFloorFurni.Remove(furni);
                }
                if (RegularFloorFurni.Contains(furni))
                {
                    RegularFloorFurni.Remove(furni);
                }
                if (!RemovedFloorFurnis.Contains(furni.Id))
                {
                    RemovedFloorFurnis.Add(furni.Id);
                }
                UpdateRemovedFloorFurniLbl();
                UpdateFloorFurnisLabel();
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
    }
}