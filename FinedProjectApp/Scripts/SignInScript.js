


function AppViewModel() {
    var that = this;
    this.UserName = ko.observable("").extend({ required: { message: "Please enter a UserName" } });
    this.Password = ko.observable("").extend({ required: { message: "Please enter your Password" } });
    this.Options = ko.observableArray(["student", "project manager"]);
    this.selected = ko.observable("");
    this.RegBtn = function () {
        var JsUser = ko.toJS(this.UserName);
        var JsPass = ko.toJS(this.Password);
        var JsonData = {
            "UserName": JsUser,
            "password": Jspassword,
        };
        var apiUrl = "";
        if (ko.toJS(this.selected) == "student") {
            apiUrl = "../api/StudentSignIn";
        }
        else
            apiUrl = "../api/DirectorSignIn";
        $.post(apiUrl, JsonData).done(function (item) {
            alert("User registered successfully");
            location.replace("../View/StudentPreference.html");
        }).fail(function (jqXHR, status, errorThrown) {
            // if wrong arguments
            if (errorThrown == "BadRequest") {
                alert('Wrong details');
            }
            else {
                alert('Failed to send request to server');
            }

        });
    };

    
}

ko.applyBindings(new AppViewModel());