
//$(document).ready(function () {
var btn_app = document.getElementById("my_btn");
var modal = document.getElementById("myModal");
var tryGetAppId = 1;
var startButton = document.getElementById('my_btn');

var random_id = Math.floor(Math.random() * 100000000000000) + 100;

setStatus();

function setStatus() {
    window.location.href = "client2web:aliveId=" + random_id;
 //   console.log("skickar anropet");
}

startButton.onclick = function () {
      var runCode = setInterval(function () {
        if (tryGetAppId <= 1) {
                ($.ajax("/Web2Client/w2cService.asmx/getValue", {
                    contentType: "application/x-www-form-urlencoded",
                    type: "POST",
                    data: "id=" + random_id,
                    error: function (data, status, err) {
                        alert("Failed!!");
                    },
                    success: function (data) {
                        var status = (data.firstChild.textContent);
                        console.log(status);
                        if (status == "true") {
                            redirectToApp();
                        }
                    }
                }));
                tryGetAppId++;
            }
            else {
                clearInterval(runCode);
                showModal();
            }
        }, 1000);
}


function showModal() {
   
    $('#myModal').modal({show:true});
                    
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


