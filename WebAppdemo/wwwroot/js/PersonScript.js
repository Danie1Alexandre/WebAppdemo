function getPersonList() {
    $.get("/Ajax/GetPeople", null, function (data){
        $("#personList").html(data);
    })

}

function getPersonByID() {
    var personIdValue = document.getElementById('PersonIdInput').value;
    $.post("/Ajax/FindPersonById", { id: personIdValue }, function (data) {
        $("#personList").html(data);
    });
}

function deletePersonByID() {
    var personIdValue = document.getElementById('PersonIdInput').value;
    $.post("/Ajax/DeletePersonById", { id: personIdValue }, function (data) {

    })
        .done(function () {
            document.getElementById('errorMessages').innerHTML = "Successfully removed Person from list.";
            getPersonList();
        })
        .fail(function () {
            document.getElementById('errorMessages').innerHTML = "Could not remove person from list.";
        });

}
