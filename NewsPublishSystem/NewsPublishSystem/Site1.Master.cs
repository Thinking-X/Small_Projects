using NewsPublishSystem.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsPublishSystem
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NewsBLL nb = new NewsBLL();
            Repeater1.DataSource = nb.LatestRecord();
            Repeater1.DataBind();
            return;
        }
    }
}