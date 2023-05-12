namespace XRL.World.Parts {
  public class PKRCX_Recompositrex : IPoweredPart {
    public PKRCX_Recompositrex() {
      this.WorksOnSelf = true;
    }

    public override bool WantEvent(int id, int cascade) {
      return id == CanSmartUseEvent.ID
          || id == CommandSmartUseEvent.ID
          || id == GetPointsOfInterestEvent.ID
          || base.WantEvent(id, cascade);
    }

    // I'm not sure what the contract on this looks like
    public override bool HandleEvent(CanSmartUseEvent e) {
      if (e.Actor.IsPlayer() && this.IsReady(false)) {
        return false;
      }
      return base.HandleEvent(e);
    }

    public override bool HandleEvent(CommandSmartUseEvent e) {
      if (e.Actor.IsPlayer() && this.IsReady(false)) {
      }
      return base.HandleEvent(e);
    }

    public override bool HandleEvent(GetPointsOfInterestEvent e) {
      if (e.StandardChecks(this, e.Actor)) {
        e.Add(ParentObject, ParentObject.BaseDisplayName, Radius: 1);
      }
      return base.HandleEvent(e);
    }
  }
}