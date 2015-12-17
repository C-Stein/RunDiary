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
        RunDistance: $("#runDistance").val(),
        DistanceUnits: $("#distanceUnits").val(),
        RunTime: $("#runTime").val(),
        RunPlace: $("#runPlace").val(),
        Photo: $("#photo").val(),
        IsRace: $("#isRace").val(),
        DiaryEntry: $("#diaryEntry").val()
    };

    if(runToAdd.RunDate > "1/1/0001") {
        runToAdd = JSON.stringify(runToAdd);

        console.log(runToAdd);
        console.log(date, $("#date").val());

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
} else {
       alert("You MUST enter in a date in order to add a run");
}

     
});