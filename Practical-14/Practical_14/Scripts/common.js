$(document).ready(function () {

    $("#searchBox").keyup(function () {
        var value = $(this).val();

        $.ajax({
            url: '/Employee/Search',
            type: 'GET',
            data: { name: value, page: 1 },
            success: function (data) {
                $("#tableBody").html(data);
            },
            error: function () {
                console.log("AJAX error");
            }
        });

    });

});

$(document).on("click", ".page-number", function (e) {
    e.preventDefault();

    var page = $(this).data("page");

    $.ajax({
        url: '/Employee/Index',
        type: 'GET',
        data: { page: page },
        success: function (data) {
            $("#tableBody").html(data);
        },
        error: function () {
            console.log("Pagination error");
        }
    });
});