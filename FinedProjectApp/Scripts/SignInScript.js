


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
            "password": JsPass,
        };
        var apiUrl = "";
        if (ko.toJS(this.selected) == "student") {
            apiUrl = "../api/GetStudent/" + JsUser + "/" + JsPass ;
        }
        else
            apiUrl = "../api/GetDirector/" + JsUser + "/" + JsPass ;
        $.Get(apiUrl, JsonData).done(function (item) {
            alert("User signed in successfully");
            if (ko.toJS(this.selected) == "student") {
                location.replace("../View/StudentPreference.html");
            }
            location.replace("../View/ProjectDirector.html");
        }).fail(function (jqXHR, status, errorThrown) {
            // if wrong arguments
           
                alert(errorThrown);
           

        });
    }; 
}
ko.applyBindings(new AppViewModel());