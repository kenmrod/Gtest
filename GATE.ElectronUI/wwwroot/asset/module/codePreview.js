
(function ($) {

    //const { ipcRenderer } = require("electron");

    //var elms = document.getElementsByClassName("nav-button")
    //for (i = 0; i < elms.length; i++) {
    //    elms.item(i).addEventListener("click", () => {
    //        var target = event.target;
    //        var file = target.innerHTML;
    //        ipcRenderer.send("preview-code", file);
    //    });
    //}

    //ipcRenderer.on("preview-code-text-reply", (event, data) => {
    // document.getElementById("script-title").innerHTML = data;
    //});

    
    $('.testrun-filename').on('click', function () {
        var testRunFileName = $(this).text();
        var testRunFilePath = $(this).attr("filepath");

        $('#script-title').empty();
        $('#script-title').text(testRunFileName);

        $.ajax({
            type: 'POST',
            url: "Core/GetFileContent/",
            data: {'FilePath' : testRunFilePath},
            success: function (data) {
                $('#code-text').text(data);
            },
            error: function() {
                $('#code-text').text("Unable to retrieve file content.");
            },
        });
    });
}(jQuery));