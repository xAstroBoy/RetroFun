using System;
using System.ComponentModel;
using System.Windows.Forms;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Protocol;
using Sulakore.Components;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FurniSpawnPage:  ObservablePage
    {
        private Random rand = new Random();
        private int _InventoryFurniID;
        private int _FloorFurniID;

        private int LocalFurniID;
        private int _FurniAmountInv = 0;

        private int _Wallcoordsl;

        public int Wallcoordsl
        {
            get => _Wallcoordsl;
            set
            {
                _Wallcoordsl = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _Wallcoordsw;

        public int Wallcoordsw
        {
            get => _Wallcoordsw;
            set
            {
                _Wallcoordsw = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _Wallcoords2l;

        public int Wallcoords2l
        {
            get => _Wallcoords2l;
            set
            {
                _Wallcoords2l = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _Wallcoords2w;

        public int Wallcoords2w
        {
            get => _Wallcoords2w;
            set
            {
                _Wallcoords2w = value;
                RaiseOnPropertyChanged();
            }
        }




        private int _WallFurniID;

        public int WallFurniID
        {
            get => _WallFurniID;
            set
            {
                _WallFurniID = value;
                RaiseOnPropertyChanged();
            }
        }



        private string _PosterID = "2005";

        public string PosterID
        {
            get => _PosterID;
            set
            {
                _PosterID = value;
                RaiseOnPropertyChanged();
            }
        }


        private string _WallCSRotation = "l";

        public string WallCSRotation
        {
            get => _WallCSRotation;
            set
            {
                _WallCSRotation = value;
                RaiseOnPropertyChanged();
            }
        }


        private string _WallPosterID = "2005";

        public string WallPosterID
        {
            get => _WallPosterID;
            set
            {
                _WallPosterID = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _FurniType = "I";

        public string FurniType
        {
            get => _FurniType;
            set
            {
                _FurniType = value;
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


        public int InventoryFurniID
        {
            get => _InventoryFurniID;
            set
            {
                _InventoryFurniID = value;
                RaiseOnPropertyChanged();
            }
        }

        public int FurniAmountInv
        {
            get => _FurniAmountInv;
            set
            {
                _FurniAmountInv = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _CoordX;

        public int CoordX
        {
            get => _CoordX;
            set
            {
                _CoordX = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _CoordY;

        public int CoordY
        {
            get => _CoordY;
            set
            {
                _CoordY = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _CoordZ;

        public int CoordZ
        {
            get => _CoordZ;
            set
            {
                _CoordZ = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _FurniOwnerName = " ";

        public string FurniOwnerName
        {
            get => _FurniOwnerName;
            set
            {
                _FurniOwnerName = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _FurniRotation = 6;

        public int FurniRotation
        {
            get => _FurniRotation;
            set
            {
                _FurniRotation = value;
                RaiseOnPropertyChanged();
            }
        }
        private bool _SpawnFurniOnClick;
        public bool SpawnFloorFurniOnClick
        {
            get => _SpawnFurniOnClick;
            set
            {
                _SpawnFurniOnClick = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _SpawnWallFurniOnClick;
        public bool SpawnWallFurniOnClick
        {
            get => _SpawnWallFurniOnClick;
            set
            {
                _SpawnWallFurniOnClick = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _SpawnWallFurniOnValueChange;
        public bool SpawnWallFurniOnValueChange
        {
            get => _SpawnWallFurniOnValueChange;
            set
            {
                _SpawnWallFurniOnValueChange = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _SpawnFloorFurniOnValueChange;
        public bool SpawnFloorFurniOnValueChange
        {
            get => _SpawnFloorFurniOnValueChange;
            set
            {
                _SpawnFloorFurniOnValueChange = value;
                RaiseOnPropertyChanged();
            }
        }




        public FurniSpawnPage()
        {
            InitializeComponent();

            Bind(FloorFurniSpawnerNbx, "Value", nameof(FloorFurniID));
            Bind(CoordXNbx, "Value", nameof(CoordX));
            Bind(CoordYNbx, "Value", nameof(CoordY));
            Bind(CoordZNBx, "Value", nameof(CoordZ));
            Bind(RotationNbx, "Value", nameof(FurniRotation));
            Bind(FurniOwnerTxbx, "Text", nameof(FurniOwnerName));
            Bind(PosterIDTxbx, "Text", nameof(PosterID));
            Bind(AmountNbx, "Value", nameof(FurniAmountInv));

            Bind(FurniInventoryIDNbx, "Value", nameof(InventoryFurniID));

            Bind(WallFurniIDNbx, "Value", nameof(WallFurniID));
            Bind(CoordWnumbx, "Value", nameof(Wallcoordsw));
            Bind(CoordINumbx, "Value", nameof(Wallcoordsl));
            //Bind(WallPosterIDTbx, "Text", nameof(WallPosterID));
            Bind(CoordWDecimalPartNbx, "Value", nameof(Wallcoords2w));
            Bind(CoordLDecimalPartNbx, "Value", nameof(Wallcoords2l));


            LocalFurniID = rand.Next(1498128, 9999999);
        }

        public override void Out_RoomUserWalk(DataInterceptedEventArgs e)
        {
            int coordX = e.Packet.ReadInteger();
            int coordY = e.Packet.ReadInteger();
            if (SpawnFloorFurniOnClick)
            {
                CoordX = coordX;
                CoordY = coordY;
                SpawnFurni(FloorFurniID, coordX, coordY, CoordZ, FurniRotation, FurniOwnerName);
                e.IsBlocked = true;
            }
            if (SpawnWallFurniOnClick)
            {
                Wallcoordsw = coordX;
                Wallcoordsl = coordY;
                SpawnWallFurni(WallFurniID, Wallcoordsw, Wallcoordsl, WallCSRotation, FurniOwnerName);
                e.IsBlocked = true;
            }
        }

        private void RotationUp_CheckedChanged(object sender, EventArgs e)
        {
            FurniRotation = 6;
        }

        private void RotationRight_CheckedChanged(object sender, EventArgs e)
        {
            FurniRotation = 0;
        }

        private void RotationDown_CheckedChanged(object sender, EventArgs e)
        {
            FurniRotation = 2;

        }

        private void rotationLeft_CheckedChanged(object sender, EventArgs e)
        {
            FurniRotation = 4;
        }


        private void SpawnFloorFurniBtn_Click(object sender, EventArgs e)
        {
            SpawnFurni(FloorFurniID, CoordX, CoordY, CoordZ, FurniRotation, FurniOwnerName); 
        }

        private void SpawnFurni(int FurniID, int CoordX, int CoordY, int CoordZ, int FurniRotation, string Owner) 
        {
            LocalFurniID++;
            SendToClient(In.AddFloorItem, new object[]
            {
                LocalFurniID,
                FurniID,
                CoordX,
                CoordY,
                FurniRotation,
                CoordZ,
                "0.0", //<-?
                0, //<-?
                0, //<-?
                false, //<-?
                false, //<-?
                -1, //<-?
                0, //<-?
                0, //<-?
                Owner, //<-?
            });
        }

        private void SetOwnUsernameBtn_Click(object sender, EventArgs e)
        {
            FurniOwnerName = GlobalStrings.UserDetails_Username;
        }


        private void SpawnFloorFurniOnClickBtn_Click(object sender, EventArgs e)
        {
            if(SpawnFloorFurniOnClick)
            {
                WriteToButton(SpawnFloorFurniOnClickBtn, "Spawn Floor Furni on click : OFF");
                SpawnFloorFurniOnClick = false;
            }
            else
            {
                WriteToButton(SpawnFloorFurniOnClickBtn, "Spawn Floor Furni on click : ON");
                WallFurniSpeak("The User won't be able to move until this option is toggled off!");
                DisableSpawnWallFurniOnClick();
                SpawnFloorFurniOnClick = true;
            }
        }


        private void WallFurniSpeak(string text)
        {
                SendToClient(In.RoomUserWhisper, 0, "[WallFurni Spawner]: " + text, 0, 34, 0, -1);
        }
        private void FloorFurniSpeak(string text)
        {
                SendToClient(In.RoomUserWhisper, 0, "[FloorFurni Spawner]: " + text, 0, 34, 0, -1);
        }

        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }

        private void IRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            FurniType = "I";
        }

        private void SRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            FurniType = "S";
        }

        private void SpawnFurniInvBtn_Click(object sender, EventArgs e)
        {
            if (FurniType == "S")
            {
                SpawnFurniInventoryS("S",  InventoryFurniID);
            }
            else if(FurniType == "I")
            {
                SpawnFurniInventoryI("I", InventoryFurniID);

            }

        }


        private void SpawnFurniInventoryS(string furnitype, int furniIDinv)
        {
            FurniAmountInv++;

            SendToClient(In.InventoryItemUpdate, new object[]
                {
                    FurniAmountInv,
                    furnitype,
                    FurniAmountInv,
                    furniIDinv,
                    1,
                    0,
                    0,
                    true,
                    true,
                    -1,
                    -1,
                    false,
                    0,
                    false,
                    false
                    });
        }

        private void SpawnFurniInventoryI(string furnitype, int furniIDinv)
        {
            FurniAmountInv++;
            SendToClient(In.InventoryItemUpdate, new object[]
                    {
                        FurniAmountInv,
                        furnitype,
                        FurniAmountInv,
                        furniIDinv,
                        6,
                        0,
                        PosterID,
                        true,
                        true,
                        true,
                        true,
                        -1,
                        false,
                        -1
                    });
        }


        private void SpawnWallFurni(int FurniID, decimal Coordw, decimal coordsl, string FurniRotation, string Owner)
        {
            LocalFurniID++;
            SendToClient(In.AddWallItem,
                LocalFurniID.ToString(),
                FurniID,
                ":w=" + Coordw.ToString() + "," + Wallcoords2w.ToString() + " l=" + coordsl.ToString() + "," + Wallcoords2l.ToString() + " " + FurniRotation,
                false,
                false,
                -1,
                1,
                0,
                Owner
            );
            WallFurniSpeak("[DEBUG]: Furni : " + FurniID + ":w=" + Coordw.ToString() + "," + Wallcoords2w.ToString() + " l=" + coordsl.ToString() + "," + Wallcoords2l.ToString() + " " + FurniRotation + " " + PosterID + -1 + 0 + 0 + Owner);
        }


        private void DisableSpawnFloorFurniOnClick()
        {
            if(SpawnFloorFurniOnClick)
            {
                WriteToButton(SpawnFloorFurniOnClickBtn, "Spawn Floor Furni on click : OFF");
                SpawnFloorFurniOnClick = false;
            }
        }

        private void DisableSpawnWallFurniOnClick()
        {
            WriteToButton(SpawnWallFurniOnClickBtn, "Spawn Wall Furni on click : OFF");
            SpawnWallFurniOnClick = false;
        }

        private void RotationIBtn_CheckedChanged(object sender, EventArgs e)
        {
            WallCSRotation = "l";
        }

        private void RotationRBtn_CheckedChanged(object sender, EventArgs e)
        {
            WallCSRotation = "r";
        }

        private void SpawnWallFurniBtn_Click(object sender, EventArgs e)
        {
            SpawnWallFurni(WallFurniID, Wallcoordsw, Wallcoordsl, WallCSRotation,   FurniOwnerName);
        }

        private void SpawnWallFurniOnClickBtn_Click(object sender, EventArgs e)
        {
            if (SpawnWallFurniOnClick)
            {
                WriteToButton(SpawnWallFurniOnClickBtn, "Spawn Wall Furni on click : OFF");
                SpawnWallFurniOnClick = false;
            }
            else
            {
                WriteToButton(SpawnWallFurniOnClickBtn, "Spawn Wall Furni on click : ON");
                WallFurniSpeak("The User won't be able to move until this option is toggled off!");
                DisableSpawnFloorFurniOnClick();
                SpawnWallFurniOnClick = true;
            }
        }

        private void WallFurniSpawnOnChangeBtn_Click(object sender, EventArgs e)
        {
            if (SpawnWallFurniOnValueChange)
            {
                WriteToButton(WallFurniSpawnOnChangeBtn, "Spawn Wall Furni on value change : OFF");
                SpawnWallFurniOnValueChange = false;
            }
            else
            {
                WriteToButton(WallFurniSpawnOnChangeBtn, "Spawn Wall Furni on value change : ON");
                SpawnWallFurniOnValueChange = true;
            }
        }

        private void FloorlFurniSpawnOnChangeBtn_Click(object sender, EventArgs e)
        {
            if (SpawnFloorFurniOnValueChange)
            {
                WriteToButton(FloorlFurniSpawnOnChangeBtn, "Spawn Floor Furni on value change : OFF");
                SpawnFloorFurniOnValueChange = false;
            }
            else
            {
                WriteToButton(FloorlFurniSpawnOnChangeBtn, "Spawn Floor Furni on value change : ON");
                SpawnFloorFurniOnValueChange = true;
            }
        }


        // FLOORFURNI


        private void CoordXNbx_ValueChanged(object sender, EventArgs e)
        {
            if (SpawnFloorFurniOnValueChange)
            {
                SpawnFurni(FloorFurniID, CoordX, CoordY, CoordZ, FurniRotation, FurniOwnerName);
            }
        }

        private void CoordYNbx_ValueChanged(object sender, EventArgs e)
        {
            if (SpawnFloorFurniOnValueChange)
            {
                SpawnFurni(FloorFurniID, CoordX, CoordY, CoordZ, FurniRotation, FurniOwnerName);
            }
        }

        private void CoordZNBx_ValueChanged(object sender, EventArgs e)
        {
            if (SpawnFloorFurniOnValueChange)
            {
                SpawnFurni(FloorFurniID, CoordX, CoordY, CoordZ, FurniRotation, FurniOwnerName);
            }
        }


        // WALL FURNI
 

        private void CoordWDecimalPartNbx_ValueChanged(object sender, EventArgs e)
        {
            if (SpawnWallFurniOnValueChange)
            {
                SpawnWallFurni(WallFurniID, Wallcoordsw, Wallcoordsl, WallCSRotation, FurniOwnerName);
            }
        }

        private void CoordLDecimalPartNbx_ValueChanged(object sender, EventArgs e)
        {
            if (SpawnWallFurniOnValueChange)
            {
                SpawnWallFurni(WallFurniID, Wallcoordsw, Wallcoordsl, WallCSRotation, FurniOwnerName);
            }
        }

        private void CoordWnumbx_ValueChanged(object sender, EventArgs e)
        {
            if (SpawnWallFurniOnValueChange)
            {
                SpawnWallFurni(WallFurniID, Wallcoordsw, Wallcoordsl, WallCSRotation, FurniOwnerName);
            }
        }

        private void CoordINumbx_ValueChanged(object sender, EventArgs e)
        {
            if (SpawnWallFurniOnValueChange)
            {
                SpawnWallFurni(WallFurniID, Wallcoordsw, Wallcoordsl, WallCSRotation, FurniOwnerName);
            }
        }
    }
}
