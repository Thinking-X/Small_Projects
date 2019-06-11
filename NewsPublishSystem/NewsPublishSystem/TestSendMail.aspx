<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestSendMail.aspx.cs" Inherits="NewsPublishSystem.TestSendMail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>    
        发送人：<asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
        <br/>
        收件人：<asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
        <br/>
        主题：<asp:TextBox ID="txtTheme" runat="server"></asp:TextBox>
        <br/>
        附件：<asp:FileUpload ID="fpAttachment" runat="server"/>
            
        <br/>
        内容：<asp:TextBox ID="txtContent" runat="server" Rows="20" TextMode="MultiLine" 
            Width="300px"></asp:TextBox>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="发送" onclick="Button1_Click"/>
    </div>
    
    </form>
</body>
</html>
