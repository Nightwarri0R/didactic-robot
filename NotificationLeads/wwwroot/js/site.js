// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function loadJsonData() {
    if ()
    var postdata = JSON.stringify(
        {
            "EmailAddress": document.getElementById("emailId").value
           

        });
    try {
        $.ajax({
            type: "POST",
            url: "https://localhost:3000",
            cache: false,
            data: postdata,
            dataType: "json",
            success: getSuccess,
            error: getFail
        });
    } catch (e) {
        alert(e);
    }
    function getSuccess(data, textStatus, jqXHR) {
        alert(data.Response);
    };
    function getFail(jqXHR, textStatus, errorThrown) {
        alert(jqXHR.status);
    };
};