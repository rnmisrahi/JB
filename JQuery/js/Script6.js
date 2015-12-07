//.      הגדר דינמית  30 דיבים, עבןר הזוגיים צבע הרקע יהיה לבן , עבור האיזוגיים שחור.קליק על הזוגיים יחליף את הצבעים . יש להשתמש בaddClass   ו  removeClass


$(window).ready(function () {
    for (k = 0; k < 30; k++) {
        var idkP1 = 'id' + (k + 1).toString();
        var a = $("body").append('<div id="' + idkP1 + '">' + idkP1 + '</div>');
        addClicks(k + 1);
        //addFades(k + 1);
    }
    
    $("div:odd").addClass("blackBackground");
    $("div:even").addClass("whiteBackground");
});

addClicks = function (k) {
    var s = "#id" + k.toString();
    $(s).click(function () {

        var n = $("div").index($(s));
        if ((n % 2) == 1) {//odd
            $("div:odd").removeClass("blackBackground");
            $("div:even").removeClass("whiteBackground");
            $("div:odd").addClass("whiteBackground");
            $("div:even").addClass("blackBackground");
        }
        else {
            $("div:odd").removeClass("whiteBackground");
            $("div:even").removeClass("blackBackground");
            $("div:odd").addClass("blackBackground");
            $("div:even").addClass("whiteBackground");
        }
        console.log(n);

        //console.log($(s).index());
    });
};

addFades = function (k) {
    var s = "#id" + k.toString();
    $(s).fadeOut(3000);
};




       