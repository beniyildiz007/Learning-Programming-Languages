// While döngüsü

let counter = 0;
while (counter<10){
    console.log(counter)
    counter ++ // 0-9 arası sayıları yazdırır
}

let userName=""
while (!userName){
    userName = prompt("Kullanıcı adınızı giriniz:")
    console.log(userName) // kutucuk boşken sürekli kullanıcı adı sorar
}