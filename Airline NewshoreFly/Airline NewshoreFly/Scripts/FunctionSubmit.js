$(document).ready(function () {
    $('.frm').submit(function (e) {
        e.preventDefault();

        url = "/Flight/Find"
        parametro = $(this).serialize();

        $.post(url, parametro, function (data) {
            if (data) {
                console.log(data);
            }
            else {
                alert(data)
            }
        })
    })
});