using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
using Sulakore.Modules;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class MiscellaneousPage : ObservablePage
    {
        public MiscellaneousPage()
        {
            InitializeComponent();

            Bind(NoRemoveFriendOnReport, "Checked", nameof(AntiFriendRemove));

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RemoveFriend, BlockFriendRemoval);
            }

        }

        private bool _AntiFriendRemove = true;	
        public bool AntiFriendRemove	
        {	
            get => _AntiFriendRemove;	
            set	
            {	
                _AntiFriendRemove = value;	
                RaiseOnPropertyChanged();	
            }	
        }

	
        [OutDataCapture("RemoveFriend")]
        public void BlockFriendRemoval(DataInterceptedEventArgs e)	
        {	
            if (AntiFriendRemove)	
                e.IsBlocked = true;	
        }

        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }



        private void AcquireMODPermissionsBtn_Click_1(object sender, EventArgs e)
        {
            Connection.SendToClientAsync(In.UserPermissions, int.MaxValue, int.MaxValue, true);
        }
    }
}