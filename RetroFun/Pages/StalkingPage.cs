using System;
using System.ComponentModel;

using RetroFun.Controls;
using Sulakore.Communication;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class StalkingPage : ObservablePage
    {
        private readonly Victim[] _victims = new[]
        {
            new Victim("Bot-giochi", 1442790),	           
            new Victim("gar0u", 1615824),	
            new Victim("I.P.S", 1361879),	            
            new Victim(":Heidi:", 1569371),	            
            new Victim(":HEIDI:: (i.p.s)", 1608565),	
            new Victim("Servedio (i.p.s)", 1224246)
        };

        public StalkingPage()
        {
            InitializeComponent();

            VictimsCmbx.Items.AddRange(_victims);
            VictimsCmbx.SelectedIndex = 0;

            if (Program.Master != null)
            {
                Triggers.InAttach(In.ReceivePrivateMessage, CheckifIsBotGiochi);

            }

        }

        private void CheckifIsBotGiochi (DataInterceptedEventArgs obj)
        {
            if (Stalkbotgamescheck.Checked)
            {
                int UserID = obj.Packet.ReadInteger();
                if (UserID == 1442790)
                {
                    Connection.SendToServerAsync(Out.StalkFriend, 1442790);
                }
            }
        }

        private void StalkVictimBtn_Click(object sender, EventArgs e)
        {
            Connection.SendToServerAsync(Out.StalkFriend, ((Victim)VictimsCmbx.SelectedItem).ID);
        }

        private class Victim
        {
            public int ID { get; }
            public string Name { get; }

            public Victim(string name, int id)
            {
                ID = id;
                Name = name;
            }

            public override string ToString() => $"{Name} [#{ID}]";
        }
    }
}