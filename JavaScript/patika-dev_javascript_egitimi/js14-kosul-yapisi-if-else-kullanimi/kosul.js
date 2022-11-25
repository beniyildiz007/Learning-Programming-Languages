// Koşullarla Çalışmak:

let username=prompt("Kullanıcı Adınızı Giriniz:")

// eğer kullanıcı adı bilgisi varsa ekrana ismini yazdır
// eğer (username.length>0) {console.log(username)} değilse {console.log("Hiçbir bilgi girilmedi")}
// if (username.length>0) {console.log(username)} else {console.log("Hiçbir bilgi girilmedi")}

if(username){ // if tarafı her zaman true ile çalışır
    console.log(`Kullanıcı Bilginiz ${username}`)
} else{
    console.log("Hiçbir bilgi girilmedi!")
}