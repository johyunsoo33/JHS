<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>DroneToYou</title>
    <link rel="stylesheet" href="resources/css/nav.css">
    <link rel="stylesheet" href="resources/css/login.css">
    <link rel="stylesheet" href="resources/css/reset.css">
    <link rel="stylesheet" href="resources/css/productDetail.css">
    <script src="resources/js/mainPage.js"></script>
    <script src="resources/js/review.js"></script>
    <script src="resources/js/productDetail.js"></script>
</head>

<body>
    <section id="dtyMenu">
        <div class="menu">
            <menu class="mBottom">
                <div class="conWrap">
                    <div class="logo">
                        <a href="index.html"><img src="resources/img/droneLogo.png" alt=""></a>
					</div>

                    <div class="navWrap">
                        <div class="innerNav">
                            <nav>
                                <ul>
                                    <li class="menuDetail"><a href="#">상품</a>
                                        <ul class="hiddenMenu">
                                            <li><a href="product.html">판매</a></li>
                                            <li><a href="product.html">대여</a></li>
                                        </ul>
                                    </li>

                                    <li class="menuDetail"><a href="#">커스텀드론</a>
                                        <ul class="hiddenMenu">
                                            <li><a href="#">커스텀제작</a></li>
                                        </ul>
                                    </li>

                                    <li class="menuDetail"><a href="#">C2C</a>
                                        <ul class="hiddenMenu">
                                            <li><a href="#">게시판</a></li>
                                        </ul>
                                    </li>

                                    <li class="menuDetail"><a href="#">고객센터</a>
                                        <ul class="hiddenMenu">
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
                            <a href="#"><img src="resources/img/shoppingCart.png" alt=""></a>
                        </div>
                        <table class="loginTable">
                            <form action="login.do" method="post" name="loginForm" onsubmit="">
                                <tbody>
                                    <tr>
                                        <td><i class="id_icon"></i><input type="text" placeholder="Username" name="dm_id"></td>
                                    </tr>

                                    <tr>
                                        <td><i class="pw_icon"> </i> <input type="password" placeholder="Password" name="dm_pw"></td>
                                    </tr>
                                </tbody>
                                <tr>
                                    <td>
                                        <button type="submit">로그인</button>
                                    </td>
                                </tr>
                            </form>
                            <tr>
                                <td>
                                    <button type="button" onclick="joinGo();">회원가입</button>
                                </td>
                            </tr>
                        </table>

                    </div>

                </div>
            </menu>
        </div>
    </section>

    <div class="detailMain">
        <div class="detailPhoto">
            <div class="detailBg">
                <div class="detailBgArea"></div>
                <div class="detailTextArea">
                    <p>제품 상세보기</p>
                    <span></span>
                    <p>드론의 모든 정보를 확인하고 구매를 결정하세요.</p>
                </div>
            </div>
        </div>

        <div class="droneInfoArea">
            <div class="detailTop">
                <div class="droneImg">
                    <img src="resources/img/droneImg/toy/toyDrone11.jpg" alt="대표이미지" class="productMainImg">
                    <ul>
                        <li><img src="resources/img/droneImg/toy/toyDrone11_1.jpg" alt="서브이미지"></li>
                        <li><img src="resources/img/droneImg/toy/toyDrone11_2.jpg" alt="서브이미지"></li>
                        <li><img src="resources/img/droneImg/toy/toyDrone11_3.jpg" alt="서브이미지"></li>
                        <li><img src="resources/img/droneImg/toy/toyDrone11_4.jpg" alt="서브이미지"></li>
                    </ul>
                </div>

                <div class="droneInfo">
                    <h2>DJI Neon</h2>

                    <p>초보자도 쉽게 활동하는 스마트 드론</p>

                    <p>249,000원</p>

                    <p>
                        배송비:<i>3,000</i>
                    </p>
                    <p>
                        배송기간:<i>3 ~ 5일</i>
                    </p>
                    <button class="cartBtn">장바구니 담기</button>
                    <button class="buyBtn">바로구매</button>
                </div>
            </div>

            <div class="detailBottom">
                <ul class="tabTitle">
                    <li class="active"><a href="#" onclick="moveClass('droneDetail'); return false;">제품상세</a></li>
                    <li><a href="#" onclick="moveClass('productReview'); return false;">제품리뷰</a></li>
                    <li><a href="#" onclick="moveClass('productQnA'); return false;">제품문의</a></li>
                    <li><a href="#" onclick="moveClass('productRecom'); return false;">추천상품</a></li>
                </ul>

                <div class="tabCons">
                    <div class="droneDetail">
                        <div class="conWrap">
                            <div class="imgSpace">
                                <div>
                                    <img src="resources/img/promotion/promotion1.png" alt="">

                                </div>
                            </div>
                            <div class="text">
                            	<p>AI 피사체 추적 기능으로 주인공 등극</p>
                                <p>DJI Neo는 사용자가 사이클링, 스케이트보드, 하이킹 등 어떤 <br> 
                                   활동을 하든지 프레임 안에 완벽하게 유지하며 속도에 맞춰 <br>
                                   추적하며 멋진 장면을 쉽게 촬영할 수 있습니다</p>
                            </div>

                            <div class="imgSpace">
                                <div>
                                    <img src="resources/img/promotion/promotion2.png" alt="">
                                </div>
                            </div>
                            <div class="text">
                            	<p>장거리 RC 제어를 통한 끊김없는 조종</p>
                                <p>RC-N3, RC-N2, RC 2를 사용할 경우, DJI Neo는 최대 10km 동 <br> 
                                   영상 전송 거리를 지원합니다. 기존 RC 조종 스틱을 사용하면 <br> 
                                   프로급 장면을 촬영할 수도 있죠.</p>
                            </div>

                            <div class="imgSpace">
                                <div>
                                    <img src="resources/img/promotion/promotion4.png" alt="">
                                    <img src="resources/img/promotion/promotion5.png" alt="">
                                </div>
                            </div>
                            <div class="text">
                            	<p>주머니에 넣고 돌아다닐수 있는 탁월한 휴대성 </p>
                                <p>손바닥 이륙 & 착륙이 가능할 정도의 작은 사이즈 <br> 
                                   135g의 가벼운 무게 & 주머니 속에도 보관이 되는 높은 휴대성</p>
                            </div>
                            
                             <div class="imgSpace">
                                <div>
                                    <img src="resources/img/promotion/promotion6.png" alt="">
                                </div>
                            </div>
                            <div class="text">
                            	<p>360도 보호되는 프로펠러 가드 </p>
                                <p>풀 커버 프로펠러 가드로 걱정없이 <br> 
                                   어린아이들 초보자들도 사용하면서 이용이 가능합니다</p>
                            </div>
                        </div>
                    </div>

                    <div class="productReview">
                        <div class="conWrap">
                            <h3>상품평</h3>

                            <form action="" class="reviewForm">
                                <table class="reviewWrite">
                                    <tr>
                                        <td>
                                            <label for="userImg"><img alt="" src="resources/img/${sessionScope.loginMember.dm_photo }"></label>
                                        </td>

                                        <td>
                                            <label for="userId">${sessionScope.loginMember.dm_id }킹캉콩</label>
                                        </td>
                                    </tr>

                                    <tr class="star">
                                        <td>
                                            <select class="starPoint">
                                                <option>☆☆☆☆☆</option>
                                                <option>★☆☆☆☆</option>
                                                <option>★★☆☆☆</option>
                                                <option>★★★☆☆</option>
                                                <option>★★★★☆</option>
                                                <option>★★★★★</option>
                                            </select>
                                        </td>
                                    </tr>

                                    <tr class="reviewCon">
                                        <td>
                                        </td>
                                    </tr>
                                    <tr class="reviewText">
                                        <td>
                                            <!--<input type="text" placeholder="리뷰를 작성해주세요" name="">-->
                                            <textarea name="dm_review" placeholder="리뷰를 작성해주세요"></textarea>
                                        </td>
                                    </tr>
                                    <tr class="reviewPhoto">
                                        <td>
                                            <label for="reviewImg">파일 선택하기</label>
                                            <input name="" type="file" id="reviewImg" placeholder="사진첨부하기">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <button type="submit" class="reviewSub">완료</button>
                                        </td>
                                    </tr>
                                </table>
                            </form>

                            <table class="reviewOutput">
                                <caption style="text-align: left; font-size: 23px; font-weight: bold; padding-bottom: 20px; padding-top: 20px;">작성된 리뷰들</caption>
                                <tr>
                                    <td>

                                    </td>
                                </tr>
                            </table>

                        </div>
                    </div>


                    <div class="productQnA">
                        <div class="conWrap">
                            <table>
                                <tr>
                                    <h3>자주묻는 문의</h3>
                                </tr>
                                <tr class="qnA">
                                    <td><em class="question">질문</em> 드론은 안전하게 배달이 되나요?</td>
                                    <td><i><img src="resources/img/answer.png" alt=""></i>
                                        <em class="answer">답변</em> 드론은 충격흡수재질로 포장하여서 안전하게 배송이 진행됩니다.
                                    </td>
                                </tr>

                                <tr class="qnA">
                                    <td><em class="question">질문</em>이 사이트에서 파는 드론은 정품 인증이 되어있는건가요?</td>
                                    <td><i><img src="resources/img/answer.png" alt=""></i>
                                        <em class="answer">답변</em>네 저희 DroneToYou에서 구매 혹은 대여하는 드론은 모두 정품인증서를 동봉해서 드립니다.
                                    </td>
                                </tr>

                                <tr class="qnA">
                                    <td><em class="question">질문</em>환불은 어떻게 진행되나요??</td>
                                    <td><i><img src="resources/img/answer.png" alt=""></i>
                                        <em class="answer">답변</em>저희에게 전화로 환불을 요청하시면 3일이내에 직원이 찾아가서 직접 수령하여 환불이 진행됩니다.
                                    </td>
                                </tr>

                                <tr class="qnA">
                                    <td><em class="question">질문</em>A/S를 받고싶은데 어디에 문의하면 될까요?</td>
                                    <td><i><img src="resources/img/answer.png" alt=""></i>
                                        <em class="answer">답변</em>A/S문의는 저희 DroneToYou에서는 별도로 진행하지 않습니다.
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>

                    <div class="productRecom">
                        <div class="conWrap">
                            <h3>추천상품</h3>
                            <ul class="recomList">
                                <li>
                                    <a href="#">
                                        <img src="resources/img/droneImg/toy/toyDrone10.png" alt="">
                                        <p>DTY Mini 1</p>
                                        <p>₩49,000</p>
                                        <p></p>
                                    </a>
                                </li>

                                <li>
                                    <a href="#">
                                        <img src="resources/img/droneImg/toy/toyDrone4.jpg" alt="">
                                        <p>Lobit 100C</p>
                                        <p>₩69,000</p>
                                        <p></p>
                                    </a>
                                </li>

                                <li>
                                    <a href="#">
                                        <img src="resources/img/droneImg/toy/toyDrone10_3.png" alt="">
                                        <p>DTY Mini 1 Blue</p>
                                        <p>₩49,000</p>
                                        <p></p>
                                    </a>
                                </li>	

                                <li>
                                    <a href="#">
                                        <img src="resources/img/droneImg/toy/toyDrone8.jpg" alt="">
                                        <p>ATO-T 미니드론</p>
                                        <p>₩35,840</p>
                                        <p></p>
                                    </a>
                                </li>

                                <li>
                                    <a href="#">
                                        <img src="resources/img/droneImg/toy/toyDrone2.jpg" alt="">
                                        <p>DJI Tello</p>
                                        <p>₩151,740</p>
                                        <p></p>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</body>

</html>