//Let's toggle the color from red to light blue
function changeColor(k) {
    var x = "#id" + k.toString();
    var c = $(x).css("background-color");
    if (c == "rgb(255, 0, 0)")//c contains the color
        $(x).css("background-color", "lightBlue");
    else
        $(x).css("background-color", "red");
}

//Declare the nodes that will be affected
var line = ["#id1", "#id2", "#id3", "#id4", "#id5", "#id6"];

//Associate a click event to each of the lines
// This works ok, but I found an easier way below...
//$(line[0]).click(function () {
//    changeColor(1);
//});
//$(line[1]).click(function () {
//    changeColor(2);
//});
//$(line[2]).click(function () {
//    changeColor(3);
//});
//$(line[3]).click(function () {
//    changeColor(4);
//});
//$(line[4]).click(function () {
//    changeColor(5);
//});
//$(line[5]).click(function () {
//    changeColor(6);
//});


//Let's toggle the color of an entry from red to light blue
function changeColors(entry) {
    var c = $(entry).css("background-color");
    if (c == "rgb(255, 0, 0)")//c contains the color
        $(entry).css("background-color", "lightBlue");
    else
        $(entry).css("background-color", "red");
}

//This loop works and is in my opinion more elegant
line.forEach(function (entry) {
    console.log(entry);
    $(entry).click(function () {
        changeColors(entry);
        //$(entry).css("background-color", "red");
    });
});



//This loop doesn't work. Still unclear why.
//var line = [];
//for (k = 0; k < 6; k++) {
//    //var kp1 = k + 1;
//    //line[k] = "#id" + kp1.toString();
//    $(line[k]).click(function () {
//        //changeColor(k + 1);
//    });
//}


       