# index.html
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hello World</title>
</head>
<body>
    <h1>Frontend 101 Eğitimi - Hakan Yalçınkaya</h1>

    <h2 id="info"></h2>

    
    
    <ul id="userList">
        
    </ul>


    <script src="fetch-api.js"></script>

</body>
</html>
```
# fetch-api.js
```javascript
// fetch api ile çalışmak

// JSON dosyadan veri çekmek:
fetch("data/settings.json").then(
    response => response.json()
).then( responseJson => {
    console.log(responseJson)
    console.log(responseJson.userName)
})

let userListDOM = document.querySelector("#userList")

// API üzerinden veri çektik
fetch("https://jsonplaceholder.typicode.com/posts").then(
    response => response.json()
).then(responseJson => {
    responseJson.forEach(item => {
        let liDOM = document.createElement("li")
        liDOM.innerHTML = item.title // listenin içindeki her item'ın title değerini yazdırdık
        userListDOM.appendChild(liDOM)
    })
})



// JSON içindeki kodlar
// {
//     "userName": "fakeUser",
//     "password": 1234,
//     "serverIP": "127.0.0.1",
//     "serverName": "kodluyoruz.org",
//     "isAuth": true,
//     "IDs": [1,2,3,4,5]
// }

// Json içerisindeki değişkenler her zaman "" işaretleri arasında tanımlanır
// Json dosyasında yorum satırı bulundurulmaz!!
// Veriler alt alta sıralanırken mutlaka aralarına virgül koyulmalı
// En son veriden sonra virgül koyulmasına izin verilmez!!
```
