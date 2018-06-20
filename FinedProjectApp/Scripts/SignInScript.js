


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
            apiUrl = "../api/Students/" + JsUser + "/" + JsPass ;
        }
        else
            apiUrl = "../api/ProjectDirectors/" + JsUser + "/" + JsPass;
        $.ajax({
            url: apiUrl,
            type: "GET",
            success: function (data, status, jqXHR) {
                alert("User signed in successfully");
                sessionStorage.UserName = ko.toJS(that.UserName);
                if (ko.toJS(that.selected) == "student") {

                    location.replace("../View/StudentPreference.html");
                }
                if (ko.toJS(that.selected) == "project manager") {

                    location.replace("../View/ProjectDirector.html");
                }
            },
            error: function (jqXHR, status, err) {
                alert(err);
            },
            
        })
       
    }; 
}
ko.applyBindings(new AppViewModel());