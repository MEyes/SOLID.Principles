using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LSP.Core
{
    public interface ISettings
    {
        void GetSettings();
        void SetSettings();
    }
}