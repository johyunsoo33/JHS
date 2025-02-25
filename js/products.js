document.addEventListener('DOMContentLoaded', () => {
    const sliderContainers = document.querySelectorAll('.slider');

    sliderContainers.forEach((container) => {
        const slider = container.querySelector('.productGrid');
        const prevBtn = container.querySelector('.prevBtn');
        const nextBtn = container.querySelector('.nextBtn');
        const items = slider.querySelectorAll('.productItem');
        const itemWidth = 280 + 6;
        const visibleItems = 5; // 한 번에 보이는 상품 개수
        const totalItems = items.length;

        let currentIndex = visibleItems; // 복제된 첫 번째 아이템 뒤에서 시작
        let isTransitioning = false;

        // 슬라이더 앞뒤에 복제 요소 추가
        const cloneFirst = [...items].slice(0, visibleItems).map((item) => item.cloneNode(true));
        const cloneLast = [...items].slice(-visibleItems).map((item) => item.cloneNode(true));

        cloneFirst.forEach((clone) => slider.appendChild(clone));
        cloneLast.reverse().forEach((clone) => slider.insertBefore(clone, slider.firstChild));

        // 슬라이더 초기 위치 설정
        slider.style.transform = `translateX(-${currentIndex * itemWidth}px)`;

        const updateSlider = () => {
            slider.style.transition = "transform 0.3s ease-in-out";
            slider.style.transform = `translateX(-${currentIndex * itemWidth}px)`;
        };

        const handleTransitionEnd = () => {
            if (currentIndex === 0) {
                slider.style.transition = "none";
                currentIndex = totalItems; // 실제 마지막 요소로 이동
                slider.style.transform = `translateX(-${currentIndex * itemWidth}px)`;
            } else if (currentIndex === totalItems + visibleItems) {
                slider.style.transition = "none";
                currentIndex = visibleItems; // 실제 첫 번째 요소로 이동
                slider.style.transform = `translateX(-${currentIndex * itemWidth}px)`;
            }
            isTransitioning = false;
        };

        // 버튼 클릭 이벤트
        prevBtn.addEventListener('click', () => {
            if (isTransitioning) return;
            isTransitioning = true;
            currentIndex--;
            updateSlider();
        });

        nextBtn.addEventListener('click', () => {
            if (isTransitioning) return;
            isTransitioning = true;
            currentIndex++;
            updateSlider();
        });

        // 슬라이더 끝에서 루프 처리
        slider.addEventListener('transitionend', handleTransitionEnd);
    });
});
