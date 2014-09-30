'use strict';

var myApp = angular.module('myApp', ['ngRoute']);

myApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/',
            {
                templateUrl: '/Templates/Home.html',
                controller: 'HomeCtrl'
            }
        ).when('/Forums',
            {
                templateUrl: '/Templates/Forum/Forum.html',
                controller: 'ForumCtrl'
            }
        ).when('/Challenge',
            {
                templateUrl: '/Templates/Contest/Challenge.html',
                controller: 'ChallengeCtrl'
            }
        ).when('/Mail',
            {
                templateUrl: '/Templates/Mail/Inbox.html',
                controller: 'MailCtrl'
            }
        ).when('/Mail/Compose',
            {
                templateUrl: '/Templates/Mail/Compose.html',
                controller: 'ComposeCtrl'
            }
        ).when('/Mail/:Id',
            {
                templateUrl: '/Templates/Mail/Message.html',
                controller: 'MessageCtrl'
            }
        ).when('/Sent',
            {
                templateUrl: '/Templates/Mail/Sent.html',
                controller: 'SentCtrl'
            }
        ).when('/Friends',
            {
                templateUrl: '/Templates/Social/Friends.html',
                controller: 'FriendsCtrl'
            }
        )
        .when('/Store',
            {
                templateUrl: '/Templates/Store.html',
                controller: 'StoreCtrl'
            }
        ).when('/Stats',
            {
                templateUrl: '/Templates/Stats/Stats.html',
                controller: 'StatsCtrl'
            }
        ).when('/Pictures',
            {
                templateUrl: '/Templates/Social/Pictures.html',
                controller: 'PicsCtrl'
            }
        )
        .when('/Videos',
            {
                templateUrl: '/Templates/School/Videos.html',
                controller: 'VidsCtrl'
            }
        )
        .when('/Feed',
            {
                templateUrl: '/Templates/Social/Feed.html',
                controller: 'FeedCtrl'
            }
        );
}]);