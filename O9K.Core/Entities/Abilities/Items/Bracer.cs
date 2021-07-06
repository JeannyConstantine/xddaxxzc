﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_bracer)]
    public class Bracer : PassiveAbility
    {
        public Bracer(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}