(function () {

    var myViewModel = new Vue({
        el: '#game-view',
        data: {
            games: [],
        },
        mounted() {
            fetch("http://localhost:65492/api/games")
                .then(response => response.json())
                .then(data => {
                    this.games = data;
                });
        }
    });

})();
