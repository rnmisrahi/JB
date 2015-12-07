//Let's toggle the color from red to light blue

$("#id1").mouseover(function () {
    $("#id1").fadeOut(3000);
    //alert("Done"); //Interesting: The alert comes up immediately after fadeout, not 3 secs after it. Nevertheless, fadeIn 'waits' until fadeout end.
    $("#id1").fadeIn(3000);
});

       