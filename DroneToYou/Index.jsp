<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<!DOCTYPE html>
<html lang="ko">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>DroneToYou</title>
    <link rel="stylesheet" href="CSS/reset.css">
    <link rel="stylesheet" href="CSS/MainPage.css">
</head>

<body>
    <section id="DTY_menu">
        <div class="Menu">
            <menu class="m_bottom">
                <div class="conwrap">
                    <div class="logo">
                        <a href="index.html"><img src="IMG/DroneLogo.png" alt=""></a>
                    </div>

                    <div class="nav_wrap">
                        <div class="inner_nav">
                            <nav>
                                <ul>
                                    <li class="menu_detail">
                                        <a href="#">상품</a>
                                        <ul class="hidden_menu">
                                            <li><a href="Company_info.html">판매</a></li>
                                            <li><a href="Company_history.html">대여</a></li>
                                        </ul>
                                    </li>

                                    <li class="menu_detail">
                                        <a href="#">커스텀드론</a>
                                        <ul class="hidden_menu">
                                            <li><a href="#">커스텀제작</a></li>
                                        </ul>
                                    </li>

                                    <li class="menu_detail">
                                        <a href="#">C2C</a>
                                        <ul class="hidden_menu">
                                            <li><a href="#">게시판</a></li>
                                        </ul>
                                    </li>

                                    <li class="menu_detail">
                                        <a href="#">고객센터</a>
                                        <ul class="hidden_menu">
                                            <li><a href="#">부품문의</a></li>
                                            <li><a href="#">기타문의</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </nav>
                        </div>

                    </div>
                    <div class="right">
                        <div class="cart">
                            <a href="#"><img src="IMG/shopping_cart.png" alt=""></a>
                        </div>

                        <div class="bf_login">
                            <h3>로그인</h3>
                                <table>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <jsp:include page="${loginPage}"></jsp:include>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                        </div>

                    </div>

                </div>
            </menu>
        </div>
    </section>

    <main>
     <jsp:include page="${home}"></jsp:include>
    </main>

    <footer>
        <p>만든이:이호준/조현수/김윤희/조상훈/이상민/소현수/정의천</p>
    </footer>

    <script src="./JS/MainPage.js">
    </script>
</body>


</html>