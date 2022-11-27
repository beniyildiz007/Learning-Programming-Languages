// Form Submit:

let formDOM = document.querySelector("#userForm")
formDOM.addEventListener("submit",formSubmit)

function formSubmit(event){
    event.preventDefault() // Yazının göründükten sonra silinmemesini sağlıyor
    console.log("işlem gerçekleşti")
}