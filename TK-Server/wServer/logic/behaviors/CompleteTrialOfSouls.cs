﻿using wServer.core;
using wServer.core.objects;

namespace wServer.logic.behaviors
{
    internal class CompletedTrialOfSouls : Behavior
    {
        public CompletedTrialOfSouls() { }

        public override void OnDeath(Entity host, ref TickTime time)
        {
            if(host.ObjectDesc.ObjectId == "The Baron")
            {
                foreach(var player in host.World.Players)
                {
                    player.Value.Client.Character.CompletedTrialOfSouls = true;
                    player.Value.SendInfo("Congratulations you have completed the Trial of Souls");
                }
            }
        }

        protected override void TickCore(Entity host, TickTime time, ref object state)
        {
        }
    }
}
