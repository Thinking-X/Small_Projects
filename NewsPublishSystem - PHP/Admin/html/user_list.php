<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
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
    <form id="form1">
        <div class="breadcrub">
            当前位置：用户管理>用户列表
        </div>
        <div class="pannel">
            <table class="common_table">
            	<tr>
                	<th>用户ID</th>
                	<th>用户名称</th>
                    <th>性别</th>
                    <th>密码</th>
                    <th>生日</th>
                </tr>
                <?php include '../../Function_DAL/Table_User_CURD.php';
                $userinfo = User_SelectPart(2, 'user_list');
                    if(!empty($userinfo)) 
                    { 
        				foreach($userinfo as $row)
        				{
        					echo '<tr>';
                            echo '<td>'.$row["user_id"].'</td>';
                            echo '<td>'.$row["user_name"].'</td>';
                            echo '<td>'.$row["gender"].'</td>';
                            echo '<td>'.$row["password"].'</td>';
                            echo '<td>'.$row["birthdate"].'</td>';
                            echo '</tr>';
        			 	}
        			}
        			//mysqli_free_result($userinfo);
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
