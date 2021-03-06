﻿using AutoBuddy.MainLogics;
using EloBuddy;
using EloBuddy.SDK;

namespace AutoBuddy.MyChampLogic
{
    internal class Generic : IChampLogic
    {
        public float MaxDistanceForAA { get { return int.MaxValue; } }
        public float OptimalMaxComboDistance { get { return AutoWalker.myHero.AttackRange; } }
        public float HarassDistance { get { return AutoWalker.myHero.AttackRange; } }

        public Spell.Active Q;
        public Spell.Skillshot W, E, R;

        public Generic()
        {
            skillSequence = new[] {2, 1, 3, 2, 2, 4, 2, 1, 2, 1, 4, 1, 1, 3, 3, 4, 3, 3};
        }

        public int[] skillSequence { get; private set; }
        public LogicSelector Logic { get; set; }
        
        public void Harass(AIHeroClient target)
        {
            Orbwalker.ActiveModesFlags = Orbwalker.ActiveModes.Harass;
        }

        public void Survi()
        {
            //Orbwalker.ActiveModesFlags = Orbwalker.ActiveModes.Flee;
        }

        public void Combo(AIHeroClient target)
        {
            //Orbwalker.ActiveModesFlags = Orbwalker.ActiveModes.Combo;
        }
    }
}