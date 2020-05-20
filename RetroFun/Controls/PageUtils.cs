using RetroFun.Helpers;
using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Habbo.Messages;
using Sulakore.Habbo.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
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
                if (DesignMode)
                {
                    _bindings[e.PropertyName].ReadValue();
                }
            } catch(System.ObjectDisposedException)
            {

            }
            catch(System.ArgumentOutOfRangeException)
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