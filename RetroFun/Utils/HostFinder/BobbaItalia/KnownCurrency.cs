using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.HostFinder.BobbaItalia
{
    public class KnownCurrency
    {
        // FLOOR ITEMS
        public static readonly List<int> Bobba_Distributori = new List<int> { 457, 3191 };
        public static readonly List<int> Bobba_Letsparty = new List<int> { 2631, 4425, 2940, 2995 };
        public static readonly List<int> Bobba_LimitedEditionFloorMay = new List<int> { 16083, 19963, 7935 };
        public static readonly List<int> Bobba_Dragoni = new List<int> { 1625, 1624, 1621, 1620, 3929, 4532, 1627 };
        public static readonly List<int> Bobba_RariDecorativi = new List<int> { 1590, 1588, 1587, 1586, 1585, 1584, 1583, 1582, 1581, 1580, 1579, 1609, 1574, 1573, 1572, 1571, 1570, 1568, 1567, 1566, 1565, 1564, 1563, 1562, 1561, 1560, 1559, 1558, 1557, 1556, 1555, 1554, 1553, 1552, 1551, 1550, 1549, 1638, 1637, 1636, 1635, 1634, 1633, 1632, 1631, 1630, 1629, 1608, 1607, 1606, 1605, 1604, 1603, 1602, 1601, 1600, 1599, 1618, 1617, 1616, 1615, 1614, 1613, 1612, 1611, 1610, 4661, 18854, 10698, 4660, 1775, 1774, 1770, 1769, 1768, 1767, 1766, 1765, 1648, 1647, 1646, 1645, 1644, 1643, 1642, 1641, 1640, 1639, 1592, 1598, 1597, 1596, 1595, 1594, 1593, 1591, 1589 };
        public static readonly List<int> Bobba_CrystalCambio = new List<int> { 5193, 5197, 5196, 5195, 5194 };
        public static readonly List<int> Bobba_BoBBaCambio = new List<int> { 2522, 2525, 2067, 2066, 2065, 2064, 2063, 2521, 2524 };


        // WALL ITEMS

        public static readonly List<int> Bobba_LimiteEditionMayWall = new List<int> { 25664 };


        public static bool isCrystals(HFloorItem item)
        {

            if(Bobba_CrystalCambio.Contains(item.TypeId)) { return true; }
            else if (Bobba_Distributori.Contains(item.TypeId)) { return true; }
            else if (Bobba_Letsparty.Contains(item.TypeId)) { return true; }
            else if (Bobba_Dragoni.Contains(item.TypeId)) { return true; }
            else if (Bobba_RariDecorativi.Contains(item.TypeId)) { return true; }
            else if (Bobba_LimitedEditionFloorMay.Contains(item.TypeId)) { return true; }

            return false;
        }

        public static bool isCrystals(HWallItem item)
        {

            if (Bobba_LimiteEditionMayWall.Contains(item.TypeId)) { return true; }
            else { return false; }
        }

        public static bool isCredits(HFloorItem item)
        {
            if (Bobba_BoBBaCambio.Contains(item.TypeId))
            {
                return true;
            }
            return false;
        }


    }
}
