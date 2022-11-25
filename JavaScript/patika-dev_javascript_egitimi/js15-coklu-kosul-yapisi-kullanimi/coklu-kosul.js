// Çoklu Koşullar ile Çalışmak:

let userName=prompt("Kullanıcı Adınız: ")
let age=prompt("Yaşınız: ")

if(!userName){
    console.log("Kullanıcı adı girilmedi!")
}else if(!age){
    console.log("Yaş bilgisi girilmedi!")
}else{
    if(age>=18){
        console.log("Ehliyet alabilirsiniz.")
    }else{
        console.log("Biraz büyü evlat!")
    }
}