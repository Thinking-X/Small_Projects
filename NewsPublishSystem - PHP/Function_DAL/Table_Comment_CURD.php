<?php
include 'DB_Service.php';
function SelectOneByID($id)//
{
    $sqlStr = "select * from user where id = '$id'";
    $result = mysqli_query(GetConn(), $sqlStr);
    //$userinfo = array();
    //因为通过id查询记录，返回结果是1条或0条，因此不必通过while循环
    //并且如果通过while循环得到数据，返回，通过键取值(形如$userinfo["name"])，那么不会取得到值，提示:Undefined index: name。具体原因，暂未搞懂
    //  while($row = mysqli_fetch_assoc($result))
    //  {
    //      $userinfo[] = $row;
    //  }
    //$userinfo = mysqli_fetch_assoc($result);
    return mysqli_fetch_assoc($result);
}
function SelectOneByName($name, $pwd)//根据用户名和密码准确查询
{
    $sqlStr = "select * from user where name = '$name' and password = '$pwd'";
    $result = mysqli_query(GetConn(), $sqlStr);
    return mysqli_fetch_assoc($result);
    //$userinfo = array();
    //$userinfo[] = mysqli_fetch_assoc($result);
    //return $userinfo;
    //对于上边这种只返回一条记录的情况
    //若申请了一个array数组，并且往数组中追加了一个对象，即使该对象为null，则该数组也不为空。通过if判断该数组，值为true
    //所以只需要返回一个对象就可以，不要返回一个对象数组，不然不可以直接用if判断对象，
    //得需要if($userinfo[]===null)判断，不可以if($userinfo)判断
}

function SelectByName($name)//根据用户名模糊查询
{
    $sqlStr = "select * from user where name LIKE '%$name%'";
    $result = mysqli_query(GetConn(), $sqlStr);
    $userinfo = array();
    while($row = mysqli_fetch_assoc($result))
    {
        $userinfo[] = $row;
    }
    return $userinfo;
}
function SelectPart($pageSize, $pageName)//分页查询
{
    $sqlStr = "select count(*) from user";
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
    $sql = "select * from user limit {$lim},{$pageSize}";
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
function SelectTop($quantity)//查询最新记录
{
    $sqlStr = "select * from user order by id desc limit $quantity";
    $result = mysqli_query(GetConn(), $sqlStr);
    $userinfo = array();
    while($row = mysqli_fetch_assoc($result))
    {
        $userinfo[] = $row;
    }
    return $userinfo;
}
function InsertRecord($username, $sex, $password)//
{
    $sqlStr = 'insert into user (name, gender, password) values ("'.$username.'","'.$sex.'","'.$password.'")';
    return mysqli_query(GetConn(),$sqlStr);
    //$userid = mysqli_insert_id(GetConn()); //返回最后一条插入语句产生的自增 ID
}
function DeleteRecord($id)//
{
    $sqlStr = 'delete from user where user_id='.$id;
    return mysqli_query(GetConn(),$sqlStr);
}

?>