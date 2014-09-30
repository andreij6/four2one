$(function () {
    // Declare a proxy to reference the hub. 
    var chat = $.connection.chatHub;

    chat.client.broadcastMessage = function (message) {
        $('#discussion').prepend('<li> <b>' + message.User + '</b><p>' + message.Body + '<p></li>');
    };

    $('#message').focus();

    $.connection.hub.start().done(function () {
        $('#sendmessage').click(function () {
            chat.server.send($('#message').val());
            $('#message').val('').focus();
        });
    });
});