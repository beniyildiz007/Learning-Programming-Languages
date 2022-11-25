// Fonksiyonlara parametreler atamak ve fonksiyondan geri dönüş almak:

/* Temel Kurallar:
1-) Bir fonksiyon bir veya birden fazla parametre alabilir ya da hiç almayabilir
2-) Bir fonksiyon dışarı bilgi gönderebilir (return) veya göndermeyebilir
3-) Mümkünse fonksiyonun bağımlılıklarını azaltmak gerekir
*/

let firstName="Lorem"

function greetings(firstName="", lastName=""){ // default parametre alıyor
    // console.log(`Merhaba ${firstName ? firstName : ""}`)
    // console.log(`Merhaba ${firstName}`)
    console.log(`Merhaba ${firstName} ${lastName}`) // Output => Merhaba
}

console.log(firstName) // Output => Lorem
greetings() // fonksiyona parametre göndermedik
greetings("Parametre") // Output => Merhaba Parametre

function greetings2(firstName, lastName){
    let info = `Merhaba ${firstName} ${lastName}`
    return info
}

let greetingsInfo = greetings2("Ad","Soyad")
console.log(greetingsInfo) // Output => Merhaba Ad Soyad

function domIdWriteInfo(id,info){
    let domObject=document.querySelector(`#${id}`)
    domObject.innerHTML=info
    return info
}

let htmlInfo=`<span style="color:red;">Color REDDDDD</span>`
domIdWriteInfo("greeting",htmlInfo)
domIdWriteInfo("info",greetings2("lorem","Ipsum"))