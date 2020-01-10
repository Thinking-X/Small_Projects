<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" charset="utf-8" />
<link rel="stylesheet" href="CSS/bootstrap.css"/>
<link rel="stylesheet" href="CSS/main.css"/>

<link rel="stylesheet" type="text/css" href="bootstrap3.2.0/front/css/bootstrap.min.css" />
<link rel="stylesheet" type="text/css" href="CSS/common.css" />

<script type="text/javascript" src="js/jquery-1.11.1.js"></script>
<script type="text/javascript" src="js/bootstrap.js"></script>
    <!--
        图片轮播Carousel需要引入的文件，需要使用Bootstrap（用于生产环境的Bootstrap版本），Bootstrap3对2并不兼容，直接根据其开发文档使用Bootstrap3
        Bootstrap3所提供的JavaScript效果需要到jQuery1.11支持，可以到jQuery官网中下载兼容旧浏览器IE6的jQuery1.11，而不是不兼容旧浏览器IE6的jQuery2
        把Bootstrap3直接解压到站点目录，把jquery-1.11.1.js放到js目录，也就是与bootstrap.js同一目录
    -->
    
<style type="text/css">  
    .btns{font-weight: bold;
          display: inline-block;
          width: 40px;height: 40px;
          /*border: #5fb878;*/
          /*background: #5fb878;*//*#FFFFFF*/
          font-size: 1.2em;
          text-align: center;
          /*padding-top: 5px;*/
          color: white;}
    a:hover{color:#FFFFFF}
</style>  

    <title>今日报-首页</title>
</head>
<body>
    <form id="form1">
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
    
    <div class="container">
        <div style="width: 1000px; height: 180px; margin-right: auto; margin-left: auto;">
            <div id="carousel-example-generic" class="carousel slide" data-ride="carousel" data-interval="2000">
                <ol class="carousel-indicators">
                    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                </ol>
                <div class="carousel-inner" role="listbox">
                    <div class="item active">
                        <a href="Images/AD/ad-1.jpg"><img src="Images/AD/ad-1.jpg" width: 100%; height: 280px; alt="img0"/></a>
                        <div class="carousel-caption">
                            <h3>
                                广告
                            </h3>
                            <p>
                                广告
                            </p>
                        </div>
                    </div>
                    <div class="item">
                        <a href="Images/AD/ad-3.PNG"><img src="Images/AD/ad-3.PNG" width: 100%; height: 280px; alt="img1"/></a>
                        <div class="carousel-caption">
                            <h3>
                                广告
                            </h3>
                            <p>
                                广告
                            </p>
                        </div>
                    </div>
                    <div class="item">
                        <a href="Images/AD/ad-1.jpg"><img src="Images/AD/ad-1.jpg" width: 100%; height: 280px; alt="img2"/></a>
                        <div class="carousel-caption">
                            <h3>
                                广告
                            </h3>
                            <p>
                                广告
                            </p>
                        </div>
                    </div>
                </div>
                <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left"></span>
                </a>
                <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right"></span>
                </a>
            </div>
        </div>
    </div>

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
                <div class="news-list">
                <?php include 'Function_DAL/Table_News_CURD.php';
                $userinfo = News_SelectPart(1, 'index');
                if(!empty($userinfo)) 
                { 
    				foreach($userinfo as $row)
    				{
    					echo '<div class="news-list-item clearfix">';
                        echo '    <div class="col-xs-5">';
                        echo '        <img src=Images/News/'.$row["picture"].' />';
                        echo '    </div>';
                        echo '    <div class="col-xs-7">';
                        echo '        <a href="NewsDetails.php?id='.$row["news_id"].'" class="title">'.$row["title"].'</a>';
                        echo '        <div class="info">';
                        echo '            <span><span class="avatar"><img src="Images/News/0.jpg" /></span>王花花</span>';
                        echo '            <span>25k评论</span> ';
                        echo '             <span>10分钟前</span>';
                        echo '        </div>';
                        echo '    </div>';
                        echo '</div>';
    			 	}
    			}
    			//mysqli_free_result($userinfo);
    			?>
                </div>
                
                <div class="panel-footer">
                    <div class="pager">
                        <?php echo $page_html;?>
                    </div>
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
     </div>
        
     <div style="overflow: hidden;position: fixed;right: 10px;bottom: 20px;z-index: 10;">
	    <div style="overflow: hidden;">
	        <div style="padding-right:50px;">
	    	    <a href="#" class="btns"  title="刷新"><img src="Images/Icon/Refresh.jpg" /></a>
			</div>
	    	<div style="padding-top:20px;padding-right:50px;">
			    <a href="#" class="btns"  title="反馈"><img src="Images/Icon/feedback.png" /></a>
			</div>
	    	<div style="padding-top:20px;padding-right:50px;padding-bottom:50px">
			    <a href="#" style="float: right;" class="btns" title="回到顶部"><img src="Images/Icon/top.jpg" /></a>
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

                    //window.location.href = "http://www.baidu.com";
                    //window.open("http://www.baidu.com");
                    
                    //var name = document.getElementById("exampleInputAmount").value;
                    //window.open(SearchResult.aspx);
                    //$(location).attr("href","SearchResult.aspx?Keyword=" + $("#exampleInputAmount").val() );
                });
            });
        </script>
    </form>

</body>
</html>

