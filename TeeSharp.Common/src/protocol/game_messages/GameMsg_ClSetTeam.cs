﻿using TeeSharp.Common.Enums;

namespace TeeSharp.Common.Protocol
{
    public class GameMsg_ClSetTeam : BaseGameMessage
    {
        public override GameMessages MsgId { get; } = GameMessages.CL_SETTEAM;

        public Team Team { get; set; }

        public override bool Pack(MsgPacker packer)
        {
            packer.AddInt((int) Team);
            return packer.Error;
        }
    }
}