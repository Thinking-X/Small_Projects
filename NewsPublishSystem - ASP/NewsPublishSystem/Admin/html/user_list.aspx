 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_list.aspx.cs" Inherits="NewsPublishSystem.Admin.html.user_list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="../../bootstrap3.2.0/front/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="../css/reset.css" />
    <link rel="stylesheet" type="text/css" href="../css/main.css" />
    <link rel="stylesheet" href="../css/jquery.pagination.css" />
    <script type="text/javascript" src="../js/jquery-1.12.4.min.js"></script>
    <script type="text/javascript" src="../js/jquery.pagination.min.js"></script>
    <title>今日报资讯后台管理</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="breadcrub">
            当前位置：用户管理>用户列表
        </div>
        <div class="pannel">
            <asp:Repeater ID="Repeater1" runat="server" >
                <HeaderTemplate>
                    <table class="common_table">
                        <tr>
                    <th>用户ID</th>
                    <th>邮箱</th>
                    <th>性别</th>
                    <th>出生日期</th>
                    <%--<th>注册时间</th>
                    <th>上次登录时间</th>--%>
                </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# ((Hashtable)Container.DataItem)["UserID"] %></td>
                        <td><%# ((Hashtable)Container.DataItem)["Email"] %></td>
                        <td><%# ((Hashtable)Container.DataItem)["Gender"] %></td>
                        <td><%# ((Hashtable)Container.DataItem)["Birthdate"] %></td> 
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
        <div class="panel-footer">
            <div class="pager">
                <ul class="pagination pagination-lg">
                    <asp:Button ID="btn1" runat="server" Text="首页" CssClass="btn btn-warning" OnClick="btn1_Click" />
                    <asp:Button ID="btn2" runat="server" Text="&laquo;上一页" CssClass="btn btn-info" OnClick="btn2_Click" />
                    <asp:Button ID="btn3" runat="server" Text="下一页&raquo;" CssClass="btn btn-info" OnClick="btn3_Click" />
                    <asp:Button ID="btn4" runat="server" Text="尾页" CssClass="btn btn-warning" OnClick="btn4_Click" />
                </ul>
            </div>
        </div>
        <script>
            
        </script>
    </form>
</body>
</html>
