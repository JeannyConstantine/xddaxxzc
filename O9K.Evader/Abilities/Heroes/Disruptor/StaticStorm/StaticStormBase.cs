﻿namespace O9K.Evader.Abilities.Heroes.Disruptor.StaticStorm
{
    using Base;
    using Base.Evadable;
    using Base.Usable.DisableAbility;

    using Core.Entities.Abilities.Base;
    using Core.Entities.Metadata;

    using Divine;

    [AbilityId(AbilityId.disruptor_static_storm)]
    internal class StaticStormBase : EvaderBaseAbility, IEvadable, IUsable<DisableAbility>
    {
        public StaticStormBase(Ability9 ability)
            : base(ability)
        {
        }

        public EvadableAbility GetEvadableAbility()
        {
            return new StaticStormEvadable(this.Ability, this.Pathfinder, this.Menu);
        }

        public DisableAbility GetUsableAbility()
        {
            return new DisableAbility(this.Ability, this.Menu);
        }
    }
}