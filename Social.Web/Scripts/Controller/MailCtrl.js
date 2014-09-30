/// <reference path="c:\Projects\Social.Web\Social.Web\Templates/Mail/Compose.html" />
'use strict';

myApp.controller('MailCtrl', ['$scope', 'WebAPI', 'Storage', function ($scope, WebAPI, Storage) {
    $scope.Test = "Mail";

    $scope.Inbox = [];
    $scope.Unread = 0;

    $scope.getInbox = function () {
        WebAPI.getInbox().then(
            function (data) {
                $scope.Inbox = data;
                Storage.Inbox = data;

                for(var x in data)
                {
                    if(!data[x].Read)
                    {
                        $scope.Unread += 1;
                    }
                }

                Storage.Unread = $scope.Unread;
            },
            function (statusCode) { console.log(statusCode); }
        );
    };

    $scope.MarkUnread = function (messageId) {
        WebAPI.MarkAsRead(messageId).then(
                function (data) { console.log(data);},
                function (statusCode) { console.log(statusCode);}
            );
    }

    $scope.getInbox();
}]);

myApp.controller('ComposeCtrl', ['$scope', 'WebAPI', 'Storage', function ($scope, WebAPI, Storage) {
    $scope.Test = "Composer";
    $scope.People = [];
    $scope.Mail = {};
    $scope.Inbox = Storage.Inbox;
    $scope.Unread = Storage.Unread;

    //Get all users to fill the reciepient field.
    $scope.GetUsers = function () {
        WebAPI.getUsers().then(
                function (data) {
                    $scope.People = data;
                },
                function (statusCode) {
                    console.log(statusCode);
                }
            )
    }

    $scope.SendMail = function (message) {
        WebAPI.sendMail(message).then(
            function (data) { console.log(data); },
            function (statusCode) { console.log(statusCode); }
            );
    }

    $scope.GetUsers();
}]);

myApp.controller('MessageCtrl', ['$scope', 'WebAPI', 'Storage', '$routeParams', function ($scope, WebAPI, Storage, $routeParams) {
    $scope.Message = {};
    $scope.Test = $routeParams.Id;
    $scope.Inbox = Storage.Inbox;
    $scope.Unread = Storage.Unread;

    for(var x in Storage.Inbox)
    {
        if(Storage.Inbox[x].Id == $routeParams.Id)
        {
            $scope.Message = Storage.Inbox[x];
        }
    }
    


}]);

myApp.controller('SentCtrl', ['$scope', 'WebAPI', 'Storage', function ($scope, WebAPI, Storage) {
    $scope.Unread = Storage.Unread;
    $scope.Sent = [];
    $scope.Test = "testing"

    $scope.SentMail = function () {
        WebAPI.getSent().then(
            function (data) {
                $scope.Sent = data;
            },
            function (statusCode) {
                console.log(statusCode);
            }
     );
    }

    $scope.SentMail();

}]);