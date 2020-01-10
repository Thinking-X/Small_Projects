<?php
    include_once '../Function_DAL/Table_User_CURD.php';
    include_once '../Function_DAL/Table_News_CURD.php';
    
    //isset($var)检测变量是否设置
    if(isset($_GET["id"]))
    {
        $GET1 = $_GET["id"];
        echo json_encode($GET1);
    }
//     int strncmp(string str1,string str2,int len)
//     参数str1规定要比较的首个字符串。参数str2规定要比较的第二个字符串。len（必需）规定比较中所用的每个字符串的字符数。
//     如果相等则返回0；如果参数str1大于str2则返回值大于0；如果参数str1小于str2则返回值小于0。
//     与 strcmp() 函数类似，不同的是，strcmp() 没有 length 参数
    if(isset($_GET["requestPage"]))//请求来自Admin/html/login.html
    {
        if(!strcmp($_GET["requestPage"],"login"))
        {
            $phone = $_POST["username"];
            $pwd = $_POST["password"];
            if(User_SelectOneByPhone($phone, $pwd))
            {
                echo json_encode(1);//登录成功
            }
            else
            {
                echo json_encode(0);//登录失败
            }
        }
        if(!strcmp($_GET["requestPage"],"news_write"))
        {
            $title = $_POST['Title'];
            $style_id = $_POST['StyleID'];
            $news_source = $_POST['NewsSource'];
            $content = $_POST['NewsContent'];
            if ( 0 < $_FILES['file']['error'] ) {
                //echo 'Error: ' . $_FILES['file']['error'] . '<br>';
            }
            else {
                move_uploaded_file($_FILES['file']['tmp_name'], '../Images/News/'.$_FILES['file']['name']);
                $picture = $_FILES['file']['name'];
                //echo json_encode("成功");
            }
            $manager_id = "1";
            $result = News_InsertRecord_Guest($manager_id, $style_id, $title, $content, $picture, $news_source);
            if($result)
            {
                echo json_encode(1);
            }
            else
            {
                echo json_encode(0);
            }
        }
    }
    
    // $myPicture = $_FILES['myPicture'];
    // $error = $myPicture['error'];
    // switch ($error){
    //     case 0:
    //         $myPictureName = $myPicture['name'];
    //         echo "您的个人相片为：".$myPictureName. "<br/>";
    //         $myPictureTemp = $myPicture['tmp_name'];
    //         $destination = "uploads/".$myPictureName;
    //         move_uploaded_file($myPictureTemp,$destination);
    //         echo "文件上传成功！<br/>";
    //         break;
    //     case 1:
    //         echo "上传的文件超过了 php.ini 中upload_max_filesize选项限制的值！<br/>";
    //         break;
    //     case 2:
    //         echo "上传文件的大小超过了FORM表单MAX_FILE_SIZE选项指定的值！<br/>";
    //         break;
    //     case 3:
    //         echo "文件只有部分被上传！<br/>";
    //         break;
    //     case 4:
    //         echo "没有选择上传文件！<br/>";
    //         break;
    // }
?>