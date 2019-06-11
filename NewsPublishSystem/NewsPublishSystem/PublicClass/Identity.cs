using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Reflection;
using System.Web.Configuration;

namespace NewsPublishSystem.PublicClass
{
    public class Identity
    {
        public static void ChangeConfiguration()
        {
            //动态修改web.config
            //（1）//Configuration config = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~");
            //config.AppSettings.Settings.Remove("connString1");
            //config.AppSettings.Settings.Add("connString1", "true");
            //config.Save();
            //string item = ConfigurationManager.AppSettings["connString1"];
            //Response.Write(item);

            //（2）
            string path = HttpContext.Current.Request.ApplicationPath;
            Configuration config = WebConfigurationManager.OpenWebConfiguration(path);
            AppSettingsSection appSetting = (AppSettingsSection)config.GetSection("appSettings");
            if (appSetting.Settings["connString11"] == null)//如果不存在此节点,则添加   
            {
                appSetting.Settings.Add("connString11", "strvalueNo");
            }
            else//如果存在此节点,则修改   
            {
                appSetting.Settings["connString1"].Value = "strvalue";
            }
            config.Save();
            config = null;
            return;
        }
        
    }
}