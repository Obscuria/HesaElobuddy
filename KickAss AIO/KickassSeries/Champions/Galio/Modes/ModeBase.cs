﻿using EloBuddy.SDK;

namespace KickassSeries.Champions.Galio.Modes
{
    public abstract class ModeBase
    {
        protected static Spell.Skillshot Q
        {
            get { return SpellManager.Q; }
        }
        protected static Spell.Targeted W
        {
            get { return SpellManager.W; }
        }
        protected static Spell.Skillshot E
        {
            get { return SpellManager.E; }
        }
        protected static Spell.Active R
        {
            get { return SpellManager.R; }
        }

        public abstract bool ShouldBeExecuted();

        public abstract void Execute();
    }
}