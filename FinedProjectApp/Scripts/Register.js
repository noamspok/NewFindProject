

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


        sessionStorage.UserName = ko.toJS(that.UserName);

        if (ko.toJS(this.selected) === "student") {
            sessionStorage.Password = ko.toJS(that.Password);
            sessionStorage.Email = ko.toJS(that.Email);
            location.replace("../View/Student.html");
        } else {
            var JsUser = ko.toJS(this.UserName);
            var JsPass = ko.toJS(this.Password);
            var JsEmail = ko.toJS(this.Email);
            var JsonData = {
                "UserName": JsUser,
                "Password": JsPass,
                "Email": JsEmail

            };

            var apiUrl = "../api/ProjectDirectors"; 
            $.post(apiUrl, JsonData).done(function (item) {
                alert("User registered successfully");
                location.replace("../View/ProjectDirector.html");
            }).fail(function (jqXHR, status, errorThrown) {
                // if wrong arguments
                if (errorThrown === "BadRequest") {
                    alert('Wrong details');
                }
                else {
                    alert(errorThrown);
                }

            });

        }

    };

    this.isFormValid = ko.computed(function () {

        return this.Password() && this.Password2() && this.UserName() && this.Email() && this.Password2.isValid();
    }, this);
}

ko.applyBindings(new AppViewModel());