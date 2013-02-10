using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace FirstAttempt
{
    /// Partial Class that implements the IGetData Interface
    /// call GetSomeData. This partialClass is GetData which
    /// is the same as the service class
    public partial class GetData: IGetData
    {

        public string GetSomeData(int value)
        {
            return "Service 1 Called";
        }
    }
}