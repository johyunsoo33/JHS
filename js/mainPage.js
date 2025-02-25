//메뉴 이벤트
```````````````document.addEventListener('DOMContentLoaded', function () {
    var nav = document.querySelector('nav');
    var navUl = document.querySelector('nav > ul');
    var menuDetails = document.querySelectorAll('nav ul li.menuDetail');

    function showBg() {
        if (navUl) {
            navUl.classList.add('show_bg');
        }
    }

    function hideBg() {
        if (navUl) {
            navUl.classList.remove('show_bg');
        }
    }

    function showAllMenus() {
        var hiddenMenus = document.querySelectorAll('.hiddenMenu');
        hiddenMenus.forEach(function (menu) {
            menu.style.display = 'block';
        });
    }

    function hideAllMenus() {
        var hiddenMenus = document.querySelectorAll('.hiddenMenu');
        hiddenMenus.forEach(function (menu) {
            menu.style.display = 'none';
        });
    }

    // nav 내부에 마우스가 있을 때 배경 유지
    nav.addEventListener('mouseenter', function () {
        showBg();
        showAllMenus();
    });

    nav.addEventListener('mouseleave', function () {
        hideBg();
        hideAllMenus();
    });

    // 각 li에 마우스가 들어올 때 배경을 보이게 하고 메뉴도 보이도록 설정
    menuDetails.forEach(function (detail) {
        detail.addEventListener('mouseenter', function () {
            showBg();
            showAllMenus();
        });
    });

    // 각 li를 벗어나도 nav 전체를 벗어나기 전까지 배경을 유지
    menuDetails.forEach(function (detail) {
        detail.addEventListener('mouseleave', function () {
            // 여전히 nav 영역 내에 있다면 hide를 호출하지 않음
            if (!nav.matches(':hover')) {
                hideBg();
                hideAllMenus();
            }
        });
    });
});
document.addEventListener('DOMContentLoaded', function () {
	// 카테고리 항목을 클릭할 때 보여줄 항목을 처리하기 위해 변수 선언
	    const toyCategory = document.querySelector('.toy');
	    const racingCategory = document.querySelector('.racing');
	    const cameraCategory = document.querySelector('.camera');

	    const toyItem = document.querySelector('.toyItem');
	    const racingItem = document.querySelector('.racingItem');
	    const cameraItem = document.querySelector('.cameraItem');
	    
	    // 카테고리 클릭 이벤트 설정
	    toyCategory.addEventListener('click', function () {
	        toggleVisibility(toyItem);
	    });

	    racingCategory.addEventListener('click', function () {
	        toggleVisibility(racingItem);
	    });

	    cameraCategory.addEventListener('click', function () {
	        toggleVisibility(cameraItem);
	    });
	  
	    // 항목을 토글하는 함수
	    function toggleVisibility(item) {
	        const allItems = [toyItem, racingItem, cameraItem];
	        
	        // 모든 항목을 숨기기
	        allItems.forEach(i => i.style.display = 'none');

	        // 선택된 항목만 토글 (숨기거나 표시하기)
	        if (item.style.display === 'none' || item.style.display === '') {
	            item.style.display = 'block';
	        } else {
	            item.style.display = 'none';
	        }
	    }
});
 
//selling 드론 이벤트
document.addEventListener('DOMContentLoaded', function () {
    var sellDrones = document.querySelectorAll('.contentWarp > .viewItems > ul > li');
    //드론 이미지확대
    sellDrones.forEach(function(sellDrone){
        var sellDroneImg = sellDrone.querySelector('.itemImg > img');
        if(sellDroneImg){
            sellDrone.addEventListener('mouseenter', function () {
                sellDroneImg.style.transform = 'scale(1.2)'
            });
            sellDrone.addEventListener('mouseleave', function () {
                sellDroneImg.style.transform = 'scale(1)'
            });
        }
    
    });  
});

//custome 드론 이벤트
document.addEventListener('DOMContentLoaded', function () {
    var names = ['도색','프레임제작','이니셜 각인','업그레이드'];
    var container = document.querySelectorAll('.box>a');
    if (container.length > 0) {
        container.forEach(function(container, index) {
            // 배열에서 해당 인덱스의 이름을 가져옵니다.
            var name = names[index] || `기본 작업-${index + 1}`;
            var Redintro = document.createElement('div');
            Redintro.classList.add('redOnDiv');
            Redintro.innerHTML = `
                <div class ="align">
                    <div class="name">
                        ${name}
                    </div>

                    <div class="plus">
                        <div>
                        </div>

                        <div>
                        </div>
                    </div>
                </div>
            `;
            container.appendChild(Redintro);
        });
    }
});

//c2c 이벤트
// 목표로한 높이 1600
document.addEventListener('DOMContentLoaded', function () {
    var ctocBg = document.querySelector('.c2cBg');
    var ctocWrap = document.querySelector('.c2cWrap');
    var tgHeight = 1600;

    window.addEventListener('scroll', function () {
        var scrollPosition = window.scrollY;

        // 스크롤 위치가 tgHeight에 도달하거나 넘어갔을 때
        if (scrollPosition >= tgHeight) {
            if (ctocWrap && ctocBg) {
                ctocWrap.style.transform = 'translateX(0)';
                ctocWrap.style.opacity = '1';
                ctocWrap.style.transition = 'all 1s ease-out';

                ctocBg.style.transform = 'translateX(0)';
                ctocBg.style.opacity = '1';
                ctocBg.style.transition = 'all 1s ease-out';
            }
        } else {
            if (ctocWrap && ctocBg) {
                ctocWrap.style.transform = 'translateX(300px)';
                ctocWrap.style.opacity = '0';
                ctocBg.style.transform = 'translateX(300px)';
                ctocBg.style.opacity = '0';
            }
        }
    });
});
function isElementHidden(element) {
    if (!element) {
        console.error("유효한 요소가 아닙니다.");
        return true;
    }
    const display = window.getComputedStyle(element).display;
    return display === 'none';
}

// 메인 함수
function reqOutTbl() {
    const writeTable = document.querySelector('.reqInTbl');
    const darkBg = document.querySelector('.tableDark');
	if (writeTable.style.display !== 'none') {
	    writeTable.style.display = 'none'; // 테이블 숨기기
	    darkBg.style.display = 'none';
	    console.log("테이블이 숨겨졌습니다.");
	}
}


