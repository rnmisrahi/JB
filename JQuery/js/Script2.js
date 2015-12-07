var n;
 
$("#one").click(function () {
    add();
});

function add(e) {
    n = $("#one").text();
    var m = Number(n);
    m = m + 1;
    $("#one").text(m);
}


