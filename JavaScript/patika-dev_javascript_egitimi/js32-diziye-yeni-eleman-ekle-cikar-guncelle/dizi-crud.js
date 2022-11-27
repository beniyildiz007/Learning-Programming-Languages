// Array yapısına öge eklemek ve Array içerisinden istenilen ögenin çıkarılması:

let items = [10,20,30,40,]
console.log("items - ilk hali: ", items)

// Array sona öge eklemek => push
items.push(50)
console.log("50: ", items) // Output => 10,20,30,40,50

// Array başa öge eklemek => unshift
items.unshift(5)
console.log("5: ", items) // Output => 5,10,20,30,40,50

// Array sonraki ögeyi çıkarmak => pop
let lastItem = items.pop() // son elemanı lastItem içerisine ekledik
console.log("lastItem: ", lastItem, ", items: ", items)

// Array: baştaki ögeyi çıkarmak => shift
let firstItem = items.shift() // ilk elemanı firstItem içerisine ekledik
console.log("firstItem: ",firstItem,", items: ", items)

// ARRAY İÇİNDEKİ ÖGENİN DEĞİŞTİRİLMESİ

// ilk ögenin değiştirilmesi:
items[0] = 7;
console.log(items)

// Sonuncu ögenin değiştirilmesi:
items[items.length - 1] = 1000
console.log(items)

items[10000] = 10000 // hata almadık fakat ortada kalan 9996 tane boş yerimiz meydana geldi!
console.log(items)
