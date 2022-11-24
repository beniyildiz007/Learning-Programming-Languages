// DOM içinden öge seçimi

let title = document.getElementById("title")
title.innerHTML="Değişen Bilgi" // 'Merhaba Dünya' yazısını değiştirdik
console.log(title.innerHTML)

let link=document.querySelector("#kodluyoruzLink")
link.innerHTML+=" değişti" // linkin yazısına ekleme yaptık
link.style.color="red" // linkin rengini kırmızı yaptık
link.classList.add("btn") // linki btn class'ına ekledik