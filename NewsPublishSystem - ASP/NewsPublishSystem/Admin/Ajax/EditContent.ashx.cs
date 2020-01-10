using NewsPublishSystem.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace NewsPublishSystem
{
    /// <summary>
    /// EditContent 的摘要说明
    /// </summary>
    public class EditContent : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string Request = context.Request.QueryString["Request"].Trim();
            if (Request == "1")
            {
                Hashtable News = new Hashtable();
                NewsBLL newsBLL = new NewsBLL();
                JavaScriptSerializer jResult = new JavaScriptSerializer();
                context.Response.ContentType = "application/json";
                Hashtable Result = new Hashtable();
                bool feedback;
                string NewsContent = context.Request.Form["NewsContent"];
                var sensitiveWords = new List<string> { "法轮大法好", "民运", "学潮" };
                bool flag = false;
                foreach (var word in sensitiveWords)
                {
                    if (NewsContent.Contains(word))
                    {
                        News.Add("@AuditState", "不通过");
                        flag = false;
                        break;
                    }
                }
                if(!flag)
                {
                    News.Add("@AuditState", "通过");
                }
                News.Add("@NewsContent", NewsContent);
                News.Add("@Title", context.Request.Form["Title"]);
                switch (context.Request.Form["StyleID"].Trim())
                {
                    case "国际": News.Add("@StyleID", 1); break;
                    case "国内": News.Add("@StyleID", 2); break;
                    case "军事": News.Add("@StyleID", 3); break;
                    case "体育": News.Add("@StyleID", 4); break;
                    case "娱乐": News.Add("@StyleID", 5); break;
                    case "财经": News.Add("@StyleID", 6); break;
                    case "科技": News.Add("@StyleID", 7); break;
                    case "时尚": News.Add("@StyleID", 8); break;
                    default: News.Add("@StyleID", 1); break;
                }
                if (context.Request.Form["NewsSource"].Trim() == "原创(若非原创，请更改)")
                {
                    News.Add("@NewsSource", "原创");
                }
                else
                {
                    News.Add("@NewsSource", context.Request.Form["NewsSource"]);
                }
                News.Add("@Pic", context.Request.Form["Pic"]);
                News.Add("@ManagerID", "1");
                //context.Application["mystr"]
                //context.Session["mystr"]
                if ("update" == context.Request.Form["OperationType"].Trim())
                {
                    News.Add("@NewsID", context.Request.Form["NewsID"]);
                    feedback = newsBLL.UpdateRecord(News);
                }
                else
                {
                    feedback = newsBLL.InsetRecord(News);
                }
                if (!feedback)
                {
                    Result.Add("states", 0);
                    Result.Add("info", "提交失败，请等待审核！");
                }
                else
                {
                    Result.Add("states", 1);
                    Result.Add("info", "提交成功！");
                }
                context.Response.Write(jResult.Serialize(Result));
                context.Response.End();
                return;
            }
            else if (Request == "2")
            {
                Hashtable News = new Hashtable();
                NewsBLL newsBLL = new NewsBLL();
                Hashtable Result = new Hashtable();
                JavaScriptSerializer jResult = new JavaScriptSerializer();
                context.Response.ContentType = "application/json";
                News.Add("@NewsID", context.Request.Form["id"].Trim());
                if(newsBLL.DeleteRecord(News))
                {
                    Result.Add("states", 1);
                    Result.Add("info", "删除成功！");
                }
                else
                {
                    Result.Add("states", 0);
                    Result.Add("info", "删除失败！");
                }
                context.Response.Write(jResult.Serialize(Result));
                context.Response.End();
                return;
            }
            else if (Request == "3")
            {
                Hashtable Manager = new Hashtable();
                ManagerBLL managerBLL = new ManagerBLL();
                Hashtable Result = new Hashtable();
                JavaScriptSerializer jResult = new JavaScriptSerializer();
                context.Response.ContentType = "application/json";
                Manager.Add("@Phone", context.Request.Form["username"].Trim());
                Manager.Add("@Pwd", context.Request.Form["password"].Trim()); 
                if (managerBLL.CountManager(Manager) == 1)
                {
                    Result.Add("states", 1);
                    Result.Add("info", "登陆成功！");
                }
                else
                {
                    Result.Add("states", 0);
                    Result.Add("info", "登陆失败！");
                }
                context.Response.Write(jResult.Serialize(Result));
                context.Response.End();
                return;
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}