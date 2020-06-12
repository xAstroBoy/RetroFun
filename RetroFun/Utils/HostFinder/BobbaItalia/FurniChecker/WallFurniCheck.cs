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
        public static List<HWallItem> RemovedIrregularWallFurnis = new List<HWallItem>();
        public static List<HWallItem> RemovedRegularWallFurnis = new List<HWallItem>();
        public static List<HWallItem> SnapshotRemovedIrregularWallFurnis = new List<HWallItem>();
        public static List<HWallItem> SnapshotRemovedRegularWallFurnis = new List<HWallItem>();

        public static void HandleAddedFurni(HWallItem item)
        {
            if (SnapshotRemovedWallItems.Contains(item))
            {
                SnapshotRemovedWallItems.Remove(item);
            }
            if (RemovedIrregularWallFurnis.Contains(item))
            {
                RemovedIrregularWallFurnis.Remove(item);
            }
            if (SnapshotRemovedIrregularWallFurnis.Contains(item))
            {
                SnapshotRemovedIrregularWallFurnis.Remove(item);
            }
            if (SnapshotRemovedRegularWallFurnis.Contains(item))
            {
                SnapshotRemovedRegularWallFurnis.Remove(item);
            }

        }

        public static void UpdateWallFurniPosition(string id, string newpos)
        {
            if (int.TryParse(id, out int furniid))
            {
                UpdateWallFurniPosition(furniid, newpos);
            }
        }


        public static void UpdateWallFurniPosition(int id, string newpos)
        {
            try
            {
                if (IrregularWallFurni.Find(f => f.Id == id) != null) { IrregularWallFurni.Find(f => f.Id == id).Location = newpos; }
                if (CrystalsWallItems.Find(f => f.Id == id) != null) { CrystalsWallItems.Find(f => f.Id == id).Location = newpos; }
                if (CatalogueWallFurnis.Find(f => f.Id == id) != null) { CatalogueWallFurnis.Find(f => f.Id == id).Location = newpos; }
                if (RaresWallFurnis.Find(f => f.Id == id) != null) { RaresWallFurnis.Find(f => f.Id == id).Location = newpos; }
                if (RegularWallFurni.Find(f => f.Id == id) != null) { RegularWallFurni.Find(f => f.Id == id).Location = newpos; }
                if (WhitelistedWallFurni.Find(f => f.Id == id) != null) { WhitelistedWallFurni.Find(f => f.Id == id).Location = newpos; }
                if (HIDDEN_IRREGULAR_WALLFURNIS.Find(f => f.Id == id) != null) { HIDDEN_IRREGULAR_WALLFURNIS.Find(f => f.Id == id).Location = newpos; }
                if (HIDDEN_REGULAR_WALLFURNIS.Find(f => f.Id == id) != null) { HIDDEN_REGULAR_WALLFURNIS.Find(f => f.Id == id).Location = newpos; }
                if (WallRaresSnapshotCount.Find(f => f.Id == id) != null) { WallRaresSnapshotCount.Find(f => f.Id == id).Location = newpos; }
                if (RoomWallItemsSnapshot.Find(f => f.Id == id) != null) { RoomWallItemsSnapshot.Find(f => f.Id == id).Location = newpos; }
                if (SnapShotIrregularWallFurni.Find(f => f.Id == id) != null) { SnapShotIrregularWallFurni.Find(f => f.Id == id).Location = newpos; }
                if (SnapshotRegularWallItems.Find(f => f.Id == id) != null) { SnapshotRegularWallItems.Find(f => f.Id == id).Location = newpos; }
                if (SnapshotRemovedWallItems.Find(f => f.Id == id) != null) { SnapshotRemovedWallItems.Find(f => f.Id == id).Location = newpos; }
                if (SnapshotCatalogueWallItems.Find(f => f.Id == id) != null) { SnapshotCatalogueWallItems.Find(f => f.Id == id).Location = newpos; }
                if (UnknownWallItems.Find(f => f.Id == id) != null) { UnknownWallItems.Find(f => f.Id == id).Location = newpos; }
                if (SnapshotCrystalsWallFurnis.Find(f => f.Id == id) != null) { SnapshotCrystalsWallFurnis.Find(f => f.Id == id).Location = newpos; }
                if (RemovedIrregularWallFurnis.Find(f => f.Id == id) != null) { RemovedIrregularWallFurnis.Find(f => f.Id == id).Location = newpos; }
                if (RemovedRegularWallFurnis.Find(f => f.Id == id) != null) { RemovedRegularWallFurnis.Find(f => f.Id == id).Location = newpos; }
                if (SnapshotRemovedRegularWallFurnis.Find(f => f.Id == id) != null) { SnapshotRemovedRegularWallFurnis.Find(f => f.Id == id).Location = newpos; }
                if (SnapshotRemovedIrregularWallFurnis.Find(f => f.Id == id) != null) { SnapshotRemovedIrregularWallFurnis.Find(f => f.Id == id).Location = newpos; }
            }
            catch (Exception) { }

        }
        public static void HandleRemovedFurni(HWallItem item)
        {
            if (IrregularWallFurni.Contains(item)) { IrregularWallFurni.Remove(item); if (!RemovedIrregularWallFurnis.Contains(item)) { RemovedIrregularWallFurnis.Add(item); } }
            if (RegularWallFurni.Contains(item)) { RegularWallFurni.Remove(item); if (!RemovedRegularWallFurnis.Contains(item)) {RemovedRegularWallFurnis.Add(item); }}
            if (WhitelistedWallFurni.Contains(item)) { WhitelistedWallFurni.Remove(item); }
            if (HIDDEN_IRREGULAR_WALLFURNIS.Contains(item)) { HIDDEN_IRREGULAR_WALLFURNIS.Remove(item); }
            if (HIDDEN_REGULAR_WALLFURNIS.Contains(item)) { HIDDEN_REGULAR_WALLFURNIS.Remove(item); }
            if (WallRaresSnapshotCount.Contains(item)) { WallRaresSnapshotCount.Remove(item); }
            if (SnapshotRegularWallItems.Contains(item)) { SnapshotRegularWallItems.Remove(item); }
            if (SnapShotIrregularWallFurni.Contains(item)) { SnapShotIrregularWallFurni.Remove(item); }
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
            SnapshotRemovedRegularWallFurnis.Clear();
            SnapshotRemovedIrregularWallFurnis.Clear();
        }
    }
}
