



ko.validation.registerExtenders();

function AppViewModel() {
    var that = this;
    
    this.IdNum = ko.observable("").extend({ required: { message: "אנא מלא/י את מס' תעודת הזהות שלך" }, number: true,min:9,max: 9 });
    this.PName = ko.observable("").extend({ required: { message: "אנא מלא/י את השם הפרטי שלך" } });
    this.FName = ko.observable("").extend({ required: { message: "אנא מלא/י את שם המשפחה שלך" } });
    this.Avg = ko.observable("").extend({ required: { message: "אנא מלא/י את מס' תעודת הזהות שלך" }, number: true });
    this.reserchOptions = ko.observableArray(["תעשיה", "מחקר","לא משנה"]);
    this.GroupOptions = ko.observableArray(["1", "2", "3", "4"]);
    this.selectedReserch = ko.observable("");
    this.selectedGroup = ko.observable("");  
    this.courses = ko.observableArray([]);
    this.codeLang = ko.observableArray([]);
    
    this.Location = ko.observableArray([]);
    
    this.StartBtn = function () {
        var JsUser = sessionStorage.getItem("UserName");
        var JsIdNum = ko.toJS(this.IdNum);
        var JsPName = ko.toJS(this.PName);
        var JsFName = ko.toJS(this.FName);
        var JsAvg = ko.toJS(this.Avg);
        var JsselectedReserch = ko.toJS(this.selectedReserch);
        var JsselectedLocation = ko.toJS(this.Location);
        
        var JsselectedGroup = ko.toJS(this.selectedGroup);
        
        var Jscourses = ko.toJS(this.courses);
        var JscodeLang = ko.toJS(this.codeLang);
        var Jsemail = sessionStorage.getItem("Email");
        var Jspassword = sessionStorage.getItem("Password");
        
        var JsonData = {
            "UserName": JsUser,
            "password": Jspassword,
            "Email": Jsemail,
            "FirstName": JsPName,
            "LastName": JsFName,
            "Id": JsIdNum,
            "Average": JsAvg,
            "Courses": Jscourses,
            "ProgrammingLanguage": JscodeLang,
            
        };
        var apiUrl = "../api/Students";
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

ko.applyBindings(AppViewModel);

