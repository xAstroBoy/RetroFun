using Sulakore.Habbo;
using System.Collections.Generic;

namespace RetroFun.Habbo
{
    public class PartSet
    {
        public string Type { get; set; }
        public int PaletteId { get; set; }
        public bool MAndMZero { get; set; }
        public bool MAndFZero { get; set; }
        public bool MAndMOne { get; set; }
        public bool MAndFOne { get; set; }

        public IList<Set> Sets { get; set; }
    }
    public class Set
    {
        public int Id { get; set; }
        public HGender Gender { get; set; }
        public bool Club { get; set; }
        public bool Colorable { get; set; }
        public bool Selectable { get; set; }

        public IList<Part> Parts { get; set; }
    }
    public class Part
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Colorable { get; set; }
        public int Index { get; set; }
        public int ColorIndex { get; set; }
    }
}
