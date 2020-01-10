using NewsPublishSystem.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace NewsPublishSystem.Admin.html
{
    public partial class news_review_detail : System.Web.UI.Page
    {
        public int NewsID;
        public string nTitle;
        public string StyleName;
        public string NewsSource;
        public string Pic;
        public string NewsContent;
        public string AuditState;
        public string RejectReason;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                NewsID = Convert.ToInt32(Request.QueryString["id"]);
                NewsBLL nb2 = new NewsBLL();
                Hashtable Record = new Hashtable();
                Hashtable h = new Hashtable();
                h.Add("@NewsID", NewsID);
                Record = nb2.OneOtherRecordALL(h);

                nTitle = Record["Title"].ToString();
                StyleName = Record["StyleName"].ToString();
                NewsSource = Record["NewsSource"].ToString();
                Pic = Record["Pic"].ToString();
                NewsContent = Record["NewsContent"].ToString();
                AuditState = Record["AuditState"].ToString();
                
                if (!IsPostBack)
                {
                    RejectReason = Record["RejectReason"].ToString();

                    HtmlInputRadioButton RadioAccept = (HtmlInputRadioButton)Page.FindControl("radioAccept");
                    HtmlInputRadioButton radioReject = (HtmlInputRadioButton)Page.FindControl("radioReject");
                    if(AuditState == "通过")
                    {
                        RadioAccept.Checked = true;
                        radioReject.Checked = false;
                    }
                    else
                    {
                        RadioAccept.Checked = false;
                        radioReject.Checked = true;
                    }
                }
            }
            return;
        }
        protected void btn1_Click(object sender, EventArgs e)//提交审核结果
        {
            NewsBLL newsBLL = new NewsBLL(); 
            Hashtable hashtable = new Hashtable(); 
            HtmlInputRadioButton RadioAccept = (HtmlInputRadioButton)Page.FindControl("radioAccept");
            HtmlInputRadioButton radioReject = (HtmlInputRadioButton)Page.FindControl("radioReject");
            if (RadioAccept.Checked)
            {
                hashtable.Add("@AuditState", "通过");
                hashtable.Add("@RejectReason", "");
            } 
            else
            {
                hashtable.Add("@AuditState", "不通过");
                hashtable.Add("@RejectReason", Request.Form["reason"].Trim());
            }
            hashtable.Add("@NewsID", NewsID);
            if(newsBLL.UpdateVerify(hashtable))
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('提交成功')</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('提交失败')</script>");
            }
            hashtable.Clear();
            hashtable.Add("@NewsID", NewsID);
            RejectReason = newsBLL.OneOtherRecordALL(hashtable)["RejectReason"].ToString();
            return;
        }
    }
}