document.addEventListener('DOMContentLoaded', function() {
    const activeList = document.querySelectorAll('.tabTitle li a');
    const activeList2 = document.querySelectorAll('.tabTitle li');

    activeList.forEach(function(item) {
        item.addEventListener('click', function(event) {
            // 모든 li 요소에서 active 클래스 제거
            activeList2.forEach(function(li) {
                li.classList.remove('active');
            });

            // 클릭된 a 요소의 부모(li)에 active 클래스 추가
            const parentLi = item.parentElement;
            parentLi.classList.add('active');
        });
    });
});

document.addEventListener('DOMContentLoaded', function() {
    function loadFile(input) {
        var file = input.files[0];
        if (file) {
            var newImage = document.createElement("img");
            newImage.src = URL.createObjectURL(file);
            newImage.style.width = "100px";
            newImage.style.height = "100px";
            newImage.style.objectFit = "contain";
            newImage.style.padding = "5px";
            var container = document.querySelector('.reviewCon>td');
            container.appendChild(newImage);
        }
    }

    document.getElementById('reviewImg').addEventListener('change', function() {
        loadFile(this);
    });
});

function moveClass(className) {
    const element = document.querySelector(`.${className}`);
    if (element) {
        element.scrollIntoView({
            behavior: 'smooth'
        });
    }
}

document.addEventListener('DOMContentLoaded', function() {
    // 리뷰 폼 제출 이벤트 처리
    document.querySelector('.reviewForm').addEventListener('submit', function(event) {
        event.preventDefault();

        // 입력값 가져오기
        const starPoint = document.querySelector('.starPoint').value;
        const reviewText = document.querySelector('.reviewText textarea').value;
        const reviewPhotoInput = document.querySelector('.reviewCon>td');
        let reviewPhoto = '';

        if (reviewPhotoInput.files && reviewPhotoInput.files[0]) {
            const file = reviewPhotoInput.files[0];

            // 이미지 파일의 URL 생성
            reviewPhoto = URL.createObjectURL(file); // 파일의 URL 생성
        }
        if (reviewText.trim() === '') {
            alert('리뷰를 작성해주세요!');
            return;
        }

        // 리뷰 객체 생성
        const review = {
            starPoint,
            reviewText,
            reviewPhoto,
        };

        // 동적으로 리뷰 요소 생성
        const newReviewHTML = createReviewElement(review);

        // 출력 영역에 추가
        const reviewsContainer = document.querySelector('.reviewOutput td');
        reviewsContainer.innerHTML = newReviewHTML + reviewsContainer.innerHTML;

        // 입력값 초기화
        document.querySelector('.reviewText textarea').value = '';
        document.querySelector('.reviewCon').value = '';

        alert('리뷰가 성공적으로 등록되었습니다!');
    });
});

function loadReview() {
    const reviews = JSON.parse(localStorage.getItem('reviews')) || [];
    reviews.reverse().forEach(review => {
        const reviewElement = createReviewElement(review);
        document.getElementById('reviewsContainer').appendChild(reviewElement);
    });
}

function saveReview(review) {
    // 기존 리뷰 목록 가져오기
    const reviews = JSON.parse(localStorage.getItem('reviews')) || [];
    // 새로운 리뷰 추가
    reviews.push(review);
    // 리뷰 데이터를 localStorage에 저장
    localStorage.setItem('reviews', JSON.stringify(reviews));
}

function createReviewElement(review) {
    return `
        <table class="reviews">
            <tr>
                <td>
                    <table class="innerTable">
                        <tr class="reviewsUser">
                            <td>
                                <label for="userImg">
                                    <img alt="" src="resources/img/aa.jpg">
                                </label>
                            </td>
                            <td>
                                <label for="userId">킹캉콩</label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ${review.starPoint}
                            </td>
                        </tr>
                        <tr>
                            <td class="reviewsPhoto">
							${review.reviewPhoto ? `<img src="${review.reviewPhoto}" alt="리뷰 사진">` : '사진 없음'}
                            </td>
                        </tr>
                        <tr>
                            <td class="reviewsText">
                                ${review.reviewText}
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>`;
}

