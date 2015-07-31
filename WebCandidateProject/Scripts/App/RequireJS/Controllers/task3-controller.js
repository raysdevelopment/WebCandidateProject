require(["jquery", "underscore", "app/RequireJS/Models/user-model", "app/RequireJS/Services/user-service"], function ($, _, userModel, userService) {
    // list of all the users
    var users = [];

    // initialize
    function init() {
        
    };

    // get all users
    function getUsers() {
        // TODO: Get all users via the user service
        // NOTE: If you have not used RequireJS you can get the users via userService.getUsers()      
    }

    // adds select options to users select
    function createSeletOption(user) {
        $("#users").append('<option value="' + user.userId + '">' + user.firstName + '</option>');
    }

    $(function () {
        init();
    });
});