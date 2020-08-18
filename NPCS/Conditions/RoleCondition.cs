﻿using Exiled.API.Features;
using NPCS.Talking;
using System.Collections.Generic;

namespace NPCS.Conditions
{
    internal class RoleCondition : NodeCondition
    {
        public override string Name => "RoleCondition";

        public override bool Check(Player player, Dictionary<string, string> args)
        {
            if (bool.Parse("inverted"))
            {
                return player.Role != (RoleType)int.Parse(args["role"]);
            }
            return player.Role == (RoleType)int.Parse(args["role"]);
        }
    }
}