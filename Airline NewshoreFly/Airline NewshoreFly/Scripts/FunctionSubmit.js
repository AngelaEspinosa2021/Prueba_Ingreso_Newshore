$(document).ready(function () {
    $('.frm').submit(function (e) {
        e.preventDefault();

        url = "/Flight/Find"
        parametro = $(this).serialize();

        $.post(url, parametro, function (data) {
            if (data === 0) {
                alert(data);
            }
            else {
                console.log(data);
            }
        })
    })
});

