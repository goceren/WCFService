using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.Models;

namespace WCFService
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Product GetOne();

        [OperationContract]
        List<Product> GetAll();
    }
}
