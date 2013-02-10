using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace FirstAttempt
{
    /// <summary>
    /// Partial Class that implements the IDoWork Interface
    /// call Do More work. This partialClass is GetData which
    /// is the same as the service class
    /// </summary>
    public partial class GetData :IDoMoreWork
    {
        public string DoMoreWork()
        {
            return "Service 2 Called";
        }
    }
}