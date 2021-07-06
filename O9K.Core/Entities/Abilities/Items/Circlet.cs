﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_circlet)]
    public class Circlet : PassiveAbility
    {
        public Circlet(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}