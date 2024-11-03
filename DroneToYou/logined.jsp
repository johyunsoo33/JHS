<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>DroneToYou</title>
</head>
<body>

                        <div class="logined">
                            <form action="">
                                <table id="loginedTb">
                                    <tbody>
                                        <tr>
                                            <td align="center" rowspan="2">
                                                <img alt="" src="IMG/ex_IMG.jpg">
                                            </td>
                                            <td>${}님 안녕하세요</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <button onclick="logOut();">로그아웃</button>
                                                <button onclick="memberInfoGo();">회원정보</button>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </form>
                        </div>
</body>
</html>