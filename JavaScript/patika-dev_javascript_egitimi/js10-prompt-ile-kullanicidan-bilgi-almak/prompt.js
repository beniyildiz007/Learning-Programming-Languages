// Promt ile kullanıcıdan bilgi almak:

let fullName=prompt("Lütfen Adınızı Giriniz: ")

let greeting=document.querySelector("#greeting")

greeting.innerHTML=`${greeting.innerHTML} <span style="color:red;">${fullName}</span>`