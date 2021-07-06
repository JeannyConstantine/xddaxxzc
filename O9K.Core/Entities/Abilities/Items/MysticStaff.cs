﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_mystic_staff)]
    public class MysticStaff : PassiveAbility
    {
        public MysticStaff(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}