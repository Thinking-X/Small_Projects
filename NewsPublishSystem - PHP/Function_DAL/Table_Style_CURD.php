<?php
include_once 'DB_Service.php';
function Style_SelectOneByID($id)//
{
    $sqlStr = "select * from style where style_id = '$id'";
    $result = mysqli_query(GetConn(), $sqlStr);
    return mysqli_fetch_assoc($result);
}
function Style_SelectAll()
{
    $sqlStr = "select * from style";
    $result = mysqli_query(GetConn(), $sqlStr);
    $userinfo = array();
    while($row = mysqli_fetch_assoc($result))
    {
        $userinfo[] = $row;
    }
    return $userinfo;
}
function Style_InsertRecord($username, $sex, $password)//
{
    $sqlStr = 'insert into user (name, gender, password) values ("'.$username.'","'.$sex.'","'.$password.'")';
    return mysqli_query(GetConn(),$sqlStr);
    //$userid = mysqli_insert_id(GetConn()); //返回最后一条插入语句产生的自增 ID
}
function Style_DeleteRecord($id)//
{
    $sqlStr = 'delete from user where user_id='.$id;
    return mysqli_query(GetConn(),$sqlStr);
}
?>