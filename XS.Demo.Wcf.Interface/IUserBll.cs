using System.Collections.Generic;
using System.ServiceModel;
using XS.Demo.Wcf.Model;

namespace XS.Demo.Wcf.Interface
{
    [ServiceContract]
    public interface IUserBll
    {
        [OperationContract]
        IList<User> FindAll();
    }
}