$(document).ready(function () {
    var btn_app = document.getElementById("my_btn");
    var modal = document.getElementById("myModal");
    var tryGetAppId = 1;
    var startButton = document.getElementById('my_btn');
    
    var random_id = Math.floor(Math.random() * 100000000000000) + 100;//id to verify that the application is installed

    checkCookie();

    // create cookie.
    function setCookie(cookie_name, cookie_value) {
        var d = new Date();
        d.setTime(d.getTime() + ( 365 * 24 * 60 * 60 * 1000));
        var expires = "expires=" + d.toUTCString();
        var statusCookie= document.cookie = cookie_name + "=" + cookie_value + "; " + expires;
    }
    
    $('#modal-close-btn-2').click(function () {
        $('#startModal').modal('toggle');
    });

    $('.install-app').click(function () {
        setCookie("installStatus", "Ok");
        $('#startModal').modal('toggle');
    });
  
    function getCookie(cookie_name) {
        var name = cookie_name + "=";
        var split_cookie = document.cookie.split(';');
        for (var i = 0; i < split_cookie.length; i++) {
            var c = split_cookie[i];
            while (c.charAt(0) == ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) == 0) {
                return c.substring(name.length, c.length);
            }
        }
        return "";
    }

    //cookie för att se om klienten finns installerad. 
    function checkCookie() {
        var app_status = getCookie("installStatus");
        if (app_status == "Ok") {
            $('#startModal').modal({ show: false });
        } else {
            $('#startModal').modal({ show: true });
            }
    }

    
    function setStatus() {
        try {
            window.location.assign("client2web:aliveId=" + random_id);  //call to protocol client2web: with parameter aliveId= random_id.
        }
        catch (err) {
            showModal()
        }
    }

    $('#my_btn').click(function () {
        setStatus();
    });

    //when user click on startbutton the script will check for applicationId in db, via webservice. 
    //the code will be run repetitively. 
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

    $('#close-btn').click(function () {
        $('#myModal').modal('hide');
        redirectToApp();
    });

    function showModal() {
        $('#myModal').modal({ show: true });
    }

     function redirectToApp() {
        window.location.href = "command.aspx"
    }

    function redirectToInstall() {
        window.location.href = "promptdownload.aspx"
    }

    function hideModal() {
        document.getElementById("myModal").style.display.none;
    }

});
