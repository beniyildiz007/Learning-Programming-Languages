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



    <script src="mantiksal.js"></script>

</body>
</html>

```

# mantiksal.js

```javascript

// Karşılaştırma Operatörleri ve Mantıksal Operatörler:

 
let price="1"
let user="berkan"

// Eşitse (==):
console.log("==: ",price==1) // True
console.log("==: ",price==100) // False

// Hem değeri hem de türü eşitse (===):
console.log("===: ",price===1) // False
console.log("===: ",price===100) // False
console.log("===: ",price="1") // True

// Eşit değilse (!=)
console.log(user!="guest") // True

// Küçükse (<)
console.log("price < 100: ",price<100) // True

// Küçük veya eşitse (<=)
console.log("price <= 100: ", price<=100) // True

// Büyükse (>)
console.log("price > 100: ", price>200) // False

// Büyükse veya eşitse (>=)
console.log("price >= 100: ", price>=200) // False

// Ve (&&)
price=0
console.log(price>0 && user!="guest") // False

// Veya (||)
console.log(price>0 || user!="guest") // True

// Değil (!)
user="guest"
price=1
console.log(price>0 && !user=="guest") // False
console.log(price>0 && user=="guest") // True


```
