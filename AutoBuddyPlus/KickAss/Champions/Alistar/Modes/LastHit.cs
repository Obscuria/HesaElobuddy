﻿using System.Linq;
using EloBuddy.SDK;

using Settings = KickassSeries.Champions.Alistar.Config.Modes.LastHit;

namespace KickassSeries.Champions.Alistar.Modes
{
    public sealed class LastHit : ModeBase
    {
        public override bool ShouldBeExecuted()
        {
            return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.LastHit);
        }

        public override void Execute()
        {
            var minion =
                EntityManager.MinionsAndMonsters.GetLaneMinions()
                    .OrderByDescending(m => m.Health)
                    .FirstOrDefault(m => m.IsValidTarget(Q.Range));

            if (minion == null) return;


            if (W.IsReady() && minion.IsValidTarget(W.Range) && Settings.UseW)
            {
                W.Cast(minion);
            }

            if (Q.IsReady() && minion.IsValidTarget(Q.Range) && Settings.UseQ)
            {
                Q.Cast();
            }
        }
    }
}
