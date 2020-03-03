function AjaxPostData(URL, DATA, statusCode) {
    $.ajax({
        url: URL,
        data: DATA,
        type: "POST",
        statusCode: statusCode
    });
}