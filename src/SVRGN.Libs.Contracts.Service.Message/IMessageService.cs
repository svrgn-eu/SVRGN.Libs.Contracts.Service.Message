using SVRGN.Libs.Contracts.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Message
{
    public interface IMessageService : IService
    {
        #region Properties

        IList<ITopic> Topics { get; }

        #endregion Properties

        #region Methods

        bool Register(IMessageReceiver Receiver, string TopicName);
        bool Deregister(IMessageReceiver Receiver, string TopicName);

        #region Send: Sends a message.
        /// <summary>
        /// Sends a message.
        /// </summary>
        /// <param name="Sender">The sending object</param>
        /// <param name="TopicName">Name of the topic the message will be queued on</param>
        /// <param name="Message">the message itself</param>
        /// <param name="DoCopySender">if 'true', the sender receives the message also, if 'false', not</param>
        /// <returns>true, if the message has been received by any receiver and has been 'understood' (ackowledgement)</returns>
        bool Send(IMessageSender Sender, string TopicName, IMessage Message, bool DoCopySender = true);
        #endregion Send

        #endregion Methods
    }
}
