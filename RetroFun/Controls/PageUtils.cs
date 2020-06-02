using RetroFun.Helpers;
using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Habbo.Messages;
using Sulakore.Habbo.Web;
using Sulakore.Protocol;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroFun.Controls
{
    [ToolboxItem(false)]
    [DesignerCategory("Code")]
    public class PageUtils : UserControl, INotifyPropertyChanged
    {
        private readonly Dictionary<string, Binding> _bindings;

        protected ObservableExtensionForm Module => Program.Master;
        protected override Size DefaultSize => new Size(465, 263);

        protected Incoming In => Module?.In;
        protected Outgoing Out => Module?.Out;

        protected HGame Game => Module?.Game;
        protected HGameData GameData => Module?.GameData;
        protected HTriggers Triggers => Module?.Triggers;
        protected IHConnection Connection => Module?.Connection;
        protected HHotel Hotel => Module?.Hotel ?? HHotel.Unknown;


        internal void SendToClient(byte[] data)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(data);
            }
        }

        internal void SendToClient(HMessage packet)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(packet);
            }
        }


        internal void SendToClient(ushort id, params object[] values)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(id, values);
            }
        }

        internal void SendToServer(byte[] data)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(data);
            }
        }
        internal void SendToServer(HMessage packet)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(packet);
            }
        }
        internal void SendToServer(ushort id, params object[] values)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(id, values);
            }
        }


        internal async Task AwaitSendToClient(byte[] data)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToClientAsync(data);
            }
        }

        internal async Task AwaitSendToClient(HMessage packet)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToClientAsync(packet);
            }
        }


        internal async Task AwaitSendToClient(ushort id, params object[] values)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToClientAsync(id, values);
            }
        }

        internal async Task AwaitSendToServer(byte[] data)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(data);
            }
        }
        internal async Task AwaitSendToServer(HMessage packet)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(packet);
            }
        }
        internal async Task AwaitSendToServer(ushort id, params object[] values)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(id, values);
            }
        }

        public PageUtils()
        {
            _bindings = new Dictionary<string, Binding>();

            TabStop = false;
            BackColor = Color.White;
        }

        internal void Bind(IBindableComponent component, string propertyName, string dataMember, IValueConverter converter = null, DataSourceUpdateMode dataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged)
        {
            var binding = new CustomBinding(propertyName, this, dataMember, converter)
            {
                DataSourceUpdateMode = dataSourceUpdateMode,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            };
            component.DataBindings.Add(binding);
            _bindings[dataMember] = binding;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Controls.Count == 0)
            {
                // Useful when debugging, so that we can see the region it occupies in the parent container.
                e.Graphics.Clear(Color.FromArgb(243, 63, 63));
            }
            base.OnPaint(e);
        }

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        internal virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            try
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    FindForm()?.Invoke(handler, this, e);
                }
                else
                {
                    return;
                }
            }
            catch (System.ObjectDisposedException)
            {

            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {

            }
        }

        internal void RaiseOnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }



        #endregion INotifyPropertyChanged Implementation
    }
}