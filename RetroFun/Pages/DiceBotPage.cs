using RetroFun.Controls;
using RetroFun.Converter;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class DiceBotPage : ObservablePage, ISubscriber
    {
        public bool ShouldRollFirst => DiceSelected1 && DiceHostResult != DiceResult1;
        public bool ShouldRollSecond => DiceSelected2 && DiceHostResult != DiceResult2;
        public bool ShouldRollThird => DiceSelected3 && DiceHostResult != DiceResult3;

        public bool ShouldRollFourth => DiceSelected3 && DiceHostResult != DiceResult4;

        public bool ShouldRollFifth => DiceSelected3 && DiceHostResult != DiceResult5;

        public bool ShouldRollSixth => DiceSelected3 && DiceHostResult != DiceResult6;


        public bool ShouldRollTargetFirst => DiceSelected1 && DiceSelectedResult1 != DiceResult1;
        public bool ShouldRollTargetSecond => DiceSelected2 && DiceSelectedResult2 != DiceResult2;
        public bool ShouldRollTargetThird => DiceSelected3 && DiceSelectedResult3 != DiceResult3;

        public bool ShouldRollTargetFourth => DiceSelected3 && DiceSelectedResult4 != DiceResult4;

        public bool ShouldRollTargetFifth => DiceSelected3 && DiceSelectedResult5 != DiceResult5;

        public bool ShouldRollTargetSixth => DiceSelected3 && DiceSelectedResult6 != DiceResult6;




        private int _currentDiceTargetIndex = -1;

        private int _diceOneId, _diceTwoId, _diceThreeId, _diceFourID, _diceFifthID, _diceSixthID, _diceHostId;

        private bool isTargetMode = true;
        private bool isManualMode;

        private bool ShouldShoutPhrase;

        private bool shouldKillBot = true;

        private bool isGlobalTargetOn;
        #region Dice Results



        private string _ShoutPhrase;
        public string ShoutPhrase
        {
            get => _ShoutPhrase;
            set
            {
                _ShoutPhrase = value;
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


        private int _DiceSelectedResult1;

        public int DiceSelectedResult1
        {
            get => _DiceSelectedResult1;
            set
            {
                _DiceSelectedResult1 = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _DiceSelectedResult2;

        public int DiceSelectedResult2
        {
            get => _DiceSelectedResult2;
            set
            {
                _DiceSelectedResult2 = value;
                RaiseOnPropertyChanged();
            }
        }
        private int _DiceSelectedResult3;

        public int DiceSelectedResult3
        {
            get => _DiceSelectedResult3;
            set
            {
                _DiceSelectedResult3 = value;
                RaiseOnPropertyChanged();
            }
        }
        private int _DiceSelectedResult4;

        public int DiceSelectedResult4
        {
            get => _DiceSelectedResult4;
            set
            {
                _DiceSelectedResult4 = value;
                RaiseOnPropertyChanged();
            }
        }
        private int _DiceSelectedResult5;

        public int DiceSelectedResult5
        {
            get => _DiceSelectedResult5;
            set
            {
                _DiceSelectedResult5 = value;
                RaiseOnPropertyChanged();
            }
        }
        private int _DiceSelectedResult6;

        public int DiceSelectedResult6
        {
            get => _DiceSelectedResult6;
            set
            {
                _DiceSelectedResult6 = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _hostDiceResult;

        public int DiceHostResult
        {
            get => _hostDiceResult;
            set
            {
                _hostDiceResult = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _GlobalSelectResult;

        public int GlobalSelectResult
        {
            get => _GlobalSelectResult;
            set
            {
                _GlobalSelectResult = value;
                RaiseOnPropertyChanged();
            }
        }

        #endregion Dice Results

        private bool _ISHoloDiceCheat;

        public bool IsBotActive
        {
            get => _ISHoloDiceCheat;
            set
            {
                _ISHoloDiceCheat = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool IsReceiving => true;

        private List<SKoreButton> _registrationButtons;

        public DiceBotPage()
        {
            InitializeComponent();

            _registrationButtons = new List<SKoreButton> {
                RegisterFirstBtn, RegisterSecondBtn, RegisterThirdBtn,RegisterFourthBtn, RegisterFifthBtn, RegisterSixthBtn, RegisterHostBtn
            };

            RegisterFirstBtn.Click += HandleRegisterClick;
            RegisterSecondBtn.Click += HandleRegisterClick;
            RegisterThirdBtn.Click += HandleRegisterClick;
            RegisterFourthBtn.Click += HandleRegisterClick;
            RegisterFifthBtn.Click += HandleRegisterClick;
            RegisterSixthBtn.Click += HandleRegisterClick;

            RegisterHostBtn.Click += HandleRegisterClick;

            Bind(DiceFirstResTB, "Value", nameof(DiceResult1));
            Bind(DiceSecondResTB, "Value", nameof(DiceResult2));
            Bind(DiceThirdResTB, "Value", nameof(DiceResult3));
            Bind(DiceFourthResTB, "Value", nameof(DiceResult4));
            Bind(DiceFifthResTB, "Value", nameof(DiceResult5));
            Bind(DiceSixthtResTB, "Value", nameof(DiceResult6));

            Bind(DiceHostResTB, "Value", nameof(DiceHostResult));

            Bind(DiceNumber1TargetNbx, "Value", nameof(DiceSelectedResult1));
            Bind(DiceNumber2TargetNbx, "Value", nameof(DiceSelectedResult2));
            Bind(DiceNumber3TargetNbx, "Value", nameof(DiceSelectedResult3));
            Bind(DiceNumber4TargetNbx, "Value", nameof(DiceSelectedResult4));
            Bind(DiceNumber5TargetNbx, "Value", nameof(DiceSelectedResult5));
            Bind(DiceNumber6TargetNbx, "Value", nameof(DiceSelectedResult6));

            Bind(GlobalTargetNbx, "Value", nameof(GlobalSelectResult));


            Bind(MatchFirstChk, "Checked", nameof(DiceSelected1));
            Bind(MatchSecondChk, "Checked", nameof(DiceSelected2));
            Bind(MatchThirdChk, "Checked", nameof(DiceSelected3));
            Bind(MatchFourthChbx, "Checked", nameof(DiceSelected4));
            Bind(MatchFifthChbx, "Checked", nameof(DiceSelected5));
            Bind(MatchSixthChbx, "Checked", nameof(DiceSelected6));

            Bind(holoDiceShoutPhraseTxb, "Text", nameof(ShoutPhrase));




            // TODO:  ARCTURUS SUPPORT LATER!
            //Triggers.InAttach(In.FloorItemUpdate, HandleDiceUpdate2);

        }

        private void HandleRegisterClick(object sender, EventArgs e)
        {
            var registrationButton = (SKoreButton)sender;
            _currentDiceTargetIndex = _registrationButtons.IndexOf(registrationButton);

            registrationButton.Text = "Waiting for dice..";
            _registrationButtons.ForEach(b => b.Enabled = false);
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {
            if (_currentDiceTargetIndex < 0) return;

            e.IsBlocked = true;
            int id = e.Packet.ReadInteger();

            switch (_currentDiceTargetIndex)
            {
                case 0: _diceOneId = id; break;
                case 1: _diceTwoId = id; break;
                case 2: _diceThreeId = id; break;
                case 3: _diceFourID = id; break;
                case 4: _diceFifthID = id; break;
                case 5: _diceSixthID = id; break;

                case 6: _diceHostId = id; break;
            }

            Invoke((MethodInvoker)delegate
            {
                _registrationButtons[_currentDiceTargetIndex].Text = id.ToString(); //fuk formatting
                _currentDiceTargetIndex = -1;
                _registrationButtons.ForEach(b => b.Enabled = true);
            });

            Broadcast("Dice registered!");
        }
        public void OnLatencyTest(DataInterceptedEventArgs e)
        {
        }
        public void OnUsername(DataInterceptedEventArgs e)
        {
        }

        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
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

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
        }
        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {
        }






        public void InItemExtraData(DataInterceptedEventArgs e)
        {
            int id = int.Parse(e.Packet.ReadString());
            e.Packet.ReadInteger();
            string data = e.Packet.ReadString();

            e.Continue();

            if (!int.TryParse(data, out int diceState) || diceState == -1) return;


            if (id == _diceHostId)
            {
                DiceHostResult = diceState;

                if (isTargetMode)
                {
                    if (IsBotActive)
                    {
                        if (diceState == 0)
                        {
                            CloseDice(_diceOneId);
                            CloseDice(_diceTwoId);
                            CloseDice(_diceThreeId);
                            CloseDice(_diceFourID);
                            CloseDice(_diceFifthID);
                            CloseDice(_diceSixthID);

                        }
                    }
                }


                if (IsBotActive)
                {
                    if (isManualMode)
                    {
                        if (DiceSelectedResult1 == 0)
                        {
                            CloseDice(_diceOneId);
                        }
                        if (DiceSelectedResult2 == 0)
                        {
                            CloseDice(_diceTwoId);
                        }
                        if (DiceSelectedResult3 == 0)
                        {
                            CloseDice(_diceThreeId);
                        }
                        if (DiceSelectedResult4 == 0)
                        {
                            CloseDice(_diceFourID);
                        }
                        if (DiceSelectedResult5 == 0)
                        {
                            CloseDice(_diceFifthID);
                        }
                        if (DiceSelectedResult6 == 0)
                        {
                            CloseDice(_diceSixthID);
                        }
                    }
                }
            }


            else if (id == _diceOneId) DiceResult1 = diceState;
            else if (id == _diceTwoId) DiceResult2 = diceState;
            else if (id == _diceThreeId) DiceResult3 = diceState;
            else if (id == _diceFourID) DiceResult4 = diceState;
            else if (id == _diceFifthID) DiceResult5 = diceState;
            else if (id == _diceSixthID) DiceResult6 = diceState;

            else return;

            if (diceState < 1) return;

            if (IsBotActive)
            {
                // FOLLOWS HOST DICE
                if (isTargetMode)
                {
                    if ((!ShouldRollFirst && !DiceSelected2 && !DiceSelected3 && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollFirst && !ShouldRollSecond && !DiceSelected3 && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollFirst && !ShouldRollSecond && !ShouldRollThird && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollFirst && !ShouldRollSecond && !ShouldRollThird && !ShouldRollFourth && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollFirst && !ShouldRollSecond && !ShouldRollThird && !ShouldRollFourth && !ShouldRollFifth && !DiceSelected6) ||
                        (!ShouldRollFirst && !ShouldRollSecond && !ShouldRollThird && !ShouldRollFourth && !ShouldRollFifth && !ShouldRollSixth))
                    {
                        //WON! Do the victory procedure here.

                        if (Connection.Remote.IsConnected)
                        {
                            if (ShouldShoutPhrase)
                            {
                                Connection.SendToServerAsync(Out.RoomUserShout, ShoutPhrase, 0);
                            }
                        }

                        // KILLS THE BOT TO AVOID CHEAT SUSPICIONS , JUST RESTART IT WITH THE BUTTON!

                        if (shouldKillBot)
                        {
                            IsBotActive = false;
                            WriteToButton(EnableBotBtn, "Bot : OFF");
                        }
                    }
                    else
                    {
                        if (ShouldRollFirst)
                            RollDice(_diceOneId);

                        if (ShouldRollSecond)
                            RollDice(_diceTwoId);

                        if (ShouldRollThird)
                            RollDice(_diceThreeId);

                        if (ShouldRollFourth)
                            RollDice(_diceFourID);

                        if (ShouldRollFifth)
                            RollDice(_diceFifthID);

                        if (ShouldRollSixth)
                            RollDice(_diceSixthID);
                    }
                }

                // FOLLOWS MANUAL CONTROLS
                if (isManualMode)
                {
                    if ((!ShouldRollTargetFirst && !DiceSelected2 && !DiceSelected3 && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollTargetFirst && !ShouldRollTargetSecond && !DiceSelected3 && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollTargetFirst && !ShouldRollTargetSecond && !ShouldRollTargetThird && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollTargetFirst && !ShouldRollTargetSecond && !ShouldRollTargetThird && !ShouldRollTargetFourth && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollTargetFirst && !ShouldRollTargetSecond && !ShouldRollTargetThird && !ShouldRollTargetFourth && !ShouldRollTargetFifth && !DiceSelected6) ||
                        (!ShouldRollTargetFirst && !ShouldRollTargetSecond && !ShouldRollTargetThird && !ShouldRollTargetFourth && !ShouldRollTargetFifth && !ShouldRollTargetSixth))
                    {
                        //WON! Do the victory procedure here.

                        if (Connection.Remote.IsConnected)
                        {
                            if (ShouldShoutPhrase)

                            {
                                Connection.SendToServerAsync(Out.RoomUserShout, ShoutPhrase, 0);
                            }
                        }

                        // KILLS THE BOT TO AVOID CHEAT SUSPICIONS , JUST RESTART IT WITH THE BUTTON!
                        if (shouldKillBot)
                        {
                            IsBotActive = false;
                            WriteToButton(EnableBotBtn, "Bot : OFF");
                        }
                    }
                    else
                    {
                        if (ShouldRollTargetFirst)
                            RollDice(_diceOneId);

                        if (ShouldRollTargetSecond)
                            RollDice(_diceTwoId);

                        if (ShouldRollTargetThird)
                            RollDice(_diceThreeId);

                        if (ShouldRollTargetFourth)
                            RollDice(_diceFourID);

                        if (ShouldRollTargetFifth)
                            RollDice(_diceFifthID);

                        if (ShouldRollTargetSixth)
                            RollDice(_diceSixthID);
                    }
                }

            }

        }



        private void ToggleGroupbox(GroupBox group, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                group.Enabled = value;
            });
        }


        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _diceOneId = _diceTwoId = _diceThreeId = _diceFourID = _diceFifthID = _diceSixthID = _diceHostId = -1;
            WriteToButton(RegisterFirstBtn, "First: -1");
            WriteToButton(RegisterSecondBtn, "Second: -1");
            WriteToButton(RegisterThirdBtn, "Third: -1");
            WriteToButton(RegisterFourthBtn, "Fourth: -1");
            WriteToButton(RegisterFifthBtn, "Fifth: -1");
            WriteToButton(RegisterSixthBtn, "Sixth: -1");

            WriteToButton(RegisterHostBtn, "Host: -1");

        }

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {
        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }

        private void ChoseDiceTargetBtn_Click(object sender, EventArgs e)
        {
            if (isManualMode)
            {
                WriteToButton(ChoseDiceTargetBtn, "Target : Host");
                ToggleGroupbox(HostDiceBox, true);
                ToggleGroupbox(TargetNumberBox, false);
                ToggleGroupbox(GlobalGroupBox, false);
                isTargetMode = true;
                isManualMode = false;

            }
            else if (isTargetMode)
            {
                WriteToButton(ChoseDiceTargetBtn, "Target : Manual");
                ToggleGroupbox(HostDiceBox, false);
                ToggleGroupbox(TargetNumberBox, true);
                ToggleGroupbox(GlobalGroupBox, true);
                isTargetMode = false;
                isManualMode = true;

            }
        }

        // TEMP FIX


        private void StartGlobalTargetSync()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    DiceSelectedResult1 = GlobalSelectResult;
                    DiceSelectedResult2 = GlobalSelectResult;
                    DiceSelectedResult3 = GlobalSelectResult;
                    DiceSelectedResult4 = GlobalSelectResult;
                    DiceSelectedResult5 = GlobalSelectResult;
                    DiceSelectedResult6 = GlobalSelectResult;

                } while (isGlobalTargetOn);
            }).Start();
        }




        private void AntiCheatBtn_Click(object sender, EventArgs e)
        {
            if (shouldKillBot)
            {
                shouldKillBot = false;
                WriteToButton(AntiCheatBtn, "Auto-Terminate bot : FALSE");
            }
            else
            {
                shouldKillBot = true;
                WriteToButton(AntiCheatBtn, "Auto-Terminate bot : TRUE");
            }
        }

        private void ShoutPhraseBtn_Click(object sender, EventArgs e)
        {
            if (ShouldShoutPhrase)
            {
                WriteToButton(ShoutPhraseBtn, "Shout phrase  : FALSE");
                ShouldShoutPhrase = false;
            }
            else
            {
                WriteToButton(ShoutPhraseBtn, "Shout phrase  : TRUE");
                ShouldShoutPhrase = true;
            }
        }

        private void GlobalTargetBtn_Click(object sender, EventArgs e)
        {
            if (isGlobalTargetOn)
            {
                WriteToButton(GlobalTargetBtn, "Global Target : OFF");
                isGlobalTargetOn = false;
            }
            else
            {
                WriteToButton(GlobalTargetBtn, "Global Target : ON");
                isGlobalTargetOn = true;
                StartGlobalTargetSync();
            }
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
        }

        public void OnRoomUserStartTyping(DataInterceptedEventArgs e)
        {
        }


        private void DiceStart()
        {
            if (isManualMode)
            {
                if (DiceSelected1)
                {
                    if (DiceSelectedResult1 == 0)
                    {
                        CloseDice(_diceOneId);
                    }
                    else
                    {
                        RollDice(_diceOneId);

                    }
                }
                if (DiceSelected2)
                {

                    if (DiceSelectedResult2 == 0)
                    {
                        CloseDice(_diceTwoId);
                    }
                    else
                    {
                        RollDice(_diceTwoId);

                    }
                }
                if (DiceSelected3)
                {
                    if (DiceSelectedResult3 == 0)
                    {
                        CloseDice(_diceThreeId);
                    }
                    else
                    {
                        RollDice(_diceThreeId);

                    }
                }
                if (DiceSelected4)
                {
                    if (DiceSelectedResult4 == 0)
                    {
                        CloseDice(_diceFourID);
                    }
                    else
                    {
                        RollDice(_diceFourID);
                    }
                }
                if (DiceSelected5)
                {
                    if (DiceSelectedResult5 == 0)
                    {
                        CloseDice(_diceFifthID);
                    }
                    else
                    {
                        RollDice(_diceFifthID);

                    }
                }
                if (DiceSelected6)
                {
                    if (DiceSelectedResult6 == 0)
                    {
                        CloseDice(_diceSixthID);
                    }
                    else
                    {
                        RollDice(_diceSixthID);
                    }
                }
            }
            else if (isTargetMode)
            {
                if (DiceSelected1)
                    RollDice(_diceOneId);

                if (DiceSelected2)
                    RollDice(_diceTwoId);

                if (DiceSelected3)
                    RollDice(_diceThreeId);

                if (DiceSelected4)
                    RollDice(_diceFourID);

                if (DiceSelected5)
                    RollDice(_diceFifthID);

                if (DiceSelected6)
                    RollDice(_diceSixthID);
            }


        }
        private void StartHoloBotBtn_Click(object sender, EventArgs e)
        {
            if (!IsBotActive)
            {
                IsBotActive = true;
                Broadcast("Bot started!");
                WriteToButton(EnableBotBtn, "Bot : ON");
                DiceStart();
            }
            else
            {
                DiceStart();
            }
        }
        private void EnableHoloBotBtn_Click(object sender, EventArgs e)
        {
            if (IsBotActive)
            {
                IsBotActive = false;
                WriteToButton(EnableBotBtn, "Bot : OFF");
            }
            else
            {
                IsBotActive = true;
                WriteToButton(EnableBotBtn, "Bot : ON");
            }
        }

        private void RollDice(int diceID)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(Out.TriggerDice, diceID);
            }
        }

        private void CloseDice(int diceID)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(Out.CloseDice, diceID);
            }
        }

        private void Broadcast(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[DICE BOT]: " + text, 0, 1, 0, -1);
            }
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
            e.Continue();

        }

        public void InFloorItemUpdate(DataInterceptedEventArgs e)
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


            if (id == _diceHostId)
            {
                DiceHostResult = diceState;

                if (isTargetMode)
                {
                    if (IsBotActive)
                    {
                        if (diceState == 0)
                        {
                            CloseDice(_diceOneId);
                            CloseDice(_diceTwoId);
                            CloseDice(_diceThreeId);
                            CloseDice(_diceFourID);
                            CloseDice(_diceFifthID);
                            CloseDice(_diceSixthID);

                        }
                    }
                }


                if (IsBotActive)
                {
                    if (isManualMode)
                    {
                        if (DiceSelectedResult1 == 0)
                        {
                            CloseDice(_diceOneId);
                        }
                        if (DiceSelectedResult2 == 0)
                        {
                            CloseDice(_diceTwoId);
                        }
                        if (DiceSelectedResult3 == 0)
                        {
                            CloseDice(_diceThreeId);
                        }
                        if (DiceSelectedResult4 == 0)
                        {
                            CloseDice(_diceFourID);
                        }
                        if (DiceSelectedResult5 == 0)
                        {
                            CloseDice(_diceFifthID);
                        }
                        if (DiceSelectedResult6 == 0)
                        {
                            CloseDice(_diceSixthID);
                        }
                    }
                }
            }


            else if (id == _diceOneId) DiceResult1 = diceState;
            else if (id == _diceTwoId) DiceResult2 = diceState;
            else if (id == _diceThreeId) DiceResult3 = diceState;
            else if (id == _diceFourID) DiceResult4 = diceState;
            else if (id == _diceFifthID) DiceResult5 = diceState;
            else if (id == _diceSixthID) DiceResult6 = diceState;

            else return;

            if (diceState < 1) return;

            if (IsBotActive)
            {
                // FOLLOWS HOST DICE
                if (isTargetMode)
                {
                    if ((!ShouldRollFirst && !DiceSelected2 && !DiceSelected3 && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollFirst && !ShouldRollSecond && !DiceSelected3 && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollFirst && !ShouldRollSecond && !ShouldRollThird && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollFirst && !ShouldRollSecond && !ShouldRollThird && !ShouldRollFourth && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollFirst && !ShouldRollSecond && !ShouldRollThird && !ShouldRollFourth && !ShouldRollFifth && !DiceSelected6) ||
                        (!ShouldRollFirst && !ShouldRollSecond && !ShouldRollThird && !ShouldRollFourth && !ShouldRollFifth && !ShouldRollSixth))
                    {
                        //WON! Do the victory procedure here.

                        if (Connection.Remote.IsConnected)
                        {
                            if (ShouldShoutPhrase)
                            {
                                Connection.SendToServerAsync(Out.RoomUserShout, ShoutPhrase, 0);
                            }
                        }

                        // KILLS THE BOT TO AVOID CHEAT SUSPICIONS , JUST RESTART IT WITH THE BUTTON!

                        if (shouldKillBot)
                        {
                            IsBotActive = false;
                            WriteToButton(EnableBotBtn, "Bot : OFF");
                        }
                    }
                    else
                    {
                        if (ShouldRollFirst)
                            RollDice(_diceOneId);

                        if (ShouldRollSecond)
                            RollDice(_diceTwoId);

                        if (ShouldRollThird)
                            RollDice(_diceThreeId);

                        if (ShouldRollFourth)
                            RollDice(_diceFourID);

                        if (ShouldRollFifth)
                            RollDice(_diceFifthID);

                        if (ShouldRollSixth)
                            RollDice(_diceSixthID);
                    }
                }

                // FOLLOWS MANUAL CONTROLS
                if (isManualMode)
                {
                    if ((!ShouldRollTargetFirst && !DiceSelected2 && !DiceSelected3 && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollTargetFirst && !ShouldRollTargetSecond && !DiceSelected3 && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollTargetFirst && !ShouldRollTargetSecond && !ShouldRollTargetThird && !DiceSelected4 && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollTargetFirst && !ShouldRollTargetSecond && !ShouldRollTargetThird && !ShouldRollTargetFourth && !DiceSelected5 && !DiceSelected6) ||
                        (!ShouldRollTargetFirst && !ShouldRollTargetSecond && !ShouldRollTargetThird && !ShouldRollTargetFourth && !ShouldRollTargetFifth && !DiceSelected6) ||
                        (!ShouldRollTargetFirst && !ShouldRollTargetSecond && !ShouldRollTargetThird && !ShouldRollTargetFourth && !ShouldRollTargetFifth && !ShouldRollTargetSixth))
                    {
                        //WON! Do the victory procedure here.

                        if (Connection.Remote.IsConnected)
                        {
                            if (ShouldShoutPhrase)

                            {
                                Connection.SendToServerAsync(Out.RoomUserShout, ShoutPhrase, 0);
                            }
                        }

                        // KILLS THE BOT TO AVOID CHEAT SUSPICIONS , JUST RESTART IT WITH THE BUTTON!
                        if (shouldKillBot)
                        {
                            IsBotActive = false;
                            WriteToButton(EnableBotBtn, "Bot : OFF");
                        }
                    }
                    else
                    {
                        if (ShouldRollTargetFirst)
                            RollDice(_diceOneId);

                        if (ShouldRollTargetSecond)
                            RollDice(_diceTwoId);

                        if (ShouldRollTargetThird)
                            RollDice(_diceThreeId);

                        if (ShouldRollTargetFourth)
                            RollDice(_diceFourID);

                        if (ShouldRollTargetFifth)
                            RollDice(_diceFifthID);

                        if (ShouldRollTargetSixth)
                            RollDice(_diceSixthID);
                    }
                }

            }

        }
    }
}