using System;
using System.Collections.Generic;
using XRL.World.Parts;
using XRL;

// Global tracker of all the known recompositrices.
[Serializable]
public class RecompCoordsTracker {
  public static Dictionary<Guid, RecompositrexID> ids;
}