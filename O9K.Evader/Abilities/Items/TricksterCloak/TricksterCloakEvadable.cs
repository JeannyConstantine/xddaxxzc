﻿namespace O9K.Evader.Abilities.Items.TricksterCloak
{
    using Base.Evadable;

    using Core.Entities.Abilities.Base;
    using Core.Entities.Units;

    using Divine;

    using Metadata;

    using Pathfinder.Obstacles.Modifiers;

    internal sealed class TricksterCloakEvadable : ModifierCounterEvadable
    {
        public TricksterCloakEvadable(Ability9 ability, IPathfinder pathfinder, IMainMenu menu)
            : base(ability, pathfinder, menu)
        {
        }

        public override bool ModifierEnemyCounter { get; } = true;

        public override void AddModifier(Modifier modifier, Unit9 modifierOwner)
        {
            var obstacle = new ModifierEnemyObstacle(this, modifier, modifierOwner, 800);
            this.Pathfinder.AddObstacle(obstacle);
        }
    }
}