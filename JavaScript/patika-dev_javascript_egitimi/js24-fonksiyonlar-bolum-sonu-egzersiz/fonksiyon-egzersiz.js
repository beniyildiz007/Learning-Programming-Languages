// Functions Bölüm Sonu Egzersizi

let counter = 0
let counterDOM = document.querySelector("#counter")
let incDOM = document.querySelector("#inc")
let decDOM = document.querySelector("#dec")

counterDOM.innerHTML=counter

incDOM.addEventListener("click", clickEvent)
decDOM.addEventListener("click", clickEvent)

function clickEvent(){
    console.log(this.id)
    this.id=="inc" ? counterDOM.innerHTML = counter+=1 : counterDOM.innerHTML = counter-=1

}