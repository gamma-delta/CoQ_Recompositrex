using System;
using XRL.UI;
using XRL.Language;

namespace XRL.World.Parts {
  [Serializable]
  public class PKRCX_RandomEnergyCell : EnergyCell {
    public string StartCharge;
    public new int MaxCharge;

    public PKRCX_RandomEnergyCell() {
      this.ChargeDisplayStyle = "amount";
      this.AltChargeDisplayStyle = "amount";
      this.IsRechargeable = false;
    }

    public override bool WantEvent(int id, int cascade) {
      return id == ObjectCreatedEvent.ID
          || base.WantEvent(id, cascade);
    }

    public override bool HandleEvent(ObjectCreatedEvent e) {
      // See LiquidVolume
      if (!StartCharge.IsNullOrEmpty()) {
        this.Charge = StartCharge.RollCached();
      }
      base.MaxCharge = this.MaxCharge;
      return base.HandleEvent(e);
    }
  }
}