# index.html
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hello World</title>
    <script src="degisken-turu.js"></script>
</head>
<body>
    <h1>Frontend 101 Eğitimi - Hakan Yalçınkaya</h1>
</body>
</html>

```

# degisken-turu.js
```javascript
// Veri türünü öğrenmek için => typeof:
let price=111
let stringPrice="111"
let hasPassword=true

console.log("price: ",typeof(price)) // Output => Price: Number
console.log("stringPrice: ",typeof(stringPrice)) // Output => stringPrice: String
console.log("hasPassword: ",typeof(hasPassword)) // Output => hasPassword: Boolean

// string (metinsel) bilgileri int ve float (sayısal) verilere dönüştürmek:
// parseInt() ve parseFloat() sayı ile başlayan metinleri çevirir
let number1="11"
number1=parseInt(number1)
console.log("number1: ",number1, typeof(number1)) // doğru

let number2="11px"
number2=parseInt(number2)
console.log("number2: ",number2, typeof(number2)) // doğru

let number3="11.1px"
number3=parseFloat(number3)
console.log("number3: ",number3, typeof(number3)) // doğru


// Number() yalnızca sayıları metinden sayıya çevirir:
let number4="11px"
number4=Number(number4)
console.log("number4: ",number4, typeof(number4)) // YANLIŞ
let number5="11"
number5=Number(number5)
console.log("number5: ",number5, typeof(number5)) // DOĞRU


// Sayısal veri türünü string (metinsel) veri türüne çevirmek:
let number6=55
number5=number5.toString()
console.log(number5, typeof(number5))// Output => "'55' String"


```
