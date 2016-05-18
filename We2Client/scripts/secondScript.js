
function openCreateModal() {
    $('#createModal').modal({ show: true });
}



$(document).ready(function () {


    
    $('#create-btn').click(function () {
        $('#createModal').modal({ show: true });
        console.log("kommer hit");
    })


    //function openModal() {
    //    $('#createModal').modal('show');
    //}



  //  insertText();

    //function insertText() {
    //    document.getElementById('doc1').innerHTML = "Some text to enter";
    //}
    //view();
    //function view()
    //{
    //    CallService();
        

    //}        
    //function CallService() {
    //    $.ajax("/Web2Client/DocumentManagementService.asmx/View", {
    //        contentType: "application/x-www-form-urlencoded",
    //        type: "GET",
    //        data: "",
    //        dataType: "xml",
    //        error: function (data, status, err) {
    //            alert("Failed!! Error: " + err);
    //        },
    //        success: function (data) {
    //            var status = (data.firstChild.textContent);
    //            var users = jQuery.parseJSON(response.d);
    //            console.log(users.length);  // The number of entries
    //            console.log(users[0].Name); // The first user's name
    //            console.log(users[1].Name); // The first user's name
    //            console.log(list);
              

    //        }
    //    });



        //function CallService() {
        //        $.ajax("/Web2Client/DocumentManagementService.asmx/View", {
        //            contentType: "application/x-www-form-urlencoded",
        //            type: "GET",
        //            data: "",
        //           dataType: "json",
        //            error: function (data, status, err) {
        //                alert("Failed!! Error: " + err);
        //            },
        //            success: function (data) {

        //                console.log("success");

        //            }
        //        });

        //    }            
 
       



    }
    
  

    
);





