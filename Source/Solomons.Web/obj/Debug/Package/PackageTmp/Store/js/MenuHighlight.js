
$(document).ready(function () {
    $(".menuClass").hover(function () {

        var parentLi = $(this).parent();
        $(this).css("color", "white");
        var bgimage = "images/menu-hover-bg.png";
        $(parentLi).css("background-image", 'url("'+bgimage+'")');
    }, function () {
        var parentLi = $(this).parent();
        $(this).css("color", "#666666");
        parentLi.css("background-image", "");

    });
}); 