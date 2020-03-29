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

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class AvatarEditorPg : ObservablePage, ISubscriber
    {
        public AvatarEditorPg()
        {
            InitializeComponent();
        }




        public bool IsReceiving => true;



        // JUST IN CASE
        public void InItemExtraData(DataInterceptedEventArgs e)
        {

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

        public void inUserProfile(DataInterceptedEventArgs e)
        {

        }

        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {

        }

        public void OnLatencyTest(DataInterceptedEventArgs e)
        {

        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {

        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {

        }

        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
        {

        }

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {

        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {

        }

        public void OnUsername(DataInterceptedEventArgs e)
        {

        }
    }
}
