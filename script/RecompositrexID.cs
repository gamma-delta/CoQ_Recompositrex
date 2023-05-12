using System;
using XRL;
using XRL.World;
using XRL.World.Parts;

[Serializable]
public struct RecompositrexID {
  public readonly string ZoneCoord;
  public readonly int X, Y;
  public readonly Guid ID;

  public RecompositrexID(PKRCX_Recompositrex recomp) {
    this.ID = Guid.NewGuid();

    this.ZoneCoord = recomp.ParentObject.CurrentZone.ZoneID;
    this.X = recomp.ParentObject.CurrentCell.X;
    this.Y = recomp.ParentObject.CurrentCell.Y;
  }
}
