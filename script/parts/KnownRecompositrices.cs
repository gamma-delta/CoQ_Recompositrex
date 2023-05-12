using System;
using System.Collections.Generic;

namespace XRL.World.Parts {
  // Stored on the player object. No part means no known recompositrices.
  // We actually store the 

  public class PKRCX_AuthedRecompositrices : IPart {
    public HashSet<Guid> AuthedIDs = new HashSet<Guid>();

    public static PKRCX_AuthedRecompositrices getOrCreate(GameObject target) {
      var known = target.GetPart<PKRCX_AuthedRecompositrices>();
      return known ?? target.AddPart(new PKRCX_AuthedRecompositrices());
    }

    public void authenticate(RecompositrexID id) {
      this.AuthedIDs.Add(id.ID);
    }

    public bool isAuthenticated(RecompositrexID id) {
      return this.AuthedIDs.Contains(id.ID);
    }
  }
}