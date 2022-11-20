// 0 ve 1'i Anlamak:
let isActive=false // 0
isActive=true // 1
console.log(isActive) // Output => true

// İçinde veri olmayan değişkenler "false" değerini döner:
let userName;
let isUserName=Boolean(userName)
console.log(isUserName) // Output => false

Boolean("11") // true
Boolean("0") // true
Boolean("") // false

userName="user";
console.log("User Name: ", Boolean(userName)) // Output => User Name: True

// Boolean karar yapısı:
Boolean(userName.length>0) // Output => true


// 0, -0, null, false, NaN, undefined, (""):
Boolean(0) // false
Boolean(-0) // false
Boolean(-0.1) // true
Boolean(0 === 0) // true (0 sayısı 0 sayısına eşit mi?)
Boolean(0 === 1) // false (0 sayısı 1 sayısına eşit mi?)

