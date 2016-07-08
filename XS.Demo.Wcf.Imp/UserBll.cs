using System.Collections.Generic;
using System.ServiceModel;
using XS.Demo.Wcf.Interface;
using XS.Demo.Wcf.Model;
using XS.WCF.WCFHelper;
using XS.WCF.WCFHelper.SDMessageHeader;

namespace XS.Demo.Wcf.Imp
{
    public class UserBll : CommonWcfBll, IUserBll
    {
        public IList<User> FindAll()
        {
            var headercontext = HeaderOperater.GetServiceWcfHeader(OperationContext.Current);

            var list = new List<User>();
            for (var i = 0; i < 30; i++)
            {
                var obj = new User();
                obj.UserID = i + 1;
                obj.UserName = "test" + (i + 1);

                list.Add(obj);
            }
            return list;
        }
    }
}