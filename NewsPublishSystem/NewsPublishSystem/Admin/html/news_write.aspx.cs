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
    public partial class news_write : System.Web.UI.Page
    {
        public int NewsID;
        public string nTitle;
        public string StyleName;
        public string NewsSource;
        public string Pic;
        public string NewsContent;
        protected void Page_Load(object sender, EventArgs e)
        {
            StyleBLL nb = new StyleBLL();
            List<Hashtable> result = new List<Hashtable>();
            result = nb.SelectAllStyle();
            Repeater1.DataSource = result;
            Repeater1.DataBind();

            if (Request.QueryString["id"] != null)
            {
                NewsID = Convert.ToInt32(Request.QueryString["id"]);
                NewsBLL nb2 = new NewsBLL();
                Hashtable Record = new Hashtable();
                Hashtable h = new Hashtable();
                h.Add("@NewsID", NewsID);
                Record = nb2.OneOtherRecord(h);

                nTitle = Record["Title"].ToString();
                StyleName = Record["StyleName"].ToString();
                NewsSource = Record["NewsSource"].ToString();
                Pic = Record["Pic"].ToString();
                NewsContent = Record["NewsContent"].ToString();
            }
            return;
        }
    }
}