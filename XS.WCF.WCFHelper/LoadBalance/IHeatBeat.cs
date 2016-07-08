using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace XS.WCF.WCFHelper.LoadBalance
{
    /// <summary>
    /// 心跳
    /// </summary>
    [ServiceContract]
    public interface IHeatBeat
    {
        /// <summary>
        /// 心跳回调
        /// </summary>
        [OperationContract]
        void CallBack(bool flag);
    }
}
