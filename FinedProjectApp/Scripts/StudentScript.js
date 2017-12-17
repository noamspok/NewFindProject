



ko.validation.registerExtenders();

function AppViewModel() {
    var that = this;
    this.UserName = ko.observable("").extend({ required: { message: "אנא מלא/י את שם המשתמש שלך" } });
    this.IdNum = ko.observable("").extend({ required: { message: "אנא מלא/י את מס' תעודת הזהות שלך" }, number: true });
    this.PName = ko.observable("").extend({ required: { message: "אנא מלא/י את השם הפרטי שלך" } });
    this.FName = ko.observable("").extend({ required: { message: "אנא מלא/י את שם המשפחה שלך" } });
    this.Avg = ko.observable("").extend({ required: { message: "אנא מלא/י את מס' תעודת הזהות שלך" }, number: true });
    this.GenderOptions = ko.observableArray(["זכר", "נקבה"]);
    this.GroupOptions = ko.observableArray(["1", "2", "3", "4"]);
    this.ExpOptions = ko.observableArray(["ללא נסיון", "עד שנה", "1-2 שנים", "3-5 שנים","יותר מ-5 שנים"]);
    this.BirthOptions = ko.observableArray(["1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002"]);
    this.selectedBirth = ko.observable("");
    this.selectedGender = ko.observable("");
    this.selectedGroup = ko.observable("");
    this.selecteExp = ko.observable("");
    this.courses = ko.observableArray([""]);
    this.codeLang = ko.observableArray([""]);
    
        this.StartBtn = function () {
           
        };
    

    this.isFormValid = ko.computed(function () {

        return  this.UserName.isValid();
    }, this);
}

ko.applyBindings(AppViewModel);

