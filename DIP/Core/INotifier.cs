using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP.Core
{
    public interface INotifier
    {
        void Notify(string message);
    }
}
