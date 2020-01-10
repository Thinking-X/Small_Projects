<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="NewsPublishSystem.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="css/semantic.css" media="screen" title="no title" />
    <link rel="stylesheet" href="css/login.css" media="screen" title="no title" />
    <title>登录</title>
    <style>
        #color-input-red + label {
            display: block;
            width: 20px;
            height: 20px;
            cursor: pointer;
            position: absolute;
            top: 0px;
            left: 0px;
            background: rgba(240, 84, 77, 1);
        }

        /*当input框为选中状态时，lable标签的样式，其中在css选择时，
          “：”表示当前input框的值，即checked；
      该部分主要对显示的“对号”的大限居中方式，显示颜色进行了设置*/
        #color-input-red:checked + label::before {
            display: block;
            content: "\2714";
            text-align: center;
            font-size: 16px;
            color: white;
        }

        input[type=checkbox] {
            visibility: hidden;
        }
    </style>
    <script type="text/javascript" src="js/jquery-1.11.1.js"></script>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div class="ui basic segment container content">
            <h1 class="ui center aligned header">登录</h1>
            <div class="ui form">
                <div class="field">
                    <div class="ui  image top">
                        <img src="Images/login/usericon.png" alt="" />
                    </div>
                    <input type="text" placeholder="邮箱名" name="txtName" id="input-username"value="<%=LoginUserName%>"/>
                </div>
                <div class="field">
                    <div class="ui  image top">
                        <img src="Images/login/lockicon.png" alt="" />
                    </div>
                    <input type="text" name="txtPwd" id="input-password" placeholder="密码" />
                </div>
                <div class="two fields">
                    <div class="field" style="top: 20px;">
                        <div class="ui image bottom" style="bottom: 13px;">
                            <input id="color-input-red" class="chat-button-location-radio-input" type="checkbox" name="color-input-red" value="#f0544d" onclick="SetCookie()" />
                            <label for="color-input-red"></label>
                        </div>
                        <div style="bottom: 2px; position: absolute;">
                            <span style="font-size: 14px; color: #888888;">&nbsp;&nbsp;&nbsp;记住我</span>
                        </div>

                        <div class="ui image bottom" style="top: 29px; position: absolute;">
                            <img src="Images/login/passwordicon.png" alt="" />
                        </div>
                        <div style="top: 24px; position: relative;">
                            <label><a href="default.aspx" style="font-size: 14px;">忘记密码&nbsp;&nbsp;</a> | <a href="default.aspx" style="font-size: 14px;">&nbsp;&nbsp;重新注册</a></label>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <div class="field">
            
            <button runat="server" onserverclick="btn1_Click" id="submit1" class="ui right floated red circular button" >确认登录</button>
            <asp:Button ID="btn1" runat="server" Visible="false" OnClick="btn1_Click" />
            <%--当使用input type="button"时，onclick会触发脚本的函数--%>
            <%--当直接使用button标签时，onclick不会触发脚本的函数，但onserverclick可以执行Button控件的事件--%>
        </div>
        <div class="ui basic segment container footer">
            <div class="bottom">
                <div class="ui divider"></div>
                <button type="button" name="button" class="ui circular red button backtoindex">
                    <img src="Images/login/homeicon.png" style="position: absolute; left: 18%; top: 10%;" />
                    <h4>首页</h4>
                </button>
                <div class="ui image title">
                    <img src="Images/login/logo.jpg" alt="" />
                </div>
            </div>
        </div>
        <script type="text/javascript">
            function SetCookie() {
                const username = $('#input-username').val();
                const password = $('#input-password').val();

                if ($('#color-input-red').is(':checked')) {
                    $('#color-input-red').attr('checked', 'checked');
                    var Days = 7; //此 cookie 将被保存 7 天
                    var exp = new Date();    //new Date("December 31, 9998");
                    exp.setTime(exp.getTime() + Days * 24 * 60 * 60 * 1000);
                    document.cookie = username + '=' + password + ";expires=" + exp.toGMTString();

                    //为时不设定过期时间，浏览器关闭时cookie自动消失
                    //var date = new Date();
                    //var ms = objHours * 3600 * 1000;
                    //date.setTime(date.getTime() + ms);
                    //str += "; expires=" + date.toGMTString();
                    //document.cookie = str;
                }
                else {
                    //document.cookie = name + "=;expires=" + (new Date(0)).toGMTString();
                    var exp = new Date();
                    exp.setTime(exp.getTime() - 1);
                    document.cookie = username + '=' + password + ";expires=" + exp.toGMTString();
                }
            }

            /**js设置、修改、获取、删除 cookie
             * 设置cookie
             * @param {string} name  键名
             * @param {string} value 键值
             * @param {integer} days cookie周期
             
            function setCookie(name, value, days) {
                if (days) {
                    var date = new Date();
                    date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
                    var expires = "; expires=" + date.toGMTString();
                } else {
                    var expires = "";
                }
                document.cookie = name + "=" + value + expires + "; path=/";
            }
            // 获取cookie
            function getCookie(name) {
                var nameEQ = name + "=";
                var ca = document.cookie.split(';');
                for (var i = 0; i < ca.length; i++) {
                    var c = ca[i];
                    while (c.charAt(0) == ' ') c = c.substring(1, c.length);
                    if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
                }
                return null;
            }
            // 删除cookie
            function deleteCookie(name) {
                setCookie(name, "", -1);
            }
            */

            //获得cookie 的值
            //function cookie(name) {
            //    var cookieArray = document.cookie.split("; "); //得到分割的cookie名值对   
            //    var cookie = new Object();
            //    for (var i = 0; i < cookieArray.length; i++) {
            //        var arr = cookieArray[i].split("=");       //将名和值分开   
            //        if (arr[0] == name) return unescape(arr[1]); //如果是指定的cookie，则返回它的值   
            //    }
            //    return "";
            //}
      
            //function delCookie(name)//删除cookie
            //{
            //    document.cookie = name + "=;expires=" + (new Date(0)).toGMTString();
            //}

            //function getCookie(objName) {//获取指定名称的cookie的值
            //    var arrStr = document.cookie.split("; ");
            //    for (var i = 0; i < arrStr.length; i++) {
            //        var temp = arrStr[i].split("=");
            //        if (temp[0] == objName) return unescape(temp[1]);
            //    }
            //}

            //function addCookie(objName, objValue, objHours) {      //添加cookie
            //    var str = objName + "=" + escape(objValue);
            //    if (objHours > 0) {                               //为时不设定过期时间，浏览器关闭时cookie自动消失
            //        var date = new Date();
            //        var ms = objHours * 3600 * 1000;
            //        date.setTime(date.getTime() + ms);
            //        str += "; expires=" + date.toGMTString();
            //    }
            //    document.cookie = str;
            //}

            //function SetCookie(name, value)//两个参数，一个是cookie的名子，一个是值
            //{
            //    var Days = 30; //此 cookie 将被保存 30 天
            //    var exp = new Date();    //new Date("December 31, 9998");
            //    exp.setTime(exp.getTime() + Days * 24 * 60 * 60 * 1000);
            //    document.cookie = name + "=" + escape(value) + ";expires=" + exp.toGMTString();
            //escape()方法用于 生成新的由十六进制转义序列替换的字符串，以废弃
            //现使用 encodeURI 或 encodeURIComponent 代替.
            //}
            //function getCookie(name)//取cookies函数       
            //{
            //    var arr = document.cookie.match(new RegExp("(^| )" + name + "=([^;]*)(;|$)"));
            //    if (arr != null) return unescape(arr[2]); return null;
            //}
            //function delCookie(name)//删除cookie
            //{
            //    var exp = new Date();
            //    exp.setTime(exp.getTime() - 1);
            //    var cval = getCookie(name);
            //    if (cval != null) document.cookie = name + "=" + cval + ";expires=" + exp.toGMTString
            //}

            //记住我
            //function aa() {
            //    //var bu = document.getElementById("btn1");
            //    //bu.click();
            //alert("!!!!!!!!");
            //}

            //$('#submit1').click(
            //        function (event) {
            //        var bu = document.getElementById("btn1");
            //        bu.click();
            //}

            //document.getElementById('#submit1').addEventListener('click',
            //    function () {
            //        var bu = document.getElementById("btn1");
            //        bu.click();
            //    });

            //$('#submit1').bind('click', function () {
            //    var bu = document.getElementById("btn1");
            //    bu.click();
            //});

            //$('#submit1').on('click', function () {
            //    var bu = document.getElementById("btn1");
            //    bu.click();
            //});
        </script>
    </form>
</body>
</html>
