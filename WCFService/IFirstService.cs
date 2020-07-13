using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    [ServiceContract]
    public interface IFirstService
    {
        [OperationContract]
        string Welcome();

        [OperationContract]
        string Hi(string name);

        [OperationContract]
        int Sum(int a, int b);
    }
}
