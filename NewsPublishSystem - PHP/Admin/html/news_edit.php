<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="../css/reset.css" />
    <link rel="stylesheet" type="text/css" href="../css/main.css" />
    <link rel="stylesheet" type="text/css" href="../../bootstrap3.2.0/front/css/bootstrap.min.css" />
    <title>今日报资讯后台管理</title>
    <script src="../../bootstrap3.2.0/front/js/jquery-3.3.1.min.js"></script>
    <script src="../../js/bootstrap.js"></script>
</head>
<body>
    <form id="form1" >
        <div class="breadcrub">
            当前位置：新闻管理>新闻版式编辑
            <div class="news_filter_form">
                <input name="keywords" type="text" placeholder="请输入关键字" class="input_txt" />
                <input type="submit" value="搜 索" class="input_sub" />
            </div>
        </div>
        <div class="pannel">
         	<table class="common_table">
            	<tr>
                   	<th width="5%">新闻ID</th>
                   	<th width="65%">标题</th>
                  	<th width="10%">发布时间</th>
                   	<th width="10%">管理操作</th>
                   	<th width="10%">删除操作</th>
              	</tr>
                <?php include '../../Function_DAL/Table_News_CURD.php';
                $userinfo = News_SelectPart(1, 'news_edit');
                if(!empty($userinfo)) 
                {
                    foreach($userinfo as $row)
        			{
        				echo '<tbody>';
                        echo '<tr>';
                        echo '<td>'.$row["news_id"].'</td>';
                        echo '<td class="tleft">'.$row["title"].'</td>';
                        echo '<td>'.$row["publish_time"].'</td>';
                        echo '<td>';
                        echo '    <a href="news_update.php?id='.$row["news_id"].'" class="editContent">编辑</a>';
                        echo '</td>';
                        echo '    <td>';
                        echo '        <button class="btn btn-warning" data-toggle="modal" data-target="#editModal" type="button" data-nid="'.$row["news_id"].'" data-tit="'.$row["title"].'">';
                        echo '          删除';
                        echo '        </button>';
                        echo '        <div class="modal fade" id="editModal" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">';
                        echo '            <div class="modal-dialog">';
                        echo '                <div class="modal-content">';
                        echo '                    <div class="modal-header">';
                        echo '                        <button type="button" class="close" data-dismiss="modal">';
                        echo '                            <span aria-hidden="true">&times;</span>';
                        echo '                            <span class="sr-only">Close</span>';
                        echo '                        </button>';
                        echo '                        <h4 style="align-content: center;" class="modal-title aa">新闻删除</h4>';
                        echo '                    </div>';
                        echo '                    <div class="modal-body">';
                        echo '                        <div class="form-group">';
                        echo '                            <label for="NewsID" class="col-sm-3 control-label">新闻ID:</label>';
                        echo '                            <div class="col-sm-9">';
                        echo '                                <input type="text" class="form-control" name="leibie" id="NewsID" />';
                        echo '                            </div>';
                        echo '                        </div>';
                        echo '                        <br />';
                        echo '                         <div class="form-group">';
                        echo '                            <label for="Title" class="col-sm-3 control-label">新闻标题:</label>';
                        echo '                            <div class="col-sm-9">';
                        echo '                                <input type="text" class="form-control" id="Title" />';
                        echo '                            </div>';
                        echo '                        </div>';
                        echo '                    </div>';
                        echo '                    <div class="modal-footer">';
                        echo '                        <button type="button" class="btn btn-default" data-dismiss="modal">关闭</button>';
                        echo '                        <button type="button" class="btn btn-primary" id="delete">确认删除</button>';
                        echo '                    </div>';
                        echo '                </div>';
                        echo '            </div>';
                        echo '        </div>';
                        echo '    </td>';
                        echo '</tr>';
                        echo '</tbody>';
        			}
        		}
        		?>
                <tr>
                	<td colspan="5"><a href="news_write.html" class="addtype">发布新闻</a></td>
                </tr>
            </table>
        </div>
        
<!--         data 属性 data-toggle 用于打开模态窗口。 -->
<!--         <div class="modal fade" id="mymodal-data" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true"></div> -->
<!--         aria-labelledby="mySmallModalLabel"，该属性引用模态框的标题。 -->
<!--         aria-hidden="true" 用于保持模态窗口不可见，直到触发器被触发为止（比如点击在相关的按钮上）。 -->
<!--         role="dialog"用于指定模态框为对话框。 -->
<!--          class="modal fade"模态框弹出时的动画效果（淡入淡出效果） -->
<!--         tabindex可以更改网页中Tab键选择按钮的顺序，如果值为负数则不会被Tab选中 -->

        <div class="panel-footer">
            <div class="pager">
                <ul class="pagination pagination-lg">
                     <?php echo $page_html;?>
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
                    	$.get("../../Ajax/HandleAjax.php",
                            {
                        		id: btn.data("nid")
                            },
                            function(data)
                            {
                                alert(data);
                            	//window.location.reload();//页面刷新
                        	}
                    	);
                    });
                });
            });
        </script>
    </form>
</body>
</html>
