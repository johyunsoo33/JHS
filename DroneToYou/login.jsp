<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>DroneToYou</title>

</head>
<body>
          <div class="login">
                            <form action="login.do" method="post" name="loginForm" onsubmit="" class="loginTable">
                                <table>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <i class="id_icon"></i>
                                                <input type="text" placeholder="Username" name="dm_id">
                                            </td>
                                        </tr>

                                        <tr>
                                            <td>
                                                <i class="pw_icon"> </i>
                                                <input type="password" placeholder="Password" name="dm_pw">
                                            </td>
                                        </tr>

                                    </tbody>
                                </table>
                                <button type="submit">로그인</button>
                                <button type="button" onclick="joinGo();">회원가입</button>
                            </form>
                        </div>
</body>
</html>