var JsUser = sessionStorage.getItem("UserName");
var apiUrl = "../api/Project/"; // + JsUser;
$.getJSON(apiUrl, { username: JsUser }).done(function (JSProjects) {
    var table = document.getElementById("myTable");
    var rank = 1;
    JSProjects.forEach(function (project) {
        $("#myTable").append("<tr><td>" + rank + "</td><td>" + project.project + "</td><td>" + user.Victories + "</td><td>" + user.Losses + "</td></tr>");
        rank++;
    });
});



$("#AddBtn").click(function () {
    location.replace("../View/AddProject.html");
});