var userUrl = "../api/Users";
$.getJSON(userUrl).done(function (JSuser) {
    var table = document.getElementById("myTable");
    var rank = 1;
    JSuser.forEach(function (user) {
        $("#myTable").append("<tr><td>" + rank + "</td><td>" + user.UserName + "</td><td>" + user.Victories + "</td><td>" + user.Losses + "</td></tr>");
        rank++;
    });
});