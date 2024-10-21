<?php
// 데이터베이스 연결
$servername = "localhost";
$username = "your_username";
$password = "your_password";
$dbname = "your_database";

// MySQL 연결
$conn = new mysqli($servername, $username, $password, $dbname);

// 연결 확인
if ($conn->connect_error) {
    die("연결 실패: " . $conn->connect_error);
}

// SQL 쿼리 실행
$sql = "SELECT image_name FROM images WHERE category = '펜'";
$result = $conn->query($sql);

$image_paths = array();

// 쿼리 결과를 배열로 저장
while($row = $result->fetch_assoc()) {
    $image_paths[] = $row['image_name'];
}

// JSON 형식으로 출력
header('Content-Type: application/json');
echo json_encode($image_paths);

// 연결 종료
$conn->close();