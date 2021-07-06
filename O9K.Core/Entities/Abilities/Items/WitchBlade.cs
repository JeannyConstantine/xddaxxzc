﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_witch_blade)]
    public class WitchBlade : PassiveAbility
    {
        public WitchBlade(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}