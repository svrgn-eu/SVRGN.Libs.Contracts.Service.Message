using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Message
{
    public interface ITopic : IName
    {
        #region Properties

        int MessageCount { get; }

        IList<IMessageReceiver> Receivers { get; }

        #endregion Properties

        #region Methods

        void CountOneUp();
        void AddReceiver(IMessageReceiver Receiver);
        bool Publish(IMessage Message, bool DoCopySender = true);
        void RemoveReceiver(IMessageReceiver Receiver);

        #endregion Methods
    }
}
