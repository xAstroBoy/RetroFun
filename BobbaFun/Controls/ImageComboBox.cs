using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System;
using System.Text.RegularExpressions;

namespace RetroFun.Controls
{
    [DesignerCategory("Code")]
    public class ImageComboBox : ComboBox
    {
        public object SelectedTag => (SelectedItem as DropDownImageItem)?.Tag;

        public ImageComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }


        public object[] SortNumericItems(object[] items)
        {
            // Get the numeric values of the items.
            int num_items = items.Length;
            const string float_pattern = @"-?\d+\.?\d*";
            double[] values = new double[num_items];
            for (int i = 0; i < num_items; i++)
            {
                string match = Regex.Match(
                    items[i].ToString(), float_pattern).Value;
                double value;
                if (!double.TryParse(match, out value))
                    value = double.MinValue;
                values[i] = value;
            }

            // Sort the items array using the keys to determine order.
            Array.Sort(values, items);
            return items;
        }

        public void AddImageItem(Image image, string text, object tag)
        {
            int adjustedWidth = image.Width > Width ? Width : image.Width;
            int adjustedHeight = image.Height > ItemHeight ? ItemHeight : image.Height;
            if (image.Width != adjustedWidth || image.Height != adjustedHeight)
            {
                image = ResizeImage(image, adjustedWidth, adjustedHeight);
            }
            Items.Add(new DropDownImageItem(image, text, tag));
        }

        public void AddImageItem(string text, Image image)
        {
            image = ResizeImage(image, image.Width, image.Height > ItemHeight ? ItemHeight : image.Height);
            Items.Add(new DropDownImageItem(text, image));
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index >= 0 && e.Index < Items.Count)
            {
                var item = (DropDownImageItem)Items[e.Index];
                e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top);
                e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + item.Image.Width + 4, e.Bounds.Top + 5);
            }
            base.OnDrawItem(e);
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }



        public class DropDownImageItem
        {
            public object Tag { get; }
            public string Text { get; }
            public Image Image { get; }

            public DropDownImageItem(string text)
                : this(null, text, null)
            { }

            public DropDownImageItem(string value, Image image)
            {
                Text = value;
                Image = image;
            }


            public DropDownImageItem(Image image)
                : this(image, string.Empty, null)
            { }
            public DropDownImageItem(Image image, object tag)
                : this(image, string.Empty, tag)
            { }

            public DropDownImageItem(Image image, string text)
                : this(image, text, null)
            { }
            public DropDownImageItem(Image image, string text, object tag)
            {
                Tag = tag;
                Text = text;
                Image = image;
            }

            public override string ToString() => Text ?? string.Empty;
        }
    }
}