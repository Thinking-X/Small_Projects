<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news_edit.aspx.cs" Inherits="NewsPublishSystem.Admin.html.news_edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="../css/reset.css" />
    <link rel="stylesheet" type="text/css" href="../css/main.css" />
    <link rel="stylesheet" type="text/css" href="../../bootstrap3.2.0/front/css/bootstrap.min.css" />
    <title>今日报资讯后台管理</title>
    <script src="../../bootstrap3.2.0/front/js/jquery-3.3.1.min.js"></script>
    <script src="../../js/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="breadcrub">
            当前位置：新闻管理>新闻版式编辑
            <div class="news_filter_form">
                <input name="keywords" type="text" placeholder="请输入关键字" class="input_txt" />
                <input type="submit" value="搜 索" class="input_sub" />
            </div>
        </div>
        <div class="pannel">
            <asp:Repeater ID="Repeater1" runat="server" >
                <HeaderTemplate>
                    <table class="common_table">
                        <tr>
                            <th width="5%">新闻ID</th>
                            <th width="65%">标题</th>
                            <th width="10%">发布时间</th>
                            <th width="10%">管理操作</th>
                            <th width="10%">删除操作</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tbody>
                        <tr>
                        <td><%# ((Hashtable)Container.DataItem)["NewsID"] %></td>
                        <td class="tleft"><%# ((Hashtable)Container.DataItem)["Title"] %></td>
                        <td><%# ((Hashtable)Container.DataItem)["PublishTime"] %></td>
                        <td>
                            <a href="news_write.aspx?id=<%# ((Hashtable)Container.DataItem)["NewsID"] %>" class="editContent">编辑</a>
                        </td>
                            <td>
                                <button class="btn btn-warning" data-toggle="modal" data-target="#editModal" type="button"
                                    data-nid="<%#((Hashtable)Container.DataItem)["NewsID"]%>"
                                    data-tit="<%#((Hashtable)Container.DataItem)["Title"] %>">
                                    删除
                                </button>
                                <div class="modal fade" id="editModal" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">
                                    <div class="modal-dialog">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <button type="button" class="close" data-dismiss="modal">
                                                    <span aria-hidden="true">&times;</span>
                                                    <span class="sr-only">Close</span>
                                                </button>
                                                <h4 style="align-content: center;" class="modal-title aa">新闻删除</h4>
                                            </div>
                                            <div class="modal-body">
                                                <div class="form-group">
                                                    <label for="NewsID" class="col-sm-3 control-label">新闻ID:</label>
                                                    <div class="col-sm-9">
                                                        <input type="text" class="form-control" name="leibie" id="NewsID" />
                                                    </div>
                                                </div>
                                                <br />
                                                <div class="form-group">
                                                    <label for="Title" class="col-sm-3 control-label">新闻标题:</label>
                                                    <div class="col-sm-9">
                                                        <input type="text" class="form-control" id="Title" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="modal-footer">
                                                <button type="button" class="btn btn-default" data-dismiss="modal">关闭</button>
                                                <button type="submit" class="btn btn-primary" id="delete">确认删除</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </tbody>
                </ItemTemplate>
                <FooterTemplate>
                    <tr>
                        <td colspan="5"><a href="news_write.html" class="addtype">发布新闻</a></td>
                    </tr>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
        
        <%--data 属性 data-toggle 用于打开模态窗口。--%>
        <%--<div class="modal fade" id="mymodal-data" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true"></div>--%>
        <%--aria-labelledby="mySmallModalLabel"，该属性引用模态框的标题。--%>
        <%--aria-hidden="true" 用于保持模态窗口不可见，直到触发器被触发为止（比如点击在相关的按钮上）。--%>
        <%--role="dialog"用于指定模态框为对话框。--%>
        <%-- class="modal fade"模态框弹出时的动画效果（淡入淡出效果）--%>
        <%--tabindex可以更改网页中Tab键选择按钮的顺序，如果值为负数则不会被Tab选中--%>

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

        <script type="text/javascript">
            $(function () {
                $("#editModal").on("show.bs.modal", function (e) {
                    var btn = $(e.relatedTarget);//MouseClick 
                    $("#NewsID").val(btn.data("nid"));
                    $("#Title").val(btn.data("tit"));
                    $("#delete").click(function () {
                    $.post("../Ajax/EditContent.ashx?Request=2", 
                        {
                            id: btn.data("nid")
                        },
                        function (d, s) {
                            if (s == "success") {
                                if (d.states == 1) {
                                    alert(d.info);
                                }
                                else {
                                    alert(d.info);
                                }
                                window.location.reload();//页面刷新
                            }
                        }
                    );
                    });
                });
            });
        </script>
    </form>
</body>
</html>
