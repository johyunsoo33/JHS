<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<link rel="stylesheet" href="resources/css/surveyForm.css">
</head>
<body>
<table class="surveyArea">
<tr>
	<td class="surveyPhotoArea">
	</td>
	<td class="surveyTextArea">
		<p>
		맞춤제작
		</p>
		<span></span>
		<p>
		나만의 드론이 만들어지는 과정
		</p>
	</td>
</tr>
</table>
<form action="/submit" method="post">
	<table class="surveyContainer">
		<caption>맞춤제작 요청사항</caption>
	        <tr class="form-group">
	        	<td>
		            <label for="wingSpecification">1. 날개 규격:</label>
		            <input type="text" id="wingSpecification" name="wingSpecification" required>
	            </td>
	        </tr>
	        <tr class="form-group">
	        	<td>
		            <label for="wingCount">2. 날개 개수:</label>
		            <input type="number"  name="wingCount" required>
	           	</td>
	        </tr>
	        <tr class="form-group">
	        	<td>        
		            <label for="purpose">3. 사용 목적:</label>
		            <textarea name="purpose" required></textarea>
	            </td>
	        </tr>
	        <tr class="form-group">
	        	<td>
		            <label for="requiredFeatures">4. 필요한 기능:</label>
		            <textarea  name="requiredFeatures" required></textarea>
	            </td>
	        </tr>
	        <tr class="form-group">
	        	<td>        
		            <label for="batteryCapacity">5. 배터리 용량:</label>
		            <input type="text" name="batteryCapacity" required>
	            </td>
	        </tr>
	        <tr class="form-group">
	        	<td>        
		            <label for="bodySize">6. 바디 크기:</label>
		            <input type="text" name="bodySize" required>
	            </td>
	        </tr>
	        <tr class="form-group">
	        	<td>        
		            <label for="blueprint">7. 설계 도면:</label>
		            <input type="file" name="blueprint" required>
	            </td>
	        </tr>
	        <tr class="form-group">
	        	<td>
		            <label for="painting">8. 도색:</label>
		            <input type="text" name="painting" required>
	            </td>
	        </tr>
	        <tr>
		        <td>
		        	<button type="submit">제출</button>
		        </td>
	        </tr>
	       	<tr>
		        <td>
		        	<button>취소</button>
		        </td>
	        </tr>
	</table>
</form>
</body>
</html>