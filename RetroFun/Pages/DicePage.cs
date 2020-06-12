using RetroFun.Subscribers;
using Sulakore.Communication;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class DicePage:  ObservablePage
    {

        private bool _IsRegistrationMode;

        public bool IsRegistrationMode
        {
            get => _IsRegistrationMode;
            set
            {
                _IsRegistrationMode = value;
                RaiseOnPropertyChanged();
            }
        }




        private int _DiceTotResult;

        public int DiceTotResult
        {
            get => _DiceTotResult;
            set
            {
                _DiceTotResult = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _DiceResult1;

        public int DiceResult1
        {
            get => _DiceResult1;
            set
            {
                _DiceResult1 = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _DiceResult2;

        public int DiceResult2
        {
            get => _DiceResult2;
            set
            {
                _DiceResult2 = value;
                RaiseOnPropertyChanged();
            }
        }
        private int _DiceResult3;

        public int DiceResult3
        {
            get => _DiceResult3;
            set
            {
                _DiceResult3 = value;
                RaiseOnPropertyChanged();
            }
        }
        private int _DiceResult4;

        public int DiceResult4
        {
            get => _DiceResult4;
            set
            {
                _DiceResult4 = value;
                RaiseOnPropertyChanged();
            }
        }
        private int _DiceResult5;

        public int DiceResult5
        {
            get => _DiceResult5;
            set
            {
                _DiceResult5 = value;
                RaiseOnPropertyChanged();
            }
        }
        private int _DiceResult6;

        public int DiceResult6
        {
            get => _DiceResult6;
            set
            {
                _DiceResult6 = value;
                RaiseOnPropertyChanged();
            }
        }

                private int _DiceID1;

        public int DiceID1
        {
            get => _DiceID1;
            set
            {
                _DiceID1 = value;
                RaiseOnPropertyChanged();
            }
        }
		
		        private int _DiceID2;

        public int DiceID2
        {
            get => _DiceID2;
            set
            {
                _DiceID2 = value;
                RaiseOnPropertyChanged();
            }
        }
		        private int _DiceID3;

        public int DiceID3
        {
            get => _DiceID3;
            set
            {
                _DiceID3 = value;
                RaiseOnPropertyChanged();
            }
        }
		        private int _DiceID4;

        public int DiceID4
        {
            get => _DiceID4;
            set
            {
                _DiceID4 = value;
                RaiseOnPropertyChanged();
            }
        }
		        private int _DiceID5;

        public int DiceID5
        {
            get => _DiceID5;
            set
            {
                _DiceID5 = value;
                RaiseOnPropertyChanged();
            }
        }
		        private int _DiceID6;

        public int DiceID6
        {
            get => _DiceID6;
            set
            {
                _DiceID6 = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _DiceSelected1;
        public bool DiceSelected1
        {
            get => _DiceSelected1;
            set
            {
                _DiceSelected1 = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _DiceSelected2;

        public bool DiceSelected2
        {
            get => _DiceSelected2;
            set
            {
                _DiceSelected2 = value;
                RaiseOnPropertyChanged();
            }
        }
        private bool _DiceSelected3;

        public bool DiceSelected3
        {
            get => _DiceSelected3;
            set
            {
                _DiceSelected3 = value;
                RaiseOnPropertyChanged();
            }
        }
        private bool _DiceSelected4;

        public bool DiceSelected4
        {
            get => _DiceSelected4;
            set
            {
                _DiceSelected4 = value;
                RaiseOnPropertyChanged();
            }
        }
        private bool _DiceSelected5;

        public bool DiceSelected5
        {
            get => _DiceSelected5;
            set
            {
                _DiceSelected5 = value;
                RaiseOnPropertyChanged();
            }
        }
        private bool _DiceSelected6;

        public bool DiceSelected6
        {
            get => _DiceSelected6;
            set
            {
                _DiceSelected6 = value;
                RaiseOnPropertyChanged();
            }
        }

        public DicePage()
        {
            InitializeComponent();
            Bind(DiceRegisterModeCheck, "Checked", nameof(IsRegistrationMode));


            Bind(DiceID1Nbx, "Value", nameof(DiceID1));
            Bind(DiceID2Nbx, "Value", nameof(DiceID2));
            Bind(DiceID3Nbx, "Value", nameof(DiceID3));
            Bind(DiceID4Nbx, "Value", nameof(DiceID4));
            Bind(DiceID5Nbx, "Value", nameof(DiceID5));
            Bind(DiceID6Nbx, "Value", nameof(DiceID6));

            Bind(Dice1ResultNbx, "Value", nameof(DiceResult1));
            Bind(Dice2ResultNbx, "Value", nameof(DiceResult2));
            Bind(Dice3ResultNbx, "Value", nameof(DiceResult3));
            Bind(Dice4ResultNbx, "Value", nameof(DiceResult4));
            Bind(Dice5ResultNbx, "Value", nameof(DiceResult5));
            Bind(Dice6ResultNbx, "Value", nameof(DiceResult6));

            Bind(DiceSelect1Chbx, "Checked", nameof(DiceSelected1));
            Bind(DiceSelect2Chbx, "Checked", nameof(DiceSelected2));
            Bind(DiceSelect3Chbx, "Checked", nameof(DiceSelected3));
            Bind(DiceSelect4Chbx, "Checked", nameof(DiceSelected4));
            Bind(DiceSelect5Chbx, "Checked", nameof(DiceSelected5));
            Bind(DiceSelect6Chbx, "Checked", nameof(DiceSelected6));

            Bind(TotalDiceResultNbx, "Value", nameof(DiceTotResult));


        }

        public override void Out_TriggerDice(DataInterceptedEventArgs e)
        {
            if (_IsRegistrationMode)
            {
                RegisterDice(e.Packet.ReadInteger());
                e.IsBlocked = true;
            }
        }
        public override void Out_CloseDice(DataInterceptedEventArgs e)
        {
            if (_IsRegistrationMode)
            {
                RegisterDice(e.Packet.ReadInteger());
                e.IsBlocked = true;
            }
        }

        private void DiceRegisterMode_CheckedChanged(object sender, EventArgs e)
        {
            if (DiceRegisterModeCheck.Checked)
            {
                DiceRegistered1 = false;
                DiceRegistered2 = false;
                DiceRegistered3 = false;
                DiceRegistered4 = false;
                DiceRegistered5 = false;
                DiceRegistered6 = false;
                RegistrationCompleted = false;
                RegisterDiceSpeak("Registration has been activated.");
                RegisterDiceAsk(1);
            }
            else
            {
                if (!RegistrationCompleted)
                {
                    RegisterDiceSpeak("Registration completed.");
                }
            }
        }

        public void RegisterDice(int NewDice)
        {

            if (!DiceRegistered1)
            {
                DiceRegistered1 = true;
                DiceID1 = NewDice;
                RegisterDiceAsk(2);
                return;
            }
            if (!DiceRegistered2)
            {
                DiceRegistered2 = true;
                DiceID2 = NewDice;
                RegisterDiceAsk(3);
                return;
            }
            if (!DiceRegistered3)
            {
                DiceRegistered3 = true;
                DiceID3 = NewDice;
                RegisterDiceAsk(4);
                return;
            }
            if (!DiceRegistered4)
            {
                DiceRegistered4 = true;
                DiceID4 = NewDice;
                RegisterDiceAsk(5);
                return;
            }
            if (!DiceRegistered5)
            {
                DiceRegistered5 = true;
                DiceID5 = NewDice;
                RegisterDiceAsk(6);
                return;
            }
            if (!DiceRegistered6)
            {
                DiceRegistered6 = true;
                DiceID6 = NewDice;
                RegistrationCompleted = true;
                if (RegistrationCompleted)
                {
                    RegisterDiceSpeak("Registration completed.");
                }
                CheckBoxToggler(DiceRegisterModeCheck, false);
                return;
            }
        }

        private void RollCheckedDices_Click(object sender, EventArgs e)
        {
            if (DiceSelected1)
            {

                    RollDice(DiceID1);
                
            }
            if (DiceSelected2)
            {

                    RollDice(DiceID2);
                
            }
            if (DiceSelected3)
            {

                    RollDice(DiceID3);

            }
            if (DiceSelected4)
            {

                    RollDice(DiceID4);
            }
            if (DiceSelected5)
            {
                    RollDice(DiceID5);
                
            }
            if (DiceSelected6)
            {

                    RollDice(DiceID6);
            }
        }

        private void CloseCheckedDices_Click(object sender, EventArgs e)
        {
            if (DiceSelected1)
            {
                CloseDice(DiceID1);
            }
            if (DiceSelected2)
            {
                CloseDice(DiceID2);
            }
            if (DiceSelected3)
            {
                CloseDice(DiceID3);
            }
            if (DiceSelected4)
            {
                CloseDice(DiceID4);
            }
            if (DiceSelected5)
            {
                CloseDice(DiceID5);
            }
            if (DiceSelected6)
            {
                CloseDice(DiceID6);
            }
        }

        private void ThrowDice1Btn_Click(object sender, EventArgs e)
        {
            RollDice(DiceID1);

        }

        private void ThrowDice2Btn_Click(object sender, EventArgs e)
        {
            RollDice(DiceID2);

        }

        private void ThrowDice3Btn_Click(object sender, EventArgs e)
        {
            RollDice(DiceID3);

        }

        private void ThrowDice4Btn_Click(object sender, EventArgs e)
        {
            RollDice(DiceID4);

        }

        private void ThrowDice5Btn_Click(object sender, EventArgs e)
        {
            RollDice(DiceID5);

        }

        private void ThrowDice6Btn_Click(object sender, EventArgs e)
        {
            RollDice(DiceID6);
        }

        private void CloseDice1Btn_Click(object sender, EventArgs e)
        {
            CloseDice(DiceID1);

        }

        private void CloseDice2Btn_Click(object sender, EventArgs e)
        {
            CloseDice(DiceID2);

        }

        private void CloseDice3Btn_Click(object sender, EventArgs e)
        {
            CloseDice(DiceID3);

        }

        private void CloseDice4Btn_Click(object sender, EventArgs e)
        {
            CloseDice(DiceID4);

        }

        private void CloseDice5Btn_Click(object sender, EventArgs e)
        {
            CloseDice(DiceID5);

        }

        private void CloseDice6Btn_Click(object sender, EventArgs e)
        {
            CloseDice(DiceID6);

        }

        private void UnSelectAllButton_Click(object sender, EventArgs e)
        {
            CheckStatus(false);
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            CheckStatus(true);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DiceID1 = 0;
            DiceID2 = 0;
            DiceID3 = 0;
            DiceID4 = 0;
            DiceID5 = 0;
            DiceID6 = 0;

            DiceResult1 = 0;
            DiceResult2 = 0;
            DiceResult3 = 0;
            DiceResult4 = 0;
            DiceResult5 = 0;
            DiceResult6 = 0;

            CheckStatus(false);
        }

        public void CheckStatus(bool status)
        {
            CheckBoxToggler(DiceSelect1Chbx, status);
            CheckBoxToggler(DiceSelect2Chbx, status);
            CheckBoxToggler(DiceSelect3Chbx, status);
            CheckBoxToggler(DiceSelect4Chbx, status);
            CheckBoxToggler(DiceSelect5Chbx, status);
            CheckBoxToggler(DiceSelect6Chbx, status);
        }

        private void RollDice(int DiceID)
        {
                _ = SendToServer(Out.TriggerDice, DiceID);
        }

        private void CloseDice(int DiceID)
        {
                _ = SendToServer(Out.CloseDice, DiceID);
        }

        private void RegisterDiceAsk(int DiceNumber)
        {
                _ = SendToClient(In.RoomUserWhisper, 0, "[Registration Dice]: Please Select the dice nr " + DiceNumber.ToString() + ".", 0, 34, 0, -1);
        }

        private void RegisterDiceSpeak(string text)
        {
                _ = SendToClient(In.RoomUserWhisper, 0, "[Registration Dice]: " + text, 0, 34, 0, -1);
        }

        private void CheckBoxToggler(CheckBox box, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                box.Checked = value;
            });
        }


        public override void In_ItemExtraData(DataInterceptedEventArgs e)
        {
            try
            {
                int id = int.Parse(e.Packet.ReadString());
                e.Packet.ReadInteger();
                string data = e.Packet.ReadString();
                e.Packet.Position = 0;
                e.Continue();

                if (!int.TryParse(data, out int diceState) || diceState == -1) return;

                if (id == DiceID1)
                {
                    DiceResult1 = diceState;
                    CalculateResults();

                }

                if (id == DiceID2)
                {
                    DiceResult2 = diceState;
                    CalculateResults();

                }

                if (id == DiceID3)
                {
                    DiceResult3 = diceState;
                    CalculateResults();

                }

                if (id == DiceID4)
                {
                    DiceResult4 = diceState;
                    CalculateResults();

                }

                if (id == DiceID5)
                {
                    DiceResult5 = diceState;
                    CalculateResults();

                }

                if (id == DiceID6)
                {
                    DiceResult6 = diceState;
                    CalculateResults();
                }
            }
            catch (Exception exc)
            {

            }
        }


        


        private void CalculateResults()
        {
            DiceTotResult = 0;
            DiceTotResult = DiceResult1 + DiceResult2 + DiceResult3 + DiceResult4 + DiceResult5 + DiceResult6;
        }

        private bool DiceRegistered1;
        private bool DiceRegistered2;
        private bool DiceRegistered3;
        private bool DiceRegistered4;
        private bool DiceRegistered5;
        private bool DiceRegistered6;
        private bool RegistrationCompleted;
        private bool StartDiceRoll;
        private bool StartDiceCloseRoll;

        private void RollPokerDices()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {

                    if (StartDiceRoll)
                    {
                        if (DiceSelected1)
                        {
                            Thread.Sleep(550);
                            RollDice(DiceID1);
                        }
                        if (DiceSelected2)
                        {
                            Thread.Sleep(550);
                            RollDice(DiceID2);
                        }
                        if (DiceSelected3)
                        {
                            Thread.Sleep(550);
                            RollDice(DiceID3);

                        }
                        if (DiceSelected4)
                        {
                            Thread.Sleep(550);
                            RollDice(DiceID4);
                        }
                        if (DiceSelected5)
                        {
                            Thread.Sleep(550);
                            RollDice(DiceID5);
                        }

                        if (DiceSelected6)
                        {
                            Thread.Sleep(550);
                            RollDice(DiceID6);
                        }
                        StartDiceRoll = false;
                    }

                } while (StartDiceRoll);
            }).Start();
        }

        private void ClosePokerDice()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {

                    if (StartDiceCloseRoll)
                    {
                        if (DiceSelected1)
                        {
                            Thread.Sleep(550);
                            CloseDice(DiceID1);
                        }
                        if (DiceSelected2)
                        {
                            Thread.Sleep(550);
                            CloseDice(DiceID2);
                        }
                        if (DiceSelected3)
                        {
                            Thread.Sleep(550);
                            CloseDice(DiceID3);

                        }
                        if (DiceSelected4)
                        {
                            Thread.Sleep(550);
                            CloseDice(DiceID4);
                        }
                        if (DiceSelected5)
                        {
                            Thread.Sleep(550);
                            CloseDice(DiceID5);
                        }

                        if (DiceSelected6)
                        {
                            Thread.Sleep(550);
                            CloseDice(DiceID6);
                        }
                        StartDiceCloseRoll = false;
                    }

                } while (StartDiceCloseRoll);
            }).Start();
        }

        private void RollDicePkrBtn_Click(object sender, EventArgs e)
        {
            StartDiceRoll = true;
            RollPokerDices();

        }

        private void CloseDicePkrBtn_Click(object sender, EventArgs e)
        {
            StartDiceCloseRoll = true;
            ClosePokerDice();
        }


        public override void In_FloorItemUpdate(DataInterceptedEventArgs e)
        {
            try
            {
                int id = e.Packet.ReadInteger();

                e.Packet.ReadInteger();
                e.Packet.ReadInteger();
                e.Packet.ReadInteger();
                e.Packet.ReadInteger();
                e.Packet.ReadString();
                e.Packet.ReadString();
                e.Packet.ReadInteger();
                e.Packet.ReadInteger();

                string data = e.Packet.ReadString();

                e.Continue();

                if (!int.TryParse(data, out int diceState) || diceState == -1) return;

                if (id == DiceID1)
                {
                    DiceResult1 = diceState;
                    CalculateResults();

                }

                if (id == DiceID2)
                {
                    DiceResult2 = diceState;
                    CalculateResults();

                }

                if (id == DiceID3)
                {
                    DiceResult3 = diceState;
                    CalculateResults();

                }

                if (id == DiceID4)
                {
                    DiceResult4 = diceState;
                    CalculateResults();

                }

                if (id == DiceID5)
                {
                    DiceResult5 = diceState;
                    CalculateResults();

                }

                if (id == DiceID6)
                {
                    DiceResult6 = diceState;
                    CalculateResults();
                }
            }
            catch(Exception exc)
            {

            }

        }
    }

}