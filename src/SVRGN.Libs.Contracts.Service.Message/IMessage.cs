using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Message
{
    public interface IMessage
    {
        #region Properties

        string Subject { get; }
        object Payload { get; }
        IMessageSender Sender { get; }
        IList<IMessageReceiver> Recipients { get; }

        DateTime CreatedAt { get; }
        DateTime SentAt { get; }

        #endregion Properties

        #region Methods

        void AddReceiver(IMessageReceiver CurrentReceiver);
        void SetSentDate();

        #endregion Methods
    }
}
