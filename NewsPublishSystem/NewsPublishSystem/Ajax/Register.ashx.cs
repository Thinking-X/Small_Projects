using NewsPublishSystem.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Script.Serialization;

namespace NewsPublishSystem
{
    /// <summary>
    /// Register 的摘要说明
    /// </summary>
    public class Register : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/javascript";
            //context.Response.Write("Hello World");
            //HttpContext.Current.Response.Write("Hello World");
            //Hashtable result = new Hashtable();

            //context.Response.ContentType = "application/json";
            //context.Response.Write(JsonConvert.SerializeObject(prod));

            string code = context.Request.QueryString["code"].ToString();

            Hashtable user = new Hashtable();
            UserBLL userBLL = new UserBLL();
            Hashtable Result = new Hashtable();
            JavaScriptSerializer jResult = new JavaScriptSerializer();
            context.Response.ContentType = "application/json";
            user.Add("@UserID", context.Request.Form["username"].ToString().Trim());
            if (userBLL.JudgeExist(user))
            {
                Result.Add("states", 2);
                Result.Add("info", "此用户ID已经存在！请更改ID号！");
                context.Response.Write(jResult.Serialize(Result));
                return;
            }
            user.Add("@Email", context.Request.Form["email"].ToString().Trim());
            user.Add("@Pwd", context.Request.Form["password"].ToString().Trim());
            user.Add("@Gender", context.Request.Form["gender"].ToString().Trim());
            user.Add("@Birthdate", context.Request.Form["birthday"].ToString().Trim());
            if (userBLL.InsertUser(user))
            {
                Result.Add("states", 1);
                Result.Add("info", "注册成功！");
            }
            else
            {
                Result.Add("states", 0);
                Result.Add("info", "注册失败！");
            }
            context.Response.Write(jResult.Serialize(Result));//序列化
        }

        /// <summary>
        /// 验证注册邮箱
        /// </summary>
        ///<param name = "strUserId" > 用户编号 </ param >
        /// <param name="strClientEmail">目的地</param>
        /// <param name="strUser">用户名称</param>
        //public void SendMail(string strUserId, string strUser, string strClientEmail)
        //{
        //    try
        //    {
        //        MailMessage ClientEmailMsg = new MailMessage();
        //        ClientEmailMsg.From = new MailAddress("[XXXXXX]<PsArvin@126.com>");
        //        ClientEmailMsg.To.Add(strClientEmail);
        //        ClientEmailMsg.Subject = "[XXXXXX]您的邮箱激活邮件";
        //        string activecode = Guid.NewGuid().ToString().Substring(0, 10);
        //        string strMsg = string.Format(
        //        "亲爱的{0}：<br/><br/>&nbsp;&nbsp;&nbsp;&nbsp;" +
        //        "您好！<br/>&nbsp;&nbsp;&nbsp;&nbsp;" +
        //        "您的邮箱激活邮件<br/>&nbsp;&nbsp;&nbsp;&nbsp;" +
        //        "请打击下面链接或者复制下面的激活链接到浏览器进行访问，以便激活你的邮箱。<br/>" +
        //        "&nbsp;&nbsp;&nbsp;&nbsp;邮箱激活链接:" +
        //        "<a href='http://localhost:4723/WebService1.asmx?activecode={1} &id={2}'>" +
        //        "http://localhost:4723/WebService1.asmx?activecode={3} &id={4}</a>" +
        //        "<br/><br/><br/><br/><br/>" +
        //        "[XXXXXX]<br/>{5}<br/><br/>此邮件为系统自动发出的邮件，请勿直接回复。",
        //        strUser, activecode, strUserId, activecode, strUserId,
        //        DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
        //        ClientEmailMsg.Body = strMsg;
        //        ClientEmailMsg.IsBodyHtml = true;
        //        SmtpClient client = new SmtpClient();
        //        //发件方服务器地址
        //        client.Host = "smtp.126.com";
        //        client.Port = 25;
        //        //mailMsg.IsBodyHtml = true;
        //        NetworkCredential credetial = new NetworkCredential();
        //        credetial.UserName = "PsArvin";
        //        credetial.Password = "Arvincdlg";
        //        client.Credentials = credetial;
        //        client.Send(ClientEmailMsg);
        //        //Response.Write("发送成功！");
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //    }
        //}

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}