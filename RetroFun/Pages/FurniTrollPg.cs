using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using RetroFun.Controls;
using Sulakore;
using Sulakore.Communication;
using Sulakore.Components;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]

    public partial class FurniTrollPg : ObservablePage
    {

        #region vars

        #region private booleans
        private bool FurniIDRegistered1;
        private bool FurniIDRegistered2;
        private bool FurniIDRegistered3;
        private bool FurniIDRegistered4;
        private bool FurniIDRegistered5;
        private bool FurniIDRegistered6;
        private bool FurniIDRegistered7;
        private bool FurniIDRegistered8;
        private bool FurniIDRegistered9;
        private bool FurniIDRegistered10;
        private bool RegistrationCompleted;

        private bool _IsRegistrationMode;

        private bool _IsGlobalCooldownEnabled;


        private bool _StartFurniThread1;
        private bool _StartFurniThread2;
        private bool _StartFurniThread3;
        private bool _StartFurniThread4;
        private bool _StartFurniThread5;
        private bool _StartFurniThread6;
        private bool _StartFurniThread7;
        private bool _StartFurniThread8;
        private bool _StartFurniThread9;
        private bool _StartFurniThread10;

        private bool _isFurniBoxChecked1 = true;
        private bool _isFurniBoxChecked2;
        private bool _isFurniBoxChecked3;
        private bool _isFurniBoxChecked4;
        private bool _isFurniBoxChecked5;
        private bool _isFurniBoxChecked6;
        private bool _isFurniBoxChecked7;
        private bool _isFurniBoxChecked8;
        private bool _isFurniBoxChecked9;
        private bool _isFurniBoxChecked10;

        #endregion
        #region private ints
        private int _FurniIDInt1;
        private int _FurniIDInt2;
        private int _FurniIDInt3;
        private int _FurniIDInt4;
        private int _FurniIDInt5;
        private int _FurniIDInt6;
        private int _FurniIDInt7;
        private int _FurniIDInt8;
        private int _FurniIDInt9;
        private int _FurniIDInt10;

        private int _CooldownThread1 = 150;
        private int _CooldownThread2 = 150;
        private int _CooldownThread3 = 150;
        private int _CooldownThread4 = 150;
        private int _CooldownThread5 = 150;
        private int _CooldownThread6 = 150;
        private int _CooldownThread7 = 150;
        private int _CooldownThread8 = 150;
        private int _CooldownThread9 = 150;
        private int _CooldownThread10 = 150;

        private int _GlobalCooldown = 150;

        #endregion

        #region booleans 


        public bool IsGlobalCooldownEnabled
        {
            get => _IsGlobalCooldownEnabled;
            set
            {
                _IsGlobalCooldownEnabled = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool IsRegistrationMode
        {
            get => _IsRegistrationMode;
            set
            {
                _IsRegistrationMode = value;
                RaiseOnPropertyChanged();
            }
        }


        public bool StartFurniThread1
        {
            get => _StartFurniThread1;
            set
            {
                _StartFurniThread1 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool StartFurniThread2
        {
            get => _StartFurniThread2;
            set
            {
                _StartFurniThread2 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool StartFurniThread3
        {
            get => _StartFurniThread3;
            set
            {
                _StartFurniThread3 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool StartFurniThread4
        {
            get => _StartFurniThread4;
            set
            {
                _StartFurniThread4 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool StartFurniThread5
        {
            get => _StartFurniThread5;
            set
            {
                _StartFurniThread5 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool StartFurniThread6
        {
            get => _StartFurniThread6;
            set
            {
                _StartFurniThread6 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool StartFurniThread7
        {
            get => _StartFurniThread7;
            set
            {
                _StartFurniThread7 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool StartFurniThread8
        {
            get => _StartFurniThread8;
            set
            {
                _StartFurniThread8 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool StartFurniThread9
        {
            get => _StartFurniThread9;
            set
            {
                _StartFurniThread9 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool StartFurniThread10
        {
            get => _StartFurniThread10;
            set
            {
                _StartFurniThread10 = value;
                RaiseOnPropertyChanged();
            }
        }


        public bool isFurniBoxChecked1
        {
            get => _isFurniBoxChecked1;
            set
            {
                _isFurniBoxChecked1 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool isFurniBoxChecked2
        {
            get => _isFurniBoxChecked2;
            set
            {
                _isFurniBoxChecked2 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool isFurniBoxChecked3
        {
            get => _isFurniBoxChecked3;
            set
            {
                _isFurniBoxChecked3 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool isFurniBoxChecked4
        {
            get => _isFurniBoxChecked4;
            set
            {
                _isFurniBoxChecked4 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool isFurniBoxChecked5
        {
            get => _isFurniBoxChecked5;
            set
            {
                _isFurniBoxChecked5 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool isFurniBoxChecked6
        {
            get => _isFurniBoxChecked6;
            set
            {
                _isFurniBoxChecked6 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool isFurniBoxChecked7
        {
            get => _isFurniBoxChecked7;
            set
            {
                _isFurniBoxChecked7 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool isFurniBoxChecked8
        {
            get => _isFurniBoxChecked8;
            set
            {
                _isFurniBoxChecked8 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool isFurniBoxChecked9
        {
            get => _isFurniBoxChecked9;
            set
            {
                _isFurniBoxChecked9 = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool isFurniBoxChecked10
        {
            get => _isFurniBoxChecked10;
            set
            {
                _isFurniBoxChecked10 = value;
                RaiseOnPropertyChanged();
            }
        }

        #endregion
        #region ints

        public int FurniIDInt1
        {
            get => _FurniIDInt1;
            set
            {
                _FurniIDInt1 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int FurniIDInt2
        {
            get => _FurniIDInt2;
            set
            {
                _FurniIDInt2 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int FurniIDInt3
        {
            get => _FurniIDInt3;
            set
            {
                _FurniIDInt3 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int FurniIDInt4
        {
            get => _FurniIDInt4;
            set
            {
                _FurniIDInt4 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int FurniIDInt5
        {
            get => _FurniIDInt5;
            set
            {
                _FurniIDInt5 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int FurniIDInt6
        {
            get => _FurniIDInt6;
            set
            {
                _FurniIDInt6 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int FurniIDInt7
        {
            get => _FurniIDInt7;
            set
            {
                _FurniIDInt7 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int FurniIDInt8
        {
            get => _FurniIDInt8;
            set
            {
                _FurniIDInt8 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int FurniIDInt9
        {
            get => _FurniIDInt9;
            set
            {
                _FurniIDInt9 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int FurniIDInt10
        {
            get => _FurniIDInt10;
            set
            {
                _FurniIDInt10 = value;
                RaiseOnPropertyChanged();
            }
        }


        public int CooldownThread1
        {
            get => _CooldownThread1;
            set
            {
                _CooldownThread1 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int CooldownThread2
        {
            get => _CooldownThread2;
            set
            {
                _CooldownThread2 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int CooldownThread3
        {
            get => _CooldownThread3;
            set
            {
                _CooldownThread3 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int CooldownThread4
        {
            get => _CooldownThread4;
            set
            {
                _CooldownThread4 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int CooldownThread5
        {
            get => _CooldownThread5;
            set
            {
                _CooldownThread5 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int CooldownThread6
        {
            get => _CooldownThread6;
            set
            {
                _CooldownThread6 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int CooldownThread7
        {
            get => _CooldownThread7;
            set
            {
                _CooldownThread7 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int CooldownThread8
        {
            get => _CooldownThread8;
            set
            {
                _CooldownThread8 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int CooldownThread9
        {
            get => _CooldownThread9;
            set
            {
                _CooldownThread9 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int CooldownThread10
        {
            get => _CooldownThread10;
            set
            {
                _CooldownThread10 = value;
                RaiseOnPropertyChanged();
            }
        }

        public int GlobalCooldown
        {
            get => _GlobalCooldown;
            set
            {
                _GlobalCooldown = value;
                RaiseOnPropertyChanged();
            }
        }


        #endregion


        #endregion


        public FurniTrollPg()
        {
            InitializeComponent();

            #region checkboxes
            Bind(checkBox1, "Checked", nameof(isFurniBoxChecked1));
            Bind(checkBox2, "Checked", nameof(isFurniBoxChecked2));
            Bind(checkBox3, "Checked", nameof(isFurniBoxChecked3));
            Bind(checkBox4, "Checked", nameof(isFurniBoxChecked4));
            Bind(checkBox5, "Checked", nameof(isFurniBoxChecked5));
            Bind(checkBox6, "Checked", nameof(isFurniBoxChecked6));
            Bind(checkBox7, "Checked", nameof(isFurniBoxChecked7));
            Bind(checkBox8, "Checked", nameof(isFurniBoxChecked8));
            Bind(checkBox9, "Checked", nameof(isFurniBoxChecked9));
            Bind(checkBox10, "Checked", nameof(isFurniBoxChecked10));

            Bind(GlobalCooldownChbx, "Checked", nameof(IsGlobalCooldownEnabled));


            #endregion

            #region numericboxes
            Bind(FurniNbx1, "Value", nameof(FurniIDInt1));
            Bind(FurniNbx2, "Value", nameof(FurniIDInt2));
            Bind(FurniNbx3, "Value", nameof(FurniIDInt3));
            Bind(FurniNbx4, "Value", nameof(FurniIDInt4));
            Bind(FurniNbx5, "Value", nameof(FurniIDInt5));
            Bind(FurniNbx6, "Value", nameof(FurniIDInt6));
            Bind(FurniNbx7, "Value", nameof(FurniIDInt7));
            Bind(FurniNbx8, "Value", nameof(FurniIDInt8));
            Bind(FurniNbx9, "Value", nameof(FurniIDInt9));
            Bind(FurniNbx10, "Value", nameof(FurniIDInt10));

            Bind(CooldownNbx1, "Value", nameof(CooldownThread1));
            Bind(CooldownNbx2, "Value", nameof(CooldownThread2));
            Bind(CooldownNbx3, "Value", nameof(CooldownThread3));
            Bind(CooldownNbx4, "Value", nameof(CooldownThread4));
            Bind(CooldownNbx5, "Value", nameof(CooldownThread5));
            Bind(CooldownNbx6, "Value", nameof(CooldownThread6));
            Bind(CooldownNbx7, "Value", nameof(CooldownThread7));
            Bind(CooldownNbx8, "Value", nameof(CooldownThread8));
            Bind(CooldownNbx9, "Value", nameof(CooldownThread9));
            Bind(CooldownNbx10, "Value", nameof(CooldownThread10));


            Bind(GlobalCooldownNbx, "Value", nameof(GlobalCooldown));



            #endregion
            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.ToggleFloorItem, HandleFurniTrigger);
            }
        }


        #region threads
        private void StartThread1()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {

                        if (StartFurniThread1)
                        {
                            Connection.SendToServerAsync(Out.ToggleFloorItem, FurniIDInt1, 0);
                            Thread.Sleep(CooldownThread1);
                        }
                    
                    } while (StartFurniThread1) ;
            }).Start();
        }

        private void StartThread2()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {

                        if (StartFurniThread2)
                        {
                            Connection.SendToServerAsync(Out.ToggleFloorItem, FurniIDInt2, 0);
                            Thread.Sleep(CooldownThread2);
                        }
                    
                } while (StartFurniThread2);
            }).Start();
        }
        private void StartThread3()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {

                        if (StartFurniThread3)
                        {
                            Connection.SendToServerAsync(Out.ToggleFloorItem, FurniIDInt3, 0);
                            Thread.Sleep(CooldownThread3);

                        }
                    
                } while (StartFurniThread3);
            }).Start();
        }
        private void StartThread4()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {

                        if (StartFurniThread4)
                        {
                            Connection.SendToServerAsync(Out.ToggleFloorItem, FurniIDInt4, 0);
                            Thread.Sleep(CooldownThread4);

                        
                    }
                } while (StartFurniThread4);
            }).Start();
        }
        private void StartThread5()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {

                        if (StartFurniThread5)
                        {
                            Connection.SendToServerAsync(Out.ToggleFloorItem, FurniIDInt5, 0);
                            Thread.Sleep(CooldownThread5);

                        }
                    
                } while (StartFurniThread5);
            }).Start();
        }
        private void StartThread6()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {

                        if (StartFurniThread6)
                        {
                            Connection.SendToServerAsync(Out.ToggleFloorItem, FurniIDInt6, 0);
                            Thread.Sleep(CooldownThread6);

                        }
                    
                } while (StartFurniThread6);
            }).Start();
        }
        private void StartThread7()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {

                        if (StartFurniThread7)
                        {
                            Connection.SendToServerAsync(Out.ToggleFloorItem, FurniIDInt7, 0);
                            Thread.Sleep(CooldownThread7);
                        }
                    
                } while (StartFurniThread7);
            }).Start();
        }
        private void StartThread8()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {

                        if (StartFurniThread8)
                        {
                            Connection.SendToServerAsync(Out.ToggleFloorItem, FurniIDInt8, 0);
                            Thread.Sleep(CooldownThread8);

                        }
                    
                } while (StartFurniThread8);
            }).Start();
        }
        private void StartThread9()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                        if (StartFurniThread9)
                        {
                            Connection.SendToServerAsync(Out.ToggleFloorItem, FurniIDInt9, 0);
                            Thread.Sleep(CooldownThread9);
                        }
                    
                } while (StartFurniThread9);
            }).Start();
        }

        private void StartThread10()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                        if (StartFurniThread10)
                        {
                            Connection.SendToServerAsync(Out.ToggleFloorItem, FurniIDInt10, 0);
                            Thread.Sleep(CooldownThread10);
                        }
                    
                } while (StartFurniThread10);
            }).Start();
        }

        private void StartGlobalSpeedUpdater()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    CooldownThread1 = GlobalCooldown;
                    CooldownThread2 = GlobalCooldown;
                    CooldownThread3 = GlobalCooldown;
                    CooldownThread4 = GlobalCooldown;
                    CooldownThread5 = GlobalCooldown;
                    CooldownThread6 = GlobalCooldown;
                    CooldownThread7 = GlobalCooldown;
                    CooldownThread8 = GlobalCooldown;
                    CooldownThread9 = GlobalCooldown;
                    CooldownThread10 = GlobalCooldown;
                } while (IsGlobalCooldownEnabled);
            }).Start();
        }





        #endregion


        #region interception

        private void HandleFurniTrigger(DataInterceptedEventArgs e)
        {
            int furniid = e.Packet.ReadInteger();

            if(IsRegistrationMode)
            {
                RegisterFurni(furniid);
                e.IsBlocked = true;
            }
        }




        #endregion

        #region methods


        public void RegistrationDone()
        {
            RegistrationCompleted = true;
            IsRegistrationMode = false;
            WriteToButton(RegisterFurnIDBtn, "Registration Mode : OFF");
            RegisterFurniSpeak("Registration completed.");

        }


        public void RegisterFurni(int FurnID)
        {
            if (isFurniBoxChecked1)
            {
                if (!FurniIDRegistered1)
                {
                    FurniIDRegistered1 = true;
                    FurniIDInt1 = FurnID;
                    if(isFurniBoxChecked2)
                    {
                        RegisterFurniAsk(2);
                    }
                    else
                    {
                        RegistrationDone();
                    }
                    return;
                }
            }
            if (isFurniBoxChecked2)
            {
                if (!FurniIDRegistered2)
                {
                    FurniIDRegistered2 = true;
                    FurniIDInt2 = FurnID;
                    if(isFurniBoxChecked3)
                    {
                        RegisterFurniAsk(3);

                    }
                    else
                    {
                        RegistrationDone();
                    }
                    RegisterFurniAsk(3);
                    return;
                }
            }
            if (isFurniBoxChecked3)
            {
                if (!FurniIDRegistered3)
                {
                    FurniIDRegistered3 = true;
                    FurniIDInt3 = FurnID;
                    if (isFurniBoxChecked4)
                    {
                        RegisterFurniAsk(4);

                    }
                    else
                    {
                        RegistrationDone();
                    }
                    return;
                }
            }
            if (isFurniBoxChecked4)
            {
                if (!FurniIDRegistered4)
                {
                    FurniIDRegistered4 = true;
                    FurniIDInt4 = FurnID;
                    if (isFurniBoxChecked5)
                    {
                        RegisterFurniAsk(5);

                    }
                    else
                    {
                        RegistrationDone();
                    }
                    return;
                }
            }
            if (isFurniBoxChecked5)
            {
                if (!FurniIDRegistered5)
                {
                    FurniIDRegistered5 = true;
                    FurniIDInt5 = FurnID;
                    if (isFurniBoxChecked6)
                    {
                        RegisterFurniAsk(6);

                    }
                    else
                    {
                        RegistrationDone();
                    }
                    return;
                }
            }
            if (isFurniBoxChecked6)
            {
                if (!FurniIDRegistered6)
                {
                    FurniIDRegistered6 = true;
                    FurniIDInt6 = FurnID;
                    if (isFurniBoxChecked7)
                    {
                        RegisterFurniAsk(7);

                    }
                    else
                    {
                        RegistrationDone();
                    }
                    return;
                }
            }
            if (isFurniBoxChecked7)
            {
                if (!FurniIDRegistered7)
                {
                    FurniIDRegistered7 = true;
                    FurniIDInt7 = FurnID;
                    if (isFurniBoxChecked8)
                    {
                        RegisterFurniAsk(8);

                    }
                    else
                    {
                        RegistrationDone();
                    }
                    return;
                }
            }
            if (isFurniBoxChecked8)
            {
                if (!FurniIDRegistered8)
                {
                    FurniIDRegistered8 = true;
                    FurniIDInt8 = FurnID;
                    if (isFurniBoxChecked9)
                    {
                        RegisterFurniAsk(9);

                    }
                    else
                    {
                        RegistrationDone();
                    }
                    return;
                }
            }
            if (isFurniBoxChecked9)
            {
                if (!FurniIDRegistered9)
                {
                    FurniIDRegistered9 = true;
                    FurniIDInt9 = FurnID;
                    if (isFurniBoxChecked10)
                    {
                        RegisterFurniAsk(10);
                    }
                    else
                    {
                        RegistrationDone();
                    }
                    return;
                }
            }
            if (isFurniBoxChecked10)
            {
                if (!FurniIDRegistered10)
                {
                    FurniIDRegistered10 = true;
                    FurniIDInt10 = FurnID;
                    RegistrationDone();
                    return;
                }
            }
            return;
        }
        

        public void CheckAll()
        {
            Checker(checkBox10, true);
            Checker(checkBox7, true);
            Checker(checkBox8, true);
            Checker(checkBox9, true);
            Checker(checkBox4, true);
            Checker(checkBox5, true);
            Checker(checkBox6, true);
            Checker(checkBox3, true);
            Checker(checkBox2, true);
            Checker(checkBox1, true);
        }

        public void UncheckAll()
        {
            Checker(checkBox10, false);
            Checker(checkBox7, false);
            Checker(checkBox8, false);
            Checker(checkBox9, false);
            Checker(checkBox4, false);
            Checker(checkBox5, false);
            Checker(checkBox6, false);
            Checker(checkBox3, false);
            Checker(checkBox2, false);
            Checker(checkBox1, false);
        }

        public void HaltThreads()
        {
            StartFurniThread1 = false;
            StartFurniThread2 = false;
            StartFurniThread3 = false;
            StartFurniThread4 = false;
            StartFurniThread5 = false;
            StartFurniThread6 = false;
            StartFurniThread7 = false;
            StartFurniThread8 = false;
            StartFurniThread9 = false;
            StartFurniThread10 = false;
            ResetThreadsButtons();

        }

        public void ResetThreadsButtons()
        {
            WriteToButton(FurniIDThreadBtn1, "Thread Status : OFF");
            WriteToButton(FurniIDThreadBtn2, "Thread Status : OFF");
            WriteToButton(FurniIDThreadBtn3, "Thread Status : OFF");
            WriteToButton(FurniIDThreadBtn4, "Thread Status : OFF");
            WriteToButton(FurniIDThreadBtn5, "Thread Status : OFF");
            WriteToButton(FurniIDThreadBtn6, "Thread Status : OFF");
            WriteToButton(FurniIDThreadBtn7, "Thread Status : OFF");
            WriteToButton(FurniIDThreadBtn8, "Thread Status : OFF");
            WriteToButton(FurniIDThreadBtn9, "Thread Status : OFF");
            WriteToButton(FurniIDThreadBtn10, "Thread Status : OFF");
        }

        public void ResetFurniIDs()
        {
            FurniIDInt1 = 0;
            FurniIDInt2 = 0;
            FurniIDInt3 = 0;
            FurniIDInt4 = 0;
            FurniIDInt5 = 0;
            FurniIDInt6 = 0;
            FurniIDInt7 = 0;
            FurniIDInt8 = 0;
            FurniIDInt9 = 0;
            FurniIDInt10 = 0;
            FurniIDRegistered1 = false;
            FurniIDRegistered2 = false;
            FurniIDRegistered3 = false;
            FurniIDRegistered4 = false;
            FurniIDRegistered5 = false;
            FurniIDRegistered6 = false;
            FurniIDRegistered7 = false;
            FurniIDRegistered8 = false;
            FurniIDRegistered9 = false;
            FurniIDRegistered10 = false;
        }

        public void ResetCooldowns()
        {
            CooldownThread1 = 150;
            CooldownThread2 = 150;
            CooldownThread3 = 150;
            CooldownThread4 = 150;
            CooldownThread5 = 150;
            CooldownThread6 = 150;
            CooldownThread7 = 150;
            CooldownThread8 = 150;
            CooldownThread9 = 150;
            CooldownThread10 = 150;
            GlobalCooldown = 150;
        }
        private void WriteToButton(SKoreButton Button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                Button.Text = text;
            });
        }

        private void Checker(CheckBox checkbox, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                checkbox.Checked = value;
            });
        }


        private void UnblockNbx(NumericUpDown nbx, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                nbx.Enabled = value;
            });
        }



        private void RegisterFurniAsk(int furni)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Furni Registration]: Please Select the furni nr " + furni.ToString() + ".", 0, 34, 0, -1);
            }
        }

        private void RegisterFurniSpeak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Furni Registration]: " + text, 0, 34, 0, -1);
            }
        }


        private void ToggleThread1() 
        {
            if(FurniIDRegistered1)
            {
                if(StartFurniThread1)
                {
                    WriteToButton(FurniIDThreadBtn1, "Thread Status : OFF");
                    StartFurniThread1 = false;
                } 
                else
                {
                    WriteToButton(FurniIDThreadBtn1, "Thread Status : ON");
                    StartFurniThread1 = true;
                    StartThread1();
                }
            }
            
        }

        private void ToggleThread2()
        {
            if (FurniIDRegistered2)
            {
                if (StartFurniThread2)
                {
                    WriteToButton(FurniIDThreadBtn2, "Thread Status : OFF");
                    StartFurniThread2 = false;
                }
                else
                {
                    WriteToButton(FurniIDThreadBtn2, "Thread Status : ON");
                    StartFurniThread2 = true;
                    StartThread2();
                }
            }

        }
        private void ToggleThread3()
        {
            if (FurniIDRegistered3)
            {
                if (StartFurniThread3)
                {
                    WriteToButton(FurniIDThreadBtn3, "Thread Status : OFF");
                    StartFurniThread3 = false;
                }
                else
                {
                    WriteToButton(FurniIDThreadBtn3, "Thread Status : ON");
                    StartFurniThread3 = true;
                    StartThread3();
                }
            }

        }
        private void ToggleThread4()
        {
            if (FurniIDRegistered4)
            {
                if (StartFurniThread4)
                {
                    WriteToButton(FurniIDThreadBtn4, "Thread Status : OFF");
                    StartFurniThread4 = false;
                }
                else
                {
                    WriteToButton(FurniIDThreadBtn4, "Thread Status : ON");
                    StartFurniThread4 = true;
                    StartThread4();
                }
            }

        }

        private void ToggleThread5()
        {
            if (FurniIDRegistered5)
            {
                if (StartFurniThread5)
                {
                    WriteToButton(FurniIDThreadBtn5, "Thread Status : OFF");
                    StartFurniThread5 = false;
                }
                else
                {
                    WriteToButton(FurniIDThreadBtn5, "Thread Status : ON");
                    StartFurniThread5 = true;
                    StartThread5();
                }
            }

        }

        private void ToggleThread6()
        {
            if (FurniIDRegistered6)
            {
                if (StartFurniThread6)
                {
                    WriteToButton(FurniIDThreadBtn6, "Thread Status : OFF");
                    StartFurniThread6 = false;
                }
                else
                {
                    WriteToButton(FurniIDThreadBtn6, "Thread Status : ON");
                    StartFurniThread6 = true;
                    StartThread6();
                }
            }

        }

        private void ToggleThread7()
        {
            if (FurniIDRegistered7)
            {
                if (StartFurniThread7)
                {
                    WriteToButton(FurniIDThreadBtn7, "Thread Status : OFF");
                    StartFurniThread7 = false;
                }
                else
                {
                    WriteToButton(FurniIDThreadBtn7, "Thread Status : ON");
                    StartFurniThread7 = true;
                    StartThread7();
                }
            }

        }

        private void ToggleThread8()
        {
            if (FurniIDRegistered8)
            {
                if (StartFurniThread8)
                {
                    WriteToButton(FurniIDThreadBtn8, "Thread Status : OFF");
                    StartFurniThread8 = false;
                }
                else
                {
                    WriteToButton(FurniIDThreadBtn8, "Thread Status : ON");
                    StartFurniThread8 = true;
                    StartThread8();
                }
            }

        }


        private void ToggleThread9()
        {
            if (FurniIDRegistered9)
            {
                if (StartFurniThread9)
                {
                    WriteToButton(FurniIDThreadBtn9, "Thread Status : OFF");
                    StartFurniThread9 = false;
                }
                else
                {
                    WriteToButton(FurniIDThreadBtn9, "Thread Status : ON");
                    StartFurniThread9 = true;
                    StartThread9();
                }
            }

        }


        private void ToggleThread10()
        {
            if (FurniIDRegistered10)
            {
                if (StartFurniThread10)
                {
                    WriteToButton(FurniIDThreadBtn10, "Thread Status : OFF");
                    StartFurniThread10 = false;
                }
                else
                {
                    WriteToButton(FurniIDThreadBtn10, "Thread Status : ON");
                    StartFurniThread10 = true;
                    StartThread10();
                }
            }

        }



        #endregion


        #region buttons 


        private void GlobalCooldownChbx_CheckedChanged(object sender, EventArgs e)
        {
            if(!IsGlobalCooldownEnabled)
            {
                UnblockNbx(GlobalCooldownNbx, true);

                UnblockNbx(CooldownNbx1, false);
                UnblockNbx(CooldownNbx2, false);
                UnblockNbx(CooldownNbx3, false);
                UnblockNbx(CooldownNbx4, false);
                UnblockNbx(CooldownNbx5, false);
                UnblockNbx(CooldownNbx6, false);
                UnblockNbx(CooldownNbx7, false);
                UnblockNbx(CooldownNbx8, false);
                UnblockNbx(CooldownNbx9, false);
                UnblockNbx(CooldownNbx10, false);
                StartGlobalSpeedUpdater();
            }
            else
            {
                UnblockNbx(GlobalCooldownNbx, false);

                UnblockNbx(CooldownNbx1, true);
                UnblockNbx(CooldownNbx2, true);
                UnblockNbx(CooldownNbx3, true);
                UnblockNbx(CooldownNbx4, true);
                UnblockNbx(CooldownNbx5, true);
                UnblockNbx(CooldownNbx6, true);
                UnblockNbx(CooldownNbx7, true);
                UnblockNbx(CooldownNbx8, true);
                UnblockNbx(CooldownNbx9, true);
                UnblockNbx(CooldownNbx10, true);
            }
        }


        private void UncheckAllBtn_Click(object sender, EventArgs e)
        {
            UncheckAll();
        }

        private void CheckAllBtn_Click(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void ClearFurniIDsBtn_Click(object sender, EventArgs e)
        {
            HaltThreads();
            ResetFurniIDs();
        }










        private void FurniIDThreadBtn1_Click(object sender, EventArgs e)
        {
            ToggleThread1();
        }
        private void FurniIDThreadBtn2_Click(object sender, EventArgs e)
        {
            ToggleThread2();
        }

        private void FurniIDThreadBtn3_Click(object sender, EventArgs e)
        {
            ToggleThread3();

        }
        private void FurniIDThreadBtn4_Click(object sender, EventArgs e)
        {
            ToggleThread4();

        }
        private void FurniIDThreadBtn5_Click(object sender, EventArgs e)
        {
            ToggleThread5();
        }
        private void FurniIDThreadBtn6_Click(object sender, EventArgs e)
        {
            ToggleThread6();

        }

        private void FurniIDThreadBtn7_Click(object sender, EventArgs e)
        {
            ToggleThread7();
        }

        private void FurniIDThreadBtn8_Click(object sender, EventArgs e)
        {
            ToggleThread8();
        }


        private void FurniIDThreadBtn9_Click(object sender, EventArgs e)
        {
            ToggleThread9();
        }

        private void FurniIDThreadBtn10_Click(object sender, EventArgs e)
        {
            ToggleThread10();
        }



        private void RegisterFurnIDBtn_Click(object sender, EventArgs e)
        {
            if (!IsRegistrationMode)
            {

                ResetFurniIDs();
                HaltThreads();
                RegisterFurniSpeak("Registration has been activated.");
                RegisterFurniAsk(1);
                IsRegistrationMode = true;
                WriteToButton(RegisterFurnIDBtn, "Registration Mode : ON");

            }
            else
            {
                if (!RegistrationCompleted)
                {
                    RegisterFurniSpeak("Registration completed.");
                    WriteToButton(RegisterFurnIDBtn, "Registration Mode : OFF");

                    IsRegistrationMode = false;
                }
                else
                {
                    IsRegistrationMode = false;
                    WriteToButton(RegisterFurnIDBtn, "Registration Mode : OFF");
                }
            }

        }


        private void StopAllThreadsBtn_Click(object sender, EventArgs e)
        {
            HaltThreads();
        }


        private void StartThreadsBtn_Click(object sender, EventArgs e)
        {
            ToggleThread1();
            ToggleThread2();
            ToggleThread3();
            ToggleThread4();
            ToggleThread5();
            ToggleThread6();
            ToggleThread7();
            ToggleThread8();
            ToggleThread9();
            ToggleThread10();
        }

        private void AddfiftyBtn_Click(object sender, EventArgs e)
        {
            CooldownThread1 = CooldownThread1 + 50;
            CooldownThread2 = CooldownThread2 + 50;
            CooldownThread3 = CooldownThread3 + 50;
            CooldownThread4 = CooldownThread4 + 50;
            CooldownThread5 = CooldownThread5 + 50;
            CooldownThread6 = CooldownThread6 + 50;
            CooldownThread7 = CooldownThread7 + 50;
            CooldownThread8 = CooldownThread8 + 50;
            CooldownThread9 = CooldownThread9 + 50;
            CooldownThread10 = CooldownThread10 + 50;
        }
        private void MinusFiftyBtn_Click(object sender, EventArgs e)
        {
            CooldownThread1 = CooldownThread1 - 50;
            CooldownThread2 = CooldownThread2 - 50;
            CooldownThread3 = CooldownThread3 - 50;
            CooldownThread4 = CooldownThread4 - 50;
            CooldownThread5 = CooldownThread5 - 50;
            CooldownThread6 = CooldownThread6 - 50;
            CooldownThread7 = CooldownThread7 - 50;
            CooldownThread8 = CooldownThread8 - 50;
            CooldownThread9 = CooldownThread9 - 50;
            CooldownThread10 = CooldownThread10 - 50;
        }


        private void MinusTenBtn_Click(object sender, EventArgs e)
        {
            CooldownThread1 = CooldownThread1 - 10;
            CooldownThread2 = CooldownThread2 - 10;
            CooldownThread3 = CooldownThread3 - 10;
            CooldownThread4 = CooldownThread4 - 10;
            CooldownThread5 = CooldownThread5 - 10;
            CooldownThread6 = CooldownThread6 - 10;
            CooldownThread7 = CooldownThread7 - 10;
            CooldownThread8 = CooldownThread8 - 10;
            CooldownThread9 = CooldownThread9 - 10;
            CooldownThread10 = CooldownThread10 - 10;
        }

        private void AddtenBtn_Click(object sender, EventArgs e)
        {
            CooldownThread1 = CooldownThread1 + 10;
            CooldownThread2 = CooldownThread2 + 10;
            CooldownThread3 = CooldownThread3 + 10;
            CooldownThread4 = CooldownThread4 + 10;
            CooldownThread5 = CooldownThread5 + 10;
            CooldownThread6 = CooldownThread6 + 10;
            CooldownThread7 = CooldownThread7 + 10;
            CooldownThread8 = CooldownThread8 + 10;
            CooldownThread9 = CooldownThread9 + 10;
            CooldownThread10 = CooldownThread10 + 10;
        }

        #endregion


    }
}
