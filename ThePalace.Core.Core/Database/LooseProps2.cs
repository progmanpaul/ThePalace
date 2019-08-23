﻿using System;
using System.Collections.Generic;

namespace ThePalace.Core.Database
{
    public partial class LooseProps2
    {
        public int UserId { get; set; }
        public short RoomId { get; set; }
        public int OrderId { get; set; }
        public int AssetId { get; set; }
        public int AssetCrc { get; set; }
        public int Flags { get; set; }
        public int? RefCon { get; set; }
        public short LocH { get; set; }
        public short LocV { get; set; }
    }
}
