(function () {

    var myModel = {
        games: {},
    };

    var myViewModel = new Vue({
        el: '#game-view',
        data: myModel,
        mounted() {
            fetch("http://localhost:65492/api/games")
                .then(response => response.json())
                .then(data => {
                    myModel.games = data;
                });
        }
    });

})();
