// Using jQuery

$(document).ready(function () {
    var url = 'ws://' + window.location.host + '/TimeHandler.ashx';
    ws = new WebSocket(url);

    ws.onopen = function () {
        $('#container').prepend('WebSocket is open! <br/>');
    };

    ws.onmessage = function (e) {
        $('#container').prepend(e.data + '<br/>');
    };

    ws.onclose = function () {
        $('#container').prepend('Bye! <br/>');
    };

    ws.onerror = function () {
        $('#container').prepend('Oops! <br/>');
    };

});