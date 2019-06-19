using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTiko
{

    [ServiceContract]
  public interface IContract
    {
       [OperationContract]
        string gettikotime(string text);
    }
}
