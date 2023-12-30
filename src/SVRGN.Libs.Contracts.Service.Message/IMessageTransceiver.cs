using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Message
{
    public interface IMessageTransceiver : IMessageReceiver, IMessageSender
    {
    }
}
