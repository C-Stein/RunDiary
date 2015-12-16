$("#date").datepicker();






$("#addRun").on("click", function () {
    var runToAdd = {};

    console.log("you clicked it!!");

    //grab values from form and store in object
     runToAdd = {
        "runName": $("#runName").val(),
        "date": $("#date").val(),
        "runDistance": $("#runDistance").val(),
        "distanceUnits": $("#distanceUnits").val(),
        "runTime": $("#runTime").val(),
        "runPlace": $("#runPlace").val(),
        "photo": $("#photo").val(),
        "isRace": $("#isRace").val(),
        "diaryEntry": $("#diaryEntry").val()
    };

     runToAdd = JSON.stringify(runToAdd);

     console.log(runToAdd);

     $.ajax({
         url: "/api/AddRun",
         method: "POST",
         data: runToAdd
     }).done(function (addedRun) {
         console.log("addedRun", addedRun);
     }).fail(function (xhr, status, error) {
         deferred.reject(error);
     });

     
});