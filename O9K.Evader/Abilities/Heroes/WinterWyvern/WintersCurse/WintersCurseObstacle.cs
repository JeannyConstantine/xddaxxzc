﻿namespace O9K.Evader.Abilities.Heroes.WinterWyvern.WintersCurse
{
    using System.Collections.Generic;
    using System.Linq;

    using Base.Evadable;

    using Core.Entities.Units;

    using Divine;

    using Pathfinder.Obstacles.Abilities.AreaOfEffect;

    using SharpDX;

    internal class WintersCurseObstacle : AreaOfEffectModifierObstacle
    {
        public WintersCurseObstacle(EvadableAbility ability, Vector3 position, Modifier modifier)
            : base(ability, position, modifier)
        {
        }

        public override IEnumerable<AbilityId> GetBlinks(Unit9 ally)
        {
            return Enumerable.Empty<AbilityId>();
        }

        public override IEnumerable<AbilityId> GetCounters(Unit9 ally)
        {
            return Enumerable.Empty<AbilityId>();
        }

        public override IEnumerable<AbilityId> GetDisables(Unit9 ally)
        {
            return Enumerable.Empty<AbilityId>();
        }
    }
}