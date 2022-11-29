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




    <script src="try-catch.js"></script>

</body>
</html>
```
# try-catch.js
```javascript
// hata yönetimi için try catch kullanımı

let products;

try{
    products.forEach(item => console.log(item));
} catch(hataaa){
    console.log("Kodun içine ettin bak!")
    products = [1,2,3]
    products.forEach(item => console.log(item));
}

console.log("hata ytönetimi düzgün çalışıyor")

let info = "kodluyoruz"
console.log(info)
```
