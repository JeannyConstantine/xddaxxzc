﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_tranquil_boots)]
    public class TranquilBoots : PassiveAbility
    {
        public TranquilBoots(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}