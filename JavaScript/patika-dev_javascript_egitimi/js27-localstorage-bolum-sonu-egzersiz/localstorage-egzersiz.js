// Local Storage Bölüm Sonu Egzersizi:


let counter=localStorage.getItem("counter") ? Number(localStorage.getItem("counter")) : 0
// ↑↑ Sayfa yenilendiğinde eğer yerel deoplamada counter bilgisi varsa onu al, yoksa 0 al.

let counterDOM=document.querySelector("#counter")
let incDOM=document.querySelector("#inc")
let decDOM=document.querySelector("#dec")

counterDOM.innerHTML=counter

incDOM.addEventListener("click", clickEvent)
decDOM.addEventListener("click", clickEvent)

function clickEvent(){
    this.id=="inc" ? counter+=1 : counter-=1
    localStorage.setItem("counter",counter)
    counterDOM.innerHTML=counter
}