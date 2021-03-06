﻿using Exiled.API.Features;
using NPCS.Harmony;
using NPCS.Talking;
using System.Collections.Generic;

namespace NPCS.Actions
{
    internal class RoundEndAction : NodeAction
    {
        public override string Name => "RoundEndAction";

        public override void Process(Npc npc, Player player, Dictionary<string, string> args)
        {
            RoundSummaryFix.__npc_endRequested = true;
        }
    }
}