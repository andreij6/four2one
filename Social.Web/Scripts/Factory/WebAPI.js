'use strict';

myApp.factory('WebAPI', function ($q, $http) {
    return {
        getUsers: function () {
            var defered = $q.defer();

            $http({
                method: "GET",
                url: "/api/User"
            }).success(function (data) {
                defered.resolve(data);
            }).error(function (data) {
                defered.reject(status);
            })

            return defered.promise;
        },

        sendMail: function(message){
            var defered = $q.defer();

            $http({
                method: "POST",
                url: "/api/Message",
                data: message
            }).success(function (data) {
                defered.resolve(data);
            }).error(function (data) {
                defered.reject(status);
            })

            return defered.promise;
        },

        getInbox: function () {
            var defered = $q.defer();

            $http({
                method: "GET",
                url: "/api/Message"
            }).success(function (data) {
                defered.resolve(data);
            }).error(function (data) {
                defered.reject(status);
            })

            return defered.promise;
        },

        MarkAsRead: function (messageId) {
            //  api/MessageAction/{id}

            var defered = $q.defer();

            $http({
                method: "GET",
                url: "/api/MessageAction/" + messageId + "/MarkAsRead",
            }).success(function (data) {
                defered.resolve(data);
            }).error(function (data) {
                defered.reject(status);
            })

            return defered.promise;
        },

        getSent: function () {
            var defered = $q.defer();

            $http({
                method: "GET",
                url: "/api/MessageAction/0/GetSent",
            }).success(function (data) {
                defered.resolve(data);
            }).error(function (data) {
                defered.reject(status);
            })

            return defered.promise;
        }
    }
})
