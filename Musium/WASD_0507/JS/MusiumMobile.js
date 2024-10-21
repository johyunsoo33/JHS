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
var swiper = new Swiper(".mySwiper", {
    slidesPerView: 3,
    spaceBetween:1,
    loop: true
  });

document.getElementById("myButton").onclick = function() {
    location.href = "Musium_Review.html";
};