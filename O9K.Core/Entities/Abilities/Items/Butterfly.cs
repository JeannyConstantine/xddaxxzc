﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_butterfly)]
    public class Butterfly : PassiveAbility
    {
        public Butterfly(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}