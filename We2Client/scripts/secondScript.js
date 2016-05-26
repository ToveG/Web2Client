
function openCreateModal() {
    $('#createModal').modal({ show: true });
}

function setHiddenField() {
    var newFileName, text;
    newFileName = document.getElementById("TextBox2").value;
    if (newFileName == " " || newFileName == null) {
        text = "Du har inte angivit ett gilltigt filnamn. Vänligen försök igen.";
    }
    else {
        text = " ";
        var setValue = document.getElementById('valueOfNewDocumentName').value = newFileName;
    }
    document.getElementById("inputFeedback").innerHTML = text;
}

function renameDocument(data) {
    $('#renameModal').modal({ show: true });
}

$("#TextBox2").change(function () {
    setHiddenField();
});

$(document).ready(function () {
    $('#myTable tbody tr #Button1').on('click', function (e) {
        var rowIndex = $(this).closest('td').parent()[0].sectionRowIndex;
        var valueOfTd = $("#myTable > tbody").find("tr:eq(" + rowIndex + ")").find('td:eq(1)').text();
        var setHiddenValue = document.getElementById('valueOfClickedDocument').value = valueOfTd;

        renameDocument();
    });

    $('#myTable tbody tr #download-document').on('click', function (e) {
        var rowIndex = $(this).closest('td').parent()[0].sectionRowIndex;
        var valueOfTd = $("#myTable > tbody").find("tr:eq(" + rowIndex + ")").find('td:eq(1)').text();
        var newtest = valueOfTd.split(' ').join('{');
     
        test = window.location.href = "client2web:" + "download" + newtest;
    });

    $('#create-btn').click(function () {
        $('#createModal').modal({ show: true });
    })
}
);





