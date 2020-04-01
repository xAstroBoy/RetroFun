using System.Drawing;

namespace RetroFun.Habbo
{
    public class PartColor
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public bool Club { get; set; }
        public bool Selectable { get; set; }
        public Color Color { get; set; }
        
        public PartColor()
        { }

        public PartColor(int id, int index, bool club, bool selectable, Color color)
        {
            Id = id;
            Index = index;
            Club = club;
            Selectable = selectable;
            Color = color;
        }
    }
}
