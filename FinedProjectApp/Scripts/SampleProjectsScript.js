





function AppViewModel() {
    var that = this;

    this.Proj1score = ko.observable("");
    this.Proj2score = ko.observable("");
    this.Proj3score = ko.observable("");
    this.Proj4score = ko.observable("");
    this.Proj5score = ko.observable("");
    this.Proj6score = ko.observable("");
   
    this.NextBtn = function () {
        var JsUser = sessionStorage.getItem("UserName");
        var JsProj1score = ko.toJS(this.Proj1score);
        var JsProj2score = ko.toJS(this.Proj2score);
        var JsProj3score = ko.toJS(this.Proj3score);
        var JsProj4score = ko.toJS(this.Proj4score);
        var JsProj5score = ko.toJS(this.Proj5score);
        var JsProj6score = ko.toJS(this.Proj6score);
       
        
        

        var JsonData = {
            "UserName": JsUser,
            "Results": JSON.stringify(JsProj1score, JsProj2score, JsProj3score, JsProj4score, JsProj5score, JsProj6score)

        };
        var apiUrl = "../api/StudentPrefs/SampleResults";
        $.post(apiUrl, JsonData).done(function (item) {
            alert("User registered successfully");
            location.replace("../View/StudentPreference.html");
        }).fail(function (jqXHR, status, errorThrown) {
            // if wrong arguments
            if (errorThrown === "BadRequest") {
                alert('Wrong details');
            }
            else {
                alert('Failed to send request to server');
            }

        });

    };


}

ko.applyBindings(AppViewModel);

