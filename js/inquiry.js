function selectCategory(button, category) {
          const buttons = document.querySelectorAll('.inquiryButton');
          buttons.forEach(btn => btn.classList.remove('active'));

          button.classList.add('active');

          const typeSelect = document.getElementById("type");

          const options = {
              "배송": ["예약배송", "배송일정", "기타"],
              "주문/결제": ["결제수단", "주문변경", "기타"],
              "취소/교환/환불": ["주문취소", "교환/반품", "환불/반품"],
              "회원정보": ["가입/인증", "로그인/정보", "탈퇴/기타"],
              "상품확인": ["상품문의", "불량/하자", "A/S"],
              "서비스": ["후기", "이용문의", "고객센터", "신고", "기타"]
          };

          typeSelect.innerHTML = `<option value="" disabled selected>문의 유형을 선택해주세요.</option>`;
          options[category].forEach(option => {
              const opt = document.createElement("option");
              opt.value = option;
              opt.textContent = option;
              typeSelect.appendChild(opt);
	});
}
