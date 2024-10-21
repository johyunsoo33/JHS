document.addEventListener('DOMContentLoaded', function () {
    var menuDetails = document.querySelectorAll('nav ul li.menu_detail');

    function showBg() {
        var navUl = document.querySelector('nav>ul');
        if (navUl) {
            navUl.classList.add('show-bg');
        }
    }

    function hideBg() {
        var navUl = document.querySelector('nav>ul');
        if (navUl) {
            navUl.classList.remove('show-bg');
        }
    }

    function showAllMenus() {
        var hiddenMenus = document.querySelectorAll('.hidden_menu');
        hiddenMenus.forEach(function (menu) {
            menu.style.display = 'block';
        });
    }

    function hideAllMenus() {
        var hiddenMenus = document.querySelectorAll('.hidden_menu');
        hiddenMenus.forEach(function (menu) {
            menu.style.display = 'none';
        });
    }

    menuDetails.forEach(function (detail) {
        detail.addEventListener('mouseenter', function () {
            showBg();
            showAllMenus();
        });
        detail.addEventListener('mouseleave', function () {
            hideBg();
            hideAllMenus();
        });
    });
});

document.addEventListener('DOMContentLoaded', function () {
    var Redintro = document.createElement('div');
    Redintro.classList.add('red_ondiv');
    Redintro.innerHTML = `
            <div class ="align">
                <div class="cate">
                    PEN
                </div>

                 <div class="name">
                    FX ZETA C3
                </div>

                 <div class="plus">
                    <div>
                    </div>

                    <div>
                    </div>
                </div>
            </div>
    `;

    var container = document.querySelectorAll('.box1 , .box2 , .box3 , .box4, .box5');
    if (container.length > 0) {
        container.forEach(function(container) {
            container.appendChild(Redintro.cloneNode(true));
        });
    } else {
       
    }
});

document.addEventListener('DOMContentLoaded',function(){
    const targetHeight = 2636;
    const endHeight = 3500;
    const auto = document.getElementsByClassName('bgvid')[0];

    function onscroll(){
        if(window.scrollY >= targetHeight && window.scrollY <= endHeight ){
            console.log("비디오 시작");
            if(auto.pause){
                auto.play().then(function(){

                }).catch(function(error){

                });
            }
        } else {
            if (!auto.paused) {
                console.log("비디오 종료");
                auto.pause();
            }
        }
    }
    window.addEventListener('scroll',onscroll);
});


var swiper = new Swiper(".list_box", {
    slidesPerView: 5,
    spaceBetween: 9,
    freeMode: true,
  });