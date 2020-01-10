<?php
include_once 'Function_DAL/Table_User_CURD.php';
include_once 'Object/EntityClass.php';
$user_ = new user;
$user_->birthdate = $_POST['phone'];
$user_->user_name = $_POST['registerName'];
$user_->birthdate = $_POST['date'];
$user_->password = $_POST['registerPwd'];
$user_->gender = $_POST['gender'];
//     if(!strcmp($_POST['gender'], "1"))
//     {
//         $user_->gender = 1;
//     }
//     else
//     {
//         $user_->gender = 0;
//     }
    $result = User_InsertRecord($user_);
    if($result)
    {
        echo "<script language=\"JavaScript\">\r\n";
        echo " alert(\"注册成功！\");\r\n";
        echo " window.location.href='index.php';\r\n";
        echo "</script>";
    }
    else 
    {
        echo "<script language=\"JavaScript\">\r\n";
        echo " alert(\"注册失败！\");\r\n";
        //echo " window.location.reload();\r\n";
        echo "</script>";
    }

?>