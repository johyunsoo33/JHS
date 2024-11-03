<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>logined</title>
</head>
<body>
	<div class="login">
        <h3>로그인</h3>
        <form action="" method="post" name="loginForm" onsubmit="" class="loginTable">
            <table>
                <tr>
                    <th>ID</th>
                    <td><input type="text" placeholder="ID" name="dm_id"><br></td>
                </tr>
                <tr>
                    <th>PW</th>
                    <td><input type="password" placeholder="Password" name="dm_pw"></td>                
                </tr>
                <tr>
                    <th>비밀번호 확인</th>
                    <td><input type="password" placeholder="password Check" name="dm_pw_c"></td>                
                </tr>
                <tr>
                    <th>이름</th>
                    <td><input type="text" placeholder="Name" name="dm_name"><br></td>
                </tr>
                <tr>
                    <th>전화번호</th>
                    <td><input type="text" placeholder="Phone number" name="dm_phone"></td>                
                </tr>
                <tr>
                    <th>생년월일</th>
                    <td><input type="text" placeholder="Birthday" name="dm_birthday"><br></td>
                </tr>
                <tr>
                    <th>이메일</th>
                    <td><input type="email" placeholder="Email" name="dm_email"></td>                
                </tr>
                <tr>
                    <button type="submit">로그인하기</button>
                    <button type="button" onclick="">회원가입</button>
                </tr>
            </table>
        </form>
    </div>
</body>
</html>