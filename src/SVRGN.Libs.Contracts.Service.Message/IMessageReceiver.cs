using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Message
{
    public interface IMessageReceiver : IBaseObject, IId
    {
        #region Methods

        bool Receive(IMessage Message);
        void SetMessageService(IMessageService MessageService);

        #endregion Methods
    }
}
