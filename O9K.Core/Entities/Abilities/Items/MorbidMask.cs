﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_lifesteal)]
    public class MorbidMask : PassiveAbility
    {
        public MorbidMask(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}