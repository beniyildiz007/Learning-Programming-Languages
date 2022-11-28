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




    <script src="while.js"></script>

</body>
</html>
```
# while.js
```javascript
// While döngüsü

let counter = 0;
while (counter<10){
    console.log(counter)
    counter ++ // 0-9 arası sayıları yazdırır
}

let userName=""
while (!userName){
    userName = prompt("Kullanıcı adınızı giriniz:")
    console.log(userName) // kutucuk boşken sürekli kullanıcı adı sorar
}
```
