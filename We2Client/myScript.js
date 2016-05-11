
$(document).ready(function () {
    var btn_app = document.getElementById("my_btn");
    var modal = document.getElementById("myModal");
    var tryGetAppId = 1;
    var startButton = document.getElementById('my_btn');

    var random_id = Math.floor(Math.random() * 100000000000000) + 100;

    promptInstall();
    function promptInstall() {
        $('#startModal').modal({ show: true });
    }

    function setCookie(cname, cvalue) {
        var d = new Date();
        d.setTime(d.getTime() + ( 365 * 24 * 60 * 60 * 1000));
        var expires = "expires=" + d.toUTCString();
        var statusCookie= document.cookie = cname + "=" + cvalue + "; " + expires;
        console.log(statusCookie);
    }


    $('.installed').click(function () {
        setCookie("status", "installedinne");
        //var statusCookie = document.cookie = "status = installed";
 
    });


  




    $('#modal-install').click(function () {
        var statusCookie = document.cookie = "status = not installed";
        console.log(statusCookie);
    });


    //$('#modal-close-btn-2').click(function () {
    //    document.cookie = "status = installed";
    //});



    function setStatus() {
        try {
            window.location.assign("client2web:aliveId=" + random_id);
        }
        catch (err) {
            showModal()
        }
    }

    $('#my_btn').click(function () {
        setStatus();
    });


    startButton.onclick = function () {
        var runCode = setInterval(function () {
            if (tryGetAppId <= 1) {
                ($.ajax("/Web2Client/w2cService.asmx/getValue", {
                    contentType: "application/x-www-form-urlencoded",
                    type: "POST",
                    data: "id=" + random_id,
                    error: function (data, status, err) {
                        alert("Failed!! Error: " + err);
                    },
                    success: function (data) {
                        var status = (data.firstChild.textContent);
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
//Test
    $('#close-btn').click(function () {
        $('#myModal').modal('hide');
        redirectToApp();
    });

//slut på test
    function showModal() {
        $('#myModal').modal({ show: true });
    }

    //function close_and_redirect() {
    //    $('#myModal').modal('hide');
    //    redirectToApp();
    //}

    function redirectToApp() {
        window.location.href = "commandClient.aspx"
    }

    function redirectToInstall() {
        window.location.href = "promptdownload.aspx"
    }

    function hideModal() {
        document.getElementById("myModal").style.display.none;
    }

});
