<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>DroneToYou</title>
</head>
<body>
<table class="inquryArea">
<tr>
	<td class="inquryPhotoArea">
	</td>
	<td class="inquryTextArea">
		<p>
		기타문의
		</p>
		<span></span>
		<p>
		더 나은 서비스를 위해 귀하의 질문을 기다립니다.
		</p>
	</td>
</tr>
</table>
<form action="">
	<table class="inquryContainer">
	    <caption>문의사항</caption>
	    <tr class="inquirySection">
	        <td class="inquiryButtons">
	            <button class="inquiryButton" onclick="selectCategory(this, '배송')">배송</button>
	            <button class="inquiryButton" onclick="selectCategory(this, '주문/결제')">주문/결제</button>
	            <button class="inquiryButton" onclick="selectCategory(this, '취소/교환/환불')">취소/교환/환불</button>
	            <button class="inquiryButton" onclick="selectCategory(this, '회원정보')">회원정보</button>
	            <button class="inquiryButton" onclick="selectCategory(this, '상품확인')">상품확인</button>
	            <button class="inquiryButton" onclick="selectCategory(this, '서비스')">서비스</button>
	        </td>
	        <td>
		        <select id="type" name="type" required>
		            <option value="" disabled selected>문의 유형을 선택해주세요.</option>
		        </select>
	        </td>
	    </tr>
		
		<tr>
			<td>
		    	<label for="details" id="detailsLabel">내용</label>
		    	<textarea id="details" name="details" required></textarea>
		    </td>
		</tr>
	    <tr id="attachmentField">
		    <td>
		        <label for="attachment">사진 첨부</label>
		        <input type="file" id="attachment" name="attachment" accept="image/*">
		    </td>
	    </tr>
	
	    <tr>
	    	<td>
		        <button type="submit">작성하기</button>
	        </td>
	    </tr>
	    <tr>
	    	<td>
		        <button>취소하기</button>
	        </td>
	    </tr>
	</table>
</form>
</body>
</html>