// Çok kullanılan dizi metotları ve Array içinde Array

let items=[1,2,3,4,5]

// Array içinde Array:
let femaleUsers=["Ayşe","Hülya","Merve"]
let maleUsers=["Ahmet","Hasan","Mehmet"]

items.unshift(femaleUsers)
items.push(maleUsers)

console.log(items)

console.log(items.length)
console.log(items[0].length) // Array içindeki array'in eleman sayısı
console.log(items[0][0]) // Ayşe bilgisine ulaştık

// Array içerisindeki ögeleri ayırmak => splice(pos, item?)
let newItems = items.splice(1,5) // 1. index'ten başlasın 5 eleman yazsın

console.log("newItems: ", newItems)
console.log("items: ", items)

// Array içerisindeki ögenin index bilgisini bulmak => indexOf("value")
items.unshift("lorem") // Başına lorem ekledik
items.push("ipsum") // Sonuna ipsum ekledik

console.log(items.indexOf("ipsum")) // ipsum'un index numarasını verir

// Array kopyalamak => slice, [...ES6]
let copyItems = items
console.log(items)

copyItems.pop() // son ögeyi çıkarttık
console.log("copyItems", copyItems)
console.log("items", items)

console.log("kopyalandıktan sonraki hali: ")
copyItems = items.slice() // kopyalama yaptık
copyItems.pop() // son ögeyi çıkarttık
console.log("copyItems", copyItems)
console.log("items", items)

let es6Items = [...items] // ES6 ve sonrasında gelen kopyalama işlemi
console.log(es6Items)

// İki array bilgisini birleştirmek => [...ES6, ...ES6]
let allUsers = [...femaleUsers, ...maleUsers] // es6 birden fazla array yapısını birleştirmek
console.log(allUsers)

// Array içerisindeki bilgiyi String'e çevirmek => toString, join
console.log(allUsers.toString())
console.log(allUsers.join(" --- ")) // elemanlar arasına --- koyar

// İstediğimiz index bilgisine öge eklemek => splice(index, 0 , value)
allUsers.splice(allUsers.lengt-1, 0, "Melissssa")
allUsers.splice(Math.floor(allUsers.length / 2), 0, "Lorem")
console.log(allUsers)
