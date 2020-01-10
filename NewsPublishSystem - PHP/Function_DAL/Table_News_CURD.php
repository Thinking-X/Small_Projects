<?php
include_once 'DB_Service.php';
function News_SelectOneByID($id)//
{
    $sqlStr = "select * from news where news_id = '$id'";
    $result = mysqli_query(GetConn(), $sqlStr);
    return mysqli_fetch_assoc($result);
}

function News_SelectByTitle($title)//根据新闻标题模糊查询
{
    $sqlStr = "select * from news where title LIKE '%$title%'";
    $ConnObj = GetConn();
    $result = mysqli_query($ConnObj, $sqlStr);
    if(!$result)
    {
        die(mysqli_error($ConnObj));
        return;
    }
    $userinfo = array();
    while($row = mysqli_fetch_assoc($result))
    {
        $userinfo[] = $row;
    }
//     if(count($userinfo, 0) === 1)
//     {
//         return $userinfo[0];
//     }
    return $userinfo;
}

function News_SelectPart($pageSize, $pageName)//分页查询
{
    $sqlStr = "select count(*) from news";
    $res = mysqli_query(GetConn(), $sqlStr);
    if(!$res)
    {
        die(mysqli_error());
        return;
    }
    
    $count = mysqli_fetch_row($res);
    //取出查询结果中的第一列的值
    $count = $count[0];
    $max_page = ceil($count/$pageSize);
    //获取当前选择的页码，并作容错处理
    $page = isset($_GET['page']) ? intval($_GET['page']) : 1;
    $page = $page > $max_page ? $max_page : $page;
    $page = $page < 1 ? 1 : $page;
    
     global $page_html;
     //组合分页链接
     $page_html = "<a href='./$pageName.php?page=1'>首页</a>&nbsp;&nbsp;";
     $page_html .= "<a href='./$pageName.php?page=".(($page - 1) > 0 ? ($page - 1) : 1)."'>上一页</a>&nbsp;&nbsp;";
     $page_html .= "<a href='./$pageName.php?page=".(($page + 1) < $max_page ? ($page + 1) : $max_page)."'>下一页</a>&nbsp;&nbsp;";
     $page_html .= "<a href='./$pageName.php?page={$max_page}'>尾页</a>";
     
    //拼接查询语句并执行，获取查询数据
     $lim = ($page -1) * $pageSize;
    $sql = "select * from news limit {$lim},{$pageSize}";
    $res = mysqli_query(GetConn(),$sql);
    if(!$res)
    {
        die(mysqli_error());
        return;
    }
    
    //读取数据并作相关处理
    $userinfo = array();
    while($row = mysqli_fetch_assoc($res)){
    	$userinfo[] = $row;
    }
    return $userinfo;
}
function News_SelectTop($quantity)//查询最新记录
{
    $sqlStr = "select * from news order by news_id desc limit $quantity";
    $result = mysqli_query(GetConn(), $sqlStr);
    $userinfo = array();
    while($row = mysqli_fetch_assoc($result))
    {
        $userinfo[] = $row;
    }
    return $userinfo;
}

function News_InsertRecord_Guest($manager_id, $style_id, $title, $content, $picture, $news_source)//
{
    // $dbConnection = new PDO('mysql:dbname=newsdb;host=localhost;charset=utf8', 'root', 'root');
    // $dbConnection->setAttribute(PDO::ATTR_EMULATE_PREPARES, false);
    // $dbConnection->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    try{
        $pdo = new PDO("mysql:host=localhost;dbname=newsdb;charset=utf8","root","root");
        
        //预处理的SQL语句
        $stmt = $pdo->prepare("insert into news (manager_id, style_id, title, content, picture, news_source, publish_time) values (?,?,?,?,?,?,NOW())");
        
        //为占位符绑定变量
        $stmt->bindParam(1,$manager_id_);
        $stmt->bindParam(2,$style_id_);
        $stmt->bindParam(3,$title_);
        $stmt->bindParam(4,$content_);
        $stmt->bindParam(5,$picture_);
        $stmt->bindParam(6,$news_source_);
        
        
        //为绑定的变量赋值
        $manager_id_= $manager_id;
        $style_id_ = $style_id;
        $title_ = $title;
        $content_ = $content;
        $picture_ = $picture;
        $news_source_ = $news_source;
        
        //执行预处理语句
        $stmt->execute();
        return true;
    }catch(PDOException $e){
        //输出异常信息
        echo $e->getMessage().'<br>';
    }
    
//     $sqlStr = 'insert into news (manager_id, style_id, title, content, picture, news_source, publish_time) values ("'.$manager_id.'","'.$style_id.'","'.$title.'","'.$content.'","'.$picture.'","'.$news_source.'",NOW())';
    
//     $ConnObj = GetConn();
//     $result = mysqli_query($ConnObj, $sqlStr);
//     if(!$result)
//     {
//         die(mysqli_error($ConnObj));
//         file_put_contents('log.txt',mysqli_error($ConnObj),FILE_APPEND);
//         return;
//     }
    
//     return mysqli_query(GetConn(),$sqlStr);
}
function News_InsertRecord_Admin($manager_id, $style_id, $title, $content, $picture, $news_source, $AuditState, $RejectReason)//
{
    $sqlStr = 'insert into news (manager_id, style_id, title, content, picture, news_source, publish_time, AuditState, RejectReason) values ("'.$manager_id.'","'.$style_id.'","'.$title.'","'.$content.'","'.$picture.'","'.$news_source.'",NOW(),"'.$AuditState.'","'.$RejectReason.'")';
    return mysqli_query(GetConn(),$sqlStr);
}
function News_DeleteRecord($id)//
{
    $sqlStr = 'delete from news where news_id='.$id;
    return mysqli_query(GetConn(),$sqlStr);
}

?>