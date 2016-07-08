using System;
using System.Web.UI;
using XS.Demo.Wcf.Interface;
using XS.WCF.WCFHelper;

namespace XS.Demo.Wcf.Web
{
    public partial class demo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var bll = WcfClient.GetProxy<IUserBll>();
                var list = bll.FindAll();
                GridView1.DataSource = list;
                GridView1.DataBind();
            }
        }
    }
}