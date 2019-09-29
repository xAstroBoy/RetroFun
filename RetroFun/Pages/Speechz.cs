using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sulakore.Protocol;
using RetroFun.Controls;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class Speechz : ObservablePage
    {
        private string speechtext_with_id = "";
        private HMessage packet;
        private bool first_timer_tick = false;
        private int i = 0;
        private bool switched_to_live_count_during_active_timer = false;
        private int max_increased = 0;


        public Speechz()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            first_timer_tick = true;
            timer.Enabled = true;
            btn_pause.Text = "⏸Pause";
            btn_pause.Visible = true;
        }

        private void send_packet()
        {
            speechtext_with_id = txt_speechtext.Text.Replace("<id>", i.ToString()); //replace all "<id>"s with i, leave rest of the string unchanged

            if (rdo_client.Checked) //if "Client" is checked
            {
                packet = new HMessage(In.RoomUserTalk, new object[] { 0, speechtext_with_id, 0, i, 0, 0 }); //construct incoming packet
            }
            else if (rdo_server.Checked) //else if "Server" is checked
            {
                packet = new HMessage(Out.RoomUserTalk, new object[] { speechtext_with_id, i, 0 }); //construct outgoing packet
            }

            if (packet.IsCorrupted) //check constructed packet for corruption
            {
                MessageBox.Show("Packet is corrupted and will not be sent as it would crash your Habbo client"); //If constructed packet is corrupted, only show a message informing the user of this
            }
            else //If constructed packet is not corrupted, send it...
            {
                if (rdo_client.Checked) //if "Client" is checked
                {
                    Connection.SendToClientAsync(packet.ToBytes()); //...to client
                }
                else if (rdo_server.Checked) //or if "Server" is checked
                {
                    Connection.SendToServerAsync(packet.ToBytes()); //...to server
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = Convert.ToInt32(nmr_interval.Value); //to update the interval even when the timer is running

            if (first_timer_tick)
            {
                if (rdo_ascending.Checked)
                {
                    i = 1;
                    if (rdo_live_counting.Checked)
                    {
                        max_increased = Convert.ToInt32(nmr_bubbletype.Value);
                    }
                }
                else if (rdo_descending.Checked)
                {
                    i = Convert.ToInt32(nmr_bubbletype.Value);
                }
                send_packet(); //Timer needs to count one value higher by doing only a packet send, but not changing any counting value
                update_live_count();
                first_timer_tick = false;
                if (rdo_ascending.Checked)
                {
                    i++;
                }
                else if (rdo_descending.Checked)
                {
                    i--;
                }
            }
            else
            {
                if (switched_to_live_count_during_active_timer)
                {
                    nmr_bubbletype.Value = i;
                    switched_to_live_count_during_active_timer = false;
                }

                if ((rdo_ascending.Checked && rdo_manual_value.Checked && i <= nmr_bubbletype.Value) || (rdo_ascending.Checked && rdo_live_counting.Checked && i <= max_increased))
                {
                    send_packet();
                    update_live_count();
                    i++;
                }
                else if (rdo_descending.Checked && i > 0)
                {
                    send_packet();
                    update_live_count();
                    i--;
                }
                else
                {
                    btn_pause.Visible = false;
                    timer.Enabled = false;
                }
            }
        }

        private void update_live_count() //update the value in the bubble type box
        {
            if (rdo_live_counting.Checked) //but only when "Live counting" is checked/enabled
            {
                nmr_bubbletype.Value = i;
            }
        }

        private void rdo_live_counting_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_live_counting.Checked && timer.Enabled)
            {
                switched_to_live_count_during_active_timer = true; //only needed when switching to live count to update the current value (increasing/decreasing the value while actually using live counting it is not being done here)
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (btn_pause.Text == "⏸Pause")
            {
                timer.Enabled = false;
                btn_pause.Text = "▶Resume";
            }
            else if (btn_pause.Text == "▶Resume")
            {
                timer.Enabled = true;
                btn_pause.Text = "⏸Pause";
            }
        }
    }
}
