﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_mantle)]
    public class MantleOfIntelligence : PassiveAbility
    {
        public MantleOfIntelligence(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}