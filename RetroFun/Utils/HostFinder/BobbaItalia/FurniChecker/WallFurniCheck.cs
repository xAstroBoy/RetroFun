using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.HostFinder.BobbaItalia
{
    public class WallFurniCheck
    {


        public static List<HWallItem> IrregularWallFurni = new List<HWallItem>();
        public static List<HWallItem> CrystalsWallItems = new List<HWallItem>();
        public static List<HWallItem> CatalogueWallFurnis = new List<HWallItem>();
        public static List<HWallItem> RaresWallFurnis = new List<HWallItem>();
        public static List<HWallItem> RegularWallFurni = new List<HWallItem>();
        public static List<HWallItem> WhitelistedWallFurni = new List<HWallItem>();
        public static List<HWallItem> HIDDEN_IRREGULAR_WALLFURNIS = new List<HWallItem>();
        public static List<HWallItem> HIDDEN_REGULAR_WALLFURNIS = new List<HWallItem>();
        public static List<HWallItem> WallRaresSnapshotCount = new List<HWallItem>();
        public static List<HWallItem> RoomWallItemsSnapshot = new List<HWallItem>();
        public static List<HWallItem> SnapShotIrregularWallFurni = new List<HWallItem>();
        public static List<HWallItem> SnapshotRegularWallItems = new List<HWallItem>();
        public static List<HWallItem> SnapshotRemovedWallItems = new List<HWallItem>();
        public static List<HWallItem> SnapshotCatalogueWallItems = new List<HWallItem>();
        public static List<HWallItem> UnknownWallItems = new List<HWallItem>();
        public static List<HWallItem> SnapshotCrystalsWallFurnis = new List<HWallItem>();


        public static void HandleRemovedFurni(HWallItem item)
        {
            if (IrregularWallFurni.Contains(item)) { IrregularWallFurni.Remove(item); }
            if (RegularWallFurni.Contains(item)) { RegularWallFurni.Remove(item); }
            if (WhitelistedWallFurni.Contains(item)) { WhitelistedWallFurni.Remove(item); }
            if (HIDDEN_IRREGULAR_WALLFURNIS.Contains(item)) { HIDDEN_IRREGULAR_WALLFURNIS.Remove(item); }
            if (HIDDEN_REGULAR_WALLFURNIS.Contains(item)) { HIDDEN_REGULAR_WALLFURNIS.Remove(item); }
            if (WallRaresSnapshotCount.Contains(item)) { WallRaresSnapshotCount.Remove(item); }
            if (SnapshotRegularWallItems.Contains(item)) { SnapshotRegularWallItems.Remove(item); }
            if (SnapShotIrregularWallFurni.Contains(item)) { SnapShotIrregularWallFurni.Remove(item); }
            if (SnapshotRemovedWallItems.Contains(item)) { SnapshotRemovedWallItems.Remove(item); }
            if (CatalogueWallFurnis.Contains(item)) { CatalogueWallFurnis.Remove(item); }
            if (RaresWallFurnis.Contains(item)) { RaresWallFurnis.Remove(item); }
            if (RoomWallItemsSnapshot.Contains(item)) { RoomWallItemsSnapshot.Remove(item); }
            if (SnapshotCatalogueWallItems.Contains(item)) { SnapshotCatalogueWallItems.Remove(item); }
            if (CrystalsWallItems.Contains(item)) { CrystalsWallItems.Remove(item); }
            if (SnapshotCrystalsWallFurnis.Contains(item)) { SnapshotCrystalsWallFurnis.Remove(item); }
            if (UnknownWallItems.Contains(item)) { UnknownWallItems.Remove(item); }
        }

        public static void ClearAll()
        {
            IrregularWallFurni.Clear();
            CrystalsWallItems.Clear();
            CatalogueWallFurnis.Clear();
            RaresWallFurnis.Clear();
            RegularWallFurni.Clear();
            WhitelistedWallFurni.Clear();
            HIDDEN_IRREGULAR_WALLFURNIS.Clear();
            HIDDEN_REGULAR_WALLFURNIS.Clear();
            WallRaresSnapshotCount.Clear();
            RoomWallItemsSnapshot.Clear();
            SnapShotIrregularWallFurni.Clear();
            SnapshotRegularWallItems.Clear();
            SnapshotRemovedWallItems.Clear();
            SnapshotCatalogueWallItems.Clear();
            UnknownWallItems.Clear();
            SnapshotCrystalsWallFurnis.Clear();
        }
    }
}
