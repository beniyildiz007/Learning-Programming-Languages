// Object Key - Value:

let laptop1 = {
    brand: "Apple",
    model: "MacBook Pro",
    modelName: "MacBook Pro",
}

console.log(laptop1)

// Doğru anahtar bilgisi oluşturmak
console.log(laptop1.brand, laptop1["brand"]) // ikisi de aynı işlevi görür
console.log(laptop1.model, laptop1["model"])

// Anahtar bilgisine yeni değer eklemek
laptop1.brand = "Mac"
laptop1["brand"] = "Mac1"
console.log(laptop1)

// Yeni bilgi eklemek
laptop1.version = "10.15.7"
console.log(laptop1)

// Anahtar bilgilerine ulaşmak (keys) => Object.keys(item)
keys = Object.keys(laptop1)
console.log(keys)
console.log(Object.keys(laptop1))

keys.forEach(keyInfo => {
    console.log(keyInfo)
    console.log(laptop1[keyInfo])
})

// Değer bilgilerine ulaşmak (values) => Object.values(item)
console.log(
    Object.values(laptop1)
)

let values = Object.values(laptop1)

values.forEach(value => {
    console.log("value: ", value)
})