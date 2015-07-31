define(function () {

    var User = function(data) {
        var self = this;
        self.userId = data.userId || 0;
        self.firstName = data.firstName || "";
        self.lastName = data.lastName || "";
        self.address = data.address || "";
        self.city = data.city || "";
        self.state = data.state || "";
        self.zip = data.zip || "";
        self.profileImage = data.profileImage || "";
    }

    return User;
});