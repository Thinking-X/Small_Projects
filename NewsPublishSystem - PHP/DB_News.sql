-- 新建数据库: NewsDB
/*
 1. 如果数据库不存在则创建，存在则不创建。
 2. 创建NewsDB数据库，并设定编码集为utf8
*/
CREATE DATABASE IF NOT EXISTS `NewsDB` DEFAULT CHARSET utf8 COLLATE utf8_general_ci;





-- 新建表: news
CREATE TABLE IF NOT EXISTS `news`(
   `news_id` INT UNSIGNED AUTO_INCREMENT,
   `manager_id` INT NOT NULL,
   `style_id` INT NOT NULL,
   `title` varchar(100) NULL,
   `content` text NULL,
   `picture` varchar(50) NULL,
   `news_source` varchar(100) NULL,
   `publish_time` DATETIME NULL,
   `AuditState` varchar(100) NULL,
   `RejectReason` varchar(100) NULL,
   PRIMARY KEY (`news_id`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- 新建表: style --新闻类型
CREATE TABLE IF NOT EXISTS `style`(
   `style_id` INT UNSIGNED AUTO_INCREMENT,
   `style_name` varchar(50) NULL,
   PRIMARY KEY (`style_id`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- 新建表: user
CREATE TABLE IF NOT EXISTS `user`(
   `user_id` INT UNSIGNED AUTO_INCREMENT,
   `user_phone` VARCHAR(20) NOT NULL,
   `user_name` VARCHAR(100) NOT NULL,
   `gender` CHAR(1) NOT NULL comment '1表示男，0表示女',
   `birthdate` DATE NULL,
   `password` VARCHAR(20) NOT NULL,
   PRIMARY KEY (`user_id`, `user_phone`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- 新建表: comment
CREATE TABLE IF NOT EXISTS `comment`(
   `comment_id` INT UNSIGNED AUTO_INCREMENT,
   `news_id` INT NOT NULL,
   `user_id` INT NOT NULL,
   `comm_content` VARCHAR(200) NOT NULL,
   `comm_time` DATETIME NOT NULL,
   PRIMARY KEY (`comment_id`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- 新建表: manager
CREATE TABLE IF NOT EXISTS `manager`(
	`manager_id` INT UNSIGNED AUTO_INCREMENT,
	`true_name` varchar(50) NOT NULL,
	`phone` varchar(20) NOT NULL,
	`pwd` varchar(50) NOT NULL,
	PRIMARY KEY (`manager_id`,`phone`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;