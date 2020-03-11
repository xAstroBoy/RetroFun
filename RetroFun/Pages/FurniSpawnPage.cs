using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Protocol;
using Sulakore.Components;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FurniSpawnPage : ObservablePage, ISubscriber
    {
        private Random rand = new Random();
        private int _FurniID;
        private int LocalFurniID;

        public int FurniID
        {
            get => _FurniID;
            set
            {
                _FurniID = value;
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

        private string _FurniOwnerName =" ";

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
        public bool SpawnFurniOnClick
        {
            get => _SpawnFurniOnClick;
            set
            {
                _SpawnFurniOnClick = value;
                RaiseOnPropertyChanged();
            }
        }



        public FurniSpawnPage()
        {
            InitializeComponent();

            Bind(FurnIDnbx, "Value", nameof(FurniID));
            Bind(CoordXNbx, "Value", nameof(CoordX));
            Bind(CoordYNbx, "Value", nameof(CoordY));
            Bind(CoordZNBx, "Value", nameof(CoordZ));
            Bind(RotationNbx, "Value", nameof(FurniRotation));
            Bind(FurniOwnerTxbx, "Text", nameof(FurniOwnerName));

            LocalFurniID = rand.Next(1498128, 9999999);
        }
        public bool IsReceiving => true;

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {
        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }

        public void inUserProfile(DataInterceptedEventArgs e)
        {
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
        }

        public void OnUserLeaveRoom(DataInterceptedEventArgs e)
        {
        }

        public void OnLatencyTest(DataInterceptedEventArgs e)
        {
        }

        public void InUserEnterRoom(DataInterceptedEventArgs e)
        {
        }

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
            int coordX = e.Packet.ReadInteger();
            int coordY = e.Packet.ReadInteger();
            if (SpawnFurniOnClick)
            {
                CoordX = coordX;
                CoordY = coordY;
                SpawnFurni(FurniID, coordX, coordY, CoordZ, FurniRotation, FurniOwnerName);
                e.IsBlocked = true;
            }
        }

        public void OnUsername(DataInterceptedEventArgs e)
        {
            HMessage packet = e.Packet;
            string username = packet.ReadString();

            FurniOwnerName = username;
            
        }


        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
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
            SpawnFurni(FurniID, CoordX, CoordY, CoordZ, FurniRotation, FurniOwnerName); 
        }

        private void SpawnFurni(int FurniID, int CoordX, int CoordY, int CoordZ, int FurniRotation, string Owner) 
        {
            LocalFurniID++;
            Connection.SendToClientAsync(In.AddFloorItem, new object[]
            {
                LocalFurniID,
                FurniID,
                CoordX,
                CoordY,
                FurniRotation,
                CoordZ,
                "0.0",
                0,
                0,
                false,
                false,
                -1,
                0,
                0,
                0,// REMOVE IF BAD
                Owner,
            });
        }

        private void SetOwnUsernameBtn_Click(object sender, EventArgs e)
        {
            Connection.SendToServerAsync(Out.RequestUserData);

        }

        private void SpawnFloorFurniOnClickBtn_Click(object sender, EventArgs e)
        {
            if(SpawnFurniOnClick)
            {
                WriteToButton(SpawnFloorFurniOnClickBtn, "Spawn Floor Furni on click : OFF");
                SpawnFurniOnClick = false;
            }
            else
            {
                WriteToButton(SpawnFloorFurniOnClickBtn, "Spawn Floor Furni on click : ON");
                Speak("The User won't be able to move until this option is toggled off!");
                SpawnFurniOnClick = true;
            }
        }


        private void Speak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Furni Spawner]: " + text, 0, 34, 0, -1);
            }
        }


        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }


    }
}
