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




    <script src="dizi-crud.js"></script>

</body>
</html>

```
# dizi-crud.js
```javascript

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


```
