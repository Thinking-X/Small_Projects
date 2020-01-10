<?php
include_once 'DB_Service.php';
//include_once './Object/EntityClass.php';//当提示路径不对时，但是检查后去确定没错，试着将双点换成单点

// The include_once() 语句在脚本执行期间包含并运行指定文件。此行为和 include() 语句类似，唯一区别是如果该文件中的代码已经被包含了，则不会再次包含。如同此语句名字暗示的那样，只会包含一次。
// include_once() 应该用于在脚本执行期间同一个文件有可能被包含超过一次的情况下，想确保它只被包含一次以避免函数重定义，变量重新赋值等问题。
// require()和require_once()类似 
// include()和require()。这两种结构除了在如何处理失败之外完全一样。
// include() 产生一个警告Warning，而 require() 则导致一个致命错误Fatal Error
// 换句话说，如果想在遇到丢失文件时停止处理页面就用 require()。include() 就不是这样，脚本会继续运行

//文件引用问题：如上面第3行，login.php应用时，应当那样写。
//但Admin/html下某个文件要引用该文件时，提示找不到EntityClass.php需要写成'../Object/EntityClass.php'原因暂未搞懂
//所以在哪里用到这个类文件，就在哪里引入，比如把这个文件在register.php中引入了
function User_SelectOneByID($id)//
{
    try 
    {
        $sqlStr = "select * from user where user_id = '$id'";
        $ConnObj = GetConn();
        $result = mysqli_query($ConnObj, $sqlStr);
        //mysqli_query(GetConn(), $sqlStr);也可以这样写，但是为了防止函数执行出错，用变量$ConnObj存放链接对象,以使用mysqli_error($ConnObj)
        //$userinfo = array();
        //因为通过id查询记录，返回结果是1条或0条，因此不必通过while循环
        //并且如果通过while循环得到数据，返回，通过键取值(形如$userinfo["name"])，那么不会取得到值，提示:Undefined index: name。具体原因，暂未搞懂
        //  while($row = mysqli_fetch_assoc($result))//返回多条记录
        //  {
        //      $userinfo[] = $row;
        //  }
        //$userinfo = mysqli_fetch_assoc($result);//返回一条记录
        
        if(!$result)
        {
            $error = mysqli_error($ConnObj);
            //mysqli_error(connection); 函数返回最近调用函数的最后一个错误描述
            //mysqli_connect_errno() 函数返回上一次连接错误的错误代码。
            if($error)//这时是sql语句执行出错，抛出异常提示
            {
                throw new Exception($error);
            }
            else //sql语句执行成功，但没有查询到结果，返回结果为空
            {
                return NULL;//和return null;没有区别。相同的类型只是一个不区分大小写的关键字
            }
        }
        return mysqli_fetch_assoc($result);
    }
    catch (Exception $e) 
    {
        echo 'Caught exception: ',  $e->getMessage(), "\n";//既可以用点号连接字符串，也可以用逗号连接字符串
    }
}

function User_SelectOneByPhone($phone, $pwd)//根据手机号和密码准确查询
{
    $sqlStr = "select * from user where user_phone = '$phone' and password = '$pwd'";
    $ConnObj = GetConn();
    $result = mysqli_query($ConnObj, $sqlStr);
    try
    {
        if(!$result)
        {
            $error = mysqli_error($ConnObj);
            if($error)//这时是sql语句执行出错，抛出异常提示
            {
                throw new Exception($error);
            }
            else //sql语句执行成功，但没有查询到结果，返回结果为空
            {
                return NULL;
            }
        }
        return mysqli_fetch_assoc($result);
        //$userinfo = array();
        //$userinfo[] = mysqli_fetch_assoc($result);
        //return $userinfo;
        //对于上边这种只返回一条记录的情况
        //若申请了一个array数组，并且往数组中追加了一个对象，即使该对象为null，则该数组也不为空。通过if判断该数组，值为true
        //所以只需要返回一个对象就可以，不要返回一个对象数组，不然不可以直接用if判断对象，
        //得需要if($userinfo[]===null)判断，不可以if($userinfo)判断
    }
    catch (Exception $e)
    {
        echo 'Caught exception: ',  $e->getMessage(), "\n";
    }
}

function User_SelectByName($name)//根据用户名模糊查询
{
    $sqlStr = "select * from user where user_name LIKE '%$name%'";
    $ConnObj = GetConn();
    $result = mysqli_query($ConnObj, $sqlStr);
    try
    {
        if(!$result)
        {
            $error = mysqli_error($ConnObj);
            if($error)//这时是sql语句执行出错，抛出异常提示
            {
                throw new Exception($error);
            }
            else //sql语句执行成功，但没有查询到结果，返回结果为空
            {
                return NULL;
            }
        }
        $userinfo = array();
        while($row = mysqli_fetch_assoc($result))
        {
            $userinfo[] = $row;
        }
        return $userinfo;
    }
    catch (Exception $e)
    {
        echo 'Caught exception: ',  $e->getMessage(), "\n";
    }
}

function User_SelectPart($pageSize, $pageName)//分页查询
{
    $sqlStr = "select count(*) from user";
    $ConnObj = GetConn();
    $res = mysqli_query($ConnObj, $sqlStr);
    if(!$res)
    {
        die(mysqli_error($ConnObj));//die() 函数输出一条消息，并退出当前脚本。该函数是 exit() 函数的别名。
        return NULL;
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
    $res = mysqli_query($ConnObj, $sql);
    if(!$res)
    {
        die(mysqli_error($ConnObj));
        return NULL;
    }
    
    //读取数据并作相关处理
    $userinfo = array();
    while($row = mysqli_fetch_assoc($res)){
    	$userinfo[] = $row;
    }
    return $userinfo;
}

function User_SelectTop($quantity)//查询最新记录
{
    $sqlStr = "select * from user order by user_id desc limit $quantity";
    $ConnObj = GetConn();
    $result = mysqli_query($ConnObj, $sqlStr);
    if(!$result)
    {
        die(mysqli_error($ConnObj));
        return NULL;
    }
    $userinfo = array();
    while($row = mysqli_fetch_assoc($result))
    {
        $userinfo[] = $row;
    }
    return $userinfo;
}

function User_InsertRecord(user $user_)
{
    $user_phone = $user_->user_phone;
    $user_name = $user_->user_name;
    $gender = $user_->gender;
    $birthdate = $user_->birthdate;
    $password = $user_->password;
    
    $sqlStr = 'insert into user (user_phone, user_name, gender, birthdate, password) values ("'.$user_phone.'","'.$user_name.'","'.$gender.'","'.$birthdate.'","'.$password.'")';
    $ConnObj = GetConn();
    return mysqli_query($ConnObj, $sqlStr);
    //$userid = mysqli_insert_id(GetConn()); //返回最后一条插入语句产生的自增 ID
}

function User_DeleteRecord($id)//
{
    $sqlStr = 'delete from user where user_id='.$id;
    return mysqli_query(GetConn(),$sqlStr);
}

?>