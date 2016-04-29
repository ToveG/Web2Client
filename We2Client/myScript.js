
//$(document).ready(function () {
var btn_app = document.getElementById("my_btn");
var modal = document.getElementById("myModal");



function checkAppStatus() {

    var random_id = Math.floor(Math.random() * 100000000000000) + 100;
    window.location.href = "client2web:aliveId=" + random_id;
   // appId = random_id + "&";

       $.ajax("/Web2Client/w2cService.asmx/getValue", {
        contentType: "application/x-www-form-urlencoded",
        type: "POST",
        data: "id=" + random_id ,          
        error: function (data, status, err) {
                alert("Failed!!");
            },
            success: function (data) {
                var status = (data.firstChild.textContent);
                console.log("success:" + status);
                console.log(status);
                if (status == "true") {
                 //   redirectToApp();
                }
                else if (status == "false") {
                    console.log("false");
                //    //redirectToInstall();
                //    $('#myModal').modal('show');
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


    