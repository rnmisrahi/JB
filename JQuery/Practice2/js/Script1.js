// JavaScript source code

$(window).ready(function () {
    exercise1();
    //exercise2();
    //exercise3();
    //exercise4();
    //exercise5();
});


addAlert = function (s) {
    $("#" + s).click(function () {
        alert(s);
    });
};

createDiv = function (root, k) {
    var idkP1 = 'id' + (k + 1).toString();
    var a = $("#" + root).append('<div id="' + idkP1 + '">' + idkP1 + '</div>');
    return idkP1;
}

/* Create 50 divs and add click events to each line
   on click, show the div number */
exercise1 = function () {
    for (k = 0; k < 50; k++) {
        var x = createDiv("Exercise1", k);
        addAlert(x);
    }
}

nestDivs=function(newDiv1, newDiv2){
    $(newDiv2).click(function () {
        $(newDiv1).addClass("frame");
    });
}

/* Add 10 divs, one the child of the previous one.
   Each click will draw the frame of the next(child) div */
exercise2 = function () {
    var Div = $('<div/>', { 'id': 'd1' });
    $(Div).text("Div 1");
    $(Div).appendTo('#Exercise2');

    var newDiv;
    var s;
    var s1;
    for (var k = 1; k < 10; k++) {
        s = k.toString();
        s1 = (k + 1).toString();
        newDiv = $('<div/>', { 'id': 'd' + s1 });
        $(newDiv).text("Div " + s1);
        $(newDiv).appendTo('#d' + s);
        nestDivs(Div, newDiv);
        Div = newDiv;
    }
}

yellowBg = function (s) {
    $("#" + s).click(function () {
        $("#" + s).addClass("yellow");
    });
}

removeYellows = function(){
    for (k = 0; k < 50; k++) {
        var idkP1 = '#id' + (k + 1).toString();
        var bg = $(idkP1).css("background-color");
        if (bg == "rgb(255, 255, 0)"){ //Yellow is all red + all green
            $(idkP1).remove();
        }
    }
}

/* Add 50 divs. On click, set the background yellow. 
   After 30 seconds from the time the page got loaded, 
   the yellow divs will disappear as if they never existed (Remove) */
exercise3 = function () {
    for (k = 0; k < 50; k++) {
        var x = createDiv("Exercise3", k);
        yellowBg(x);
    }
    window.setTimeout(removeYellows, 30000);//Remove all divs with yellow background after 30 seconds
}

/* Menu - Create a Div with the word Cities.
    When the mouse hovers over the name, drop down 3 Divs with names of cities
    When the mouse leaves the area, the 3 Divs disappear */
exercise4 = function () {
    $("#citydrop").hide();
    $("#cityclick").mouseover(function () {
        $("#citydrop").slideDown('slow');
    });
    $("#wrapper").mouseleave(function () {
        $("#citydrop").slideUp('slow');
    });
}


/* Continuation of Exercise 4:
    When we click on a name, the city's website opens */
exercise5 = function () {
    $("#jerusalem").click(function () {
        window.open("https://www.jerusalem.muni.il/");
    });
    $("#telaviv").click(function () {
        window.open("http://www.tel-aviv.gov.il/");
    });
    $("#haifa").click(function () {
        window.open("http://www.haifa.muni.il/");
    });
}

       