wpApp.factory("userService", [
  "$http", "$q", function ($http, $q) {

      var userService = {};

      userService.getUsers = function () {
          var deferred = $q.defer();
          
          $http.get("/api/user").
                success(function (result) {
                    deferred.resolve(result);
                }).
                error(function (result) {
                    deferred.resolve(result);
                });

          return deferred.promise;
      };

      userService.getUserById = function (id) {
          // TODO: call /api/user/id to get a user by id
      };

      return userService;
  }
]);