$(document).ready(function () {
    if ($('.js-all-animals').length > 0) {
        var wrapper = $('.js-all-animals');
        var animals = wrapper.find('li');
        var rand = Math.floor((Math.random() * animals.length) + 0);
        var theOnlyOneAnimalThatWannaBeRandom = $(animals).get(rand);

        $(animals).remove();
        $(wrapper).append($(theOnlyOneAnimalThatWannaBeRandom));
    }
    
});