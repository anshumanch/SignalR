﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR
{
    public interface IMessageBus
    {
        Task<IEnumerable<Message>> GetMessagesSince(IEnumerable<string> eventKeys, ulong? id = null);
        Task Send(string eventKey, object value);
    }
}
