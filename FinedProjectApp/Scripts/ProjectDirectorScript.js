



ko.validation.registerExtenders();

function AppViewModel() {
    var that = this;
    
    this.PName = ko.observable("").extend({ required: { message: "אנא מלא/י את שם הפרוייקט" } });
    this.GroupOptions = ko.observableArray(["1", "2", "3", "4"]);
    this.reserchOptions = ko.observableArray(["תעשיה", "מחקר"]);
    this.ProjectOptions = ko.observableArray([]);
    
    this.selectedGroup = ko.observable("");  

    this.selectedReserch = ko.observable("");
    this.Location = ko.observableArray([]);
    this.codeLang = ko.observableArray([]);
    
    this.courses = ko.observableArray([]);
    
    this.pdf = ko.observable("");
    
    

    this.StartBtn = function () {
        var JsUser = "1"//sessionStorage.getItem("UserName");
        var JsPName = ko.toJS(this.PName);
        var JsFName = ko.toJS(this.FName);
        var JsselectedLocation = ko.toJS(this.Location);
        var JsselectedReserch = ko.toJS(this.selectedReserch);
        var JsProjectOptions = ko.toJS(this.ProjectOptions);
        var JsselectedGroup = ko.toJS(this.selectedGroup);

        var JscodeLang = ko.toJS(this.codeLang);
        
        var Jstechnology = ko.toJS(this.courses);
       
        var Jspdf = "3"//ko.toJS(this.pdf);
        var Jsemail = "2"//sessionStorage.getItem("Email");
        var Jspassword = "3"//sessionStorage.getItem("Password");
        
        var JsonData = {
            "UserName": JsUser,
            "Password": Jspassword,
            "Email": Jsemail,
            "ProjectName": JsPName,
            "Location": JsselectedLocation,
            "FieldOfProject": JsselectedReserch,
            "KindOfProject":JsProjectOptions,
            "ProgrammingLanguage": JscodeLang,
            "Courses": Jstechnology,
            "GroupSize": JsselectedGroup,
            "ProjectDescriptionFile": Jspdf
        };

        var apiUrl = "../api/ProjectDirectors";
        $.post(apiUrl, JsonData).done(function (item) {
            alert("User registered successfully");
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

