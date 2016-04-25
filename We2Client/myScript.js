
//$(document).ready(function () {
var btn_app = document.getElementById("my_btn");
var modal = document.getElementById("myModal");



    function checkAppStatus() {
        $.ajax("/Web2Client/w2cService.asmx/getValue", {
            contentType: "application/x-www-form-urlencoded",
            type: "POST",
            data: '',
            error: function (data) {
                console.log("error: " + data);
                //redirectToInstall();
                //showModal(modal);


            },
            success: function (data) {
                var status = (data.firstChild.textContent);
                console.log("success:" + status);


                if (status == "true") {
                    redirectToApp();

                    
                 

                }
                else if (status == "false") {
                    //redirectToInstall();
                    $('#myModal').modal('show');
                }
            }
        });
    }


    function close_and_redirect() {
        $('#myModal').modal('hide');
         redirectToApp();
        }

    function redirectToApp() {
        window.location.href = "commandClient.aspx"
    }

    function redirectToInstall() {
        window.location.href = "promptdownload.aspx"
    }

    function hideModal() {
        document.getElementById("myModal").style.display.none;
    }


    