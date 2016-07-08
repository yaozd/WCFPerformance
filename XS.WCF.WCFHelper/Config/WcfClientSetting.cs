using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XS.WCF.WCFHelper.Config
{
    internal class WcfClientSetting : BaseSetting
    {
        #region 默认在config中配置
        private IList<SittConfigSection<string>> WcfClientPath
        {
            get
            {
                return
                    base.SittConfiglist.Where(e => e.Key == "WcfClient")
                                .ToList<SittConfigSection<string>>();
            }
        }


        private IList<SittConfigSection<string>> WcfClientConstantPath
        {
            get
            {
                return
                     base.SittConfiglist.Where(e => e.Key == "WcfClientConstantPath")
                                 .ToList<SittConfigSection<string>>();
            }

        }

        /// <summary>
        /// 客户端服务配置
        /// </summary>
        internal WcfClientSettingConfig WcfClient
        {
            get
            {
                return GetInstanceConfig.CreateConfigInstance<WcfClientSettingConfig, string>(this.WcfClientPath);
            }
        }

        /// <summary>
        /// 客户端常量
        /// </summary>
        internal WcfClientConstantSettingConfig WcfClientConstant
        {
            get
            {
                return GetInstanceConfig.CreateConfigInstance<WcfClientConstantSettingConfig, string>(this.WcfClientConstantPath);
            }
        }
        #endregion
    }
}
