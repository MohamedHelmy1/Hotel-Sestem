$(document).ready(function () {
    $(window).resize(function () {
        $(".list").height($(window).height());
    });
    let Arr = [$("#Input1"), $("#Input2"), $("#Input3"), $("#Input4"), $("#Input5"), $("#Input6"), $("#Input7"), $("#Input8"), $("#Input9"), $("#Input10")];

    $("#Add").click(function () {
        var index = 1;
        for (let i of Arr) {
            if (i.val() == null || i.val().length == 0) {
                $(`#V-${index}`).show()
            } else {
                $(`#V-${index}`).hide();

            }
            index++;
        }
        //$('.Add').append(
        //                 <tr>
        //                    <td>${$("#Input1").val() + $("#Input2").val()}</td>
        //                    <td>${$("#Input9").val()}</td>
        //                    <td>${$("#Input3").val()}</td>
        //                    <td>${$("#Input7").val() +" "+ $("#Input8").val()}</td>
        //                    <td>${$("#Input10").val()}</td>
        //                </tr>
        //              );
    });







})