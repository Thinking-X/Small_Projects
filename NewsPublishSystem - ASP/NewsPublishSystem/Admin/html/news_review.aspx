<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news_review.aspx.cs" Inherits="NewsPublishSystem.Admin.html.news_review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<link rel="stylesheet" type="text/css" href="../css/reset.css" />
	<link rel="stylesheet" type="text/css" href="../css/main.css" /> 
    <link rel="stylesheet" type="text/css" href="../../bootstrap3.2.0/front/css/bootstrap.min.css" />
	<link rel="stylesheet" href="../css/jquery.pagination.css" />
	<script type="text/javascript" src="../js/jquery-1.12.4.min.js"></script>
	<script type="text/javascript" src="../js/jquery.pagination.min.js"></script>
    <title>今日报资讯后台管理</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="breadcrub">
			当前位置：新闻管理>新闻审核
			<div class="news_filter_form">
				<input name="keywords" type="text" placeholder="请输入关键字" class="input_txt" />
				<input type="submit" value="搜 索" class="input_sub" />
			</div>
		</div>
		<div class="pannel">
				<asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="common_table">
				<tr>
					<th width="3%">新闻ID</th>
					<th width="70%">标题</th>
					<th width="15%">发布时间</th>
					<th width="5%">状态</th>
					<th width="8%">管理操作</th>
				</tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
					<td><%# ((Hashtable)Container.DataItem)["NewsID"] %></td>
					<td class="tleft"><%# ((Hashtable)Container.DataItem)["Title"] %></td>
					<td><%# ((Hashtable)Container.DataItem)["PublishTime"] %></td>
					<td><%# ((Hashtable)Container.DataItem)["AuditState"] %></td>
					<td>
						<a href="news_review_detail.aspx?id=<%# ((Hashtable)Container.DataItem)["NewsID"] %>" class="review">审核</a>
					</td>
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
    </form>
</body>
</html>
