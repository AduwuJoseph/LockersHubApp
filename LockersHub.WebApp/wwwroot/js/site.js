// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$('.select2').select2();

function showResult(str) {

    if (str.length == 0) {
        document.getElementById("livesearch").innerHTML = "";
        document.getElementById("livesearch").style.border = "0px";
        return;
    }
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("livesearch").innerHTML = this.responseText;
            document.getElementById("livesearch").style.border = "1px solid #A5ACB2";
        }
    }
    var url = "https://lockershub.azurewebsites.net/api/Lockers/";
    xmlhttp.open("GET", url + "SearchlockerByCityOrState2?id=" + str , true);
    xmlhttp.send();
    Load("/locker/GetLockersBySearch?apiUrl=" + url+ "SearchlockerByCityOrState/id=" + str);
}

$(document).on('click', '[data-toggle="tab"]', function (event) {
    event.preventDefault();
    var url = $(this).data('url');
    Load(url);
});

function Load(url) {
    //alert(url);
    $('#home').load(url, function () {
    });
}
