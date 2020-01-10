<?php
include 'Function_DAL/Table_User_CURD.php';
$phone = $_POST['loginPhone'];
$pwd = $_POST['loginPwd'];
if(User_SelectOneByPhone($phone, $pwd))
{
    session_start();//1、启用session
    $_SESSION['Phone'] = $phone; //2、用全局数组session[]存储传递的值
    $_SESSION['Pwd'] = $pwd;
        
        
//         $time = time()+3600;//1小时，以秒为单位
//         setcookie($name, $pwd, $time);
//         if(isset($_COOKIE["Name"]))
//         {
//             $name = $_COOKIE["Name"];
//             echo $name."</br>";
//         }
//         else
//         {
//             echo "Http请求中没有名字为name的Cookie"."</br>";
//         }
//         if(isset($_COOKIE["Pwd"]))
//         {
//             $pwd = $_COOKIE["Pwd"];
//             echo $pwd."</br>";
//         }
//         else
//         {
//             echo "Http请求中没有名字为password的Cookie"."</br>";
//         }
        echo "<script language=\"JavaScript\">\r\n";
        echo " window.location.href='index.php';\r\n";
        echo "</script>";
}
else //弹出对话框之后返回原来页面
{
    echo "<script language=\"JavaScript\">\r\n";
    echo " alert(\"登录失败\");\r\n";
    //echo " window.location.reload();\r\n";
    echo  " history.back();\r\n";
    echo "</script>";
    //exit;//输出一个消息并且退出当前脚本
        
//         或者
//         print "<script language=\"JavaScript\">\r\n";
//         print " alert(\"登录失败\");\r\n";
//         print " history.back();\r\n";
//         print "</script>";
//         exit;
}
?>