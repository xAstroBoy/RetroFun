using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.HostFinder.BobbaItalia
{
    public class FloorFurniCheck
    {
        public static List<HFloorItem> IrregularFloorFurni = new List<HFloorItem>();
        public static List<HFloorItem> CreditsFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> CrystalsFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> CatalogueFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> RaresFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> RegularFloorFurni = new List<HFloorItem>();
        public static List<HFloorItem> WhiteListedFloorFurni = new List<HFloorItem>();
        public static List<HFloorItem> HIDDEN_IRREGULAR_FLOORFURNIS = new List<HFloorItem>();
        public static List<HFloorItem> HIDDEN_REGULAR_FLOORFURNIS = new List<HFloorItem>();
        public static List<HFloorItem> FloorRaresSnapShotCount = new List<HFloorItem>();
        public static List<HFloorItem> RoomFloorItemsSnapshot = new List<HFloorItem>();
        public static List<HFloorItem> SnapShotIrregularFloorFurni = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotRegularFloorItems = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotRemovedFloorItems = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotCatalogueFloorItems = new List<HFloorItem>();
        public static List<HFloorItem> UnknownFloorItems = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotCreditsFloorFurnis = new List<HFloorItem>();
        public static List<HFloorItem> SnapshotCrystalsFloorFurnis = new List<HFloorItem>();


        public static void HandleRemovedFurni(HFloorItem item)
        {
            if (IrregularFloorFurni.Contains(item)) { IrregularFloorFurni.Remove(item); }
            if (RegularFloorFurni.Contains(item)) { RegularFloorFurni.Remove(item); }
            if (WhiteListedFloorFurni.Contains(item)) { WhiteListedFloorFurni.Remove(item); }
            if (HIDDEN_IRREGULAR_FLOORFURNIS.Contains(item)) { HIDDEN_IRREGULAR_FLOORFURNIS.Remove(item); }
            if (HIDDEN_REGULAR_FLOORFURNIS.Contains(item)) { HIDDEN_REGULAR_FLOORFURNIS.Remove(item); }
            if (FloorRaresSnapShotCount.Contains(item)) { FloorRaresSnapShotCount.Remove(item); }
            if (SnapshotRegularFloorItems.Contains(item)) { SnapshotRegularFloorItems.Remove(item); }
            if (SnapShotIrregularFloorFurni.Contains(item)) { SnapShotIrregularFloorFurni.Remove(item); }
            if (SnapshotRemovedFloorItems.Contains(item)) { SnapshotRemovedFloorItems.Remove(item); }
            if (CreditsFloorFurnis.Contains(item)) { CreditsFloorFurnis.Remove(item); }
            if (CrystalsFloorFurnis.Contains(item)) { CrystalsFloorFurnis.Remove(item); }
            if (CatalogueFloorFurnis.Contains(item)) { CatalogueFloorFurnis.Remove(item); }
            if (RaresFloorFurnis.Contains(item)) { RaresFloorFurnis.Remove(item); }
            if (RoomFloorItemsSnapshot.Contains(item)) { RoomFloorItemsSnapshot.Remove(item); }
            if (SnapshotCatalogueFloorItems.Contains(item)) { SnapshotCatalogueFloorItems.Remove(item); }
            if (SnapshotCreditsFloorFurnis.Contains(item)) { SnapshotCreditsFloorFurnis.Remove(item); }
            if (SnapshotCrystalsFloorFurnis.Contains(item)) { SnapshotCrystalsFloorFurnis.Remove(item); }
            if (UnknownFloorItems.Contains(item)) { UnknownFloorItems.Remove(item); }
        }

        public static void ClearAll()
        {
            IrregularFloorFurni.Clear();
            CreditsFloorFurnis.Clear();
            CrystalsFloorFurnis.Clear();
            CatalogueFloorFurnis.Clear();
            RaresFloorFurnis.Clear();
            RegularFloorFurni.Clear();
            WhiteListedFloorFurni.Clear();
            HIDDEN_IRREGULAR_FLOORFURNIS.Clear();
            HIDDEN_REGULAR_FLOORFURNIS.Clear();
            FloorRaresSnapShotCount.Clear();
            RoomFloorItemsSnapshot.Clear();
            SnapShotIrregularFloorFurni.Clear();
            SnapshotRegularFloorItems.Clear();
            SnapshotRemovedFloorItems.Clear();
            SnapshotCatalogueFloorItems.Clear();
            UnknownFloorItems.Clear();
            SnapshotCreditsFloorFurnis.Clear();
            SnapshotCrystalsFloorFurnis.Clear();
        }
    }
}

