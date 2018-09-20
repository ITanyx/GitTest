using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        protected string WcfTitle { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //SalesVolumeOperation.SalesVolumeOperationClient sa = new SalesVolumeOperation.SalesVolumeOperationClient();
                CalculateWcfService.CalculateService sa = new CalculateWcfService.CalculateService();
                double dResult;
                bool bResult;
                sa.AddOperation(20.35, true, 30.25, true, out dResult, out bResult);
                this.WcfTitle = dResult.ToString();
            }
        }
    }
}