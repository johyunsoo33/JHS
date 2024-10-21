// API 키와 URL 설정
 // 실제 API 키로 교체
//const url = `http://api.kcisa.kr/openapi/CNV_060/request?serviceKey=98b3cfa8-f7c5-469a-97e2-ba00ef9c6fe0 &numOfRows=10&pageNo=1`;
//var xhr = new XMLHttpRequest();
//var url = 'http://localhost:3000/proxy';  // 프록시 서버를 통해 API 요청을 우회
//var queryParams = '?' + encodeURIComponent('serviceKey') + '=' + '98b3cfa8-f7c5-469a-97e2-ba00ef9c6fe0';  // 실제 API 키로 교체
//queryParams += '&' + encodeURIComponent('numOfRows') + '=' + encodeURIComponent('10');
//queryParams += '&' + encodeURIComponent('pageNo') + '=' + encodeURIComponent('1');

//xhr.open('GET', url + queryParams);
//xhr.onreadystatechange = function () {
   // if (this.readyState == 4) {
       // if (this.status === 200) {
           // console.log('status: ' + this.status);
           // var xml = this.responseText;
           // console.log('XML Response:', xml);

          //  var parser = new DOMParser();
           // var xmlDoc = parser.parseFromString(xml, "text/xml");

           // var items = xmlDoc.getElementsByTagName("item");
           // for (var i = 0; i < items.length; i++) {
                //if (i >= document.querySelectorAll('.musical-item').length) break;  // Ensure we don't exceed the number of musical items in the HTML

                //var title = items[i].getElementsByTagName("title")[0].childNodes[0].nodeValue;
               // var imageObject = items[i].getElementsByTagName("imageObject")[0].childNodes[0].nodeValue;

               // var item = document.querySelectorAll('.musical-item')[i];
             //   item.querySelector('.musical-image').src = imageObject;
           //     item.querySelector('.musical-title').innerText = title;
         //   }
       // } else {
      //      console.error('Error fetching data:', this.statusText);
    //    }
 //   }
//}
//xhr.send('');

// API 키와 URL 설정
const apiKey = 'b%2FxpQMqcdBmLrm64LrJf%2BY1dD5zp7P7nJtBhwy5tsbYgMoa0i%2Fan1V0sjVknkQwOVcCF2jSFumd9JP5haMq5sg%3D%3D';  // Encoded API 키
const url = `http://apis.data.go.kr/6260000/BusanCultureMusicalDetailService/getMusicalDetail?serviceKey=${apiKey}&numOfRows=10&pageNo=1&_type=json`;

// API 호출
fetch(url)
    .then(response => {
        if (!response.ok) {
            throw new Error('Network response was not ok ' + response.statusText);
        }
        return response.json();  // JSON 형식의 응답을 기대
    })
    .then(data => {
        console.log(data);  // 데이터 확인

        const extractedData = data.getMusicalDetail.item.map(item => ({
            title: item.title
        }));

        // 추출한 데이터 적용
        applyMusicalData(extractedData);
    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
        document.getElementById('data').innerText = 'Error: ' + error;
    });

function applyMusicalData(data) {
    const musicalItems = document.querySelectorAll('.musical-item');
    if (musicalItems.length === 0) {
        console.error('No musical items found in the DOM');
        return;
    }

    musicalItems.forEach((item, index) => {
        if (data[index]) {
            const title = item.querySelector('.musical-title');
            if (title) {
                title.innerText = data[index].title;
            } else {
                console.error('title element not found within musical-item');
            }
        }
    });
}
