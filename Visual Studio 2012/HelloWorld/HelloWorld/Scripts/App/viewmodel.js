var vm = function () {
    var self = this;

    self.name = ko.observable('enter your name here');
    self.welcomeMessage = ko.observable('');

    self.helloClicked = function () {
        self.welcomeMessage("Welcome to Hello World  - " + self.name() + " !!!");
    };
};