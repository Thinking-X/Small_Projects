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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            if(Request.QueryString["id"] != null)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                NewsBLL nb2 = new NewsBLL();
                Hashtable result = new Hashtable();
                Hashtable h = new Hashtable();
                h.Add("@NewsID", id);
                result = nb2.OneRecord(h);
                if (result != null)
                {
                    label1.Text = result["Title"].ToString();
                    label2.Text = result["NewsContent"].ToString();
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