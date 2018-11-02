ko.bindingHandlers.fileUpload = {

    update: function (element, valueAccessor, allBindingsAccessor) {
        var value = ko.utils.unwrapObservable(valueAccessor())
        if (element.files.length && value) {
            var file = element.files[0];
            console.log(file)
            var url = allBindingsAccessor().url

            xhr = new XMLHttpRequest();
            xhr.open("post", url, true);
            xhr.setRequestHeader("Content-Type", "application/octet-stream");
            xhr.setRequestHeader("X-File-Name", file.name);
            xhr.setRequestHeader("X-File-Size", file.size);
            xhr.setRequestHeader("X-File-Type", file.type);
            xhr.setRequestHeader("X-Project-Name", sessionStorage.getItem("ProjectName"));
            console.log("sending")
            // Send the file (doh)
            xhr.send(file);
            location.replace("../View/ProjectsTable.html");
        }
    }
}


function MainPageViewModal() {
    this.fileName = ko.observable()
    this.url = "../api/File"
}

var mainPageViewModal = new MainPageViewModal()

ko.applyBindings(mainPageViewModal);
