using NewsPublishSystem.BLL;
using NewsPublishSystem.PublicClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace NewsPublishSystem
{
    public partial class _default : System.Web.UI.Page
    {
        private int pageSize = 5;//每页显示几条记录
        private int totalPage;//总共多少页

        private static int i = 1;//表示第几页
        private int count;//表示所查询的表一共几行

        public void GetPartRecord()//显示部分记录
        {
            NewsBLL nb = new NewsBLL();
            List<Hashtable> result = new List<Hashtable>();
            Hashtable h = new Hashtable();
            h.Add("@start", pageSize * (i - 1) + 1);
            h.Add("@end", pageSize * i);
            result = nb.PartRecord(h);
            Repeater1.DataSource = result;
            Repeater1.DataBind();
            return;
        }

        protected void Page_Load(object sender, EventArgs e)//每加载一次页面，重新执行一次，例如点击一次翻页
        {
            //IsPostBack:获取一个值，该值指示页上呈现第一次还是正在加载中为回发的响应。
            //返回结果: 响应客户端回发true， 加载页面后false。
            //if(!IsPostBack)
            {
                NewsBLL nb = new NewsBLL();
                count = (int)nb.CountNews();

                if (count % pageSize == 0)
                {
                    totalPage = count / pageSize;
                }
                else
                {
                    totalPage = count / pageSize + 1;
                }
                GetPartRecord();
            }

            NewsBLL nb2 = new NewsBLL();
            Repeater2.DataSource = nb2.LatestRecord();
            Repeater2.DataBind();

            if(Application["ourstr"].ToString() != "")
            {
                //HtmlInputRadioButton RadioAccept = (HtmlInputRadioButton)Page.FindControl("radioAccept");
                
            }
            return;
        }
        
        protected void btn1_Click(object sender, EventArgs e)//首页
        {
            btn2.Enabled = false;
            btn3.Enabled = true;
            i = 1;
            GetPartRecord();
            return;
        }

        protected void btn2_Click(object sender, EventArgs e)//上一页
        {
            btn3.Enabled = true;
            i--;
            if (i == 0)
            {
                i++;
                //Response.Write("<script>alert('已经到达第一页')</script>");
                Page.ClientScript.RegisterStartupScript(GetType(), "message","<script>alert('已经到达第一页')</script>");
                btn2.Enabled = false;
                return;
            }
            GetPartRecord();
            return;
        }

        protected void btn3_Click(object sender, EventArgs e)//下一页
        {
            btn2.Enabled = true;
            i++;
            if((i - 1) == totalPage)
            {
                i--;
                //Response.Write("<script>alert('已经到达最后一页')</script>");
                Page.ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('已经到达最后一页')</script>");
                btn3.Enabled = false;
                return;
            }
            GetPartRecord();
            return;
        }

        protected void btn4_Click(object sender, EventArgs e)//尾页
        {
            btn2.Enabled = true;
            btn3.Enabled = false;
            i = totalPage;
            GetPartRecord();
            return;
        }
    }
}