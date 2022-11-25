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




    <script src="fonksiyon.js"></script>

</body>
</html>

```

# fonksiyon.js

```javascript

// İlk fonksiyonumuzu tanımlamak:

function helloWorld(){ // fonksiyon tanımlandı
    console.log("Hello World")
}

function hello(){
    console.log("Merhaba")
    helloWorld() // fonksiyon içerisinde bir başka fonksiyon çağırılabilir
}

hello() // Fonksiyonu çalıştırmak için çağırmamız gerekir

```
