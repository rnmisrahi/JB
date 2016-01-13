function evalf(val) {
    var length = document.all ? document.all[val.controltovalidate].value.length : document.getElementById(val.controltovalidate).value.length
    if (length < 4 || length > 8)
        return false;
    return true;
}

