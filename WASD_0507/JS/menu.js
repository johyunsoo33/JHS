document.addEventListener("DOMContentLoaded", function() {
    var menuButton = document.getElementById("menu-button");
    var menu = document.getElementById("menu");

    menuButton.addEventListener("click", function() {
        menu.classList.toggle("show");
    });
});

document.addEventListener("DOMContentLoaded", function() {
    var menuButton = document.getElementById("close_button");
    var menu = document.getElementById("menu");

    menuButton.addEventListener("click", function() {
        menu.classList.remove("show");
    });
});