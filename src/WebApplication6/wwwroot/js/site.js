$(function () {
    date();

    setInterval(function () {
        date();
    }, 1000);

    function date() {
        var myquery = $.ajax("/Home/Time");
        
        myquery.done(function (r) {
            $('#date').html(r);
        });
    };
});