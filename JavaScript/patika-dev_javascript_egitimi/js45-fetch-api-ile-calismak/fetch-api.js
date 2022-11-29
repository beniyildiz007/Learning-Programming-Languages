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