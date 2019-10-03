using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using RetroFun.Controls;
using Sulakore.Components;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class RoomBackFun : ObservablePage
    {

        private int _Tonality;
        public int Tonality
        {
            get => _Tonality;
            set
            {
                _Tonality = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _Saturation;
        public int Saturation
        {
            get => _Saturation;
            set
            {
                _Saturation = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _Luminosity;
        public int Luminosity
        {
            get => _Luminosity;
            set
            {
                _Luminosity = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _FurniID;
        public int FurniID
        {
            get => _FurniID;
            set
            {
                _FurniID = value;
                RaiseOnPropertyChanged();
            }
        }


        public RoomBackFun()
        {
            InitializeComponent();
            Bind(TonNbx, "Value", nameof(Tonality));
            Bind(SatNbx, "Value", nameof(Saturation));
            Bind(LightNbx, "Value", nameof(Luminosity));
            Bind(FurniIDnb, "Value", nameof(FurniID));

        }


        //[RoomBackground]
        // HEADER
        //{i:684050046} FURNIID 
        // {i:0} Tonality
        // {i:0} Saturation
        // {i:0} Luminosity
        // TODO: Figure how to grab FurniID



    }
}
