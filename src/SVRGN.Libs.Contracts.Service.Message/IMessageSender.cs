using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Message
{
    public interface IMessageSender : IBaseObject, IId
    {
        #region Properties

        #endregion Properties

        #region Methods

        #region Send: Sends a message.
        /// <summary>
        /// Sends a message.
        /// </summary>
        /// <param name="TopicName">Name of the topic the message will be queued on</param>
        /// <param name="Message">the message itself</param>
        /// <param name="DoCopySender">if 'true', the sender receives the message also, if 'false', not</param>
        /// <returns>true, if the message has been received by any receiver and has been 'understood' (ackowledgement)</returns>
        bool Send(string TopicName, IMessage Message, bool DoCopySender = true);
        #endregion Send

        #endregion Methods
    }
}
