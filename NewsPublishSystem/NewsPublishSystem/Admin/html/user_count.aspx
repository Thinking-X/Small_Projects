<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_count.aspx.cs" Inherits="NewsPublishSystem.Admin.html.user_count" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="../css/reset.css" />
    <link rel="stylesheet" type="text/css" href="../css/main.css" />
    <script type="text/javascript" src="../js/echarts.min.js"></script>
    <title>今日报资讯后台管理</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="breadcrub">
            当前位置：用户管理>用户统计

        </div>
        <div class="spannels">
            <div class="spannel scolor01">
                <em>36365</em><span>人</span>
                <b>用户总数</b>
            </div>
            <div class="spannel scolor02">
                <em>146</em><span>人</span>
                <b>用户月新增数</b>
            </div>
            <div class="spannel2 scolor03">
                <em>32</em><span>人</span>
                <b>用户日新增数</b>
            </div>
        </div>

        <div class="pannel">
            <div id="chart_show" class="chart_show"></div>
        </div>
        <script>
            var oChart = echarts.init(document.getElementById('chart_show'));
            var chartopt = {
                title: {
                    text: '用户登录活跃数',
                    left: 'center',
                    top: '10'
                },
                tooltip: {
                    trigger: 'axis'
                },
                legend: {
                    data: ['active'],
                    top: '40'
                },
                toolbox: {
                    show: true,
                    feature: {
                        mark: { show: true },
                        dataView: { show: true, readOnly: false },
                        magicType: { show: true, type: ['line', 'bar'] },
                        restore: { show: true },
                        saveAsImage: { show: true }
                    }
                },
                calculable: true,
                xAxis: [
                    {
                        name: '今天',
                        type: 'category',
                        boundaryGap: false,
                        data: ["00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "24:00"]
                    }
                ],
                yAxis: [
                    {
                        name: '活跃用户数量',
                        type: 'value'
                    }
                ],
                series: [
                    {
                        name: 'active',
                        type: 'line',
                        smooth: true,
                        itemStyle: { normal: { areaStyle: { type: 'default' }, color: '#f80' }, lineStyle: { color: '#f80' } },
                        data: [14951, 14861, 7186, 15861, 14951, 14861, 7186, 14951, 14861, 7186, 15861, 14951, 14951, 14861, 7186, 15861, 14951, 14861, 7186, 14951, 14861, 7186, 15861, 14951, 14951]
                    }],
                areaStyle: {
                    normal: {
                        color: new echarts.graphic.LinearGradient(0, 0, 0, 1, [{
                            offset: 0,
                            color: 'rgba(255,136,0,0.39)'
                        }, {
                            offset: .34,
                            color: 'rgba(255,180,0,0.25)'
                        }, {
                            offset: 1,
                            color: 'rgba(255,222,0,0.00)'
                        }])

                    }
                }
            };
            oChart.setOption(chartopt);
	</script>
    </form>
</body>
</html>
