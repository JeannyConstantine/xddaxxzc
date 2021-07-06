﻿namespace O9K.Core.Entities.Abilities.Items
{
    using Base;

    using Divine;

    using Metadata;

    [AbilityId(AbilityId.item_vitality_booster)]
    public class VitalityBooster : PassiveAbility
    {
        public VitalityBooster(Ability baseAbility)
            : base(baseAbility)
        {
        }
    }
}