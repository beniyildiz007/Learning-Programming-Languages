// Ternary operator ile short if kullanımı:

// Eğer kullanıcı adın varsa yazdır yoksa 'kullanıcı bilginiz bulunamadı' yazsın

let userName=prompt("Kullanıcı adınızı giriniz:")
let info=document.querySelector("#info")

// ternary kullanımı:
// koşul ? doğruysa : yanlışsa

// userName ? userName : "Kullanıcı Bilginiz Bulunamadı!"

info.innerHTML=`${userName ? userName : "Kullanıcı Bilginiz Bulunamadı! :/"}`