﻿using TeeSharp.Common.Snapshots;
using TeeSharp.Core;

namespace TeeSharp.Server
{
    public enum ServerClientState
    {
        EMPTY = 0,
        AUTH,
        CONNECTING,
        READY,
        IN_GAME,
    }

    public abstract class BaseServerClient : BaseInterface
    {
        public class Input
        {
            public readonly int[] Data;
            public readonly long Tick;

            public Input(int[] data, long tick)
            {
                Data = data;
                Tick = tick;
            }
        }

        public abstract ServerClientState State { get; set; }
        public abstract string PlayerName { get; set; }
        public abstract string PlayerClan { get; set; }
        public abstract int PlayerCountry { get; set; }
        public abstract long TrafficSince { get; set; }
        public abstract long Traffic { get; set; }

        public abstract SnapshotStorage SnapshotStorage { get; protected set; }
        public abstract Input[] Inputs { get; protected set; }
        public abstract void Reset();
    }
}