$(document).ready(function () {
    var $Lable1 = $("#show1"),
        $Lable2 = $("#show2"),
        $Input1 = $("#Input1"),
        $Input2 = $("#Input2"),
        $Attr1 = $Input1.attr('placeholder'),
        $Attr2 = $Input2.attr('placeholder');
    $Input1.focus(function () {
        $Lable1.show();
        $(this).attr('placeholder', '');
    })
    $Input1.blur(function () {
        $Lable1.hide();
        $(this).attr('placeholder', $Attr1);
    })
    $Input2.focus(function () {
        $Lable2.show();
        $(this).attr('placeholder', '');
    })
    $Input2.blur(function () {
        $Lable2.hide();
        $(this).attr('placeholder', $Attr2);
    })
    $Input1.blur(function () {
        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    })
    $Input2.blur(function () {
        if ($(this).val().length == 0) {
            $(this).css({ 'border-bottom-color': 'red' });
        } else {
            $(this).css({ "border-bottom-color": ' #767676' });
        }
    });
});
