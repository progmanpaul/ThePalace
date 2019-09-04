﻿using System.ComponentModel;
using ThePalace.Core.Database;
using ThePalace.Core.Interfaces;
using ThePalace.Core.Server.Attributes;
using ThePalace.Core.Utility;
using ThePalace.Server.Models;
using ThePalace.Server.Network;

namespace ThePalace.Server.Business
{
    [Description("qAst")]
    [SuccessfullyConnectedProtocol]
    public struct MSG_ASSETQUERY : IReceiveBusiness
    {
        public void Receive(ThePalaceEntities dbContext, object message)
        {
            var sessionState = ((Message)message).sessionState;
            var protocol = ((Message)message).protocol;

            var inboundPacket = (Protocols.MSG_ASSETQUERY)protocol;

            if (inboundPacket.assetSpec.id != 0)
            {
                Logger.Log(MessageTypes.Info, $"MSG_ASSETQUERY[{sessionState.UserID}]: {inboundPacket.assetSpec.id}, {inboundPacket.assetSpec.crc}");

                AssetLoader.OutboundQueueTransfer(sessionState, inboundPacket.assetSpec);
            }
        }
    }
}
