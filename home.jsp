<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>DroneToYou</title>
<link rel="stylesheet" href="resources/css/mainPage.css">
<script src="resources/js/mainPage.js"></script>
</head>

<body>
    <div class="main">
        <section id="photoVisual">
            <div class="bg">
                <div class="bgArea"></div>
                <div class="textArea">
                    <h3>Drone To You<br>
                        드론을 날려 하늘을<br>
                        날아보세요
                    </h3>
                    <div class="line"></div>
                    <p>
                        다양한 드론과 특별한 이야기가 함께하는<br>
                        Drone To You는 언제나 당신의 하늘을<br>
                        열 준비가 되어 있습니다.
                    </p>
                </div>
            </div>
        </section>
		<c:if test="${ccrs != null && sessionScope.loginMember.dm_id != null}">
	         <table class="tableDark">
		         <c:forEach var="ccrs" items="${ccrs}">
		            <table border="1" class="reqInTbl">
		               <tr>
		                  <td>드론 거래 요청이 있습니다.</td><td><button>X</button></td>
		               </tr>
		               <tr>
		                  <td>
		                     ${ccrs.dcr_writer}
		                  </td>
		                  <td>
		                     ${ccrs.dcr_txt}
		                  </td>
		               </tr>
		               <tr>
		                  <td><button>수락</button></td>
		                  <td><button>거절</button></td>
		               </tr>
		            </table>
		         </c:forEach>
	         </table>
	      </c:if>
        <section id="selling">
            <div>
                <div class="sellWarp">
                    <div class="title">
                        <h1>판매중인상품</h1>
                    </div>

                    <ul class="categories">
                        <li class="category toy">
                                <h2>완구용</h2>
                                <div class="icon">
                                    <img src="" alt="">
                                </div>
                        </li>

                        <li class="category racing">
                                <h2>경주용</h2>
                                <div class="icon">
                                </div>
                        </li>

                        <li class="category camera">
                                <h2>촬영용</h2>
                                <div class="icon">
                                    <img src="" alt="">
                                </div>
                        </li>
                    </ul>
                </div>
                <div class="contentWarp">
                    <div class="viewItems toyItem">
                        <ul>
                            <li>
                                <a href="productDetail.jsp" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/toy/toyDrone11.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="productDetail.jsp" class="item">
                                    <h2 class="name">DJI Neon</h2>
                                </a>
                            </li>

                            <li>
                                <a href="productDetail.jsp" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/toy/toyDrone5.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="productDetail.jsp" class="itemDes">
                                    <h2 class="name">토이비젼 키티호크 드론</h2>
                                </a>
                            </li>

                            <li>
                                <a href="productDetail.jsp" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/toy/toyDrone3.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="productDetail.jsp" class="item">
                                    <h2 class="name">DJI Mini2</h2>
                                </a>
                            </li>

                            <li>
                                <a href="productDetail.jsp" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/toy/toyDrone4.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="productDetail.jsp" class="item">
                                    <h2 class="name">Lobit 100C</h2>
                                </a>
                            </li>
                        </ul>
                    </div>

                    <div class="viewItems racingItem" style="display:none;">
                        <ul>
                            <li>
                                <a href="productDetail.jsp" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/racing/racingDrone1.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="" class="item">
                                    <h2 class="name">FPV Racing Drone </h2>
                                </a>
                            </li>

                            <li>
                                <a href="" class="item">
                                    <div class="itemImg">
                                       <img src="resources/img/droneImg/racing/racingDrone2.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="" class="item">
                                    <h2 class="name">TCMMRC TX 220</h2>
                                </a>
                            </li>

                            <li>
                                <a href="" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/racing/racingDrone3.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="" class="item">
                                    <h2 class="name">DIATONE MXC Taycan Duct 3</h2>
                                </a>
                            </li>

                            <li>
                                <a href="" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/racing/racingDrone4.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="" class="item">
                                    <h2 class="name">DJI FPV 드론</h2>
                                </a>
                            </li>
                        </ul>
                    </div>

                    <div class="viewItems cameraItem" style="display:none;">
                        <ul>
                            <li>
                                <a href="" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/camera/cameraDrone1.png" alt="상품">
                                    </div>
                                </a>

                                <a href="" class="item">
                                    <h2 class="name">DJI Phantom 4 RTK</h2>
                                </a>
                            </li>

                            <li>
                                <a href="" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/camera/cameraDrone2.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="" class="item">
                                    <h2 class="name">DJI Matrice 350 RTK</h2>
                                </a>
                            </li>

                            <li>
                                <a href="" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/camera/cameraDrone3.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="" class="item">
                                    <h2 class="name">DJI MATRICE 30T</h2>
                                </a>
                            </li>

                            <li>
                                <a href="" class="item">
                                    <div class="itemImg">
                                        <img src="resources/img/droneImg/camera/cameraDrone4.jpg" alt="상품">
                                    </div>
                                </a>

                                <a href="" class="item">
                                    <h2 class="name">DJI Mavic Air 2</h2>
                                </a>
                            </li>

                        </ul>
                    </div>
                </div>
            </div>
        </section>

        <section id="customDrone">
            <h2>커스텀드론</h2>
            <h4>자신만의 드론을 꿈꿔보세요</h4>
            <div class="customWrap">
                <div class="box">
                    <a href="">
                        <img src="resources/img/custome/drone1.jpg" alt="커스텀이미지">
                    </a>
                </div>
                <div class="box">
                    <a href="">
                        <img src="resources/img/custome/drone2.jpg" alt="커스텀이미지">
                    </a>
                </div>
                <div class="box">
                    <a href="">
                        <img src="resources/img/custome/drone3.jpg" alt="커스텀이미지">
                    </a>
                </div>
                <div class="box">
                    <a href="">
                        <img src="resources/img/custome/drone4.jpg" alt="커스텀이미지">
                    </a>
                </div>
            </div>
        </section>

        <section id="c2c">
            <div class="c2cBg"></div>
            <div class="c2cWrap">
                <div class="topTxt">
                    <h2>Customer to Customer</h2>
                    <h3>회원들간의 자유로운 거래를 경험해보세요</h3>
                </div>

                <div class="c2cImg">
                    <div><a href="#">다양한 드론 리뷰</a><img src="resources/img/c2c/droneReview.png" alt="c2c이미지"></div>
                    <div><a href="#">자유로운 거래</a><img src="resources/img/c2c/freeTrade.png" alt="c2c이미지"></div>
                    <div><a href="#">신뢰성있는 거래</a><img src="resources/img/c2c/trustDeal.png" alt="c2c이미지"></div>
                </div>
            </div>
        </section>

        <section id="announcement">
            <div class="announceWarp">
                <div class="topTxt">
                    <h2>공지사항</h2>
                    <p><a href="#">전체보기</a></p>
                </div>

                <div class="notice">
                    <div>
                        <a href="#">DJI 브랜드와 협업을 시작하게 되었습니다.</a>
                        <a href="#">2024-10-30</a>
                    </div>
                    <div>
                        <a href="#">신규 드론 입고</a>
                        <a href="#">2024-10-19</a>
                    </div>
                    <div>
                        <a href="#">대여 상품 관련하여 공지사항입니다.</a>
                        <a href="#">2024-10-07</a>
                    </div>
                    <div>
                        <a href="#">현재 재고부족으로 판매가 중단된 품목</a>
                        <a href="#">2024-10-01</a>
                    </div>
                    <div>
                        <a href="#">수수료 관련 변동사항</a>
                        <a href="#">2024-10-21</a>
                    </div>
                </div>
            </div>
        </section>

    </div>
</body>
</html>
