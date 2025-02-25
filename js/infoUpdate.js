document.addEventListener('DOMContentLoaded', function () {
    const slideIcon = document.querySelectorAll('#infoUpdateArea  tr');
    
    slideIcon.forEach(function (upIcon2) {
        const slideI = upIcon2.querySelector('th > img');
        const inputFields2 = upIcon2.querySelectorAll('td > input,select');
      
        if (inputFields2.length > 0 ) {
            inputFields2.forEach(function(inputField2) {
                inputField2.addEventListener('focus', function() {
                    slideI.classList.add('slide-top-animation'); // 정확한 클래스명 사용
                });
                
                inputField2.addEventListener('blur', function() {
                    slideI.classList.remove('slide-top-animation');
                });
            });
        }
    });
});

document.addEventListener('DOMContentLoaded', function () {
    function loadPhoto(input) {
        var file = input.files[0];
        if (file) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var imgElement = document.querySelector('.photoArea'); // .photoArea 선택
                imgElement.src = e.target.result; // 이미지 URL 설정
            };
            reader.readAsDataURL(file); // 파일을 Data URL로 변환
        }
    }

    document.getElementById('textType').addEventListener('change', function () {
        loadPhoto(this);
    });
});