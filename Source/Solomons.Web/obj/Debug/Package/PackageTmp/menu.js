$(document).ready(function () {

    $("#homeli").hover(function () {


        $("#homeimg").hide();
        $("#homeimgact").stop(true, true).fadeIn('slow');

    }, function () {

        $("#homeimgact").hide();
        $("#homeimg").stop(true, true).fadeIn('slow');
        setHighlight();

    });

    $("#sararli").hover(function () {
        $("#sararimg").hide();
        $("#sararimgact").stop(true, true).fadeIn('slow');

    }, function () {
        $("#sararimg").stop(true, true).fadeIn('slow');
        $("#sararimgact").hide();
        setHighlight();

    });



    $("#bossli").hover(function () {
        $("#bossimg").hide();
        $("#bossimgact").stop(true, true).fadeIn('slow');

    }, function () {
        $("#bossimg").stop(true, true).fadeIn('slow');
        $("#bossimgact").hide();
        setHighlight();

    });



    $("#storeli").hover(function () {

        $("#storeimg").hide();
        $("#storeimgact").stop(true, true).fadeIn('slow');
        setHighlight();

    }, function () {
        $("#storeimg").stop(true, true).fadeIn('slow');
        $("#storeimgact").hide();
        setHighlight();
    });




    $("#contactli").hover(function () {

        $("#contactimg").hide();
        $("#contactimgact").stop(true, true).fadeIn('slow');

    }, function () {
        $("#contactimg").stop(true, true).fadeIn('slow');
        $("#contactimgact").hide();
        setHighlight();
    });



    $("#aboutli").hover(function () {


        $("#aboutimg").hide();
        $("#aboutimgact").stop(true, true).fadeIn('slow');

    }, function () {
        $("#aboutimg").stop(true, true).fadeIn('slow');
        $("#aboutimgact").hide();
        setHighlight();

    });

    $('#slideshow').innerfade({
        speed: 5000,
        timeout: 6500,
        type: 'sequence',
        containerheight: '556px'
    });

    setHighlight();
    function setHighlight() {
        var url = window.location.pathname;
        //alert(url); 
        var pageset = false;

        if (url.indexOf("default") > -1) {
            $("#homeimg").hide();
            $("#homeimgact").stop(true, true).fadeIn('slow');
            pageset = true;
        }

        if (url.indexOf("sar") > -1) {
            $("#sararimg").hide();
            $("#sararimgact").stop(true, true).fadeIn('slow');
            pageset = true;
        }

        if (url.indexOf("boss") > -1) {
            $("#bossimg").hide();
            $("#bossimgact").stop(true, true).fadeIn('slow');
            pageset = true;
        }

        if (url.indexOf("contact") > -1) {
            $("#contactimg").hide();
            $("#contactimgact").stop(true, true).fadeIn('slow');
            pageset = true;
        }
        if (url.indexOf("about") > -1) {
            $("#aboutimg").hide();
            $("#aboutimgact").stop(true, true).fadeIn('slow');
            pageset = true;
        }
    }
});