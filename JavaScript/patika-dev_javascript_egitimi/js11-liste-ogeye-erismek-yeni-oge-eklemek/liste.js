// Liste içerisindeki son elemana ulaşmak veya listeye eleman eklemek:

// Liste içerisindeki elemanları değiştirmek:
let lastChild=document.querySelector("ul#list>li:last-child")
lastChild.innerHTML="<b>son öge değiştirildi!</b>"

let firstChild=document.querySelector("ul#list>li:first-child")
firstChild.innerHTML="<i>ilk öge değiştirildi!</i>"


// Listeye eleman eklemek:
let ulDOM=document.querySelector("ul#list")
let liDOM=document.createElement("li")

liDOM.innerHTML="<span style='color:red;'>Kendi oluşturduğumuz öge!</span>" // Henüz eklenmedi, sadece oluşturuldu!

// ulDOM.append(liDOM) // en sona ekler
ulDOM.prepend(liDOM) // ilk başa ekler
