// array - dizilerle çalışmak

// Array oluşturmak:
let domain="kodluyoruz"
let isActive=false
let items=[15,25,35,isActive,domain]
console.log(items)

let emptyArray=[] // Boş liste

// Array içerisindeki eleman/öge sayısını öğrenmek:
console.log(
    items.length // array içindeki öge sayısı
)

// document.querySelector("#info").innerHTML=items.length

// Array içindeki ilk elemanın çağırılması:
console.log(items[0])

// Array içindeki son elemanın çağırılması:
console.log(items[items.length - 1]) // console.log(items[4])

// Array içindeki ortada olan elemanı çağırmak:
console.log(
    "ortadaki: ",
    items[Math.floor(items.length / 2)]
)

// Değişken içindeki bilginin Array olup olmadığının kontrol edilmesi:
console.log(
    typeof(items) // Output => object
)

console.log(
    Array.isArray(items) // Output => true
)

// Hangileri isArray => True verir?

console.log("[]: ", Array.isArray([])) // Output => true
console.log("1: ", Array.isArray(1)) // Output => false
console.log("true: ", Array.isArray(true)) // Output => false