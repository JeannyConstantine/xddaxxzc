﻿namespace O9K.Core.Entities.Abilities.NeutralItems
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_the_leveller)]
    public class TheLeveller : PassiveAbility
    {
        public TheLeveller(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}