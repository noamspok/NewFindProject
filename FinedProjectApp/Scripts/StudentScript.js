$("#btn_register").click(function () {
    var student = {
        userName: $("#userName").val(),
        Password: $("#Password").val(),
        Email: $("#Email").val(),
        JoinDate: 0,
        Victories: 0,
        Losses: 0
    };
    if (user.userName === "") {
        alert("user name is messing")
    }
    else if (user.Password === "") {
        alert("password is messing")
    }
    else if (user.Email === "") {
        alert("password is messing")
    } else {
        var userUrl = "../api/Users";
        $.post(userUrl, user).done(function () {
            alert("User added successfully");
            sessionStorage.setItem("userName", user.userName);
            location.replace("../View/HomePage.html");
        });
    }
});