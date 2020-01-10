function getCookie(name) {
    var r = document.cookie.match("\\b" + name + "=([^;]*)\\b");
    return r ? r[1] : undefined;
}

$(function(){
    $(".news_edit").submit(function (e) {
        e.preventDefault()
//        描述: 如果调用这个方法，默认事件行为将不再触发。
//        添加的版本: 1.0event.preventDefault()
//        这个方法不接受任何参数。
//        例如，在执行这个方法后，如果点击一个链接（a标签），浏览器不会跳转到新的 URL 去了。
//        可以用 event.isDefaultPrevented() 来确定这个方法是否(在那个事件对象上)被调用过了。
        // TODO 新闻编辑提交
    })
})

// 点击取消，返回上一页
function cancel() {
    history.go(-1)
}