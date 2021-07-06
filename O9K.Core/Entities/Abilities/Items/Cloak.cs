﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_cloak)]
    public class Cloak : PassiveAbility
    {
        public Cloak(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}