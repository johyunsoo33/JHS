document.addEventListener('DOMContentLoaded', function () {
    const upImg = document.querySelectorAll('.joinTable > table tr');

    upImg.forEach(function(upIcon) {
        const iconImgs = upIcon.querySelectorAll('.icon > img');
        const inputFields = upIcon.querySelectorAll('.joinTable > table tr td input');

        // inputFields가 있는 경우에만 이벤트 핸들러 추가
        if (inputFields.length > 0) {
            // 각 input에 대해 이벤트 핸들러 추가
            inputFields.forEach(function(inputField) {
                // input에 focus 이벤트 핸들러 추가
                inputField.addEventListener('focus', function() {
                    iconImgs.forEach(function(iconImg) {
                        iconImg.classList.add('slide-top-animation');
                    });
                });

                // input에 blur 이벤트 핸들러 추가
                inputField.addEventListener('blur', function() {
                    iconImgs.forEach(function(iconImg) {
                        iconImg.classList.remove('slide-top-animation');
                    });
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

    document.getElementById('fileChoose').addEventListener('change', function () {
        loadPhoto(this);
    });
});