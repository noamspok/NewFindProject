



ko.validation.registerExtenders();

function AppViewModel() {
    var that = this;
    this.UserName = ko.observable("").extend({ required: { message: "אנא מלא/י את שם המשתמש שלך" } });
    this.PName = ko.observable("").extend({ required: { message: "אנא מלא/י את השם הפרטי שלך" } });
    this.FName = ko.observable("").extend({ required: { message: "אנא מלא/י את שם המשפחה שלך" } });
    this.reserchOptions = ko.observableArray(["תעשיה", "מחקר", "לא משנה"]);
    this.amountDaysOptions = ko.observableArray(["פעם בשבוע", "פעמיים בחודש", "פעם בחודש", "פעם בחודשיים"]);
    this.Location = ko.observableArray([]);
    this.selectedReserch = ko.observable("");
    this.freeDays = ko.observableArray([]);
    this.codeLang = ko.observableArray([]);
    this.selectedAmountDays = ko.observable("");
    this.courses = ko.observableArray([]);
    this.freeText = ko.observable("");
    this.pdf = ko.observable("");
    
    

    this.StartBtn = function () {
        var JsUser = ko.toJS(this.UserName);
        var JsPName = ko.toJS(this.PName);
        var JsFName = ko.toJS(this.FName);
        var JsselectedLocation = ko.toJS(this.Location);
        var JsselectedReserch = ko.toJS(this.selectedReserch);
        var JsfreeDays = ko.toJS(this.freeDays);
        var JscodeLang = ko.toJS(this.codeLang);
        var JsselectedAmountDays = ko.toJS(this.selectedAmountDays);
        var Jstechnology = ko.toJS(this.courses);
        var JsfreeText = ko.toJS(this.freeText);
        var Jspdf = ko.toJS(this.pdf);
        var Jsemail = sessionStorage.getItem("Email");
        var Jspassword = sessionStorage.getItem("Password");
        
        var JsonData = {
            "UserName": JsUser,
            "Password": Jspassword,
            "Email": Jsemail,
            "FirstName": JsPName,
            "LastName": JsFName,
            "Location": JsselectedLocation,
            "FieldOfProject": JsselectedReserch,
            "FreeDays": JsfreeDays,
            "ProgrammingLanguage": JscodeLang,
            "AmountOfDays": JsselectedAmountDays,
            "Technology": Jstechnology,
            "ProjectDescription": JsfreeText,
            "ProjectDescriptionFile": Jspdf,
        };

        var apiUrl = "../api/ProjectDirectors";
        $.post(apiUrl, JsonData).done(function (item) {
            alert("User registered successfully");
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

    this.isFormValid = ko.computed(function () {

        return this.UserName.isValid();
    }, this);
}

ko.applyBindings(AppViewModel);

