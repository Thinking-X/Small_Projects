<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<link rel="stylesheet" type="text/css" href="../css/reset.css" />
	<link rel="stylesheet" type="text/css" href="../css/main.css" />
	<script type="text/javascript" src="../js/jquery-1.12.4.min.js"></script>
	<script type="text/javascript" src="../js/jquery.form.min.js"></script>
	<script src="../tinymce/js/tinymce/tinymce.min.js"></script>
    <script src="../js/tinymce_setup.js"></script>
	<script src="../js/news_edit_detail.js"></script>
    <title>今日报资讯后台管理</title>
</head>
<body>
    <div class="breadcrub">
        当前位置：新闻管理>新闻内容编辑
    </div>
    <div class="pannel">
        <form class="news_edit" id="contentForm" method="post" action="">
            <h3 class="review_title">新闻内容编辑</h3>
            <div class="form_group">
                <label>新闻标题：</label>
                <?php include_once '../../Function_DAL/Table_News_CURD.php';
                include_once '../../Function_DAL/Table_Style_CURD.php';
                $row = News_SelectOneByID($_GET["id"]);//
                ?>
                <input type="text" class="input_txt2" name="Title" id="nTitle" value="<?php echo $row["title"]?>" />
            </div>
            <div class="form_group">
                <label>新闻分类：</label>
                    <select class="sel_opt" name="StyleID" id="nType" >
				<?php 
				$userinfo = Style_SelectAll();//style表
                foreach($userinfo as $row_)
        		{				    
				    echo '<option value="'.$row_["style_id"].'" id="nStyle">'.$row_["style_name"].'</option>';
                }
                ?>
                </select>      
            </div>
            <div class="form_group">
                <label>新闻来源：</label>
                <input type="text" class="input_txt2" name="NewsSource" id="nSource" value="<?php echo $row["news_source"]?>" />
            </div>
            <div class="form_group">
                <label>索引图片：</label>
                <input type="file" onchange="showPic(this)" name="Pic" id="nPic" />
                <img src="../../Images/News/<?php echo $row['picture']?>" id="pic" class="index_pic" />
            </div>
            <div class="form_group">
                <label>新闻内容：</label>
                <div class="rich_wrap fl">
                    <textarea class="input_area" id="rich_content" name="NewsContent" >
                        <?php echo $row["content"]?>
                    </textarea>
                </div>
            </div>
            <div class="form_group indent_group line_top">
                <input type="button" value="确定" class="confirm" id="confirmBtn" name="button" />
                <input type="button" value="取消" class="cancel" onclick="cancel()" />
            </div>
        </form>
    </div>

    <script type="text/javascript">
        $("#nType").val("<?php echo $row["style_id"]?>");

        function getFullPath(obj) {
            if (obj) {
                //兼容chrome、火狐等，HTML5获取路径       
                if (typeof FileReader != "undefined") {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        document.getElementById("pic").src = e.target.result + "";
                    }
                    reader.readAsDataURL(obj.files[0]);
                }
            }
        };
        function showPic(obj) {
            var fullPath = getFullPath(obj);
        };

        $('#confirmBtn').click(function () {
            $.post("../Ajax/EditContent.ashx?Request=1", {
                OperationType: "update",
                NewsID: <?php echo $row["name"]?>,
                Title: $("#nTitle").val(),
                StyleID: $("#nType").val(),
                NewsSource: $("#nSource").val(),
                Pic: "../Images/News/" + $("#nPic").val().slice(12),
                NewsContent: tinyMCE.activeEditor.getContent()
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
    </script>
</body>
</html>
