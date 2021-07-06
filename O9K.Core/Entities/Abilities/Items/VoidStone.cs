﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_void_stone)]
    public class VoidStone : PassiveAbility
    {
        public VoidStone(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}