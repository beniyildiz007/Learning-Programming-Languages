# index.html
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hello World</title>
</head>
<body>
    <h1>Frontend 101 Eğitimi - Hakan Yalçınkaya</h1>

    <h2 id="info"></h2>




    <script src="key-value-yapisi.js"></script>

</body>
</html>
```
# key-value-yapisi.js
```javascript
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
```
