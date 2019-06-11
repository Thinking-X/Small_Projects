using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace NewsPublishSystem
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        //在HttpApplication 类的第一个实例被创建时，该事件被触发。它允许创建可以由所有HttpApplication 实例访问的对象。
        {
            Application["ourstr"] = string.Empty;
        }

        protected void Application_End(object sender, EventArgs e)
        // 应用程序的最后一个事件，在HttpApplication 类的最后一个实例被销毁时，该事件被触发。在一个应用程序的生命周期内它只被触发一次。
        {

        }
        protected void Session_Start(object sender, EventArgs e)
        //Session_Start：在一个新用户访问应用程序 Web 站点时，该事件被触发。
        {
            Session["mystr"] = string.Empty;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        //当接收到程序的时侯自动触发，可用来做站点计数器。
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        //在安全模块建立用户的有效身份，该事件被触发，用户将被验证。
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        //当应用程序中遇到一个未处理的异常时，该事件被触发
        {

        }

        protected void Session_End(object sender, EventArgs e)
        //在一个用户的会话超时、结束或他们离开应用程序 Web 站点时，该事件被触发
        {

        }
        
        /*
        3>Application_authorizeRequest
          安全模块确认用户是不是有权限访问资源
        · Application_AuthorizeRequest：当安全模块确认一个用户可以访问资源之后，该事件被触发。

        5>Application_OnStart
          Application_OnStart 事件在首次创建新的会话（即 Session_OnStart 事件）之前发生。只有Application 和 Server 内建对象是可用的。在 Application_OnStart 事件脚本中引用Session、Request 或 Response 对象将导致错误。
        6>Application_OnEnd
          Application_OnEnd 事件在应用程序退出时于 Session_OnEnd 事件之后发生，只有 Application和Server 内建对象可用。

        Global.asax 文件继承自HttpApplication 类，它维护一个HttpApplication 对象池，并在需要时将对象池中的对象分配给应用程序。
        Global.asax 文件包含以下事件：
        · Application_Init：在应用程序被实例化或第一次被调用时，该事件被触发。对于所有的HttpApplication 对象实例，它都会被调用。
        · Application_Disposed：在应用程序被销毁之前触发。这是清除以前所用资源的理想位置。
        · Application_BeginRequest：在接收到一个应用程序请求时触发。对于一个请求来说，它是第一个被触发的事件，请求一般是用户输入的一个页面请求（URL）。
        · Application_EndRequest：针对应用程序请求的最后一个事件。
        · Application_PreRequestHandlerExecute：在 ASP.NET 页面框架开始执行诸如页面或 Web 服务之类的事件处理程序之前，该事件被触发。
        · Application_PostRequestHandlerExecute：在 ASP.NET 页面框架结束执行一个事件处理程序时，该事件被触发。
        · Applcation_PreSendRequestHeaders：在 ASP.NET 页面框架发送 HTTP 头给请求客户（浏览器）时，该事件被触发。
        · Application_PreSendContent：在 ASP.NET 页面框架发送内容给请求客户（浏览器）时，该事件被触发。
        · Application_AcquireRequestState：在 ASP.NET 页面框架得到与当前请求相关的当前状态（Session 状态）时，该事件被触发。
        · Application_ReleaseRequestState：在 ASP.NET 页面框架执行完所有的事件处理程序时，该事件被触发。这将导致所有的状态模块保存它们当前的状态数据。
        · Application_ResolveRequestCache：在 ASP.NET 页面框架完成一个授权请求时，该事件被触发。它允许缓存模块从缓存中为请求提供服务，从而绕过事件处理程序的执行。
        · Application_UpdateRequestCache：在 ASP.NET 页面框架完成事件处理程序的执行时，该事件被触发，从而使缓存模块存储响应数据，以供响应后续的请求时使用。
         */
    }
}