using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsPublishSystem
{
    public partial class TestSendMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //测试通过，能发送带有附件的邮件
            string from = txtFrom.Text.Trim(); //发件人
            string to = txtTo.Text.Trim();//收件人
            string theme = txtTheme.Text.Trim();//主题
            //string file = fpAttachment.FileName;//附件文件名
            string file = fpAttachment.PostedFile.FileName;//附件文件路径（包含文件名）
            string content = txtContent.Text; //邮件内容
            MailMessage messge = new MailMessage(from, to);  //邮件消息实例
            messge.Body = content;
            messge.Subject = theme;
            messge.IsBodyHtml = true;
            messge.Priority = MailPriority.High;//邮件优先级别
            messge.Attachments.Add(new Attachment(file));
            SmtpClient client = new SmtpClient(); //Smtp协议
            client.Host = "smtp.qq.com"; //pop.qq.com
            //发送人的Smtp主机名称或IP地址，"smtp.163.com" 为163邮箱的Smtp地址
            client.Credentials = new NetworkCredential("1969591432@qq.com", "wrweqzwefuwtbiab");//验证发件人的身份凭据
            //只需要发件人身份凭据，收件人不用
            //"1969591432@qq.com", "Jiayou2014","wrweqzwefuwtbiab"

            client.Send(messge);
            messge.Attachments.Dispose();
        }

    }
}