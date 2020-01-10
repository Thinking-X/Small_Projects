<?php
$ConnObj=null;//全局变量
//var_dump($ConnObj);
function GetConn()//链接数据库
{
    $hostname="localhost";
    $database="newsdb";
    $username="root";
    $paswd="root";
    global $ConnObj;//使用全局变量
    //var_dump($ConnObj);
    $ConnObj = mysqli_connect($hostname,$username,$paswd) or die(mysqli_error($ConnObj));
    mysqli_select_db($ConnObj,$database);
    mysqli_query($ConnObj, 'set names utf8');
    return $ConnObj;
}

function CloseConn()//释放数据库
{  
    global $ConnObj;
    //var_dump($ConnObj);
    if($ConnObj){
        mysqli_close($ConnObj) or die(mysqli_error($ConnObj));
    }
}
?>