<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>DroneToYou</title>
</head>
<body>
	<div class="cartMain">
		<table class="topArea">
			<tr>
				<td class="cartPhotoArea"></td>
				<td class="cartTextArea">
					<p>장바구니</p>
					<span></span>
					<p>지금 결제하고 빠르게 받아보세요!</p>
				</td>
			</tr>
		</table>

	<table class="cartTable">
		<tr>
			<th>드론배송 상품</th>
				<td>
					<table class="cartInfo">
						<tr>
							<th>선택</th>
							<th>상품정보</th>
							<th>판매가</th>
							<th>수량</th>
						</tr>
				
						<tr>
							<td><input type="checkbox"  class="check"></td>
							<td><span>DJI Neon</span><img src="resources/img/droneImg/toy/toyDrone11.jpg" alt="드론1"></</td>
							<td>249,000원</td>
							<td class="cartText">
								<input type="hidden" class="sellPrice" value="249,000"/> 
								<button onclick="decreaseQuantity(this)"  style="background-color: #fff; border: 1px solid #d1d1d1;">-</button>
								<input type="text" value="1" size="2" max="" style="text-align: center;" class="quantity" /> 
								<button onclick="increaseQuantity(this)"  style="background-color: #fff; border: 1px solid #d1d1d1">+</button>
							</td>
						</tr>
					</table>
					
					<table class="cartInfo">
						<tr>
							<th>선택</th>
							<th>상품정보</th>
							<th>판매가</th>
							<th>수량</th>
						</tr>
				
						<tr>
							<td><input type="checkbox"  class="check"></td>
							<td><span>DJI Mini2</span><img src="resources/img/droneImg/toy/toyDrone3.jpg" alt="드론1"></td>
							<td>549,000원</td>
							<td class="cartText">
								<input type="hidden" class="sellPrice" value="549,000"/> 
								<button onclick="decreaseQuantity(this)"  style="background-color: #fff; border: 1px solid #d1d1d1;">-</button>
								<input type="text" value="1" size="2" max="" style="text-align: center;" class="quantity" /> 
								<button onclick="increaseQuantity(this)"  style="background-color: #fff; border: 1px solid #d1d1d1">+</button>
							</td>
						</tr>
					</table>
				</td>
			</tr>
		
			<tr class="orderTable">
				<th>주문예상금액</th>	
				<td>상품가격<input type="text" class="productPrice" size="11" value="" readonly>원</td>
				<td>배송비<p>3,000</p> 원</td>
				<td>총금액<input type="text" name="totalSum" readonly>원
				</td>
				<td><button type="submit">구매하기</button></td>
			</tr>
		</table>
	</div>
</body>
</html>