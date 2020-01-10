<?php
class user {
    /* 成员变量 */
    var $user_id;//如果用 var 定义，则被视为公有。
    var $user_phone;
    var $user_name;
    var $gender;
    var $birthdate;
    var $password;
}

class news {
    var $news_id;
    var $manager_id;
    var $style_id;
    var $title;
    var $content;
    var $picture;
    var $news_source;
    var $publish_time;
    var $AuditState;
    var $RejectReason;
} 
    
class style {
    var $style_id;
    var $style_name;
}
            
class comment {
    var $comment_id;
    var $news_id;
    var $user_id;
    var $comm_content;
    var $comm_time;
}

class manager {
    var $manager_id;
    var $true_name;
    var $phone;
    var $pwd;
} 
?>