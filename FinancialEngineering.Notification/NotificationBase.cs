using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialEngineering.Notification
{
    public abstract class NotificationBase
    {
        public List<string> Audiences { get; set; }
        public NotificationSource Source { get; set; }
        public abstract void Notify(string message);
        public virtual void RegisteAudience(string audience)
        {
            if (this.Audiences == null) this.Audiences = new List<string>();
            this.Audiences.Add(audience);
        }
    }
}
