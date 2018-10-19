
function AppViewModel() {
    var that = this;

    this.a = ko.observable("");
    this.b = ko.observable("");
    this.c = ko.observable("");
    this.d = ko.observable("");
    this.e = ko.observable("");

    this.NextBtn = function () {
        var JsUser = sessionStorage.getItem("UserName");
        var JsQ1 = ko.toJS(this.a);
        var JsQ2 = ko.toJS(this.b);
        var JsQ3 = ko.toJS(this.c);
        var JsQ4 = ko.toJS(this.d);
        var JsQ5 = ko.toJS(this.e);




        var JsonData = {
            "UserName": JsUser,
            "Q1": JsQ1,
            "Q2": JsQ2,
            "Q3": JsQ3,
            "Q4": JsQ4,
            "Q5": JsQ5
        };
        var apiUrl = "../api/Survey";
        $.post(apiUrl, JsonData).done(function (item) {
            alert("תשובתך נשמרה");
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

