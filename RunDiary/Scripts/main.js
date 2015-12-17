$("#date").datepicker();


$(document).ready(function () {

    // page is now ready, initialize the calendar...

    $('#calendar').fullCalendar({
        // put your options and callbacks here
    })

});



$("#addRun").on("click", function (e) {
    var runToAdd = {};
    e.preventDefault();
    console.log("you clicked it!!");

    //grab values from form and store in object
    runToAdd = {
        RunName: $("#runName").val(),
        RunDate: $("#date").val(),
        runDistance: $("#runDistance").val(),
        distanceUnits: $("#distanceUnits").val(),
        runTime: $("#runTime").val(),
        RunPlace: $("#runPlace").val(),
        photo: $("#photo").val(),
        isRace: $("#isRace").val(),
        diaryEntry: $("#diaryEntry").val()
    };

    runToAdd = JSON.stringify(runToAdd);

    console.log(runToAdd);

    $.ajax({
        url: "/api/AddRun",
        method: "POST",
        contentType: "application/json;charset=utf-8",
        data: runToAdd,
        success: function (data) {
            console.log("success", data);
        },
        error: function (error) {
        console.log("error", error);
        }
     });

     
});