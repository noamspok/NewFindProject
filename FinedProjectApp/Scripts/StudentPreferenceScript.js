



ko.validation.registerExtenders();

function AppViewModel() {
    var that = this;
    
    this.reserchOptions = ko.observableArray(["תעשיה", "מחקר", "לא משנה"]);
    this.GroupOptions = ko.observableArray(["1", "2", "3", "4","לא משנה"]);
    this.selectedReserch = ko.observable("");
    this.ProjectOptions = ko.observableArray([]);
    this.selectedGroup = ko.observable("");
    this.selectedLang = ko.observable("");
    this.codeLang = ko.observableArray([]);

    

    this.SubmitBtn = function () {
        var JsUser = sessionStorage.getItem("UserName");
        var JsselectedReserch = ko.toJS(this.selectedReserch);
        var JsselectedLocation = ko.toJS(this.Location);
        var JsselectedGroup = ko.toJS(this.selectedGroup);
        var JsProjectOptions = ko.toJS(this.ProjectOptions);
        var JsFavoriteLang = ko.toJS(this.codeLang);

        var JsonData = {
            "UserName": JsUser,
            "FieldOfProject": JsselectedReserch,
            "GroupSize": JsselectedGroup,
            "KindOfProject": JSON.stringify(JsProjectOptions),
            "FavoriteLang": JSON.stringify(JsFavoriteLang),
            
        };
        var apiUrl = "../api/StudentPrefs";
        $.post(apiUrl, JsonData).done(function (item) {
            alert("Preferences registered successfully");
            location.replace("../View/SampleProjects.html");
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

