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
    public partial class SearchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Keyword = Request.QueryString["Keyword"];
            if (Keyword != null)
            {
                NewsBLL nb2 = new NewsBLL();
                List<Hashtable> result = new List<Hashtable>();
                Hashtable h = new Hashtable();
                h.Add("@Keyword", Keyword);
                result = nb2.SelectRecord(h);
                if (result != null)
                {
                    Repeater1.DataSource = result;
                    Repeater1.DataBind();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('该文章管理员已经删除！')</script>");
                }
            }
            return;
        }
    }
}