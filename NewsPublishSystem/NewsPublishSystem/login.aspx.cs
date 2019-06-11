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
    public partial class login : System.Web.UI.Page
    {
        public string LoginUserName { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["mystr"] = "bbb";
            //Application["ourstr"] = "aaa";
            //Response.Write(Application["ourstr"]);
            //Response.Write(Session["mystr"]);
        }

        protected void btn1_Click(object sender, EventArgs e)//登录
        {
            //Response.Write("<script>alert('SSSSSSSSS')</script>");
            if (IsPostBack)   //如果是Post请求(点击提交)
            {
                string userName = Request.Form["txtName"];
                string userPwd = Request.Form["txtPwd"];
                Hashtable hashtable = new Hashtable();
                hashtable.Add("@UserID", userName);
                hashtable.Add("@Pwd", userPwd);
                UserBLL userBLL = new UserBLL();
                if(userBLL.ValidateLogon(hashtable))
                {
                    Application["ourstr"] = userName;
                    Page.ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('登录成功')</script>");
                    Server.Transfer("default.aspx", true);
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "message", "<script>alert('未找到此用户，请检查用户ID与密码！')</script>");
                }
            }
            else   //否则是Get请求，回显用户名
            {
                //读Cookie。
                if (Request.Cookies["userName"] != null)
                {

                }
            }
        }
        protected void setCookie(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('SSSSSSSSS')</script>");
            //if (IsPostBack)   //如果是Post请求(点击提交)
            //{
            //    string userName = Request.Form["txtName"];
            //    string userPwd = Request.Form["txtPwd"];
            //    //写到Cookie中.
            //    Response.Cookies[userName].Value = Server.UrlEncode(userPwd);
            //    Response.Cookies[userName].Expires = DateTime.Now.AddDays(7);
            //}
            //else   //否则是Get请求，回显用户名
            //{
            //    //读Cookie。
            //    if (Request.Cookies["userName"] != null)
            //    {
            //        string name = Server.UrlDecode(Request.Cookies["userName"].Value);  //读Cookie
            //        LoginUserName = name;
            //        Response.Cookies["userName"].Value = Server.UrlEncode(name); //更新Cookie的过期时间
            //        Response.Cookies["userName"].Expires = DateTime.Now.AddDays(7);
            //    }
            //}
        }
    }
}