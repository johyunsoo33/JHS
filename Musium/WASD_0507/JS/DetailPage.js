document.addEventListener('DOMContentLoaded', function() {
    // 페이지 로드 시 기존 리뷰 로드
    loadReviews();

    document.getElementById('reviewForm').addEventListener('submit', function(event) {
        event.preventDefault(); // 폼 제출 기본 동작 막기

        const reviewText = document.getElementById('reviewText').value;

        if (reviewText.trim() === "") {
            alert("리뷰를 입력해주세요!");
            return;
        }

        const starPoint = document.getElementById('star_point').value;

        const review = {
            starPoint: starPoint,
            reviewText: reviewText
        };

        saveReview(review);

        alert("리뷰가 성공적으로 등록되었습니다!");

        // 새로운 리뷰 요소 생성
        const newReview = createReviewElement(review);

        // 리뷰 컨테이너의 맨 위에 새로운 리뷰 추가
        const reviewsContainer = document.getElementById('reviewsContainer');
        reviewsContainer.insertBefore(newReview, reviewsContainer.firstChild);

        // 텍스트 에어리어 초기화
        document.getElementById('reviewText').value = '';
        document.getElementById('star_point').selectedIndex = 0;
    });
});

function saveReview(review) {
    // 기존 리뷰 목록 가져오기
    const reviews = JSON.parse(localStorage.getItem('reviews')) || [];

    // 새로운 리뷰 추가
    reviews.push(review);

    // 리뷰 데이터를 localStorage에 저장
    localStorage.setItem('reviews', JSON.stringify(reviews));
}

function loadReviews() {
    // localStorage에서 리뷰 목록 가져오기
    const reviews = JSON.parse(localStorage.getItem('reviews')) || [];

    // 가장 최근 리뷰가 맨 위에 표시되도록 역순으로 추가
    reviews.reverse().forEach(review => {
        // 새로운 리뷰 요소 생성
        const reviewElement = createReviewElement(review);

        // 리뷰 컨테이너에 추가
        document.getElementById('reviewsContainer').appendChild(reviewElement);
    });


}

function createReviewElement(review) {
    const reviewElement = document.createElement('div');
    reviewElement.classList.add('reviews');
    reviewElement.innerHTML = `
        <div style="width: 100%; display: flex; align-items: center; margin-left: 38px; margin-top: 34px;">
            <label for="userimg" style="width: 72px; height: 72px; border-radius: 50%; background-color: #FFFFFF; margin-right: 10px;">
                <img src="IMG/사람.png" alt="" style="width: 100%; height: 100%; object-fit: cover;">
            </label>
            <label for="username" style="width: 141px; height: 30px; font-family: 'SF Pro'; font-style: normal; font-weight: 510; font-size: 25px; color: #FFFFFF;">
                사용자 이름
            </label>
        </div>
        <div style="width: 100%; margin-left: 40px; justify-content: center; margin-top: 20px;">
            <span style="font-family: 'SF Pro'; font-style: normal; font-weight: 510; font-size: 30px; color: #FFFFFF;">${review.starPoint}</span>
        </div>
        <textarea readonly style="display: block; width: 1200px; margin: 35px auto; background: none; font-family: 'SF Pro'; font-style: normal; font-weight: 400; font-size: 25px; letter-spacing: 0.08em; color: #ABABAB; border: none; border-bottom: 2px solid #ffffff;">${review.reviewText}</textarea>
    `;
    reviewElement.style.margin = '33px auto';
    reviewElement.style.width = '1300px';
    reviewElement.style.height = '420px';
    reviewElement.style.border = '1px solid #ffffff';
    reviewElement.style.borderRadius = '30px';

    return reviewElement;
}