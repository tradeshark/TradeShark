using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialEngineering.Notification
{
    public class QQNotification : NotificationBase
    {
        public QQNotification(NotificationSource source)
        {
            this.Source = source;
        }
        public override void Notify(string message)
        {
            throw new NotImplementedException();
        }
        private void SendMessage()
        {

        }
    }
}
