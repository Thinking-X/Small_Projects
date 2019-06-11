using NewsPublishSystem.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsPublishSystem.Admin.html
{
    public partial class news_type : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StyleBLL nb = new StyleBLL();
            List<Hashtable> result = new List<Hashtable>();
            Hashtable h = new Hashtable();
            result = nb.SelectAllStyle();
            Repeater1.DataSource = result;
            Repeater1.DataBind();
        }
    }
}