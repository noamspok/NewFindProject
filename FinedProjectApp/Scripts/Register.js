

ko.validation.rules['mustEqual'] = {
    validator: function (val, otherVal) {
        return val === otherVal;
    },
    message: "Passwords don't match!"
};

ko.validation.registerExtenders();

function AppViewModel() {
    var that = this;
    this.UserName = ko.observable("").extend({ required: { message: "Please enter a UserName" } });
    this.Password = ko.observable("").extend({ required: { message: "Please enter your Password" } });
    this.Password2 = ko.observable("").extend({
        required: { message: "Passwords don't match!" },
        mustEqual: that.Password

    });
    this.Email = ko.observable("").extend({ required: { message: "Please enter your Password" } });
    this.Options = ko.observableArray(["student", "project manager"]);
    this.selected = ko.observable("");
    this.RegBtn = function () {
        var JsUser = ko.toJS(this.UserName);
        var JsPass = ko.toJS(this.Password);
        var JsEmail = ko.toJS(this.Email);
        var JsonData = {
            "UserName": JsUser,
            "Password": JsPass,
            "Email": JsEmail
        };
        var apiUrl = "../api/Registry";
        $.post(apiUrl, JsonData).done(function (item) {
            alert("נרשמת בהצלחה");
            sessionStorage.loggedInUser = ko.toJS(that.UserName);
        }).fail(function (jqXHR, status, errorThrown) {
            // if wrong arguments
            if (errorThrown == "BadRequest") {
                alert('Wrong details');
            }
            // if the user already exist
            else if (errorThrown == "Conflict") {
                alert('Username already exist');
            }
            else {
                alert('Failed to send request to server');
            }

        });

    };

    this.isFormValid = ko.computed(function () {

        return this.Password() && this.Password2() && this.UserName() && this.Email() && this.Password2.isValid();
    }, this);
}

ko.applyBindings(new AppViewModel());