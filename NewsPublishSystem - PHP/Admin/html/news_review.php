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
        	<table class="common_table">
				<tr>
					<th width="3%">新闻ID</th>
					<th width="70%">标题</th>
					<th width="15%">发布时间</th>
					<th width="5%">状态</th>
					<th width="8%">管理操作</th>
				</tr>
                <?php include '../../Function_DAL/Table_News_CURD.php';
                $userinfo = News_SelectPart(2, 'news_review');
                foreach($userinfo as $row)
        		{
                    echo '<tr>';
                    echo '<td>'.$row["news_id"].'</td>';
					echo '<td class="tleft">'.$row["title"].'</td>';
					echo '<td>'.$row["publish_time"].'</td>';
					echo '<td>'.$row["AuditState"].'</td>';
					echo '<td>';
					echo '	<a href="news_review_detail.php?id='.$row["news_id"].'" class="review">审核</a>';
					echo '</td>';
				    echo '</tr>';
                }
                ?>
        	</table>			
		</div>
        <div class="panel-footer">
            <div class="pager">
                <ul class="pagination pagination-lg">
                    <?php echo $page_html;?>
                </ul>
            </div>
        </div>
    </form>
</body>
</html>
