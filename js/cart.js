function updateProductPrice() {
    let totalProductPrice = 0; 
    const cartInfoTables = document.querySelectorAll('.cartInfo'); // 모든 cartInfo 테이블 선택

    // 각 상품의 가격 계산
    cartInfoTables.forEach((table) => {
        const sellPriceElement = table.querySelector('.sellPrice'); // 상품 단가
        const quantityElement = table.querySelector('.quantity'); // 수량
        const checkbox = table.querySelector('.check'); // 체크박스
        
        // 값이 유효하고 체크된 경우만 계산
        if (checkbox.checked && sellPriceElement && quantityElement) {
            const sellPrice = parseInt(sellPriceElement.value.replace(/,/g, ''), 10); // 단가
            const quantity = parseInt(quantityElement.value, 10); // 수량
            
            if (!isNaN(sellPrice) && !isNaN(quantity)) {
                totalProductPrice += sellPrice * quantity; // 총 상품 가격에 더하기
            }
        }
    });

    // 총 상품 가격 업데이트
    const productPriceInput = document.querySelector('.productPrice');
    if (productPriceInput) {
        productPriceInput.value = totalProductPrice.toLocaleString(); 
    }

    // 배송비 및 총금액 계산
    const shippingCost = 3000;
    const totalAmount = totalProductPrice + (totalProductPrice > 0 ? shippingCost : 0); // 상품 없으면 배송비 제외
    const totalSumInput = document.querySelector('input[name="totalSum"]');
    if (totalSumInput) {
        totalSumInput.value = totalAmount.toLocaleString();
    }
}

document.addEventListener('DOMContentLoaded', function () {
    const checkboxes = document.querySelectorAll('.check');
    checkboxes.forEach((checkbox) => {
        checkbox.addEventListener('change', function () {
           updateProductPrice();
        });
    });
});
function increaseQuantity(button) {
    const table = button.closest('table'); 
    const curQuantity = table.querySelector('.quantity');
    let currentValue = parseInt(curQuantity.value); // 현재 값 가져오기
    if (!isNaN(currentValue)) {
        curQuantity.value = currentValue + 1;
    } else {
        curQuantity.value = 1; // 초기값 설정
    }
    updateProductPrice(table); // 가격 업데이트
}

function decreaseQuantity(button) {
    const table = button.closest('table');
    const curQuantity = table.querySelector('.quantity');
    let currentValue = parseInt(curQuantity.value); // 현재 값 가져오기
    if (!isNaN(currentValue) && currentValue > 1) {
        curQuantity.value = currentValue - 1;
    }
    updateProductPrice(table); // 가격 업데이트
}

window.onload = function () {
    const tables = document.querySelectorAll('.cartInfo'); // 모든 테이블 선택
    tables.forEach(table => {
        updateProductPrice(table); // 각 테이블에 대해 가격 업데이트
    });
};

