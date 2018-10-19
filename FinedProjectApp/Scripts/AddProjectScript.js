



ko.validation.registerExtenders();

function AppViewModel() {
    var that = this;
    
    this.PName = ko.observable("").extend({ required: { message: "אנא מלא/י את שם הפרוייקט" } });
    this.GroupOptions = ko.observableArray(["1", "2", "3", "4"]);
    this.reserchOptions = ko.observableArray(["תעשיה", "מחקר"]);
    this.ProjectOptions = ko.observableArray([]);
    this.avg = ko.observable("");
    this.selectedGroup = ko.observable("");  

    this.selectedReserch = ko.observable("");
 
    this.codeLang = ko.observableArray([]);
    
    this.courses = ko.observableArray([]);
    
    this.pdf = ko.observable("");
    
    

    this.StartBtn = function () {
        var JsUser = sessionStorage.getItem("UserName");
        var JsPName = ko.toJS(this.PName);
        var JsselectedReserch = ko.toJS(this.selectedReserch);
        var JsProjectOptions = ko.toJS(this.ProjectOptions);
        var JsselectedGroup = ko.toJS(this.selectedGroup);
        var JscodeLang = ko.toJS(this.codeLang);
        var Jstechnology = ko.toJS(this.courses);
        var Jspdf = ko.toJS(this.pdf);
        var Jsavg = ko.toJS(this.avg);
        var JsonData = {
            "UserName": JsUser,
            "ProjectName": JsPName,
            "FieldOfProject": JsselectedReserch,
            "KindOfProject":JsProjectOptions,
            "ProgrammingLanguage": JSON.stringify(JscodeLang),
            "Courses": JSON.stringify(Jstechnology),
            "GroupSize": JsselectedGroup,
            "ProjectDescriptionFile": Jspdf,
            "Avg": Jsavg
        };

        var apiUrl = "../api/Project";
        $.post(apiUrl, JsonData).done(function (item) {
            alert("User registered successfully");
            location.replace("../View/ProjectsTable.html");
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

