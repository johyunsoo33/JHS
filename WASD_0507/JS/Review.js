document.addEventListener('DOMContentLoaded', function() {
    loadReviews();
});

function loadReviews() {
    // localStorage에서 리뷰 목록 가져오기
    const reviews = JSON.parse(localStorage.getItem('reviews')) || [];
    
    // 최대 8개의 리뷰만 표시
    const displayedReviews = reviews.slice(-8).reverse();

    displayedReviews.forEach((review, index) => {
        // 새로운 리뷰 요소 생성
        const reviewElement = document.createElement('div');
        reviewElement.classList.add('re');
        reviewElement.innerHTML = `
            <div class="re_img">
                <img src="" alt="">
            </div>
            <div class="re_text">
                <p>${review.starPoint}</p>
                <p><b>뮤지컬 제목</b></p>
                <p>${review.reviewText}</p>
                <button onclick="deleteReview(${index})">삭제</button>
            </div>
        `;

        // 리뷰 리스트에 새로운 리뷰 추가
        document.getElementById('reviewList').appendChild(reviewElement);
    });

    console.log('Loaded reviews:', displayedReviews); // 디버깅용 콘솔 로그
}

function deleteReview(index) {
    // localStorage에서 리뷰 목록 가져오기
    let reviews = JSON.parse(localStorage.getItem('reviews')) || [];

    // 실제 인덱스 계산 (표시된 리뷰의 인덱스가 아닌 실제 전체 리뷰의 인덱스)
    const actualIndex = reviews.length - 8 + index;

    reviews.splice(actualIndex, 1);

    // 변경된 리뷰 목록을 localStorage에 저장
    localStorage.setItem('reviews', JSON.stringify(reviews));

    location.reload();
}