<!DOCTYPE html>

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" charset="utf-8" />
<link rel="stylesheet" href="CSS/bootstrap.css"/>
<link rel="stylesheet" href="CSS/main.css"/>

<link rel="stylesheet" type="text/css" href="bootstrap3.2.0/front/css/bootstrap.min.css" />
<link rel="stylesheet" type="text/css" href="CSS/common.css" />

<script type="text/javascript" src="js/jquery-1.11.1.js"></script>
<script type="text/javascript" src="js/bootstrap.js"></script>
    <title></title>
</head>
<body>
    <form>
        <div class="navbar navbar-default" style="margin-left:20px; margin-right:20px; height:70px;">
        <div class="row">
            <div class="col-lg-1 col-md-3">
                <img style="margin-left:14px; margin-right:25px; margin-top:15px;" src="Images/login/logo.jpg" />
            </div>
            <div class="col-lg-8 col-xs-8">
                <ul class="nav nav-pills" style="margin-top:20px;">
                    <li class="active"><a href="#">首页</a></li>
                    <li><a href="#">国际</a></li>
                    <li><a href="#">国内</a></li>
                    <li><a href="#">军事</a></li>
                    <li><a href="#">体育</a></li>
                    <li><a href="#">娱乐</a></li>
                    <li><a href="#">财经</a></li>
                    <li><a href="#">科技</a></li>
                    <li><a href="#">时尚</a></li>
                </ul>
            </div>
            <div class="col-lg-2 col-md-2">
                <ul class="nav navbar-nav navbar-right">
                    <li>
                        <a href="login_register.html">
                            <img src="Images/login.png" height="32" width="32" />
                            <p>登录</p>
                        </a>
                    </li>
                    <li>
                        <a href="login_register.html">
                            <img src="Images/register.png" />
                            <p>注册</p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
        <br />
    <div>
        <h1 style="text-align:center;">
        <?php include 'Function_DAL/Table_News_CURD.php';
        $userinfo = News_SelectOneByID($_GET['id']);
        echo '<label for="'.$userinfo["news_id"].'">'.$userinfo["title"].'</label>';
        ?>
    	</h1>  
    </div>
        <br />

        <div class="container">
        <div class="row">
            <div class="col-lg-2">    
                <div class="panel panel-info">
                    <div class="panel-heading">您感兴趣的</div>
                    <div class="panel-body">
                        <ul class="nav nav-pills nav-stacked">
                            <li><a href="#">热闻</a></li>
                            <li><a href="#">科普</a></li>
                            <li class="nav-divider"></li>
                            <li><a href="#">问答</a></li>
                            <li><a href="#">论坛</a></li>
                            <li class="nav-divider"></li>
                            <li><a href="#">图片</a></li>
                            <li><a href="#">视频</a></li>
                            <li class="nav-divider"></li>
                            <li><a href="#">加入我们</a></li>
                        </ul>
                    </div>
                    <div class="panel-footer"></div>
                </div>

                <div class="panel panel-info">
                    <a href="#">
                        <img style="width: 100%; height: 300px;" src="Images/AD/ad-2.jpg" />
                    </a>
                </div>
            </div>
            <div class="col-lg-7">
                <div>
                    <br /><br /><br />
                    <p style="text-indent:50px; font-size:20px;">
                    <?php
                    $userinfo = News_SelectOneByID($_GET['id']);
                    echo '<label for="'.$userinfo["news_id"].'">'.$userinfo["content"].'</label>';
                    ?>
                    </p>
                    <br />
                    <div class="desc">15k阅读 1k评论</div>
                    <br />
                </div>
                <div style="text-align:center;">
                    <p style="font-size:10px;">
                        免责声明：本文来自腾讯新闻客户端自媒体，不代表腾讯网的观点和立场。
                    </p>
                </div>
                
            </div>   
                
            <div class="col-lg-3">
                <div class="form-inline">
                    <div class="form-group">
                        <label class="sr-only" for="exampleInputAmount">Amount (in dollars)</label>
                        <div class="input-group">
                            <input type="text" class="form-control" id="exampleInputAmount" placeholder="标题搜索" />
                        </div>										
                    </div>
                    <button type="button" class="btn btn-primary" id="btnSearch">搜一下</button>
                </div>
                
                <div class="side-bar-card flag clearfix">
                    <div class="col-xs-5">
                        <a href="http://report.12377.cn:13225/toreportinputNormal_anis.do"><img src="Images/1-1.png" /></a>
                    </div>
                    <div class="col-xs-7">
                        <div class="text-lg">有害信息举报专区</div>
                        <div>举报电话：12377</div>
                    </div>
                </div>
                <div class="side-bar-card">
                    <div class="card-title">24小时热闻</div>
                    <div class="card-body">
                    <div class="list">
                        <?php $userinfo = News_SelectTop(2);
                        if(!empty($userinfo))
                        {
                            foreach($userinfo as $row)
                            {
                                echo '<div class="item">';
                                echo '<div class="title">';
                                echo '<a href="NewsDetails.php?id='.$row["news_id"].'" class="title">'.$row["title"].'</a>';
                                echo '</div>';
                                echo '<div class="desc">15k阅读 1k评论</div>';
                                echo '</div>  ';
                            }
                        }
                        ?>
                    </div>
                   </div>
                </div>
             </div>
       </div>

        <div class="footer">
        © 2019 今日报 中国互联网举报中心 京ICP证1401号京ICP备125439号-3京公网安备
        </div>
        <script type="text/javascript">
            $(function () {
                $("#btnSearch").click(function () {                   
                    location.href = "SearchResult.php?Keyword=" + $("#exampleInputAmount").val();
                });
            });
        </script>
    </form>
</body>
</html>
