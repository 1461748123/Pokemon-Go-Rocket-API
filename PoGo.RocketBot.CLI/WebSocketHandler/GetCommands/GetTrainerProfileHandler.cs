﻿using PoGo.RocketBot.CLI.WebSocketHandler.GetCommands.Tasks;
using PoGo.RocketBot.Logic.State;
using SuperSocket.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoGo.RocketBot.CLI.WebSocketHandler.GetCommands
{
    class GetTrainerProfileHandler : IWebSocketRequestHandler
    {

        public string Command { get; private set; }

        public GetTrainerProfileHandler()
        {
            Command = "GetTrainerProfile";
        }

        public async Task Handle(ISession session, WebSocketSession webSocketSession, dynamic message)
        {
            await GetTrainerProfileTask.Execute(session, webSocketSession, (string)message.RequestID);
        }
    }
}
