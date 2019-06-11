<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news_type.aspx.cs" Inherits="NewsPublishSystem.Admin.html.news_type" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<link rel="stylesheet" type="text/css" href="../css/reset.css" />
	<link rel="stylesheet" type="text/css" href="../css/main.css" />
	<script type="text/javascript" src="../js/jquery-1.12.4.min.js"></script>
	<script type="text/javascript" src="../js/news_type.js"></script>
    <title>今日报资讯后台管理</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="breadcrub">
        当前位置：新闻管理>新闻分类管理
    </div>
    <div class="pannel">
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table class="common_table">
                    <tr>
                        <th width="10%">id</th>
                        <th width="80%">类别名称</th>
                        <th width="10%">管理操作</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# ((Hashtable)Container.DataItem)["StyleID"] %></td>
                    <td><%# ((Hashtable)Container.DataItem)["StyleName"] %></td>
                    <td><a href="javascript:;" class="edit">编辑</a></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                <tr>
                    <td colspan="3"><a href="javascript:;" class="addtype">增加分类</a></td>
                </tr>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>

    <div class="pop_con">
        <div class="pop">
            <div>
                <h3>修改分类</h3>
                <div class="form_group mt50">
                    <label class="input_label">分类名称：</label><input type="text" class="input_txt3" />
                    <span class="error_tip">提示文字</span>
                </div>
                <div class="form_group line_top">
                    <input type="button" value="确定" class="confirm" />&nbsp;&nbsp;&nbsp;&nbsp;
                    <input type="button" value="取消" class="cancel" />
                </div>
            </div>
        </div>
        <div class="mask"></div>
    </div>
    </form>
</body>
</html>
