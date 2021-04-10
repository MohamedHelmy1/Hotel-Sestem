$(document).ready(function () {
    $("input[type='email']").blur(function () {
        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color":' #767676'});
        }
    });
    $("input[type='tel']").blur(function () {
        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
    $("input[type='datetime-local']").blur(function () {
        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
    $("select").blur(function () {
        if ($(this).val() == "") {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
    let $PassWord = $("#InputPass"),
        $ConfirmPassWord = $("#InputConfirmPass");
    $PassWord.blur(function () {

        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
    $ConfirmPassWord.blur(function () {

        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
    $("input[type='button']").click(function () {
        if ($ConfirmPassWord.val() != $PassWord.val()) {
        $ConfirmPassWord.css({ 'border-bottom-color': 'red' });
        $PassWord.css({ 'border-bottom-color': 'red' });
    } else{
        $ConfirmPassWord.css({ "border-bottom-color": ' #767676' });
        $PassWord.css({ "border-bottom-color": ' #767676' });
    }});

    $("#name").blur(function () {
        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
    $("#staff").blur(function () {
        if ($(this).val() == -1) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
    $("#salary").blur(function () {
        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
    $("#shift").blur(function () {
        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
    $("#cardtype").blur(function () {

        if ($(this).val()==-1) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
    $("#cardnumber").blur(function () {

        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
});