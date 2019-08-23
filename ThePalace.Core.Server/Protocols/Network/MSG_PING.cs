﻿using System.ComponentModel;
using ThePalace.Core.Factories;
using ThePalace.Core.Interfaces;

namespace ThePalace.Server.Protocols
{
    [Description("ping")]
    public struct MSG_PING : IReceiveProtocol, ISendProtocol
    {
        public void Deserialize(Packet packet)
        {

        }

        public byte[] Serialize(object input = null)
        {
            return null;
        }

        public void DeserializeJSON(string json)
        {

        }

        public string SerializeJSON(object input = null)
        {
            return string.Empty;
        }
    }
}
