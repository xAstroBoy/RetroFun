using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Helpers
{
    public class HCatalogNode
    {
        public bool Visible { get; set; }

        public int Icon { get; set; }
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string Localization { get; set; }

        public int[] OfferIds { get; set; }
        public HCatalogNode[] Children { get; set; }

        public HCatalogNode(HMessage packet)
        {
            Visible = packet.ReadBoolean();

            Icon = packet.ReadInteger();
            PageId = packet.ReadInteger();
            PageName = packet.ReadString();
            Localization = packet.ReadString();

            OfferIds = new int[packet.ReadInteger()];
            for (int i = 0; i < OfferIds.Length; i++)
            {
                OfferIds[i] = packet.ReadInteger();
            }

            Children = new HCatalogNode[packet.ReadInteger()];
            for (int i = 0; i < Children.Length; i++)
            {
                Children[i] = new HCatalogNode(packet);
            }
        }

        public static HCatalogNode Parse(HMessage packet)
        {
            var root = new HCatalogNode(packet);
            bool newAdditionsAvailable = packet.ReadBoolean();
            string catalogType = packet.ReadString();

            return root;
        }
    }
}

