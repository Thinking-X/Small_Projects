<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="news_review_detail.aspx.cs" Inherits="NewsPublishSystem.Admin.html.news_review_detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="../css/reset.css" />
    <link rel="stylesheet" type="text/css" href="../css/main.css" />
    <script type="text/javascript" src="../js/jquery-1.12.4.min.js"></script>
    <script src="../tinymce/js/tinymce/tinymce.min.js"></script>
    <script src="../js/news_review_detail.js"></script>
    <title>今日报资讯后台管理</title>
</head>
<body>
    <div class="breadcrub">
        当前位置：新闻管理>新闻审核
    </div>
    <div class="pannel">
        <form class="news_review" id="form1" runat="server">
            <h3 class="review_title">内容审核</h3>
            <div class="form_group">
                <label>新闻标题：</label>
                <input type="text" class="input_txt2" value="<%=nTitle%>" readonly />
            </div>
            <div class="form_group">
                <label>新闻分类：</label>
                <div class="category_name"><%=StyleName%></div>
            </div>
            <div class="form_group">
                <label>新闻来源：</label>
                <%--<textarea class="input_multxt" readonly></textarea>--%>
                <input type="text" class="input_txt2" name="NewsSource" id="nSource" value="<%=NewsSource%>" readonly />
            </div>
            <div class="form_group">
                <label>索引图片：</label>
                <img src="<%=Pic%>" alt="索引图片" class="index_pic" />
            </div>
            <div class="form_group">
                <label>新闻内容：</label>
                <div class="rich_wrap fl">
                    <textarea class="input_area" id="rich_content" name="NewsContent" >
                        <%= NewsContent %>
                    </textarea>
                </div>
            </div>
            <div class="form_group indent_group">
                <input type="radio" name="action" id="radioAccept" checked="" Runat="server" value="accept" />
                通过&nbsp;&nbsp;&nbsp;&nbsp;
               
                <input type="radio" name="action" id="radioReject" Runat="server" value="reject" />
                拒绝通过
            </div>
            <div class="form_group group_hide">
                <label>拒绝原因：</label>
                <textarea class="input_multxt" name="reason"><%= RejectReason %></textarea>
            </div>
            <div class="form_group indent_group line_top">
                <%--<input type="submit" value="确定" class="confirm" id="confirmBtn" onserverclick="btn1_Click"/>--%>
                <button type="submit" value="确定" class="confirm" id="confirmBtn" runat="server" onserverclick="btn1_Click">确定</button>
                <asp:Button ID="btn1" runat="server" Visible="false" OnClick="btn1_Click" />
                <input type="button" value="取消" class="cancel" onclick="cancel()" />
            </div>
            <!-- 隐藏字段，用于记录当前新闻id -->
            <input name="news_id" value="1" hidden />
        </form>
    </div>

    <script>
        $(function () {
            if ($("#radioAccept").prop("checked")) {
                $('.group_hide').hide();
            }
            else {
                $('.group_hide').show();
            } 
        })

        $(function () {
            var $radio = $('input[name="action"]');
            $radio.click(function () {
                if ($(this).index() == 1) {
                    $('.group_hide').show();
                }
                else {
                    $('.group_hide').hide();
                }
            });

            tinymce.init({
                //选择class为content的标签作为编辑器
                selector: '#rich_content',
                //方向从左到右
                directionality: 'ltr',
                //语言选择中文
                language: 'zh_CN',
                //高度为400
                height: 400,
                width: '100%',
                //按tab不换行
                nonbreaking_force_tab: true,
                readonly: 1
            });
        })
        </script>
</body>
</html>
