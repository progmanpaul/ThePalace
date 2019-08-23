﻿using Newtonsoft.Json;
using System.ComponentModel;
using ThePalace.Core.Factories;
using ThePalace.Core.Interfaces;

namespace ThePalace.Server.Protocols
{
    [Description("HTTP")]
    public struct MSG_HTTPSERVER : ISendProtocol
    {
        public string url;

        public byte[] Serialize(object input = null)
        {
            using (var packet = new Packet())
            {
                packet.WriteCString(url);

                return packet.getData();
            }
        }

        public string SerializeJSON(object input = null)
        {
            return JsonConvert.SerializeObject(new
            {
                url = url,
            });
        }
    }
}
