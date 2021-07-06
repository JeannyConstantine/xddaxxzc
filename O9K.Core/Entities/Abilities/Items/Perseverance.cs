﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_pers)]
    public class Perseverance : PassiveAbility
    {
        public Perseverance(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}