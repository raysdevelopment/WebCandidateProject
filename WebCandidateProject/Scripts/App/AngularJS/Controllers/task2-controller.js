wpApp.controller('Task2Controller', ['$scope', 'userService',
    function ($scope, userService) {

        // view binds to this object to display user information
        $scope.user = {};

        // initialize page
        $scope.init = function () {
            // this will execute when the page loads
        };

        // get a user by id
        function getUserById(id) {
            // TODO: get user by id and set $scope.user to the user object. Angular will bind the object to the page   
        }
    }
]);