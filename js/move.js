function joinGo() {
	location.href="join.go";
}

function logOut() {
	var really = confirm("로그아웃하시겠습니까?");
	if (really) {
		location.href = "logout.do";		
	}
}

function memberInfoGo() {
	location.href="member.info.go";
}

function bye() {
	var really = confirm("탈퇴하시겠습니까?");
	if (really) {
		location.href = "member.bye.do";	
	}
}