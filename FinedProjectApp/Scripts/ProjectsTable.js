var JsUser = sessionStorage.getItem("UserName");
var apiUrl = "../api/Project/"; // + JsUser;
$.getJSON(apiUrl, { username: JsUser }).done(function (JSProjects) {
    var table = document.getElementById("myTable");
    JSProjects.forEach(function (project) {
        $("#myTable").append("<tr><td>" + "הסר" + "</td><td>" + project +  "</td></tr>");
    });
});



$("#AddBtn").click(function () {
    location.replace("../View/AddProject.html");
});